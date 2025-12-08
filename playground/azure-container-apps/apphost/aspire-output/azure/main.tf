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

variable "azure_registry_endpoint" {
  type = string
}

variable "azure_registry_name" {
  type = string
}

resource "azurerm_resource_group" "rg" {
  location = var.location
  name     = "azure-aca-rg"
  tags = {
    ManagedBy = "Aspire-Terraform"
  }
}

resource "azurerm_log_analytics_workspace" "law" {
  location            = var.location
  name                = "azure-law"
  resource_group_name = azurerm_resource_group.rg.name
  retention_in_days   = 30
  sku                 = "PerGB2018"
  tags = {
    ManagedBy = "Aspire-Terraform"
  }
}

resource "azurerm_user_assigned_identity" "mi" {
  location            = var.location
  name                = "azure-mi"
  resource_group_name = azurerm_resource_group.rg.name
  tags = {
    ManagedBy = "Aspire-Terraform"
  }
}

data "azurerm_container_registry" "acr" {
  name                = var.azure_registry_name
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
  resource_group_name        = azurerm_resource_group.rg.name
  tags = {
    ManagedBy = "Aspire-Terraform"
  }
}

output "container_env_id" {
  value = azurerm_container_app_environment.cae.id
}

output "managed_identity_id" {
  value = azurerm_user_assigned_identity.mi.id
}

output "resource_group_name" {
  value = azurerm_resource_group.rg.name
}

module "api" {
  api_container_image       = var.api_container_image
  azure_container_env_id    = azurerm_container_app_environment.cae.id
  azure_managed_identity_id = azurerm_user_assigned_identity.mi.id
  azure_registry_endpoint   = var.azure_registry_endpoint
  azure_resource_group_name = azurerm_resource_group.rg.name
  source                    = "./api"
}

module "app" {
  api_http_endpoint         = module.api.http_endpoint
  app_container_image       = var.app_container_image
  azure_container_env_id    = azurerm_container_app_environment.cae.id
  azure_managed_identity_id = azurerm_user_assigned_identity.mi.id
  azure_registry_endpoint   = var.azure_registry_endpoint
  azure_resource_group_name = azurerm_resource_group.rg.name
  source                    = "./app"
}

variable "api_container_image" {
  description = "Container image reference for 'api'"
  type        = string
}

variable "app_container_image" {
  description = "Container image reference for 'app'"
  type        = string
}
