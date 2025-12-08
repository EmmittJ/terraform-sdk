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

resource "azurerm_resource_group" "rg" {
  location = var.location
  name     = "azure-registry-rg"
  tags = {
    ManagedBy = "Aspire-Terraform"
  }
}

resource "random_pet" "acr_pet" {
  keepers = {
    resource_group  = azurerm_resource_group.rg.name
    subscription_id = var.azure_subscription_id
  }
  length    = 1
  separator = ""
}

resource "random_string" "acr_suffix" {
  keepers = {
    resource_group  = azurerm_resource_group.rg.name
    subscription_id = var.azure_subscription_id
  }
  length  = 4
  lower   = false
  numeric = true
  special = false
  upper   = false
}

resource "azurerm_container_registry" "acr" {
  admin_enabled       = true
  location            = azurerm_resource_group.rg.location
  name                = "acr${random_pet.acr_pet.id}${random_string.acr_suffix.result}"
  resource_group_name = azurerm_resource_group.rg.name
  sku                 = "Basic"
  tags = {
    ManagedBy = "Aspire-Terraform"
  }
}

output "name" {
  description = "The name of the Azure Container Registry"
  value       = azurerm_container_registry.acr.name
}

output "endpoint" {
  description = "The login server URL for the Azure Container Registry"
  value       = azurerm_container_registry.acr.login_server
}
