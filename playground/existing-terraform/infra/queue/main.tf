# A reusable module: referenced with AddTerraformModule(name, source).
variable "name" {
  type = string
}

resource "terraform_data" "queue" {
  input = "queue-${var.name}"
}

output "queue_id" {
  value = terraform_data.queue.output
}
