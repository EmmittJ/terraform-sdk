// Licensed under the MIT License.

#pragma warning disable ASPIREPIPELINES001

using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using Aspire.Hosting.Pipelines;
using Aspire.Hosting.Publishing;
using Microsoft.Extensions.Logging;

namespace EmmittJ.Aspire.Hosting.Terraform.Modules;

internal static class TerraformCli
{
    private static readonly JsonSerializerOptions s_jsonOptions = new() { PropertyNameCaseInsensitive = true };

    /// <summary>
    /// Runs a Terraform command. <paramref name="variables"/> are passed as <c>TF_VAR_*</c>
    /// environment variables so values (including secrets) are never written to disk.
    /// </summary>
    public static async Task<string> RunAsync(
        PipelineStepContext context,
        string arguments,
        string workingDirectory,
        IReadOnlyDictionary<string, string>? variables = null,
        bool logOutput = false)
    {
        context.Logger.LogDebug("Running terraform {Arguments} in {Path}", arguments, workingDirectory);

        var startInfo = new ProcessStartInfo
        {
            FileName = "terraform",
            Arguments = arguments,
            WorkingDirectory = workingDirectory,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true,
            Environment = { ["TF_IN_AUTOMATION"] = "true" }
        };

        if (variables is not null)
        {
            foreach (var (name, value) in variables)
            {
                startInfo.Environment[$"TF_VAR_{name}"] = value;
            }
        }

        using var process = new Process { StartInfo = startInfo };
        process.Start();

        var outputTask = process.StandardOutput.ReadToEndAsync(context.CancellationToken);
        var errorTask = process.StandardError.ReadToEndAsync(context.CancellationToken);

        await process.WaitForExitAsync(context.CancellationToken).ConfigureAwait(false);

        var output = await outputTask.ConfigureAwait(false);
        var error = await errorTask.ConfigureAwait(false);

        if (!string.IsNullOrWhiteSpace(output))
        {
            context.Logger.Log(logOutput ? LogLevel.Information : LogLevel.Debug, "Terraform output:\n{Output}", output);
        }

        if (!string.IsNullOrWhiteSpace(error))
        {
            context.Logger.LogWarning("Terraform stderr:\n{Error}", error);
        }

        if (process.ExitCode != 0)
        {
            await context.ReportingStep.CompleteAsync(
                $"terraform {arguments.Split(' ')[0]} failed with exit code {process.ExitCode}",
                CompletionState.CompletedWithError,
                context.CancellationToken).ConfigureAwait(false);

            throw new InvalidOperationException($"terraform {arguments} failed with exit code {process.ExitCode}. {error}");
        }

        return output;
    }

    public static async Task<Dictionary<string, (object? Value, bool Sensitive)>> ReadOutputsAsync(
        PipelineStepContext context,
        string workingDirectory)
    {
        var json = await RunAsync(context, "output -json", workingDirectory).ConfigureAwait(false);
        var result = new Dictionary<string, (object? Value, bool Sensitive)>(StringComparer.OrdinalIgnoreCase);

        if (string.IsNullOrWhiteSpace(json))
        {
            return result;
        }

        Dictionary<string, OutputValue>? outputs;
        try
        {
            outputs = JsonSerializer.Deserialize<Dictionary<string, OutputValue>>(json, s_jsonOptions);
        }
        catch (JsonException ex)
        {
            // Raw output is intentionally not logged: it may contain sensitive values.
            throw new InvalidOperationException($"Failed to parse 'terraform output -json': {ex.Message}", ex);
        }

        foreach (var (name, output) in outputs ?? [])
        {
            result[name] = (output.Value, output.Sensitive);
        }

        return result;
    }

    private sealed class OutputValue
    {
        [JsonPropertyName("value")]
        public object? Value { get; set; }

        [JsonPropertyName("sensitive")]
        public bool Sensitive { get; set; }
    }
}
