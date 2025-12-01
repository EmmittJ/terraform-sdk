variable "azure_container_env_id" {
  type = string
}

variable "azure_managed_identity_id" {
  type = string
}

variable "azure_resource_group_name" {
  type = string
}

variable "app_container_image" {
  description = "Container image reference for 'app'"
  type        = string
}

variable "acr_endpoint" {
  type = string
}

resource "azurerm_container_app" "app" {
  container_app_environment_id = var.azure_container_env_id
  name                         = "aspire-vite-yarp-app"
  resource_group_name          = var.azure_resource_group_name
  revision_mode                = "Single"
  tags = {
    Environment = "Development"
    ManagedBy   = "Aspire-Terraform"
  }
  identity {
    identity_ids = [var.azure_managed_identity_id]
    type         = "UserAssigned"
  }
  ingress {
    external_enabled = true
    target_port      = 8080
    transport        = "auto"
    traffic_weight {
      latest_revision = true
      percentage      = 100
    }
  }
  registry {
    identity = var.azure_managed_identity_id
    server   = var.acr_endpoint
  }
  template {
    max_replicas = 3
    min_replicas = 1
    container {
      args    = ["/app/yarp.dll"]
      command = ["dotnet"]
      cpu     = 0.25
      image   = var.app_container_image
      memory  = "0.5Gi"
      name    = "app"
      env {
        name  = "ASPNETCORE_ENVIRONMENT"
        value = "Production"
      }
      env {
        name  = "ASPNETCORE_URLS"
        value = "http://+:8080"
      }
      env {
        name  = "YARP_ENABLE_STATIC_FILES"
        value = "true"
      }
    }
    http_scale_rule {
      concurrent_requests = "100"
      name                = "http-scale"
    }
  }
}

output "app_url" {
  description = "The URL of the deployed application"
  value       = "https://${azurerm_container_app.app.latest_revision_fqdn}"
}
