terraform {
  required_providers {
    google = {
      source  = "hashicorp/google"
      version = "~> 5.0"
    }
  }
}

provider "google" {
  project = "schema-generation-project"
  region  = "us-central1"
  
  # Skip authentication for schema generation only
  credentials = "fake-credentials.json"
}
