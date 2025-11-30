# EmmittJ.Terraform.Sdk.Providers.Google

Google Cloud provider bindings for [EmmittJ.Terraform.Sdk](https://www.nuget.org/packages/EmmittJ.Terraform.Sdk) - strongly-typed C# classes for Google Cloud Terraform resources.

## Installation

```bash
dotnet add package EmmittJ.Terraform.Sdk.Providers.Google
```

## Usage

```csharp
using EmmittJ.Terraform.Sdk;
using EmmittJ.Terraform.Sdk.Providers.Google;

var stack = new TerraformStack();

// Add Google Cloud provider
var provider = stack.Add(new GoogleProvider());

// Generate HCL
Console.WriteLine(stack.ToHcl());
```

## Features

- **Strongly-typed resources**: All Google Cloud resources and data sources as C# classes
- **IntelliSense support**: Full autocomplete for resource properties
- **Compile-time safety**: Catch configuration errors before deployment
- **Auto-generated**: Bindings generated from official Terraform Google Cloud provider schema

## Package Contents

| | |
|---|---|
| **Provider Version** | ~&gt; 7.0 |
| **Resources** | 1125 |
| **Data Sources** | 387 |

## Documentation

- [EmmittJ.Terraform.Sdk Documentation](https://github.com/EmmittJ/terraform-sdk)
- [Terraform Google Cloud Provider Documentation](https://registry.terraform.io/providers/hashicorp/google/~&gt; 7.0/docs)

