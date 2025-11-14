#pragma warning disable ASPIREPIPELINES001

using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Pipelines;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EmmittJ.Terraform.Sdk.AppHost.Resources;

/// <summary>
/// Represents a Terraform provider that will have its resources and data sources generated.
/// </summary>
public sealed class TerraformProviderResource : Resource
{
    /// <summary>
    /// Gets the Terraform provider name (e.g., "aws", "azurerm").
    /// </summary>
    public string ProviderName { get; }

    /// <summary>
    /// Gets the version constraint for the provider (e.g., "~> 6.0").
    /// </summary>
    public string Version { get; }

    public TerraformProviderResource(string name, string providerName, string version) : base(name)
    {
        ProviderName = providerName;
        Version = version;

        // Add pipeline step annotation to generate code for this provider
        Annotations.Add(new PipelineStepAnnotation((factoryContext) =>
        {
            return Task.FromResult(CreateSteps(factoryContext));
        }));
    }

    private IEnumerable<PipelineStep> CreateSteps(PipelineStepFactoryContext factoryContext)
    {
        var model = factoryContext.PipelineContext.Model;

        // Find the code gen environment
        var environment = model.Resources.OfType<TerraformCodeGenEnvironmentResource>().FirstOrDefault();
        if (environment is null)
        {
            throw new InvalidOperationException(
                $"No {nameof(TerraformCodeGenEnvironmentResource)} found in the model. " +
                $"Add one by calling AddTerraformCodeGenEnvironment().");
        }

        // Step 1: Generate schema
        var generateSchemaStep = new PipelineStep
        {
            Name = $"generate-schema-{ProviderName}",
            Action = async context => await GenerateSchemaAsync(context, environment).ConfigureAwait(false),
            Tags = [TerraformCodeGenPipelineTags.GenerateSchema]
        };
        generateSchemaStep.DependsOn(WellKnownPipelineSteps.PublishPrereq);
        generateSchemaStep.RequiredBy(WellKnownPipelineSteps.Publish);
        yield return generateSchemaStep;

        // Step 2: Parse schema
        var parseSchemaStep = new PipelineStep
        {
            Name = $"parse-schema-{ProviderName}",
            Action = async context => await ParseSchemaAsync(context, environment).ConfigureAwait(false),
            Tags = [TerraformCodeGenPipelineTags.ParseSchema]
        };
        parseSchemaStep.DependsOn(generateSchemaStep);
        yield return parseSchemaStep;

        // Step 3: Generate code
        var generateCodeStep = new PipelineStep
        {
            Name = $"generate-code-{ProviderName}",
            Action = async context => await GenerateCodeAsync(context, environment).ConfigureAwait(false),
            Tags = [TerraformCodeGenPipelineTags.GenerateCode]
        };
        generateCodeStep.DependsOn(parseSchemaStep);
        yield return generateCodeStep;
    }

    private async Task GenerateSchemaAsync(
        PipelineStepContext context,
        TerraformCodeGenEnvironmentResource environment)
    {
        var workingDirectory = Path.Combine(
            environment.WorkingDirectory,
            ProviderName);

        var codeGenServices = context.Services.GetRequiredService<TerraformCodeGenServices>();

        // Create working directory
        codeGenServices.FileSystem.CreateDirectory(workingDirectory);

        // Generate Terraform configuration file
        var terraformConfig = $@"terraform {{
  required_providers {{
    {ProviderName} = {{
      source  = ""hashicorp/{ProviderName}""
      version = ""{Version}""
    }}
  }}
}}

provider ""{ProviderName}"" {{
}}
";

        var configPath = Path.Combine(workingDirectory, "main.tf");
        await codeGenServices.FileSystem.WriteAllTextAsync(configPath, terraformConfig, context.CancellationToken);

        // Initialize Terraform
        await codeGenServices.TerraformCli.InitializeAsync(workingDirectory, context.CancellationToken);

        // Generate schema
        var schemaPath = Path.Combine(workingDirectory, "schema.json");
        var schemaJson = await codeGenServices.TerraformCli.GetSchemaJsonAsync(workingDirectory, context.CancellationToken);
        await codeGenServices.FileSystem.WriteAllTextAsync(schemaPath, schemaJson, context.CancellationToken);

        await context.ReportingStep.CompleteAsync(
            $"Schema generated for {ProviderName}",
            CompletionState.Completed,
            context.CancellationToken);
    }

    private async Task ParseSchemaAsync(
        PipelineStepContext context,
        TerraformCodeGenEnvironmentResource environment)
    {
        var workingDirectory = Path.Combine(
            environment.WorkingDirectory,
            ProviderName);

        var services = context.Services.GetRequiredService<TerraformCodeGenServices>();

        var schemaPath = Path.Combine(workingDirectory, "schema.json");
        var schemaJson = await services.FileSystem.ReadAllTextAsync(schemaPath, context.CancellationToken);
        var schemaRoot = services.SchemaParser.ParseSchema(schemaJson);
        var providerSchema = schemaRoot.ProviderSchemas.Values.FirstOrDefault()
            ?? throw new InvalidOperationException($"No provider schema found for {ProviderName}");

        // Store parsed schema in annotation for next step
        Annotations.Add(new TerraformParsedSchemaAnnotation(providerSchema));

        await context.ReportingStep.CompleteAsync(
            $"Schema parsed for {ProviderName}",
            CompletionState.Completed,
            context.CancellationToken);
    }

    private async Task GenerateCodeAsync(
        PipelineStepContext context,
        TerraformCodeGenEnvironmentResource environment)
    {
        var services = context.Services.GetRequiredService<TerraformCodeGenServices>();

        // Retrieve parsed schema
        var schemaAnnotation = Annotations.OfType<TerraformParsedSchemaAnnotation>().FirstOrDefault()
            ?? throw new InvalidOperationException($"No parsed schema found for {ProviderName}");

        var providerSchema = schemaAnnotation.ProviderSchema;
        var providerNamespace = GetNamespace(environment);
        var outputDirectory = Path.Combine(services.Options.OutputDirectory, providerNamespace);

        // Generate provider class
        await GenerateProviderClassAsync(outputDirectory, providerSchema, providerNamespace, services, context.CancellationToken);

        // Generate resources
        var resources = services.SchemaParser.ParseResources(providerSchema, ProviderName);
        await GenerateResourcesAsync(outputDirectory, resources, providerNamespace, services, context.CancellationToken);

        // Generate data sources
        var dataSources = services.SchemaParser.ParseDataSources(providerSchema, ProviderName);
        await GenerateDataSourcesAsync(outputDirectory, dataSources, providerNamespace, services, context.CancellationToken);

        // Generate project file
        await GenerateProjectFileAsync(outputDirectory, providerNamespace, services, context.CancellationToken);

        await context.ReportingStep.CompleteAsync(
            $"Code generated for {ProviderName}: {resources.Count} resources, {dataSources.Count} data sources",
            CompletionState.Completed,
            context.CancellationToken);
    }

    internal string GetNamespace(TerraformCodeGenEnvironmentResource environment)
    {
        var normalizedName = char.ToUpper(ProviderName[0]) + ProviderName.Substring(1);
        return $"{environment.Namespace}.{normalizedName}";
    }

    private async Task GenerateProviderClassAsync(
        string outputDirectory,
        Schema.ProviderSchema providerSchema,
        string providerNamespace,
        TerraformCodeGenServices services,
        CancellationToken cancellationToken)
    {
        services.FileSystem.CreateDirectory(outputDirectory);

        var configAttributes = new List<Models.PropertyModel>();
        if (providerSchema.Provider?.Block != null)
        {
            foreach (var (attrName, attr) in providerSchema.Provider.Block.Attributes)
            {
                var property = services.ModelBuilder.BuildPropertyModel(attr, attrName);
                configAttributes.Add(property);
            }
        }

        var providerModel = new Models.ProviderConfig
        {
            Name = ProviderName,
            Namespace = providerNamespace,
            FolderPath = outputDirectory,
            Version = Version,
            Description = providerSchema.Provider?.Block?.Description,
            ResourceCount = providerSchema.ResourceSchemas.Count,
            DataSourceCount = providerSchema.DataSourceSchemas.Count,
            ConfigurationAttributes = configAttributes
        };

        var providerCode = services.ProviderTemplate.Generate(providerModel);
        var providerClassName = GetProviderClassName(providerNamespace);
        var providerClassPath = Path.Combine(outputDirectory, $"{providerClassName}.cs");
        await services.FileSystem.WriteAllTextAsync(providerClassPath, providerCode, cancellationToken);
    }

    private async Task GenerateResourcesAsync(
        string outputDirectory,
        List<Models.ResourceModel> resources,
        string providerNamespace,
        TerraformCodeGenServices services,
        CancellationToken cancellationToken)
    {
        var resourcesDirectory = Path.Combine(outputDirectory, "Resources");
        services.FileSystem.CreateDirectory(resourcesDirectory);

        foreach (var resource in resources)
        {
            var resourceCode = services.ResourceTemplate.Generate(resource, providerNamespace);
            var resourceClassPath = Path.Combine(resourcesDirectory, $"{resource.ClassName}.cs");
            await services.FileSystem.WriteAllTextAsync(resourceClassPath, resourceCode, cancellationToken);
        }
    }

    private async Task GenerateDataSourcesAsync(
        string outputDirectory,
        List<Models.ResourceModel> dataSources,
        string providerNamespace,
        TerraformCodeGenServices services,
        CancellationToken cancellationToken)
    {
        var dataSourcesDirectory = Path.Combine(outputDirectory, "DataSources");
        services.FileSystem.CreateDirectory(dataSourcesDirectory);

        foreach (var dataSource in dataSources)
        {
            var dataSourceCode = services.DataSourceTemplate.Generate(dataSource, providerNamespace);
            var dataSourceClassPath = Path.Combine(dataSourcesDirectory, $"{dataSource.ClassName}.cs");
            await services.FileSystem.WriteAllTextAsync(dataSourceClassPath, dataSourceCode, cancellationToken);
        }
    }

    private async Task GenerateProjectFileAsync(
        string outputDirectory,
        string providerNamespace,
        TerraformCodeGenServices services,
        CancellationToken cancellationToken)
    {
        var templatePath = Path.Combine(services.Options.TemplatesDirectory, "Provider.csproj.mustache");
        var projectContent = await services.FileSystem.ReadAllTextAsync(templatePath, cancellationToken);
        var projectPath = Path.Combine(outputDirectory, $"{providerNamespace}.csproj");
        await services.FileSystem.WriteAllTextAsync(projectPath, projectContent, cancellationToken);
    }

    private static string GetProviderClassName(string @namespace)
    {
        var parts = @namespace.Split('.');
        var providerName = parts[^1];
        return $"{providerName}Provider";
    }
}

/// <summary>
/// Annotation that holds the parsed Terraform provider schema.
/// </summary>
internal class TerraformParsedSchemaAnnotation : IResourceAnnotation
{
    public Schema.ProviderSchema ProviderSchema { get; }

    public TerraformParsedSchemaAnnotation(Schema.ProviderSchema providerSchema)
    {
        ProviderSchema = providerSchema;
    }
}
