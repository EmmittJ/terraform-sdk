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
            .WithPipelineStepFactory(context => CreateProviderPipelineSteps(resource, context));
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
            .WithPipelineStepFactory(context => CreateProviderPipelineSteps(resource, context));
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

    private static List<PipelineStep> CreateProviderPipelineSteps(TerraformProviderResource provider, PipelineStepFactoryContext context)
    {
        // Schema generation step (must run first)
        var schemaStep = new PipelineStep
        {
            Name = $"schema-{provider.Name}",
            Resource = provider,
            Action = async stepContext => await GenerateSchemaStepAsync(provider, stepContext),
            Tags = { "codegen", "terraform", "schema" }
        };

        // Project file step (can run after schema)
        var projectStep = new PipelineStep
        {
            Name = $"project-{provider.Name}",
            Resource = provider,
            Action = async stepContext => await GenerateProjectFileStepAsync(provider, stepContext),
            Tags = { "codegen", "terraform", "project" }
        };
        projectStep.DependsOn(schemaStep);

        // Provider class step (can run after schema, in parallel with project/resources/datasources)
        var providerClassStep = new PipelineStep
        {
            Name = $"provider-class-{provider.Name}",
            Resource = provider,
            Action = async stepContext => await GenerateProviderClassStepAsync(provider, stepContext),
            Tags = { "codegen", "terraform", "provider" }
        };
        providerClassStep.DependsOn(schemaStep);

        // Resources step (can run after schema, in parallel with project/provider/datasources)
        var resourcesStep = new PipelineStep
        {
            Name = $"resources-{provider.Name}",
            Resource = provider,
            Action = async stepContext => await GenerateResourcesStepAsync(provider, stepContext),
            Tags = { "codegen", "terraform", "resources" }
        };
        resourcesStep.DependsOn(schemaStep);

        // Data sources step (can run after schema, in parallel with project/provider/resources)
        var dataSourcesStep = new PipelineStep
        {
            Name = $"datasources-{provider.Name}",
            Resource = provider,
            Action = async stepContext => await GenerateDataSourcesStepAsync(provider, stepContext),
            Tags = { "codegen", "terraform", "datasources" }
        };
        dataSourcesStep.DependsOn(schemaStep);

        // All steps should be required by publish
        schemaStep.RequiredBy(WellKnownPipelineSteps.Publish);
        projectStep.RequiredBy(WellKnownPipelineSteps.Publish);
        providerClassStep.RequiredBy(WellKnownPipelineSteps.Publish);
        resourcesStep.RequiredBy(WellKnownPipelineSteps.Publish);
        dataSourcesStep.RequiredBy(WellKnownPipelineSteps.Publish);

        return [schemaStep, projectStep, providerClassStep, resourcesStep, dataSourcesStep];
    }

    private static async Task GenerateSchemaStepAsync(TerraformProviderResource provider, PipelineStepContext stepContext)
    {
        var logger = stepContext.Logger;
        var step = stepContext.ReportingStep;

        var initTask = await step.CreateTaskAsync($"Generating schema for {provider.ProviderName}", stepContext.CancellationToken);
        try
        {
            var (repositoryRoot, templatePath, workingDir) = GetProviderPaths(provider, stepContext);

            // Step 1: Generate Terraform configuration
            Directory.CreateDirectory(workingDir);
            var terraformConfig = await GenerateTerraformConfigAsync(provider, templatePath, stepContext.CancellationToken);
            var configPath = Path.Combine(workingDir, "main.tf");
            await File.WriteAllTextAsync(configPath, terraformConfig, stepContext.CancellationToken);

            // Step 2: Generate schema
            var schemaPath = Path.Combine(workingDir, "schema.json");
            await GenerateSchemaAsync(workingDir, schemaPath, logger, stepContext.CancellationToken);

            await initTask.CompleteAsync("Schema generated", CompletionState.Completed, stepContext.CancellationToken);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "❌ Error generating schema for provider {ProviderName}", provider.ProviderName);
            await initTask.FailAsync(ex.Message, stepContext.CancellationToken);
            throw;
        }
    }

    private static async Task GenerateProjectFileStepAsync(TerraformProviderResource provider, PipelineStepContext stepContext)
    {
        var logger = stepContext.Logger;
        var step = stepContext.ReportingStep;

        var task = await step.CreateTaskAsync($"Generating project file", stepContext.CancellationToken);
        try
        {
            var (repositoryRoot, templatePath, workingDir) = GetProviderPaths(provider, stepContext);
            var outputFolder = provider.OutputFolder ?? Path.Combine(repositoryRoot, provider.Namespace);

            Directory.CreateDirectory(outputFolder);

            var csprojContent = await GenerateCsprojFileAsync(templatePath, stepContext.CancellationToken);
            var csprojPath = Path.Combine(outputFolder, $"{provider.Namespace}.csproj");
            await File.WriteAllTextAsync(csprojPath, csprojContent, stepContext.CancellationToken);

            logger.LogInformation("Generated project file: {CsprojPath}", csprojPath);
            await task.CompleteAsync("Project file generated", CompletionState.Completed, stepContext.CancellationToken);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "❌ Error generating project file for {ProviderName}", provider.ProviderName);
            await task.FailAsync(ex.Message, stepContext.CancellationToken);
            throw;
        }
    }

    private static async Task GenerateProviderClassStepAsync(TerraformProviderResource provider, PipelineStepContext stepContext)
    {
        var logger = stepContext.Logger;
        var step = stepContext.ReportingStep;

        var task = await step.CreateTaskAsync($"Generating provider class", stepContext.CancellationToken);
        try
        {
            var (repositoryRoot, templatePath, workingDir) = GetProviderPaths(provider, stepContext);
            var outputFolder = provider.OutputFolder ?? Path.Combine(repositoryRoot, provider.Namespace);

            // Parse schema to get provider configuration and counts
            var schemaPath = Path.Combine(workingDir, "schema.json");
            var schemaJson = await File.ReadAllTextAsync(schemaPath, stepContext.CancellationToken);
            var parser = new SchemaParser();
            var schemaRoot = parser.ParseSchema(schemaJson);
            var providerSchema = schemaRoot.ProviderSchemas.Values.FirstOrDefault()
                ?? throw new InvalidOperationException($"No provider schema found in {schemaPath}");

            // Extract provider configuration attributes
            var configurationAttributes = new List<Models.PropertyModel>();
            if (providerSchema.Provider?.Block != null)
            {
                foreach (var (attrName, attr) in providerSchema.Provider.Block.Attributes)
                {
                    var csharpType = parser.MapTerraformTypeToCSharp(attr.Type);
                    var isCollection = csharpType.Contains("List<") || csharpType.Contains("Dictionary<") || csharpType.Contains("HashSet<");

                    // Extract the inner type from TerraformProperty<T> or collection types
                    var isValueType = false;
                    if (csharpType.StartsWith("TerraformProperty<"))
                    {
                        // Extract T from TerraformProperty<T>
                        var innerType = csharpType.Substring("TerraformProperty<".Length, csharpType.Length - "TerraformProperty<".Length - 1);
                        isValueType = innerType == "bool" || innerType == "double" || innerType == "int" || innerType == "long" || innerType == "float";
                    }

                    configurationAttributes.Add(new Models.PropertyModel
                    {
                        Name = parser.ToPascalCase(attrName),
                        TerraformName = attrName,
                        CSharpType = csharpType,
                        Description = attr.Description ?? $"The {attrName} configuration.",
                        IsRequired = attr.Required,
                        IsOptional = attr.Optional,
                        IsComputed = attr.Computed,
                        IsSensitive = attr.Sensitive,
                        IsDeprecated = attr.Deprecated,
                        IsCollection = isCollection,
                        IsValueType = isValueType
                    });
                }
            }

            var providerTemplate = new ProviderTemplate(templatePath);
            var providerConfig = new Models.ProviderConfig
            {
                Name = provider.ProviderName,
                Namespace = provider.Namespace,
                FolderPath = outputFolder,
                Version = provider.Version,
                Description = providerSchema.Provider?.Block?.Description,
                ResourceCount = providerSchema.ResourceSchemas.Count,
                DataSourceCount = providerSchema.DataSourceSchemas.Count,
                ConfigurationAttributes = configurationAttributes
            };
            var providerCode = providerTemplate.Generate(providerConfig);
            var providerClassName = GetProviderClassName(provider.Namespace);
            var providerClassPath = Path.Combine(outputFolder, $"{providerClassName}.cs");
            await File.WriteAllTextAsync(providerClassPath, providerCode, stepContext.CancellationToken);

            logger.LogInformation("Generated provider class: {ProviderClassPath} ({ResourceCount} resources, {DataSourceCount} data sources, {ConfigCount} config attributes)",
                providerClassPath, providerConfig.ResourceCount, providerConfig.DataSourceCount, configurationAttributes.Count);
            await task.CompleteAsync("Provider class generated", CompletionState.Completed, stepContext.CancellationToken);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "❌ Error generating provider class for {ProviderName}", provider.ProviderName);
            await task.FailAsync(ex.Message, stepContext.CancellationToken);
            throw;
        }
    }

    private static async Task GenerateResourcesStepAsync(TerraformProviderResource provider, PipelineStepContext stepContext)
    {
        var logger = stepContext.Logger;
        var step = stepContext.ReportingStep;

        var task = await step.CreateTaskAsync($"Generating resources", stepContext.CancellationToken);
        try
        {
            var (repositoryRoot, templatePath, workingDir) = GetProviderPaths(provider, stepContext);
            var outputFolder = provider.OutputFolder ?? Path.Combine(repositoryRoot, provider.Namespace);

            // Parse schema
            var schemaPath = Path.Combine(workingDir, "schema.json");
            var schemaJson = await File.ReadAllTextAsync(schemaPath, stepContext.CancellationToken);
            var parser = new SchemaParser();
            var schemaRoot = parser.ParseSchema(schemaJson);
            var providerSchema = schemaRoot.ProviderSchemas.Values.FirstOrDefault()
                ?? throw new InvalidOperationException($"No provider schema found in {schemaPath}");

            var resources = parser.ParseResources(providerSchema, provider.ProviderName);

            var resourcesFolder = Path.Combine(outputFolder, "Resources");
            Directory.CreateDirectory(resourcesFolder);

            var resourceTemplate = new ResourceTemplate(templatePath);
            var resourceGenerationTasks = resources.Select(async resource =>
            {
                var code = resourceTemplate.Generate(resource, provider.Namespace);
                var filePath = Path.Combine(resourcesFolder, $"{resource.ClassName}.cs");
                await File.WriteAllTextAsync(filePath, code, stepContext.CancellationToken);
            });

            await Task.WhenAll(resourceGenerationTasks);

            logger.LogInformation("Generated {ResourceCount} resources", resources.Count);
            await task.CompleteAsync($"{resources.Count} resources generated", CompletionState.Completed, stepContext.CancellationToken);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "❌ Error generating resources for {ProviderName}", provider.ProviderName);
            await task.FailAsync(ex.Message, stepContext.CancellationToken);
            throw;
        }
    }

    private static async Task GenerateDataSourcesStepAsync(TerraformProviderResource provider, PipelineStepContext stepContext)
    {
        var logger = stepContext.Logger;
        var step = stepContext.ReportingStep;

        var task = await step.CreateTaskAsync($"Generating data sources", stepContext.CancellationToken);
        try
        {
            var (repositoryRoot, templatePath, workingDir) = GetProviderPaths(provider, stepContext);
            var outputFolder = provider.OutputFolder ?? Path.Combine(repositoryRoot, provider.Namespace);

            // Parse schema
            var schemaPath = Path.Combine(workingDir, "schema.json");
            var schemaJson = await File.ReadAllTextAsync(schemaPath, stepContext.CancellationToken);
            var parser = new SchemaParser();
            var schemaRoot = parser.ParseSchema(schemaJson);
            var providerSchema = schemaRoot.ProviderSchemas.Values.FirstOrDefault()
                ?? throw new InvalidOperationException($"No provider schema found in {schemaPath}");

            var dataSources = parser.ParseDataSources(providerSchema, provider.ProviderName);

            var dataSourcesFolder = Path.Combine(outputFolder, "DataSources");
            Directory.CreateDirectory(dataSourcesFolder);

            var dataSourceTemplate = new DataSourceTemplate(templatePath);
            var dataSourceGenerationTasks = dataSources.Select(async dataSource =>
            {
                var code = dataSourceTemplate.Generate(dataSource, provider.Namespace);
                var filePath = Path.Combine(dataSourcesFolder, $"{dataSource.ClassName}.cs");
                await File.WriteAllTextAsync(filePath, code, stepContext.CancellationToken);
            });

            await Task.WhenAll(dataSourceGenerationTasks);

            logger.LogInformation("Generated {DataSourceCount} data sources", dataSources.Count);
            await task.CompleteAsync($"{dataSources.Count} data sources generated", CompletionState.Completed, stepContext.CancellationToken);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "❌ Error generating data sources for {ProviderName}", provider.ProviderName);
            await task.FailAsync(ex.Message, stepContext.CancellationToken);
            throw;
        }
    }

    private static (string repositoryRoot, string templatePath, string workingDir) GetProviderPaths(
        TerraformProviderResource provider,
        PipelineStepContext stepContext)
    {
        var configuration = stepContext.Services.GetRequiredService<IConfiguration>();
        var appHostDirectory = configuration["AppHost:Directory"]
            ?? throw new InvalidOperationException("AppHost:Directory not found in configuration");

        var repositoryRoot = Directory.GetParent(appHostDirectory)?.FullName
            ?? throw new InvalidOperationException("Could not determine repository root from AppHost directory");

        var templatePath = provider.TemplatePath ?? Path.Combine(AppContext.BaseDirectory, "Templates", "Files");
        var workingDir = provider.WorkingDirectory ?? Path.Combine(Directory.GetCurrentDirectory(), ".terraform-codegen", provider.ProviderName);

        return (repositoryRoot, templatePath, workingDir);
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
