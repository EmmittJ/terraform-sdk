// Licensed under the MIT License.

#pragma warning disable ASPIREPIPELINES001

using System.ComponentModel;
using System.Diagnostics;
using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Pipelines;
using Aspire.Hosting.Publishing;
using Microsoft.Extensions.Logging;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Provides factory methods for creating common container registry login callbacks.
/// </summary>
/// <remarks>
/// <para>
/// These helpers use CLI-based authentication which requires the respective CLI tools
/// (Azure CLI, AWS CLI, Docker) to be installed and configured. For Azure Container Registry,
/// the user must be logged in via <c>az login</c>. For AWS ECR, valid credentials must be configured.
/// </para>
/// <para>
/// On Windows, CLI tools like <c>az</c> and <c>aws</c> are implemented as batch scripts (.cmd files).
/// When using <see cref="ProcessStartInfo"/> with <c>UseShellExecute = false</c>, batch scripts
/// require the command interpreter (<c>cmd.exe /c</c>) to execute. This is handled internally
/// by the <see cref="CreateCliProcessStartInfo"/> method.
/// </para>
/// </remarks>
public static class TerraformContainerRegistryHelpers
{
    /// <summary>
    /// Creates a <see cref="ProcessStartInfo"/> for running a CLI command.
    /// </summary>
    /// <param name="command">The CLI command to run (e.g., "az", "aws", "docker").</param>
    /// <param name="arguments">The arguments to pass to the command.</param>
    /// <param name="isNativeExecutable">
    /// <c>true</c> if the command is a native executable (e.g., docker);
    /// <c>false</c> if it's a batch script on Windows (e.g., az.cmd, aws.cmd).
    /// </param>
    /// <returns>A configured <see cref="ProcessStartInfo"/>.</returns>
    /// <remarks>
    /// On Windows, CLI tools like <c>az</c> and <c>aws</c> are batch scripts (.cmd files).
    /// When <paramref name="isNativeExecutable"/> is <c>false</c> and running on Windows,
    /// this method uses <c>cmd.exe /c</c> to execute the command.
    /// </remarks>
    private static ProcessStartInfo CreateCliProcessStartInfo(string command, string arguments, bool isNativeExecutable)
    {
        // On Windows, batch scripts (.cmd files) need cmd.exe to execute them
        // when UseShellExecute = false (required for stdout/stderr redirection).
        var needsShellWrapper = OperatingSystem.IsWindows() && !isNativeExecutable;

        return new ProcessStartInfo
        {
            FileName = needsShellWrapper ? "cmd.exe" : command,
            Arguments = needsShellWrapper ? $"/c {command} {arguments}" : arguments,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };
    }

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
    public static Func<PipelineStepContext, IContainerRegistry, Task> CreateAzureCliLoginCallback()
    {
        return async (context, registry) =>
        {
            var registryName = await registry.Name.GetValueAsync(context.CancellationToken).ConfigureAwait(false);

            if (string.IsNullOrEmpty(registryName))
            {
                throw new InvalidOperationException(
                    "Registry name not available. Ensure the registry is provisioned and the 'name' output is defined.");
            }

            context.Logger.LogInformation("Logging in to Azure Container Registry '{RegistryName}'", registryName);

            await context.ReportingStep.CompleteAsync(
                $"Logging in to ACR '{registryName}'",
                CompletionState.InProgress,
                context.CancellationToken).ConfigureAwait(false);

            var processStartInfo = CreateCliProcessStartInfo("az", $"acr login --name {registryName}", isNativeExecutable: false);

            using var process = new Process { StartInfo = processStartInfo };

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
                context.Logger.LogDebug("Azure CLI output: {Output}", output);
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
    public static Func<PipelineStepContext, IContainerRegistry, Task> CreateAwsEcrLoginCallback(string? region = null)
    {
        return async (context, registry) =>
        {
            var registryEndpoint = await registry.Endpoint.GetValueAsync(context.CancellationToken).ConfigureAwait(false);

            if (string.IsNullOrEmpty(registryEndpoint))
            {
                throw new InvalidOperationException(
                    "Registry endpoint not available. Ensure the registry is provisioned and the 'endpoint' output is defined.");
            }

            context.Logger.LogInformation("Logging in to AWS ECR '{RegistryEndpoint}'", registryEndpoint);

            await context.ReportingStep.CompleteAsync(
                $"Logging in to ECR '{registryEndpoint}'",
                CompletionState.InProgress,
                context.CancellationToken).ConfigureAwait(false);

            // Build the AWS ECR get-login-password command
            var regionArg = string.IsNullOrEmpty(region) ? "" : $" --region {region}";
            var awsCommand = $"ecr get-login-password{regionArg}";

            // Get the password from AWS CLI
            var awsProcessStartInfo = CreateCliProcessStartInfo("aws", awsCommand, isNativeExecutable: false);

            using var awsProcess = new Process { StartInfo = awsProcessStartInfo };

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

            // Docker login with the password via stdin (password is not logged)
            var dockerProcessStartInfo = CreateCliProcessStartInfo("docker", $"login --username AWS --password-stdin {registryEndpoint}", isNativeExecutable: true);
            dockerProcessStartInfo.RedirectStandardInput = true;

            using var dockerProcess = new Process { StartInfo = dockerProcessStartInfo };

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

            // Write password to stdin (never log the password)
            await dockerProcess.StandardInput.WriteAsync(password).ConfigureAwait(false);
            dockerProcess.StandardInput.Close();

            var dockerOutputTask = dockerProcess.StandardOutput.ReadToEndAsync(context.CancellationToken);
            var dockerErrorTask = dockerProcess.StandardError.ReadToEndAsync(context.CancellationToken);

            await dockerProcess.WaitForExitAsync(context.CancellationToken).ConfigureAwait(false);

            var dockerOutput = await dockerOutputTask.ConfigureAwait(false);
            var dockerError = await dockerErrorTask.ConfigureAwait(false);

            if (!string.IsNullOrWhiteSpace(dockerOutput))
            {
                context.Logger.LogDebug("Docker login output: {Output}", dockerOutput);
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
    /// <returns>A callback that runs <c>docker login --password-stdin {endpoint}</c>.</returns>
    /// <remarks>
    /// <para>
    /// This callback requires Docker to be installed. The username and password are obtained from the
    /// specified Terraform outputs, and the endpoint from the <c>endpoint</c> output.
    /// </para>
    /// <para>
    /// The password is passed via stdin using <c>--password-stdin</c> to avoid exposing it in process
    /// arguments or logs.
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
    public static Func<PipelineStepContext, IContainerRegistry, Task> CreateDockerLoginCallback(
        string usernameOutputName,
        string passwordOutputName)
    {
        ArgumentException.ThrowIfNullOrEmpty(usernameOutputName);
        ArgumentException.ThrowIfNullOrEmpty(passwordOutputName);

        return async (context, registry) =>
        {
            if (registry is not TerraformContainerRegistryResource terraformRegistry)
            {
                throw new InvalidOperationException(
                    $"CreateDockerLoginCallback requires a TerraformContainerRegistryResource to access named outputs, but received {registry.GetType().Name}.");
            }

            var registryEndpoint = await registry.Endpoint.GetValueAsync(context.CancellationToken).ConfigureAwait(false);

            if (string.IsNullOrEmpty(registryEndpoint))
            {
                throw new InvalidOperationException(
                    "Registry endpoint not available. Ensure the registry is provisioned and the 'endpoint' output is defined.");
            }

            // Get username and password from outputs
            if (!terraformRegistry.OutputsAnnotation.Outputs.TryGetValue(usernameOutputName, out var usernameValue) ||
                usernameValue is null)
            {
                throw new InvalidOperationException(
                    $"Username output '{usernameOutputName}' not found for registry '{terraformRegistry.Name}'.");
            }

            if (!terraformRegistry.OutputsAnnotation.Outputs.TryGetValue(passwordOutputName, out var passwordValue) ||
                passwordValue is null)
            {
                throw new InvalidOperationException(
                    $"Password output '{passwordOutputName}' not found for registry '{terraformRegistry.Name}'.");
            }

            var username = usernameValue.ToString() ?? "";
            var password = passwordValue.ToString() ?? "";

            // Log endpoint but never log credentials
            context.Logger.LogInformation("Logging in to Docker registry '{RegistryEndpoint}'", registryEndpoint);

            await context.ReportingStep.CompleteAsync(
                $"Logging in to registry '{registryEndpoint}'",
                CompletionState.InProgress,
                context.CancellationToken).ConfigureAwait(false);

            // Use --password-stdin to avoid exposing password in process arguments
            var processStartInfo = CreateCliProcessStartInfo("docker", $"login --username {username} --password-stdin {registryEndpoint}", isNativeExecutable: true);
            processStartInfo.RedirectStandardInput = true;

            using var process = new Process { StartInfo = processStartInfo };

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

            // Write password to stdin (never log the password)
            await process.StandardInput.WriteAsync(password).ConfigureAwait(false);
            process.StandardInput.Close();

            var outputTask = process.StandardOutput.ReadToEndAsync(context.CancellationToken);
            var errorTask = process.StandardError.ReadToEndAsync(context.CancellationToken);

            await process.WaitForExitAsync(context.CancellationToken).ConfigureAwait(false);

            var output = await outputTask.ConfigureAwait(false);
            var error = await errorTask.ConfigureAwait(false);

            if (!string.IsNullOrWhiteSpace(output))
            {
                context.Logger.LogDebug("Docker login output: {Output}", output);
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
