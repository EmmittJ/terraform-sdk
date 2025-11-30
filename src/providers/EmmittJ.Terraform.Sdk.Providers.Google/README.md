# EmmittJ.Terraform.Sdk.Providers.Google

Google Cloud provider bindings for [EmmittJ.Terraform.Sdk](https://www.nuget.org/packages/EmmittJ.Terraform.Sdk) - strongly-typed C# classes for GCP Terraform resources.

## Installation

```bash
dotnet add package EmmittJ.Terraform.Sdk.Providers.Google
```

## Usage

```csharp
using EmmittJ.Terraform.Sdk;
using EmmittJ.Terraform.Sdk.Providers.Google;

var stack = new TerraformStack();

// Add Google provider
var google = stack.Add(new GoogleProvider("google")
{
    ["project"] = "my-gcp-project",
    ["region"] = "us-central1"
});

// Create a Cloud Storage bucket
var bucket = stack.Add(new GoogleStorageBucket("my-bucket")
{
    ["name"] = "my-unique-bucket-name",
    ["location"] = "US"
});

// Generate HCL
Console.WriteLine(stack.ToHcl());
```

## Features

- **Strongly-typed resources**: All Google Cloud resources and data sources as C# classes
- **IntelliSense support**: Full autocomplete for resource properties
- **Compile-time safety**: Catch configuration errors before deployment
- **Auto-generated**: Bindings generated from official Terraform Google provider schema

## Documentation

- [EmmittJ.Terraform.Sdk Documentation](https://github.com/EmmittJ/terraform-sdk)
- [Terraform Google Provider Documentation](https://registry.terraform.io/providers/hashicorp/google/latest/docs)
