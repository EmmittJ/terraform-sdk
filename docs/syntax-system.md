# Syntax System

The Syntax system provides the final layer of abstraction for generating HCL output. Syntax nodes are the output of the **Resolve phase** and serve as the direct representation of HCL elements that will be rendered to strings.

## Core Concepts

### TerraformSyntaxNode

`TerraformSyntaxNode` is the abstract base class for all renderable elements in HCL:

```csharp
public abstract class TerraformSyntaxNode
{
    /// <summary>
    /// Renders this syntax node to HCL string format.
    /// </summary>
    public abstract string ToHcl(ITerraformContext context);
}
```

**Key Characteristics:**

- **Simple abstraction** - only responsibility is HCL rendering
- **Context-aware** - uses `ITerraformContext` for indentation and formatting
- **Immutable** - nodes don't change after creation
- **Self-rendering** - each node type knows its HCL representation

## Syntax Node Types

### TerraformArgumentNode

Represents a key-value assignment:

```csharp
new TerraformArgumentNode("region", TerraformExpression.Literal("us-west-2"))

// Renders to:
// region = "us-west-2"
```

**Structure:**

```csharp
public sealed class TerraformArgumentNode : TerraformSyntaxNode
{
    public string Key { get; }                // Left side: "region"
    public TerraformExpression Value { get; } // Right side: "us-west-2"

    public override string ToHcl(ITerraformContext context)
        => $"{Key} = {Value.ToHcl(context)}";
}
```

**Usage:**

```csharp
// Created during resolution from TerraformValue<T>
var node = new TerraformArgumentNode("cidr_block",
    TerraformExpression.Literal("10.0.0.0/16"));

// Outputs: cidr_block = "10.0.0.0/16"
```

### TerraformBlockNode

Represents a nested block with children:

```csharp
new TerraformBlockNode("tags", children)

// Renders to:
// tags {
//   Name = "Example"
//   Environment = "Production"
// }
```

**Structure:**

```csharp
public sealed class TerraformBlockNode : TerraformSyntaxNode
{
    public string Label { get; }                              // "tags"
    public IReadOnlyList<string> AdditionalLabels { get; }    // e.g., ["for_each"]
    public IEnumerable<TerraformSyntaxNode> Children { get; } // Nested nodes
}
```

**Rendering with Indentation:**

```csharp
public override string ToHcl(ITerraformContext context)
{
    var sb = new StringBuilder();

    // Header: label [additional_labels...] {
    sb.Append(Label);
    foreach (var additionalLabel in AdditionalLabels)
        sb.Append(' ').Append(additionalLabel);
    sb.AppendLine(" {");

    // Body (indented)
    using (context.PushIndent())
    {
        foreach (var child in Children)
        {
            sb.Append(context.Indent);
            sb.AppendLine(child.ToHcl(context));
        }
    }

    // Closing brace
    sb.Append('}');
    return sb.ToString();
}
```

### TerraformTopLevelBlockNode

Represents top-level blocks like resources, data sources, providers:

```csharp
new TerraformTopLevelBlockNode("resource",
    labels: ["aws_vpc", "main"],
    children: childNodes)

// Renders to:
// resource "aws_vpc" "main" {
//   cidr_block = "10.0.0.0/16"
//   enable_dns_hostnames = true
// }
```

**Structure:**

```csharp
public class TerraformTopLevelBlockNode : TerraformSyntaxNode
{
    public string BlockType { get; }                       // "resource", "data", "module"
    public IReadOnlyList<string> Labels { get; }           // ["aws_vpc", "main"]
    public IReadOnlyList<TerraformSyntaxNode> Children { get; }
}
```

**Label Handling:**

```csharp
// resource "aws_vpc" "main"
BlockType = "resource"
Labels = ["aws_vpc", "main"]

// provider "aws"
BlockType = "provider"
Labels = ["aws"]

// terraform
BlockType = "terraform"
Labels = []
```

### TerraformCommentNode

Represents HCL comments:

```csharp
new TerraformCommentNode("This is a configuration comment")

// Renders to:
// # This is a configuration comment
```

**Structure:**

```csharp
public sealed class TerraformCommentNode : TerraformSyntaxNode
{
    public string Text { get; }  // Without the '#' prefix

    public override string ToHcl(ITerraformContext context)
        => $"# {Text}";
}
```

### TerraformEmptyLineNode

Represents empty lines for formatting:

```csharp
TerraformEmptyLineNode.Instance

// Renders to:
// (empty line)
```

**Structure:**

```csharp
public sealed class TerraformEmptyLineNode : TerraformSyntaxNode
{
    public static readonly TerraformEmptyLineNode Instance = new();

    public override string ToHcl(ITerraformContext context)
        => string.Empty;
}
```

**Singleton Pattern:**

Only one instance is needed - empty lines are identical.

## Resolution to Syntax Nodes

The resolution process transforms high-level constructs into syntax nodes:

### From Values

```csharp
// TerraformValue<T> resolves to expression nodes (which ARE syntax nodes)
var value = new TerraformValue<string>("us-west-2");
var nodes = value.ResolveNodes(context);
// Returns: [LiteralExpression("us-west-2")] - an expression syntax node

// In a property context, this expression is wrapped in an ArgumentNode
var arg = new TerraformArgumentNode("region", nodes.First() as TerraformExpression);
// region = "us-west-2"
```

**Key point:** The `LiteralExpression` returned IS a `TerraformSyntaxNode` (because `TerraformExpression` extends `TerraformSyntaxNode`).

### From Blocks

```csharp
// TerraformResource resolves to ArgumentNode and BlockNode children
var vpc = new TerraformResource("aws_vpc", "main")
{
    ["cidr_block"] = "10.0.0.0/16",
    ["tags"] = new TerraformMap<string>
    {
        ["Name"] = "Main VPC"
    }
};

var nodes = vpc.ResolveNodes(context);
// Returns:
// - TerraformArgumentNode("cidr_block", Literal("10.0.0.0/16"))
// - TerraformBlockNode("tags", [
//     TerraformArgumentNode("Name", Literal("Main VPC"))
//   ])
```

### From Stack

```csharp
// TerraformStack resolves to TopLevelBlockNode for each block
var stack = new TerraformStack { Name = "infrastructure" };
stack.Add(vpc);
stack.Add(subnet);

var nodes = stack.ResolveNodes(context);
// Returns:
// - TerraformTopLevelBlockNode("resource", ["aws_vpc", "main"], [...])
// - TerraformTopLevelBlockNode("resource", ["aws_subnet", "public"], [...])
```

## Indentation Management

The context provides automatic indentation management:

```csharp
public interface ITerraformContext
{
    int IndentLevel { get; }       // Current nesting level
    string Indent { get; }         // Current indentation string
    IDisposable PushIndent();      // Increase indent, returns disposable
}
```

### Usage Pattern

```csharp
sb.AppendLine("{");

using (context.PushIndent())
{
    // All rendering here is indented
    sb.Append(context.Indent);  // "  " (2 spaces)
    sb.AppendLine(child.ToHcl(context));
}

sb.Append("}");
```

**Result:**

```hcl
{
  child_content = "value"
  nested {
    deep_content = "nested value"
  }
}
```

### Indentation Rules

- **2 spaces per level** (Terraform standard)
- **Automatic nesting** via `using` statements
- **Context-aware** - each node gets correct indentation

## Node Formatting and Ordering

The `ITerraformNodeFormatter` interface controls node ordering:

```csharp
public interface ITerraformNodeFormatter
{
    IEnumerable<TerraformSyntaxNode> SortNodes(
        IEnumerable<TerraformSyntaxNode> nodes);
}
```

### Default Ordering

The SDK orders nodes for optimal readability:

1. **Meta-arguments first** (count, for_each, provider, depends_on, lifecycle)
2. **Regular arguments** (alphabetically)
3. **Nested blocks** (alphabetically by label)
4. **Dynamic blocks** (at the end)

**Example:**

```hcl
resource "aws_instance" "server" {
  count         = 3                    # Meta-argument
  provider      = aws.west             # Meta-argument

  ami           = "ami-12345"          # Regular argument (alphabetical)
  instance_type = "t2.micro"           # Regular argument (alphabetical)

  tags {                               # Nested block
    Name = "Server"
  }

  lifecycle {                          # Nested block
    create_before_destroy = true
  }

  dynamic "ebs_block_device" {         # Dynamic block (last)
    for_each = var.ebs_volumes
    content {
      device_name = ebs_block_device.value.device_name
    }
  }
}
```

## Syntax Node Tree Structure

Nodes form a tree that mirrors HCL structure:

```
TerraformTopLevelBlockNode (resource "aws_vpc" "main")
├── TerraformArgumentNode (cidr_block = "10.0.0.0/16")
├── TerraformArgumentNode (enable_dns_hostnames = true)
└── TerraformBlockNode (tags)
    ├── TerraformArgumentNode (Name = "Main VPC")
    └── TerraformArgumentNode (Environment = "Production")
```

### Tree Traversal

```csharp
void PrintTree(TerraformSyntaxNode node, int depth = 0)
{
    Console.WriteLine(new string(' ', depth * 2) + node.GetType().Name);

    if (node is TerraformBlockNode block)
    {
        foreach (var child in block.Children)
            PrintTree(child, depth + 1);
    }
    else if (node is TerraformTopLevelBlockNode topLevel)
    {
        foreach (var child in topLevel.Children)
            PrintTree(child, depth + 1);
    }
}
```

## Expression Nodes

`TerraformExpression` is both a syntax node AND a resolvable:

```csharp
public abstract class TerraformExpression : TerraformSyntaxNode, ITerraformResolvable
{
    // As ITerraformResolvable - returns itself
    public virtual IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context)
    {
        yield return this;
    }

    // As TerraformSyntaxNode - renders to HCL
    public abstract override string ToHcl(ITerraformContext context);
}
```

This dual nature allows expressions to:

- **Resolve to themselves** (they're already syntax nodes)
- **Render directly to HCL** (they know their representation)

## HCL Generation Pipeline

The complete pipeline from user code to HCL:

```
User Code (C#)
    ↓
TerraformBlock/TerraformValue (High-level API)
    ↓ Prepare Phase
Dependency Tracking
    ↓ Resolve Phase
TerraformSyntaxNode Tree
    ↓ ToHcl Phase
HCL String Output
```

### Example Flow

```csharp
// 1. User creates resource
var vpc = new TerraformResource("aws_vpc", "main")
{
    ["cidr_block"] = "10.0.0.0/16"
};

// 2. Added to stack
stack.Add(vpc);

// 3. Prepare phase - collect dependencies
stack.Prepare(context);

// 4. Resolve phase - generate syntax tree
var nodes = stack.ResolveNodes(context);
// Returns: TerraformTopLevelBlockNode containing ArgumentNodes

// 5. Render phase - generate HCL
var hcl = string.Join("\n\n", nodes.Select(n => n.ToHcl(context)));

// 6. Output HCL
// resource "aws_vpc" "main" {
//   cidr_block = "10.0.0.0/16"
// }
```

## Best Practices

### ✅ Do

- Use context.Indent for proper indentation
- Use `using (context.PushIndent())` for nested blocks
- Trust the node formatter for ordering
- Keep nodes immutable after creation
- Use appropriate node types for different HCL elements

### ❌ Don't

- Don't manually construct HCL strings outside of ToHcl()
- Don't ignore context parameter in ToHcl()
- Don't mutate nodes after creation
- Don't bypass the syntax node system
- Don't hardcode indentation levels

## Testing Syntax Nodes

```csharp
[Fact]
public async Task ArgumentNode_RendersCorrectly()
{
    var node = new TerraformArgumentNode(
        "region",
        TerraformExpression.Literal("us-west-2")
    );

    var context = TerraformContext.Temporary();
    var hcl = node.ToHcl(context);

    await Verify(hcl);
    // Snapshot: region = "us-west-2"
}

[Fact]
public async Task BlockNode_RendersWithIndentation()
{
    var children = new[]
    {
        new TerraformArgumentNode("Name", TerraformExpression.Literal("Example")),
        new TerraformArgumentNode("Environment", TerraformExpression.Literal("Production"))
    };

    var node = new TerraformBlockNode("tags", children);
    var context = TerraformContext.Temporary();
    var hcl = node.ToHcl(context);

    await Verify(hcl);
    // Snapshot:
    // tags {
    //   Name = "Example"
    //   Environment = "Production"
    // }
}
```

## Integration with Other Systems

### Values System

Values resolve to expression nodes (which are syntax nodes):

```csharp
TerraformValue<string> → ResolveNodes() → TerraformExpression (extends TerraformSyntaxNode)
```

### Expressions System

Expressions ARE a category of syntax nodes:

```csharp
TerraformExpression extends TerraformSyntaxNode  // Expressions are specialized syntax nodes
```

### Blocks System

Blocks resolve to collections of syntax nodes (arguments, blocks, expressions):

```csharp
TerraformBlock → ResolveNodes() → [ArgumentNode, BlockNode, ...] (all are TerraformSyntaxNode)
```

### Context System

Context provides rendering environment for all syntax nodes:

```csharp
ITerraformContext
├── Indentation management (PushIndent)
├── Node formatting (Formatter.SortNodes)
└── Scope access (Scope property)
```

## Advanced Patterns

### Custom Syntax Nodes

```csharp
public class CustomCommentBlock : TerraformSyntaxNode
{
    private readonly string _title;
    private readonly string[] _lines;

    public override string ToHcl(ITerraformContext context)
    {
        var sb = new StringBuilder();
        sb.AppendLine($"# {new string('=', 50)}");
        sb.AppendLine($"# {_title}");
        sb.AppendLine($"# {new string('=', 50)}");
        foreach (var line in _lines)
            sb.AppendLine($"# {line}");
        return sb.ToString();
    }
}
```

### Conditional Node Inclusion

```csharp
var nodes = new List<TerraformSyntaxNode>
{
    new TerraformArgumentNode("name", nameExpr)
};

if (includeDescription)
{
    nodes.Add(new TerraformArgumentNode("description", descExpr));
}

var block = new TerraformBlockNode("resource", nodes);
```

### Node Transformation

```csharp
// Transform nodes before rendering
var transformedNodes = nodes.Select(node =>
{
    if (node is TerraformArgumentNode arg && arg.Key == "sensitive_value")
    {
        // Redact sensitive values
        return new TerraformCommentNode("[REDACTED]");
    }
    return node;
});
```

## Performance Considerations

### String Building

```csharp
// ✅ Use StringBuilder for concatenation
var sb = new StringBuilder();
foreach (var child in Children)
{
    sb.Append(context.Indent);
    sb.AppendLine(child.ToHcl(context));
}

// ❌ Avoid string concatenation in loops
var result = "";
foreach (var child in Children)
{
    result += context.Indent + child.ToHcl(context) + "\n";
}
```

### Indentation Caching

Context caches indentation strings:

```csharp
// Efficient - string is cached per level
context.Indent  // "  " (cached at level 1)
context.Indent  // Same instance returned
```

### Node Reuse

```csharp
// Singleton for empty lines
TerraformEmptyLineNode.Instance  // Reused everywhere

// Consider caching for frequently used nodes
private static readonly TerraformCommentNode SectionSeparator =
    new TerraformCommentNode(new string('-', 50));
```

## Future Enhancements

Potential improvements:

- Syntax validation at node creation
- HCL parsing to reconstruct syntax trees
- Syntax tree diffing for incremental updates
- Better error messages with node location tracking
- Syntax node serialization for caching
- Custom rendering strategies per node type
