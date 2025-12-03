// Licensed under the MIT License.

#pragma warning disable ASPIREPIPELINES001

using Aspire.Hosting.Pipelines;
using Aspire.Hosting.Publishing;
using Microsoft.Extensions.Logging;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Provides utility methods for running Terraform commands.
/// </summary>
internal static class TerraformCommandRunner
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
    public static async Task<string> RunTerraformCommandAsync(
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
                context.Logger.LogInformation("Terraform output: {Output}", output);
            }
            else
            {
                context.Logger.LogDebug("Terraform output: {Output}", output);
            }
        }

        if (!string.IsNullOrWhiteSpace(error))
        {
            context.Logger.LogWarning("Terraform stderr: {Error}", error);
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
}
