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
    public Task TerraformStack_Empty_GeneratesCorrectHCL()
    {
        var stack = new TerraformStack { Name = "empty" };

        var hcl = stack.ToHcl();

        return Verify(hcl).UseMethodName("TerraformStack_Empty");
    }

    [Fact]
    public Task TerraformStack_SingleResource_GeneratesCorrectHCL()
    {
        var stack = new TerraformStack { Name = "single" };

        var instance = new TerraformResource("aws_instance", "web");
        instance["ami"] = "ami-12345678";
        instance["instance_type"] = "t2.micro";

        stack.Add(instance);

        var hcl = stack.ToHcl();

        return Verify(hcl).UseMethodName("TerraformStack_SingleResource");
    }

    [Fact]
    public Task TerraformStack_MultipleResources_GeneratesCorrectHCL()
    {
        var stack = new TerraformStack { Name = "multiple" };

        var vpc = new TerraformResource("aws_vpc", "main");
        vpc["cidr_block"] = "10.0.0.0/16";

        var subnet = new TerraformResource("aws_subnet", "public");
        subnet["cidr_block"] = "10.0.1.0/24";

        var instance = new TerraformResource("aws_instance", "web");
        instance["ami"] = "ami-12345678";
        instance["instance_type"] = "t2.micro";

        stack.Add(vpc);
        stack.Add(subnet);
        stack.Add(instance);

        var hcl = stack.ToHcl();

        return Verify(hcl).UseMethodName("TerraformStack_MultipleResources");
    }

    [Fact]
    public Task TerraformStack_WithReferences_GeneratesCorrectHCL()
    {
        var stack = new TerraformStack { Name = "references" };

        var vpc = new TerraformResource("aws_vpc", "main");
        vpc["cidr_block"] = "10.0.0.0/16";
        vpc["enable_dns_hostnames"] = true;

        var subnet = new TerraformResource("aws_subnet", "public");
        subnet["vpc_id"] = vpc["id"];
        subnet["cidr_block"] = "10.0.1.0/24";
        subnet["availability_zone"] = "us-west-2a";

        var instance = new TerraformResource("aws_instance", "web");
        instance["ami"] = "ami-12345678";
        instance["instance_type"] = "t2.micro";
        instance["subnet_id"] = subnet["id"];

        stack.Add(vpc);
        stack.Add(subnet);
        stack.Add(instance);

        var hcl = stack.ToHcl();

        return Verify(hcl).UseMethodName("TerraformStack_WithReferences");
    }

    [Fact]
    public Task TerraformStack_WithVariablesAndOutputs_GeneratesCorrectHCL()
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

        var instance = new TerraformResource("aws_instance", "web");
        instance["ami"] = "ami-12345678";
        instance["instance_type"] = TerraformExpression.Raw("var.instance_type");
        instance["tags"] = new Dictionary<string, string>
        {
            ["Name"] = "Web Server"
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

        return Verify(hcl).UseMethodName("TerraformStack_WithVariablesAndOutputs");
    }

    [Fact]
    public Task TerraformStack_WithComplexStructure_GeneratesCorrectHCL()
    {
        var stack = new TerraformStack { Name = "complex" };

        // VPC
        var vpc = new TerraformResource("aws_vpc", "main");
        vpc["cidr_block"] = "10.0.0.0/16";
        vpc["enable_dns_hostnames"] = true;
        vpc["tags"] = new Dictionary<string, string>
        {
            ["Name"] = "Main VPC"
        };

        // Internet Gateway
        var igw = new TerraformResource("aws_internet_gateway", "main");
        igw["vpc_id"] = vpc["id"];

        // Public Subnet
        var publicSubnet = new TerraformResource("aws_subnet", "public");
        publicSubnet["vpc_id"] = vpc["id"];
        publicSubnet["cidr_block"] = "10.0.1.0/24";
        publicSubnet["availability_zone"] = "us-west-2a";
        publicSubnet["map_public_ip_on_launch"] = true;

        // Route Table
        var routeTable = new TerraformResource("aws_route_table", "public");
        routeTable["vpc_id"] = vpc["id"];

        // Route
        var route = new TerraformResource("aws_route", "internet_access");
        route["route_table_id"] = routeTable["id"];
        route["destination_cidr_block"] = "0.0.0.0/0";
        route["gateway_id"] = igw["id"];

        // Security Group
        var securityGroup = new TerraformResource("aws_security_group", "web");
        securityGroup["name"] = "web-sg";
        securityGroup["vpc_id"] = vpc["id"];
        securityGroup["ingress"] = new[]
        {
            new Dictionary<string, object>
            {
                ["from_port"] = 80,
                ["to_port"] = 80,
                ["protocol"] = "tcp",
                ["cidr_blocks"] = new[] { "0.0.0.0/0" }
            },
            new Dictionary<string, object>
            {
                ["from_port"] = 443,
                ["to_port"] = 443,
                ["protocol"] = "tcp",
                ["cidr_blocks"] = new[] { "0.0.0.0/0" }
            }
        };

        // EC2 Instance
        var instance = new TerraformResource("aws_instance", "web");
        instance["ami"] = "ami-12345678";
        instance["instance_type"] = "t2.micro";
        instance["subnet_id"] = publicSubnet["id"];
        instance["vpc_security_group_ids"] = new[] { securityGroup["id"] };

        stack.Add(vpc);
        stack.Add(igw);
        stack.Add(publicSubnet);
        stack.Add(routeTable);
        stack.Add(route);
        stack.Add(securityGroup);
        stack.Add(instance);

        var hcl = stack.ToHcl();

        return Verify(hcl).UseMethodName("TerraformStack_WithComplexStructure");
    }

    [Fact]
    public Task TerraformStack_WithMetaArguments_GeneratesCorrectHCL()
    {
        var stack = new TerraformStack { Name = "meta" };

        var instance = new TerraformResource("aws_instance", "web");
        instance["ami"] = "ami-12345678";
        instance["instance_type"] = "t2.micro";
        instance.Count = 3;
        instance.Provider = "aws.us_west_2";

        stack.Add(instance);

        var hcl = stack.ToHcl();

        return Verify(hcl).UseMethodName("TerraformStack_WithMetaArguments");
    }

    [Fact]
    public Task TerraformStack_WithProviderBlock_GeneratesCorrectHCL()
    {
        var stack = new TerraformStack { Name = "provider" };

        var provider = new TerraformProvider("aws");
        provider["region"] = "us-west-2";
        provider["access_key"] = TerraformExpression.Raw("var.aws_access_key");
        provider["secret_key"] = TerraformExpression.Raw("var.aws_secret_key");

        var instance = new TerraformResource("aws_instance", "web");
        instance["ami"] = "ami-12345678";
        instance["instance_type"] = "t2.micro";

        stack.Add(provider);
        stack.Add(instance);

        var hcl = stack.ToHcl();

        return Verify(hcl).UseMethodName("TerraformStack_WithProviderBlock");
    }
}
