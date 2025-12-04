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

- **.NET 10.0 SDK** with C# 14 preview features (specified in `global.json`)
- **Target frameworks**: .NET 10.0
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
- ❌ **Do NOT use** the null-forgiving operator (`!`) trust the compiler annotations

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

```csharp
// References generate correct HCL identifiers
subnet["vpc_id"] = vpc["id"];  // Resolves to: aws_vpc.main.id

// Resolution generates valid HCL
stack.ToHcl();  // Both resources rendered with correct references
```

### Key Design Principles

- **Polymorphic dispatch** - Avoid runtime type checking, use interfaces
- **Immutability** - Objects don't change after creation
- **Type safety** - Compile-time validation via `TerraformValue<T>`
- **Composition** - Build complex structures from simple pieces
- **Lazy evaluation** - Defer computation until resolution phase

## 📂 Path-Specific Instructions

Detailed instructions for specific areas of the codebase are in separate files:

- **Core SDK** (`src/EmmittJ.Terraform.Sdk/**`): See `.github/copilot-instructions-src-sdk.md`
- **Testing** (`tests/**`): See `.github/copilot-instructions-tests.md`
- **AppHost/Code Generation** (`src/EmmittJ.Terraform.Sdk.AppHost/**`): See `.github/copilot-instructions-apphost.md`
- **Source Generators** (`src/EmmittJ.Terraform.Sdk.SourceGenerators/**`): See `.github/copilot-instructions-sourcegenerators.md`
- **Aspire Integration** (`src/EmmittJ.Aspire.Hosting.Terraform/**`): See `.github/copilot-instructions-aspire.md`

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

## 📦 Package Publishing

- ✅ Version is controlled by `Directory.Build.props`: `<VersionPrefix>0.1.0</VersionPrefix>`
- ✅ CI/CD automatically manages version suffixes and publishing
- ❌ **Do NOT manually create NuGet packages** unless testing locally
- ❌ **Do NOT manually create git tags** - automated by CI/CD

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
- **Resolution system** - Single-pass resolution to HCL
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
