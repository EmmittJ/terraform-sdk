# EmmittJ.Terraform.Sdk.Tests

This directory contains the comprehensive test suite for the Terraform SDK. The tests use **snapshot testing** with Verify.Xunit to ensure generated HCL matches expected output.

## Test Architecture

The test suite is organized into layers that mirror the SDK's four-layer architecture:

### Layer 1: Values → Expressions

**Directory:** `Values/`

- Tests `TerraformValue<T>` resolution to `TerraformExpression`
- Validates implicit conversions and type safety
- Examples: `TerraformValueTests.cs`, `TerraformListTests.cs`, `TerraformMapTests.cs`

### Layer 2: Expressions → Syntax

**Directory:** `Expressions/`

- Tests expression composition and HCL rendering
- Validates operators, function calls, and complex expressions
- Examples: `TerraformExpressionTests.cs`, `TerraformReferenceExpressionTests.cs`

### Layer 3: Blocks → HCL

**Directory:** `Blocks/`

- Tests individual block types and their HCL generation
- Validates meta-arguments and nested blocks
- Examples: `TerraformResourceTests.cs`, `TerraformVariableTests.cs`, `TerraformOutputTests.cs`

### Layer 4: Stack Integration

**Directory:** `Configuration/`

- Tests complete infrastructure stacks with multiple blocks
- Validates cross-block references and dependencies
- Examples: `TerraformStackTests.cs`

## Testing Patterns

### Pattern 1: Snapshot Testing with Verify.Xunit

All HCL generation tests use **snapshot testing** to compare output against verified files.

```csharp
[Fact]
public Task TerraformResource_WithStringProperty()
{
    var resource = new TerraformResource("aws_instance", "example")
    {
        ["ami"] = "ami-12345678",
        ["instance_type"] = "t2.micro"
    };

    var context = TerraformTestHelpers.CreateContext();
    var hcl = TerraformTestHelpers.RenderBlock(resource, context);

    return Verify(hcl);  // Verify returns Task for snapshot comparison
}
```

**Key points:**

- Return `Task` from test methods
- Use `return Verify(hcl)` to perform snapshot verification
- First run creates `.received.txt` files
- Run `dotnet verify accept` to accept snapshots (creates `.verified.txt` files)
- Subsequent runs compare output against `.verified.txt`

### Pattern 2: Using TerraformTestHelpers

The `TerraformTestHelpers` class provides utilities for common test operations:

```csharp
using EmmittJ.Terraform.Sdk.Tests.TestHelpers;

// Create a test context
var context = TerraformTestHelpers.CreateContext("my-stack");

// Render a block to HCL
var hcl = TerraformTestHelpers.RenderBlock(resource, context);

// Or with automatic context creation
var hcl = TerraformTestHelpers.RenderBlock(resource);
```

**Available methods:**

- `CreateContext(string stackName = "test")` - Creates a context with a named stack
- `RenderBlock(TerraformBlock block, ITerraformContext context)` - Renders block with given context
- `RenderBlock(TerraformBlock block, string stackName = "test")` - Renders block with new context

### Pattern 3: Testing Resource References

When testing cross-resource references, add blocks to a stack and use the stack's context:

```csharp
[Fact]
public Task TerraformResource_WithReference()
{
    var stack = new TerraformStack { Name = "test" };
    var context = new TerraformContext(stack);

    var vpc = new TerraformResource("aws_vpc", "main")
    {
        ["cidr_block"] = "10.0.0.0/16"
    };
    stack.Add(vpc);

    var subnet = new TerraformResource("aws_subnet", "public")
    {
        ["vpc_id"] = vpc["id"],  // Reference using indexer
        ["cidr_block"] = "10.0.1.0/24"
    };
    stack.Add(subnet);

    var hcl = TerraformTestHelpers.RenderBlock(subnet, context);

    return Verify(hcl);
}
```

**Key points:**

- Create a stack and add all referenced blocks
- Use the stack's context for resolution
- Access resource attributes via indexer: `vpc["id"]`
- Variable/Output references use `.AsReference()`

### Pattern 4: Testing Collections

Use strongly-typed collection classes for maps and lists:

**For maps in nested blocks:**

```csharp
var tagsMap = new TerraformMapExpression();
tagsMap.Add("Name", TerraformExpression.Literal("Example"));
tagsMap.Add("Environment", TerraformExpression.Literal("Development"));

var resource = new TerraformResource("aws_instance", "example")
{
    ["tags"] = tagsMap
};
```

**For simple maps:**

```csharp
var resource = new TerraformResource("aws_instance", "example")
{
    ["tags"] = new TerraformMap<object>
    {
        ["Name"] = "Example",
        ["Environment"] = "Development"
    }
};
```

**For lists:**

```csharp
// List of primitives
["availability_zones"] = new TerraformList<string> { "us-west-2a", "us-west-2b" }

// List of maps
["ingress"] = new TerraformList<TerraformMap<object>>
{
    new TerraformMap<object>
    {
        ["from_port"] = 80,
        ["to_port"] = 80,
        ["protocol"] = "tcp"
    }
}
```

### Pattern 5: Testing Complete Stacks

For integration tests, use `TerraformStack.ToHcl()` to generate complete configuration:

```csharp
[Fact]
public Task TerraformStack_WithMultipleResources()
{
    var stack = new TerraformStack { Name = "test" };

    var vpc = new TerraformResource("aws_vpc", "main")
    {
        ["cidr_block"] = "10.0.0.0/16"
    };

    var subnet = new TerraformResource("aws_subnet", "public")
    {
        ["vpc_id"] = vpc["id"],
        ["cidr_block"] = "10.0.1.0/24"
    };

    stack.Add(vpc);
    stack.Add(subnet);

    var hcl = stack.ToHcl();  // Generates complete HCL with all blocks

    return Verify(hcl);
}
```

### Pattern 6: Testing Edge Cases

Use `[Theory]` and `[InlineData]` for parameterized tests:

```csharp
[Theory]
[InlineData("simple", "\"simple\"")]
[InlineData("with spaces", "\"with spaces\"")]
[InlineData("with\nnewline", "\"with\\nnewline\"")]
[InlineData("with\"quotes", "\"with\\\"quotes\"")]
public Task TerraformValue_String_EscapesSpecialCharacters(string input, string expected)
{
    TerraformValue<string> value = input;
    var context = TerraformContext.Temporary();

    var nodes = value.ResolveNodes(context).ToList();
    var expression = Assert.IsAssignableFrom<TerraformExpression>(nodes[0]);
    var hcl = expression.ToHcl(context);

    Assert.Equal(expected, hcl);
    return Task.CompletedTask;
}
```

### Pattern 7: Using Test Traits

Organize tests with xUnit traits for filtering:

```csharp
[Trait("Category", "Unit")]      // Unit vs Integration
[Trait("Layer", "Values")]        // Which SDK layer
public class TerraformValueTests
{
    // Tests...
}
```

**Run tests by trait:**

```bash
dotnet test --filter "Category=Unit"
dotnet test --filter "Layer=Blocks"
dotnet test --filter "Category=Integration&Layer=Stacks"
```

## Common Testing Scenarios

### Scenario 1: Testing a New Block Type

1. Create test file in appropriate directory
2. Add trait attributes for categorization
3. Test empty block first
4. Add tests for each property type
5. Test meta-arguments if applicable
6. Test references to/from other blocks

Example structure:

```csharp
[Trait("Category", "Integration")]
[Trait("Layer", "Blocks")]
public class TerraformNewBlockTests
{
    [Fact]
    public Task TerraformNewBlock_Empty() { ... }

    [Fact]
    public Task TerraformNewBlock_WithStringProperty() { ... }

    [Fact]
    public Task TerraformNewBlock_WithReferences() { ... }
}
```

### Scenario 2: Testing HCL Generation

1. Create the block/stack with test data
2. Render to HCL using helpers
3. Use `Verify(hcl)` for snapshot comparison
4. Review `.received.txt` file
5. Run `dotnet verify accept` if correct
6. Commit `.verified.txt` to version control

### Scenario 3: Testing Expression Composition

1. Build expressions using `TerraformExpression` factory methods
2. Compose complex expressions from simple ones
3. Test HCL output at each level
4. Verify operator precedence and parentheses

```csharp
var sum = TerraformExpression.Add(
    TerraformExpression.Literal(1),
    TerraformExpression.Literal(2)
);

var product = TerraformExpression.Multiply(sum, TerraformExpression.Literal(3));
var hcl = product.ToHcl(context);  // (1 + 2) * 3

return Verify(hcl);
```

## Snapshot Management

### Accepting New Snapshots

After writing a test, run it to generate `.received.txt` files:

```bash
dotnet test
```

Review the output files in `Snapshots/` directories, then accept them:

```bash
dotnet verify accept -y
```

### Updating Snapshots After Changes

When you modify SDK code that changes HCL output:

1. Run tests to generate new `.received.txt` files
2. Review changes using git diff on snapshot files
3. Verify changes are correct
4. Run `dotnet verify accept` to update `.verified.txt`
5. Commit updated snapshots with your changes

### Snapshot Organization

Snapshots are stored in directories matching the test class location:

- `Snapshots/TerraformResourceTests/TerraformResourceTests.TestName.verified.txt`
- One `.verified.txt` file per test method
- File names include full test class name and method name

## Best Practices

### DO:

✅ Use snapshot testing for all HCL generation  
✅ Add descriptive test method names  
✅ Test edge cases (empty, null, special characters)  
✅ Use `TerraformTestHelpers` for consistency  
✅ Add trait attributes for filtering  
✅ Test both positive and negative scenarios  
✅ Return `Task` from snapshot tests

### DON'T:

❌ Manually write expected HCL strings in tests  
❌ Skip testing error conditions  
❌ Forget to add blocks to stack when testing references  
❌ Use `Assert.Equal()` for HCL comparison (use Verify instead)  
❌ Commit `.received.txt` files (they're temporary)  
❌ Accept snapshots without reviewing changes

## Running Tests

```bash
# Run all tests
dotnet test

# Run specific category
dotnet test --filter "Category=Unit"
dotnet test --filter "Category=Integration"

# Run specific layer
dotnet test --filter "Layer=Values"
dotnet test --filter "Layer=Blocks"
dotnet test --filter "Layer=Stacks"

# Run specific test
dotnet test --filter "FullyQualifiedName~TerraformResource_WithStringProperty"

# Run with verbosity
dotnet test --verbosity normal

# Get test count
dotnet test --list-tests
```

## Test Coverage

Current test coverage (as of Nov 2025):

- **136 total tests**
- **134 passing**
- **2 skipped** (known issues)

Coverage breakdown:

- Values layer: ~25 tests
- Expressions layer: ~30 tests
- Blocks layer: ~45 tests
- Stack integration: ~35 tests

## Troubleshooting

### Test fails with "VerifyException"

- This means HCL output doesn't match verified snapshot
- Review the `.received.txt` file
- If correct, run `dotnet verify accept`
- If incorrect, fix the SDK code

### Reference not resolving correctly

- Ensure blocks are added to stack: `stack.Add(block)`
- Use stack's context for resolution
- Check that you're using correct reference pattern (indexer vs .AsReference())

### Snapshot files not being created

- Ensure test method returns `Task`
- Verify `return Verify(hcl)` statement exists
- Check that Verify.Xunit package is installed

### Test hangs or times out

- Check for circular references in blocks
- Ensure context is created properly
- Verify expressions don't have infinite recursion

## Contributing Tests

When adding new features to the SDK:

1. **Write tests first** (TDD approach)
2. **Use existing patterns** from similar tests
3. **Add comprehensive coverage** including edge cases
4. **Update this guide** if you discover new patterns
5. **Run full test suite** before submitting PR

For questions or improvements to testing patterns, open an issue on GitHub.
