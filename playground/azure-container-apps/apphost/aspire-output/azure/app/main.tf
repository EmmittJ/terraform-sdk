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

variable "azure_acr_endpoint" {
  type = string
}

resource "azurerm_container_app" "app" {
  container_app_environment_id = var.azure_container_env_id
  name                         = "app"
  resource_group_name          = var.azure_resource_group_name
  revision_mode                = "Single"
  tags = {
    CustomTag   = "MyValue"
    Environment = "Development"
    ManagedBy   = "Aspire-Terraform"
  }
  identity {
    identity_ids = [var.azure_managed_identity_id]
    type         = "UserAssigned"
  }
  ingress {
    external_enabled = true
    target_port      = 5000
    transport        = "auto"
    traffic_weight {
      latest_revision = true
      percentage      = 100
    }
  }
  registry {
    identity = var.azure_managed_identity_id
    server   = var.azure_acr_endpoint
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

output "http_endpoint" {
  value = "${"http"}://${azurerm_container_app.app.ingress[0].fqdn}"
}
