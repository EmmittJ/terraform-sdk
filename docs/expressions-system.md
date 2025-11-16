# Expressions System

The Expressions system provides the compositional building blocks for representing Terraform HCL syntax as an abstract syntax tree. Expressions are values that appear on the right-hand side of assignments and can be composed into larger, more complex expressions.

## Core Concepts

### TerraformExpression

`TerraformExpression` is the abstract base class for all expression node types in the Terraform AST. Expressions are a **specialized category of syntax nodes** that represent value-producing constructs in Terraform configurations - not structural elements like blocks or property assignments.

```csharp
// Expressions ARE syntax nodes (they extend TerraformSyntaxNode)
public abstract class TerraformExpression : TerraformSyntaxNode, ITerraformSerializable, ITerraformResolvable
{
    // Expressions resolve to themselves (they're already syntax nodes)
    public virtual IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context);

    // All expressions can render to HCL
    public abstract override string ToHcl(ITerraformContext context);
}
```

**Key Characteristics:**

- **Expressions ARE syntax nodes** - just a specific category for value-producing constructs
- **Immutable** - expressions don't change after creation
- **Compositional** - small expressions combine into larger ones
- **Type-agnostic** - no knowledge of .NET types, only HCL syntax
- **Self-rendering** - each expression knows how to generate HCL

**Note:** This is similar to how Roslyn works - `ExpressionSyntax` extends `SyntaxNode`. The term "expression tree" here refers to compositional tree structures (like AST expression nodes), NOT .NET's `System.Linq.Expressions.Expression` trees.### Understanding the AST Node Hierarchy

```csharp
// All of these ARE syntax nodes in the Terraform AST:

// ✅ Expression Nodes - value-producing syntax nodes
TerraformExpression literal = TerraformExpression.Literal("us-west-2");
TerraformExpression reference = vpc.AsReference();
TerraformExpression list = TerraformExpression.List("a", "b", "c");

// ✅ Structural Syntax Nodes - non-value-producing elements
TerraformArgumentNode arg = new("region", literal);  // region = "us-west-2"
TerraformBlockNode block = new("tags", children);    // tags { ... }

// ✅ High-Level Constructs - resolve to multiple syntax nodes
TerraformResource vpc = new("aws_vpc", "main");
TerraformProvider aws = new("aws");
```

**The Hierarchy:**

- `TerraformSyntaxNode` (abstract base) - all AST nodes
  - `TerraformExpression` (extends SyntaxNode) - value-producing nodes
  - `TerraformArgumentNode` (extends SyntaxNode) - key=value assignments
  - `TerraformBlockNode` (extends SyntaxNode) - nested blocks
  - etc.

## Expression Types

### Literal Expressions

Represent constant values:

```csharp
// String literals
TerraformExpression.Literal("us-west-2")     // "us-west-2"
TerraformExpression.Literal("Hello World")   // "Hello World"

// Numeric literals
TerraformExpression.Literal(443)             // 443
TerraformExpression.Literal(3.14)            // 3.14

// Boolean literals
TerraformExpression.Literal(true)            // true
TerraformExpression.Literal(false)           // false

// Implicit conversions available
TerraformExpression expr = "us-west-2";      // Automatic conversion
TerraformExpression port = 443;              // Automatic conversion
```

### Identifier Expressions

Represent variable references and identifiers:

```csharp
// Simple identifier
TerraformExpression.Identifier("var.region")              // var.region

// Deferred resolution - resolved during Resolve phase
TerraformExpression.Identifier(provider, p =>
    p.Alias?.LiteralValue != null
        ? $"aws.{p.Alias.LiteralValue}"
        : "aws"
)

// Common use case - resource references
resource.AsReference()  // aws_vpc.main
```

### Collection Expressions

#### List Expressions

```csharp
// Array syntax
TerraformExpression.List("a", "b", "c")
// ["a", "b", "c"]

// From enumerable
TerraformExpression.List(items.Select(i => i.ToExpression()))

// Implicit conversion
TerraformExpression tags = new[] { "web", "api" };
// ["web", "api"]
```

#### Set Expressions

```csharp
// Sets use same HCL syntax as lists - type system distinguishes them
TerraformExpression.Set("unique", "values", "only")
// ["unique", "values", "only"]

// Note: Terraform's type system handles uniqueness validation
```

#### Map/Object Expressions

```csharp
// Create empty map
var map = TerraformExpression.Object();

// Add key-value pairs
map["Environment"] = TerraformExpression.Literal("Production");
map["Owner"] = TerraformExpression.Literal("Platform Team");

// Result:
// {
//   Environment = "Production"
//   Owner = "Platform Team"
// }

// From dictionary
var pairs = new Dictionary<string, TerraformExpression>
{
    ["key1"] = value1,
    ["key2"] = value2
};
TerraformExpression.Map(pairs);
```

### String Interpolation

```csharp
// Combine multiple parts into a single string
TerraformExpression.Interpolate("prefix-", variable, "-suffix")
// "prefix-${var.name}-suffix"

TerraformExpression.Interpolate("The VPC ID is ", vpc["id"])
// "The VPC ID is ${aws_vpc.main.id}"
```

### For Expressions

#### List Comprehensions

```csharp
// Basic form
TerraformExpression.ForList("item", collection, resultExpr)
// [for item in collection : resultExpr]

// With callback builder
TerraformExpression.ForList(users, user => user["email"])
// [for item in var.users : item.email]

// With condition
TerraformExpression.ForList(items, item => item["id"],
    condition: item["active"])
// [for item in var.items : item.id if item.active]
```

#### Map Comprehensions

```csharp
// Basic form
TerraformExpression.ForMap("k", "v", collection, keyExpr, valueExpr)
// {for k, v in collection : k => v}

// With callback builder
TerraformExpression.ForMap(users, (key, value) => (key, value["role"]))
// {for key, value in var.users : key => value.role}
```

### Conditional Expressions (Ternary)

```csharp
TerraformExpression.Conditional(
    condition: isProd,
    trueValue: TerraformExpression.Literal("m5.large"),
    falseValue: TerraformExpression.Literal("t2.micro")
)
// var.is_prod ? "m5.large" : "t2.micro"
```

### Index/Subscript Expressions

```csharp
// List indexing
TerraformExpression.Index(listExpr, TerraformExpression.Literal(0))
// list[0]

// Map lookup
TerraformExpression.Index(mapExpr, TerraformExpression.Literal("key"))
// map["key"]

// Member access syntax (convenience)
vpc["id"]           // aws_vpc.main.id
subnet["cidr_block"] // aws_subnet.public.cidr_block
```

### Splat Expressions

```csharp
// Get all elements
TerraformExpression.Splat(instances)
// aws_instance.servers[*]

// Get attribute from all elements
TerraformExpression.Splat(instances, "id")
// aws_instance.servers[*].id
```

### Binary Expressions (Operators)

```csharp
// Arithmetic
var sum = expr1 + expr2;         // expr1 + expr2
var diff = expr1 - expr2;        // expr1 - expr2
var product = expr1 * expr2;     // expr1 * expr2
var quotient = expr1 / expr2;    // expr1 / expr2

// Supported operators:
// Add, Subtract, Multiply, Divide, Modulo
// Equal, NotEqual
// LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual
// And, Or
```

### Raw Expressions

For escaping to raw HCL when needed (use sparingly):

```csharp
TerraformExpression.Raw("jsonencode(local.complex_data)")
// Outputs exactly: jsonencode(local.complex_data)
```

⚠️ **Prefer typed expressions** - raw expressions bypass type safety and validation.

## Composition Patterns

### Building Complex Expressions

Expressions compose naturally:

```csharp
// Nested collections
var config = TerraformExpression.Object();
config["database"] = TerraformExpression.Object();
config["database"]["host"] = dbInstance["endpoint"];
config["database"]["port"] = 5432;

// Conditional with interpolation
var name = TerraformExpression.Conditional(
    usePrefix,
    TerraformExpression.Interpolate(prefix, "-", baseName),
    baseName
);

// For expression with conditional filtering
var activeUserEmails = TerraformExpression.ForList(
    users,
    user => user["email"],
    condition: user["active"]
);
```

### Compositional AST Structures

Expressions form immutable tree structures in the Abstract Syntax Tree (AST):

```
ConditionalExpression (syntax node)
├── Condition: BinaryExpression (syntax node)
│   ├── Left: IdentifierExpression("var.environment") (syntax node)
│   ├── Operator: Equal
│   └── Right: LiteralExpression("production") (syntax node)
├── TrueValue: InterpolateExpression (syntax node)
│   ├── LiteralExpression("prod-") (syntax node)
│   └── IdentifierExpression("var.name") (syntax node)
└── FalseValue: InterpolateExpression (syntax node)
    ├── LiteralExpression("dev-") (syntax node)
    └── IdentifierExpression("var.name") (syntax node)
```

**Note:** Each node in this tree is a `TerraformSyntaxNode`. This is an AST (Abstract Syntax Tree), not to be confused with .NET's `System.Linq.Expressions.Expression` trees used for LINQ.

## Resolution Process

Expressions, like all AST nodes, participate in the **resolution system**:

### Resolve Phase

```csharp
public virtual IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context)
{
    yield return this;  // Expressions return themselves - they're already syntax nodes!
}
```

**Why return themselves?** Because `TerraformExpression` extends `TerraformSyntaxNode`, expressions ARE already AST nodes ready for rendering. They don't need to be transformed into something else.

### Render Phase

```csharp
public abstract string ToHcl(ITerraformContext context);
```

Each expression node type implements HCL rendering:

```csharp
// LiteralExpression renders to quoted string
"\"us-west-2\""

// ListExpression renders to HCL list
"[\"a\", \"b\", \"c\"]"

// ConditionalExpression renders to ternary
"var.is_prod ? \"m5.large\" : \"t2.micro\""
```

## Assignment Operators

Expressions control how they appear in assignments:

```csharp
public virtual string AssignmentOperator => " = ";
```

- **Object expressions**: Use `" = "` (e.g., `key = value`)
- **Block expressions**: Override to `" "` (e.g., `tags { ... }`)

## Integration with Values

Expressions integrate seamlessly with the Values system:

```csharp
// TerraformValue<T> wraps expressions
TerraformValue<string> value = TerraformExpression.Literal("us-west-2");

// TerraformValue<T> resolves to expressions
var nodes = value.ResolveNodes(context);  // Returns expression nodes

// Expressions can be directly assigned
resource["region"] = TerraformExpression.Conditional(isProd, "us-east-1", "us-west-2");
```

## Factory Methods vs Constructors

The SDK prefers **factory methods** over constructors:

```csharp
// ✅ Factory methods - clear intent, consistent API
TerraformExpression.Literal("value")
TerraformExpression.List("a", "b")
TerraformExpression.Conditional(cond, trueVal, falseVal)

// ❌ Direct constructors - less discoverable
new LiteralExpression<string>("value")
new ListExpression(new[] { ... })
```

Benefits:

- Consistent naming (`TerraformExpression.*`)
- Better IntelliSense discoverability
- Flexibility to change implementations
- Type inference support

## Type Safety Considerations

Expressions are **type-agnostic** at the expression level:

```csharp
// All valid expressions - type checking happens at TerraformValue<T> level
TerraformExpression expr1 = TerraformExpression.Literal("string");
TerraformExpression expr2 = TerraformExpression.Literal(123);
TerraformExpression expr3 = TerraformExpression.List("a", 1, true);  // Mixed types OK

// Type safety enforced at value level
TerraformValue<string> region = "us-west-2";  // ✅ Type matches
TerraformValue<string> port = 443;            // ✅ Implicit conversion OK
TerraformValue<int> region = "us-west-2";    // ❌ Compiler error
```

This separation allows:

- **Expressions**: Focus on HCL syntax correctness
- **Values**: Provide compile-time type safety

## Optimization Opportunities

The expression tree design enables future optimizations:

### Constant Folding

```csharp
// Before optimization
TerraformExpression.Literal(2) + TerraformExpression.Literal(3)

// After optimization
TerraformExpression.Literal(5)
```

### Dead Code Elimination

```csharp
// Before optimization
TerraformExpression.Conditional(
    TerraformExpression.Literal(true),
    valueA,
    valueB
)

// After optimization
valueA
```

### Common Subexpression Elimination

```csharp
// Detect and reuse identical subexpressions
var expr1 = vpc["id"];
var expr2 = vpc["id"];  // Same reference
```

## Best Practices

### ✅ Do

- Use factory methods (`TerraformExpression.Literal()` not `new LiteralExpression()`)
- Build expressions compositionally from smaller pieces
- Use typed expressions instead of `Raw()` whenever possible
- Trust the expression system for HCL generation
- Leverage implicit conversions for cleaner code

### ❌ Don't

- Don't manually construct HCL strings - use expressions
- Don't mix expression construction with HCL rendering
- Don't override `ToHcl()` without understanding indentation context
- Don't create mutable expression types
- Don't bypass type safety with excessive `Raw()` usage

## Advanced Patterns

### Expression Builders

```csharp
public static class CustomExpressions
{
    public static TerraformExpression AwsArn(string service, string resource)
    {
        return TerraformExpression.Interpolate(
            "arn:aws:",
            service,
            "::",
            TerraformExpression.Identifier("data.aws_region.current.name"),
            "::",
            TerraformExpression.Identifier("data.aws_caller_identity.current.account_id"),
            ":",
            resource
        );
    }
}

// Usage
var arn = CustomExpressions.AwsArn("s3", bucketName);
```

### Lazy Expression Evaluation

```csharp
// Expression isn't evaluated until resolution
var lazyExpr = TerraformValue<string>.Lazy(ctx =>
{
    // Compute expression based on context state
    var useOptimized = ctx.Scope.SomeCondition;
    return useOptimized
        ? TerraformExpression.Literal("optimized-value")
        : TerraformExpression.Raw("complex.terraform.expression");
});
```

### Custom Expression Types

```csharp
// Extend for domain-specific needs
public class TagExpression : TerraformExpression
{
    private readonly Dictionary<string, TerraformExpression> _tags;

    public override string ToHcl(ITerraformContext context)
    {
        var map = TerraformExpression.Object();
        foreach (var (key, value) in _tags)
        {
            map[key] = value;
        }
        return map.ToHcl(context);
    }
}
```

## Common Pitfalls

### String Concatenation

```csharp
// ❌ Don't use C# string concatenation for HCL
var bad = TerraformExpression.Literal("prefix-" + variable + "-suffix");

// ✅ Use interpolation
var good = TerraformExpression.Interpolate("prefix-", variable, "-suffix");
```

### Premature Rendering

```csharp
// ❌ Don't call ToHcl() during construction
var bad = new TerraformResource("aws_vpc", "main")
{
    ["name"] = vpc.AsReference().ToHcl(context)  // Wrong!
};

// ✅ Keep expressions as expressions
var good = new TerraformResource("aws_vpc", "main")
{
    ["name"] = vpc.AsReference()  // Expression object
};
```

### Type Mismatches

```csharp
// ❌ Expression accepts anything - type checking delayed
TerraformExpression expr = TerraformExpression.List(1, "two", true);

// ✅ Use typed collections when type safety matters
TerraformList<string> list = new() { "a", "b", "c" };
```

## Testing Expressions

```csharp
[Fact]
public void ConditionalExpression_RendersCorrectly()
{
    var expr = TerraformExpression.Conditional(
        TerraformExpression.Identifier("var.is_prod"),
        TerraformExpression.Literal("m5.large"),
        TerraformExpression.Literal("t2.micro")
    );

    var context = TerraformContext.Temporary();
    var hcl = expr.ToHcl(context);

    await Verify(hcl);  // Snapshot testing
}
```

## Future Enhancements

Potential improvements:

- Expression validation during construction
- Static analysis for common mistakes
- Expression optimization pipeline
- Better error messages with expression location tracking
- Expression serialization/deserialization for caching
- Expression equivalence checking
