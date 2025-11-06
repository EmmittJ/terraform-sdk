# EmmittJ.Aspire.Hosting.Terraform library

Provides extension methods and resources for generating Terraform infrastructure-as-code from Aspire resource definitions using the EmmittJ.Terraform.Sdk.

## Getting started

### Install the package

In your AppHost project, install the EmmittJ Aspire Terraform Hosting library with [NuGet](https://www.nuget.org):

```dotnetcli
dotnet add package EmmittJ.Aspire.Hosting.Terraform
```

## Usage example

Create Terraform stacks as child resources of any Aspire resource:

```csharp
var builder = DistributedApplication.CreateBuilder(args);

// Add a Postgres resource
var postgres = builder.AddPostgres("postgres");

// Attach a Terraform stack as a child resource
var postgresInfra = postgres.WithTerraformStack("infrastructure", stack =>
{
    // Configure the Terraform stack using the SDK
    var provider = new TerraformAwsProvider("aws")
    {
        Region = "us-west-2"
    };
    stack.AddProvider(provider);

    var db = new TerraformResource("postgres_db", "aws_db_instance")
    {
        ["engine"] = "postgres",
        ["instance_class"] = "db.t3.micro"
    };
    stack.AddResource(db);
});

// The Terraform stack is now a separate resource that can be:
// - Referenced by other resources
// - Waited on for completion
// - Monitored in the dashboard

builder.Build().Run();
```

## Core Concepts

### Terraform Stacks as First-Class Resources

Terraform stacks are created as `TerraformStackResource` instances—separate resources in the Aspire application model. This follows Aspire's architectural patterns where related entities are represented as child resources with `IResourceWithParent<T>`.

**Benefits:**

- Each stack appears in the Aspire dashboard
- Stacks have their own lifecycle and can be monitored independently
- Other resources can explicitly wait for stacks to complete
- Better separation of concerns: parent resource represents the application component, stack resource represents infrastructure provisioning

### Creating Terraform Stacks

Use `WithTerraformStack` to create a stack as a child resource:

```csharp
var redis = builder.AddRedis("redis");

var cacheInfra = redis.WithTerraformStack("cache-infra", stack =>
{
    // Add providers
    stack.AddProvider(new TerraformAwsProvider("aws") { Region = "us-east-1" });

    // Add resources
    stack.AddResource(new TerraformResource("elasticache", "aws_elasticache_cluster")
    {
        ["cluster_id"] = "my-redis-cluster",
        ["engine"] = "redis"
    });

    // Add outputs
    stack.AddOutput("cluster_endpoint", new TerraformOutput
    {
        Value = "${aws_elasticache_cluster.elasticache.cache_nodes[0].address}"
    });
});

// The stack resource can be referenced
var app = builder.AddProject<Projects.MyApp>("myapp")
    .WaitFor(cacheInfra); // Wait for infrastructure to be ready
```

### Setting Working Directory

Optionally specify where Terraform files should be generated:

```csharp
var postgres = builder.AddPostgres("postgres")
    .WithTerraformWorkingDirectory("./terraform/database");

var dbInfra = postgres.WithTerraformStack("rds", stack =>
{
    // Stack configuration
});
```

### Multiple Stacks Per Resource

You can attach multiple Terraform stacks to a single resource:

```csharp
var api = builder.AddProject<Projects.WebApi>("api");

// Network infrastructure
var network = api.WithTerraformStack("network", stack =>
{
    stack.AddResource(new TerraformResource("vpc", "aws_vpc")
    {
        ["cidr_block"] = "10.0.0.0/16"
    });
});

// Security infrastructure
var security = api.WithTerraformStack("security", stack =>
{
    stack.AddResource(new TerraformResource("sg", "aws_security_group")
    {
        ["name"] = "api-sg"
    });
});
```

### Automatic Parameter Generation

Terraform variables in your stack are automatically converted to Aspire parameters:

```csharp
var infra = builder.AddContainer("infra", "terraform")
    .WithTerraformStack("aws-resources", stack =>
    {
        // Add Terraform variables
        stack.Add(new TerraformVariable("region")
        {
            Type = TerraformTypeProperty.String,
            Description = "AWS region"
        });

        stack.Add(new TerraformVariable("instance_count")
        {
            Type = TerraformTypeProperty.Number,
            Default = 3
        });

        // Use variables in resources
        stack.AddProvider(new TerraformAwsProvider("aws")
        {
            Region = "${var.region}"
        });
    });

// Aspire parameters are automatically created with the naming pattern:
// {stackResourceName}_{variableName}
// - infra-aws-resources_region
// - infra-aws-resources_instance_count
```

These parameters are registered in the application model and can be configured through:

- User secrets
- Environment variables
- Configuration files
- The Aspire dashboard (when prompted for values)

## API Reference

### Extension Methods

#### `WithTerraformStack<T>`

Adds a Terraform stack as a child resource of the parent resource.

```csharp
IResourceBuilder<TerraformStackResource> WithTerraformStack<T>(
    this IResourceBuilder<T> builder,
    string stackName,
    Action<TerraformStack>? configureStack = null)
    where T : IResource
```

**Parameters:**

- `builder` - The parent resource builder
- `stackName` - Name of the Terraform stack (used in the resource name)
- `configureStack` - Optional action to configure the stack

**Returns:** A resource builder for the `TerraformStackResource`

#### `WithTerraformWorkingDirectory<T>`

Sets the working directory for Terraform file generation.

```csharp
IResourceBuilder<T> WithTerraformWorkingDirectory<T>(
    this IResourceBuilder<T> builder,
    string workingDirectory)
    where T : IResource
```

**Parameters:**

- `builder` - The resource builder
- `workingDirectory` - Path where Terraform files will be generated

**Returns:** The resource builder for chaining

### Resources

#### `TerraformStackResource`

Represents a Terraform stack as a first-class Aspire resource.

**Properties:**

- `Name` - The unique name of the stack resource
- `Parent` - The parent Aspire resource this stack is associated with
- `Stack` - The `TerraformStack` definition containing providers, resources, and configuration

#### `TerraformConfigurationAnnotation`

Annotation that stores Terraform configuration on a resource.

**Properties:**

- `WorkingDirectory` - Directory where Terraform files will be generated (optional)

## File Generation

Terraform files are **not** generated during `dotnet run`. Instead, file generation happens during the `aspire publish` process via CI/CD pipelines. This separation ensures:

- Faster local development (no file I/O during app startup)
- Infrastructure provisioning decoupled from application runtime
- Stack validation happens early (during resource creation)
- Terraform execution controlled by deployment pipelines

## Additional documentation

- [EmmittJ.Terraform.Sdk Documentation](../EmmittJ.Terraform.Sdk/README.md)
- [Terraform Documentation](https://www.terraform.io/docs)

## Feedback & contributing

https://github.com/EmmittJ/terraform-sdk
