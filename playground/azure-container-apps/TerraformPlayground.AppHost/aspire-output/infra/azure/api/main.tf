variable "azure_container_env_id" {
  type = string
}

variable "cache_connection_string" {
  sensitive = true
  type      = string
}

variable "appdb_connection_string" {
  sensitive = true
  type      = string
}

resource "azurerm_container_app" "api" {
  container_app_environment_id = var.azure_container_env_id
  name                         = "aspire-api"
  resource_group_name          = "aspire-playground-rg"
  revision_mode                = "Single"
  tags = {
    Environment = "Development"
    ManagedBy   = "Aspire"
  }
  secret {
    name  = "redis-connection"
    value = var.cache_connection_string
  }
  secret {
    name  = "postgres-connection"
    value = var.appdb_connection_string
  }
  template {
    max_replicas = 1
    min_replicas = 1
    container {
      cpu    = 0.5
      image  = "aspireplayground/api:latest"
      memory = "1Gi"
      name   = "api-container"
      env {
        name        = "ConnectionStrings__cache"
        secret_name = "redis-connection"
      }
      env {
        name        = "ConnectionStrings__appdb"
        secret_name = "postgres-connection"
      }
    }
  }
}

output "api_fqdn" {
  description = "The FQDN of the API Container App"
  value       = azurerm_container_app.api.latest_revision_fqdn
}
