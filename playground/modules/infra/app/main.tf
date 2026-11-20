terraform {
  required_version = ">= 1.4.0"
}

variable "network_id" {
  type = string
}

variable "callback_url" {
  type = string
}

resource "terraform_data" "app" {
  input = "app-in-${var.network_id}"
}

output "app_id" {
  value = terraform_data.app.output
}

output "callback_url" {
  value = var.callback_url
}
