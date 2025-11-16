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
    public Task TerraformResource_Empty_GeneratesCorrectHCL()
    {
        var resource = new TerraformResource("aws_instance", "example");
        var context = TerraformTestHelpers.CreateContext();

        var hcl = TerraformTestHelpers.RenderBlock(resource, context);

        return Verify(hcl).UseMethodName("TerraformResource_Empty");
    }

    [Fact]
    public Task TerraformResource_WithStringProperty_GeneratesCorrectHCL()
    {
        var resource = new TerraformResource("aws_instance", "example");
        resource["ami"] = "ami-12345678";
        resource["instance_type"] = "t2.micro";

        var context = TerraformTestHelpers.CreateContext();
        var hcl = TerraformTestHelpers.RenderBlock(resource, context);

        return Verify(hcl).UseMethodName("TerraformResource_WithStringProperty");
    }

    [Fact]
    public Task TerraformResource_WithNumberProperty_GeneratesCorrectHCL()
    {
        var resource = new TerraformResource("aws_instance", "example");
        resource["count"] = 3;
        resource["volume_size"] = 100;

        var context = TerraformTestHelpers.CreateContext();
        var hcl = TerraformTestHelpers.RenderBlock(resource, context);

        return Verify(hcl).UseMethodName("TerraformResource_WithNumberProperty");
    }

    [Fact]
    public Task TerraformResource_WithBooleanProperty_GeneratesCorrectHCL()
    {
        var resource = new TerraformResource("aws_instance", "example");
        resource["monitoring"] = true;
        resource["ebs_optimized"] = false;

        var context = TerraformTestHelpers.CreateContext();
        var hcl = TerraformTestHelpers.RenderBlock(resource, context);

        return Verify(hcl).UseMethodName("TerraformResource_WithBooleanProperty");
    }

    [Fact]
    public Task TerraformResource_WithListProperty_GeneratesCorrectHCL()
    {
        var resource = new TerraformResource("aws_security_group", "example");
        var ingressMap = new TerraformMapExpression();
        ingressMap.Add("from_port", TerraformExpression.Literal(80));
        ingressMap.Add("to_port", TerraformExpression.Literal(80));
        ingressMap.Add("protocol", TerraformExpression.Literal("tcp"));
        resource["ingress"] = TerraformExpression.List(ingressMap);

        var context = TerraformTestHelpers.CreateContext();
        var hcl = TerraformTestHelpers.RenderBlock(resource, context);

        return Verify(hcl).UseMethodName("TerraformResource_WithListProperty");
    }

    [Fact]
    public Task TerraformResource_WithMapProperty_GeneratesCorrectHCL()
    {
        var resource = new TerraformResource("aws_instance", "example");
        var tagsMap = new TerraformMapExpression();
        tagsMap.Add("Name", TerraformExpression.Literal("Example Instance"));
        tagsMap.Add("Environment", TerraformExpression.Literal("Development"));
        tagsMap.Add("ManagedBy", TerraformExpression.Literal("Terraform"));
        resource["tags"] = tagsMap;

        var context = TerraformTestHelpers.CreateContext();
        var hcl = TerraformTestHelpers.RenderBlock(resource, context);

        return Verify(hcl).UseMethodName("TerraformResource_WithMapProperty");
    }

    [Fact]
    public Task TerraformResource_WithComplexNestedStructure_GeneratesCorrectHCL()
    {
        var resource = new TerraformResource("aws_launch_template", "example");
        resource["name"] = "example-template";
        resource["image_id"] = "ami-12345678";
        resource["instance_type"] = "t2.micro";

        var ebsMap = new TerraformMapExpression();
        ebsMap.Add("volume_size", TerraformExpression.Literal(20));
        ebsMap.Add("volume_type", TerraformExpression.Literal("gp3"));
        ebsMap.Add("encrypted", TerraformExpression.Literal(true));

        var deviceMap = new TerraformMapExpression();
        deviceMap.Add("device_name", TerraformExpression.Literal("/dev/sda1"));
        deviceMap.Add("ebs", ebsMap);

        resource["block_device_mappings"] = TerraformExpression.List(deviceMap);

        var context = TerraformTestHelpers.CreateContext();
        var hcl = TerraformTestHelpers.RenderBlock(resource, context);

        return Verify(hcl).UseMethodName("TerraformResource_WithComplexNestedStructure");
    }

    // TODO: Re-enable after implementing resource output property generation
    // Resources don't auto-generate properties like "id", "public_ip" etc.
    // Need to either:
    // 1. Use TerraformExpression.Raw("aws_vpc.main.id") for references
    // 2. Implement dynamic property generation based on provider schemas
    /*
    [Fact]
    public Task TerraformResource_WithReference_GeneratesCorrectHCL()
    {
        var stack = new TerraformStack { Name = "test" };
        var context = new TerraformContext(stack);

        var vpc = new TerraformResource("aws_vpc", "main");
        vpc["cidr_block"] = "10.0.0.0/16";
        stack.Add(vpc);

        var subnet = new TerraformResource("aws_subnet", "public");
        subnet["vpc_id"] = TerraformExpression.Raw("aws_vpc.main.id");
        subnet["cidr_block"] = "10.0.1.0/24";
        stack.Add(subnet);

        var hcl = TerraformTestHelpers.RenderBlock(subnet, context);

        return Verify(hcl).UseMethodName("TerraformResource_WithReference");
    }
    */

    [Fact]
    public Task TerraformResource_WithMetaArguments_GeneratesCorrectHCL()
    {
        var resource = new TerraformResource("aws_instance", "example");
        resource["ami"] = "ami-12345678";
        resource["instance_type"] = "t2.micro";
        resource.Count = 3;
        resource.DependsOn = new[] { "aws_vpc.main", "aws_subnet.public" };

        var context = TerraformTestHelpers.CreateContext();
        var hcl = TerraformTestHelpers.RenderBlock(resource, context);

        return Verify(hcl).UseMethodName("TerraformResource_WithMetaArguments");
    }
}
