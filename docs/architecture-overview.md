# Architecture Overview

The EmmittJ Terraform SDK implements a **layered architecture** that transforms strongly-typed C# code into valid Terraform HCL configurations. This document provides a high-level overview of how the major systems work together.

## Three-Layer Architecture

The SDK is organized into three primary layers, each with distinct responsibilities:

```
┌─────────────────────────────────────────┐
│         VALUES LAYER                    │
│  TerraformValue<T>, TerraformList<T>   │
│  Polymorphic, type-safe value storage  │
└─────────────────┬───────────────────────┘
                  │ Resolves to
                  ↓
┌─────────────────────────────────────────┐
│      EXPRESSIONS LAYER                  │
│  TerraformExpression, Literal, List    │
│  Compositional HCL syntax builders     │
└─────────────────┬───────────────────────┘
                  │ Rendered as
                  ↓
┌─────────────────────────────────────────┐
│        SYNTAX LAYER                     │
│  TerraformSyntaxNode, ArgumentNode     │
│  Direct HCL output representation      │
└─────────────────────────────────────────┘
```

### Layer 1: Values

**Purpose:** Type-safe value storage and management

**Key Types:** `TerraformValue<T>`, `TerraformList<T>`, `TerraformMap<T>`, `TerraformReference<T>`

**Responsibilities:**

- Provide compile-time type safety
- Enable implicit conversions from literals
- Support lazy evaluation
- Track references between resources
- Eliminate null reference exceptions via polymorphic design

**Example:**

```csharp
// Type-safe value that can be literal, reference, or expression
TerraformValue<string> region = "us-west-2";
TerraformValue<string> vpcId = vpc["id"];
TerraformValue<int> count = 3;
```

### Layer 2: Expressions

**Purpose:** Compositional HCL syntax construction

**Key Types:** `TerraformExpression`, `LiteralExpression`, `ListExpression`, `ConditionalExpression`

**Responsibilities:**

- Represent HCL syntax constructs
- Enable composition of complex expressions
- Provide type-agnostic value representation
- Support operator overloading for natural syntax
- Enable future optimizations (constant folding, etc.)

**Example:**

```csharp
// Build complex expressions compositionally
var name = TerraformExpression.Conditional(
    isProd,
    TerraformExpression.Interpolate("prod-", baseName),
    TerraformExpression.Interpolate("dev-", baseName)
);
```

### Layer 3: Syntax

**Purpose:** Direct HCL output generation

**Key Types:** `TerraformSyntaxNode`, `TerraformArgumentNode`, `TerraformBlockNode`, `TerraformTopLevelBlockNode`

**Responsibilities:**

- Represent final HCL structure
- Handle indentation and formatting
- Order nodes for readability
- Generate HCL string output

**Example:**

```csharp
// Syntax nodes render directly to HCL
var arg = new TerraformArgumentNode("region", TerraformExpression.Literal("us-west-2"));
// Renders: region = "us-west-2"
```

## Resolution System

The SDK uses a single-pass resolution approach:

```
┌──────────────────┐
│   User Code      │
│   (C# API)       │
└────────┬─────────┘
         │
         ↓
┌──────────────────┐
│  RESOLVE         │
│  • Gen nodes     │
│  • Build AST     │
│  • Order refs    │
└────────┬─────────┘
         │
         ↓
┌──────────────────┐
│  RENDER          │
│  • Gen HCL       │
│  • Format        │
│  • Indent        │
└────────┬─────────┘
         │
         ↓
    HCL Output
```

### Resolve Phase

**When:** `stack.ToHcl()`

**Purpose:** Generate syntax node tree

**Activities:**

- Call `ResolveNodes(context)` on all blocks
- Generate `TerraformSyntaxNode` tree
- Order nodes for readability (meta-arguments first, etc.)

**Example:**

```csharp
var nodes = vpc.ResolveNodes(context);
// Returns:
// - TerraformArgumentNode("cidr_block", ...)
// - TerraformBlockNode("tags", ...)
```

### Render Phase

**When:** Automatic during `ToHcl()`

**Purpose:** Generate final HCL string

**Activities:**

- Call `ToHcl(context)` on each syntax node
- Apply indentation via context
- Format according to Terraform conventions
- Concatenate into final output

**Example:**

```csharp
var hcl = node.ToHcl(context);
// resource "aws_vpc" "main" {
//   cidr_block = "10.0.0.0/16"
// }
```

## Core Interfaces

### ITerraformResolvable

The foundation of the resolution system:

```csharp
public interface ITerraformResolvable
{
    IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context);
}
```

**Implemented by:**

- `TerraformValue<T>` - resolves to expression nodes
- `TerraformExpression` - resolves to self (is already a syntax node)
- `TerraformBlock` - resolves to argument and block nodes
- `TerraformStack` - resolves to top-level block nodes

### ITerraformContext

Provides resolution environment:

```csharp
public interface ITerraformContext
{
    TerraformStack Scope { get; }                  // Current stack
    int IndentLevel { get; }                       // Current indentation
    string Indent { get; }                         // Indentation string
    ITerraformNodeFormatter Formatter { get; }     // Node sorting
    IDisposable PushIndent();                      // Increase indentation
    IDisposable SetCurrentBlock(TerraformBlock? block); // Set context block
}
```

## Data Flow

### From User Code to HCL

Complete flow through the system:

```csharp
// 1. User creates resources with typed values
var vpc = new TerraformResource("aws_vpc", "main")
{
    ["cidr_block"] = "10.0.0.0/16"  // TerraformValue<string>
};

var subnet = new TerraformResource("aws_subnet", "public")
{
    ["vpc_id"] = vpc["id"]  // TerraformReference<string>
};

// 2. Add to stack
stack.Add(vpc);
stack.Add(subnet);

// 3. Generate HCL (triggers resolve → render)
var hcl = stack.ToHcl();

// Internal flow:
// - Resolve: Generate syntax nodes for each resource
// - Render: Format nodes as HCL with proper indentation
// Note: Terraform itself handles dependency ordering
```

### Resolution Chain

```
TerraformValue<string>("us-west-2")
    ↓ implements ITerraformResolvable
    ↓ wraps TerraformLiteralValue<string>
    ↓ ResolveNodes(context)
    ↓
LiteralExpression("us-west-2")
    ↓ extends TerraformExpression
    ↓ extends TerraformSyntaxNode
    ↓ ToHcl(context)
    ↓
"\"us-west-2\""
```

### Reference Chain

```
vpc["id"]
    ↓ indexer returns
TerraformReference<string>(vpc, "id")
    ↓ implements ITerraformResolvable
    ↓ wraps TerraformReferenceResolvable
    ↓ ResolveNodes(context)
    ↓ calls vpc.AsReference()
    ↓
TerraformExpression.Identifier("aws_vpc.main.id")
    ↓ ToHcl(context)
    ↓
"aws_vpc.main.id"
```

## Block Hierarchy

Blocks form the structural backbone:

```
TerraformBlock (abstract base)
    ├── Property storage via TerraformMap<object>
    ├── SetArgument/GetArgument for source generators
    └── AsReference() for dependency tracking

TerraformResource : TerraformBlock, ITerraformTopLevelBlock
    ├── Resource type (e.g., "aws_vpc")
    ├── Resource name (e.g., "main")
    ├── Meta-arguments (count, for_each, depends_on)
    └── Properties stored in base TerraformMap

TerraformDataSource : TerraformBlock, ITerraformTopLevelBlock
    └── Similar to resource but for data sources

TerraformModule : TerraformBlock, ITerraformTopLevelBlock
    └── Module configurations

TerraformProvider : TerraformBlock, ITerraformTopLevelBlock
    └── Provider configurations
```

## Source Generation

The SDK uses Roslyn source generators for meta-arguments and properties:

### Meta-Arguments Generator

```csharp
// Generates implementations of meta-argument interfaces
public interface ITerraformHasCount
{
    TerraformValue<int>? Count { get; set; }
}

// Source generator produces:
partial class TerraformResource : ITerraformHasCount
{
    public TerraformValue<int>? Count { get; set; }
}
```

### Property Generator

```csharp
// Generates property accessors for provider-specific resources
public partial class AwsVpc : TerraformResource
{
    [TerraformArgument("cidr_block")]
    public TerraformValue<string>? CidrBlock
    {
        get => GetArgument<TerraformValue<string>>("cidr_block");
        set => SetArgument("cidr_block", value);
    }
}
```

## Provider Code Generation

Providers are auto-generated from Terraform schemas:

### Generation Pipeline

```
Terraform Registry
    ↓ Download schema
Provider Schema JSON
    ↓ Parse
Schema Model
    ↓ Generate C#
Provider Classes
    ├── Resources (aws_vpc, aws_subnet, ...)
    ├── Data Sources (aws_ami, aws_availability_zones, ...)
    └── Provider Config (AwsProvider)
```

### AppHost Orchestration

Uses Aspire to coordinate generation:

```csharp
var builder = DistributedApplication.CreateBuilder(args);

builder.AddTerraformProvider("aws", "hashicorp/aws", "5.0.0")
    .WithOutputPath("../providers/EmmittJ.Terraform.Sdk.Providers.Aws");

// Generates:
// - AwsProvider.cs
// - Resources/AwsVpc.cs
// - Resources/AwsSubnet.cs
// - DataSources/AwsAmi.cs
// - etc.
```

## Extension Points

### Custom Block Types

```csharp
public class CustomBlock : TerraformBlock
{
    public CustomBlock() : base("custom") { }

    public override TerraformExpression AsReference()
    {
        return TerraformExpression.Identifier($"custom.{ResourceName}");
    }
}
```

### Custom Expression Types

```csharp
public class CustomExpression : TerraformExpression
{
    public override string ToHcl(ITerraformContext context)
    {
        // Custom HCL generation logic
        return "custom_function(...)";
    }
}
```

### Custom Value Types

```csharp
public class CustomValue<T> : TerraformValue<T>
{
    public CustomValue(Func<ITerraformContext, TerraformExpression> resolver)
        : base(new CustomResolvable<T>(resolver))
    {
    }
}
```

## Error Handling

### Validation Errors

```csharp
public class ValidationResult
{
    public bool IsValid { get; }
    public IReadOnlyList<ValidationError> Errors { get; }
}

// Example usage:
var result = TerraformValidator.Validate(stack);
if (!result.IsValid)
{
    foreach (var error in result.Errors)
    {
        Console.WriteLine($"{error.Severity}: {error.Message}");
    }
}
```

### Exception Hierarchy

```csharp
TerraformException (base)
    ├── TerraformValidationException (validation failures)
    └── TerraformStackException (stack-level errors)
```

## Performance Characteristics

### Memory Efficiency

- **Immutable structures** - safe sharing and caching
- **Lazy evaluation** - defer computation until needed
- **String interning** - reuse common identifiers
- **Singleton patterns** - empty lines, common nodes

### Execution Efficiency

- **Single-pass rendering** - no repeated traversals
- **Cached indentation** - string reuse per level
- **Topological sort** - efficient dependency ordering
- **Parallel preparation** - potential future optimization

## Design Principles

### 1. Type Safety

Use compile-time types to prevent errors:

```csharp
// ✅ Compiler enforces type safety
TerraformValue<string> region = "us-west-2";
TerraformValue<int> count = 3;

// ❌ Compiler prevents mismatches
// TerraformValue<string> count = 3;  // Error!
```

### 2. Immutability

Objects don't change after creation:

```csharp
// ✅ Create new instances for changes
var expr1 = TerraformExpression.Literal("value");
var expr2 = TerraformExpression.Interpolate("prefix-", expr1);

// ❌ No mutation of existing objects
// expr1.Value = "new value";  // Not possible
```

### 3. Polymorphic Dispatch

Avoid runtime type checking:

```csharp
// ✅ Polymorphic - each type knows how to resolve itself
return value.ResolveNodes(context);

// ❌ Avoid runtime switching
// if (value is Literal) ... else if (value is Reference) ...
```

### 4. Composition

Build complex structures from simple pieces:

```csharp
// ✅ Compositional
var name = TerraformExpression.Interpolate(
    prefix,
    "-",
    TerraformExpression.Conditional(isProd, "prod", "dev")
);

// ❌ Monolithic
// var name = new ComplexNameExpression(prefix, isProd);
```

### 5. Separation of Concerns

Each layer has one responsibility:

- **Values** - Type safety and storage
- **Expressions** - Syntax composition
- **Syntax** - HCL rendering
- **Blocks** - Structure and properties
- **Context** - Resolution environment

## Future Enhancements

### Planned Features

- **Expression optimization** - Constant folding, dead code elimination
- **Incremental generation** - Only regenerate changed parts
- **HCL parsing** - Import existing configurations
- **Enhanced validation** - Static analysis, linting
- **Performance profiling** - Identify bottlenecks
- **Caching layer** - Memoize expensive operations

### Research Areas

- **Parallel resolution** - Concurrent block processing
- **Streaming generation** - Large config support
- **Graph visualization** - Dependency diagrams
- **IDE integration** - Better debugging experience
- **Schema validation** - Runtime schema checking

## Best Practices Summary

### ✅ Do

- Trust the type system
- Use implicit conversions
- Let polymorphism handle dispatch
- Build expressions compositionally
- Use the resolution pattern for HCL generation

### ❌ Don't

- Don't bypass type safety
- Don't manually construct HCL strings
- Don't mutate objects after creation
- Don't perform runtime type checking
- Don't disable nullable reference types

## Learning Path

Recommended order for understanding the SDK:

1. **Values System** - Start with type-safe value storage
2. **Expressions System** - Learn compositional syntax building
3. **Syntax System** - Understand HCL rendering
4. **Resolution System** - See how values resolve to HCL
5. **Blocks System** - Work with resources and modules
6. **Source Generation** - Understand code generation
7. **Provider Generation** - Learn schema-to-C# transformation

## Additional Resources

- **values-system.md** - Deep dive into polymorphic values
- **expressions-system.md** - Complete expression reference
- **syntax-system.md** - Syntax node details
- **Source code** - `src/EmmittJ.Terraform.Sdk/`
- **Tests** - `tests/EmmittJ.Terraform.Sdk.Tests/`
