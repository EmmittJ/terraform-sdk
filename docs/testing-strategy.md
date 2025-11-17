# Comprehensive Testing Strategy

## 🎯 Problem Statement

The SDK generates HCL from C# code through a three-layer architecture:

1. **Values Layer** - Type-safe value storage
2. **Expressions Layer** - Compositional HCL syntax builders
3. **Syntax Layer** - Direct HCL output

Errors like `Literal type Object is not supported` occur deep in the pipeline during Aspire publish, making them hard to debug. We need **layered testing** that catches issues at each level before they propagate to integration tests.

## 📊 Testing Pyramid

```
                    ┌──────────────────────────┐
                    │ Aspire Integration       │ ← E2E: Full publish pipeline
                    │ (Slowest, Highest Level) │
                    └──────────────────────────┘
                  ┌───────────────────────────────┐
                  │   SDK Integration Tests       │ ← Stack → HCL validation
                  │   (Medium Speed)              │
                  └───────────────────────────────┘
              ┌───────────────────────────────────────┐
              │      Expression Unit Tests            │ ← Expression → HCL
              │      (Fast, Lowest Level)             │
              └───────────────────────────────────────┘
          ┌───────────────────────────────────────────────┐
          │         Value Unit Tests                      │ ← Value → Expression
          │         (Fastest, Foundation)                 │
          └───────────────────────────────────────────────┘
```

## 🧪 Test Suite Structure

### Layer 1: Value Tests (`EmmittJ.Terraform.Sdk.Tests`)

**Purpose**: Validate that all `TerraformValue<T>` types resolve to valid expressions

**Test Categories**:

1. **Primitive Value Resolution**

   - Test: `string`, `int`, `bool`, `double`, `decimal`, etc.
   - Verify: Correct `LiteralExpression<T>` creation
   - Catch: Unsupported literal types BEFORE they reach HCL generation

2. **Complex Value Resolution**

   - Test: `Dictionary<string, T>`, `List<T>`, nested objects
   - Verify: Correct `MapExpression`, `ListExpression` creation
   - Catch: Type mismatches in collections

3. **Reference Resolution**

   - Test: Resource references, variable references
   - Verify: Correct identifier generation (`aws_vpc.main.id`)
   - Catch: Invalid reference paths

4. **Null Handling**
   - Test: `null` values in all contexts
   - Verify: Proper null propagation or defaults
   - Catch: `NullReferenceException` during resolution

**Example Tests**:

```csharp
[Trait("Category", "Unit")]
[Trait("Layer", "Values")]
public class TerraformValueTests
{
    private static ITerraformContext CreateContext() => TerraformContext.Temporary();

    [Fact]
    public void TerraformValue_String_ResolvesToLiteralExpression()
    {
        TerraformValue<string> value = "test";
        var context = CreateContext();

        var nodes = value.ResolveNodes(context).ToList();

        Assert.Single(nodes);
        var expression = Assert.IsAssignableFrom<TerraformExpression>(nodes[0]);
        Assert.Equal("\"test\"", expression.ToHcl(context));
    }

    [Fact]
    public void TerraformValue_UnsupportedType_ThrowsNotSupportedException()
    {
        var ex = Assert.Throws<NotSupportedException>(() =>
        {
            TerraformValue<object> value = new object();
            var context = CreateContext();
            var nodes = value.ResolveNodes(context).ToList();
            nodes[0].ToHcl(context);
        });

        Assert.Contains("Literal type Object is not supported", ex.Message);
    }
}
```

### Layer 2: Expression Tests (`EmmittJ.Terraform.Sdk.Tests`)

**Purpose**: Validate that expressions generate correct HCL syntax

**Test Categories**:

1. **Literal Expression HCL**

   - Test: All supported literal types
   - Verify: Correct HCL format (`"string"`, `123`, `true`, `null`)
   - Catch: Unsupported types throwing at HCL generation time

2. **Collection Expression HCL**

   - Test: Lists, sets, maps with various element types
   - Verify: Correct syntax (`[]`, `{}`) with proper nesting and indentation
   - Catch: Malformed HCL structures

3. **Reference Expression HCL**

   - Test: Simple and complex references
   - Verify: Correct identifier format
   - Catch: Invalid identifiers

4. **Function Call Expression HCL**

   - Test: Built-in functions with various argument types
   - Verify: Correct function call syntax
   - Catch: Invalid argument formatting

5. **Operator Expression HCL**
   - Test: Arithmetic, logical, comparison operators
   - Verify: Correct operator precedence and formatting
   - Catch: Unsupported operators

**Example Tests**:

```csharp
[Trait("Category", "Unit")]
[Trait("Layer", "Expressions")]
[UsesVerify]
public class TerraformExpressionTests
{
    private static ITerraformContext CreateContext() => TerraformContext.Temporary();

    [Theory]
    [InlineData("test", "\"test\"")]
    [InlineData(123, "123")]
    [InlineData(true, "true")]
    [InlineData(false, "false")]
    public void LiteralExpression(object value, string expectedHcl)
    {
        var expr = TerraformExpression.Literal(value);
        var context = CreateContext();

        var hcl = expr.ToHcl(context);
        Assert.Equal(expectedHcl, hcl);
    }

    [Fact]
    public Task MapExpression_WithNestedValues_GeneratesValidHCL()
    {
        var map = TerraformExpression.Map();
        map["string_key"] = TerraformExpression.Literal("value");
        map["number_key"] = TerraformExpression.Literal(42);
        map["nested"] = TerraformExpression.Map(new Dictionary<string, TerraformSyntaxNode>
        {
            ["inner"] = TerraformExpression.Literal("test")
        });

        var context = CreateContext();
        var hcl = map.ToHcl(context);

        return Verify(hcl);
    }
}
```

### Layer 3: Block Tests (`EmmittJ.Terraform.Sdk.Tests`)

**Purpose**: Validate that blocks (resources, variables, outputs) generate correct HCL structure

**Test Categories**:

1. **Resource Block HCL**

   - Test: Resources with various property types
   - Verify: Correct block structure with meta-arguments
   - Catch: Missing required properties, invalid property types

2. **Variable Block HCL**

   - Test: Variables with all type constraints
   - Verify: Correct type, default, description formatting
   - Catch: Invalid type expressions

3. **Output Block HCL**

   - Test: Outputs with complex value expressions
   - Verify: Correct value, description, sensitive attributes
   - Catch: Invalid output values

4. **Nested Block HCL**
   - Test: Resources with nested blocks (e.g., `dynamic` blocks)
   - Verify: Correct nesting and indentation
   - Catch: Malformed nested structures

**Example Tests**:

```csharp
[Trait("Category", "Integration")]
[Trait("Layer", "Blocks")]
[UsesVerify]
public class TerraformResourceTests
{
    [Fact]
    public Task TerraformResource_WithComplexProperties_GeneratesValidHCL()
    {
        var resource = new TerraformResource("aws_instance", "example")
        {
            ["ami"] = "ami-12345678",
            ["instance_type"] = "t2.micro",
            ["tags"] = new TerraformMap<object>
            {
                ["Name"] = "Example",
                ["Environment"] = "Dev"
            }
        };

        var hcl = resource.ToHcl();

        return Verify(hcl);
    }
}
```

### Layer 4: Stack Integration Tests (`EmmittJ.Terraform.Sdk.Tests`)

**Purpose**: Validate that complete stacks generate valid, terraform-validated HCL

**Test Categories**:

1. **Full Stack HCL Generation**

   - Test: Stacks with multiple resources, variables, outputs
   - Verify: Complete HCL file structure
   - Catch: Missing terraform block, invalid dependencies

2. **Terraform Validation**

   - Test: Run `terraform validate` on generated HCL
   - Verify: No validation errors
   - Catch: Invalid HCL syntax or semantics

3. **Reference Resolution**
   - Test: Cross-resource references
   - Verify: Correct reference paths in output
   - Catch: Unresolved or circular references

**Example Tests**:

```csharp
[Trait("Category", "Integration")]
[Trait("Layer", "Stacks")]
[UsesVerify]
public class TerraformStackTests
{
    [Fact]
    public Task TerraformStack_WithMultipleResources_GeneratesValidHCL()
    {
        var stack = new TerraformStack { Name = "example" };

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

        var hcl = stack.ToHcl();

        return Verify(hcl);
    }
}
```

### Layer 5: Aspire Integration Tests (`EmmittJ.Aspire.Hosting.Terraform.Tests`)

**Purpose**: Validate end-to-end pipeline execution and file generation

**Test Categories**:

1. **Pipeline Execution**

   - Test: Full publish pipeline with various configurations
   - Verify: Files generated in correct locations
   - Catch: Pipeline failures, file generation errors

2. **Multi-Stack Generation**

   - Test: Multiple Terraform environments
   - Verify: Separate files per stack
   - Catch: File conflicts, incorrect output paths

3. **Configuration Propagation**
   - Test: Aspire resource annotations → Terraform configuration
   - Verify: Correct translation of Aspire concepts
   - Catch: Lost or incorrect configuration

**Example Tests**:

```csharp
[Trait("Category", "E2E")]
[Trait("Layer", "Aspire")]
public class TerraformPipelineIntegrationTests
{
    private static string[] GetPublishArgs(string outputPath) =>
        ["--operation", "publish", "--output-path", outputPath, "--non-interactive"];

    [Fact]
    public async Task TerraformStack_GeneratesFileInDefaultLocation()
    {
        var tempDir = Path.Combine(Path.GetTempPath(), "terraform-test", Guid.NewGuid().ToString());
        try
        {
            var builder = DistributedApplication.CreateBuilder(new DistributedApplicationOptions
            {
                Args = GetPublishArgs(tempDir),
                DisableDashboard = true
            });

            builder.AddTerraformEnvironment("terraform");

            var container = builder.AddContainer("myapp", "image")
                .PublishAsTerraform((stack, _) =>
                {
                    var vpc = new TerraformVariable("vpc_cidr")
                    {
                        Type = "string",
                        Default = "10.0.0.0/16",
                        Description = "VPC CIDR block"
                    };
                    stack.Add(vpc);
                });

            using var app = builder.Build();

            // Act - Execute the publish pipeline
            using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));
            await app.StartAsync(cts.Token);
            await app.WaitForShutdownAsync(cts.Token);

            // Assert - Verify the entire output directory structure
            await VerifyDirectory(tempDir);
        }
        finally
        {
            if (Directory.Exists(tempDir))
            {
                Directory.Delete(tempDir, recursive: true);
            }
        }
    }
}
```

## 🔄 Test Execution Order

### Development Workflow

1. Run **Value Tests** first - fastest feedback loop
2. Run **Expression Tests** - validates HCL generation
3. Run **Block Tests** - validates structure
4. Run **Stack Integration Tests** - validates composition
5. Run **Aspire Integration Tests** last - full E2E validation

### CI/CD Pipeline

```yaml
- name: Unit Tests (Values & Expressions)
  run: dotnet test --filter Category=Unit

- name: Integration Tests (Blocks & Stacks)
  run: dotnet test --filter Category=Integration

- name: E2E Tests (Aspire Pipeline)
  run: dotnet test --filter Category=E2E
```

## 📝 Test Categorization with Traits

```csharp
[Trait("Category", "Unit")]
[Trait("Layer", "Values")]
public class TerraformValueTests { }

[Trait("Category", "Unit")]
[Trait("Layer", "Expressions")]
public class TerraformExpressionTests { }

[Trait("Category", "Integration")]
[Trait("Layer", "Blocks")]
public class TerraformResourceTests { }

[Trait("Category", "Integration")]
[Trait("Layer", "Stacks")]
public class TerraformStackTests { }

[Trait("Category", "E2E")]
[Trait("Layer", "Aspire")]
public class TerraformPipelineIntegrationTests { }
```

## 🎨 Snapshot Testing with Verify.Xunit

### Setup and Configuration

All test projects use `Verify.Xunit` for snapshot testing:

```xml
<!-- In test project .csproj -->
<ItemGroup>
  <PackageReference Include="Verify.Xunit" />
</ItemGroup>
```

```csharp
// Global usings (Usings.cs)
global using Xunit;
global using VerifyXunit;
global using VerifyTests;
```

```csharp
// ModuleInitializer.cs - Configure snapshot directory structure
using System.Runtime.CompilerServices;

namespace EmmittJ.Terraform.Sdk.Tests;

internal static class ModuleInitializer
{
    [ModuleInitializer]
    public static void Init()
    {
        DerivePathInfo((sourceFile, projectDirectory, type, method) =>
        {
            return new PathInfo(
                directory: Path.Combine(projectDirectory, "Snapshots", type.Name),
                typeName: type.Name,
                methodName: method.Name);
        });
    }
}
```

### Usage Patterns

```csharp
[UsesVerify]  // Add to test class using snapshot testing
public class MyTests
{
    [Fact]
    public Task TestMethod()  // Return Task for async Verify
    {
        var result = GenerateSomeOutput();
        return Verify(result);  // Snapshot the result
    }

    [Fact]
    public Task TestDirectory()  // Verify entire directory structures
    {
        var outputDir = "/path/to/output";
        return VerifyDirectory(outputDir);
    }
}
```

### Best Practices

1. **Deterministic Output**: Ensure generated HCL is consistent across runs (avoid timestamps, GUIDs)
2. **Readable Snapshots**: Use proper indentation and formatting in generated output
3. **Minimal Snapshots**: Keep test cases focused and small
4. **Version Control**: Commit `.verified.` files with tests
5. **Review Changes**: Carefully review snapshot diffs during updates
6. **Use [UsesVerify]**: Apply attribute to test classes that use snapshot testing
7. **Return Task**: Snapshot test methods should return `Task` from `Verify()` call
8. **Object Initializer Syntax**: Always use C# object initializer syntax for resource properties to improve readability and maintainability

## 🚨 Error Message Testing & Improvements

### Error Message Quality Standards

Every error message should include:

1. **What went wrong**: Clear description of the error
2. **Why it's wrong**: Context about the expected behavior
3. **How to fix it**: Actionable guidance for resolution
4. **Relevant context**: Type names, values, property names, etc.

### Error Message Pattern

```csharp
// ❌ Bad: Generic error
throw new NotSupportedException($"Literal type {typeof(T).Name} is not supported");

// ✅ Good: Actionable error with context
throw new NotSupportedException(
    $"Literal type '{typeof(T).Name}' is not supported for HCL generation. " +
    $"Supported primitive types: string, int, long, short, byte, bool, float, double, decimal. " +
    $"For complex types, use TerraformExpression.Map() for objects or TerraformExpression.List() for collections. " +
    $"Value was: {(_value?.ToString() ?? "null")}"
);
```

### Error Message Test Categories

#### 1. Type Support Errors

Test that unsupported types provide clear guidance:

```csharp
[Fact]
public void LiteralExpression_UnsupportedType_ProvidesActionableError()
{
    var ex = Assert.Throws<NotSupportedException>(() =>
    {
        var value = new CustomClass();
        TerraformValue<CustomClass> tfValue = value;
        var context = TerraformContext.Temporary();
        var nodes = tfValue.ResolveNodes(context).ToList();
        nodes[0].ToHcl(context);
    });

    // Error message should include:
    Assert.Contains("not supported", ex.Message, StringComparison.OrdinalIgnoreCase);
    Assert.Contains("CustomClass", ex.Message); // Type name
    Assert.Contains("TerraformExpression.Map", ex.Message); // Solution
    Assert.Contains("TerraformExpression.List", ex.Message); // Alternative
}
```

#### 2. Missing Required Property Errors

```csharp
[Fact]
public void TerraformResource_MissingRequiredProperty_ShowsHowToFix()
{
    var ex = Assert.Throws<InvalidOperationException>(() =>
    {
        var resource = new TerraformResource("aws_instance", "test");
        // Intentionally don't set required property
        var context = TerraformContext.Temporary();
        resource.ToHcl(context);
    });

    Assert.Contains("Required property", ex.Message);
    Assert.Contains("aws_instance", ex.Message); // Resource type
}
```

#### 3. Resolution Errors

```csharp
[Fact]
public void TerraformValue_MultiNodeResolution_ExplainsExpectation()
{
    var ex = Assert.Throws<InvalidOperationException>(() =>
    {
        var badResolvable = new MultiNodeResolvable();
        TerraformValue<string> value = TerraformValue.FromExpression<string>(badResolvable);
        var context = TerraformContext.Temporary();
        // Attempt to use in context expecting single expression
        var expr = value.ResolveNodes(context).Single();
    });

    Assert.Contains("resolved to", ex.Message);
    Assert.Contains("nodes instead of", ex.Message);
    Assert.Contains("single expression", ex.Message);
}
```

#### 4. Invalid Operation Errors

```csharp
[Fact]
public void TerraformOutput_WithoutValue_ExplainsRequirement()
{
    var ex = Assert.Throws<InvalidOperationException>(() =>
    {
        var output = new TerraformOutput("test_output");
        var context = TerraformContext.Temporary();
        output.ToHcl(context);
    });

    Assert.Contains("must have a value", ex.Message);
    Assert.Contains("test_output", ex.Message); // Output name
    Assert.Contains("Value =", ex.Message); // Shows how to fix
}
```

### Error Message Validation Tests

Create a dedicated test class for error messages using snapshot testing:

```csharp
[Trait("Category", "Unit")]
[Trait("Layer", "ErrorMessages")]
[UsesVerify]
public class ErrorMessageQualityTests
{
    private static ITerraformContext CreateContext() => TerraformContext.Temporary();

    private static Exception GetException(Action action)
    {
        try
        {
            action();
            throw new InvalidOperationException("Expected an exception");
        }
        catch (NotSupportedException ex)
        {
            return ex;
        }
        catch (InvalidOperationException ex)
        {
            return ex;
        }
    }
}
```

**Benefits of Snapshot Testing for Error Messages:**

1. **Consistency**: Ensures error messages don't change unexpectedly
2. **Version Control**: Git diffs clearly show what improved
3. **Review**: Easy to review error message changes in pull requests
4. **Regression Prevention**: Prevents accidental error message degradation
5. **Documentation**: Snapshot files serve as documentation of actual errors

### Common Error Scenarios to Test

1. **Unsupported literal types**: `object`, custom classes, `DateTime`, `Guid`
2. **Missing required properties**: Resources without required attributes
3. **Invalid references**: Circular dependencies, null references
4. **Type mismatches**: Assigning wrong type to TerraformValue<T>
5. **Invalid operations**: Setting values on immutable objects, indexing non-indexable types
6. **Resolution failures**: Multi-node when single expected, null resolvables
7. **HCL generation errors**: Invalid identifiers, unsupported operators
8. **Configuration errors**: Missing terraform block, invalid provider config

### Error Message Documentation

Maintain a reference guide:

````markdown
# Common Error Messages and Solutions

## "Literal type 'X' is not supported"

**Cause**: Attempting to use an unsupported type as a Terraform value

**Solution**:

- For primitives: Use string, int, bool, double, etc.
- For objects: Use `TerraformExpression.Map()`
- For collections: Use `TerraformExpression.List()`

**Example**:

```csharp
// ❌ Wrong
resource["config"] = new MyConfig { Name = "test" };

// ✅ Right
var configMap = TerraformExpression.Map();
configMap["name"] = "test";
resource["config"] = configMap;
```
````

```

## 📈 Coverage Goals

- **Values Layer**: 100% - All types should be tested
- **Expressions Layer**: 95%+ - Cover all expression types and edge cases
- **Blocks Layer**: 90%+ - Cover common patterns and error cases
- **Stack Integration**: 85%+ - Cover typical use cases
- **Aspire Integration**: 80%+ - Cover E2E scenarios

## 🔧 Implementation Plan

### Phase 1: Foundation (Week 1)

- [ ] Create `TerraformValueTests.cs` with primitive type tests
- [ ] Create `TerraformExpressionTests.cs` with literal expression tests
- [ ] Add test traits and categories
- [ ] Set up snapshot testing infrastructure

### Phase 2: Core Coverage (Week 2)

- [ ] Complete value resolution tests for all types
- [ ] Complete expression HCL generation tests
- [ ] Add block HCL generation tests
- [ ] Add stack composition tests

### Phase 3: Integration (Week 3)

- [ ] Add terraform CLI validation tests
- [ ] Enhance Aspire integration tests
- [ ] Add error handling and edge case tests
- [ ] Set up CI/CD test categories

### Phase 4: Polish (Week 4)

- [ ] Improve error messages based on test findings
- [ ] Add performance benchmarks
- [ ] Document common patterns and anti-patterns
- [ ] Create test examples for contributors

## 📚 Related Documentation

- [Architecture Overview](./architecture-overview.md)
- [Values System](./values-system.md)
- [Expressions System](./expressions-system.md)
- [Testing Guidelines](../.github/instructions/tests.instructions.md)
```
