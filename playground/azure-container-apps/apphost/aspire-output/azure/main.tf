terraform {
  backend "local" {
  }
  required_providers {
    azurerm = {
      source  = "hashicorp/azurerm"
      version = "~> 4.0"
    }
    random = {
      source  = "hashicorp/random"
      version = "~> 3.0"
    }
  }
}

variable "azure_subscription_id" {
  description = "Parameter 'azure-subscription-id'"
  sensitive   = false
  type        = string
}

provider "azurerm" {
  subscription_id = var.azure_subscription_id
  use_cli         = true
  features {
  }
}

variable "location" {
  default = "westus2"
  type    = string
}

variable "azure_acr_endpoint" {
  type = string
}

variable "azure_acr_name" {
  type = string
}

resource "azurerm_resource_group" "rg" {
  location = var.location
  name     = "azure-aca-rg"
  tags = {
    Environment = "Development"
    ManagedBy   = "Aspire-Terraform"
  }
}

resource "azurerm_log_analytics_workspace" "law" {
  location            = var.location
  name                = "azure-law"
  resource_group_name = "azure-aca-rg"
  retention_in_days   = 30
  sku                 = "PerGB2018"
  tags = {
    Environment = "Development"
    ManagedBy   = "Aspire-Terraform"
  }
}

resource "azurerm_user_assigned_identity" "mi" {
  location            = var.location
  name                = "azure-mi"
  resource_group_name = "azure-aca-rg"
  tags = {
    Environment = "Development"
    ManagedBy   = "Aspire-Terraform"
  }
}

data "azurerm_container_registry" "acr" {
  name                = var.azure_acr_name
  resource_group_name = "azure-registry-rg"
}

resource "azurerm_role_assignment" "acr-pull" {
  principal_id         = azurerm_user_assigned_identity.mi.principal_id
  principal_type       = "ServicePrincipal"
  role_definition_name = "AcrPull"
  scope                = data.azurerm_container_registry.acr.id
}

resource "azurerm_container_app_environment" "cae" {
  location                   = var.location
  log_analytics_workspace_id = azurerm_log_analytics_workspace.law.id
  logs_destination           = "log-analytics"
  name                       = "azure-cae"
  resource_group_name        = "azure-aca-rg"
  tags = {
    Environment = "Development"
    ManagedBy   = "Aspire-Terraform"
  }
}

output "container_env_id" {
  value = azurerm_container_app_environment.cae.id
}

output "managed_identity_id" {
  value = azurerm_user_assigned_identity.mi.id
}

output "resource_group_name" {
  value = "azure-aca-rg"
}

module "app" {
  app_container_image       = var.app_container_image
  azure_acr_endpoint        = var.azure_acr_endpoint
  azure_container_env_id    = azurerm_container_app_environment.cae.id
  azure_managed_identity_id = azurerm_user_assigned_identity.mi.id
  azure_resource_group_name = "azure-aca-rg"
  source                    = "./app"
}

variable "app_container_image" {
  description = "Container image reference for 'app'"
  type        = string
}
