# EmmittJ.Aspire.Hosting.Terraform

This package provides Terraform deployment support for .NET Aspire applications. It allows you to deploy Aspire applications using Terraform infrastructure-as-code, following the same deployment model pattern as Azure Container Apps, Azure App Service, and Kubernetes in Aspire.

## Overview

The Terraform integration provides a complete compute environment for deploying Aspire applications with Terraform. This includes:

- **Terraform Environment Resource** - Deployment target for your application
- **Automatic Configuration Generation** - Generates Terraform JSON files during publish
- **Pipeline Integration** - Automated terraform init/plan/apply steps
- **Resource Customization** - Add Terraform-specific infrastructure per resource

## Getting Started

### Installation

```bash
dotnet add package EmmittJ.Aspire.Hosting.Terraform
```

### Basic Usage

```csharp
var builder = DistributedApplication.CreateBuilder(args);

// Add a Terraform deployment environment
var terraform = builder.AddTerraformEnvironment("terraform")
    .WithBackend("s3", config =>
    {
        config["bucket"] = "my-terraform-state";
        config["region"] = "us-west-2";
        config["key"] = "aspire/terraform.tfstate";
    })
    .WithVersion("1.9.0");

// Add resources - they'll be deployed to Terraform when published
var api = builder.AddProject<Projects.Api>("api");

builder.Build().Run();
```

### Publishing

Generate Terraform configuration:

```bash
aspire publish
```

This creates HCL configuration files (main.tf) in directories named after each Terraform environment.

## Configuration

### Environment Configuration

```csharp
builder.AddTerraformEnvironment("terraform")
    .WithWorkspace("production")              // Terraform workspace
    .WithVersion("1.9.0")                      // Terraform version
    .WithBackend("azurerm", config => { })     // State backend
    .WithOutputPath("infra")                   // Output path (relative to publish output)
    .WithAutoOperations(
        autoInit: true,    // Run terraform init
        autoPlan: true,    // Run terraform plan
        autoApply: false   // Manual approval required
    );
```

### Backend Configuration

Common backend configurations:

#### AWS S3

```csharp
.WithBackend("s3", config =>
{
    config["bucket"] = "terraform-state";
    config["key"] = "state.tfstate";
    config["region"] = "us-west-2";
})
```

#### Azure Storage

```csharp
.WithBackend("azurerm", config =>
{
    config["resource_group_name"] = "terraform-state";
    config["storage_account_name"] = "tfstate";
    config["container_name"] = "state";
    config["key"] = "aspire.tfstate";
})
```

#### Terraform Cloud

```csharp
.WithBackend("remote", config =>
{
    config["organization"] = "my-org";
    config["workspaces"] = new { name = "aspire-prod" };
})
```

### Resource Customization

Add Terraform resources for specific application resources:

```csharp
builder.AddProject<Projects.Api>("api")
    .PublishAsTerraform((stack, resource) =>
    {
        // Add infrastructure specific to this resource
        // Uses EmmittJ.Terraform.Sdk for type-safe resource creation
    });
```

## Architecture

### Design Pattern

Follows the established Aspire deployment pattern used by:

- `Aspire.Hosting.Kubernetes` - File-based (YAML/Helm)
- `Aspire.Hosting.Azure.AppContainers` - SDK-based (Bicep)
- `Aspire.Hosting.Azure.AppService` - SDK-based (Bicep)

### Components

1. **TerraformEnvironmentResource**

   - Implements `IComputeEnvironmentResource`
   - Defines deployment environment
   - Creates pipeline steps (init/plan/apply)

2. **TerraformInfrastructure**

   - Subscribes to `BeforeStartEvent`
   - Creates deployment targets for resources
   - Validates configuration

3. **TerraformPublishingContext**

   - Generates Terraform JSON files
   - Processes resource customizations
   - Handles environment variables

4. **Annotations**
   - `TerraformCustomizationAnnotation` - Resource customization
   - `TerraformConfigurationAnnotation` - Generation settings

### Pipeline Steps

1. `publish-terraform-{name}` - Generate configuration files
2. `terraform-init-{name}` - Initialize Terraform (optional)
3. `terraform-plan-{name}` - Create execution plan (optional)
4. `terraform-apply-{name}` - Apply changes (optional)

## Advanced Usage

### Multiple Environments

```csharp
// Development environment with local state
var dev = builder.AddTerraformEnvironment("dev")
    .WithWorkspace("development")
    .WithBackend("local");

// Production with remote state and manual approval
var prod = builder.AddTerraformEnvironment("prod")
    .WithWorkspace("production")
    .WithBackend("s3", config => { /* ... */ })
    .WithAutoOperations(autoApply: false);
```

### Per-Resource Configuration

```csharp
var api = builder.AddProject<Projects.Api>("api")
    .WithTerraformConfiguration(config =>
    {
        config.OutputFileName = "api.tf.json";
        config.GenerateVariables = true;
    })
    .PublishAsTerraform((stack, resource) =>
    {
        // Add API-specific infrastructure
    });
```

## Comparison with Other Deployment Models

| Feature              | Terraform | Kubernetes | Azure Apps   |
| -------------------- | --------- | ---------- | ------------ |
| File Generation      | ✅ JSON   | ✅ YAML    | ❌ Bicep SDK |
| Pipeline Steps       | ✅        | ✅         | ✅           |
| Environment Resource | ✅        | ✅         | ✅           |
| Customization        | ✅        | ✅         | ✅           |
| Run Mode             | ❌        | ❌         | ❌           |
| Multi-Cloud          | ✅        | ❌         | ❌           |

## Requirements

- .NET 9.0+
- Aspire 9.0+
- Terraform CLI (for init/plan/apply)
- EmmittJ.Terraform.Sdk

## License

Licensed under the MIT License.
