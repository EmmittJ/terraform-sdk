using EmmittJ.Terraform.Sdk;
using EmmittJ.Terraform.Sdk.Tests.TestHelpers;
using Xunit;

namespace EmmittJ.Terraform.Sdk.Tests.Blocks;

/// <summary>
/// Tests for TerraformResource HCL generation.
/// These tests validate the third layer of the SDK: Blocks → HCL
/// </summary>
[Trait("Category", "Integration")]
[Trait("Layer", "Blocks")]
public class TerraformResourceTests
{
    [Fact]
    public Task TerraformResource_Empty()
    {
        var resource = new TerraformResource("aws_instance", "example");
        var context = TerraformTestHelpers.CreateContext();

        var hcl = TerraformTestHelpers.RenderBlock(resource, context);

        return Verify(hcl);
    }

    [Fact]
    public Task TerraformResource_WithStringProperty()
    {
        var resource = new TerraformResource("aws_instance", "example")
        {
            ["ami"] = "ami-12345678",
            ["instance_type"] = "t2.micro"
        };

        var context = TerraformTestHelpers.CreateContext();
        var hcl = TerraformTestHelpers.RenderBlock(resource, context);

        return Verify(hcl);
    }

    [Fact]
    public Task TerraformResource_WithNumberProperty()
    {
        var resource = new TerraformResource("aws_instance", "example")
        {
            ["count"] = 3,
            ["volume_size"] = 100
        };

        var context = TerraformTestHelpers.CreateContext();
        var hcl = TerraformTestHelpers.RenderBlock(resource, context);

        return Verify(hcl);
    }

    [Fact]
    public Task TerraformResource_WithBooleanProperty()
    {
        var resource = new TerraformResource("aws_instance", "example")
        {
            ["monitoring"] = true,
            ["ebs_optimized"] = false
        };

        var context = TerraformTestHelpers.CreateContext();
        var hcl = TerraformTestHelpers.RenderBlock(resource, context);

        return Verify(hcl);
    }

    [Fact]
    public Task TerraformResource_WithListProperty()
    {
        var ingressMap = new TerraformMapExpression();
        ingressMap.Add("from_port", TerraformExpression.Literal(80));
        ingressMap.Add("to_port", TerraformExpression.Literal(80));
        ingressMap.Add("protocol", TerraformExpression.Literal("tcp"));

        var resource = new TerraformResource("aws_security_group", "example")
        {
            ["ingress"] = TerraformExpression.List(ingressMap)
        };

        var context = TerraformTestHelpers.CreateContext();
        var hcl = TerraformTestHelpers.RenderBlock(resource, context);

        return Verify(hcl);
    }

    [Fact]
    public Task TerraformResource_WithMapProperty()
    {
        var tagsMap = new TerraformMapExpression();
        tagsMap.Add("Name", TerraformExpression.Literal("Example Instance"));
        tagsMap.Add("Environment", TerraformExpression.Literal("Development"));
        tagsMap.Add("ManagedBy", TerraformExpression.Literal("Terraform"));

        var resource = new TerraformResource("aws_instance", "example")
        {
            ["tags"] = tagsMap
        };

        var context = TerraformTestHelpers.CreateContext();
        var hcl = TerraformTestHelpers.RenderBlock(resource, context);

        return Verify(hcl);
    }

    [Fact]
    public Task TerraformResource_WithComplexNestedStructure()
    {
        var ebsMap = new TerraformMapExpression();
        ebsMap.Add("volume_size", TerraformExpression.Literal(20));
        ebsMap.Add("volume_type", TerraformExpression.Literal("gp3"));
        ebsMap.Add("encrypted", TerraformExpression.Literal(true));

        var deviceMap = new TerraformMapExpression();
        deviceMap.Add("device_name", TerraformExpression.Literal("/dev/sda1"));
        deviceMap.Add("ebs", ebsMap);

        var resource = new TerraformResource("aws_launch_template", "example")
        {
            ["name"] = "example-template",
            ["image_id"] = "ami-12345678",
            ["instance_type"] = "t2.micro",
            ["block_device_mappings"] = TerraformExpression.List(deviceMap)
        };

        var context = TerraformTestHelpers.CreateContext();
        var hcl = TerraformTestHelpers.RenderBlock(resource, context);

        return Verify(hcl);
    }

    // TODO: Re-enable after implementing resource output property generation
    // Resources don't auto-generate properties like "id", "public_ip" etc.
    // Need to either:
    // 1. Use vpc["id"] for references
    // 2. Implement dynamic property generation based on provider schemas
    [Fact]
    public Task TerraformResource_WithReference()
    {
        var stack = new TerraformStack { Name = "test" };
        var context = new TerraformContext(stack);

        var vpc = new TerraformResource("aws_vpc", "main")
        {
            ["cidr_block"] = "10.0.0.0/16"
        };
        stack.Add(vpc);

        var subnet = new TerraformResource("aws_subnet", "public")
        {
            ["vpc_id"] = vpc["id"],
            ["cidr_block"] = "10.0.1.0/24"
        };
        stack.Add(subnet);

        var hcl = TerraformTestHelpers.RenderBlock(subnet, context);

        return Verify(hcl);
    }

    [Fact]
    public Task TerraformResource_WithMetaArguments()
    {
        var resource = new TerraformResource("aws_instance", "example")
        {
            ["ami"] = "ami-12345678",
            ["instance_type"] = "t2.micro",
            Count = 3,
            DependsOn = new[] { "aws_vpc.main", "aws_subnet.public" }
        };

        var context = TerraformTestHelpers.CreateContext();
        var hcl = TerraformTestHelpers.RenderBlock(resource, context);

        return Verify(hcl);
    }
}
