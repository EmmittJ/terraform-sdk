# Azure Container Apps with Terraform

This sample demonstrates deploying an Aspire application to Azure Container Apps using Terraform instead of Bicep. It mirrors the functionality of `Aspire.Hosting.Azure.AppContainers` but generates Terraform configuration using the **EmmittJ.Terraform.Sdk**.

## Application Overview

This sample deploys a full-stack Todo application:

- **Frontend**: React + Vite SPA for managing todos
- **Backend**: FastAPI (Python) REST API with in-memory storage
- **Gateway**: YARP reverse proxy that routes `/api/*` to the backend and serves static files

## Architecture

```
┌─────────────────────────────────────────────────────────────────────────┐
│                    Azure Resource Group: {name}-aca-rg                  │
├─────────────────────────────────────────────────────────────────────────┤
│                                                                         │
│  ┌─────────────────────┐     ┌─────────────────────────────────────────┐│
│  │  Log Analytics      │     │  Container App Environment              ││
│  │  Workspace          │────▶│  (Consumption workload profile)         ││
│  │  {name}-law         │     │  {name}-cae                             ││
│  └─────────────────────┘     │                                         ││
│                              │  ┌─────────────────────────────────────┐││
│                              │  │  Container App: app                 │││
│                              │  │  - YARP reverse proxy               │││
│                              │  │  - Static files baked in            │││
│                              │  │  - External HTTPS ingress           │││
│                              │  │  - Auto-scaling (1-3 replicas)      │││
│                              │  └─────────────────────────────────────┘││
│                              └─────────────────────────────────────────┘│
│                                           │                             │
│  ┌─────────────────────────────────────────────────────────────────────┐│
│  │  User Assigned Managed Identity: {name}-mi                          ││
│  │  └── AcrPull role assignment ─────────────────────────────────────┐ ││
│  └───────────────────────────────────────────────────────────────────│─┘│
│                                                                      │  │
└──────────────────────────────────────────────────────────────────────│──┘
                                                                       │
┌──────────────────────────────────────────────────────────────────────│──┐
│                  Azure Resource Group: {name}-registry-rg            │  │
├──────────────────────────────────────────────────────────────────────│──┤
│                                                                      ▼  │
│  ┌─────────────────────────────────────────────────────────────────────┐│
│  │  Azure Container Registry: acr{random_pet}{random_suffix}           ││
│  │  (Basic SKU, globally unique name via random_pet + random_string)   ││
│  └─────────────────────────────────────────────────────────────────────┘│
│                                                                         │
└─────────────────────────────────────────────────────────────────────────┘
```

### Two-Stage Terraform Deployment

The infrastructure uses a **two-stage deployment** pattern to handle the container registry dependency:

1. **Stage 1: Container Registry** (separate Terraform state)

   - Resource Group: `{name}-registry-rg`
   - Azure Container Registry with globally unique name (`random_pet` + `random_string`)
   - Outputs: `name`, `endpoint` (consumed by Stage 2)

2. **Stage 2: Environment + Container Apps** (`azure/main.tf` - single `terraform apply`)

   - Resource Group: `{name}-aca-rg`
   - Log Analytics Workspace
   - User Assigned Managed Identity with AcrPull role
   - Container App Environment
   - **Container App modules** (e.g., `./api`, `./app`) - provisioned together with environment
   - Inter-app references resolved via module outputs (e.g., `module.api.http_endpoint`)

This two-stage approach is required because images must be pushed to ACR before the Container Apps can reference them.

## Infrastructure Comparison

| Aspire Azure.AppContainers (Bicep) | Terraform Equivalent                |
| ---------------------------------- | ----------------------------------- |
| `ContainerAppManagedEnvironment`   | `azurerm_container_app_environment` |
| `ContainerApp`                     | `azurerm_container_app`             |
| `ContainerRegistryService`         | `azurerm_container_registry`        |
| `OperationalInsightsWorkspace`     | `azurerm_log_analytics_workspace`   |
| `UserAssignedIdentity`             | `azurerm_user_assigned_identity`    |
| Role Assignment (AcrPull)          | `azurerm_role_assignment`           |

## Prerequisites

- [.NET 10.0 SDK](https://dotnet.microsoft.com/download)
- [Node.js 18+](https://nodejs.org/) (for Vite frontend)
- [Terraform CLI](https://www.terraform.io/downloads)
- [Azure CLI](https://docs.microsoft.com/cli/azure/install-azure-cli)
- An Azure subscription

## Project Structure

```
azure-container-apps/
├── apphost/
│   ├── AppHost.cs                                      # Aspire app host with Terraform configuration
│   ├── AppHost.csproj                                  # Project file
│   ├── TerraformAzureContainerAppEnvironmentResource.cs # Environment resource (ACR, LAW, CAE)
│   ├── TerraformAzureContainerAppEnvironmentExtensions.cs # Fluent API extensions
│   ├── TerraformAzureContainerAppContext.cs            # Container App builder context
│   └── TerraformAzureContainerAppCustomizationAnnotation.cs # Customization callback
├── api/
│   ├── main.py                 # FastAPI Todo REST API
│   └── requirements.txt        # Python dependencies (fastapi, uvicorn)
├── frontend/
│   ├── src/
│   │   └── App.jsx             # React Todo app component
│   ├── package.json            # Node.js dependencies
│   └── vite.config.js          # Vite configuration
└── README.md                   # This file
```

## Local Development

Run the application locally with the Aspire app host:

```bash
cd apphost
aspire run
```

This starts:

- YARP reverse proxy on https://localhost:5001
- FastAPI backend (Todo API with `/api/todos` endpoints)
- Vite dev server (proxied through YARP for hot module replacement)

## Publishing to Azure

### Option 1: Full Deployment with `aspire deploy`

The easiest way to deploy is using the Aspire CLI, which handles all steps automatically:

```bash
# From the azure-container-apps directory
aspire deploy
```

This command:

1. Generates Terraform configuration
2. Runs `terraform init` and `terraform apply`
3. Builds and publishes container images
4. Pushes images to the created ACR
5. Updates the Container App with the new image

### Option 2: Preview Generated Terraform with `aspire publish`

To inspect the generated Terraform configuration without deploying:

```bash
# From the azure-container-apps directory
aspire publish
```

This generates:

```
aspire-output/azure/
├── main.tf              # Root module: environment + module calls
├── api/
│   └── main.tf          # API Container App (FastAPI backend)
└── app/
    └── main.tf          # YARP reverse proxy Container App
```

The root `main.tf` includes:

- Provider configuration (azurerm ~> 4.0, random ~> 3.0)
- Environment resources (resource group, log analytics, managed identity, CAE)
- Module calls: `module "api"` and `module "app"` with inter-module references

You can then review the generated HCL and optionally run Terraform manually:

```bash
cd aspire-output

# Initialize Terraform
terraform init

# Preview changes
terraform plan

# Apply infrastructure (when ready)
terraform apply
```

### Configuration

You can configure deployment parameters via environment variables:

```bash
export Parameters__azure_subscription_id="your-subscription-id"
export Parameters__resource_group="rg-aspire-aca-demo"
export Parameters__location="westus2"

aspire deploy
```

### Verify Deployment

```bash
# Get the application URL
cd aspire-output
terraform output app_url

# Open in browser
open $(terraform output -raw app_url)
```

## Outputs

The Terraform configuration exports these outputs:

### Stage 1: Registry Outputs (separate state)

| Output     | Description                                        |
| ---------- | -------------------------------------------------- |
| `name`     | Name of the Azure Container Registry               |
| `endpoint` | Login server URL for ACR (e.g., `acr*.azurecr.io`) |

### Stage 2: Environment + Apps Outputs (`azure/main.tf`)

| Output                | Description                               |
| --------------------- | ----------------------------------------- |
| `container_env_id`    | ID of the Container App Environment       |
| `managed_identity_id` | ID of the managed identity for ACR pull   |
| `resource_group_name` | Name of the Container Apps resource group |

### Container App Module Outputs (e.g., `module.api`, `module.app`)

| Output           | Description                                   |
| ---------------- | --------------------------------------------- |
| `http_endpoint`  | HTTP endpoint URL for inter-app communication |
| `https_endpoint` | HTTPS endpoint URL (for external ingress)     |

## CI/CD Integration

For GitHub Actions or Azure DevOps, you can use `aspire deploy` for a streamlined workflow:

```yaml
# Example GitHub Actions workflow
- name: Deploy to Azure
  run: aspire deploy
  env:
    Parameters__azure_subscription_id: ${{ secrets.AZURE_SUBSCRIPTION_ID }}
    Parameters__resource_group: rg-aspire-aca-demo
    Parameters__location: westus2
```

Or for more control, use the generated Terraform directly:

```yaml
# Example GitHub Actions workflow with manual Terraform steps
- name: Generate Terraform
  run: aspire publish

- name: Deploy Infrastructure
  run: |
    cd aspire-output
    terraform init
    terraform apply -auto-approve

- name: Build and Push Image
  run: |
    ACR_NAME=$(cd aspire-output && terraform output -raw AZURE_CONTAINER_REGISTRY_NAME)
    az acr login --name $ACR_NAME
    docker build -t $(cd aspire-output && terraform output -raw AZURE_CONTAINER_REGISTRY_ENDPOINT)/app:${{ github.sha }} .
    docker push $(cd aspire-output && terraform output -raw AZURE_CONTAINER_REGISTRY_ENDPOINT)/app:${{ github.sha }}

- name: Update Container App
  run: |
    cd aspire-output
    terraform apply -auto-approve -var="image-tag=${{ github.sha }}"
```

## Clean Up

To remove all deployed resources:

```bash
cd aspire-output
terraform destroy
```

## How It Works

### Implementation Overview

The sample implements a custom `TerraformAzureContainerAppEnvironmentResource` that extends `TerraformCloudEnvironmentResource` from the SDK. This provides:

1. **Two-stage infrastructure** via `ConfigureContainerRegistry()` and `ConfigureEnvironment()` overrides
2. **Fluent configuration API** via extension methods (`WithSubscriptionId()`, `WithLocation()`, `WithBackend()`)
3. **Per-resource Container App generation** via `TerraformAzureContainerAppContext`

### AppHost.cs - The Entry Point

```csharp
// Add the Terraform Azure Container App Environment
builder.AddTerraformAzureContainerAppEnvironment("azure")
    .WithSubscriptionId(subscriptionIdParameter)
    .WithLocation("westus2")
    .WithBackend("local");

// Publish resources as Terraform Container Apps
builder.AddYarp("app")
    .WithExternalHttpEndpoints()
    .PublishWithStaticFiles(frontend)
    .PublishAsTerraformContainerApp((infra, app) =>
    {
        // Customization callback - add tags, modify settings, etc.
        app.Tags ??= new();
        app.Tags["CustomTag"] = "MyValue";
    });
```

### Key Components

#### TerraformAzureContainerAppEnvironmentResource

Extends `TerraformCloudEnvironmentResource` and implements:

- **`ConfigureContainerRegistry()`**: Creates ACR with globally unique name using `random_pet` and `random_string`
- **`ConfigureEnvironment()`**: Creates Log Analytics, Managed Identity, Role Assignment, and Container App Environment
- **`CreateComputeResourceContext()`**: Returns `TerraformAzureContainerAppContext` for building Container Apps

#### TerraformAzureContainerAppContext

Extends `TerraformComputeResourceContext` and handles:

- **Endpoint processing**: Validates HTTP/HTTPS/TCP schemes, maps endpoints to ingress configuration
- **Container App generation**: Creates `AzurermContainerApp` with template, identity, registry, and ingress
- **Self-referencing resolution**: Resolves endpoint references within the same resource

### Aspire → Terraform Translation

The `PublishAsTerraformContainerApp` extension method captures the infrastructure definition and generates Terraform HCL instead of Bicep. The pattern mirrors `Aspire.Hosting.Azure.AppContainers`:

1. **Environment Setup** (`AddTerraformAzureContainerAppEnvironment`):

   - Creates resource group, Log Analytics, managed identity with AcrPull role, and Container App Environment
   - References ACR from Stage 1 via data source
   - All resources defined in root `main.tf`

2. **Container Apps as Modules** (`PublishAsTerraformContainerApp` on resources):
   - Each Container App is generated as a separate Terraform module (e.g., `./api`, `./app`)
   - Modules receive environment outputs via variables (`azure_container_env_id`, `azure_managed_identity_id`, etc.)
   - Inter-app references use module outputs (e.g., `module.api.http_endpoint`)
   - Supports customization via callback for adding tags, modifying settings, etc.

### Container App Features

The generated `AzurermContainerApp` includes:

- **User Assigned Identity**: For secure ACR pull without admin credentials
- **Registry configuration**: Points to the created ACR with identity-based auth
- **HTTP ingress**: External or internal, with HTTP/2 support
- **Auto-scaling**: HTTP-based scaling rules (1-3 replicas, 100 concurrent requests)
- **Environment variables**: Resolved from Aspire resource annotations
- **Custom tags**: `ManagedBy: Aspire-Terraform`

### Key Differences from Bicep

| Feature      | Bicep (Azure.AppContainers) | Terraform (this sample)        |
| ------------ | --------------------------- | ------------------------------ |
| Language     | Bicep DSL                   | HCL via EmmittJ.Terraform.Sdk  |
| State        | Azure Resource Manager      | Local or remote backend        |
| Outputs      | `output` statements         | `output` blocks                |
| References   | `@` syntax                  | Attribute references           |
| Modules      | Bicep modules               | Terraform modules              |
| Unique Names | `uniqueString()` function   | `random_pet` + `random_string` |

## Troubleshooting

### ACR Authentication Issues

If you get "unauthorized" errors when pushing images:

```bash
# Ensure you're logged into Azure CLI
az login

# Re-authenticate to ACR
az acr login --name $(terraform output -raw AZURE_CONTAINER_REGISTRY_NAME)
```

### Container App Not Starting

Check the logs:

```bash
az containerapp logs show \
  --name app \
  --resource-group {name}-aca-rg \
  --follow
```

### Terraform State Issues

If Terraform state gets out of sync:

```bash
# Import existing resources
terraform import azurerm_resource_group.rg /subscriptions/.../resourceGroups/...

# Or refresh state
terraform refresh
```
