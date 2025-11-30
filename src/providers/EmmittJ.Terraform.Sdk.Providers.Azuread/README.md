# EmmittJ.Terraform.Sdk.Providers.Azuread

Azure AD provider bindings for [EmmittJ.Terraform.Sdk](https://www.nuget.org/packages/EmmittJ.Terraform.Sdk) - strongly-typed C# classes for Azure AD Terraform resources.

## Installation

```bash
dotnet add package EmmittJ.Terraform.Sdk.Providers.Azuread
```

## Usage

```csharp
using EmmittJ.Terraform.Sdk;
using EmmittJ.Terraform.Sdk.Providers.Azuread;

var stack = new TerraformStack();

// Add Azure AD provider
var provider = stack.Add(new AzureadProvider());

// Generate HCL
Console.WriteLine(stack.ToHcl());
```

## Features

- **Strongly-typed resources**: All Azure AD resources and data sources as C# classes
- **IntelliSense support**: Full autocomplete for resource properties
- **Compile-time safety**: Catch configuration errors before deployment
- **Auto-generated**: Bindings generated from official Terraform Azure AD provider schema

## Package Contents

| | |
|---|---|
| **Provider Version** | ~&gt; 3.0 |
| **Resources** | 53 |
| **Data Sources** | 20 |

## Documentation

- [EmmittJ.Terraform.Sdk Documentation](https://github.com/EmmittJ/terraform-sdk)
- [Terraform Azure AD Provider Documentation](https://registry.terraform.io/providers/hashicorp/azuread/~&gt; 3.0/docs)

