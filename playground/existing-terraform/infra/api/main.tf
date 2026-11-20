# Publishes the "api" container: PublishAsTerraformModule maps its endpoint to the `url` output.
variable "name" {
  type = string
}

variable "queue_id" {
  type = string
}

resource "terraform_data" "api" {
  input = "https://${var.name}.example.com?queue=${var.queue_id}"
}

output "url" {
  value = terraform_data.api.output
}
