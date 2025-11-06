using System.Diagnostics;
using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Pipelines;
using EmmittJ.Terraform.Sdk.AppHost.Parsers;
using EmmittJ.Terraform.Sdk.AppHost.Resources;
using EmmittJ.Terraform.Sdk.AppHost.Templates;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

#pragma warning disable ASPIREPIPELINES001

namespace EmmittJ.Terraform.Sdk.AppHost;

/// <summary>
/// Extension methods for adding Terraform provider code generation resources to the application.
/// </summary>
public static class TerraformProviderResourceExtensions
{
    /// <summary>
    /// Adds a Terraform provider resource to the application for code generation.
    /// </summary>
    /// <param name="builder">The distributed application builder.</param>
    /// <param name="name">The name of the resource (used for identification in the dashboard).</param>
    /// <param name="version">The version constraint for the provider (e.g., "~> 6.0").</param>
    /// <returns>A resource builder for the Terraform provider.</returns>
    public static IResourceBuilder<TerraformProviderResource> AddTerraformProvider(
        this IDistributedApplicationBuilder builder,
        string name,
        string version)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrWhiteSpace(name);
        ArgumentException.ThrowIfNullOrWhiteSpace(version);

        var resource = new TerraformProviderResource(name, name, version);
        return builder.AddResource(resource)
            .WithAnnotation(new TerraformProviderAnnotation())
            .WithPipelineStepFactory(context => CreateProviderPipelineStep(resource, context));
    }

    /// <summary>
    /// Adds a Terraform provider resource to the application for code generation with a custom name.
    /// </summary>
    /// <param name="builder">The distributed application builder.</param>
    /// <param name="name">The name of the resource (used for identification in the dashboard).</param>
    /// <param name="providerName">The Terraform provider name (e.g., "aws", "azurerm").</param>
    /// <param name="version">The version constraint for the provider (e.g., "~> 6.0").</param>
    /// <returns>A resource builder for the Terraform provider.</returns>
    public static IResourceBuilder<TerraformProviderResource> AddTerraformProvider(
        this IDistributedApplicationBuilder builder,
        string name,
        string providerName,
        string version)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrWhiteSpace(name);
        ArgumentException.ThrowIfNullOrWhiteSpace(providerName);
        ArgumentException.ThrowIfNullOrWhiteSpace(version);

        var resource = new TerraformProviderResource(name, providerName, version);
        return builder.AddResource(resource)
            .WithAnnotation(new TerraformProviderAnnotation())
            .WithPipelineStepFactory(context => CreateProviderPipelineStep(resource, context));
    }

    /// <summary>
    /// Sets the C# namespace for the generated provider code.
    /// </summary>
    /// <param name="builder">The resource builder.</param>
    /// <param name="namespace">The namespace to use.</param>
    /// <returns>The resource builder.</returns>
    public static IResourceBuilder<TerraformProviderResource> WithNamespace(
        this IResourceBuilder<TerraformProviderResource> builder,
        string @namespace)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrWhiteSpace(@namespace);

        builder.Resource.Namespace = @namespace;
        return builder;
    }

    /// <summary>
    /// Sets the output folder for the generated code.
    /// </summary>
    /// <param name="builder">The resource builder.</param>
    /// <param name="outputFolder">The output folder path.</param>
    /// <returns>The resource builder.</returns>
    public static IResourceBuilder<TerraformProviderResource> WithOutputFolder(
        this IResourceBuilder<TerraformProviderResource> builder,
        string outputFolder)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrWhiteSpace(outputFolder);

        builder.Resource.OutputFolder = outputFolder;
        return builder;
    }

    /// <summary>
    /// Sets the working directory for Terraform operations.
    /// </summary>
    /// <param name="builder">The resource builder.</param>
    /// <param name="workingDirectory">The working directory path.</param>
    /// <returns>The resource builder.</returns>
    public static IResourceBuilder<TerraformProviderResource> WithWorkingDirectory(
        this IResourceBuilder<TerraformProviderResource> builder,
        string workingDirectory)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrWhiteSpace(workingDirectory);

        builder.Resource.WorkingDirectory = workingDirectory;
        return builder;
    }

    /// <summary>
    /// Sets the template path for code generation.
    /// </summary>
    /// <param name="builder">The resource builder.</param>
    /// <param name="templatePath">The template path.</param>
    /// <returns>The resource builder.</returns>
    public static IResourceBuilder<TerraformProviderResource> WithTemplatePath(
        this IResourceBuilder<TerraformProviderResource> builder,
        string templatePath)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrWhiteSpace(templatePath);

        builder.Resource.TemplatePath = templatePath;
        return builder;
    }

    private static PipelineStep CreateProviderPipelineStep(TerraformProviderResource provider, PipelineStepFactoryContext context)
    {
        var step = new PipelineStep
        {
            Name = $"codegen-{provider.Name}",
            Resource = provider,
            Action = async stepContext => await ExecuteCodeGenAsync(provider, stepContext),
            Tags = { "codegen", "terraform" }
        };

        // This step should run as part of the publish phase
        step.RequiredBy(WellKnownPipelineSteps.Publish);

        return step;
    }

    private static async Task ExecuteCodeGenAsync(TerraformProviderResource provider, PipelineStepContext stepContext)
    {
        var logger = stepContext.Logger;
        var step = stepContext.ReportingStep;

        var initTask = await step.CreateTaskAsync($"Initializing {provider.ProviderName}", stepContext.CancellationToken);
        try
        {
            logger.LogInformation("Starting code generation for provider: {ProviderName}", provider.ProviderName);

            // Get the AppHost directory from configuration (set by Aspire)
            var configuration = stepContext.Services.GetRequiredService<IConfiguration>();
            var appHostDirectory = configuration["AppHost:Directory"]
                ?? throw new InvalidOperationException("AppHost:Directory not found in configuration");

            // Go one level up from AppHost directory to get the repository root
            var repositoryRoot = Directory.GetParent(appHostDirectory)?.FullName
                ?? throw new InvalidOperationException("Could not determine repository root from AppHost directory");

            var templatePath = provider.TemplatePath ?? Path.Combine(AppContext.BaseDirectory, "Templates", "Files");
            var workingDir = provider.WorkingDirectory ?? Path.Combine(Directory.GetCurrentDirectory(), ".terraform-codegen", provider.ProviderName);

            logger.LogInformation("AppHost directory: {AppHostDirectory}", appHostDirectory);
            logger.LogInformation("Repository root: {RepositoryRoot}", repositoryRoot);
            logger.LogInformation("Template path: {TemplatePath}", templatePath);
            logger.LogInformation("Working directory: {WorkingDirectory}", workingDir);

            await initTask.CompleteAsync("Initialized", CompletionState.Completed, stepContext.CancellationToken);

            // Step 1: Generate Terraform configuration
            var configTask = await step.CreateTaskAsync($"Generating Terraform configuration", stepContext.CancellationToken);
            Directory.CreateDirectory(workingDir);

            var terraformConfig = await GenerateTerraformConfigAsync(provider, templatePath, stepContext.CancellationToken);
            var configPath = Path.Combine(workingDir, "main.tf");
            await File.WriteAllTextAsync(configPath, terraformConfig, stepContext.CancellationToken);
            logger.LogInformation("Generated Terraform config at {ConfigPath}", configPath);
            await configTask.CompleteAsync("Configuration generated", CompletionState.Completed, stepContext.CancellationToken);

            // Step 2: Generate schema
            var schemaTask = await step.CreateTaskAsync($"Generating provider schema", stepContext.CancellationToken);
            var schemaPath = Path.Combine(workingDir, "schema.json");
            await GenerateSchemaAsync(workingDir, schemaPath, logger, stepContext.CancellationToken);
            await schemaTask.CompleteAsync("Schema generated", CompletionState.Completed, stepContext.CancellationToken);

            // Step 3: Parse the schema
            var parseTask = await step.CreateTaskAsync($"Parsing schema", stepContext.CancellationToken);
            var schemaJson = await File.ReadAllTextAsync(schemaPath, stepContext.CancellationToken);
            var parser = new SchemaParser();
            var schemaRoot = parser.ParseSchema(schemaJson);

            var providerSchema = schemaRoot.ProviderSchemas.Values.FirstOrDefault()
                ?? throw new InvalidOperationException($"No provider schema found in {schemaPath}");

            logger.LogInformation("Found {ResourceCount} resources and {DataSourceCount} data sources",
                providerSchema.ResourceSchemas.Count,
                providerSchema.DataSourceSchemas.Count);

            var resources = parser.ParseResources(providerSchema, provider.ProviderName);
            var dataSources = parser.ParseDataSources(providerSchema, provider.ProviderName);
            await parseTask.CompleteAsync("Schema parsed", CompletionState.Completed, stepContext.CancellationToken);

            // Step 4: Set up output folder structure
            var outputFolder = provider.OutputFolder ?? Path.Combine(repositoryRoot, provider.Namespace);
            if (Directory.Exists(outputFolder))
            {
                Directory.Delete(outputFolder, recursive: true);
            }
            Directory.CreateDirectory(outputFolder);

            var resourcesFolder = Path.Combine(outputFolder, "Resources");
            var dataSourcesFolder = Path.Combine(outputFolder, "DataSources");
            Directory.CreateDirectory(resourcesFolder);
            Directory.CreateDirectory(dataSourcesFolder);

            // Step 5: Generate .csproj file first
            var csprojTask = await step.CreateTaskAsync($"Generating project file", stepContext.CancellationToken);
            var csprojContent = await GenerateCsprojFileAsync(templatePath, stepContext.CancellationToken);
            var csprojPath = Path.Combine(outputFolder, $"{provider.Namespace}.csproj");
            await File.WriteAllTextAsync(csprojPath, csprojContent, stepContext.CancellationToken);
            logger.LogInformation("Generated project file: {CsprojPath}", csprojPath);
            await csprojTask.CompleteAsync("Project file generated", CompletionState.Completed, stepContext.CancellationToken);

            // Step 6: Generate provider class
            var providerClassTask = await step.CreateTaskAsync($"Generating provider class", stepContext.CancellationToken);
            var providerTemplate = new ProviderTemplate(templatePath);
            var providerConfig = new Models.ProviderConfig
            {
                Name = provider.ProviderName,
                Namespace = provider.Namespace,
                FolderPath = outputFolder,
                Version = provider.Version
            };
            var providerCode = providerTemplate.Generate(providerConfig);
            var providerClassName = GetProviderClassName(provider.Namespace);
            var providerClassPath = Path.Combine(outputFolder, $"{providerClassName}.cs");
            await File.WriteAllTextAsync(providerClassPath, providerCode, stepContext.CancellationToken);
            logger.LogInformation("Generated provider class: {ProviderClassPath}", providerClassPath);
            await providerClassTask.CompleteAsync("Provider class generated", CompletionState.Completed, stepContext.CancellationToken);

            // Step 7: Generate resources and data sources in parallel
            var codeGenTask = await step.CreateTaskAsync($"Generating {resources.Count + dataSources.Count} classes", stepContext.CancellationToken);

            var resourceTemplate = new ResourceTemplate(templatePath);
            var dataSourceTemplate = new DataSourceTemplate(templatePath);

            // Generate resources in parallel
            var resourceGenerationTasks = resources.Select(async resource =>
            {
                var code = resourceTemplate.Generate(resource, provider.Namespace);
                var filePath = Path.Combine(resourcesFolder, $"{resource.ClassName}.cs");
                await File.WriteAllTextAsync(filePath, code, stepContext.CancellationToken);
            });

            // Generate data sources in parallel
            var dataSourceGenerationTasks = dataSources.Select(async dataSource =>
            {
                var code = dataSourceTemplate.Generate(dataSource, provider.Namespace);
                var filePath = Path.Combine(dataSourcesFolder, $"{dataSource.ClassName}.cs");
                await File.WriteAllTextAsync(filePath, code, stepContext.CancellationToken);
            });

            // Wait for all generations to complete
            await Task.WhenAll(resourceGenerationTasks.Concat(dataSourceGenerationTasks));

            logger.LogInformation("Generated {ResourceCount} resources and {DataSourceCount} data sources", resources.Count, dataSources.Count);
            await codeGenTask.CompleteAsync($"{resources.Count + dataSources.Count} classes generated", CompletionState.Completed, stepContext.CancellationToken);

            logger.LogInformation("✅ Code generation completed for {ProviderName}: {ResourceCount} resources, {DataSourceCount} data sources",
                provider.ProviderName,
                resources.Count,
                dataSources.Count);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "❌ Error generating code for provider {ProviderName}", provider.ProviderName);
            await initTask.FailAsync(ex.Message, stepContext.CancellationToken);
            throw;
        }
    }

    private static async Task<string> GenerateTerraformConfigAsync(TerraformProviderResource provider, string templatePath, CancellationToken cancellationToken)
    {
        var templateFile = Path.Combine(templatePath, $"{provider.ProviderName}.tf.mustache");
        if (!File.Exists(templateFile))
        {
            throw new FileNotFoundException($"Terraform template not found: {templateFile}");
        }

        var template = await File.ReadAllTextAsync(templateFile, cancellationToken);
        var stubble = new Stubble.Core.Builders.StubbleBuilder().Build();
        return stubble.Render(template, new { provider.Version });
    }

    private static async Task GenerateSchemaAsync(string providerFolder, string outputPath, ILogger logger, CancellationToken cancellationToken)
    {
        logger.LogInformation("Running: terraform init");
        await RunCommandAsync("terraform", "init", providerFolder, logger, cancellationToken);

        logger.LogInformation("Running: terraform providers schema -json");
        var schemaJson = await RunCommandWithOutputAsync("terraform", "providers schema -json", providerFolder, logger, cancellationToken);

        await File.WriteAllTextAsync(outputPath, schemaJson, cancellationToken);
        logger.LogInformation("Schema saved to: {OutputPath}", outputPath);
    }

    private static async Task<string> GenerateCsprojFileAsync(string templatePath, CancellationToken cancellationToken)
    {
        var templateFile = Path.Combine(templatePath, "Provider.csproj.mustache");
        return await File.ReadAllTextAsync(templateFile, cancellationToken);
    }

    private static async Task RunCommandAsync(string command, string arguments, string workingDirectory, ILogger logger, CancellationToken cancellationToken)
    {
        var processStartInfo = new ProcessStartInfo
        {
            FileName = command,
            Arguments = arguments,
            WorkingDirectory = workingDirectory,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        using var process = Process.Start(processStartInfo)
            ?? throw new InvalidOperationException($"Failed to start process: {command}");

        await process.WaitForExitAsync(cancellationToken);

        if (process.ExitCode != 0)
        {
            var error = await process.StandardError.ReadToEndAsync(cancellationToken);
            throw new InvalidOperationException($"Command failed with exit code {process.ExitCode}: {error}");
        }
    }

    private static async Task<string> RunCommandWithOutputAsync(string command, string arguments, string workingDirectory, ILogger logger, CancellationToken cancellationToken)
    {
        var processStartInfo = new ProcessStartInfo
        {
            FileName = command,
            Arguments = arguments,
            WorkingDirectory = workingDirectory,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        using var process = Process.Start(processStartInfo)
            ?? throw new InvalidOperationException($"Failed to start process: {command}");

        var output = await process.StandardOutput.ReadToEndAsync(cancellationToken);
        await process.WaitForExitAsync(cancellationToken);

        if (process.ExitCode != 0)
        {
            var error = await process.StandardError.ReadToEndAsync(cancellationToken);
            throw new InvalidOperationException($"Command failed with exit code {process.ExitCode}: {error}");
        }

        return output;
    }

    private static string GetProviderClassName(string namespaceName)
    {
        // Extract the last segment of the namespace and append "Provider"
        // e.g., "EmmittJ.Terraform.Sdk.Providers.Aws" -> "AwsProvider"
        // e.g., "EmmittJ.Terraform.Sdk.Providers.AzureRM" -> "AzureRMProvider"

        var lastSegment = namespaceName.Split('.').Last();
        return $"{lastSegment}Provider";
    }
}

/// <summary>
/// Annotation for Terraform provider resources to enable pipeline integration.
/// </summary>
internal sealed class TerraformProviderAnnotation : IResourceAnnotation
{
}
