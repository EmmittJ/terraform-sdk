# EmmittJ.Terraform.Sdk.Providers.Aws

AWS provider bindings for [EmmittJ.Terraform.Sdk](https://www.nuget.org/packages/EmmittJ.Terraform.Sdk) - strongly-typed C# classes for AWS Terraform resources.

## Installation

```bash
dotnet add package EmmittJ.Terraform.Sdk.Providers.Aws
```

## Usage

```csharp
using EmmittJ.Terraform.Sdk;
using EmmittJ.Terraform.Sdk.Providers.Aws;

var stack = new TerraformStack();

// Add AWS provider
var aws = stack.Add(new AwsProvider("aws")
{
    ["region"] = "us-west-2"
});

// Create an S3 bucket
var bucket = stack.Add(new AwsS3Bucket("my-bucket")
{
    ["bucket"] = "my-unique-bucket-name"
});

// Generate HCL
Console.WriteLine(stack.ToHcl());
```

## Features

- **Strongly-typed resources**: All AWS resources and data sources as C# classes
- **IntelliSense support**: Full autocomplete for resource properties
- **Compile-time safety**: Catch configuration errors before deployment
- **Auto-generated**: Bindings generated from official Terraform AWS provider schema

## Documentation

- [EmmittJ.Terraform.Sdk Documentation](https://github.com/EmmittJ/terraform-sdk)
- [Terraform AWS Provider Documentation](https://registry.terraform.io/providers/hashicorp/aws/latest/docs)
