terraform {
  required_version = ">= 1.4.0"
}

variable "environment" {
  type = string
}

resource "terraform_data" "network" {
  input = "net-${var.environment}"
}

output "network_id" {
  value = terraform_data.network.output
}
