# Terraform SDK Code Generation - Aspire Integration

This project uses .NET Aspire's distributed application model and pipeline system for orchestrating Terraform provider code generation.

## Architecture

### Project Structure

**EmmittJ.Terraform.Sdk.AppHost** (Executable)

- Aspire AppHost that orchestrates the code generation process
- Contains all code generation logic (parsers, templates, schema)
- Defines custom Aspire resources: `TerraformProviderResource`, `TerraformResourceResource`, `TerraformDataSourceResource`
- Implements `IDistributedApplicationLifecycleHook` to integrate with Aspire's pipeline system
- Provides extension methods for adding Terraform providers to the AppHost

### Key Features

- **Pipeline-based execution**: Each provider runs as an independent pipeline step
- **Parallel processing**: Multiple providers can be processed concurrently
- **Progress tracking**: Aspire Dashboard shows real-time progress of each generation step
- **Error handling**: Granular error reporting per provider with detailed task breakdowns
- **Extensibility**: Easy to add new providers or customize generation behavior

## Usage

### Running Code Generation

```powershell
cd EmmittJ.Terraform.Sdk.AppHost
# Run the AppHost
dotnet run --project EmmittJ.Terraform.Sdk.AppHost
```

This will:

1. Start the Aspire Dashboard (typically at http://localhost:15000)
2. Execute the code generation pipeline for all configured providers
3. Show real-time progress in the dashboard
4. Generate code to the configured output folders

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
5. **Generate Resources** - Create C# resource classes
6. **Generate Data Sources** - Create C# data source classes
7. **Generate Project File** - Create `.csproj` file

Each step is tracked independently in the Aspire Dashboard with success/failure status.

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
