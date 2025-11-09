#pragma warning disable ASPIREPIPELINES001 // Experimental API usage

using Aspire.Hosting;
using EmmittJ.Aspire.Hosting.Terraform;

var builder = DistributedApplication.CreateBuilder(args);

// ============================================================================
// Infrastructure Resources
// ============================================================================

// Redis cache - will be provisioned as Azure Cache for Redis
var cache = builder.AddRedis("cache");

// PostgreSQL database - will be provisioned as Azure Database for PostgreSQL
var db = builder.AddPostgres("postgres")
    .AddDatabase("appdb");

// ============================================================================
// Application
// ============================================================================

var api = builder.AddProject<Projects.TerraformPlayground_ApiService>("api")
    .WithReference(cache)
    .WithReference(db)
    .WithExternalHttpEndpoints()
    .PublishAsTerraform((stack, resource) =>
    {
        // When you implement Azure resource processors, they will:
        // 1. Create an Azure Container App
        // 2. Configure environment variables for cache and db connections
        // 3. Set up Application Insights for monitoring
        // 4. Configure scaling rules
        //
        // Example (pseudo-code for future implementation):
        // var containerApp = new AzureContainerApp($"{resource.Name}")
        // {
        //     Image = "mcr.microsoft.com/..." // Built from project
        //     EnvironmentVariables = GetEnvironmentVariables(resource),
        //     Cpu = "0.5",
        //     Memory = "1Gi",
        //     MinReplicas = 1,
        //     MaxReplicas = 10
        // };
        // stack.Add(containerApp);
    });

// ============================================================================
// Azure Deployment with Local Backend
// ============================================================================

// This demonstrates a typical workflow:
// - Development: Run locally with containers
// - Production: Deploy to Azure with Terraform
// - State: Managed locally (can be moved to Azure Storage later)

var azure = builder.AddTerraformEnvironment("azure")
    .WithBackend("local")  // Simple local state for getting started
    .WithOutputPath("infra/azure")
    .WithAutoOperations(
        autoInit: true,   // Automatically run terraform init
        autoPlan: true,   // Automatically run terraform plan
        autoApply: false  // Manual approval required for apply
    );

cache.PublishAsTerraform((stack, resource) =>
{
    // Azure Cache for Redis
    // var redisCache = new AzureRedisCache($"{resource.Name}")
    // {
    //     Sku = "Basic",
    //     Family = "C",
    //     Capacity = 0,
    //     EnableNonSslPort = false
    // };
    // stack.Add(redisCache);
});

db.PublishAsTerraform((stack, resource) =>
{
    // Azure Database for PostgreSQL
    // var postgresServer = new AzurePostgreSqlServer($"{resource.Name}")
    // {
    //     Sku = "B_Gen5_1",
    //     StorageMb = 5120,
    //     Version = "14"
    // };
    // stack.Add(postgresServer);
    //
    // var database = new AzurePostgreSqlDatabase("appdb")
    // {
    //     ServerName = postgresServer.Name,
    //     Charset = "UTF8",
    //     Collation = "en_US.utf8"
    // };
    // stack.Add(database);
});

// ============================================================================
// Publishing Instructions
// ============================================================================
/*
Workflow for deploying to Azure:

1. Local Development (using containers):
   dotnet run

2. Generate Terraform configuration:
   aspire publish

3. Navigate to the infrastructure directory:
   cd <output-path>/infra/azure

4. Review the generated Terraform files:
   - main.tf: Infrastructure definitions
   - You'll see placeholders for Azure resources

5. Initialize Terraform:
   terraform init

6. Review the planned changes:
   terraform plan

7. Apply to Azure (when ready):
   terraform apply

Moving to Azure Storage backend (production):
- Update .WithBackend("azurerm", backend =>
  {
      backend["resource_group_name"] = "tfstate-rg";
      backend["storage_account_name"] = "tfstate";
      backend["container_name"] = "tfstate";
      backend["key"] = "terraform.tfstate";
  })
- Configure Azure Storage account for state
- Add state locking with Azure Blob leaseBenefits of this approach:
- Start simple with local state
- Easy to version control and review changes
- Gradual migration to remote state when needed
- All Azure resources defined as code
- Consistent deployment across environments
*/

builder.Build().Run();
