variable "azure_container_env_id" {
  type = string
}

variable "azure_managed_identity_id" {
  type = string
}

variable "azure_resource_group_name" {
  type = string
}

variable "api_container_image" {
  description = "Container image reference for 'api'"
  type        = string
}

variable "azure_registry_endpoint" {
  type = string
}

resource "azurerm_container_app" "api" {
  container_app_environment_id = var.azure_container_env_id
  name                         = "api"
  resource_group_name          = var.azure_resource_group_name
  revision_mode                = "Single"
  tags = {
    ManagedBy = "Aspire-Terraform"
  }
  identity {
    identity_ids = [var.azure_managed_identity_id]
    type         = "UserAssigned"
  }
  ingress {
    external_enabled = false
    target_port      = 80
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
      args   = ["main:app", "--host", "0.0.0.0", "--port", "80"]
      cpu    = 0.25
      image  = var.api_container_image
      memory = "0.5Gi"
      name   = "api"
      env {
        name  = "OTEL_TRACES_EXPORTER"
        value = "otlp"
      }
      env {
        name  = "OTEL_LOGS_EXPORTER"
        value = "otlp"
      }
      env {
        name  = "OTEL_METRICS_EXPORTER"
        value = "otlp"
      }
      env {
        name  = "OTEL_PYTHON_LOGGING_AUTO_INSTRUMENTATION_ENABLED"
        value = "true"
      }
      env {
        name  = "PORT"
        value = "80"
      }
    }
    http_scale_rule {
      concurrent_requests = "100"
      name                = "http-scale"
    }
  }
}

output "http_endpoint" {
  value = "http://api"
}
