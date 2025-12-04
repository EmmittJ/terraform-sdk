using EmmittJ.Terraform.Sdk;
using EmmittJ.Terraform.Sdk.Tests.TestHelpers;
using Xunit;

namespace EmmittJ.Terraform.Sdk.Tests.Blocks;

/// <summary>
/// Tests for TerraformOutput HCL generation.
/// </summary>
[Trait("Category", "Integration")]
[Trait("Layer", "Blocks")]
public class TerraformOutputTests
{
    [Fact]
    public Task TerraformOutput_WithLiteralValue()
    {
        var output = new TerraformOutput("example_output")
        {
            Value = "example-value",
            Description = "An example output"
        };

        var context = TerraformTestHelpers.CreateContext();
        var hcl = TerraformTestHelpers.RenderBlock(output, context);

        return Verify(hcl);
    }

    [Fact]
    public Task TerraformOutput_WithResourceReference()
    {
        var stack = new TerraformStack { Name = "test" };
        var context = new TerraformContext(stack);

        var instance = new TerraformResource("aws_instance", "example")
        {
            ["ami"] = "ami-12345678"
        };
        stack.Add(instance);

        var output = new TerraformOutput("instance_id")
        {
            Value = instance.AsReference("id"),
            Description = "The ID of the EC2 instance"
        };

        var hcl = TerraformTestHelpers.RenderBlock(output, context);

        return Verify(hcl);
    }

    [Fact]
    public Task TerraformOutput_Sensitive()
    {
        var output = new TerraformOutput("database_password")
        {
            Value = "super-secret-password",
            Description = "Database password",
            Sensitive = true
        };

        var context = TerraformTestHelpers.CreateContext();
        var hcl = TerraformTestHelpers.RenderBlock(output, context);

        return Verify(hcl);
    }

    [Fact]
    public Task TerraformOutput_WithComplexValue()
    {
        var detailsMap = new TerraformMapExpression();
        detailsMap.Add("id", TerraformExpression.Literal("i-1234567890abcdef0"));
        detailsMap.Add("type", TerraformExpression.Literal("t2.micro"));
        detailsMap.Add("state", TerraformExpression.Literal("running"));

        var output = new TerraformOutput("instance_details")
        {
            Value = detailsMap
        };

        var context = TerraformTestHelpers.CreateContext();
        var hcl = TerraformTestHelpers.RenderBlock(output, context);

        return Verify(hcl);
    }

    [Fact]
    public Task TerraformOutput_WithDependsOn()
    {
        var output = new TerraformOutput("vpc_id")
        {
            Value = "vpc-12345",
            DependsOn = new[] { "aws_vpc.main", "aws_subnet.public" }
        };

        var context = TerraformTestHelpers.CreateContext();
        var hcl = TerraformTestHelpers.RenderBlock(output, context);

        return Verify(hcl);
    }
}
