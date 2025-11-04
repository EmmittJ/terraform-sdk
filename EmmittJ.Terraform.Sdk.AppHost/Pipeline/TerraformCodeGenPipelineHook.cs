#pragma warning disable ASPIREPIPELINES001

using System.Diagnostics;
using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Eventing;
using Aspire.Hosting.Lifecycle;
using Aspire.Hosting.Pipelines;
using EmmittJ.Terraform.Sdk.AppHost.Parsers;
using EmmittJ.Terraform.Sdk.AppHost.Resources;
using EmmittJ.Terraform.Sdk.AppHost.Templates;
using Microsoft.Extensions.Logging;

namespace EmmittJ.Terraform.Sdk.AppHost.Pipeline;

/// <summary>
/// Eventing subscriber that registers Terraform code generation pipeline steps for each provider resource.
/// </summary>
public sealed class TerraformCodeGenPipelineHook : IDistributedApplicationEventingSubscriber
{
    public Task SubscribeAsync(IDistributedApplicationEventing eventing, DistributedApplicationExecutionContext executionContext, CancellationToken cancellationToken)
    {
        eventing.Subscribe<BeforeStartEvent>(async (@event, ct) =>
        {
            var appModel = @event.Model;

            // Find all Terraform provider resources and add pipeline steps
            var terraformProviders = appModel.Resources.OfType<TerraformProviderResource>();

            foreach (var provider in terraformProviders)
            {
                // Add pipeline step annotation that will generate code for this provider
                provider.Annotations.Add(new PipelineStepAnnotation(context => CreateProviderPipelineStep(provider, context)));
            }
        });

        return Task.CompletedTask;
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
        // By marking it as required by "publish", it will execute when publishing
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

            // Determine paths
            var workspaceRoot = FindWorkspaceRoot();
            if (workspaceRoot is null)
            {
                throw new InvalidOperationException("Could not find workspace root (looking for AspireTerraform.sln)");
            }

            var templatePath = provider.TemplatePath ?? Path.Combine(AppContext.BaseDirectory, "Templates", "Files");
            var workingDir = provider.WorkingDirectory ?? Path.Combine(Directory.GetCurrentDirectory(), ".terraform-codegen", provider.ProviderName);

            logger.LogInformation("Workspace root: {WorkspaceRoot}", workspaceRoot);
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

            // Step 4: Generate code files
            var outputFolder = provider.OutputFolder ?? Path.Combine(workspaceRoot, provider.Namespace);
            if (Directory.Exists(outputFolder))
            {
                Directory.Delete(outputFolder, recursive: true);
            }
            Directory.CreateDirectory(outputFolder);

            var resourcesFolder = Path.Combine(outputFolder, "Resources");
            var dataSourcesFolder = Path.Combine(outputFolder, "DataSources");
            Directory.CreateDirectory(resourcesFolder);
            Directory.CreateDirectory(dataSourcesFolder);

            // Generate resources
            var resourceGenTask = await step.CreateTaskAsync($"Generating {resources.Count} resource classes", stepContext.CancellationToken);
            var resourceTemplate = new ResourceTemplate(templatePath);
            foreach (var resource in resources)
            {
                var code = resourceTemplate.Generate(resource, provider.Namespace);
                var filePath = Path.Combine(resourcesFolder, $"{resource.ClassName}.cs");
                await File.WriteAllTextAsync(filePath, code, stepContext.CancellationToken);
            }
            logger.LogInformation("Generated {Count} resources to {Folder}", resources.Count, resourcesFolder);
            await resourceGenTask.CompleteAsync($"{resources.Count} resources generated", CompletionState.Completed, stepContext.CancellationToken);

            // Generate data sources
            var dataSourceGenTask = await step.CreateTaskAsync($"Generating {dataSources.Count} data source classes", stepContext.CancellationToken);
            var dataSourceTemplate = new DataSourceTemplate(templatePath);
            foreach (var dataSource in dataSources)
            {
                var code = dataSourceTemplate.Generate(dataSource, provider.Namespace);
                var filePath = Path.Combine(dataSourcesFolder, $"{dataSource.ClassName}.cs");
                await File.WriteAllTextAsync(filePath, code, stepContext.CancellationToken);
            }
            logger.LogInformation("Generated {Count} data sources to {Folder}", dataSources.Count, dataSourcesFolder);
            await dataSourceGenTask.CompleteAsync($"{dataSources.Count} data sources generated", CompletionState.Completed, stepContext.CancellationToken);

            // Step 5: Generate .csproj file
            var csprojTask = await step.CreateTaskAsync($"Generating project file", stepContext.CancellationToken);
            var csprojContent = await GenerateCsprojFileAsync(templatePath, stepContext.CancellationToken);
            var csprojPath = Path.Combine(outputFolder, $"EmmittJ.Terraform.Sdk.Providers.{ToPascalCase(provider.ProviderName)}.csproj");
            await File.WriteAllTextAsync(csprojPath, csprojContent, stepContext.CancellationToken);
            logger.LogInformation("Generated project file: {CsprojPath}", csprojPath);
            await csprojTask.CompleteAsync("Project file generated", CompletionState.Completed, stepContext.CancellationToken);

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

    private static string? FindWorkspaceRoot()
    {
        var currentDir = Directory.GetCurrentDirectory();
        while (currentDir is not null)
        {
            if (File.Exists(Path.Combine(currentDir, "AspireTerraform.sln")))
            {
                return currentDir;
            }

            currentDir = Directory.GetParent(currentDir)?.FullName;
        }

        return null;
    }

    private static string ToPascalCase(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }

        var words = input.Split('_', StringSplitOptions.RemoveEmptyEntries);
        return string.Concat(words.Select(w => char.ToUpperInvariant(w[0]) + w[1..]));
    }
}
