terraform {
  backend "local" {
  }
  required_providers {
    azurerm = {
      source  = "hashicorp/azurerm"
      version = "~> 4.0"
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

variable "resource_group" {
  description = "Parameter 'resource-group'"
  sensitive   = false
  type        = string
}

resource "azurerm_resource_group" "aspire-rg" {
  location = "eastus"
  name     = var.resource_group
  tags = {
    Environment = "Development"
    ManagedBy   = "Aspire"
  }
}

resource "azurerm_container_app_environment" "container-env" {
  location            = azurerm_resource_group.aspire-rg.location
  name                = "aspire-container-env"
  resource_group_name = azurerm_resource_group.aspire-rg.name
}

output "resource_group_name" {
  value = azurerm_resource_group.aspire-rg.name
}

output "container-env-id" {
  value = azurerm_container_app_environment.container-env.id
}

module "cache" {
  source = "./cache"
}

module "appdb" {
  postgres_password = var.postgres_password
  source            = "./appdb"
}

module "api" {
  appdb_connection_string = module.appdb.connection-string
  azure_container_env_id  = azurerm_container_app_environment.container-env.id
  cache_connection_string = module.cache.connection-string
  source                  = "./api"
}

variable "postgres_password" {
  description = "Parameter 'postgres-password'"
  sensitive   = true
  type        = string
}
