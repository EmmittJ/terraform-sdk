using EmmittJ.Terraform.Sdk;
using EmmittJ.Terraform.Sdk.Tests.TestHelpers;
using Xunit;

namespace EmmittJ.Terraform.Sdk.Tests.Blocks;

/// <summary>
/// Tests for TerraformVariable HCL generation.
/// </summary>
[Trait("Category", "Integration")]
[Trait("Layer", "Blocks")]
public class TerraformVariableTests
{
    [Fact]
    public Task TerraformVariable_WithStringType_GeneratesCorrectHCL()
    {
        var variable = new TerraformVariable("region")
        {
            Type = "string",
            Default = "us-west-2",
            Description = "AWS region"
        };

        var context = TerraformTestHelpers.CreateContext();
        var hcl = TerraformTestHelpers.RenderBlock(variable, context);

        return Verify(hcl).UseMethodName("TerraformVariable_WithStringType");
    }

    [Fact]
    public Task TerraformVariable_WithNumberType_GeneratesCorrectHCL()
    {
        var variable = new TerraformVariable("instance_count")
        {
            Type = "number",
            Default = 3,
            Description = "Number of instances to create"
        };

        var context = TerraformTestHelpers.CreateContext();
        var hcl = TerraformTestHelpers.RenderBlock(variable, context);

        return Verify(hcl).UseMethodName("TerraformVariable_WithNumberType");
    }

    [Fact]
    public Task TerraformVariable_WithBoolType_GeneratesCorrectHCL()
    {
        var variable = new TerraformVariable("enable_monitoring")
        {
            Type = "bool",
            Default = true,
            Description = "Enable CloudWatch monitoring"
        };

        var context = TerraformTestHelpers.CreateContext();
        var hcl = TerraformTestHelpers.RenderBlock(variable, context);

        return Verify(hcl).UseMethodName("TerraformVariable_WithBoolType");
    }

    [Fact]
    public Task TerraformVariable_WithListType_GeneratesCorrectHCL()
    {
        var variable = new TerraformVariable("availability_zones");
        variable.Type = "list(string)";
        variable.Default = TerraformExpression.List(
            TerraformExpression.Literal("us-west-2a"),
            TerraformExpression.Literal("us-west-2b"),
            TerraformExpression.Literal("us-west-2c")
        );

        var context = TerraformTestHelpers.CreateContext();
        var hcl = TerraformTestHelpers.RenderBlock(variable, context);

        return Verify(hcl).UseMethodName("TerraformVariable_WithListType");
    }

    [Fact]
    public Task TerraformVariable_WithMapType_GeneratesCorrectHCL()
    {
        var variable = new TerraformVariable("tags");
        variable.Type = "map(string)";
        var tagsMap = new TerraformMapExpression();
        tagsMap.Add("Environment", TerraformExpression.Literal("Production"));
        tagsMap.Add("Team", TerraformExpression.Literal("Platform"));
        variable.Default = tagsMap;

        var context = TerraformTestHelpers.CreateContext();
        var hcl = TerraformTestHelpers.RenderBlock(variable, context);

        return Verify(hcl).UseMethodName("TerraformVariable_WithMapType");
    }

    [Fact]
    public Task TerraformVariable_WithoutDefault_GeneratesCorrectHCL()
    {
        var variable = new TerraformVariable("secret_key")
        {
            Type = "string",
            Description = "Secret key (no default for security)",
            Sensitive = true
        };

        var context = TerraformTestHelpers.CreateContext();
        var hcl = TerraformTestHelpers.RenderBlock(variable, context);

        return Verify(hcl).UseMethodName("TerraformVariable_WithoutDefault");
    }

    [Fact]
    public Task TerraformVariable_WithValidation_GeneratesCorrectHCL()
    {
        var variable = new TerraformVariable("instance_type")
        {
            Type = "string",
            Default = "t2.micro",
            Description = "EC2 instance type"
        };

        variable.AddValidation(
            condition: "contains([\"t2.micro\", \"t2.small\", \"t2.medium\"], var.instance_type)",
            errorMessage: "Instance type must be t2.micro, t2.small, or t2.medium"
        );

        var context = TerraformTestHelpers.CreateContext();
        var hcl = TerraformTestHelpers.RenderBlock(variable, context);

        return Verify(hcl).UseMethodName("TerraformVariable_WithValidation");
    }
}
