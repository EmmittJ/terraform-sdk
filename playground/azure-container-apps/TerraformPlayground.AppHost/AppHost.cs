#pragma warning disable ASPIREPIPELINES001 // Experimental API usage

using Aspire.Hosting;
using EmmittJ.Aspire.Hosting.Terraform;
using EmmittJ.Terraform.Sdk;
using EmmittJ.Terraform.Sdk.Providers.Azurerm;

var builder = DistributedApplication.CreateBuilder(args);

// ============================================================================
// Azure Deployment with Local Backend
// ============================================================================

// This demonstrates a typical workflow:
// - Development: Run locally with containers
// - Production: Deploy to Azure with Terraform
// - State: Managed locally (can be moved to Azure Storage later)
var resourceGroupParameter = builder.AddParameter("resource-group");

var azure = builder.AddTerraformEnvironment("infra")
    .WithBackend("local")  // Simple local state for getting started
    .WithOutputPath("infra")
    .WithAutoOperations(
        autoInit: true,   // Automatically run terraform init
        autoPlan: true,   // Automatically run terraform plan
        autoApply: false  // Manual approval required for apply
    )
    // Add shared infrastructure that all resources will use
    .PublishAsTerraform(infra =>
    {
        // Create resource group for all Azure resources
        var resourceGroup = new AzurermResourceGroup("aspire-rg")
        {
            Name = resourceGroupParameter.AsVariable(infra).AsReference(),
            Location = "eastus",
            Tags = new()
            {
                ["Environment"] = "Development",
                ["ManagedBy"] = "Aspire"
            }
        };
        infra.Add(resourceGroup);

        // Create Container Apps Environment for hosting containers
        var containerEnv = new AzurermContainerAppEnvironment("container-env")
        {
            Name = "aspire-container-env",
            Location = resourceGroup.Location,
            ResourceGroupName = resourceGroup.Name
        };
        infra.Add(containerEnv);

        // Export key values for other stacks to reference
        var rgNameOutput = new TerraformOutput("resource_group_name")
        {
            Value = resourceGroup.Name
        };
        infra.Add(rgNameOutput);

        var containerEnvIdOutput = new TerraformOutput("container_env_id")
        {
            Value = containerEnv.Id
        };
        infra.Add(containerEnvIdOutput);
    });

// ============================================================================
// Infrastructure Resources
// ============================================================================

// Redis cache - will be provisioned as Azure Cache for Redis
var cache = builder
    .AddRedis("cache")
    .PublishAsTerraform(infra =>
    {
        // Azure Cache for Redis
        var redisCache = new AzurermRedisCache($"{infra.Resource.Name}")
        {
            Name = $"aspire-{infra.Resource.Name}",
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
        infra.Add(redisCache);

        // Output the connection string for the API to use
        var connectionStringOutput = new TerraformOutput("redis_connection_string")
        {
            Value = redisCache.PrimaryConnectionString,
            Sensitive = true
        };
        infra.Add(connectionStringOutput);

        var hostnameOutput = new TerraformOutput("redis_hostname")
        {
            Value = redisCache.Hostname
        };
        infra.Add(hostnameOutput);
    });

// PostgreSQL admin password - can be provided via user secrets, environment variables, or command line
var postgresPassword = builder.AddParameter("postgres-password", secret: true);

// PostgreSQL database - will be provisioned as Azure Database for PostgreSQL
var db = builder.AddPostgres("postgres", password: postgresPassword)
    .AddDatabase("appdb")
    .PublishAsTerraform(infra =>
    {
        // Use AsVariable to convert the Aspire parameter to a Terraform variable
        var passwordVar = postgresPassword.AsVariable(infra);

        // Azure Database for PostgreSQL Flexible Server
        var postgresServer = new AzurermPostgresqlFlexibleServer($"{infra.Resource.Name}-server")
        {
            Name = $"aspire-{infra.Resource.Name}-server",
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
        infra.Add(postgresServer);

        // Create the database
        var database = new AzurermPostgresqlFlexibleServerDatabase("appdb")
        {
            Name = "appdb",
            ServerId = postgresServer.Id,
            Charset = "UTF8",
            Collation = "en_US.utf8"
        };
        infra.Add(database);

        // Allow Azure services to access the server
        var firewallRule = new AzurermPostgresqlFlexibleServerFirewallRule("allow-azure")
        {
            Name = "allow-azure-services",
            ServerId = postgresServer.Id,
            StartIpAddress = "0.0.0.0",
            EndIpAddress = "0.0.0.0"
        };
        infra.Add(firewallRule);

        // Output connection information
        var fqdnOutput = new TerraformOutput("postgres_fqdn")
        {
            Value = postgresServer["fqdn"]
        };
        infra.Add(fqdnOutput);

        var dbNameOutput = new TerraformOutput("postgres_database_name")
        {
            Value = database.Name
        };
        infra.Add(dbNameOutput);

        var connectionStringOutput = new TerraformOutput("postgres_connection_string")
        {
            Value = Tf.Functions.Format(
                "Host=%s;Database=%s;Username=%s;Password=%s",
                postgresServer["fqdn"].AsLazy<string>(),
                database.Name,
                "aspireAdmin",
                passwordVar.AsReference()
            ),
            Sensitive = true
        };
        infra.Add(connectionStringOutput);
    });

// ============================================================================
// Application
// ============================================================================

var api = builder.AddProject<Projects.TerraformPlayground_ApiService>("api")
    .WithReference(cache)
    .WithReference(db)
    .WithExternalHttpEndpoints()
    .PublishAsTerraform(infra =>
    {
        // Reference outputs from other modules using TerraformOutputReference
        // These will automatically be wired as module input variables
        var containerEnvId = new TerraformOutputReference("container_env_id", azure.Resource).AsVariable(infra);
        var redisConnectionString = new TerraformOutputReference("redis_connection_string", cache.Resource).AsVariable(infra);
        var postgresConnectionString = new TerraformOutputReference("postgres_connection_string", db.Resource).AsVariable(infra);

        // Create Azure Container App for the API
        var containerApp = new AzurermContainerApp($"{infra.Resource.Name}")
        {
            // Use the container environment ID from the azure environment module
            ContainerAppEnvironmentId = containerEnvId.AsReference(),
            Name = $"aspire-{infra.Resource.Name}",
            ResourceGroupName = "aspire-playground-rg",
            RevisionMode = "Single",
            Tags = new()
            {
                ["Environment"] = "Development",
                ["ManagedBy"] = "Aspire"
            },
            Template =
            [
                new()
                {
                    MinReplicas = 1,
                    MaxReplicas = 1,
                    Container = [
                        new () {
                            Name = "api-container",
                            Image = "aspireplayground/api:latest", // Replace with actual image
                            Cpu = 0.5,
                            Memory = "1Gi",
                            // Pass connection strings as environment variables
                            // Note: In real scenarios, you'd use secrets or managed identities
                            Env = [
                                new () {
                                    Name = "ConnectionStrings__cache",
                                    SecretName = "redis-connection"
                                },
                                new () {
                                    Name = "ConnectionStrings__appdb",
                                    SecretName = "postgres-connection"
                                }
                            ]
                        }
                    ]
                }
            ],
            // Define secrets that reference the connection strings
            Secret = [
                new () {
                    Name = "redis-connection",
                    Value = redisConnectionString.AsReference()
                },
                new () {
                    Name = "postgres-connection",
                    Value = postgresConnectionString.AsReference()
                }
            ]
        };

        infra.Add(containerApp);

        // Output the app's FQDN
        var fqdnOutput = new TerraformOutput("api_fqdn")
        {
            Value = containerApp.LatestRevisionFqdn,
            Description = "The FQDN of the API Container App"
        };
        infra.Add(fqdnOutput);
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
