variable "environment" {
  description = "Environment name"
  type = string
  default = "development"
}

variable "instance_count" {
  type = number
  default = "3"
}

variable "enable_monitoring" {
  type = bool
  default = "true"
}

