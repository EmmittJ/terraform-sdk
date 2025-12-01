// Licensed under the MIT License.

#pragma warning disable IL2026
#pragma warning disable IL3050

using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Logging;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Provides utility methods for reading Terraform output values.
/// </summary>
internal static class TerraformOutputReader
{
    /// <summary>
    /// Reads Terraform outputs from the specified working directory by running <c>terraform output -json</c>.
    /// </summary>
    /// <param name="workingDirectory">The directory containing the Terraform configuration.</param>
    /// <param name="logger">The logger for diagnostic output.</param>
    /// <param name="cancellationToken">A cancellation token.</param>
    /// <returns>A dictionary of output names to their values.</returns>
    /// <exception cref="InvalidOperationException">Thrown when the terraform command fails.</exception>
    public static async Task<Dictionary<string, object?>> ReadOutputsAsync(
        string workingDirectory,
        ILogger logger,
        CancellationToken cancellationToken = default)
    {
        if (!Directory.Exists(workingDirectory))
        {
            throw new InvalidOperationException($"Terraform configuration directory does not exist: {workingDirectory}");
        }

        logger.LogInformation("Reading Terraform outputs from {Path}", workingDirectory);

        var processStartInfo = new System.Diagnostics.ProcessStartInfo
        {
            FileName = "terraform",
            Arguments = "output -json",
            WorkingDirectory = workingDirectory,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true,
            Environment = { ["TF_IN_AUTOMATION"] = "true" }
        };

        using var process = new System.Diagnostics.Process { StartInfo = processStartInfo };

        process.Start();

        var outputTask = process.StandardOutput.ReadToEndAsync(cancellationToken);
        var errorTask = process.StandardError.ReadToEndAsync(cancellationToken);

        await process.WaitForExitAsync(cancellationToken).ConfigureAwait(false);

        var output = await outputTask.ConfigureAwait(false);
        var error = await errorTask.ConfigureAwait(false);

        if (process.ExitCode != 0)
        {
            logger.LogError("Terraform output command failed: {Error}", error);
            throw new InvalidOperationException($"Terraform 'output -json' failed with exit code {process.ExitCode}. Error: {error}");
        }

        if (string.IsNullOrWhiteSpace(output))
        {
            logger.LogWarning("Terraform returned no outputs");
            return new Dictionary<string, object?>();
        }

        // Parse the JSON output
        var terraformOutputs = JsonSerializer.Deserialize<Dictionary<string, TerraformOutputValue>>(output, JsonSerializerOptions);

        if (terraformOutputs is null)
        {
            logger.LogWarning("Failed to parse Terraform outputs");
            return new Dictionary<string, object?>();
        }

        // Convert to simple dictionary, respecting sensitive values in logging
        var result = new Dictionary<string, object?>(StringComparer.OrdinalIgnoreCase);
        foreach (var (name, outputValue) in terraformOutputs)
        {
            result[name] = outputValue.Value;

            if (outputValue.Sensitive)
            {
                logger.LogDebug("Read output '{OutputName}' (sensitive: value redacted)", name);
            }
            else
            {
                logger.LogDebug("Read output '{OutputName}' = {Value}", name, outputValue.Value);
            }
        }

        logger.LogInformation("Read {Count} Terraform outputs", result.Count);
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
