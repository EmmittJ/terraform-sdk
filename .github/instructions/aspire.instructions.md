---
applyTo: "**/src/EmmittJ.Aspire.Hosting.Terraform/**"
---

# Aspire Integration Development

## 🔗 Integration with Aspire

The `EmmittJ.Aspire.Hosting.Terraform` library enables Terraform deployments in Aspire:

```csharp
var builder = DistributedApplication.CreateBuilder(args);

var terraform = builder.AddTerraformEnvironment("terraform")
    .WithBackend("s3", backend =>
    {
        backend["bucket"] = "my-state";
        backend["region"] = "us-west-2";
    });

var api = builder.AddProject<Projects.Api>("api")
    .PublishAsTerraform(terraform =>
    {
        // Customize Terraform infrastructure
        // terraform.Stack - the TerraformStack to add resources to
        // terraform.TargetResource - the IResource being published
        // terraform.Add() - helper to add blocks to the stack
    });
```

**Key Points**:

- Only operates during `aspire publish` (not `dotnet run`)
- Generates `main.tf` files in output directory
- Integrates with Aspire's deployment pipeline
- Supports multiple cloud providers (AWS, Azure, GCP)

## Development Guidelines

### Resource Annotations

- `TerraformConfigurationAnnotation` - Stores Terraform configuration for resources
- `TerraformCustomizationAnnotation` - Stores customization callbacks
- `TerraformEnvironmentResource` - Represents a Terraform environment in Aspire

### Publishing Context

- `TerraformPublishingContext` - Provides access to Terraform stack during publish
- `PublishingContextUtils` - Helper methods for extracting publish context
- Context is only available during `aspire publish`, not `dotnet run`

### Extension Methods

- `AddTerraformEnvironment()` - Adds a Terraform environment to the Aspire app
- `PublishAsTerraform()` - Marks a resource for Terraform deployment with customization callback
- `WithBackend()` - Configures Terraform backend for state storage (e.g., "local", "s3", "azurerm")
- `WithVersion()` - Sets the Terraform version constraint (e.g., ">= 1.9.0")
- `WithWorkspace()` - Sets the Terraform workspace name
- `WithOutputPath()` - Configures output path for generated Terraform files
- `WithAutoOperations()` - Configures automatic terraform init/plan/apply during publish
- `WithTerraformConfiguration()` - Configures Terraform generation settings for a specific resource

### Best Practices

- ✅ Check for publishing context before generating Terraform resources
- ✅ Use `TerraformStack` to build infrastructure declaratively
- ✅ Support multiple cloud providers through provider-specific extensions
- ✅ Generate idiomatic Terraform code that can be managed outside Aspire
- ❌ Don't assume resources exist during `dotnet run` - they're publish-time only
- ❌ Don't couple Aspire-specific logic to core Terraform SDK
