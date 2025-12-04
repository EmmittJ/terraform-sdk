// Licensed under the MIT License.

#pragma warning disable ASPIREPIPELINES001

using System.Text.Json;
using System.Text.Json.Serialization;
using Aspire.Hosting.Pipelines;
using Aspire.Hosting.Publishing;
using Microsoft.Extensions.Logging;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Provides methods for running Terraform CLI commands and parsing output.
/// </summary>
internal static class TerraformCli
{
    /// <summary>
    /// Runs a Terraform command in the specified working directory.
    /// </summary>
    /// <param name="context">The pipeline step context.</param>
    /// <param name="command">The Terraform command to run (e.g., "init -input=false").</param>
    /// <param name="workingDirectory">The working directory for the command.</param>
    /// <param name="sensitiveEnvironmentVariables">Optional dictionary of sensitive variables to pass as TF_VAR_* environment variables.</param>
    /// <param name="logOutput">Whether to log the command output at Information level. When <c>false</c>, output is logged at Debug level.</param>
    /// <returns>The standard output from the command.</returns>
    /// <exception cref="InvalidOperationException">Thrown when the command fails.</exception>
    public static async Task<string> RunCommandAsync(
        PipelineStepContext context,
        string command,
        string workingDirectory,
        Dictionary<string, string>? sensitiveEnvironmentVariables = null,
        bool logOutput = false)
    {
        if (!Directory.Exists(workingDirectory))
        {
            Directory.CreateDirectory(workingDirectory);
        }

        context.Logger.LogDebug("Running terraform {Command} in {Path}", command, workingDirectory);

        await context.ReportingStep.CompleteAsync(
            $"Running terraform {command}",
            CompletionState.InProgress,
            context.CancellationToken).ConfigureAwait(false);

        var processStartInfo = new System.Diagnostics.ProcessStartInfo
        {
            FileName = "terraform",
            Arguments = command,
            WorkingDirectory = workingDirectory,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true,
            Environment = { ["TF_IN_AUTOMATION"] = "true" }
        };

        // Add sensitive variables as TF_VAR_* environment variables
        if (sensitiveEnvironmentVariables is not null)
        {
            foreach (var (varName, varValue) in sensitiveEnvironmentVariables)
            {
                processStartInfo.Environment[$"TF_VAR_{varName}"] = varValue;
            }
        }

        using var process = new System.Diagnostics.Process { StartInfo = processStartInfo };

        process.Start();

        // Read output asynchronously to prevent deadlocks
        var outputTask = process.StandardOutput.ReadToEndAsync(context.CancellationToken);
        var errorTask = process.StandardError.ReadToEndAsync(context.CancellationToken);

        await process.WaitForExitAsync(context.CancellationToken).ConfigureAwait(false);

        var output = await outputTask.ConfigureAwait(false);
        var error = await errorTask.ConfigureAwait(false);

        if (!string.IsNullOrWhiteSpace(output))
        {
            if (logOutput)
            {
                context.Logger.LogInformation("Terraform output:\n{Output}", output);
            }
            else
            {
                context.Logger.LogDebug("Terraform output:\n{Output}", output);
            }
        }

        if (!string.IsNullOrWhiteSpace(error))
        {
            context.Logger.LogWarning("Terraform stderr:\n{Error}", error);
        }

        if (process.ExitCode != 0)
        {
            await context.ReportingStep.CompleteAsync(
                $"Terraform '{command}' failed with exit code {process.ExitCode}",
                CompletionState.CompletedWithError,
                context.CancellationToken).ConfigureAwait(false);

            throw new InvalidOperationException($"Terraform '{command}' failed with exit code {process.ExitCode}. Error: {error}");
        }

        await context.ReportingStep.CompleteAsync(
            $"Terraform '{command}' completed successfully",
            CompletionState.Completed,
            context.CancellationToken).ConfigureAwait(false);

        return output;
    }

    /// <summary>
    /// Reads Terraform outputs from the specified working directory by running <c>terraform output -json</c>.
    /// </summary>
    /// <param name="context">The pipeline step context.</param>
    /// <param name="workingDirectory">The directory containing the Terraform configuration.</param>
    /// <returns>A dictionary of output names to tuples of (value, sensitive flag).</returns>
    /// <exception cref="InvalidOperationException">Thrown when the terraform command fails.</exception>
    public static async Task<Dictionary<string, (object? Value, bool Sensitive)>> ReadOutputsAsync(
        PipelineStepContext context,
        string workingDirectory)
    {
        context.Logger.LogDebug("Reading Terraform outputs from {Path}", workingDirectory);

        var output = await RunCommandAsync(
            context,
            "output -json",
            workingDirectory).ConfigureAwait(false);

        if (string.IsNullOrWhiteSpace(output))
        {
            context.Logger.LogWarning("Terraform returned no outputs");
            return new Dictionary<string, (object? Value, bool Sensitive)>();
        }

        // Parse the JSON output
        Dictionary<string, TerraformOutputValue>? terraformOutputs;
        try
        {
            terraformOutputs = JsonSerializer.Deserialize<Dictionary<string, TerraformOutputValue>>(output, JsonSerializerOptions);
        }
        catch (JsonException ex)
        {
            // Don't log raw output as it may contain sensitive values
            context.Logger.LogError(ex, "Failed to parse Terraform output JSON.");
            throw new InvalidOperationException(
                $"Failed to parse Terraform output JSON. Ensure 'terraform output -json' produces valid JSON. " +
                $"Error: {ex.Message}", ex);
        }

        if (terraformOutputs is null)
        {
            context.Logger.LogWarning("Failed to parse Terraform outputs - deserialization returned null");
            return new Dictionary<string, (object? Value, bool Sensitive)>();
        }

        // Convert to dictionary with sensitivity info
        var result = new Dictionary<string, (object? Value, bool Sensitive)>(StringComparer.OrdinalIgnoreCase);
        foreach (var (name, outputValue) in terraformOutputs)
        {
            result[name] = (outputValue.Value, outputValue.Sensitive);

            if (outputValue.Sensitive)
            {
                context.Logger.LogDebug("Read output '{OutputName}' (sensitive: value redacted)", name);
            }
            else
            {
                context.Logger.LogDebug("Read output '{OutputName}' = {Value}", name, outputValue.Value);
            }
        }

        context.Logger.LogDebug("Read {Count} Terraform outputs", result.Count);
        return result;
    }

    private static readonly JsonSerializerOptions JsonSerializerOptions = new()
    {
        PropertyNameCaseInsensitive = true
    };

    /// <summary>
    /// Represents a Terraform output value from the JSON output.
    /// </summary>
    private sealed class TerraformOutputValue
    {
        /// <summary>
        /// Gets or sets the output value.
        /// </summary>
        [JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        /// Gets or sets the output type.
        /// </summary>
        [JsonPropertyName("type")]
        public object? Type { get; set; }

        /// <summary>
        /// Gets or sets whether the output is marked as sensitive.
        /// </summary>
        [JsonPropertyName("sensitive")]
        public bool Sensitive { get; set; }
    }
}
