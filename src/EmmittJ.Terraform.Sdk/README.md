# EmmittJ.Terraform.Sdk

**Infrastructure as C#** - Define Terraform configurations using strongly-typed C# with compile-time safety and IntelliSense support.

See the main [README](../../README.md) for installation, comprehensive documentation, and examples.

## Quick Start

```csharp
using EmmittJ.Terraform.Sdk;

// Create a stack
var stack = new TerraformStack { Name = "my-infrastructure" };

// Configure Terraform settings
stack.Terraform = new TerraformSettingsBlock
{
    RequiredVersion = ">= 1.9.0"
};

// Add AWS provider
var awsProvider = new TerraformProvider("aws")
{
    ["region"] = "us-west-2"
};
stack.Add(awsProvider);

// Create resources with indexer syntax
var vpc = new TerraformResource("aws_vpc", "main")
{
    ["cidr_block"] = "10.0.0.0/16",
    ["enable_dns_hostnames"] = true,
    ["enable_dns_support"] = true
};
stack.Add(vpc);

// Reference the VPC in a subnet - type-safe!
var subnet = new TerraformResource("aws_subnet", "public")
{
    ["vpc_id"] = vpc["id"],  // Generates: aws_vpc.main.id
    ["cidr_block"] = "10.0.1.0/24",
    ["availability_zone"] = "us-west-2a"
};
stack.Add(subnet);

// Generate HCL
string hcl = stack.ToHcl();
Console.WriteLine(hcl);
```

## Key Concepts

### Resource References (Indexer Syntax)

Access resource attributes using the indexer - generates correct HCL references:

```csharp
var vpc = new TerraformResource("aws_vpc", "main") { ["cidr_block"] = "10.0.0.0/16" };
var subnet = new TerraformResource("aws_subnet", "public")
{
    ["vpc_id"] = vpc["id"]  // Generates: aws_vpc.main.id
};
```

### Variables and Outputs

```csharp
// Input variable
var region = new TerraformVariable("region")
{
    Type = Tf.Types.String,
    Default = "us-west-2",
    Description = "AWS region"
};

// Output
var vpcIdOutput = new TerraformOutput("vpc_id")
{
    Value = vpc["id"],
    Description = "The ID of the VPC"
};
```

### Variable References (AsReference)

Reference entire variable values:

```csharp
var region = new TerraformVariable("region") { Default = "us-west-2" };
var provider = new TerraformProvider("aws")
{
    ["region"] = region.AsReference()  // Generates: var.region
};
```

### Data Sources

```csharp
var ami = new TerraformDataSource("aws_ami", "ubuntu")
{
    ["most_recent"] = true,
    ["owners"] = new TerraformList<string> { "099720109477" }
};

var instance = new TerraformResource("aws_instance", "web")
{
    ["ami"] = ami["id"]  // Generates: data.aws_ami.ubuntu.id
};
```

### Modules

```csharp
var vpcModule = new TerraformModule("vpc")
{
    Source = "terraform-aws-modules/vpc/aws",
    Version = "5.1.0",
    ["name"] = "my-vpc",
    ["cidr"] = "10.0.0.0/16"
};

var instance = new TerraformResource("aws_instance", "web")
{
    ["subnet_id"] = vpcModule["public_subnets"][0]  // Generates: module.vpc.public_subnets[0]
};
```

## Quick Reference

| Block Type            | How to Reference         | Example                | Generates                |
| --------------------- | ------------------------ | ---------------------- | ------------------------ |
| Resource attribute    | `resource["attr"]`       | `vpc["id"]`            | `aws_vpc.main.id`        |
| Data source attribute | `dataSource["attr"]`     | `ami["id"]`            | `data.aws_ami.ubuntu.id` |
| Module output         | `module["output"]`       | `vpcModule["vpc_id"]`  | `module.vpc.vpc_id`      |
| Variable              | `variable.AsReference()` | `region.AsReference()` | `var.region`             |
| Local value           | `locals["name"]`         | `locals["region"]`     | `local.region`           |

## Architecture Documentation

For detailed architecture documentation, see:

- [Architecture Overview](../../docs/architecture-overview.md) - Complete system architecture
- [Values System](../../docs/values-system.md) - Polymorphic value system
- [Expressions System](../../docs/expressions-system.md) - Expression composition
- [Syntax System](../../docs/syntax-system.md) - HCL rendering

## Feedback & Contributing

https://github.com/EmmittJ/terraform-sdk
