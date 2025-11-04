# Provider Code Generation Strategy

## Overview

This document outlines the strategy for generating strongly-typed C# provider classes for the EmmittJ.Terraform.Sdk library. The goal is to provide compile-time safety, IntelliSense support, and an improved developer experience when working with Terraform providers like AWS, Azure, and GCP.

## Background

Terraform providers expose resources and data sources through a schema. Each provider publishes its schema in JSON format, which describes:

- Resource types and their arguments
- Data source types and their arguments
- Attribute types and validation rules
- Required vs. optional fields
- Default values and computed attributes

## Provider Schema Format

Terraform provider schemas follow the terraform-plugin-sdk v2 format. Key components include:

### Schema Structure

```json
{
  "format_version": "1.0",
  "provider_schemas": {
    "registry.terraform.io/hashicorp/aws": {
      "provider": {
        /* provider configuration */
      },
      "resource_schemas": {
        "aws_instance": {
          "version": 0,
          "block": {
            "attributes": {
              /* resource arguments */
            },
            "block_types": {
              /* nested blocks */
            }
          }
        }
      },
      "data_source_schemas": {
        /* similar structure */
      }
    }
  }
}
```

### Attribute Types

- **Primitive**: `string`, `number`, `bool`
- **Collection**: `list(type)`, `set(type)`, `map(type)`
- **Complex**: `object({...})`, nested blocks

### Attribute Properties

- `type`: The data type
- `required`: Whether the attribute is required
- `optional`: Whether the attribute is optional
- `computed`: Whether Terraform computes the value
- `description`: Human-readable description
- `sensitive`: Whether the value is sensitive

## Code Generation Approach

### Phase 1: Schema Extraction

**Tool**: Use `terraform providers schema -json` command

Provider configurations are maintained in the `terraform/` folder:

```
terraform/
├── aws/          # AWS provider configuration
├── azurerm/      # Azure provider configuration
└── google/       # Google Cloud provider configuration
```

To generate schemas:

```bash
# Navigate to provider folder
cd terraform/aws

# Initialize Terraform (downloads provider)
terraform init

# Generate schema JSON
terraform providers schema -json > schema.json
```

This extracts the complete schema for all configured providers.

### Phase 2: Schema Parsing

Create a C# tool that:

1. Parses the provider schema JSON
2. Builds an in-memory model of resources, data sources, and their properties
3. Handles type mappings from Terraform types to C# types

**Type Mapping**:
| Terraform Type | C# Type |
|----------------|---------|
| `string` | `string` |
| `number` | `double` or `int` |
| `bool` | `bool` |
| `list(T)` | `List<T>` |
| `set(T)` | `HashSet<T>` |
| `map(T)` | `Dictionary<string, T>` |
| `object({...})` | Custom class |

### Phase 3: Code Generation

Generate C# classes using one of these approaches:

#### Option A: Source Generators (Recommended)

- Use C# Source Generators to generate code at compile time
- Read schema files embedded as additional files
- Pros: Compile-time generation, no pre-build step, IntelliSense support
- Cons: More complex to implement

#### Option B: T4 Templates

- Use T4 Text Templates to generate code
- Run as part of the build process
- Pros: Mature technology, good tooling
- Cons: Requires Visual Studio or msbuild, less flexible

#### Option C: Standalone Code Generator

- Create a standalone CLI tool that generates source files
- Run manually or as a pre-build step
- Pros: Simple, explicit, easy to debug
- Cons: Requires manual execution, generated files in source control

**Recommendation**: Start with Option C for simplicity, migrate to Option A for better developer experience.

### Phase 4: Generated Class Structure

#### Resource Example

```csharp
namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Provides an EC2 instance resource.
/// </summary>
public class AwsInstance : TerraformResource
{
    public AwsInstance(string name) : base("aws_instance", name)
    {
    }

    /// <summary>
    /// AMI to use for the instance.
    /// </summary>
    public string? Ami
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ami")?.Value;
        set => WithPropertyInternal("ami", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Instance type to use for the instance.
    /// </summary>
    public string? InstanceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_type")?.Value;
        set => WithPropertyInternal("instance_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// List of security group names to associate with.
    /// </summary>
    public List<string>? SecurityGroups
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("security_groups")?.Value;
        set => WithPropertyInternal("security_groups", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    // Output attributes
    public TerraformExpression Id => this["id"];
    public TerraformExpression PublicIp => this["public_ip"];
    public TerraformExpression PrivateIp => this["private_ip"];

    public AwsInstance()
    {
        // Declare output attributes
        DeclareOutput("id");
        DeclareOutput("public_ip");
        DeclareOutput("private_ip");
        DeclareOutput("arn");
        // ... more outputs
    }
}
```

#### Data Source Example

```csharp
namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Use this data source to get the ID of an Amazon Machine Image (AMI).
/// </summary>
public class AwsAmiDataSource : TerraformDataSource
{
    public AwsAmiDataSource(string name) : base("aws_ami", name)
    {
    }

    /// <summary>
    /// Whether to select the most recent AMI from the results.
    /// </summary>
    public bool? MostRecent
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("most_recent")?.Value;
        set => WithPropertyInternal("most_recent", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// List of AMI owners to limit search.
    /// </summary>
    public List<string>? Owners
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("owners")?.Value;
        set => WithPropertyInternal("owners", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    // Output attributes
    public TerraformExpression ImageId => this["image_id"];
    public TerraformExpression Architecture => this["architecture"];

    public AwsAmiDataSource()
    {
        DeclareOutput("image_id");
        DeclareOutput("architecture");
        DeclareOutput("creation_date");
        // ... more outputs
    }
}
```

## Implementation Plan

### Step 1: Create Schema Parser (1-2 days)

- Create `EmmittJ.Terraform.Sdk.CodeGen` project
- Implement JSON schema parser
- Build in-memory model of provider schema
- Handle type resolution and nested structures
- Read provider configurations from `terraform/` folder

### Step 2: Implement Code Generator (2-3 days)

- Create template engine (using Scriban or Liquid)
- Automate schema extraction (`terraform init` and `terraform providers schema -json`)
- Generate resource classes
- Generate data source classes
- Generate nested block classes
- Handle special cases (computed attributes, sensitive values)

### Step 3: Generate Core Providers (1-2 days)

- AWS: ~300 resources
- Azure (azurerm): ~900 resources
- GCP (google): ~200 resources

**Strategy**: Start with a subset of commonly used resources, expand incrementally.

### Step 4: Testing & Validation (2-3 days)

- Create integration tests
- Verify generated code compiles
- Test against Terraform CLI (`terraform validate`)
- Compare generated HCL with expected output

### Step 5: Documentation & Packaging (1-2 days)

- Generate XML documentation from schema descriptions
- Create NuGet packages per provider
- Write usage guides
- Create samples

## Provider Package Structure

```
EmmittJ.Terraform.Sdk.Providers.Aws/
  ├── Resources/
  │   ├── AwsInstance.cs
  │   ├── AwsVpc.cs
  │   └── ...
  ├── DataSources/
  │   ├── AwsAmiDataSource.cs
  │   ├── AwsVpcDataSource.cs
  │   └── ...
  └── AwsProvider.cs

EmmittJ.Terraform.Sdk.Providers.Azure/
  └── (similar structure)

EmmittJ.Terraform.Sdk.Providers.Google/
  └── (similar structure)
```

Each provider would be a separate NuGet package:

- `EmmittJ.Terraform.Sdk.Providers.Aws`
- `EmmittJ.Terraform.Sdk.Providers.Azure`
- `EmmittJ.Terraform.Sdk.Providers.Google`

## Challenges & Considerations

### 1. Schema Version Compatibility

**Challenge**: Provider schemas evolve with each release.
**Solution**:

- Version packages to match provider versions
- Support multiple provider versions simultaneously
- Document breaking changes

### 2. Large Codebase Size

**Challenge**: Providers like Azure have 900+ resources.
**Solution**:

- Split into multiple packages by service (e.g., `Aws.Compute`, `Aws.Networking`)
- Use source generators to avoid bloating compiled assemblies
- Generate on-demand or lazy-load types

### 3. Complex Nested Structures

**Challenge**: Some resources have deeply nested block structures.
**Solution**:

- Generate separate classes for nested blocks
- Use fluent API for builder pattern
- Provide both imperative and declarative styles

### 4. Computed Attributes

**Challenge**: Some attributes are computed by Terraform.
**Solution**:

- Make computed-only attributes read-only
- Expose as `TerraformExpression` for referencing
- Generate output declarations automatically

### 5. Dynamic Block Support

**Challenge**: Some resources benefit from dynamic blocks.
**Solution**:

- Generated classes can still use `DynamicBlocks` collection
- Provide typed wrapper methods for common patterns
- Document when to use typed vs. dynamic approaches

## Alternative Approaches

### Hybrid Approach

Instead of generating all resources upfront:

1. Generate a **base provider package** with common patterns
2. Provide a **fluent API** for defining resources dynamically
3. Generate **typed wrappers** only for most common resources

**Example**:

```csharp
// Fully typed (generated)
var instance = new AwsInstance("web")
{
    Ami = "ami-12345",
    InstanceType = "t2.micro"
};

// Dynamic (fallback for ungeneratedor new resources)
var instance = new TerraformResource("aws_instance", "web")
{
    ["ami"] = "ami-12345",
    ["instance_type"] = "t2.micro"
};
```

### Schema-First Development

Use provider schemas at runtime:

- Embed schemas in assemblies
- Validate at runtime using schema rules
- Provide dynamic API with schema-based IntelliSense

**Pros**: Always up-to-date, smaller codebase
**Cons**: No compile-time safety, runtime overhead

## Recommended Next Steps

1. **Prototype**: Create a simple code generator for 5-10 AWS resources
2. **Validate**: Ensure generated code works with existing SDK
3. **Iterate**: Refine based on usage patterns
4. **Scale**: Expand to full provider coverage
5. **Automate**: Set up CI/CD for schema updates

## Timeline Estimate

- **Week 1-2**: Schema parser and code generator
- **Week 3**: Generate AWS core resources (EC2, VPC, S3, IAM)
- **Week 4**: Testing and refinement
- **Week 5-6**: Expand to Azure and GCP
- **Week 7**: Documentation and samples
- **Week 8**: NuGet packaging and release

**Total**: ~2 months for initial release with 3 major providers

## Conclusion

Provider code generation will significantly enhance the developer experience with this SDK. By leveraging Terraform's provider schemas and generating strongly-typed C# classes, we can provide:

- Compile-time type safety
- IntelliSense support
- Reduced errors
- Better documentation
- Faster development

The recommended approach is to start with a standalone code generator, validate with a subset of resources, and then scale to full provider coverage. This strategy balances implementation complexity with developer experience benefits.
