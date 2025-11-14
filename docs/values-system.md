# Values System

The Values system provides the type-safe foundation for representing Terraform values in C#. It implements a polymorphic design that eliminates null reference exceptions and runtime type checking while maintaining compile-time type safety.

## Core Concepts

### TerraformValue\<T\>

`TerraformValue<T>` is the primary type used for all Terraform resource properties. It represents a value that can be either:

- A **literal value** (e.g., `"us-west-2"`, `443`, `true`)
- A **reference** to another resource's attribute (e.g., `vpc["id"]`)
- A **computed expression** (e.g., `Tf.Join("-", ["app", "server"])`)

```csharp
// All of these are TerraformValue<string>
TerraformValue<string> region = "us-west-2";           // Literal
TerraformValue<string> vpcId = vpc["id"];              // Reference
TerraformValue<string> name = Tf.Join("-", ["app"]);  // Expression
```

**Key Design Points:**

- `T` represents the **Terraform type** (string, double, bool), not the runtime .NET type
- At runtime, all values resolve to `TerraformExpression` for HCL generation
- Provides compile-time type safety and IntelliSense support
- Changed from struct to class to enable inheritance (collection types like `TerraformList<T>`)

### Implicit Conversions

The SDK provides automatic conversions for ergonomic APIs:

```csharp
// From literals - automatically wrapped in TerraformLiteralValue
TerraformValue<string> region = "us-west-2";
TerraformValue<int> port = 443;
TerraformValue<bool> enabled = true;

// From expressions - automatically recognized as ITerraformResolvable
TerraformValue<string> combined = TerraformExpression.Interpolate("prefix-", variable);
```

### Lazy Evaluation

Values can be lazily evaluated, deferring computation until the resolution phase:

```csharp
// Producer function is called during resolution, not at creation time
var lazyValue = TerraformValue<string>.Lazy(ctx =>
{
    // Compute the expression based on context
    return someCondition
        ? TerraformExpression.Literal("value-a")
        : TerraformExpression.Literal("value-b");
});
```

## Collection Types

### TerraformList\<T\>

Represents an ordered list of values:

```csharp
var securityGroups = new TerraformList<string>
{
    "sg-12345",
    "sg-67890"
};

// Resolves to: ["sg-12345", "sg-67890"]
```

### TerraformSet\<T\>

Represents an unordered collection of unique values:

```csharp
var tags = new TerraformSet<string>
{
    "production",
    "web-tier"
};

// Note: Sets use same HCL syntax as lists - type system distinguishes them
```

### TerraformMap\<T\>

Represents key-value pairs:

```csharp
var tags = new TerraformMap<string>
{
    ["Environment"] = "Production",
    ["Owner"] = "Platform Team"
};

// Resolves to: { Environment = "Production", Owner = "Platform Team" }
```

## References

### TerraformReference\<T\>

Represents a reference to another resource's attribute. Automatically tracks dependencies during the Prepare phase.

```csharp
var vpc = new TerraformResource("aws_vpc", "main")
{
    ["cidr_block"] = "10.0.0.0/16"
};

// Creates TerraformReference<string> that resolves to: aws_vpc.main.id
var subnet = new TerraformResource("aws_subnet", "public")
{
    ["vpc_id"] = vpc["id"]  // Reference
};
```

**Dependency Tracking:**

When a reference is resolved during the Prepare phase, the SDK automatically:

1. Records the dependency relationship
2. Validates no circular dependencies exist
3. Orders resources correctly in generated HCL

## ITerraformResolvable Interface

All value types implement `ITerraformResolvable`:

```csharp
public interface ITerraformResolvable
{
    IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context);
}
```

This interface is key to the **two-phase resolution system**:

1. **Prepare Phase**: Values are stored but not evaluated
2. **Resolve Phase**: Values are resolved to syntax nodes for HCL generation

### Resolution Lifecycle

```csharp
// 1. Creation - value is stored but not evaluated
var value = new TerraformValue<string>(vpc["id"]);

// 2. Prepare - dependencies are tracked (happens during stack.Prepare())
context.RecordDependency(vpc);

// 3. Resolve - syntax nodes are generated (happens during stack.ToHcl())
var nodes = value.ResolveNodes(context);  // Returns TerraformExpression nodes
```

## Internal Implementation

### TerraformLiteralValue\<T\>

Wraps literal values and resolves them to `LiteralExpression`:

```csharp
internal class TerraformLiteralValue<T> : ITerraformResolvable
{
    private readonly T? _value;

    public IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context)
    {
        yield return TerraformExpression.Literal(_value);
    }
}
```

Used automatically when literals are assigned:

```csharp
// Implicit conversion creates TerraformValue<string> with TerraformLiteralValue<string>
TerraformValue<string> region = "us-west-2";
```

### TerraformReferenceResolvable

Generates reference identifier expressions:

```csharp
internal class TerraformReferenceResolvable : ITerraformResolvable
{
    private readonly TerraformBlock _block;
    private readonly string _attributeName;

    public IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context)
    {
        // Generate: resource_type.resource_name.attribute_name
        var reference = _block.AsReference();
        var identifier = reference.ToHcl(context);
        yield return TerraformExpression.Identifier($"{identifier}.{_attributeName}");
    }
}
```

## Benefits of the Polymorphic Design

### No Null Reference Exceptions

Traditional approach (problematic):

```csharp
// ❌ Requires runtime null checking
public class Property
{
    public object? Value { get; set; }
    public PropertyType Type { get; set; }
}

if (property.Value is string str) { ... }
else if (property.Value is ResourceReference ref) { ... }
```

SDK approach (type-safe):

```csharp
// ✅ Each value type has exactly what it needs
public class TerraformValue<T> : ITerraformValue
{
    private readonly ITerraformResolvable? _resolvable;

    public IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context)
        => _resolvable.ResolveNodes(context);
}
```

### Compile-Time Type Safety

```csharp
// ✅ Compiler enforces type safety
TerraformValue<string> region = "us-west-2";  // OK
TerraformValue<string> region = 443;          // Compiler error

// ✅ Generic constraints prevent type mismatches
public class TerraformList<T> : TerraformValue<List<T>>
{
    // Can only contain elements of type T
}
```

### No Runtime Type Switching

```csharp
// ❌ Traditional approach - runtime switching
if (value.Type == PropertyType.Literal)
    return RenderLiteral(value.Value);
else if (value.Type == PropertyType.Reference)
    return RenderReference(value.Value);

// ✅ SDK approach - polymorphic dispatch
return value.ResolveNodes(context);  // Each type knows how to resolve itself
```

## Usage Patterns

### Conditional Values

```csharp
// Use lazy evaluation for conditional logic
var instanceType = TerraformValue<string>.Lazy(ctx =>
{
    var isProd = environment.Value == "production";
    return TerraformExpression.Literal(isProd ? "m5.large" : "t2.micro");
});
```

### Nested Structures

```csharp
// Values can be nested arbitrarily
var config = new TerraformMap<object>
{
    ["database"] = new TerraformMap<object>
    {
        ["host"] = dbInstance["endpoint"],
        ["port"] = 5432,
        ["credentials"] = new TerraformMap<string>
        {
            ["username"] = dbUser["name"],
            ["password"] = dbPassword["value"]
        }
    }
};
```

### Working with Blocks

Blocks inherit from `TerraformMap<object>` for property storage:

```csharp
public abstract class TerraformBlock : TerraformMap<object>
{
    // Source-generated properties use SetArgument/GetArgument
    public void SetArgument(string terraformName, object? value)
    {
        if (value is ITerraformValue tfValue)
            this[terraformName] = TerraformValue<object>.Lazy(ctx => tfValue.ResolveNodes(ctx));
        else if (value is ITerraformResolvable resolvable)
            this[terraformName] = new TerraformValue<object>(resolvable);
        else
            this[terraformName] = value;  // Implicit conversion to TerraformValue<object>
    }
}
```

## Best Practices

### ✅ Do

- Use `TerraformValue<T>` for all resource properties
- Trust the type system - avoid manual null checks
- Use implicit conversions for literals
- Use lazy evaluation for complex conditional logic
- Let references track dependencies automatically

### ❌ Don't

- Don't manually create `TerraformLiteralValue<T>` - use implicit conversion
- Don't use `TerraformValue<object>` in user code - use specific types
- Don't access internal `_resolvable` field - use `ResolveNodes()`
- Don't perform runtime type checking - use polymorphic dispatch
- Don't disable nullable reference types

## Integration with Other Systems

The Values system integrates with:

- **Expressions**: Values resolve to `TerraformExpression` nodes
- **Syntax**: Resolution produces `TerraformSyntaxNode` instances
- **Blocks**: Blocks store values and resolve them during HCL generation
- **Context**: `ITerraformContext` provides resolution environment
- **Validation**: Dependency graph tracks references between values

## Future Enhancements

Potential improvements to the Values system:

- Value caching to avoid redundant resolution
- Type inference for collection types
- Enhanced validation during value creation
- Custom value types for domain-specific patterns
- Performance optimizations for large configurations
