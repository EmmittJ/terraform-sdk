# EmmittJ.Terraform.Sdk

**Infrastructure as C#** - Define Terraform configurations using strongly-typed C# with compile-time safety and IntelliSense support.

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET 10](https://img.shields.io/badge/.NET-10.0-purple.svg)](https://dotnet.microsoft.com/download)
[![Version](https://img.shields.io/badge/version-0.1.0--preview-blue.svg)](https://github.com/EmmittJ/terraform-sdk)

## 🚀 Overview

The EmmittJ Terraform SDK is a .NET library that enables infrastructure-as-code using C# instead of HCL. It provides a strongly-typed API for building Terraform configurations programmatically with compile-time safety, IntelliSense support, and the full power of .NET.

**Key Features:**

- 🔒 **Type-safe** - Compile-time validation using C# type system
- 🎯 **Polymorphic value system** - No null reference exceptions, automatic type inference
- 📝 **IntelliSense support** - Full IDE support with documentation
- 🏛️ **Compositional AST** - Build complex HCL from simple expression nodes
- 🌐 **Multi-cloud** - AWS, Azure, GCP support via auto-generated providers
- 🔌 **Aspire integration** - Deploy infrastructure with .NET Aspire

## 📦 Installation

Add the core SDK package to your project:

```bash
dotnet add package EmmittJ.Terraform.Sdk
```

Add provider packages as needed:

```bash
dotnet add package EmmittJ.Terraform.Sdk.Providers.Aws
dotnet add package EmmittJ.Terraform.Sdk.Providers.AzureRM
dotnet add package EmmittJ.Terraform.Sdk.Providers.Google
```

## 🎯 Quick Start

### Basic Resource Creation

```csharp
using EmmittJ.Terraform.Sdk;
using EmmittJ.Terraform.Sdk.Configuration;
using EmmittJ.Terraform.Sdk.Blocks;

var stack = new TerraformStack { Name = "my-infrastructure" };

// Configure Terraform settings
stack.Terraform = new TerraformSettings
{
    RequiredVersion = ">= 1.9.0"
};

// Add AWS provider
var awsProvider = new TerraformProvider("aws")
{
    ["region"] = "us-west-2"
};
stack.Add(awsProvider);

// Create a VPC
var vpc = new TerraformResource("aws_vpc", "main")
{
    ["cidr_block"] = "10.0.0.0/16",
    ["enable_dns_hostnames"] = true,
    ["enable_dns_support"] = true
};
stack.Add(vpc);

// Create a subnet referencing the VPC
var subnet = new TerraformResource("aws_subnet", "public")
{
    ["vpc_id"] = vpc["id"],
    ["cidr_block"] = "10.0.1.0/24",
    ["availability_zone"] = "us-west-2a"
};
stack.Add(subnet);

// Generate HCL
string hcl = stack.ToHcl();
Console.WriteLine(hcl);
```

### Output Example

```hcl
terraform {
  required_version = ">= 1.9.0"
}

provider "aws" {
  region = "us-west-2"
}

resource "aws_vpc" "main" {
  cidr_block           = "10.0.0.0/16"
  enable_dns_hostnames = true
  enable_dns_support   = true
}

resource "aws_subnet" "public" {
  vpc_id            = aws_vpc.main.id
  cidr_block        = "10.0.1.0/24"
  availability_zone = "us-west-2a"
}
```

## 🏗️ Architecture

The SDK uses a **three-layer architecture** to transform C# into HCL:

### 1. Values Layer - Type-Safe Storage

The polymorphic value system provides compile-time type safety and eliminates null reference exceptions:

```csharp
// Type-safe values that can be literals, references, or expressions
TerraformValue<string> region = "us-west-2";           // Literal
TerraformValue<string> vpcId = vpc["id"];              // Reference
TerraformValue<int> count = 3;                         // Literal
TerraformValue<string> name = Tf.Join("-", ["app"]);  // Expression
```

**Features:**

- Implicit conversions from literals
- Automatic dependency tracking via references
- Lazy evaluation support
- Collections: `TerraformList<T>`, `TerraformMap<T>`, `TerraformSet<T>`

### 2. Expressions Layer - Compositional Syntax

Immutable expression nodes that compose into larger structures:

```csharp
// Build complex expressions compositionally
var name = TerraformExpression.Conditional(
    isProd,
    TerraformExpression.Interpolate("prod-", baseName),
    TerraformExpression.Interpolate("dev-", baseName)
);

// Use Terraform functions
var tags = TerraformExpression.ForList(users, user => user["email"]);
var combined = Tf.Join(",", ["a", "b", "c"]);
```

**Features:**

- Type-agnostic syntax representation
- Operator overloading (`+`, `-`, `*`, `/`, `[]`)
- String interpolation, conditionals, for expressions
- Terraform built-in functions

### 3. Syntax Layer - HCL Rendering

Direct representation of HCL output elements:

```csharp
// Syntax nodes render to HCL
new TerraformArgumentNode("region", TerraformExpression.Literal("us-west-2"))
// → region = "us-west-2"

new TerraformBlockNode("tags", children)
// → tags { ... }
```

**Features:**

- Context-aware indentation
- Automatic node ordering (meta-arguments first)
- Self-rendering nodes

### Resolution System

The SDK uses a single-pass resolution approach to generate HCL:

```csharp
// References generate correct HCL identifiers
subnet["vpc_id"] = vpc["id"];  // Resolves to: aws_vpc.main.id

// Resolution generates valid HCL
stack.ToHcl();  // VPC and Subnet both rendered with correct references
```

**For detailed architecture documentation, see:**

- `docs/architecture-overview.md` - Complete system architecture
- `docs/values-system.md` - Polymorphic value system
- `docs/expressions-system.md` - Expression composition
- `docs/syntax-system.md` - HCL rendering

## 🔧 Advanced Features

### Using Terraform Functions

The `Tf` class provides access to Terraform built-in functions:

```csharp
// String manipulation
var joined = Tf.Join(",", ["a", "b", "c"]);
var encoded = Tf.Base64Encode("hello");

// Type constraints
var stringType = Tf.Types.String;
var listOfStrings = Tf.Types.List(Tf.Types.String);
var mapOfNumbers = Tf.Types.Map(Tf.Types.Number);
```

### Variables and Outputs

```csharp
// Define input variables
var region = new TerraformVariable("region")
{
    Type = Tf.Types.String,
    Default = "us-west-2",
    Description = "AWS region for resources"
};
stack.Add(region);

// Define outputs
var vpcIdOutput = new TerraformOutput("vpc_id")
{
    Value = vpc["id"],
    Description = "The ID of the VPC"
};
stack.Add(vpcIdOutput);
```

### Dynamic Blocks

Create dynamic nested blocks using the `.AsDynamic()` API:

```csharp
var settings = new TerraformVariable("settings");
var settingsRef = TerraformValue.FromExpression<object>(settings.AsReference());

// Create dynamic block
var dynamicBlock = new TerraformDynamicBlock("setting", settingsRef);
dynamicBlock.Content.SetArgument("key", TerraformExpression.Identifier("setting.value.key"));
dynamicBlock.Content.SetArgument("value", TerraformExpression.Identifier("setting.value.value"));

resource.SetDynamicBlock("setting", dynamicBlock);
```

### Meta-Arguments

All standard Terraform meta-arguments are supported:

```csharp
var servers = new TerraformResource("aws_instance", "server")
{
    ["ami"] = "ami-12345678",
    ["instance_type"] = "t2.micro",
    Count = 3,  // Create 3 instances
    DependsOn = [vpc, subnet]
};
```

## 🌐 Aspire Integration

Deploy Terraform infrastructure as part of your Aspire applications:

```csharp
var builder = DistributedApplication.CreateBuilder(args);

// Add Terraform environment
var terraform = builder.AddTerraformEnvironment("terraform")
    .WithBackend("s3", backend =>
    {
        backend["bucket"] = "my-terraform-state";
        backend["region"] = "us-west-2";
        backend["key"] = "terraform.tfstate";
    });

// Publish project with Terraform infrastructure
var api = builder.AddProject<Projects.ApiService>("api")
    .PublishAsTerraform((stack, resource) =>
    {
        // Customize infrastructure for API deployment
        var container = new TerraformResource("azurerm_container_app", "api")
        {
            ["name"] = resource.Name,
            ["container_app_environment_id"] = environment.AsReference()
        };
        stack.Add(container);
    });
```

Run `aspire publish` to generate and deploy Terraform infrastructure.

## 🔨 Development

### Prerequisites

- [.NET 10.0 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) (RC or later)
- C# 14 with preview features enabled
- (Optional) [Aspire workload](https://learn.microsoft.com/dotnet/aspire/fundamentals/setup-tooling) for code generation

### Building from Source

```bash
# Clone the repository
git clone https://github.com/EmmittJ/terraform-sdk.git
cd terraform-sdk

# Restore packages
dotnet restore

# Build the solution
dotnet build

# Run tests
dotnet test
```

### Code Generation

Provider bindings are auto-generated from Terraform provider schemas:

```bash
# Generate provider code for all configured providers
aspire publish
```

This generates:

- Provider configuration classes (`AwsProvider`, `AzureRMProvider`, etc.)
- Resource classes for all Terraform resources
- Data source classes for all Terraform data sources

Generated code locations:

- `src/providers/EmmittJ.Terraform.Sdk.Providers.Aws/` - AWS resources
- `src/providers/EmmittJ.Terraform.Sdk.Providers.AzureRM/` - Azure resources
- `src/providers/EmmittJ.Terraform.Sdk.Providers.Google/` - GCP resources

**Important:** Do not manually edit generated provider code - it will be overwritten on next generation.

### Testing

The project uses xUnit and Verify for testing:

```bash
# Run all tests
dotnet test

# Run tests for a specific project
dotnet test tests/EmmittJ.Terraform.Sdk.Tests/

# Run a specific test
dotnet test --filter "FullyQualifiedName~TerraformResourceTests.CanCreateBasicResource"

# Accept snapshot changes (after reviewing)
dotnet verify accept -y
```

## 📂 Project Structure

- **EmmittJ.Terraform.Sdk** - Core SDK with polymorphic property system, compositional expression API, and HCL generation
- **EmmittJ.Terraform.Sdk.Providers.\*** - Auto-generated provider-specific resources (AWS, Azure, GCP)
- **EmmittJ.Terraform.Sdk.SourceGenerators** - Roslyn source generators for meta-arguments and properties
- **EmmittJ.Terraform.Sdk.AppHost** - Code generation using Aspire to generate provider bindings
- **EmmittJ.Aspire.Hosting.Terraform** - Integration with Aspire for deployment scenarios

## 🛠️ Technology Stack

- **.NET 10.0** with preview features enabled
- **C# 14** with preview features
- **Source Generators** for compile-time code generation
- **Verify** and **xUnit** for testing with snapshot testing
- **Aspire** for code generation orchestration
- **Central Package Management** for consistent versioning

## 🤝 Contributing

Contributions are welcome! Please read the development guidelines in [`.github/copilot-instructions.md`](.github/copilot-instructions.md) for:

- Code style and formatting rules
- Architecture principles
- Testing guidelines
- Common development patterns

### Key Principles

- Follow `.editorconfig` rules strictly
- Use file-scoped namespace declarations
- Enable nullable reference types
- Document all public APIs with XML comments
- Trust the polymorphic type system - avoid runtime type checking
- Write comprehensive tests with snapshots

## 📚 Additional Resources

- [GitHub Repository](https://github.com/EmmittJ/terraform-sdk)
- [Terraform Documentation](https://developer.hashicorp.com/terraform)
- [Terraform Registry](https://registry.terraform.io/)
- [.NET Aspire Documentation](https://learn.microsoft.com/dotnet/aspire/)

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🙏 Acknowledgments

Inspired by [Terraform CDK](https://developer.hashicorp.com/terraform/cdktf) and [AWS CDK](https://aws.amazon.com/cdk/).

- [AWS CDK](https://aws.amazon.com/cdk/) - Compositional AST and construct patterns
- [Pulumi](https://www.pulumi.com/) - Infrastructure as code with real programming languages

---

**Status:** Pre-1.0.0 preview - APIs may change. Breaking changes are minimized but possible.

**Version:** 0.1.0-preview

Made with ❤️ for .NET and Infrastructure-as-Code
