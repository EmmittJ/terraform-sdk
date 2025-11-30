# EmmittJ.Terraform.Sdk.Providers.Azurerm

Azure RM provider bindings for [EmmittJ.Terraform.Sdk](https://www.nuget.org/packages/EmmittJ.Terraform.Sdk) - strongly-typed C# classes for Azure Terraform resources.

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
var azurerm = stack.Add(new AzurermProvider("azurerm")
{
    ["features"] = new TerraformBlock("features")
});

// Create a resource group
var rg = stack.Add(new AzurermResourceGroup("my-rg")
{
    ["name"] = "my-resource-group",
    ["location"] = "East US"
});

// Generate HCL
Console.WriteLine(stack.ToHcl());
```

## Features

- **Strongly-typed resources**: All Azure RM resources and data sources as C# classes
- **IntelliSense support**: Full autocomplete for resource properties
- **Compile-time safety**: Catch configuration errors before deployment
- **Auto-generated**: Bindings generated from official Terraform AzureRM provider schema

## Documentation

- [EmmittJ.Terraform.Sdk Documentation](https://github.com/EmmittJ/terraform-sdk)
- [Terraform AzureRM Provider Documentation](https://registry.terraform.io/providers/hashicorp/azurerm/latest/docs)
