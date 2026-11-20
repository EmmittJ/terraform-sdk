# A template: a single HCL file used with AddTerraformTemplate(name, file).
variable "size" {
  type = string
}

resource "terraform_data" "cache" {
  input = "cache-${var.size}"
}

output "cache_id" {
  value = terraform_data.cache.output
}
