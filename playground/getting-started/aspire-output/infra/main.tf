terraform {
  backend "local" {
  }
}

variable "environment" {
  description = "Parameter 'environment'"
  sensitive   = false
  type        = string
}

variable "project_name" {
  description = "Parameter 'project-name'"
  sensitive   = false
  type        = string
}

resource "local_file" "config" {
  content  = "\"environment\": \"${var.environment}\"\n\"project\": \"${var.project_name}\""
  filename = "${path.module}/output/config.txt"
}

output "config_path" {
  description = "Path to the generated config file"
  value       = local_file.config.filename
}

output "environment" {
  description = "The deployment environment"
  value       = var.environment
}
