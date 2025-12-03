// Licensed under the MIT License.

#pragma warning disable ASPIREPIPELINES001

using System.Text.Json;
using System.Text.Json.Serialization;
using Aspire.Hosting.Pipelines;
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
    /// <param name="context">The pipeline step context.</param>
    /// <param name="workingDirectory">The directory containing the Terraform configuration.</param>
    /// <returns>A dictionary of output names to tuples of (value, sensitive flag).</returns>
    /// <exception cref="InvalidOperationException">Thrown when the terraform command fails.</exception>
    public static async Task<Dictionary<string, (object? Value, bool Sensitive)>> ReadOutputsAsync(
        PipelineStepContext context,
        string workingDirectory)
    {
        context.Logger.LogDebug("Reading Terraform outputs from {Path}", workingDirectory);

        var output = await TerraformCommandRunner.RunTerraformCommandAsync(
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
