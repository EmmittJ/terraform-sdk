namespace EmmittJ.Terraform.Sdk.Tests;

// Note: ForExpression and StringInterpolationExpression are internal types
// and cannot be tested directly from the test project.
// They are exercised through public APIs like Tf.For and string interpolation operators.
// This file tests other expression types with low coverage.

public class TerraformExpressionPublicTests
{
    [Fact]
    public async Task ConditionalExpression_TernaryOperator_GeneratesCorrectHcl()
    {
        var stack = new TerraformStack { Name = "test" };
        var variable = new TerraformVariable("enabled") { Type = "bool" };
        stack.Add(variable);

        var output = new TerraformOutput("result")
        {
            Value = TerraformExpression.Conditional(
                variable.AsReference(),
                TerraformExpression.Literal("yes"),
                TerraformExpression.Literal("no")
            )
        };
        stack.Add(output);

        var hcl = stack.ToHcl();

        await Verify(hcl).UseMethodName("ConditionalExpression_TernaryOperator");
    }

    [Fact]
    public async Task MemberAccessExpression_ChainedAccess_GeneratesCorrectHcl()
    {
        var stack = new TerraformStack { Name = "test" };
        var resource = new TerraformResource("aws_vpc", "main");
        resource["cidr_block"] = "10.0.0.0/16";
        stack.Add(resource);

        var output = new TerraformOutput("vpc_id")
        {
            Value = resource["id"]
        };
        stack.Add(output);

        var hcl = stack.ToHcl();

        await Verify(hcl).UseMethodName("MemberAccessExpression_ChainedAccess");
    }

    [Fact]
    public async Task RawExpression_CustomHcl_GeneratesCorrectHcl()
    {
        var stack = new TerraformStack { Name = "test" };

        var output = new TerraformOutput("result")
        {
            Value = TerraformExpression.Raw("concat([\"a\"], [\"b\"])")
        };
        stack.Add(output);

        var hcl = stack.ToHcl();

        await Verify(hcl).UseMethodName("RawExpression_CustomHcl");
    }
}
