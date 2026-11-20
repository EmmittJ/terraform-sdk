// Licensed under the MIT License.

using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using Aspire.Hosting;
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
        ILogger logger,
        string arguments,
        string workingDirectory,
        CancellationToken cancellationToken,
        IReadOnlyDictionary<string, string>? variables = null,
        bool logOutput = false)
    {
        logger.LogDebug("Running terraform {Arguments} in {Path}", arguments, workingDirectory);

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

        try
        {
            process.Start();
        }
        catch (System.ComponentModel.Win32Exception ex)
        {
            throw new DistributedApplicationException("Could not start 'terraform'. Ensure the Terraform CLI is installed and on PATH.", ex);
        }

        var outputTask = process.StandardOutput.ReadToEndAsync(cancellationToken);
        var errorTask = process.StandardError.ReadToEndAsync(cancellationToken);

        await process.WaitForExitAsync(cancellationToken).ConfigureAwait(false);

        var output = await outputTask.ConfigureAwait(false);
        var error = await errorTask.ConfigureAwait(false);

        if (!string.IsNullOrWhiteSpace(output))
        {
            logger.Log(logOutput ? LogLevel.Information : LogLevel.Debug, "Terraform output:\n{Output}", output);
        }

        if (!string.IsNullOrWhiteSpace(error))
        {
            logger.LogWarning("Terraform stderr:\n{Error}", error);
        }

        if (process.ExitCode != 0)
        {
            throw new DistributedApplicationException($"terraform {arguments} failed with exit code {process.ExitCode}. {error}");
        }

        return output;
    }

    public static async Task<Dictionary<string, (object? Value, bool Sensitive)>> ReadOutputsAsync(
        ILogger logger,
        string workingDirectory,
        CancellationToken cancellationToken)
    {
        var json = await RunAsync(logger, "output -json", workingDirectory, cancellationToken).ConfigureAwait(false);
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
            throw new DistributedApplicationException($"Failed to parse 'terraform output -json': {ex.Message}", ex);
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
