// Licensed under the MIT License.

using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Aspire.Hosting;
using Microsoft.Extensions.Logging;

namespace EmmittJ.Aspire.Hosting.Terraform;

internal static class TerraformCli
{
    private static readonly JsonSerializerOptions s_jsonOptions = new() { PropertyNameCaseInsensitive = true };
    private static readonly TimeSpan s_shutdownGracePeriod = TimeSpan.FromSeconds(30);

    [DllImport("libc", EntryPoint = "kill", SetLastError = true)]
    private static extern int Kill(int pid, int signal);

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
        bool logOutput = false,
        bool suppressOutputLog = false)
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

        var outputTask = process.StandardOutput.ReadToEndAsync(CancellationToken.None);
        var errorTask = process.StandardError.ReadToEndAsync(CancellationToken.None);

        // Cancelling only the wait would leave Terraform provisioning (and holding the state lock),
        // so interrupt it, let it shut down gracefully, and kill the process tree as a fallback.
        using var exited = new CancellationTokenSource();
        using (cancellationToken.Register(() => Interrupt(process, exited.Token)))
        {
            await process.WaitForExitAsync(CancellationToken.None).ConfigureAwait(false);
            exited.Cancel();
        }

        cancellationToken.ThrowIfCancellationRequested();

        var output = await outputTask.ConfigureAwait(false);
        var error = await errorTask.ConfigureAwait(false);

        if (!suppressOutputLog && !string.IsNullOrWhiteSpace(output))
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

    private static void Interrupt(Process process, CancellationToken exited)
    {
        try
        {
            if (process.HasExited)
            {
                return;
            }

            if (OperatingSystem.IsWindows())
            {
                process.Kill(entireProcessTree: true);
                return;
            }

            Kill(process.Id, 2); // SIGINT: Terraform stops gracefully and releases the state lock.

            _ = Task.Delay(s_shutdownGracePeriod, exited).ContinueWith(
                _ =>
                {
                    try
                    {
                        process.Kill(entireProcessTree: true);
                    }
                    catch (InvalidOperationException)
                    {
                        // Already exited or disposed.
                    }
                },
                CancellationToken.None,
                TaskContinuationOptions.OnlyOnRanToCompletion,
                TaskScheduler.Default);
        }
        catch (InvalidOperationException)
        {
            // Already exited or disposed.
        }
    }

    public static async Task<Dictionary<string, (object? Value, bool Sensitive)>> ReadOutputsAsync(
        ILogger logger,
        string workingDirectory,
        CancellationToken cancellationToken)
    {
        var json = await RunAsync(logger, "output -json", workingDirectory, cancellationToken, suppressOutputLog: true).ConfigureAwait(false);
        var result = new Dictionary<string, (object? Value, bool Sensitive)>(StringComparer.Ordinal);

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
            result[name] = (ToValue(output.Value), output.Sensitive);
        }

        return result;
    }

    // Strings are unwrapped; everything else keeps its JSON text (e.g. true, 42, {"a":1}).
    private static string? ToValue(JsonElement element) => element.ValueKind switch
    {
        JsonValueKind.Null or JsonValueKind.Undefined => null,
        JsonValueKind.String => element.GetString(),
        _ => element.GetRawText()
    };

    private sealed class OutputValue
    {
        [JsonPropertyName("value")]
        public JsonElement Value { get; set; }

        [JsonPropertyName("sensitive")]
        public bool Sensitive { get; set; }
    }
}
