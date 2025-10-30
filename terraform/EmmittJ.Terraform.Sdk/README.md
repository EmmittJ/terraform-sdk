# Aspire.Hosting.Terraform.Core

**Next-generation Terraform configuration builder with improved type system**

This is a redesigned version of the Terraform configuration library, incorporating lessons learned from Azure.Provisioning's architecture. It provides a strongly-typed, expression-based API for building Terraform configurations in C#.

## ✨ New: Deferred Resolution / Token System

The SDK now includes a **two-pass resolution system** inspired by Terraform CDK and AWS CDK:

- ✅ **Circular reference handling**
- ✅ **Cross-stack references**
- ✅ **Late-bound values**
- ✅ **Lazy evaluation with caching**
- ✅ **Type-safe token system**
- ✅ **Automatic dependency tracking**

See [DEFERRED_RESOLUTION.md](DEFERRED_RESOLUTION.md) for comprehensive documentation and examples.

## Key Improvements Over Original Design

### 1. **Separate Value Container from Expression AST**

- **`TerraformValue<T>`**: Container for property values (similar to `BicepValue<T>`)

  - Tracks four states: Unset, Literal, Expression, Reference
  - Provides type safety and implicit conversions
  - Enables detection of unassigned properties
  - **NEW**: Implements `ITerraformResolvable` for two-pass resolution

- **`TerraformExpression`**: Pure syntax tree nodes
  - Compositional expression building
  - No knowledge of types/values
  - Easy to validate and transform
  - **NEW**: Implements `ITerraformResolvable` for deferred evaluation

### 2. **Polymorphic Reference System**

- **`ITerraformConstruct`** interface: All constructs implement `GetReferenceExpression()`
- **`TerraformReference`**: Semantic pointer to another construct
  - Tracks relationships for dependency analysis
  - Each construct knows how to reference itself (no switch statements!)
  - Follows the **Tell, Don't Ask** principle
  - **NEW**: Records dependencies during prepare phase

### 3. **Infrastructure-Style Container**

- **`TerraformConfiguration`**: Manages all constructs
  - Similar to Azure.Provisioning's `Infrastructure`
  - Centralizes validation and compilation
  - Provides clean API for building configurations
  - **NEW**: Two-pass resolution (Prepare → Resolve) in `ToHcl()`

## Quick Start

```csharp
using Aspire.Hosting.Terraform.Core;

// Create a configuration
var config = new TerraformConfiguration("main");

// Define a variable
var region = new TerraformVariable("aws_region")
{
    Description = "AWS region",
    Type = "string",
    Default = "us-east-1"
};
config.Add(region);

// Create a resource
var vpc = new TerraformResource("aws_vpc", "main");
vpc.SetFromReference("cidr_block", region.AsReference());
vpc.DeclareOutput("id");
vpc.DeclareOutput("cidr_block");
config.Add(vpc);

// Reference the VPC's outputs
var subnet = new TerraformResource("aws_subnet", "main");
subnet.SetFromReference("vpc_id", vpc["id"]); // Type-safe!
config.Add(subnet);

// Generate HCL
string hcl = config.ToHcl();
config.WriteToFile("main.tf");
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
- The main value container (`TerraformValue<T>`) and its states
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
│ TerraformConfiguration (Core/)                      │
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
│ TerraformValue<T> (Core/)                           │
│ ┌─────────────┬──────────────┬────────┬──────────┐ │
│ │ Unset       │ Literal      │ Expr   │ Ref      │ │
│ │ (not set)   │ (typed val)  │ (AST)  │ (link)   │ │
│ └─────────────┴──────────────┴────────┴──────────┘ │
│ Kind tracked by TerraformValueKind enum (Core/)    │
└─────────────────────────────────────────────────────┘
         │                  │              │
         │                  │              │
         ▼                  ▼              ▼
┌──────────────┐  ┌──────────────┐  ┌──────────────┐
│TerraformExpr │  │Literal<T>    │  │TerraformRef  │
│(Expressions/)│  │(value)       │  │(Core/)       │
│- Binary ops  │  │              │  │- Tracks deps │
│- Functions   │  │              │  │- Polymorphic │
│- Conditionals│  │              │  │              │
└──────────────┘  └──────────────┘  └──────────────┘
```

**Key Design Principles:**

1. **Separation of Concerns**: Values (Core/) are separate from expressions (Expressions/)
2. **Polymorphism**: Each construct knows how to reference itself via `ITerraformConstruct.GetReferenceExpression()`
3. **Type Safety**: `TerraformValue<T>` provides compile-time checking while supporting dynamic HCL generation
4. **Two-Pass Resolution**: `ITerraformResolvable` enables dependency tracking and late binding

## Design Patterns from Azure.Provisioning

### 1. **Value Container Pattern**

Each property can be in one of four states:

- **Unset**: Property not assigned (will use Terraform defaults/computed)
- **Literal**: Direct .NET value (e.g., `"10.0.0.0/16"`)
- **Expression**: Computed value (e.g., `cidrsubnet(...)`)
- **Reference**: Link to another construct (e.g., `var.region`)

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
TerraformExpression expr = Source.GetReferenceExpression();
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
vpc.DeclareOutput("id");

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
var config = new TerraformConfiguration();

var vpc = new TerraformResource("aws_vpc", "main");
vpc.Set<string>("cidr_block", "10.0.0.0/16");
vpc.DeclareOutput("id");

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

- [x] Core type system (`TerraformValue<T>`, `TerraformExpression`, `TerraformReference`)
- [x] `ITerraformConstruct` interface with polymorphic references
- [x] `ITerraformResolvable` two-pass resolution system
- [x] `TerraformConfiguration` container with Prepare → Resolve phases
- [x] `TerraformContext` resolution context

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

- [x] `TerraformValue<T>` with 4-state pattern (Unset, Literal, Expression, Reference)
- [x] `TerraformObject` for maps/objects
- [x] `TerraformBlock` for nested blocks
- [x] Implicit conversions and type safety

#### Error Handling

- [x] Custom exception hierarchy (`TerraformException`, `TerraformConfigurationException`, `TerraformValidationException`)
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
