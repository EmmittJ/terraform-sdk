# EmmittJ.Terraform.Sdk.Providers.Random

Random provider bindings for [EmmittJ.Terraform.Sdk](https://www.nuget.org/packages/EmmittJ.Terraform.Sdk) - strongly-typed C# classes for Random Terraform resources.

## Installation

```bash
dotnet add package EmmittJ.Terraform.Sdk.Providers.Random
```

## Usage

```csharp
using EmmittJ.Terraform.Sdk;
using EmmittJ.Terraform.Sdk.Providers.Random;

var stack = new TerraformStack();

// Add Random provider
var provider = stack.Add(new RandomProvider());

// Generate HCL
Console.WriteLine(stack.ToHcl());
```

## Features

- **Strongly-typed resources**: All Random resources and data sources as C# classes
- **IntelliSense support**: Full autocomplete for resource properties
- **Compile-time safety**: Catch configuration errors before deployment
- **Auto-generated**: Bindings generated from official Terraform Random provider schema

## Package Contents

| | |
|---|---|
| **Provider Version** | ~&gt; 3.0 |
| **Resources** | 8 |
| **Data Sources** | 0 |

## Documentation

- [EmmittJ.Terraform.Sdk Documentation](https://github.com/EmmittJ/terraform-sdk)
- [Terraform Random Provider Documentation](https://registry.terraform.io/providers/hashicorp/random/~&gt; 3.0/docs)

