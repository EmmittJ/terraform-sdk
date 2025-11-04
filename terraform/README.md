# Terraform Provider Configurations

This folder contains Terraform configurations for generating provider schemas used in code generation.

## Purpose

These configurations are used to:

1. Lock provider versions for consistent code generation
2. Generate provider schemas using `terraform providers schema -json`
3. Serve as the source of truth for which providers and versions to support

## Structure

```
terraform/
├── aws/          # AWS provider configuration
├── azurerm/      # Azure provider configuration
└── google/       # Google Cloud provider configuration
```

## Generating Schemas

To generate the schema for a provider:

```bash
# Navigate to the provider folder
cd terraform/aws

# Initialize Terraform (downloads provider)
terraform init

# Generate schema JSON
terraform providers schema -json > schema.json
```

## Provider Versions

Current provider versions:

- **AWS**: `~> 5.0` (hashicorp/aws)
- **Azure**: `~> 3.0` (hashicorp/azurerm)
- **Google Cloud**: `~> 5.0` (hashicorp/google)

## Notes

- Provider configurations include authentication skip flags since we only need schemas
- Schemas are not checked into source control (add `schema.json` to `.gitignore`)
- Update provider versions here when targeting new provider releases
- Run `terraform init -upgrade` to update to latest compatible version

## Usage in Code Generation

The code generator will:

1. Read these configurations to determine target providers
2. Run `terraform init` and `terraform providers schema -json` automatically
3. Parse the resulting schema to generate C# classes

See `PROVIDER_CODE_GENERATION.md` for the full code generation strategy.
