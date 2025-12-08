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

variable "azure_registry_endpoint" {
  type = string
}

variable "api_http_endpoint" {
  type = string
}

resource "azurerm_container_app" "app" {
  container_app_environment_id = var.azure_container_env_id
  name                         = "app"
  resource_group_name          = var.azure_resource_group_name
  revision_mode                = "Single"
  tags = {
    CustomTag = "MyValue"
    ManagedBy = "Aspire-Terraform"
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
    server   = var.azure_registry_endpoint
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
        name  = "API_HTTP"
        value = var.api_http_endpoint
      }
      env {
        name  = "REVERSEPROXY__ROUTES__route0__MATCH__PATH"
        value = "api/{**catch-all}"
      }
      env {
        name  = "REVERSEPROXY__ROUTES__route0__CLUSTERID"
        value = "cluster_api"
      }
      env {
        name  = "REVERSEPROXY__ROUTES__route0__TRANSFORMS__0__PathRemovePrefix"
        value = "/api"
      }
      env {
        name  = "REVERSEPROXY__CLUSTERS__cluster_api__DESTINATIONS__destination1__ADDRESS"
        value = "http://api"
      }
      env {
        name  = "services__api__http__0"
        value = var.api_http_endpoint
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
