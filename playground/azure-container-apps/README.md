# Azure Container Apps with Terraform

This sample demonstrates deploying an Aspire application to Azure Container Apps using Terraform instead of Bicep. It mirrors the functionality of `Aspire.Hosting.Azure.AppContainers` but generates Terraform configuration.

## Architecture

```
┌─────────────────────────────────────────────────────────────────────────┐
│                         Azure Resource Group                            │
├─────────────────────────────────────────────────────────────────────────┤
│                                                                         │
│  ┌─────────────────────┐     ┌─────────────────────────────────────────┐│
│  │  Log Analytics      │     │  Container App Environment              ││
│  │  Workspace          │────>│  (Consumption workload profile)         ││
│  └─────────────────────┘     │                                         ││
│                              │  ┌─────────────────────────────────┐    ││
│  ┌─────────────────────┐     │  │  Container App: app             │    ││
│  │  Azure Container    │     │  │  - YARP reverse proxy           │    ││
│  │  Registry (ACR)     │────>│  │  - Static files baked in        │    ││
│  └─────────────────────┘     │  │  - External HTTPS ingress       │    ││
│           │                  │  └─────────────────────────────────┘    ││
│           │                  └─────────────────────────────────────────┘│
│           │                                                             │
│  ┌─────────────────────┐                                                │
│  │  User Assigned      │<──── AcrPull role assignment                   │
│  │  Managed Identity   │                                                │
│  └─────────────────────┘                                                │
│                                                                         │
└─────────────────────────────────────────────────────────────────────────┘
```

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
│   ├── AppHost.cs          # Aspire app host with Terraform configuration
│   └── AppHost.csproj      # Project file
├── frontend/
│   ├── src/                # Vite application source
│   ├── package.json        # Node.js dependencies
│   └── vite.config.js      # Vite configuration
└── README.md               # This file
```

## Local Development

Run the application locally with the Vite dev server:

```bash
cd apphost
aspire run
```

This starts:

- YARP reverse proxy on https://localhost:5001
- Vite dev server (proxied through YARP)

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

- `aspire-output/azure/main.tf` - Main Terraform configuration
- `aspire-output/azure/app/main.tf` - Container App specific configuration

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

The Terraform configuration exports these outputs (matching Aspire's Azure.AppContainers):

| Output                                            | Description                             |
| ------------------------------------------------- | --------------------------------------- |
| `AZURE_LOG_ANALYTICS_WORKSPACE_NAME`              | Name of the Log Analytics workspace     |
| `AZURE_LOG_ANALYTICS_WORKSPACE_ID`                | ID of the Log Analytics workspace       |
| `AZURE_CONTAINER_REGISTRY_NAME`                   | Name of the Azure Container Registry    |
| `AZURE_CONTAINER_REGISTRY_ENDPOINT`               | Login server URL for ACR                |
| `AZURE_CONTAINER_REGISTRY_MANAGED_IDENTITY_ID`    | ID of the managed identity for ACR pull |
| `AZURE_CONTAINER_APPS_ENVIRONMENT_NAME`           | Name of the Container App Environment   |
| `AZURE_CONTAINER_APPS_ENVIRONMENT_ID`             | ID of the Container App Environment     |
| `AZURE_CONTAINER_APPS_ENVIRONMENT_DEFAULT_DOMAIN` | Default domain for the environment      |
| `app_url`                                         | URL of the deployed application         |

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

### Aspire → Terraform Translation

The `PublishAsTerraform` extension method captures the infrastructure definition and generates Terraform HCL instead of Bicep. The pattern mirrors `Aspire.Hosting.Azure.AppContainers`:

1. **Environment Setup** (`AddTerraformEnvironment`):

   - Creates resource group, Log Analytics, ACR, managed identity, and Container App Environment
   - Exports outputs that can be referenced by dependent resources

2. **Resource Configuration** (`PublishAsTerraform` on resources):
   - Defines the Container App configuration
   - References outputs from the environment (ACR endpoint, environment ID, etc.)
   - Configures ingress, scaling, and environment variables

### Key Differences from Bicep

| Feature    | Bicep (Azure.AppContainers) | Terraform (this sample) |
| ---------- | --------------------------- | ----------------------- |
| Language   | Bicep DSL                   | HCL                     |
| State      | Azure Resource Manager      | Local or remote backend |
| Outputs    | `output` statements         | `output` blocks         |
| References | `@` syntax                  | Attribute references    |
| Modules    | Bicep modules               | Terraform modules       |

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
  --name aspire-vite-yarp-app \
  --resource-group $(terraform output -raw resource_group_name) \
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
