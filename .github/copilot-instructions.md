# Instructions for GitHub and Visual Studio Copilot

## 📋 Repository Overview

**EmmittJ.Terraform.Sdk** is a .NET library that enables infrastructure-as-code using C# instead of HCL. It provides a strongly-typed API for building Terraform configurations programmatically with compile-time safety and IntelliSense support.

### 🎯 Key Components

- **EmmittJ.Terraform.Sdk**: Core SDK with polymorphic property system, expression trees, and HCL generation
- **EmmittJ.Terraform.Sdk.Providers.\***: Auto-generated provider-specific resources (AWS, Azure, GCP)
- **EmmittJ.Terraform.Sdk.SourceGenerators**: Roslyn source generators for meta-arguments and properties
- **EmmittJ.Terraform.Sdk.AppHost**: Code generation using Aspire to generate provider bindings
- **EmmittJ.Aspire.Hosting.Terraform**: Integration with Aspire for deployment scenarios

### 🛠️ Technology Stack

- **.NET 10.0** (specified in `global.json`) - preview features enabled
- **C# 14** with preview features
- **Source Generators** for compile-time code generation
- **Verify** and **xUnit** for testing with Verify.Xunit for snapshot testing
- **Aspire** for code generation orchestration
- **Central Package Management** via `Directory.Packages.props`

## 🔧 General Development Guidelines

### Code Style & Formatting

- ✅ Follow `.editorconfig` rules strictly
- ✅ Use **file-scoped namespace declarations** (`namespace EmmittJ.Terraform.Sdk;`)
- ✅ **Preview C# 14 features** are enabled - use modern patterns
- ✅ Insert newline before opening braces of code blocks
- ✅ Use **pattern matching** and **switch expressions** wherever possible
- ✅ Use `nameof` instead of string literals for member names
- ✅ Place private class declarations at the bottom of files
- ✅ Final return statement should be on its own line
- ❌ **Never modify** `global.json` unless explicitly requested
- ❌ **Never modify** `Directory.Packages.props` unless explicitly requested
- ❌ **Never modify** `NuGet.config` unless explicitly requested

### Nullable Reference Types

- ✅ Declare variables **non-nullable by default**
- ✅ Check for `null` at entry points
- ✅ Always use `is null` or `is not null` instead of `== null` or `!= null`
- ✅ **Trust the C# null annotations** - don't add redundant null checks when the type system guarantees non-null
- ❌ **Do NOT disable** nullable reference types
- ❌ **Do NOT use** the null-forgiving operator (`!`) unless absolutely necessary

### XML Documentation

- ✅ **All public APIs must have XML documentation** (`/// <summary>`)
- ✅ Document parameters, return values, exceptions, and type parameters
- ✅ Include code examples in `<example>` tags for complex APIs
- ✅ Reference related types using `<see cref="TypeName"/>` and `<seealso cref="TypeName"/>`
- ✅ Use proper grammar and complete sentences
- ✅ Follow the patterns in existing code (e.g., `Tf.cs`, `TerraformStack.cs`)

### Naming Conventions

- ✅ **Public classes** must start with or contain **"Terraform"** (e.g., `TerraformResource`, `TerraformBlock`, `TerraformExpression`)
- ✅ **Public interfaces** must start with **"ITerraform"** or contain **"Terraform"** (e.g., `ITerraformResolvable`, `ITerraformContext`, `ITerraformSerializable`)
- ✅ This makes it immediately clear which types are part of the public Terraform SDK API
- ❌ **Do NOT create** public classes or interfaces that don't follow this naming pattern
- ❌ **Do NOT use** generic names like `Value`, `Block`, `Expression` without the "Terraform" prefix

## 🏗️ Architecture Principles

### Polymorphic Value System

The SDK uses a **polymorphic type system** with `TerraformValue<T>` to avoid null reference exceptions and runtime type checking:

```csharp
// ✅ Good - polymorphic dispatch, type-safe
public class TerraformValue<T> : ITerraformValue
{
    protected readonly ITerraformResolvable? _resolvable;

    public TerraformExpression Resolve(ITerraformContext context)
    {
        return _resolvable.Resolve(context);
    }

    // Implicit conversion from literal values
    public static implicit operator TerraformValue<T>(T value)
        => new TerraformValue<T>(new TerraformLiteralValue<T>(value));
}

// ❌ Avoid - runtime switching on types
public class Property
{
    public object? Value { get; set; }
    public PropertyType Type { get; set; }
}
```

**Key Benefits**:

- No null reference exceptions - each class only has needed fields
- Compile-time type safety via generic `TerraformValue<T>`
- No runtime type checking or switching
- Implicit conversions for ergonomic API (literals → `TerraformValue<T>`)
- Lazy evaluation support via `ITerraformResolvable`

### Two-Phase Resolution System

Inspired by Terraform CDK and AWS CDK, the SDK uses **two-pass compilation**:

1. **Prepare Phase**: Collect dependencies, track references, validate structure
2. **Resolve Phase**: Generate HCL expressions and output

```csharp
// ✅ Implement ITerraformPreparable for blocks that need dependency tracking
public class TerraformResource : TerraformBlock, ITerraformPreparable
{
    public void Prepare(ITerraformContext ctx)
    {
        // Register dependencies, validate references
    }

    public override TerraformExpression Resolve(ITerraformContext ctx)
    {
        // Generate HCL expression
    }
}
```

### Expression Tree Design

Terraform configurations are represented as **immutable expression trees**:

- `TerraformExpression`: Abstract base for all HCL syntax nodes
- Compositional building - expressions compose into larger expressions
- No knowledge of types/values at expression level
- Easy to validate, transform, and optimize

```csharp
// ✅ Build expressions compositionally
var vpc = TerraformExpression.Identifier("aws_vpc.main");
var attr = TerraformExpression.AttributeAccess(vpc, "id");
var ref = TerraformExpression.Reference(attr);
```

## 🧪 Testing Guidelines

### Test Organization

- Tests mirror the `src/` structure in `tests/`
- Use xUnit with Verify.Xunit for snapshot testing
- Test files should end with `Tests.cs` (e.g., `TerraformResourceTests.cs`)
- See `tests/TEST_INVENTORY.md` for comprehensive test categorization

### Test Style

- ❌ **Do NOT emit** "Arrange", "Act", or "Assert" comments
- ✅ Copy existing style from nearby test files for naming and capitalization
- ✅ Use descriptive test method names that explain what's being tested
- ❌ **Do NOT leave newly-added tests commented out** - all tests should build and pass
- ❌ **Do NOT use** `Directory.SetCurrentDirectory()` - causes side effects in concurrent execution

### Running Tests

**Prerequisites**: Build first with `dotnet build` from repository root

```powershell
# Run all tests in a specific project (exclude long-running tests)
dotnet test tests/EmmittJ.Terraform.Sdk.Tests/EmmittJ.Terraform.Sdk.Tests.csproj

# Run a specific test
dotnet test tests/EmmittJ.Terraform.Sdk.Tests/EmmittJ.Terraform.Sdk.Tests.csproj --filter "FullyQualifiedName~TerraformResourceTests.CanCreateBasicResource"

# Run tests by class name
dotnet test tests/EmmittJ.Terraform.Sdk.Tests/EmmittJ.Terraform.Sdk.Tests.csproj --filter "ClassName~TerraformResourceTests"
```

### Snapshot Testing with Verify

- Snapshot files are stored in `Snapshots/` directories within test projects
- After updating tests that generate new output, accept snapshots:
  ```powershell
  dotnet verify accept -y
  ```
- The `verify` tool is available globally as part of the development setup

## 🔨 Building the SDK

### Initial Setup

```powershell
# Restore packages and set up local SDK
dotnet restore

# Build the entire solution
dotnet build

# Build in release mode
dotnet build -c Release

# Clean and rebuild
dotnet clean
dotnet build
```

### Code Generation

Provider bindings are **auto-generated** from Terraform provider schemas using the AppHost project:

```powershell
# Generate provider code for all configured providers
aspire publish

# The AppHost project (EmmittJ.Terraform.Sdk.AppHost) orchestrates:
# 1. Downloading provider schemas from Terraform Registry
# 2. Parsing schema JSON
# 3. Generating C# resource/data source classes
# 4. Generating provider configuration classes
```

**Generated Code Locations**:

- `src/providers/EmmittJ.Terraform.Sdk.Providers.Aws/` - AWS resources
- `src/providers/EmmittJ.Terraform.Sdk.Providers.AzureRM/` - Azure resources
- `src/providers/EmmittJ.Terraform.Sdk.Providers.Google/` - GCP resources

**Important**: Do NOT manually edit generated provider code - it will be overwritten on next generation.

## 🎨 Terraform SDK Patterns

### Creating Resources

```csharp
// ✅ Preferred: Map indexer syntax (current API)
var vpc = new TerraformResource("aws_vpc", "main")
{
    ["cidr_block"] = "10.0.0.0/16",
    ["enable_dns_hostnames"] = true
}
```

### References Between Resources

```csharp
var vpc = new TerraformResource("aws_vpc", "main")
{
    ["cidr_block"] = "10.0.0.0/16"
}

var subnet = new TerraformResource("aws_subnet", "public")
{
    ["vpc_id"] = vpc["id"], // Creates "${aws_vpc.main.id}"
    ["cidr_block"] = "10.0.1.0/24"

}
```

### Using the Tf Helper Class

The `Tf` class provides Terraform built-in functions and type helpers:

```csharp
// Type constraints
var stringType = Tf.Types.String;
var listOfStrings = Tf.Types.List(Tf.Types.String);
var mapOfNumbers = Tf.Types.Map(Tf.Types.Number);

// Built-in functions (when implemented)
var joined = Tf.Join(",", ["a", "b", "c"]);
var base64 = Tf.Base64Encode("hello");
```

### Stack Composition

```csharp
var stack = new TerraformStack { Name = "my-infrastructure" };

// Add terraform settings block
stack.Terraform = new TerraformSettings
{
    RequiredVersion = ">= 1.9.0"
};

// Add provider
var awsProvider = new TerraformProvider("aws")
{
    ["region"] = "us-west-2"
};
stack.Add(awsProvider);

// Add resources
stack.Add(vpc);
stack.Add(subnet);

// Generate HCL
string hcl = stack.ToHcl();
```

## 🔍 Common Development Tasks

### Adding a New Block Type

1. Create class inheriting from `TerraformBlock`
2. Implement `ITerraformTopLevelBlock` if it's a top-level block
3. Override `Resolve()` to return appropriate `TerraformExpression`
4. Implement `AsReference()` if the block can be referenced (or if it can't throw `InvalidOperationException`)
5. Add XML documentation
6. Add comprehensive tests

### Adding Source Generator Features

- Source generators are in `src/EmmittJ.Terraform.Sdk.SourceGenerators/`
- Use incremental source generators for performance
- Follow Roslyn best practices for diagnostics and error handling
- Test thoroughly - source generator bugs are hard to debug

### Extending Provider Support

Providers are generated via the AppHost. To add a new provider:

1. Edit `src/EmmittJ.Terraform.Sdk.AppHost/AppHost.cs`
2. Add provider using `builder.AddTerraformProvider()`
3. Run `aspire publish` to generate bindings
4. Verify generated code compiles

## 📦 Package Publishing

- ✅ Version is controlled by `Directory.Build.props`: `<VersionPrefix>0.1.0</VersionPrefix>`
- ✅ CI/CD automatically manages version suffixes and publishing
- ❌ **Do NOT manually create NuGet packages** unless testing locally
- ❌ **Do NOT manually create git tags** - automated by CI/CD

## 🚨 Common Pitfalls to Avoid

### Breaking Changes

- Note: We are in pre-1.0.0, so breaking changes are allowed but should be minimized.
- ❌ Changing public API signatures without versioning
- ❌ Removing public types, methods, or properties
- ❌ Changing expression tree structure in non-backward-compatible ways
- ✅ Mark obsolete APIs with `[Obsolete("Reason", error: false)]`
- ✅ Provide migration guidance in XML docs

### Performance

- ❌ Lazy evaluation without caching (implement `ITerraformResolvable` properly)
- ❌ String concatenation in loops (use `StringBuilder`)
- ❌ Repeated LINQ queries on the same collection (materialize once)
- ✅ Use `stackalloc` for small temporary buffers
- ✅ Use `ValueTask` for potentially synchronous operations

### Terraform Semantics

- ❌ Generating invalid HCL syntax
- ❌ Allowing circular dependencies between resources
- ❌ Violating Terraform's evaluation order requirements
- ✅ Validate generated HCL against `terraform validate`
- ✅ Test with real Terraform CLI when adding new features

## 🌐 Terraform-Specific Best Practices

### HCL Generation

- ✅ Use proper indentation (2 spaces per level)
- ✅ Quote string values, don't quote identifiers
- ✅ Generate valid Terraform references (`${resource.name.attribute}`)
- ✅ Escape special characters in strings
- ❌ Don't generate unnecessary whitespace

### Meta-Arguments

Meta-arguments (`count`, `for_each`, `depends_on`, `provider`, `lifecycle`) have special handling:

```csharp
// ✅ Use interfaces for meta-argument support
public class TerraformResource : TerraformBlock,
    ITerraformHasCount,
    ITerraformHasForEach,
    ITerraformHasDependsOn,
    ITerraformHasProvider,
    ITerraformHasLifecycle
{
    // Meta-arguments are generated by source generators
}
```

### Provider Schema Compatibility

- ✅ Generated providers should match Terraform Registry schemas exactly
- ✅ Support all provider versions specified in generation config
- ✅ Handle optional vs required attributes correctly
- ❌ Don't make assumptions about provider behavior

## 🔗 Integration with Aspire

The `EmmittJ.Aspire.Hosting.Terraform` library enables Terraform deployments in Aspire:

```csharp
var builder = DistributedApplication.CreateBuilder(args);

var terraform = builder.AddTerraformEnvironment("terraform")
    .WithBackend("s3", backend =>
    {
        backend["bucket"] = "my-state";
        backend["region"] = "us-west-2";
    });

var api = builder.AddProject<Projects.Api>("api")
    .PublishAsTerraform((stack, resource) =>
    {
        // Customize Terraform infrastructure
    });
```

**Key Points**:

- Only operates during `aspire publish` (not `dotnet run`)
- Generates `main.tf` files in output directory
- Integrates with Aspire's deployment pipeline
- Supports multiple cloud providers (AWS, Azure, GCP)

## 📚 Additional Resources

- **Terraform Documentation**: https://developer.hashicorp.com/terraform
- **Terraform CDK**: https://developer.hashicorp.com/terraform/cdktf (similar concepts)
- **Terraform Registry**: https://registry.terraform.io/ (provider schemas)
- **Repository**: https://github.com/EmmittJ/terraform-sdk

## 🎓 Learning the Codebase

### Start Here

1. `src/EmmittJ.Terraform.Sdk/Tf.cs` - Main helper class
2. `src/EmmittJ.Terraform.Sdk/Configuration/TerraformStack.cs` - Stack/infrastructure container
3. `src/EmmittJ.Terraform.Sdk/Blocks/TerraformResource.cs` - Resource implementation
4. `src/EmmittJ.Terraform.Sdk/Expressions/TerraformExpression.cs` - Expression tree base
5. `README.md` files in each project directory

### Key Concepts to Understand

- **Polymorphic values** - Type-safe value representation via `TerraformValue<T>`
- **Two-phase resolution** - Prepare → Resolve pattern
- **Expression trees** - Compositional HCL generation
- **Reference system** - Inter-resource dependencies
- **Source generation** - Compile-time code generation

## ✨ When Making Changes

1. ✅ **Read** the existing code patterns before writing new code
2. ✅ **Follow** the architecture principles outlined above
3. ✅ **Test** your changes thoroughly with unit and integration tests
4. ✅ **Document** public APIs with XML comments
5. ✅ **Validate** generated HCL with `terraform validate` when applicable
6. ✅ **Update** README.md files if adding significant features
7. ❌ **Don't** create summary/overview files unless requested
8. ❌ **Don't** commit changes without building and testing first

---

**Remember**: This SDK is infrastructure-as-code for .NET developers. Prioritize type safety, developer experience, and alignment with Terraform semantics.
