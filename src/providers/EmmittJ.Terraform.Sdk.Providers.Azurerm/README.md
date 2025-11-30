# EmmittJ.Terraform.Sdk.Providers.Azurerm

Azure RM provider bindings for [EmmittJ.Terraform.Sdk](https://www.nuget.org/packages/EmmittJ.Terraform.Sdk) - strongly-typed C# classes for Azure RM Terraform resources.

## Installation

```bash
dotnet add package EmmittJ.Terraform.Sdk.Providers.Azurerm
```

## Usage

```csharp
using EmmittJ.Terraform.Sdk;
using EmmittJ.Terraform.Sdk.Providers.Azurerm;

var stack = new TerraformStack();

// Add Azure RM provider
var provider = stack.Add(new AzurermProvider());

// Generate HCL
Console.WriteLine(stack.ToHcl());
```

## Features

- **Strongly-typed resources**: All Azure RM resources and data sources as C# classes
- **IntelliSense support**: Full autocomplete for resource properties
- **Compile-time safety**: Catch configuration errors before deployment
- **Auto-generated**: Bindings generated from official Terraform Azure RM provider schema

## Package Contents

| | |
|---|---|
| **Provider Version** | ~&gt; 4.0 |
| **Resources** | 1120 |
| **Data Sources** | 399 |

## Documentation

- [EmmittJ.Terraform.Sdk Documentation](https://github.com/EmmittJ/terraform-sdk)
- [Terraform Azure RM Provider Documentation](https://registry.terraform.io/providers/hashicorp/azurerm/~&gt; 4.0/docs)

