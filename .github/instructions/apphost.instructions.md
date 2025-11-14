---
applyTo: "**/src/EmmittJ.Terraform.Sdk.AppHost/**"
---

# Code Generation / AppHost Development

## 🔨 Code Generation

Provider bindings are **auto-generated** from Terraform provider schemas using the AppHost project:

```powershell
# Generate provider code for all configured providers
aspire publish

# The AppHost project (EmmittJ.Terraform.Sdk.AppHost) orchestrates:
# 1. Downloading provider schemas from Terraform Registry
# 2. Parsing schema JSON
# 3. Generating C# resource/data source classes
# 4. Generating provider configuration classes
```

**Generated Code Locations**:

- `src/providers/EmmittJ.Terraform.Sdk.Providers.Aws/` - AWS resources
- `src/providers/EmmittJ.Terraform.Sdk.Providers.AzureRM/` - Azure resources
- `src/providers/EmmittJ.Terraform.Sdk.Providers.Google/` - GCP resources

**Important**: Do NOT manually edit generated provider code - it will be overwritten on next generation.

## Mustache Templates

Templates are in `Templates/Files/` directory:

- `TerraformBlock.mustache` - Generates nested block classes and resource/data source classes
- Template changes require running `aspire publish` to regenerate code

### Template Best Practices

- ✅ Generate `BlockType` overrides for all blocks: `public override string BlockType => "{{TerraformName}}";`
- ✅ Use `{{{PropertyWrapper}}}` (triple braces) to avoid HTML escaping generic types
- ✅ Handle `IsRequired`, `IsOptional`, `IsComputed` flags correctly
- ✅ Generate XML documentation from schema descriptions
- ✅ Add `[TerraformArgument("{{TerraformName}}")]` attributes
- ❌ Don't assume all properties are settable - computed attributes are read-only

## Extending Provider Support

To add a new provider:

1. Edit `src/EmmittJ.Terraform.Sdk.AppHost/AppHost.cs`
2. Add provider using `builder.AddTerraformProvider()`
3. Run `aspire publish` to generate bindings
4. Verify generated code compiles
