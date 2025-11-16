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
}
