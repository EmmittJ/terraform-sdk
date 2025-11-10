# Aspire.Hosting.Terraform.Core

**Next-generation Terraform configuration builder with improved type system**

This is a redesigned version of the Terraform configuration library, incorporating lessons learned from Azure.Provisioning's architecture. It provides a strongly-typed, expression-based API for building Terraform configurations in C#.

## ✨ New: Polymorphic Property System

The SDK uses a **polymorphic property system** for type-safe, fluent configuration building:

- ✅ **No null reference exceptions** - each property class only has needed fields
- ✅ **Compile-time type safety** - polymorphic dispatch instead of runtime switching
- ✅ **Fluent builder pattern** - `WithProperty<T>()` methods for clean chaining
- ✅ **Implicit conversions** - ergonomic API with automatic type conversion
- ✅ **Automatic two-phase resolution** - dependency tracking and HCL generation
- ✅ **Type-safe dictionary** - `Dictionary<string, TerraformProperty>` instead of `object`

See [MIGRATION_GUIDE.md](MIGRATION_GUIDE.md) for migration from the old API and [TYPE_SYSTEM_REVIEW.md](TYPE_SYSTEM_REVIEW.md) for architecture details.

## ✨ Two-Pass Resolution System

The SDK includes a **two-pass resolution system** inspired by Terraform CDK and AWS CDK:

- ✅ **Circular reference handling**
- ✅ **Cross-stack references**
- ✅ **Late-bound values**
- ✅ **Lazy evaluation with caching**
- ✅ **Type-safe token system**
- ✅ **Automatic dependency tracking**

See [DEFERRED_RESOLUTION.md](DEFERRED_RESOLUTION.md) for comprehensive documentation and examples.

## Key Improvements Over Original Design

### 1. **Polymorphic Property System**

- **`TerraformProperty`**: Abstract base class for all property values

  - Implements `ITerraformResolvable<TerraformExpression>` for two-phase resolution
  - Sealed subclasses: `LiteralProperty<T>` and `ExpressionProperty`
  - No null fields - each class only has what it needs
  - Provides type safety via polymorphic dispatch (no runtime type checking)
  - Implicit conversions for ergonomic API

- **`TerraformExpression`**: Pure syntax tree nodes
  - Compositional expression building
  - No knowledge of types/values
  - Easy to validate and transform
  - Implements `ITerraformResolvable<string>` for HCL generation

### 2. **Polymorphic Reference System**

- **`ITerraformConstruct`** interface: All constructs implement `AsReference()`
- **`TerraformReference`**: Semantic pointer to another construct
  - Tracks relationships for dependency analysis
  - Each construct knows how to reference itself (no switch statements!)
  - Follows the **Tell, Don't Ask** principle
  - **NEW**: Records dependencies during prepare phase

### 3. **Infrastructure-Style Container**

- **`TerraformStack`**: Manages all constructs
  - Similar to Azure.Provisioning's `Infrastructure`
  - Centralizes validation and compilation
  - Provides clean API for building configurations
  - **NEW**: Two-pass resolution (Prepare → Resolve) in `ToHcl()`

## Quick Start

```csharp
using EmmittJ.Terraform.Sdk;

// Create a configuration
var config = new TerraformStack();

// Define a local value using fluent API
var locals = new TerraformLocal()
    .WithProperty("region", "us-east-1")
    .WithProperty("environment", "production")
    .WithProperty("common_tags", TerraformExpression.Object(new Dictionary<string, string>
    {
        ["Environment"] = "prod",
        ["ManagedBy"] = "Terraform"
    }));
config.Add(locals);

// Create resources with fluent builder pattern
var vpc = new TerraformResource("aws_vpc", "main")
    .WithProperty("cidr_block", "10.0.0.0/16")
    .WithProperty("enable_dns_hostnames", true)
    .WithReference("tags", locals);  // Reference to local values
config.Add(vpc);

// Reference the VPC in a subnet - type-safe!
var subnet = new TerraformResource("aws_subnet", "public")
    .WithReference("vpc_id", vpc)  // Automatic reference creation
    .WithProperty("cidr_block", "10.0.1.0/24")
    .WithProperty("availability_zone", "us-west-2a")
    .WithProperty("map_public_ip_on_launch", true);
config.Add(subnet);

// Generate HCL
string hcl = config.ToHcl();
config.WriteToFile("main.tf");
```

## Phase 2 Features: Backend, Settings, and Lifecycle

The SDK now includes comprehensive support for Terraform's configuration blocks and meta-arguments:

### Backend Configuration

```csharp
// Configure S3 backend
var config = new TerraformStack()
{
    Backend = new TerraformBackend { Type = "s3" }
};
config.Backend.Config["bucket"] = "my-terraform-state";
config.Backend.Config["key"] = "prod/terraform.tfstate";
config.Backend.Config["region"] = "us-east-1";
config.Backend.Config["encrypt"] = true;

// Configure Azure backend
var config = new TerraformStack()
{
    Backend = new TerraformBackend { Type = "azurerm" }
};
config.Backend.Config["storage_account_name"] = "mystorageaccount";
config.Backend.Config["container_name"] = "tfstate";
config.Backend.Config["key"] = "prod.terraform.tfstate";
```

### Terraform Settings

```csharp
// Configure Terraform version and providers
var config = new TerraformStack()
{
    Settings = new TerraformSettings
    {
        RequiredVersion = ">= 1.0"
    }
};

// Add provider requirements
config.Settings.RequiredProviders["aws"] = new ProviderRequirement
{
    Source = "hashicorp/aws",
    Version = "~> 5.0"
};

config.Settings.RequiredProviders["azurerm"] = new ProviderRequirement
{
    Source = "hashicorp/azurerm",
    Version = ">= 3.0"
};

// Enable experimental features
config.Settings.Experiments.Add("module_variable_optional_attrs");
```

### Lifecycle Meta-Arguments

```csharp
// Create before destroy for zero-downtime replacement
var instance = new TerraformResource("aws_instance", "web")
{
    Lifecycle = new LifecycleConfig
    {
        CreateBeforeDestroy = true
    }
};
instance.Set("ami", "ami-12345678")
    .Set("instance_type", "t2.micro");

// Prevent accidental deletion
var database = new TerraformResource("aws_db_instance", "prod")
{
    Lifecycle = new LifecycleConfig
    {
        PreventDestroy = true
    }
};

// Ignore changes to specific attributes
var resource = new TerraformResource("aws_instance", "app")
{
    Lifecycle = new LifecycleConfig()
};
resource.Lifecycle.IgnoreChanges.Add("tags");
resource.Lifecycle.IgnoreChanges.Add("user_data");

// Ignore all changes
var managed_elsewhere = new TerraformResource("aws_s3_bucket", "external")
{
    Lifecycle = new LifecycleConfig()
};
managed_elsewhere.Lifecycle.IgnoreChanges.Add("all");

// Preconditions and postconditions
var instance = new TerraformResource("aws_instance", "validated")
{
    Lifecycle = new LifecycleConfig()
};

instance.Lifecycle.Preconditions.Add(new LifecycleCheck
{
    Condition = new TerraformExpression("can(regex(\"^ami-\", self.ami))"),
    ErrorMessage = "AMI ID must start with 'ami-'"
});

instance.Lifecycle.Postconditions.Add(new LifecycleCheck
{
    Condition = new TerraformExpression("self.public_ip != \"\""),
    ErrorMessage = "Instance must have a public IP"
});
```

### Complete Configuration Example

```csharp
// Build a complete Terraform configuration
var config = new TerraformStack()
{
    Settings = new TerraformSettings { RequiredVersion = ">= 1.0" },
    Backend = new TerraformBackend { Type = "s3" }
};

// Configure settings
config.Settings.RequiredProviders["aws"] = new ProviderRequirement
{
    Source = "hashicorp/aws",
    Version = "~> 5.0"
};

// Configure backend
config.Backend.Config["bucket"] = "my-state-bucket";
config.Backend.Config["key"] = "prod/terraform.tfstate";
config.Backend.Config["region"] = "us-east-1";

// Add provider
var provider = new TerraformProvider("aws");
provider.Set("region", "us-west-2");
config.Add(provider);

// Add resource with lifecycle
var instance = new TerraformResource("aws_instance", "web")
{
    Lifecycle = new LifecycleConfig
    {
        CreateBeforeDestroy = true,
        PreventDestroy = false
    }
};
instance.Lifecycle.IgnoreChanges.Add("tags");
instance.Set("ami", "ami-12345678")
    .Set("instance_type", "t2.micro");
config.Add(instance);

// Generate HCL with terraform {} block, backend, and lifecycle
string hcl = config.ToHcl();
```

Generated HCL:

```hcl
terraform {
  required_version = ">= 1.0"

  required_providers {
    aws = {
      source = "hashicorp/aws"
      version = "~> 5.0"
    }
  }

  backend "s3" {
    bucket = "my-state-bucket"
    key = "prod/terraform.tfstate"
    region = "us-east-1"
  }
}

provider "aws" {
  region = "us-west-2"
}

resource "aws_instance" "web" {
  lifecycle {
    create_before_destroy = true
    prevent_destroy = false
    ignore_changes = [tags]
  }
  ami = "ami-12345678"
  instance_type = "t2.micro"
}
```

## Project Structure

The SDK is organized into logical folders for maintainability and clarity:

```
EmmittJ.Terraform.Sdk/
├── Core/                           # Core type system and configuration
├── Constructs/                     # Terraform construct implementations
├── Expressions/                    # Expression AST and complex types
├── Validation/                     # Validation system (Phase 1 - In Progress)
├── Exceptions/                     # Custom exception types
└── Tf.cs                           # Helper functions and type constraints
```

### Design Rationale

**Core/** contains the fundamental type system:

- Interfaces that define contracts (`ITerraformConstruct`, `ITerraformResolvable`, etc.)
- The polymorphic property system (`TerraformProperty`, `LiteralProperty<T>`, `ExpressionProperty`)
- References between constructs (`TerraformReference`)
- Configuration container and resolution context

**Constructs/** contains all Terraform block types:

- Variables, Resources, Data Sources, Providers, Locals, Outputs
- Base classes with shared functionality
- Extension methods for fluent APIs

**Expressions/** contains the expression AST and complex value types:

- Expression nodes (binary operations, function calls, conditionals, etc.)
- Complex types like objects and blocks that combine values and structure

**Validation/** will contain the validation system (Phase 1):

- Validation results and error reporting
- Future: Dependency graph, circular reference detection

**Exceptions/** contains custom exception hierarchy:

- Rich error context with construct information
- Separate types for validation vs configuration errors

## Type System Architecture

```
┌─────────────────────────────────────────────────────┐
│ TerraformStack (Core/)                      │
│ - Container for all constructs                     │
│ - Two-pass resolution (Prepare → Resolve)          │
│ - Validates and compiles to HCL                    │
└─────────────────────────────────────────────────────┘
                    │
                    │ contains
                    ▼
┌─────────────────────────────────────────────────────┐
│ ITerraformConstruct (Core/)                         │
│ - TerraformVariable (Constructs/)                   │
│ - TerraformResource (Constructs/)                   │
│ - TerraformDataSource (Constructs/)                 │
│ - TerraformProvider (Constructs/)                   │
│ - TerraformLocal (Constructs/)                      │
│ - TerraformOutput (Constructs/)                     │
└─────────────────────────────────────────────────────┘
                    │
                    │ has properties
                    ▼
┌─────────────────────────────────────────────────────┐
│ TerraformProperty (Core/) - Polymorphic             │
│ ┌────────────────────────┬─────────────────────┐   │
│ │ LiteralProperty<T>     │ ExpressionProperty  │   │
│ │ (sealed)               │ (sealed)            │   │
│ │ - T _value             │ - TerraformExpr     │   │
│ │ - No null fields       │ - No null fields    │   │
│ └────────────────────────┴─────────────────────┘   │
│ Storage: Dictionary<string, TerraformProperty>     │
└─────────────────────────────────────────────────────┘
         │                              │
         │ Resolve()                    │ Resolve()
         ▼                              ▼
┌──────────────┐              ┌──────────────┐
│LiteralExpr<T>│              │TerraformExpr │
│(Expressions/)│              │(Expressions/)│
│- Creates HCL │              │- Binary ops  │
│- Escaping    │              │- Functions   │
│- Type format │              │- Conditionals│
└──────────────┘              └──────────────┘
```

**Key Design Principles:**

1. **Separation of Concerns**: Properties (Core/) are separate from expressions (Expressions/)
2. **Polymorphism**: Each construct knows how to reference itself via `ITerraformConstruct.AsReference()`
3. **Type Safety**: Polymorphic `TerraformProperty` provides compile-time checking and eliminates null fields
4. **Two-Pass Resolution**: `ITerraformResolvable` enables dependency tracking and late binding
5. **Sealed Classes**: Enable JIT devirtualization for better performance

## Design Patterns from Azure.Provisioning

### 1. **Polymorphic Property Pattern**

Properties use inheritance instead of discriminated unions:

- **`LiteralProperty<T>`**: Wraps a .NET value (e.g., `"10.0.0.0/16"`, `true`, `42`)
  - Only has `T _value` field - no null references
  - Resolve() creates `LiteralExpression<T>` on demand
- **`ExpressionProperty`**: Wraps a `TerraformExpression` (computed values, references)
  - Only has `TerraformExpression _expression` field - no null references
  - Resolve() delegates to wrapped expression

Benefits:

- ✅ No null fields (each class has only what it needs)
- ✅ Compile-time dispatch (sealed classes enable devirtualization)
- ✅ Type-safe storage (`Dictionary<string, TerraformProperty>`)
- ✅ Automatic traversal (polymorphic `Prepare()` and `Resolve()`)
- ✅ Ergonomic API (implicit conversions maintained)

### 2. **Polymorphic Self-Reference**

Instead of switch statements on construct types:

```csharp
// OLD: Switch-based (fragile, not extensible)
return Source switch {
    TerraformVariable v => $"var.{v.Name}",
    TerraformResource r => $"{r.Type}.{r.Name}",
    ...
};

// NEW: Polymorphic (extensible, maintainable)
TerraformExpression expr = Source.AsReference();
```

Benefits:

- ✅ Open for extension (add new types without modifying existing code)
- ✅ Encapsulation (each type owns its logic)
- ✅ Compile-time safety
- ✅ User-extensible

### 3. **Dependency Tracking**

References are semantic, not just strings:

```csharp
var vpc = new TerraformResource("aws_vpc", "main");
vpc.WithOutput("id");

var subnet = new TerraformResource("aws_subnet", "main");
subnet.SetFromReference("vpc_id", vpc["id"]);

// The reference tracks:
// - Source: vpc resource
// - Property: "id"
// - Can validate: is "id" actually an output?
// - Can build dependency graph automatically
```

## Comparison with Original API

### Original (String-Based)

```csharp
var doc = new TerraformDocument("main.tf");

var vpc = new TerraformResourceBlock("aws_vpc", "main")
    .WithArgument("cidr_block", "10.0.0.0/16")
    .WithOutput("id");

var subnet = new TerraformResourceBlock("aws_subnet", "main")
    .WithArgument("vpc_id", vpc["id"]);

doc.Add(vpc);
doc.Add(subnet);
string hcl = doc.ToHcl();
```

**Issues:**

- No type safety
- No distinction between literal/expression/reference
- Runtime validation only
- Manual output declaration required before reference

### New (Typed)

```csharp
var config = new TerraformStack();

var vpc = new TerraformResource("aws_vpc", "main");
vpc.Set<string>("cidr_block", "10.0.0.0/16");
vpc.WithOutput("id");

var subnet = new TerraformResource("aws_subnet", "main");
subnet.SetFromReference("vpc_id", vpc["id"]); // Validates output exists!

config.Add(vpc);
config.Add(subnet);
string hcl = config.ToHcl();
```

**Benefits:**

- Type-safe property values
- Clear separation of concerns
- Runtime validation with helpful errors
- Semantic reference tracking

## Current Status

### ✅ Implemented

#### Core System

- [x] Polymorphic property system (`TerraformProperty`, `LiteralProperty<T>`, `ExpressionProperty`)
- [x] `ITerraformConstruct` interface with polymorphic references
- [x] `ITerraformResolvable<T>` two-pass resolution system
- [x] `TerraformStack` container with Prepare → Resolve phases
- [x] `TerraformContext` resolution context
- [x] Type-safe property storage (`Dictionary<string, TerraformProperty>`)

#### Constructs (All Implemented!)

- [x] `TerraformVariable` - Input variables
- [x] `TerraformResource` - Resources with meta-arguments
- [x] `TerraformDataSource` - Data sources
- [x] `TerraformProvider` - Provider configurations
- [x] `TerraformLocal` - Local values
- [x] `TerraformOutput` - Output values

#### Expression System

- [x] Expression AST (Identifier, Literal, MemberAccess, FunctionCall)
- [x] Binary operators (Add, Subtract, Multiply, Divide, Modulo, etc.)
- [x] Conditional (ternary) expressions
- [x] For expressions
- [x] Function calls

#### Values & Types

- [x] Polymorphic `TerraformProperty` base class with sealed subclasses
- [x] `LiteralProperty<T>` for .NET values (no null fields)
- [x] `ExpressionProperty` for computed values and references (no null fields)
- [x] `TerraformMapExpression` for maps
- [x] `TerraformBlockExpression` for nested blocks (no `=` operator)
- [x] Implicit conversions and type safety
- [x] Fluent builder API with generic extension methods

#### Error Handling

- [x] Custom exception hierarchy (`TerraformException`, `TerraformStackException`, `TerraformValidationException`)
- [x] `ValidationResult` and `ValidationError` types

#### Infrastructure

- [x] HCL generation with proper indentation
- [x] File writing support
- [x] 125 passing unit tests with snapshot verification

### 🚧 In Progress (Phase 1 - Foundation)

- [ ] **Validation System** - Required property validation, reference validation, circular dependency detection
- [ ] **Dependency Graph** - Explicit graph building with topological sorting and cycle detection
- [ ] **Module Support** - `TerraformModule` construct for reusable configurations

### 📋 Planned (Phase 2+)

#### Production Features

- [ ] Backend configuration support
- [ ] Terraform settings block (required_version, required_providers)
- [ ] Lifecycle meta-arguments (create_before_destroy, prevent_destroy, ignore_changes)
- [ ] Integration tests with `terraform validate`

#### Expression Enhancements

- [ ] Splat expressions (`resource.*.id`)
- [ ] Dynamic blocks
- [ ] Complex string templates
- [ ] Try/catch expressions

#### Developer Experience

- [ ] Comprehensive user guide
- [ ] Sample project gallery
- [ ] Property-based testing
- [ ] Better error messages with suggestions

#### Long-term

- [ ] Provider-specific type safety via source generators
- [ ] Fluent validation integration
- [ ] Performance optimization

See [IMPROVEMENT_AREAS.md](../IMPROVEMENT_AREAS.md) for the complete roadmap.

## Testing

Run the tests to see the new system in action:

```bash
dotnet test Aspire.Hosting.Terraform.Core.Tests
```

Compare with the original implementation:

```bash
dotnet test Aspire.Hosting.Terraform.Tests
```

## Migration Path

The new Core library can coexist with the original implementation:

1. **Phase 1** (Now): Develop Core library in parallel
2. **Phase 2**: Port examples and tests to use Core
3. **Phase 3**: Compare HCL output for equivalence
4. **Phase 4**: Add features not possible in original (validation, dependency tracking)
5. **Phase 5**: Decide whether to replace or maintain both

## References

- [Type System Analysis](../TYPE_SYSTEM_ANALYSIS.md) - Deep dive into design decisions
- [API Comparison](../API_COMPARISON.md) - Comparison with Azure.Provisioning
- [Azure.Provisioning](https://github.com/Azure/azure-sdk-for-net/tree/main/sdk/provisioning) - Inspiration for this design

## Contributing

This is an experimental redesign. Feedback welcome on:

- API ergonomics
- Missing features
- Edge cases not handled
- Performance considerations
