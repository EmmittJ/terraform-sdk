# Instructions for GitHub and Visual Studio Copilot

## 📋 Repository Overview

**EmmittJ.Terraform.Sdk** is a .NET library that enables infrastructure-as-code using C# instead of HCL. It provides a strongly-typed API for building Terraform configurations programmatically with compile-time safety and IntelliSense support.

### 🎯 Key Components

- **EmmittJ.Terraform.Sdk**: Core SDK with polymorphic property system, compositional expression API, and HCL generation
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

**For comprehensive architecture documentation, see:**

- `docs/architecture-overview.md` - Complete system architecture
- `docs/values-system.md` - Polymorphic value system details
- `docs/expressions-system.md` - Expression composition patterns
- `docs/syntax-system.md` - HCL rendering and syntax nodes

### Three-Layer Architecture

The SDK transforms C# code to HCL through three layers:

1. **Values Layer** (`TerraformValue<T>`) - Type-safe value storage with polymorphic dispatch
2. **Expressions Layer** (`TerraformExpression`) - Compositional HCL syntax builders
3. **Syntax Layer** (`TerraformSyntaxNode`) - Direct HCL output representation

```csharp
// Values resolve to expressions, which render as syntax nodes
TerraformValue<string> region = "us-west-2";  // Values layer
    ↓ ResolveNodes()
TerraformExpression.Literal("us-west-2")      // Expressions layer
    ↓ ToHcl(context)
"\"us-west-2\""                               // Syntax layer (HCL output)
```

### Two-Phase Resolution System

Inspired by Terraform CDK and AWS CDK:

1. **Prepare Phase**: Track dependencies, validate structure, build dependency graph
2. **Resolve Phase**: Generate syntax nodes, sort by dependencies, render to HCL

```csharp
// References automatically track dependencies during Prepare
subnet["vpc_id"] = vpc["id"];  // Records: subnet depends on vpc

// Resolution ensures correct ordering
stack.ToHcl();  // VPC rendered before Subnet
```

### Key Design Principles

- **Polymorphic dispatch** - Avoid runtime type checking, use interfaces
- **Immutability** - Objects don't change after creation
- **Type safety** - Compile-time validation via `TerraformValue<T>`
- **Composition** - Build complex structures from simple pieces
- **Lazy evaluation** - Defer computation until resolution phase

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

### Values System (`TerraformValue<T>`)

Polymorphic value storage providing type safety and implicit conversions:

```csharp
// Literals - automatic wrapping
TerraformValue<string> region = "us-west-2";
TerraformValue<int> count = 3;

// References - automatic dependency tracking
TerraformValue<string> vpcId = vpc["id"];

// Lazy evaluation - deferred computation
var value = TerraformValue<string>.Lazy(ctx =>
    condition ? TerraformExpression.Literal("a") : TerraformExpression.Literal("b")
);
```

**Key Points:**

- `TerraformValue<T>` where `T` is the **Terraform type** (string, double, bool)
- Values resolve to `TerraformExpression` nodes during resolution
- Collections: `TerraformList<T>`, `TerraformMap<T>`, `TerraformSet<T>`
- See `docs/values-system.md` for complete details

### Expressions System (`TerraformExpression`)

Compositional syntax builders for HCL constructs:

```csharp
// Literals and identifiers
TerraformExpression.Literal("us-west-2")
TerraformExpression.Identifier("var.region")

// Collections
TerraformExpression.List("a", "b", "c")
TerraformExpression.Object()  // Map/object

// Composition
TerraformExpression.Conditional(isProd, "prod-value", "dev-value")
TerraformExpression.Interpolate("prefix-", variable, "-suffix")
TerraformExpression.ForList(collection, item => item["id"])

// Operators (overloaded)
var sum = expr1 + expr2;
var name = vpc["id"];
```

**Key Points:**

- Expressions are **type-agnostic** - type safety happens at `TerraformValue<T>` level
- Immutable and compositional
- Expressions ARE syntax nodes (extend `TerraformSyntaxNode`)
- See `docs/expressions-system.md` for complete details

### Syntax System (`TerraformSyntaxNode`)

Direct HCL rendering layer:

```csharp
// Argument nodes (key = value)
new TerraformArgumentNode("region", TerraformExpression.Literal("us-west-2"))
// → region = "us-west-2"

// Block nodes (nested blocks)
new TerraformBlockNode("tags", children)
// → tags { ... }

// Top-level blocks (resources, providers, etc.)
new TerraformTopLevelBlockNode("resource", ["aws_vpc", "main"], children)
// → resource "aws_vpc" "main" { ... }
```

**Key Points:**

- Syntax nodes know how to render themselves to HCL
- Context provides indentation management
- Automatic node ordering (meta-arguments first, alphabetical properties)
- See `docs/syntax-system.md` for complete details

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
- ❌ Changing expression node structure in non-backward-compatible ways
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

## 📋 Task Tracking with Todo Lists

For complex, multi-step work, use the `todos` tool to maintain visibility and ensure steady progress:

### ✅ When to Create a Todo List

- **Multi-Step Work**: Tasks requiring multiple sequential or parallel steps
- **Complex Requests**: When breaking down ambiguous or complex user requests
- **Multiple Tasks**: When users provide numbered lists or comma-separated tasks
- **Long-Running Work**: Tasks that require checkpoints for feedback and validation

### ❌ When NOT to Create a Todo List

- **Simple Operations**: Single-step tasks that can be completed directly (e.g., reading a file, quick edits)
- **Trivial Requests**: Purely conversational or informational requests

### 💡 Todo List Best Practices

- **Break Down Work**: Create specific, actionable items that can be tracked and verified
- **Update Status Consistently**: Mark tasks as `in-progress` when starting, `completed` immediately after finishing
- **One Task at a Time**: Only mark one todo as `in-progress` at a time
- **Complete Incrementally**: Mark todos completed as soon as they're done; don't batch completions
- **Provide Context**: Include detailed descriptions with story number, file paths, methods, or acceptance criteria

## 🤖 Task Delegation with runSubagent

When working on a task, you may encounter subtasks that are out of context or require extensive searching/research. Use the `runSubagent` tool to delegate these to a specialized agent:

### ✅ When to Use runSubagent

- **Out-of-Context Searches**: When you need to search for code patterns, files, or information unrelated to your current focus
- **Complex Research**: When gathering information requires multiple search iterations and you're not confident you'll find the right match immediately
- **Multi-Step Discovery**: When the subtask involves exploring unfamiliar parts of the codebase
- **Parallel Work**: When you need information that doesn't block your current progress

### ❌ When NOT to Use runSubagent

- **Simple, direct tasks**: Reading a known file, making a straightforward edit
- **Current context**: When the information is already available or directly related to your current work
- **Quick lookups**: Single file searches or grep operations with clear patterns

### 💡 Delegation Best Practices

- **Be Specific**: Provide detailed instructions about what the agent should find and return
- **Define Output**: Clearly specify what information the agent should report back
- **State Intent**: Tell the agent whether to do research only or to make changes
- **Trust Results**: Agent outputs should generally be trusted as they have full context for their subtask

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
4. `src/EmmittJ.Terraform.Sdk/Expressions/TerraformExpression.cs` - Compositional expression API
5. `README.md` files in each project directory

### Key Concepts to Understand

- **Polymorphic values** - Type-safe value representation via `TerraformValue<T>`
- **Two-phase resolution** - Prepare → Resolve pattern
- **Compositional AST** - Expression nodes that build HCL syntax
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
