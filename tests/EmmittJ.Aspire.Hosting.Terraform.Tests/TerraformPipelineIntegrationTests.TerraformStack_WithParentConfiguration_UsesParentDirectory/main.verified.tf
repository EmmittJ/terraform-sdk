terraform {
  backend "local" {}
}

module "myapp" {
  source = "./parent-terraform"
}

