# EmmittJ Terraform SDK Documentation

Welcome to the EmmittJ Terraform SDK documentation!

## Overview

The EmmittJ Terraform SDK is a .NET library that allows you to define Terraform infrastructure as code using C#. It provides a strongly-typed, fluent API for building Terraform configurations programmatically.

## Getting Started

To get started with the Terraform SDK, add a reference to the `EmmittJ.Terraform.Sdk` package in your project:

```bash
dotnet add package EmmittJ.Terraform.Sdk
```

### Quick Example

```csharp
using EmmittJ.Terraform.Sdk;
using EmmittJ.Terraform.Sdk.Providers.Aws.Resources;

var stack = new TerraformStack();

// Define a VPC
var vpc = new AwsVpc("main-vpc")
{
    CidrBlock = "10.0.0.0/16",
    EnableDnsHostnames = true,
    EnableDnsSupport = true
};

stack.Add(vpc);

// Generate HCL
var hcl = stack.ToHclString();
Console.WriteLine(hcl);
```

## Project Structure

- **EmmittJ.Terraform.Sdk** - Core SDK library with base types and HCL generation
- **EmmittJ.Terraform.Sdk.Providers.\*** - Provider-specific resource definitions
  - `Providers.Aws` - AWS provider resources
  - `Providers.AzureRM` - Azure Resource Manager provider
  - `Providers.AzureAD` - Azure Active Directory provider
  - `Providers.Google` - Google Cloud Platform provider
- **EmmittJ.Aspire.Hosting.Terraform** - Integration with .NET Aspire for hosting scenarios

## Documentation Pages

- [API Reference](./api/README.md) _(coming soon)_
- [Providers](./providers.md) _(coming soon)_
- [Aspire Integration](./aspire-integration.md) _(coming soon)_
- [Contributing](../CONTRIBUTING.md) _(coming soon)_

## Additional Resources

- [GitHub Repository](https://github.com/EmmittJ/terraform-sdk)
- [Sample Projects](../samples/)
- [Tests](../tests/) - Test examples showing various usage patterns

## License

This project is licensed under the MIT License - see the [LICENSE](../LICENSE) file for details.
