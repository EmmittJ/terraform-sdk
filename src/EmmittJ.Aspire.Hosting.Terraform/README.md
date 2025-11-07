# EmmittJ.Aspire.Hosting.Terraform library

Provides extension methods for generating Terraform infrastructure-as-code from Aspire compute resources using the EmmittJ.Terraform.Sdk.

## Getting started

### Install the package

In your AppHost project, install the EmmittJ Aspire Terraform Hosting library with [NuGet](https://www.nuget.org):

```dotnetcli
dotnet add package EmmittJ.Aspire.Hosting.Terraform
```

## Usage example

Publish compute resources as Terraform infrastructure:

```csharp
var builder = DistributedApplication.CreateBuilder(args);

// Add a container resource with Terraform infrastructure
var api = builder.AddContainer("api", "myapi")
    .PublishAsTerraform(stack =>
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
    .PublishAsTerraform(stack =>
    {
        var cdn = new CloudFrontDistribution("webapp-cdn");
        stack.Add(cdn);
    });

builder.Build().Run();
```

## Core Concepts

### Annotation-Based Architecture

This library follows Aspire's established pattern (used by Azure Container Apps, App Service, and Kubernetes) where Terraform configuration is attached to compute resources via annotations, then processed during publish.

**Key Components:**

1. **Extension Method** (`PublishAsTerraform`) - Adds a `TerraformStackAnnotation` to the compute resource
2. **Annotation** (`TerraformStackAnnotation`) - Stores the Terraform configuration callback
3. **Eventing Subscriber** (`TerraformEventingSubscriber`) - Processes annotations during publish and generates `.tf` files

**Benefits:**

- ✅ Consistent with other Aspire deployment targets (Azure, Kubernetes)
- ✅ Only operates in publish mode (no overhead during `dotnet run`)
- ✅ Clean API with single configuration callback
- ✅ Works only with compute resources (projects, containers, executables)
- ✅ Can combine with other deployment targets

### Publishing Compute Resources

Use `PublishAsTerraform` to configure Terraform infrastructure for a compute resource:

```csharp
var redis = builder.AddContainer("cache", "redis")
    .PublishAsTerraform(stack =>
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
    .PublishAsTerraform(stack =>
    {
        // Configure infrastructure
    })
    .WithTerraformConfiguration(config =>
    {
        config.OutputPath = "./terraform/api";
    });
```

By default, files are generated to `{output-path}/{resource-name}/main.tf`.

### Multiple Terraform Configurations

You can attach multiple Terraform configurations to a single resource using named stacks:

```csharp
var api = builder.AddContainer("api", "myapi")
    .PublishAsTerraform("network", stack =>
    {
        var vpc = new Vpc("api-vpc")
        {
            CidrBlock = "10.0.0.0/16"
        };
        stack.Add(vpc);
    })
    .PublishAsTerraform("security", stack =>
    {
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

#### `PublishAsTerraform<T>`

Publishes a compute resource with Terraform infrastructure configuration.

```csharp
// Unnamed version - generates main.tf
IResourceBuilder<T> PublishAsTerraform<T>(
    this IResourceBuilder<T> builder,
    Action<TerraformStack> configure)
    where T : IComputeResource

// Named version - generates {name}.tf
IResourceBuilder<T> PublishAsTerraform<T>(
    this IResourceBuilder<T> builder,
    string name,
    Action<TerraformStack> configure)
    where T : IComputeResource
```

**Parameters:**

- `builder` - The compute resource builder (project, container, or executable)
- `name` - (Optional) Name for the Terraform stack, used in file naming
- `configure` - Action to configure the Terraform stack

**Returns:** The resource builder for chaining

**File Output:**

- Unnamed: `{output-path}/{resource-name}/main.tf`
- Named: `{output-path}/{resource-name}/{name}.tf`

#### `WithTerraformConfiguration<T>`

Configures Terraform generation settings for a compute resource.

```csharp
IResourceBuilder<T> WithTerraformConfiguration<T>(
    this IResourceBuilder<T> builder,
    Action<TerraformConfigurationAnnotation> configure)
    where T : IComputeResource
```

**Parameters:**

- `builder` - The compute resource builder
- `configure` - Action to configure Terraform settings

**Returns:** The resource builder for chaining

### Annotations

#### `TerraformStackAnnotation`

Annotation that stores Terraform configuration on a compute resource.

**Properties:**

- `Configure` - Action to configure the Terraform stack
- `Name` - Optional name for the stack (used in file naming)

#### `TerraformConfigurationAnnotation`

Annotation for configuring Terraform generation settings.

**Properties:**

- `OutputPath` - Custom output path for generated Terraform files (optional)

## Additional documentation

- [EmmittJ.Terraform.Sdk Documentation](../EmmittJ.Terraform.Sdk/README.md)
- [Terraform Documentation](https://www.terraform.io/docs)

## Feedback & contributing

https://github.com/EmmittJ/terraform-sdk
