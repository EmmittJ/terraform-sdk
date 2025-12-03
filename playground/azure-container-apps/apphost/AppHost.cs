#pragma warning disable ASPIREPIPELINES001 // Experimental API usage

using Aspire.Hosting;
using EmmittJ.Aspire.Hosting.Terraform;
using EmmittJ.Terraform.Sdk;
using EmmittJ.Terraform.Sdk.Providers.Azurerm;

var builder = DistributedApplication.CreateBuilder(args);

// Parameters
var subscriptionIdParameter = builder.AddParameter("azure-subscription-id");
var locationParameter = builder.AddParameter("location", "westus2");
var baseNameParameter = builder.AddParameter("base-name", "aspire-aca");

// Common tags used across all resources
var tags = new TerraformMap<string>
{
    ["Environment"] = "Development",
    ["ManagedBy"] = "Aspire-Terraform"
};

// Container Registry (Stage 1 - provisioned before image build/push)
var acr = builder.AddTerraformContainerRegistry("acr")
    .WithBackend("local")
    .WithSettings(settings =>
    {
        settings.RequiredProviders = new()
        {
            ["azurerm"] = new ProviderRequirement { Source = "hashicorp/azurerm", Version = "~> 4.0" },
            ["random"] = new ProviderRequirement { Source = "hashicorp/random", Version = "~> 3.0" }
        };
    })
    .PublishAsTerraform(registry =>
    {
        var azurerm = new AzurermProvider("azurerm")
        {
            UseCli = true,
            SubscriptionId = registry.AddVariable(subscriptionIdParameter).AsReference(),
            Features = [new()]
        };
        registry.Add(azurerm);

        var baseNameVar = registry.AddVariable(baseNameParameter);
        var locationVar = registry.AddVariable(locationParameter);

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

        // Required outputs for IContainerRegistry: "name" and "endpoint"
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
    })
    .WithLoginCallback(TerraformContainerRegistryHelpers.CreateAzureCliLoginCallback());

// Terraform Environment (Stage 2 - provisioned after image push)
var terraform = builder.AddTerraformEnvironment("azure", acr)
    .WithBackend("local")
    .WithSettings(settings =>
    {
        settings.RequiredProviders = new()
        {
            ["azurerm"] = new ProviderRequirement { Source = "hashicorp/azurerm", Version = "~> 4.0" },
            ["random"] = new ProviderRequirement { Source = "hashicorp/random", Version = "~> 3.0" }
        };
    })
    .PublishAsTerraform(infra =>
    {
        var azurerm = new AzurermProvider("azurerm")
        {
            UseCli = true,
            SubscriptionId = infra.AddVariable(subscriptionIdParameter).AsReference(),
            Features = [new()]
        };
        infra.Add(azurerm);

        var baseNameVar = infra.AddVariable(baseNameParameter);
        var locationVar = infra.AddVariable(locationParameter);
        var registryEndpointVar = infra.RegistryEndpoint;
        var registryNameVar = infra.RegistryName;

        var resourceGroup = new AzurermResourceGroup("rg")
        {
            Name = Tf.Interpolate($"{baseNameVar.AsReference()}-aca-rg"),
            Location = locationVar.AsReference(),
            Tags = tags
        };
        infra.Add(resourceGroup);

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

        var managedIdentity = new AzurermUserAssignedIdentity("mi")
        {
            Name = Tf.Interpolate($"{baseNameVar.AsReference()}-mi"),
            Location = locationVar.AsReference(),
            ResourceGroupName = resourceGroup.Name,
            Tags = tags
        };
        infra.Add(managedIdentity);

        // Data source to reference the existing ACR for role assignment
        var acrDataSource = new TerraformDataSource("azurerm_container_registry", "acr")
        {
            ["name"] = registryNameVar.AsReference(),
            ["resource_group_name"] = Tf.Interpolate($"{baseNameVar.AsReference()}-registry-rg")
        };
        infra.Add(acrDataSource);

        // Grant the managed identity permission to pull images from ACR
        var acrPullRole = new AzurermRoleAssignment("acr-pull")
        {
            Scope = acrDataSource["id"].AsLazy<string>(),
            RoleDefinitionName = "AcrPull",
            PrincipalId = managedIdentity.PrincipalId,
            PrincipalType = "ServicePrincipal"
        };
        infra.Add(acrPullRole);

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

        // Outputs consumed by child modules via AddVariable()
        infra.AddOutput("container_env_id", containerAppEnvironment.Id);
        infra.AddOutput("managed_identity_id", managedIdentity.Id);
        infra.AddOutput("resource_group_name", resourceGroup.Name);
    });

// Frontend Vite app
var frontend = builder.AddViteApp("frontend", "../frontend");

// YARP reverse proxy
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
        var containerEnvIdVar = infra.AddVariable("container_env_id");
        var managedIdentityIdVar = infra.AddVariable("managed_identity_id");
        var resourceGroupVar = infra.AddVariable("resource_group_name");
        var containerImageVar = infra.ContainerImage;
        var registryEndpointVar = infra.RegistryEndpoint;

        var containerApp = new AzurermContainerApp("app")
        {
            Name = "aspire-vite-yarp-app",
            ResourceGroupName = resourceGroupVar.AsReference(),
            ContainerAppEnvironmentId = containerEnvIdVar.AsReference(),
            RevisionMode = "Single",
            Tags = tags,
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
                            Image = containerImageVar.AsReference(),
                            Cpu = 0.25,
                            Memory = "0.5Gi",
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

        if (infra.TargetResource is IResourceWithEndpoints resource)
        {
            // Export the stable endpoint URL (not latest_revision_fqdn which changes per revision)
            // This matches Aspire's pattern: {resourcename}.{environment_default_domain}
            var fqdn = containerApp.Ingress.Index(0, m => m.Fqdn);
            infra.AddOutput(resource.GetEndpoint("http"), Tf.Interpolate($"https://{fqdn}"));
        }
    });

terraform
    .PublishAsTerraform(infra =>
    {
        // Pass through the child module's endpoint output to the root module
        infra.AddOutput(app.GetEndpoint("http"));
    });

builder.Build().Run();
