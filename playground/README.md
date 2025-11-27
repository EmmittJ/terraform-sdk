# Terraform Playground

This directory contains example applications demonstrating the Terraform SDK and deployment model.

## Available Samples

| Sample                                          | Description                                                                                         |
| ----------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| [getting-started](./getting-started/)           | **Start here!** Minimal example with variables, resources, and outputs (no cloud provider required) |
| [azure-container-apps](./azure-container-apps/) | Full Aspire application deploying to Azure Container Apps                                           |

## Getting Started

For your first experience with the Terraform SDK, run the `getting-started` sample:

```bash
cd playground/getting-started
dotnet run
```

This demonstrates:

- Variables with types and defaults
- Resources with references
- Outputs exposing values
- HCL generation

## Creating a Playground Project

To create a playground project that showcases the Terraform deployment model:

### Option 1: Manual Project Creation

```bash
# Create a new Aspire application
dotnet new aspire-starter -n MyTerraformApp

# Add reference to the Terraform hosting package
cd MyTerraformApp/MyTerraformApp.AppHost
dotnet add reference ../../src/EmmittJ.Aspire.Hosting.Terraform/EmmittJ.Aspire.Hosting.Terraform.csproj
```

### Option 2: Use Existing Aspire App

If you have an existing Aspire application in this repository, add the Terraform hosting reference:

```bash
dotnet add reference ../src/EmmittJ.Aspire.Hosting.Terraform/EmmittJ.Aspire.Hosting.Terraform.csproj
```

## Example Scenarios

Once you have a playground project, you can experiment with various scenarios:

### Basic AWS Deployment

```csharp
var builder = DistributedApplication.CreateBuilder(args);

var terraform = builder.AddTerraformEnvironment("aws")
    .WithBackend("s3", backend =>
    {
        backend["bucket"] = "my-terraform-state";
        backend["region"] = "us-west-2";
    })
    .WithVersion(">= 1.9.0");

var api = builder.AddProject<Projects.Api>("api")
    .PublishAsTerraform((stack, resource) =>
    {
        // Add AWS infrastructure here
        // stack - the TerraformStack to add resources to
        // resource - the IResource being published
    });

builder.Build().Run();
```

### Multi-Cloud Setup

```csharp
// AWS Production
var aws = builder.AddTerraformEnvironment("aws-prod")
    .WithBackend("s3", backend => { /* ... */ })
    .WithOutputPath("aws-infra");

// Azure Staging
var azure = builder.AddTerraformEnvironment("azure-staging")
    .WithBackend("azurerm", backend => { /* ... */ })
    .WithOutputPath("azure-infra");
```

### Development with Local State

```csharp
var dev = builder.AddTerraformEnvironment("dev")
    .WithBackend("local")
    .WithAutoOperations(autoApply: true); // Auto-apply for dev
```

## Publishing

Generate Terraform configuration:

```bash
aspire publish
```

This creates infrastructure files in the output directory that you can then apply with Terraform CLI.

## Testing

1. Create your AppHost project
2. Configure Terraform environments and resources
3. Run `aspire publish`
4. Review generated `main.tf.json` in the output directory
5. Test with `terraform init && terraform plan`

## Sample Projects (To Be Added)

Future playground samples to add:

- **AwsEcsPlayground** - Deploy to AWS ECS/Fargate
- **AzureAciPlayground** - Deploy to Azure Container Instances
- **GcpCloudRunPlayground** - Deploy to Google Cloud Run
- **MultiCloudPlayground** - Multi-cloud deployment patterns
- **LocalDevPlayground** - Local development with LocalStack/Azurite

## Contributing Examples

If you create useful playground examples, consider:

1. Creating a dedicated project folder in `/playground`
2. Adding a README with scenario description
3. Including sample Terraform customizations
4. Documenting expected AWS/Azure/GCP resources

This helps others understand real-world usage patterns!
