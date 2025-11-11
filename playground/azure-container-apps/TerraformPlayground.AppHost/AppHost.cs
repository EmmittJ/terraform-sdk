#pragma warning disable ASPIREPIPELINES001 // Experimental API usage

using Aspire.Hosting;
using EmmittJ.Aspire.Hosting.Terraform;
using EmmittJ.Terraform.Sdk;
using EmmittJ.Terraform.Sdk.Providers.AzureRM;

var builder = DistributedApplication.CreateBuilder(args);

// ============================================================================
// Parameters for Secrets
// ============================================================================

// PostgreSQL admin password - can be provided via user secrets, environment variables, or command line
var postgresPassword = builder.AddParameter("postgres-password", secret: true);

// ============================================================================
// Infrastructure Resources
// ============================================================================

// Redis cache - will be provisioned as Azure Cache for Redis
var cache = builder.AddRedis("cache");

// PostgreSQL database - will be provisioned as Azure Database for PostgreSQL
var db = builder.AddPostgres("postgres", password: postgresPassword)
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
        // Create Azure Container App for the API
        var containerApp = new AzurermContainerApp($"{resource.Name}")
        {
            // Reference the Container App Environment ID using a data source or variable
            // This would typically come from the shared infrastructure output
            // For now, using a placeholder that shows the pattern
            ContainerAppEnvironmentId = TerraformExpression.Identifier("azurerm_container_app_environment.container-env.id"),
            Name = $"aspire-{resource.Name}",
            ResourceGroupName = "aspire-playground-rg",
            RevisionMode = "Single",
            Tags = new()
            {
                ["Environment"] = "Development",
                ["ManagedBy"] = "Aspire"
            }
        };

        // Note: For a complete implementation, you would need to configure:
        // - Template with container configuration (image, CPU, memory)
        // - Environment variables for Redis and PostgreSQL connection strings
        // - Ingress configuration for external HTTP access
        // - Scaling rules
        //
        // The SDK currently requires these to be set via the WithProperty extension
        // or through nested block support which may need to be added to the SDK.

        stack.Add(containerApp);

        // Output the app's FQDN
        var fqdnOutput = new TerraformOutput("api_fqdn")
        {
            Value = containerApp.LatestRevisionFqdn,
            Description = "The FQDN of the API Container App"
        };
        stack.Add(fqdnOutput);
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

// Add shared infrastructure that all resources will use
azure.PublishAsTerraform((stack, _) =>
{
    // Create resource group for all Azure resources
    var resourceGroup = new AzurermResourceGroup("aspire-rg")
    {
        Name = "aspire-playground-rg",
        Location = "eastus",
        Tags = new()
        {
            ["Environment"] = "Development",
            ["ManagedBy"] = "Aspire"
        }
    };
    stack.Add(resourceGroup);

    // Create Container Apps Environment for hosting containers
    var containerEnv = new AzurermContainerAppEnvironment("container-env")
    {
        Name = "aspire-container-env",
        Location = resourceGroup.Location,
        ResourceGroupName = resourceGroup.Name
    };
    stack.Add(containerEnv);

    // Export key values for other stacks to reference
    var rgNameOutput = new TerraformOutput("resource_group_name")
    {
        Value = resourceGroup.Name
    };
    stack.Add(rgNameOutput);

    var containerEnvIdOutput = new TerraformOutput("container_env_id")
    {
        Value = containerEnv.Id
    };
    stack.Add(containerEnvIdOutput);
});

cache.PublishAsTerraform((stack, resource) =>
{
    // Azure Cache for Redis
    var redisCache = new AzurermRedisCache($"{resource.Name}")
    {
        Name = $"aspire-{resource.Name}",
        Location = "eastus",
        ResourceGroupName = "aspire-playground-rg",
        Capacity = 0,
        Family = "C",
        SkuName = "Basic",
        MinimumTlsVersion = "1.2",
        Tags = new()
        {
            ["Environment"] = "Development",
            ["ManagedBy"] = "Aspire"
        }
    };
    stack.Add(redisCache);

    // Output the connection string for the API to use
    var connectionStringOutput = new TerraformOutput("redis_connection_string")
    {
        Value = redisCache.PrimaryConnectionString,
        Sensitive = true
    };
    stack.Add(connectionStringOutput);

    var hostnameOutput = new TerraformOutput("redis_hostname")
    {
        Value = redisCache.Hostname
    };
    stack.Add(hostnameOutput);
});

db.PublishAsTerraform((stack, resource) =>
{
    // Create a Terraform variable for the PostgreSQL password
    var passwordVar = new TerraformVariable("postgres_admin_password")
    {
        Type = "string",
        Description = "Administrator password for PostgreSQL server",
        Sensitive = true
    };
    stack.Add(passwordVar);

    // Azure Database for PostgreSQL Flexible Server
    var postgresServer = new AzurermPostgresqlFlexibleServer($"{resource.Name}-server")
    {
        Name = $"aspire-{resource.Name}-server",
        ResourceGroupName = "aspire-playground-rg",
        Location = "eastus",
        AdministratorLogin = "aspireAdmin",
        AdministratorPassword = passwordVar.AsReference(),  // Use the Terraform variable
        SkuName = "B_Standard_B1ms",
        StorageMb = 32768,
        Version = "16",
        Tags = new()
        {
            ["Environment"] = "Development",
            ["ManagedBy"] = "Aspire"
        }
    };
    stack.Add(postgresServer);

    // Create the database
    var database = new AzurermPostgresqlFlexibleServerDatabase("appdb")
    {
        Name = "appdb",
        ServerId = postgresServer.Id,
        Charset = "UTF8",
        Collation = "en_US.utf8"
    };
    stack.Add(database);

    // Allow Azure services to access the server
    var firewallRule = new AzurermPostgresqlFlexibleServerFirewallRule("allow-azure")
    {
        Name = "allow-azure-services",
        ServerId = postgresServer.Id,
        StartIpAddress = "0.0.0.0",
        EndIpAddress = "0.0.0.0"
    };
    stack.Add(firewallRule);

    // Output connection information
    var fqdnOutput = new TerraformOutput("postgres_fqdn")
    {
        Value = postgresServer["fqdn"]
    };
    stack.Add(fqdnOutput);

    var dbNameOutput = new TerraformOutput("postgres_database_name")
    {
        Value = database.Name
    };
    stack.Add(dbNameOutput);

    var timeoutes = new TerraformOutput("postgres_timeouts")
    {
        Value = database.Timeouts?.Value?.Read
    };
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

5. Create a terraform.tfvars file with your secrets:
   postgres_admin_password = "YourSecurePassword123!"

6. Initialize Terraform:
   terraform init

7. Review the planned changes:
   terraform plan

8. Apply to Azure (when ready):
   terraform apply

Notes on secrets management:
- The PostgreSQL password is defined as an Aspire parameter (postgres-password)
- In Terraform, this becomes a variable that you provide via:
  * terraform.tfvars file (not committed to git)
  * Environment variable: TF_VAR_postgres_admin_password
  * -var flag: terraform apply -var="postgres_admin_password=..."
  * Interactive prompt during terraform apply

Moving to Azure Storage backend (production):
- Update .WithBackend("azurerm", backend =>
  {
      backend["resource_group_name"] = "tfstate-rg";
      backend["storage_account_name"] = "tfstate";
      backend["container_name"] = "tfstate";
      backend["key"] = "terraform.tfstate";
  })
- Configure Azure Storage account for state
- Add state locking with Azure Blob lease

Benefits of this approach:
- Start simple with local state
- Easy to version control and review changes
- Gradual migration to remote state when needed
- All Azure resources defined as code
- Consistent deployment across environments
- Secrets managed securely via Aspire parameters and Terraform variables
*/

builder.Build().Run();
