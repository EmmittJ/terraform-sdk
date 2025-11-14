# Terraform SDK Code Generation - Aspire Integration

This project uses .NET Aspire's distributed application model and eventing system for orchestrating Terraform provider code generation.

## Architecture

### Project Structure

**EmmittJ.Terraform.Sdk.AppHost** (Executable)

- Aspire AppHost that orchestrates the code generation process
- Contains all code generation logic (parsers, templates, schema)
- Defines custom Aspire resources: `TerraformProviderResource`
- Implements `IDistributedApplicationEventingSubscriber` to integrate with Aspire's eventing system
- Provides extension methods for adding Terraform providers to the AppHost

### Architectural Layers

**Phases 1-3 Complete - Core Infrastructure:**

1. **Infrastructure Layer** (`Infrastructure/`) ✅

   - `IFileSystem` / `FileSystemWrapper`: Testable file operations
   - `ITerraformCli` / `TerraformCliExecutor`: Testable Terraform CLI execution

2. **Schema Layer** (`Schema/`) ✅

   - `ISchemaParser`: Interface for parsing Terraform provider schemas
   - `ProviderSchema.cs`: JSON schema models matching Terraform specification
   - `SchemaParser.cs`: Current implementation (to be refactored to use ModelBuilder)

3. **Code Generation Layer** (`CodeGen/`) ✅

   - `ITypeMapper` / `TypeMapper`: Maps Terraform types → C# types (extracted from SchemaParser)
   - `IModelBuilder` / `ModelBuilder`: Transforms schema models → code generation models
   - `NamingConventions`: String utilities (PascalCase, camelCase, ClassName)

4. **Template Layer** (`Templates/`) ✅

   - `ITemplateRenderer` / `MustacheTemplateRenderer`: Template rendering with Stubble
   - `ViewModelTransformer`: Transforms models → template view models (extracted from TemplateHelpers)
   - Mustache templates in `Files/`
   - Template classes (ResourceTemplate, DataSourceTemplate, etc.)

5. **Configuration** ✅
   - `TerraformCodeGenOptions`: Centralized configuration options

**Remaining Work:**

- Phase 4: Aspire eventing infrastructure (Environment resources, contexts)
- Phase 6: Service registration, update existing code to use new components

### Key Features

- **Eventing-based execution**: Triggered on `BeforeStartEvent` during publish mode
- **Testable design**: All external dependencies behind interfaces
- **Type safety**: Compile-time type mapping with `ITypeMapper`
- **Progress tracking**: Aspire Dashboard shows real-time progress of each generation step
- **Error handling**: Granular error reporting per provider
- **Extensibility**: Easy to add new providers or customize generation behavior
- **Following Aspire Patterns**: Aligned with Kubernetes/Azure AppContainers infrastructure extensions

## Usage

### Running Code Generation

To generate provider code, use the `aspire publish` command:

```powershell
# From the repository root
aspire publish

# Or specify the project explicitly
aspire publish --project src\EmmittJ.Terraform.Sdk.AppHost\EmmittJ.Terraform.Sdk.AppHost.csproj
```

This will:

1. Execute the code generation pipeline for all configured providers
2. Generate the provider class (e.g., `AwsProvider`, `AzureRMProvider`, `AzureADProvider`, `GoogleProvider`)
3. Generate all resource classes in the `Resources/` folder
4. Generate all data source classes in the `DataSources/` folder
5. Generate the `.csproj` file for each provider
6. Output generated code to the configured output folders

**Note:** You can also use `dotnet run` to start the Aspire Dashboard for real-time monitoring:

```powershell
# For interactive dashboard (requires HTTPS or ASPIRE_ALLOW_UNSECURED_TRANSPORT=true)
dotnet run --project src\EmmittJ.Terraform.Sdk.AppHost\EmmittJ.Terraform.Sdk.AppHost.csproj
```

### Configuring Providers

Edit `EmmittJ.Terraform.Sdk.AppHost/AppHost.cs`:

```csharp
var builder = DistributedApplication.CreateBuilder(args);

// Enable Terraform code generation pipeline
builder.AddTerraformCodeGenPipeline();

// Add providers with configuration
var aws = builder.AddTerraformProvider("aws", "~> 6.0")
    .WithNamespace("EmmittJ.Terraform.Sdk.Providers.Aws")
    .WithOutputFolder(@"C:\custom\path"); // Optional

var myProvider = builder.AddTerraformProvider("myprovider", "~> 1.0")
    .WithNamespace("EmmittJ.Terraform.Sdk.Providers.MyProvider")
    .WithWorkingDirectory(@"C:\temp\terraform") // Optional
    .WithTemplatePath(@"C:\templates"); // Optional

builder.Build().Run();
```

### Pipeline Execution Flow

For each provider, the pipeline executes these steps:

1. **Initialize** - Set up workspace and paths
2. **Generate Terraform Config** - Create `main.tf` from template
3. **Generate Schema** - Run `terraform init` and `terraform providers schema`
4. **Parse Schema** - Extract resources and data sources from JSON schema
5. **Generate Project File** - Create `.csproj` file
6. **Generate Provider Class** - Create the provider class (e.g., `AwsProvider.cs`, `AzureRMProvider.cs`)
7. **Generate Resources** - Create C# resource classes in parallel
8. **Generate Data Sources** - Create C# data source classes in parallel

Each step is tracked independently in the Aspire Dashboard with success/failure status.

### Generated Provider Classes

The code generation automatically creates a provider class for each configured provider:

- **AWS** → `AwsProvider` in `EmmittJ.Terraform.Sdk.Providers.Aws`
- **Azure RM** → `AzureRMProvider` in `EmmittJ.Terraform.Sdk.Providers.AzureRM`
- **Azure AD** → `AzureADProvider` in `EmmittJ.Terraform.Sdk.Providers.AzureAD`
- **Google** → `GoogleProvider` in `EmmittJ.Terraform.Sdk.Providers.Google`

These classes inherit from `TerraformProvider` and can be used in your Terraform stacks:

```csharp
using EmmittJ.Terraform.Sdk;
using EmmittJ.Terraform.Sdk.Providers.Aws;

var stack = new TerraformStack();

// Add the AWS provider
var awsProvider = new AwsProvider();
stack.Add(awsProvider);

// Or with a custom alias
var awsUsWest = new AwsProvider("aws_us_west")
{
    Alias = "us-west-2"
};
stack.Add(awsUsWest);
```

## Benefits of Aspire Integration

### Before (Console App)

- Sequential processing only
- Console output only
- Manual error handling
- No progress visibility
- Hard to debug failures
- Monolithic execution

### After (Aspire AppHost)

- Parallel processing per provider
- Rich dashboard UI with real-time progress
- Built-in error handling and reporting
- Detailed task breakdowns
- Easy to debug individual providers
- Modular, extensible pipeline steps

## Development

### Adding a New Provider

1. Add the provider in `AppHost.cs`:

   ```csharp
   builder.AddTerraformProvider("newprovider", "~> 2.0")
       .WithNamespace("EmmittJ.Terraform.Sdk.Providers.NewProvider");
   ```

2. Create a Terraform template in `Templates/Files/newprovider.tf.mustache`:

   ```hcl
   terraform {
     required_providers {
       newprovider = {
         source  = "hashicorp/newprovider"
         version = "{{Version}}"
       }
     }
   }

   provider "newprovider" {}
   ```

3. Run the AppHost - code generation happens automatically!

### Customizing Pipeline Steps

You can add custom pipeline steps by modifying `TerraformCodeGenPipelineHook.cs` or by adding annotations to resources:

```csharp
provider.Annotations.Add(new PipelineStepAnnotation(context =>
{
    return new PipelineStep
    {
        Name = "custom-validation",
        Action = async ctx =>
        {
            // Custom logic here
            using var task = ctx.ReportingStep.CreateTask("Validating...");
            // Do work
            task.Complete();
        }
    };
}));
```

## Dashboard Features

When running the AppHost, the Aspire Dashboard provides:

- **Resources View**: See all configured providers and their status
- **Console Logs**: Real-time logging output from each provider's generation
- **Traces**: OpenTelemetry traces for performance analysis
- **Metrics**: Track generation times and success rates

## Requirements

- .NET 10.0 RC or later
- Terraform CLI (must be in PATH)
- Aspire 13.1 (preview)

## Migration Notes

The original console application from `EmmittJ.Terraform.Sdk.CodeGen` has been fully integrated into this AppHost. The new architecture provides:

- Better separation of concerns (resources, pipeline, extensions)
- Type-safe configuration through extension methods
- Observable execution through Aspire Dashboard
- Foundation for future enhancements (caching, incremental generation, etc.)
