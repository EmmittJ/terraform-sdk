# Aspire.Hosting.Terraform.Core

**Next-generation Terraform configuration builder with improved type system**

This is a redesigned version of the Terraform configuration library, incorporating lessons learned from Azure.Provisioning's architecture. It provides a strongly-typed, expression-based API for building Terraform configurations in C#.

## Key Improvements Over Original Design

### 1. **Separate Value Container from Expression AST**
- **`TerraformValue<T>`**: Container for property values (similar to `BicepValue<T>`)
  - Tracks four states: Unset, Literal, Expression, Reference
  - Provides type safety and implicit conversions
  - Enables detection of unassigned properties

- **`TerraformExpression`**: Pure syntax tree nodes
  - Compositional expression building
  - No knowledge of types/values
  - Easy to validate and transform

### 2. **Polymorphic Reference System**
- **`ITerraformConstruct`** interface: All constructs implement `GetReferenceExpression()`
- **`TerraformReference`**: Semantic pointer to another construct
  - Tracks relationships for dependency analysis
  - Each construct knows how to reference itself (no switch statements!)
  - Follows the **Tell, Don't Ask** principle

### 3. **Infrastructure-Style Container**
- **`TerraformConfiguration`**: Manages all constructs
  - Similar to Azure.Provisioning's `Infrastructure`
  - Centralizes validation and compilation
  - Provides clean API for building configurations

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

## Type System Architecture

```
┌─────────────────────────────────────────────────────┐
│ TerraformConfiguration                              │
│ - Container for all constructs                     │
│ - Validates and compiles to HCL                    │
└─────────────────────────────────────────────────────┘
                    │
                    │ contains
                    ▼
┌─────────────────────────────────────────────────────┐
│ ITerraformConstruct                                 │
│ - TerraformVariable                                 │
│ - TerraformResource                                 │
│ - TerraformDataSource (TODO)                       │
│ - TerraformProvider (TODO)                         │
└─────────────────────────────────────────────────────┘
                    │
                    │ has properties
                    ▼
┌─────────────────────────────────────────────────────┐
│ TerraformValue<T>                                   │
│ ┌─────────────┬──────────────┬────────┬──────────┐ │
│ │ Unset       │ Literal      │ Expr   │ Ref      │ │
│ │ (not set)   │ (typed val)  │ (AST)  │ (link)   │ │
│ └─────────────┴──────────────┴────────┴──────────┘ │
└─────────────────────────────────────────────────────┘
         │                  │              │
         │                  │              │
         ▼                  ▼              ▼
┌──────────────┐  ┌──────────────┐  ┌──────────────┐
│TerraformExpr │  │Literal<T>    │  │TerraformRef  │
│(AST nodes)   │  │(value)       │  │(construct)   │
└──────────────┘  └──────────────┘  └──────────────┘
```

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
- [x] Core type system (`TerraformValue<T>`, `TerraformExpression`, `TerraformReference`)
- [x] `ITerraformConstruct` interface with polymorphic references
- [x] `TerraformVariable` construct
- [x] `TerraformResource` construct with meta-arguments
- [x] `TerraformConfiguration` container
- [x] Expression AST (Identifier, Literal, MemberAccess, FunctionCall, Binary operators)
- [x] Basic HCL generation
- [x] Quick start example

### 🚧 TODO
- [ ] `TerraformDataSource` construct
- [ ] `TerraformProvider` construct
- [ ] `TerraformOutput` construct
- [ ] `TerraformLocal` construct
- [ ] Validation system (required properties, circular dependencies)
- [ ] Dependency graph building
- [ ] More expression types (conditionals, for expressions, etc.)
- [ ] Helper functions library (Tf.CidrSubnet, Tf.Format, etc.)
- [ ] Provider-specific strongly-typed resources (future)

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
