# EmmittJ.Aspire.Hosting.Terraform library

Provides extension methods for provisioning Terraform infrastructure alongside Aspire resources using the EmmittJ.Terraform.Sdk.

## Getting started

### Install the package

In your AppHost project, install the EmmittJ Aspire Terraform Hosting library with [NuGet](https://www.nuget.org):

```dotnetcli
dotnet add package EmmittJ.Aspire.Hosting.Terraform
```

## Usage example

Add Terraform infrastructure provisioning to any Aspire resource:

```csharp
var builder = DistributedApplication.CreateBuilder(args);

// Add a container resource with Terraform infrastructure
var api = builder.AddContainer("api", "myapi")
    .WithTerraform(stack =>
    {
        // Configure Terraform infrastructure for the API
        var bucket = new S3Bucket("api-storage")
        {
            BucketName = "my-api-storage"
        };
        stack.Add(bucket);

        var database = new RdsInstance("api-db")
        {
            Engine = "postgres",
            InstanceClass = "db.t3.micro"
        };
        stack.Add(database);
    });

// Or with a project resource
var webapp = builder.AddProject<Projects.WebApp>("webapp")
    .WithTerraform(stack =>
    {
        var cdn = new CloudFrontDistribution("webapp-cdn");
        stack.Add(cdn);
    });

builder.Build().Run();
```

## Core Concepts

### Infrastructure Provisioning Pattern

This library follows a pattern similar to `AzureBicepResource` for infrastructure provisioning. Unlike compute environments (Kubernetes, Azure Container Apps), this generates infrastructure-as-code that provisions supporting resources.

**Key Components:**

1. **Extension Method** (`WithTerraform`) - Adds a `TerraformStackAnnotation` to any resource
2. **Annotation** (`TerraformStackAnnotation`) - Stores the Terraform configuration callback
3. **Pipeline Steps** (`TerraformPipelineStepFactory`) - Processes annotations during publish and generates `.tf` files

**Benefits:**

- ✅ Similar to Azure Bicep infrastructure provisioning
- ✅ Only operates in publish mode (no overhead during `dotnet run`)
- ✅ Clean API with configuration callback
- ✅ Works with any resource type (not just compute resources)
- ✅ Multiple stacks per resource supported
- ✅ Can combine with compute environments (Kubernetes, ACA, etc.)

### Adding Terraform Infrastructure

Use `WithTerraform` to provision infrastructure alongside any resource:

```csharp
var redis = builder.AddContainer("cache", "redis")
    .WithTerraform(stack =>
    {
        // Add AWS provider
        var provider = new AwsProvider("aws")
        {
            Region = "us-east-1"
        };
        stack.AddProvider(provider);

        // Add ElastiCache cluster
        var cluster = new ElastiCacheCluster("redis-cluster")
        {
            ClusterId = "my-cache",
            Engine = "redis",
            NodeType = "cache.t3.micro",
            NumCacheNodes = 1
        };
        stack.Add(cluster);

        // Add outputs
        stack.AddOutput("endpoint", cluster.CacheNodes[0].Address);
    });
```

### Configuring Output Path

Customize where Terraform files are generated:

```csharp
var api = builder.AddContainer("api", "myapi")
    .WithTerraform(stack =>
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

You can attach multiple Terraform stacks to a single resource:

```csharp
var api = builder.AddContainer("api", "myapi")
    .WithTerraform(stack =>
    {
        stack.Name = "network";
        var vpc = new Vpc("api-vpc")
        {
            CidrBlock = "10.0.0.0/16"
        };
        stack.Add(vpc);
    })
    .WithTerraform(stack =>
    {
        stack.Name = "security";
        var sg = new SecurityGroup("api-sg")
        {
            Name = "api-security-group"
        };
        stack.Add(sg);
    });
```

This generates:

- `{output-path}/api/network.tf`
- `{output-path}/api/security.tf`

### Publish-Only Execution

### Publish-Only Execution

Terraform file generation **only occurs during publish mode** (`aspire publish`), not during `dotnet run`. This ensures:

- ✅ Faster local development (no file I/O during app startup)
- ✅ Infrastructure provisioning decoupled from application runtime
- ✅ Stack validation happens during publish
- ✅ Terraform execution controlled by deployment pipelines

## API Reference

### Extension Methods

#### `WithTerraform<T>`

Adds Terraform infrastructure provisioning to any resource.

```csharp
IResourceBuilder<T> WithTerraform<T>(
    this IResourceBuilder<T> builder,
    Action<TerraformStack> configure)
    where T : IResource
```

**Parameters:**

- `builder` - The resource builder (any resource type)
- `configure` - Action to configure the Terraform stack

**Returns:** The resource builder for chaining

**File Output:**

- Default: `{output-path}/{resource-name}/main.tf`
- Named stack: `{output-path}/{resource-name}/{stack-name}.tf`

**Example:**

```csharp
builder.AddContainer("api", "myapi")
    .WithTerraform(stack =>
    {
        stack.Name = "storage"; // Optional: generates storage.tf instead of main.tf
        var bucket = new S3Bucket("api-bucket");
        stack.Add(bucket);
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

### Annotations

#### `TerraformStackAnnotation`

Annotation that stores Terraform configuration on a resource.

**Properties:**

- `Configure` - Action to configure the Terraform stack

#### `TerraformConfigurationAnnotation`

Annotation for configuring Terraform generation settings.

**Properties:**

- `OutputPath` - Custom output path for generated Terraform files (optional)

## Additional documentation

- [EmmittJ.Terraform.Sdk Documentation](../EmmittJ.Terraform.Sdk/README.md)
- [Terraform Documentation](https://www.terraform.io/docs)

## Feedback & contributing

https://github.com/EmmittJ/terraform-sdk
