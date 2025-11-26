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
            ["instance_type"] = instanceType.AsReference(),
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

        var accessKey = new TerraformVariable("aws_access_key")
        {
            Type = "string",
            Description = "AWS Access Key"
        };
        stack.Add(accessKey);

        var secretKey = new TerraformVariable("aws_secret_key")
        {
            Type = "string",
            Description = "AWS Secret Key"
        };
        stack.Add(secretKey);

        var provider = new TerraformProvider("aws")
        {
            ["region"] = "us-west-2",
            ["access_key"] = accessKey.AsReference(),
            ["secret_key"] = secretKey.AsReference()
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

        var settings = new TerraformSettingsBlock
        {
            RequiredVersion = ">= 1.5.0",
            RequiredProviders = new()
            {
                ["aws"] = new ProviderRequirement()
                {
                    Source = "hashicorp/aws",
                    Version = "~> 5.0"
                },
                ["azurerm"] = new ProviderRequirement()
                {
                    Source = "hashicorp/azurerm",
                    Version = ">= 3.0"
                }
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

        var settings = new TerraformSettingsBlock
        {
            Backend = new TerraformBackendBlock("s3")
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

    [Fact]
    public Task TerraformStack_WithLocals()
    {
        var stack = new TerraformStack { Name = "locals" };

        var locals = new TerraformLocals()
        {
            ["environment"] = "production",
            ["region"] = "us-west-2"
        };

        locals["common_tags"] = new TerraformMap<object>
        {
            ["Environment"] = locals["environment"],
            ["ManagedBy"] = "Terraform",
            ["Project"] = "MyApp"
        };

        var instance = new TerraformResource("aws_instance", "web")
        {
            ["ami"] = "ami-12345678",
            ["instance_type"] = "t2.micro",
            ["tags"] = locals["common_tags"]
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
            ["ami"] = ami["id"],
            ["instance_type"] = "t2.micro"
        };

        stack.Add(ami);
        stack.Add(instance);

        var hcl = stack.ToHcl();

        return Verify(hcl);
    }

    [Fact]
    public Task TerraformStack_CompleteInfrastructure()
    {
        var stack = new TerraformStack { Name = "complete" };

        // Terraform Settings
        var settings = new TerraformSettingsBlock
        {
            RequiredVersion = ">= 1.5.0",
            RequiredProviders = new()
            {
                ["aws"] = new ProviderRequirement()
                {
                    Source = "hashicorp/aws",
                    Version = "~> 5.0"
                }
            },
            Backend = new("s3")
            {
                ["bucket"] = "my-terraform-state",
                ["key"] = "prod/terraform.tfstate",
                ["region"] = "us-west-2"
            }
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

        // Provider
        var provider = new TerraformProvider("aws")
        {
            ["region"] = region.AsReference()
        };

        // Locals
        var locals = new TerraformLocals()
        {
            ["name_prefix"] = Tf.Interpolate($"{environment.AsReference()}-myapp"),
            ["common_tags"] = new TerraformMap<object>
            {
                ["Environment"] = environment.AsReference(),
                ["ManagedBy"] = "Terraform"
            }
        };

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
            ["name"] = locals["name_prefix"],
            ["cidr"] = "10.0.0.0/16",
            ["azs"] = availabilityZones["names"],
            ["private_subnets"] = new TerraformList<string> { "10.0.1.0/24", "10.0.2.0/24" },
            ["public_subnets"] = new TerraformList<string> { "10.0.101.0/24", "10.0.102.0/24" },
            ["enable_nat_gateway"] = true,
            ["tags"] = locals["common_tags"]
        };

        // Resources
        var securityGroup = new TerraformResource("aws_security_group", "web")
        {
            ["name"] = Tf.Interpolate($"{locals["name_prefix"]}-web"),
            ["vpc_id"] = vpcModule["vpc_id"],
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
            ["tags"] = locals["common_tags"]
        };

        // Outputs
        var vpcId = new TerraformOutput("vpc_id")
        {
            Value = vpcModule["vpc_id"],
            Description = "The ID of the VPC"
        };

        var securityGroupId = new TerraformOutput("security_group_id")
        {
            Value = securityGroup["id"],
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
    public Task TerraformStack_WithImplicitConversions()
    {
        var stack = new TerraformStack { Name = "implicit-conversions" };

        // Variables can be used directly with .AsReference() or directly where full reference is needed
        var region = new TerraformVariable("region")
        {
            Type = "string",
            Default = "us-west-2"
        };

        var instanceType = new TerraformVariable("instance_type")
        {
            Type = "string",
            Default = "t2.micro"
        };

        // Data sources can be used directly
        var ami = new TerraformDataSource("aws_ami", "ubuntu")
        {
            ["most_recent"] = true,
            ["owners"] = new TerraformList<string> { "099720109477" }
        };

        // Resources can reference each other naturally
        var vpc = new TerraformResource("aws_vpc", "main")
        {
            ["cidr_block"] = "10.0.0.0/16"
        };

        var subnet = new TerraformResource("aws_subnet", "public")
        {
            // Resource attributes accessed via indexer: vpc["id"]
            ["vpc_id"] = vpc["id"],
            ["cidr_block"] = "10.0.1.0/24"
        };

        var instance = new TerraformResource("aws_instance", "web")
        {
            // Data source attributes: ami["id"]
            ["ami"] = ami["id"],
            // Variable reference using implicit conversion
            ["instance_type"] = instanceType.AsReference(),
            // Resource attribute: subnet["id"]
            ["subnet_id"] = subnet["id"],
            ["tags"] = new TerraformMap<object>
            {
                ["Region"] = region.AsReference(),  // Variable reference
                ["Name"] = "Web Server"
            }
        };

        // Outputs can reference resources naturally
        var instanceId = new TerraformOutput("instance_id")
        {
            Value = instance["id"]
        };

        stack.Add(region);
        stack.Add(instanceType);
        stack.Add(ami);
        stack.Add(vpc);
        stack.Add(subnet);
        stack.Add(instance);
        stack.Add(instanceId);

        var hcl = stack.ToHcl();

        return Verify(hcl);
    }

    [Fact]
    public Task TerraformStack_WithCloudBlock_NamedWorkspace()
    {
        var stack = new TerraformStack { Name = "cloud-named" };

        var settings = new TerraformSettingsBlock
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

        var settings = new TerraformSettingsBlock
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

        var settings = new TerraformSettingsBlock
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

        var settings = new TerraformSettingsBlock
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

        var tfcToken = new TerraformVariable("tfc_token")
        {
            Type = "string",
            Description = "Terraform Cloud API Token"
        };
        stack.Add(tfcToken);

        var settings = new TerraformSettingsBlock
        {
            RequiredVersion = ">= 1.5.0",
            RequiredProviders = new()
            {
                ["aws"] = new ProviderRequirement()
                {
                    Source = "hashicorp/aws",
                    Version = "~> 5.0"
                }
            },
            Cloud = new TerraformCloudBlock
            {
                Organization = "acme-corp",
                Hostname = "app.terraform.io",
                Token = tfcToken.AsReference(),
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
