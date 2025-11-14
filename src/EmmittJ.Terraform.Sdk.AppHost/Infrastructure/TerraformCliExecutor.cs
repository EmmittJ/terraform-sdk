using System.Diagnostics;
using Microsoft.Extensions.Logging;

namespace EmmittJ.Terraform.Sdk.AppHost;

/// <summary>
/// Executor for Terraform CLI commands.
/// </summary>
public class TerraformCliExecutor : ITerraformCli
{
    private readonly ILogger<TerraformCliExecutor> _logger;

    public TerraformCliExecutor(ILogger<TerraformCliExecutor> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Runs 'terraform init' in the specified working directory.
    /// </summary>
    public async Task InitializeAsync(string workingDirectory, CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Running: terraform init in {WorkingDirectory}", workingDirectory);
        await ExecuteAsync("terraform", "init", workingDirectory, cancellationToken);
    }

    /// <summary>
    /// Runs 'terraform providers schema -json' and returns the schema JSON.
    /// </summary>
    public async Task<string> GetSchemaJsonAsync(string workingDirectory, CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Running: terraform providers schema -json in {WorkingDirectory}", workingDirectory);
        return await ExecuteWithOutputAsync("terraform", "providers schema -json", workingDirectory, cancellationToken);
    }

    private async Task ExecuteAsync(string command, string arguments, string workingDirectory, CancellationToken cancellationToken)
    {
        var process = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = command,
                Arguments = arguments,
                WorkingDirectory = workingDirectory,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            }
        };

        process.Start();
        await process.WaitForExitAsync(cancellationToken);

        if (process.ExitCode != 0)
        {
            var error = await process.StandardError.ReadToEndAsync(cancellationToken);
            throw new InvalidOperationException($"Terraform command failed: {error}");
        }
    }

    private async Task<string> ExecuteWithOutputAsync(string command, string arguments, string workingDirectory, CancellationToken cancellationToken)
    {
        var process = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = command,
                Arguments = arguments,
                WorkingDirectory = workingDirectory,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            }
        };

        process.Start();
        var output = await process.StandardOutput.ReadToEndAsync(cancellationToken);
        await process.WaitForExitAsync(cancellationToken);

        if (process.ExitCode != 0)
        {
            var error = await process.StandardError.ReadToEndAsync(cancellationToken);
            throw new InvalidOperationException($"Terraform command failed: {error}");
        }

        return output;
    }
}
