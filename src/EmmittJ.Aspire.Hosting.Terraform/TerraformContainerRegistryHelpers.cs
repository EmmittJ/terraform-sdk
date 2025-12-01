// Licensed under the MIT License.

#pragma warning disable ASPIREPIPELINES001

using System.ComponentModel;
using Aspire.Hosting.Pipelines;
using Aspire.Hosting.Publishing;
using Microsoft.Extensions.Logging;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Provides factory methods for creating common container registry login callbacks.
/// </summary>
public static class TerraformContainerRegistryHelpers
{
    /// <summary>
    /// Creates a login callback for Azure Container Registry using Azure CLI.
    /// </summary>
    /// <returns>A callback that runs <c>az acr login --name {registryName}</c>.</returns>
    /// <remarks>
    /// <para>
    /// This callback requires the Azure CLI to be installed and the user to be authenticated via <c>az login</c>.
    /// The registry name is obtained from the <c>name</c> output of the registry's Terraform configuration.
    /// </para>
    /// </remarks>
    /// <example>
    /// <code>
    /// var terraform = builder.AddTerraformEnvironment("azure")
    ///     .WithContainerRegistry("acr", configure => { ... })
    ///     .WithRegistryLogin(TerraformContainerRegistryHelpers.CreateAzureCliLoginCallback());
    /// </code>
    /// </example>
    public static Func<PipelineStepContext, TerraformContainerRegistryResource, Task> CreateAzureCliLoginCallback()
    {
        return async (context, registry) =>
        {
            var registryName = registry.NameOutput.Value;

            if (string.IsNullOrEmpty(registryName))
            {
                throw new InvalidOperationException(
                    $"Registry name not available for '{registry.Name}'. Ensure the 'name' output is defined and terraform apply has completed.");
            }

            context.Logger.LogInformation("Logging in to Azure Container Registry '{RegistryName}'", registryName);

            await context.ReportingStep.CompleteAsync(
                $"Logging in to ACR '{registryName}'",
                CompletionState.InProgress,
                context.CancellationToken).ConfigureAwait(false);

            // On Windows, az is actually az.cmd which requires shell execution
            // TODO: fix this?
            var isWindows = OperatingSystem.IsWindows();
            var processStartInfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = isWindows ? "cmd.exe" : "az",
                Arguments = isWindows ? $"/c az acr login --name {registryName}" : $"acr login --name {registryName}",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using var process = new System.Diagnostics.Process { StartInfo = processStartInfo };

            try
            {
                process.Start();
            }
            catch (Win32Exception ex) when (ex.NativeErrorCode == 2) // ERROR_FILE_NOT_FOUND
            {
                throw new InvalidOperationException(
                    "Azure CLI ('az') is not installed or not found in PATH. " +
                    "Please install the Azure CLI from https://aka.ms/installazurecli and ensure you are logged in with 'az login'.",
                    ex);
            }

            var outputTask = process.StandardOutput.ReadToEndAsync(context.CancellationToken);
            var errorTask = process.StandardError.ReadToEndAsync(context.CancellationToken);

            await process.WaitForExitAsync(context.CancellationToken).ConfigureAwait(false);

            var output = await outputTask.ConfigureAwait(false);
            var error = await errorTask.ConfigureAwait(false);

            if (!string.IsNullOrWhiteSpace(output))
            {
                context.Logger.LogInformation("Azure CLI output: {Output}", output);
            }

            if (process.ExitCode != 0)
            {
                await context.ReportingStep.CompleteAsync(
                    $"Azure ACR login failed",
                    CompletionState.CompletedWithError,
                    context.CancellationToken).ConfigureAwait(false);

                throw new InvalidOperationException($"Azure ACR login failed with exit code {process.ExitCode}. Error: {error}");
            }

            await context.ReportingStep.CompleteAsync(
                $"Logged in to ACR '{registryName}'",
                CompletionState.Completed,
                context.CancellationToken).ConfigureAwait(false);
        };
    }

    /// <summary>
    /// Creates a login callback for AWS Elastic Container Registry using AWS CLI.
    /// </summary>
    /// <param name="region">Optional AWS region. If not specified, uses the default region from AWS configuration.</param>
    /// <returns>A callback that runs <c>aws ecr get-login-password | docker login</c>.</returns>
    /// <remarks>
    /// <para>
    /// This callback requires the AWS CLI and Docker to be installed, and valid AWS credentials to be configured.
    /// The registry endpoint is obtained from the <c>endpoint</c> output of the registry's Terraform configuration.
    /// </para>
    /// </remarks>
    /// <example>
    /// <code>
    /// var terraform = builder.AddTerraformEnvironment("aws")
    ///     .WithContainerRegistry("ecr", configure => { ... })
    ///     .WithRegistryLogin(TerraformContainerRegistryHelpers.CreateAwsEcrLoginCallback("us-west-2"));
    /// </code>
    /// </example>
    public static Func<PipelineStepContext, TerraformContainerRegistryResource, Task> CreateAwsEcrLoginCallback(string? region = null)
    {
        return async (context, registry) =>
        {
            var registryEndpoint = registry.EndpointOutput.Value;

            if (string.IsNullOrEmpty(registryEndpoint))
            {
                throw new InvalidOperationException(
                    $"Registry endpoint not available for '{registry.Name}'. Ensure the 'endpoint' output is defined and terraform apply has completed.");
            }

            context.Logger.LogInformation("Logging in to AWS ECR '{RegistryEndpoint}'", registryEndpoint);

            await context.ReportingStep.CompleteAsync(
                $"Logging in to ECR '{registryEndpoint}'",
                CompletionState.InProgress,
                context.CancellationToken).ConfigureAwait(false);

            // Build the AWS ECR get-login-password command
            var regionArg = string.IsNullOrEmpty(region) ? "" : $" --region {region}";
            var awsCommand = $"ecr get-login-password{regionArg}";

            // On Windows, aws is actually aws.cmd which requires shell execution
            var isWindows = OperatingSystem.IsWindows();

            // Get the password from AWS CLI
            var awsProcessStartInfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = isWindows ? "cmd.exe" : "aws",
                Arguments = isWindows ? $"/c aws {awsCommand}" : awsCommand,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using var awsProcess = new System.Diagnostics.Process { StartInfo = awsProcessStartInfo };

            try
            {
                awsProcess.Start();
            }
            catch (Win32Exception ex) when (ex.NativeErrorCode == 2) // ERROR_FILE_NOT_FOUND
            {
                throw new InvalidOperationException(
                    "AWS CLI ('aws') is not installed or not found in PATH. " +
                    "Please install the AWS CLI from https://aws.amazon.com/cli/ and configure your credentials.",
                    ex);
            }

            var passwordTask = awsProcess.StandardOutput.ReadToEndAsync(context.CancellationToken);
            var awsErrorTask = awsProcess.StandardError.ReadToEndAsync(context.CancellationToken);

            await awsProcess.WaitForExitAsync(context.CancellationToken).ConfigureAwait(false);

            var password = (await passwordTask.ConfigureAwait(false)).Trim();
            var awsError = await awsErrorTask.ConfigureAwait(false);

            if (awsProcess.ExitCode != 0)
            {
                await context.ReportingStep.CompleteAsync(
                    "AWS ECR get-login-password failed",
                    CompletionState.CompletedWithError,
                    context.CancellationToken).ConfigureAwait(false);

                throw new InvalidOperationException($"AWS ECR get-login-password failed with exit code {awsProcess.ExitCode}. Error: {awsError}");
            }

            // Docker login with the password
            var dockerProcessStartInfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "docker",
                Arguments = $"login --username AWS --password-stdin {registryEndpoint}",
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using var dockerProcess = new System.Diagnostics.Process { StartInfo = dockerProcessStartInfo };

            try
            {
                dockerProcess.Start();
            }
            catch (Win32Exception ex) when (ex.NativeErrorCode == 2) // ERROR_FILE_NOT_FOUND
            {
                throw new InvalidOperationException(
                    "Docker is not installed or not found in PATH. " +
                    "Please install Docker from https://www.docker.com/get-started and ensure Docker daemon is running.",
                    ex);
            }

            await dockerProcess.StandardInput.WriteAsync(password).ConfigureAwait(false);
            dockerProcess.StandardInput.Close();

            var dockerOutputTask = dockerProcess.StandardOutput.ReadToEndAsync(context.CancellationToken);
            var dockerErrorTask = dockerProcess.StandardError.ReadToEndAsync(context.CancellationToken);

            await dockerProcess.WaitForExitAsync(context.CancellationToken).ConfigureAwait(false);

            var dockerOutput = await dockerOutputTask.ConfigureAwait(false);
            var dockerError = await dockerErrorTask.ConfigureAwait(false);

            if (!string.IsNullOrWhiteSpace(dockerOutput))
            {
                context.Logger.LogInformation("Docker login output: {Output}", dockerOutput);
            }

            if (dockerProcess.ExitCode != 0)
            {
                await context.ReportingStep.CompleteAsync(
                    "Docker login to ECR failed",
                    CompletionState.CompletedWithError,
                    context.CancellationToken).ConfigureAwait(false);

                throw new InvalidOperationException($"Docker login to ECR failed with exit code {dockerProcess.ExitCode}. Error: {dockerError}");
            }

            await context.ReportingStep.CompleteAsync(
                $"Logged in to ECR '{registryEndpoint}'",
                CompletionState.Completed,
                context.CancellationToken).ConfigureAwait(false);
        };
    }

    /// <summary>
    /// Creates a generic Docker login callback using username and password outputs.
    /// </summary>
    /// <param name="usernameOutputName">The name of the Terraform output containing the username.</param>
    /// <param name="passwordOutputName">The name of the Terraform output containing the password.</param>
    /// <returns>A callback that runs <c>docker login -u {username} -p {password} {endpoint}</c>.</returns>
    /// <remarks>
    /// <para>
    /// This callback requires Docker to be installed. The username and password are obtained from the
    /// specified Terraform outputs, and the endpoint from the <c>endpoint</c> output.
    /// </para>
    /// </remarks>
    /// <example>
    /// <code>
    /// var terraform = builder.AddTerraformEnvironment("docker")
    ///     .WithContainerRegistry("registry", registry =>
    ///     {
    ///         // ... create registry ...
    ///         registry.Add(new TerraformOutput("name") { Value = "myregistry" });
    ///         registry.Add(new TerraformOutput("endpoint") { Value = "registry.example.com" });
    ///         registry.Add(new TerraformOutput("username") { Value = "admin" });
    ///         registry.Add(new TerraformOutput("password") { Value = passwordSecret, Sensitive = true });
    ///     })
    ///     .WithRegistryLogin(TerraformContainerRegistryHelpers.CreateDockerLoginCallback("username", "password"));
    /// </code>
    /// </example>
    public static Func<PipelineStepContext, TerraformContainerRegistryResource, Task> CreateDockerLoginCallback(
        string usernameOutputName,
        string passwordOutputName)
    {
        ArgumentException.ThrowIfNullOrEmpty(usernameOutputName);
        ArgumentException.ThrowIfNullOrEmpty(passwordOutputName);

        return async (context, registry) =>
        {
            var registryEndpoint = registry.EndpointOutput.Value;

            if (string.IsNullOrEmpty(registryEndpoint))
            {
                throw new InvalidOperationException(
                    $"Registry endpoint not available for '{registry.Name}'. Ensure the 'endpoint' output is defined and terraform apply has completed.");
            }

            // Get username and password from outputs
            if (!registry.RegistryTerraformResource.Outputs.TryGetValue(usernameOutputName, out var usernameValue) ||
                usernameValue is null)
            {
                throw new InvalidOperationException(
                    $"Username output '{usernameOutputName}' not found for registry '{registry.Name}'.");
            }

            if (!registry.RegistryTerraformResource.Outputs.TryGetValue(passwordOutputName, out var passwordValue) ||
                passwordValue is null)
            {
                throw new InvalidOperationException(
                    $"Password output '{passwordOutputName}' not found for registry '{registry.Name}'.");
            }

            var username = usernameValue.ToString() ?? "";
            var password = passwordValue.ToString() ?? "";

            context.Logger.LogInformation("Logging in to Docker registry '{RegistryEndpoint}'", registryEndpoint);

            await context.ReportingStep.CompleteAsync(
                $"Logging in to registry '{registryEndpoint}'",
                CompletionState.InProgress,
                context.CancellationToken).ConfigureAwait(false);

            // Use --password-stdin for security
            var processStartInfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "docker",
                Arguments = $"login --username {username} --password-stdin {registryEndpoint}",
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using var process = new System.Diagnostics.Process { StartInfo = processStartInfo };

            try
            {
                process.Start();
            }
            catch (Win32Exception ex) when (ex.NativeErrorCode == 2) // ERROR_FILE_NOT_FOUND
            {
                throw new InvalidOperationException(
                    "Docker is not installed or not found in PATH. " +
                    "Please install Docker from https://www.docker.com/get-started and ensure Docker daemon is running.",
                    ex);
            }

            await process.StandardInput.WriteAsync(password).ConfigureAwait(false);
            process.StandardInput.Close();

            var outputTask = process.StandardOutput.ReadToEndAsync(context.CancellationToken);
            var errorTask = process.StandardError.ReadToEndAsync(context.CancellationToken);

            await process.WaitForExitAsync(context.CancellationToken).ConfigureAwait(false);

            var output = await outputTask.ConfigureAwait(false);
            var error = await errorTask.ConfigureAwait(false);

            if (!string.IsNullOrWhiteSpace(output))
            {
                context.Logger.LogInformation("Docker login output: {Output}", output);
            }

            if (process.ExitCode != 0)
            {
                await context.ReportingStep.CompleteAsync(
                    "Docker login failed",
                    CompletionState.CompletedWithError,
                    context.CancellationToken).ConfigureAwait(false);

                throw new InvalidOperationException($"Docker login failed with exit code {process.ExitCode}. Error: {error}");
            }

            await context.ReportingStep.CompleteAsync(
                $"Logged in to registry '{registryEndpoint}'",
                CompletionState.Completed,
                context.CancellationToken).ConfigureAwait(false);
        };
    }
}
