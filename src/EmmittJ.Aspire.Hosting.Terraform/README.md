# EmmittJ.Aspire.Hosting.Terraform library

Provides extension methods for deploying .NET Aspire applications using Terraform infrastructure-as-code.

## Getting started

### Install the package

In your AppHost project, install the EmmittJ Aspire Terraform Hosting library with [NuGet](https://www.nuget.org):

```dotnetcli
dotnet add package EmmittJ.Aspire.Hosting.Terraform
```

## Usage example

Deploy Aspire resources to a Terraform environment:

```csharp
var builder = DistributedApplication.CreateBuilder(args);

// Add a Terraform deployment environment
var terraform = builder.AddTerraformEnvironment("terraform")
    .WithBackend("s3", config =>
    {
        config["bucket"] = "my-terraform-state";
        config["region"] = "us-west-2";
    })
    .WithVersion("1.9.0");

// Add resources - they'll be deployed via Terraform when published
var api = builder.AddProject<Projects.Api>("api")
    .PublishAsTerraform((stack, resource) =>
    {
        // Customize Terraform infrastructure for this resource
        // stack - the Terraform stack to add resources to
        // resource - the Aspire resource being published
    });

builder.Build().Run();
```

## Core Concepts

### Deployment Model

This library implements a complete Terraform deployment environment for .NET Aspire, following the same pattern as Azure Container Apps and Kubernetes deployments.

**Key Components:**

1. **Terraform Environment** (`AddTerraformEnvironment`) - Deployment target for your application
2. **Resource Publishing** (`PublishAsTerraform`) - Customize infrastructure per resource
3. **Pipeline Integration** - Automated terraform init/plan/apply steps
4. **File Generation** - Generates Terraform JSON configuration during publish

**Benefits:**

- ✅ Deploy to any cloud provider (AWS, Azure, GCP)
- ✅ Type-safe infrastructure with EmmittJ.Terraform.Sdk
- ✅ Only operates in publish mode (no overhead during `dotnet run`)
- ✅ Integrates with Aspire deployment pipeline
- ✅ Flexible backend configuration (local, S3, Azure, GCS, Terraform Cloud)

### Publishing Resources

Use `PublishAsTerraform` to customize how resources are deployed:

```csharp
var api = builder.AddProject<Projects.Api>("api")
    .PublishAsTerraform((stack, resource) =>
    {
        // Add cloud-specific infrastructure
        // Example: AWS ECS task, Azure Container Instance, etc.
    });
```

### Configuring Output Path

Customize where Terraform files are generated:

```csharp
var api = builder.AddContainer("api", "myapi")
    .PublishAsTerraform((stack, resource) =>
    {
        // Configure infrastructure
    })
    .WithTerraformConfiguration(config =>
    {
        config.OutputPath = "./terraform/api";
    });
```

By default, files are generated to `{output-path}/{resource-name}/main.tf`.

### Multiple Terraform Stacks

You can attach multiple Terraform stacks to a single resource by calling `PublishAsTerraform` multiple times.

### Environment Configuration

Configure the Terraform environment with backend, version, and automation settings:

```csharp
builder.AddTerraformEnvironment("terraform")
    .WithWorkspace("production")
    .WithVersion("1.9.0")
    .WithBackend("azurerm", config =>
    {
        config["resource_group_name"] = "terraform-state";
        config["storage_account_name"] = "tfstate";
        config["container_name"] = "state";
        config["key"] = "aspire.tfstate";
    });
```

## API Reference

### Extension Methods

#### `PublishAsTerraform<T>`

Publishes a resource to the Terraform environment with customization.

```csharp
IResourceBuilder<T> PublishAsTerraform<T>(
    this IResourceBuilder<T> builder,
    Action<TerraformStack, IResource> configure)
    where T : IResource
```

**Parameters:**

- `builder` - The resource builder
- `configure` - Action to configure the Terraform infrastructure with direct access to stack and resource

**Returns:** The resource builder for chaining

**Example:**

```csharp
builder.AddProject<Projects.Api>("api")
    .PublishAsTerraform((stack, resource) =>
    {
        // Add infrastructure for this resource
        // stack - TerraformStack to add resources to
        // resource - IResource being published
    });
```

#### `WithTerraformConfiguration<T>`

Configures Terraform generation settings for a resource.

```csharp
IResourceBuilder<T> WithTerraformConfiguration<T>(
    this IResourceBuilder<T> builder,
    Action<TerraformConfigurationAnnotation> configure)
    where T : IResource
```

**Parameters:**

- `builder` - The resource builder
- `configure` - Action to configure Terraform settings

**Returns:** The resource builder for chaining

**Example:**

```csharp
builder.AddProject<Projects.Api>("api")
    .WithTerraformConfiguration(config =>
    {
        config.OutputPath = "./terraform/custom-path";
    });
```

### Publish-Only Execution

Terraform file generation **only occurs during publish mode** (`aspire publish`), not during `dotnet run`. This ensures:

- ✅ Faster local development (no file I/O during app startup)
- ✅ Infrastructure provisioning decoupled from application runtime
- ✅ Terraform execution controlled by deployment pipelines

## Additional documentation

- [Deployment Model Guide](../../../docs/deployment-model.md)
- [Extension Guide](../../../docs/extention-guide.md)
- [EmmittJ.Terraform.Sdk Documentation](../EmmittJ.Terraform.Sdk/README.md)
- [Terraform Documentation](https://www.terraform.io/docs)

## Feedback & contributing

https://github.com/EmmittJ/terraform-sdk
