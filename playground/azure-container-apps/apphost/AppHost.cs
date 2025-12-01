#pragma warning disable ASPIREPIPELINES001 // Experimental API usage

using Aspire.Hosting;
using EmmittJ.Aspire.Hosting.Terraform;
using EmmittJ.Terraform.Sdk;
using EmmittJ.Terraform.Sdk.Providers.Azurerm;

var builder = DistributedApplication.CreateBuilder(args);

// ============================================================================
// Parameters - These map to Aspire parameters and become Terraform variables
// ============================================================================
var subscriptionIdParameter = builder.AddParameter("azure-subscription-id");
var locationParameter = builder.AddParameter("location", "westus2");

// Base name for all resources - will be used to create unique resource names
var baseNameParameter = builder.AddParameter("base-name", "aspire-aca");

// ============================================================================
// Terraform Environment for Azure Container Apps
// ============================================================================
// This demonstrates a 2-stage deployment pattern:
// Stage 1: Provision container registry (via WithContainerRegistry)
//          - Creates its own resource group: {base-name}-registry-rg
//          - Outputs: name, endpoint
// Stage 2: Build/push images, then provision environment + apps (via PublishAsTerraform)
//          - Creates its own resource group: {base-name}-aca-rg
//          - Each stage is self-contained with no data source dependencies

// ========================================================================
// Stage 1: Container Registry (provisioned BEFORE image build/push)
// ========================================================================
// NOTE: Provider configuration must be duplicated in both callbacks since
// registry and environment have separate state directories.
var acr = builder.AddTerraformContainerRegistry("acr")
    .ConfigureInfrastructure(registry =>
    {
        // Provider Configuration - must be duplicated per stage
        var azurerm = new AzurermProvider("azurerm")
        {
            UseCli = true,
            SubscriptionId = registry.AddVariable(subscriptionIdParameter).AsReference(),
            Features = [new()]
        };
        registry.Add(azurerm);

        // Variables from Aspire Parameters
        var baseNameVar = registry.AddVariable(baseNameParameter);
        var locationVar = registry.AddVariable(locationParameter);

        // Common tags
        var tags = new TerraformMap<string>
        {
            ["Environment"] = "Development",
            ["ManagedBy"] = "Aspire-Terraform"
        };

        // Resource Group for Registry (separate from ACA resource group)
        var resourceGroup = new AzurermResourceGroup("rg")
        {
            Name = Tf.Interpolate($"{baseNameVar.AsReference()}-registry-rg"),
            Location = locationVar.AsReference(),
            Tags = tags
        };
        registry.Add(resourceGroup);

        // Generate a random suffix for globally unique ACR name
        var acrSuffix = new TerraformResource("random_string", "acr_suffix")
        {
            ["length"] = 8,
            ["special"] = false,
            ["upper"] = false,
            ["numeric"] = true,
            ["keepers"] = new TerraformMap<string>
            {
                ["resource_group"] = resourceGroup.Name
            }
        };
        registry.Add(acrSuffix);

        // Azure Container Registry
        var containerRegistry = new AzurermContainerRegistry("acr")
        {
            Name = Tf.Interpolate($"acr{acrSuffix["result"]}"),
            Location = resourceGroup.Location,
            ResourceGroupName = resourceGroup.Name,
            Sku = "Basic",
            AdminEnabled = true,
            Tags = tags
        };
        registry.Add(containerRegistry);

        // Required outputs: "name" and "endpoint" for IContainerRegistry
        registry.Add(new TerraformOutput("name")
        {
            Value = containerRegistry.Name,
            Description = "The name of the Azure Container Registry"
        });

        registry.Add(new TerraformOutput("endpoint")
        {
            Value = containerRegistry.LoginServer,
            Description = "The login server URL for the Azure Container Registry"
        });

        // Additional outputs for reference in Stage 2
        registry.Add(new TerraformOutput("resource_group_name")
        {
            Value = resourceGroup.Name,
            Description = "The name of the registry resource group"
        });

        registry.Add(new TerraformOutput("acr_id")
        {
            Value = containerRegistry.Id,
            Description = "The ID of the Azure Container Registry"
        });
    })
    .WithLoginCallback(TerraformContainerRegistryHelpers.CreateAzureCliLoginCallback());

// ========================================================================
// Terraform Environment (references the registry)
// ========================================================================
var terraform = builder.AddTerraformEnvironment("azure", acr)
    .WithBackend("local")
    .WithSettings(settings =>
    {
        settings.RequiredProviders = new()
        {
            ["azurerm"] = new ProviderRequirement()
            {
                Source = "hashicorp/azurerm",
                Version = "~> 4.0"
            },
            ["random"] = new ProviderRequirement()
            {
                Source = "hashicorp/random",
                Version = "~> 3.0"
            }
        };
    });

// ========================================================================
// Stage 2: Environment Infrastructure (provisioned AFTER image push)
// ========================================================================
// NOTE: Each stage is self-contained. The environment creates its own
// resource group and does not reference resources from Stage 1 via data sources.
terraform.PublishAsTerraform(infra =>
    {
        // Provider Configuration - must be duplicated per stage
        var azurerm = new AzurermProvider("azurerm")
        {
            UseCli = true,
            SubscriptionId = infra.AddVariable(subscriptionIdParameter).AsReference(),
            Features = [new()]
        };
        infra.Add(azurerm);

        // Variables from Aspire Parameters
        var baseNameVar = infra.AddVariable(baseNameParameter);
        var locationVar = infra.AddVariable(locationParameter);

        // Get registry outputs using lazy-initialized properties (NEW API)
        // Properties auto-create variables on first access - much cleaner!
        var registryEndpointVar = infra.RegistryEndpoint;
        var registryNameVar = infra.RegistryName;

        // Common tags
        var tags = new TerraformMap<string>
        {
            ["Environment"] = "Development",
            ["ManagedBy"] = "Aspire-Terraform"
        };

        // Resource Group for ACA (separate from registry resource group)
        var resourceGroup = new AzurermResourceGroup("rg")
        {
            Name = Tf.Interpolate($"{baseNameVar.AsReference()}-aca-rg"),
            Location = locationVar.AsReference(),
            Tags = tags
        };
        infra.Add(resourceGroup);

        // Log Analytics Workspace
        var logAnalytics = new AzurermLogAnalyticsWorkspace("law")
        {
            Name = Tf.Interpolate($"{baseNameVar.AsReference()}-law"),
            Location = locationVar.AsReference(),
            ResourceGroupName = resourceGroup.Name,
            Sku = "PerGB2018",
            RetentionInDays = 30,
            Tags = tags
        };
        infra.Add(logAnalytics);

        // User Assigned Managed Identity for ACR pull
        var managedIdentity = new AzurermUserAssignedIdentity("mi")
        {
            Name = Tf.Interpolate($"{baseNameVar.AsReference()}-mi"),
            Location = locationVar.AsReference(),
            ResourceGroupName = resourceGroup.Name,
            Tags = tags
        };
        infra.Add(managedIdentity);

        // Data source to reference the existing ACR (created in Stage 1)
        // This allows us to get the ACR ID for role assignment
        var acrDataSource = new TerraformDataSource("azurerm_container_registry", "acr")
        {
            ["name"] = registryNameVar.AsReference(),
            ["resource_group_name"] = Tf.Interpolate($"{baseNameVar.AsReference()}-registry-rg")
        };
        infra.Add(acrDataSource);

        // Role Assignment: ACR Pull
        var acrPullRole = new AzurermRoleAssignment("acr-pull")
        {
            Scope = acrDataSource["id"].AsLazy<string>(),
            RoleDefinitionName = "AcrPull",
            PrincipalId = managedIdentity.PrincipalId,
            PrincipalType = "ServicePrincipal"
        };
        infra.Add(acrPullRole);

        // Container App Environment
        var containerAppEnvironment = new AzurermContainerAppEnvironment("cae")
        {
            Name = Tf.Interpolate($"{baseNameVar.AsReference()}-cae"),
            Location = locationVar.AsReference(),
            ResourceGroupName = resourceGroup.Name,
            LogAnalyticsWorkspaceId = logAnalytics.Id,
            LogsDestination = "log-analytics",
            Tags = tags
        };
        infra.Add(containerAppEnvironment);

        // Outputs
        infra.Add(new TerraformOutput("AZURE_LOG_ANALYTICS_WORKSPACE_NAME")
        {
            Value = logAnalytics.Name,
            Description = "The name of the Log Analytics workspace"
        });

        infra.Add(new TerraformOutput("AZURE_CONTAINER_APPS_ENVIRONMENT_ID")
        {
            Value = containerAppEnvironment.Id,
            Description = "The ID of the Container App Environment"
        });

        infra.Add(new TerraformOutput("AZURE_CONTAINER_APPS_ENVIRONMENT_DEFAULT_DOMAIN")
        {
            Value = containerAppEnvironment.DefaultDomain,
            Description = "The default domain for the Container App Environment"
        });

        // Export for dependent resources using simplified AddOutput API (NEW API)
        // Single method - creates reference and adds output internally
        infra.AddOutput("container_env_id", containerAppEnvironment.Id);
        infra.AddOutput("managed_identity_id", managedIdentity.Id);
        infra.AddOutput("resource_group_name", resourceGroup.Name);
    });

// ============================================================================
// Application Resources
// ============================================================================

// Frontend - Vite app that will be built and served by YARP
var frontend = builder.AddViteApp("frontend", "../frontend");

// YARP reverse proxy - serves static files in publish mode
var app = builder.AddYarp("app")
    .WithConfiguration(c =>
    {
        if (builder.ExecutionContext.IsRunMode)
        {
            c.AddRoute("{**catch-all}", frontend);
        }
    })
    .WithExternalHttpEndpoints()
    .PublishWithStaticFiles(frontend)
    .PublishAsTerraform(infra =>
    {
        // Get references using simplified AddVariable API (NEW API)
        // Single method - gets parent output and creates variable internally
        var containerEnvIdVar = infra.AddVariable("container_env_id");
        var managedIdentityIdVar = infra.AddVariable("managed_identity_id");
        var resourceGroupVar = infra.AddVariable("resource_group_name");

        // Use lazy-initialized properties for container image and registry (NEW API)
        // Properties auto-create variables on first access - much cleaner!
        var containerImageVar = infra.ContainerImage;
        var registryEndpointVar = infra.RegistryEndpoint;

        // Container App for the YARP application
        var containerApp = new AzurermContainerApp("app")
        {
            Name = "aspire-vite-yarp-app",
            ResourceGroupName = resourceGroupVar.AsReference(),
            ContainerAppEnvironmentId = containerEnvIdVar.AsReference(),
            RevisionMode = "Single",
            Tags = new()
            {
                ["Environment"] = "Development",
                ["ManagedBy"] = "Aspire-Terraform"
            },
            Identity =
            [
                new()
                {
                    Type = "UserAssigned",
                    IdentityIds = [managedIdentityIdVar.AsReference()]
                }
            ],
            Registry =
            [
                new()
                {
                    Server = registryEndpointVar.AsReference(),
                    Identity = managedIdentityIdVar.AsReference()
                }
            ],
            Template =
            [
                new()
                {
                    MinReplicas = 1,
                    MaxReplicas = 3,
                    Container =
                    [
                        new()
                        {
                            Name = "app",
                            // Use the container image from the build/push process
                            Image = containerImageVar.AsReference(),
                            Cpu = 0.25,
                            Memory = "0.5Gi",
                            // Command = entrypoint, Args = command in Docker terms
                            Command = ["dotnet"],
                            Args = ["/app/yarp.dll"],
                            Env =
                            [
                                new() { Name = "ASPNETCORE_ENVIRONMENT", Value = "Production" },
                                new() { Name = "ASPNETCORE_URLS", Value = "http://+:8080" },
                                new() { Name = "YARP_ENABLE_STATIC_FILES", Value = "true" }
                            ]
                        }
                    ],
                    HttpScaleRule =
                    [
                        new()
                        {
                            Name = "http-scale",
                            ConcurrentRequests = "100"
                        }
                    ]
                }
            ],
            Ingress =
            [
                new()
                {
                    TargetPort = 8080,
                    ExternalEnabled = true,
                    Transport = "auto",
                    TrafficWeight =
                    [
                        new()
                        {
                            LatestRevision = true,
                            Percentage = 100
                        }
                    ]
                }
            ]
        };

        infra.Add(containerApp);

        infra.Add(new TerraformOutput("app_url")
        {
            Value = Tf.Interpolate($"https://{containerApp.LatestRevisionFqdn}"),
            Description = "The URL of the deployed application"
        });
    });

builder.Build().Run();
