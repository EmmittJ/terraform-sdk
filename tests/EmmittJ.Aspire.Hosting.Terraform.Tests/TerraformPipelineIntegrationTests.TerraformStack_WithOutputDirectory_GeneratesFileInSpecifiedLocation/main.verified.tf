terraform {
  backend "local" {}
}

module "myapp" {
  source = "./custom-terraform"
}

