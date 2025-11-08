terraform {
  backend "local" {}
}

module "myapp" {
  source = "./myapp"
}

