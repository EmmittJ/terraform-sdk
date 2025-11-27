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
var subscriptionIdParameter = builder.AddParameter("azure-subscription-id");
var resourceGroupParameter = builder.AddParameter("resource-group");

var azure = builder.AddTerraformEnvironment("azure")
    .WithSettings(settings =>
    {
        settings.RequiredProviders = new()
        {
            ["azurerm"] = new ProviderRequirement()
            {
                Source = "hashicorp/azurerm",
                Version = "~> 4.0"
            }
        };
    })
    .WithBackend("local")  // Simple local state for getting started
    .WithOutputPath("infra/azure")
    .WithAutoOperations(
        autoInit: true,   // Automatically run terraform init
        autoPlan: true,   // Automatically run terraform plan
        autoApply: false  // Manual approval required for apply
    )
    .PublishAsTerraform(infra =>
    {
        // AzureRM Provider
        var azurerm = new AzurermProvider("azurerm")
        {
            UseCli = true,
            SubscriptionId = infra.AddVariable(subscriptionIdParameter).AsReference(),
            Features = [new()]
        };
        infra.Add(azurerm);

        // Create resource group for all Azure resources
        var resourceGroup = new AzurermResourceGroup("aspire-rg")
        {
            Name = infra.AddVariable(resourceGroupParameter).AsReference(),
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

        // Export key values for other resources to reference
        infra.Add(new TerraformOutput("resource_group_name") { Value = resourceGroup.Name });
        if (infra.Resource is TerraformEnvironmentResource env)
        {
            infra.AddOutput(env.ContainerEnvironmentId, containerEnv.Id);
        }
    });

// ============================================================================
// Infrastructure Resources
// ============================================================================

// Redis cache - will be provisioned as Azure Cache for Redis
var cache = builder.AddRedis("cache")
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

        infra.Add(new TerraformOutput("redis_hostname") { Value = redisCache.Hostname });
        if (infra.Resource is RedisResource redis)
        {
            infra.AddOutput(redis.TerraformConnectionString, redisCache.PrimaryConnectionString);
        }
    });

// PostgreSQL admin password - can be provided via user secrets, environment variables, or command line
var postgresPassword = builder.AddParameter("postgres-password", secret: true);

// PostgreSQL database - will be provisioned as Azure Database for PostgreSQL
var db = builder.AddPostgres("postgres", password: postgresPassword)
    .AddDatabase("appdb")
    .PublishAsTerraform(infra =>
    {
        // Use AddVariable to convert the Aspire parameter to a Terraform variable
        var passwordVar = infra.AddVariable(postgresPassword);

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

        // Use output resources for shared outputs, inline TerraformOutput for module-only outputs
        infra.Add(new TerraformOutput("postgres_fqdn") { Value = postgresServer["fqdn"] });
        infra.Add(new TerraformOutput("postgres_database_name") { Value = database.Name });
        if (infra.Resource is PostgresDatabaseResource pgDb)
        {
            infra.AddOutput(pgDb.TerraformConnectionString,
                Tf.Functions.Format(
                    "Host=%s;Database=%s;Username=%s;Password=%s",
                    postgresServer["fqdn"].AsLazy<string>(),
                    database.Name,
                    "aspireAdmin",
                    passwordVar.AsReference()
                )
            );
        }
    });

// ============================================================================
// Application
// ============================================================================

// Define the API's output at the builder level
var api = builder.AddProject<Projects.TerraformPlayground_ApiService>("api")
    .WithReference(cache)
    .WithReference(db)
    .WithExternalHttpEndpoints()
    .PublishAsTerraform(infra =>
    {
        // Create Azure Container App for the API
        var containerApp = new AzurermContainerApp($"{infra.Resource.Name}")
        {
            // Use the container environment ID from the azure environment
            ContainerAppEnvironmentId = infra.AddVariable(azure.Resource.ContainerEnvironmentId).AsReference(),
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
            // Define secrets using the output references - type-safe, no magic strings!
            Secret = [
                new () {
                    Name = "redis-connection",
                    Value = infra.AddVariable(cache.TerraformConnectionString).AsReference()
                },
                new () {
                    Name = "postgres-connection",
                    Value = infra.AddVariable(db.TerraformConnectionString).AsReference()
                }
            ]
        };

        infra.Add(containerApp);

        // Use inline TerraformOutput for outputs that aren't consumed by other resources
        infra.Add(new TerraformOutput("api_fqdn")
        {
            Value = containerApp.LatestRevisionFqdn,
            Description = "The FQDN of the API Container App"
        });
    });

// ============================================================================
// Publishing Instructions
// ============================================================================
/*
Workflow for deploying to Azure:

1. Local Development (using containers):
   dotnet run

2. Deploy with Terraform:
   aspire deploy

   Based on the .WithAutoOperations() settings above:
   - autoInit: true   → Automatically runs terraform init
   - autoPlan: true   → Automatically runs terraform plan
   - autoApply: false → Requires manual approval for apply

3. If autoApply is false, you'll need to manually apply:
   cd aspire-output/infra/azure
   terraform apply aspire.tfplan

Notes on secrets management:
- The PostgreSQL password is defined as an Aspire parameter (postgres-password)
- Aspire resolves parameter values and passes them to Terraform automatically
- For sensitive parameters, values are passed via TF_VAR_* environment variables
- For non-sensitive parameters, values are written to aspire.auto.tfvars

Benefits of this approach:
- Single command deployment with aspire deploy
- Automatic Terraform workflow based on settings
- Secrets managed securely via Aspire parameters
- All Azure resources defined as code
- Consistent deployment across environments
*/

builder.Build().Run();


public static class TerraformOutputReferenceExtensions
{
    extension(IResourceBuilder<IResourceWithConnectionString> builder)
    {
        public TerraformOutputReference TerraformConnectionString =>
            builder.GetTerraformOutput("connection-string", sensitive: true);
    }

    extension(IResourceWithConnectionString resource)
    {
        public TerraformOutputReference TerraformConnectionString =>
            resource.GetTerraformOutput("connection-string", sensitive: true);
    }

    extension(TerraformEnvironmentResource environment)
    {
        public TerraformOutputReference ContainerEnvironmentId =>
            environment.GetTerraformOutput("container-env-id");
    }
}
