variable "environment" {
  default     = "development"
  description = "Environment name"
  type        = string
}

variable "instance_count" {
  default = "3"
  type    = number
}

variable "enable_monitoring" {
  default = "true"
  type    = bool
}
