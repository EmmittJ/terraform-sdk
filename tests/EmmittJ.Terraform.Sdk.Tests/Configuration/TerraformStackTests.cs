using EmmittJ.Terraform.Sdk;
using Xunit;

namespace EmmittJ.Terraform.Sdk.Tests.Configuration;

/// <summary>
/// Tests for TerraformStack HCL generation with multiple resources.
/// These tests validate the fourth layer of the SDK: Stack integration
/// </summary>
[Trait("Category", "Integration")]
[Trait("Layer", "Stacks")]
public class TerraformStackTests
{
    [Fact]
    public Task TerraformStack_Empty()
    {
        var stack = new TerraformStack { Name = "empty" };

        var hcl = stack.ToHcl();

        return Verify(hcl);
    }

    [Fact]
    public Task TerraformStack_SingleResource()
    {
        var stack = new TerraformStack { Name = "single" };

        var instance = new TerraformResource("aws_instance", "web")
        {
            ["ami"] = "ami-12345678",
            ["instance_type"] = "t2.micro"
        };

        stack.Add(instance);

        var hcl = stack.ToHcl();

        return Verify(hcl);
    }

    [Fact]
    public Task TerraformStack_MultipleResources()
    {
        var stack = new TerraformStack { Name = "multiple" };

        var vpc = new TerraformResource("aws_vpc", "main")
        {
            ["cidr_block"] = "10.0.0.0/16"
        };

        var subnet = new TerraformResource("aws_subnet", "public")
        {
            ["cidr_block"] = "10.0.1.0/24"
        };

        var instance = new TerraformResource("aws_instance", "web")
        {
            ["ami"] = "ami-12345678",
            ["instance_type"] = "t2.micro"
        };

        stack.Add(vpc);
        stack.Add(subnet);
        stack.Add(instance);

        var hcl = stack.ToHcl();

        return Verify(hcl);
    }

    [Fact]
    public Task TerraformStack_WithReferences()
    {
        var stack = new TerraformStack { Name = "references" };

        var vpc = new TerraformResource("aws_vpc", "main")
        {
            ["cidr_block"] = "10.0.0.0/16",
            ["enable_dns_hostnames"] = true
        };

        var subnet = new TerraformResource("aws_subnet", "public")
        {
            ["vpc_id"] = vpc["id"],
            ["cidr_block"] = "10.0.1.0/24",
            ["availability_zone"] = "us-west-2a"
        };

        var instance = new TerraformResource("aws_instance", "web")
        {
            ["ami"] = "ami-12345678",
            ["instance_type"] = "t2.micro",
            ["subnet_id"] = subnet["id"]
        };

        stack.Add(vpc);
        stack.Add(subnet);
        stack.Add(instance);

        var hcl = stack.ToHcl();

        return Verify(hcl);
    }

    [Fact]
    public Task TerraformStack_WithVariablesAndOutputs()
    {
        var stack = new TerraformStack { Name = "complete" };

        var region = new TerraformVariable("region")
        {
            Type = "string",
            Default = "us-west-2",
            Description = "AWS region"
        };

        var instanceType = new TerraformVariable("instance_type")
        {
            Type = "string",
            Default = "t2.micro",
            Description = "EC2 instance type"
        };

        var instance = new TerraformResource("aws_instance", "web")
        {
            ["ami"] = "ami-12345678",
            ["instance_type"] = TerraformExpression.Raw("var.instance_type"),
            ["tags"] = new TerraformMap<object>
            {
                ["Name"] = "Web Server"
            }
        };

        var instanceId = new TerraformOutput("instance_id")
        {
            Value = instance["id"],
            Description = "The ID of the EC2 instance"
        };

        var instancePublicIp = new TerraformOutput("instance_public_ip")
        {
            Value = instance["public_ip"],
            Description = "The public IP of the EC2 instance"
        };

        stack.Add(region);
        stack.Add(instanceType);
        stack.Add(instance);
        stack.Add(instanceId);
        stack.Add(instancePublicIp);

        var hcl = stack.ToHcl();

        return Verify(hcl);
    }

    [Fact]
    public Task TerraformStack_WithComplexStructure()
    {
        var stack = new TerraformStack { Name = "complex" };

        // VPC
        var vpc = new TerraformResource("aws_vpc", "main")
        {
            ["cidr_block"] = "10.0.0.0/16",
            ["enable_dns_hostnames"] = true,
            ["tags"] = new TerraformMap<object>
            {
                ["Name"] = "Main VPC"
            }
        };

        // Internet Gateway
        var igw = new TerraformResource("aws_internet_gateway", "main")
        {
            ["vpc_id"] = vpc["id"]
        };

        // Public Subnet
        var publicSubnet = new TerraformResource("aws_subnet", "public")
        {
            ["vpc_id"] = vpc["id"],
            ["cidr_block"] = "10.0.1.0/24",
            ["availability_zone"] = "us-west-2a",
            ["map_public_ip_on_launch"] = true,
        };

        // Route Table
        var routeTable = new TerraformResource("aws_route_table", "public")
        {
            ["vpc_id"] = vpc["id"]
        };

        // Route
        var route = new TerraformResource("aws_route", "internet_access")
        {
            ["route_table_id"] = routeTable["id"],
            ["destination_cidr_block"] = "0.0.0.0/0",
            ["gateway_id"] = igw["id"]
        };

        // Security Group
        var securityGroup = new TerraformResource("aws_security_group", "web")
        {
            ["name"] = "web-sg",
            ["vpc_id"] = vpc["id"],
            ["ingress"] = new TerraformList<TerraformMap<object>>(new[]
            {
                new TerraformMap<object>
                {
                    ["from_port"] = 80,
                    ["to_port"] = 80,
                    ["protocol"] = "tcp",
                    ["cidr_blocks"] = new TerraformList<string>(new[] { "0.0.0.0/0" })
                },
                new TerraformMap<object>
                {
                    ["from_port"] = 443,
                    ["to_port"] = 443,
                    ["protocol"] = "tcp",
                    ["cidr_blocks"] = new TerraformList<string>(new[] { "0.0.0.0/0" })
                }
            })
        };

        // EC2 Instance
        var instance = new TerraformResource("aws_instance", "web")
        {
            ["ami"] = "ami-12345678",
            ["instance_type"] = "t2.micro",
            ["subnet_id"] = publicSubnet["id"],
            ["vpc_security_group_ids"] = new TerraformList<object>
            {
                securityGroup["id"]
            }
        };

        stack.Add(vpc);
        stack.Add(igw);
        stack.Add(publicSubnet);
        stack.Add(routeTable);
        stack.Add(route);
        stack.Add(securityGroup);
        stack.Add(instance);

        var hcl = stack.ToHcl();

        return Verify(hcl);
    }

    [Fact]
    public Task TerraformStack_WithMetaArguments()
    {
        var stack = new TerraformStack { Name = "meta" };

        var instance = new TerraformResource("aws_instance", "web")
        {
            ["ami"] = "ami-12345678",
            ["instance_type"] = "t2.micro",
            Count = 3,
            Provider = "aws.us_west_2"
        };

        stack.Add(instance);

        var hcl = stack.ToHcl();

        return Verify(hcl);
    }

    [Fact]
    public Task TerraformStack_WithProviderBlock()
    {
        var stack = new TerraformStack { Name = "provider" };

        var provider = new TerraformProvider("aws")
        {
            ["region"] = "us-west-2",
            ["access_key"] = TerraformExpression.Raw("var.aws_access_key"),
            ["secret_key"] = TerraformExpression.Raw("var.aws_secret_key")
        };

        var instance = new TerraformResource("aws_instance", "web")
        {
            ["ami"] = "ami-12345678",
            ["instance_type"] = "t2.micro"
        };

        stack.Add(provider);
        stack.Add(instance);

        var hcl = stack.ToHcl();

        return Verify(hcl);
    }

    [Fact]
    public Task TerraformStack_WithTerraformSettings()
    {
        var stack = new TerraformStack { Name = "settings" };

        var settings = new TerraformSettings
        {
            RequiredVersion = ">= 1.5.0",
            RequiredProviders = new()
            {
                ProviderRequirements =
                [
                    new("aws")
                    {
                        Source = "hashicorp/aws",
                        Version = "~> 5.0"
                    },
                    new("azurerm")
                    {
                        Source = "hashicorp/azurerm",
                        Version = ">= 3.0"
                    }
                ]
            }
        };

        stack.Add(settings);

        var hcl = stack.ToHcl();

        return Verify(hcl);
    }

    [Fact]
    public Task TerraformStack_WithBackend()
    {
        var stack = new TerraformStack { Name = "backend" };

        var settings = new TerraformSettings
        {
            Backend = new TerraformBackend("s3")
            {
                ["bucket"] = "my-terraform-state",
                ["key"] = "terraform.tfstate",
                ["region"] = "us-west-2",
                ["encrypt"] = true
            }
        };

        stack.Add(settings);

        var hcl = stack.ToHcl();

        return Verify(hcl);
    }

    [Fact]
    public Task TerraformStack_WithModule()
    {
        var stack = new TerraformStack { Name = "module" };

        var vpcModule = new TerraformModule("vpc")
        {
            Source = "terraform-aws-modules/vpc/aws",
            Version = "5.1.0",
            ["name"] = "my-vpc",
            ["cidr"] = "10.0.0.0/16",
            ["azs"] = new TerraformList<string> { "us-west-2a", "us-west-2b", "us-west-2c" },
            ["private_subnets"] = new TerraformList<string> { "10.0.1.0/24", "10.0.2.0/24", "10.0.3.0/24" },
            ["public_subnets"] = new TerraformList<string> { "10.0.101.0/24", "10.0.102.0/24", "10.0.103.0/24" },
            ["enable_nat_gateway"] = true,
            ["enable_vpn_gateway"] = true
        };

        stack.Add(vpcModule);

        var hcl = stack.ToHcl();

        return Verify(hcl);
    }

    [Fact(Skip = "TerraformLocals with SetArgument and Raw expressions needs investigation")]
    public Task TerraformStack_WithLocals()
    {
        var stack = new TerraformStack { Name = "locals" };

        var locals = new TerraformLocals();
        locals.SetArgument("environment", "production");
        locals.SetArgument("region", "us-west-2");
        locals.SetArgument("common_tags", new TerraformMap<object>
        {
            ["Environment"] = TerraformExpression.Raw("local.environment"),
            ["ManagedBy"] = "Terraform",
            ["Project"] = "MyApp"
        });

        var instance = new TerraformResource("aws_instance", "web")
        {
            ["ami"] = "ami-12345678",
            ["instance_type"] = "t2.micro",
            ["tags"] = TerraformExpression.Raw("local.common_tags")
        };

        stack.Add(locals);
        stack.Add(instance);

        var hcl = stack.ToHcl();

        return Verify(hcl);
    }

    [Fact]
    public Task TerraformStack_WithDataSource()
    {
        var stack = new TerraformStack { Name = "datasource" };

        var ami = new TerraformDataSource("aws_ami", "ubuntu")
        {
            ["most_recent"] = true,
            ["filter"] = new TerraformList<TerraformMap<object>>
            {
                new TerraformMap<object>
                {
                    ["name"] = "name",
                    ["values"] = new TerraformList<string> { "ubuntu/images/hvm-ssd/ubuntu-jammy-22.04-amd64-server-*" }
                },
                new TerraformMap<object>
                {
                    ["name"] = "virtualization-type",
                    ["values"] = new TerraformList<string> { "hvm" }
                }
            },
            ["owners"] = new TerraformList<string> { "099720109477" }
        };

        var instance = new TerraformResource("aws_instance", "web")
        {
            ["ami"] = TerraformExpression.Raw("data.aws_ami.ubuntu.id"),
            ["instance_type"] = "t2.micro"
        };

        stack.Add(ami);
        stack.Add(instance);

        var hcl = stack.ToHcl();

        return Verify(hcl);
    }

    [Fact(Skip = "TerraformLocals with SetArgument and Raw expressions needs investigation")]
    public Task TerraformStack_CompleteInfrastructure()
    {
        var stack = new TerraformStack { Name = "complete" };

        // Terraform Settings
        var settings = new TerraformSettings
        {
            RequiredVersion = ">= 1.5.0",
            RequiredProviders = new()
            {
                ProviderRequirements =
                [
                    new("aws")
                    {
                        Source = "hashicorp/aws",
                        Version = "~> 5.0"
                    }
                ]
            },
            Backend = new("s3")
            {
                ["bucket"] = "my-terraform-state",
                ["key"] = "prod/terraform.tfstate",
                ["region"] = "us-west-2"
            }
        };

        // Provider
        var provider = new TerraformProvider("aws")
        {
            ["region"] = TerraformExpression.Raw("var.region")
        };

        // Variables
        var region = new TerraformVariable("region")
        {
            Type = "string",
            Default = "us-west-2"
        };

        var environment = new TerraformVariable("environment")
        {
            Type = "string",
            Default = "production"
        };

        // Locals
        var locals = new TerraformLocals();
        locals.SetArgument("name_prefix", TerraformExpression.Raw("\"${var.environment}-myapp\""));
        locals.SetArgument("common_tags", new TerraformMap<object>
        {
            ["Environment"] = TerraformExpression.Raw("var.environment"),
            ["ManagedBy"] = "Terraform"
        });

        // Data Sources
        var availabilityZones = new TerraformDataSource("aws_availability_zones", "available")
        {
            ["state"] = "available"
        };

        // Module
        var vpcModule = new TerraformModule("vpc")
        {
            Source = "terraform-aws-modules/vpc/aws",
            Version = "5.1.0",
            ["name"] = TerraformExpression.Raw("local.name_prefix"),
            ["cidr"] = "10.0.0.0/16",
            ["azs"] = TerraformExpression.Raw("data.aws_availability_zones.available.names"),
            ["private_subnets"] = new TerraformList<string> { "10.0.1.0/24", "10.0.2.0/24" },
            ["public_subnets"] = new TerraformList<string> { "10.0.101.0/24", "10.0.102.0/24" },
            ["enable_nat_gateway"] = true,
            ["tags"] = TerraformExpression.Raw("local.common_tags")
        };

        // Resources
        var securityGroup = new TerraformResource("aws_security_group", "web")
        {
            ["name"] = TerraformExpression.Raw("\"${local.name_prefix}-web\""),
            ["vpc_id"] = TerraformExpression.Raw("module.vpc.vpc_id"),
            ["ingress"] = new TerraformList<TerraformMap<object>>
            {
                new TerraformMap<object>
                {
                    ["from_port"] = 443,
                    ["to_port"] = 443,
                    ["protocol"] = "tcp",
                    ["cidr_blocks"] = new TerraformList<string> { "0.0.0.0/0" }
                }
            },
            ["tags"] = TerraformExpression.Raw("local.common_tags")
        };

        // Outputs
        var vpcId = new TerraformOutput("vpc_id")
        {
            Value = TerraformExpression.Raw("module.vpc.vpc_id"),
            Description = "The ID of the VPC"
        };

        var securityGroupId = new TerraformOutput("security_group_id")
        {
            Value = TerraformExpression.Raw("aws_security_group.web.id"),
            Description = "The ID of the security group"
        };

        stack.Add(settings);
        stack.Add(provider);
        stack.Add(region);
        stack.Add(environment);
        stack.Add(locals);
        stack.Add(availabilityZones);
        stack.Add(vpcModule);
        stack.Add(securityGroup);
        stack.Add(vpcId);
        stack.Add(securityGroupId);

        var hcl = stack.ToHcl();

        return Verify(hcl);
    }

    [Fact]
    public Task TerraformStack_WithCloudBlock_NamedWorkspace()
    {
        var stack = new TerraformStack { Name = "cloud-named" };

        var settings = new TerraformSettings
        {
            RequiredVersion = ">= 1.5.0",
            Cloud = new TerraformCloudBlock
            {
                Organization = "my-org",
                Hostname = "app.terraform.io",
                Workspaces = new CloudWorkspacesBlock
                {
                    Name = "production-app"
                }
            }
        };

        stack.Add(settings);

        var hcl = stack.ToHcl();

        return Verify(hcl);
    }

    [Fact]
    public Task TerraformStack_WithCloudBlock_TaggedWorkspaces()
    {
        var stack = new TerraformStack { Name = "cloud-tagged" };

        var settings = new TerraformSettings
        {
            RequiredVersion = ">= 1.5.0",
            Cloud = new TerraformCloudBlock
            {
                Organization = "my-org",
                Workspaces = new CloudWorkspacesBlock
                {
                    Tags = new TerraformList<string> { "app", "networking", "production" }
                }
            }
        };

        stack.Add(settings);

        var hcl = stack.ToHcl();

        return Verify(hcl);
    }

    [Fact]
    public Task TerraformStack_WithCloudBlock_ProjectWorkspace()
    {
        var stack = new TerraformStack { Name = "cloud-project" };

        var settings = new TerraformSettings
        {
            RequiredVersion = ">= 1.5.0",
            Cloud = new TerraformCloudBlock
            {
                Organization = "my-org",
                Workspaces = new CloudWorkspacesBlock
                {
                    Name = "my-app",
                    Project = "infrastructure"
                }
            }
        };

        stack.Add(settings);

        var hcl = stack.ToHcl();

        return Verify(hcl);
    }

    [Fact]
    public Task TerraformStack_WithCloudBlock_EnterpriseHostname()
    {
        var stack = new TerraformStack { Name = "cloud-enterprise" };

        var settings = new TerraformSettings
        {
            RequiredVersion = ">= 1.5.0",
            Cloud = new TerraformCloudBlock
            {
                Organization = "enterprise-org",
                Hostname = "terraform.example.com",
                Workspaces = new CloudWorkspacesBlock
                {
                    Tags = new TerraformList<string> { "dev", "staging" },
                    Project = "core-infrastructure"
                }
            }
        };

        stack.Add(settings);

        var hcl = stack.ToHcl();

        return Verify(hcl);
    }

    [Fact]
    public Task TerraformStack_WithCloudBlock_Complete()
    {
        var stack = new TerraformStack { Name = "cloud-complete" };

        var settings = new TerraformSettings
        {
            RequiredVersion = ">= 1.5.0",
            RequiredProviders = new()
            {
                ProviderRequirements =
                [
                    new("aws")
                    {
                        Source = "hashicorp/aws",
                        Version = "~> 5.0"
                    }
                ]
            },
            Cloud = new TerraformCloudBlock
            {
                Organization = "acme-corp",
                Hostname = "app.terraform.io",
                Token = TerraformExpression.Raw("var.tfc_token"),
                Workspaces = new CloudWorkspacesBlock
                {
                    Name = "production-infrastructure",
                    Project = "cloud-platform"
                }
            }
        };

        var provider = new TerraformProvider("aws")
        {
            ["region"] = "us-east-1"
        };

        var instance = new TerraformResource("aws_instance", "app")
        {
            ["ami"] = "ami-12345678",
            ["instance_type"] = "t3.medium"
        };

        stack.Add(settings);
        stack.Add(provider);
        stack.Add(instance);

        var hcl = stack.ToHcl();

        return Verify(hcl);
    }
}
