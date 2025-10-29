namespace EmmittJ.Terraform.Sdk.Tests;

public class TerraformExpressionTests
{
    [Fact]
    public Task Literal_String_QuotesValue()
    {
        var expr = TerraformExpression.Literal("hello world");
        return Verify(expr.ToHcl());
    }

    [Fact]
    public Task Literal_Int_UnquotedValue()
    {
        var expr = TerraformExpression.Literal(42);
        return Verify(expr.ToHcl());
    }

    [Fact]
    public Task Literal_Bool_True_LowercaseValue()
    {
        var expr = TerraformExpression.Literal(true);
        return Verify(expr.ToHcl());
    }

    [Fact]
    public Task Literal_Bool_False_LowercaseValue()
    {
        var expr = TerraformExpression.Literal(false);
        return Verify(expr.ToHcl());
    }

    [Fact]
    public Task Identifier_SingleName()
    {
        var expr = TerraformExpression.Identifier("local.region");
        return Verify(expr.ToHcl());
    }

    [Fact]
    public Task Raw_Expression_PreservesHcl()
    {
        var expr = TerraformExpression.Raw("cidrsubnet(var.base_cidr, 8, 1)");
        return Verify(expr.ToHcl());
    }

    [Fact]
    public Task BinaryExpression_Addition()
    {
        var left = TerraformExpression.Identifier("count.index");
        var right = TerraformExpression.Literal(1);
        var expr = left + right;

        return Verify(expr.ToHcl());
    }

    [Fact]
    public Task BinaryExpression_Subtraction()
    {
        var left = TerraformExpression.Literal(10);
        var right = TerraformExpression.Identifier("var.offset");
        var expr = left - right;

        return Verify(expr.ToHcl());
    }

    [Fact]
    public Task BinaryExpression_Multiplication()
    {
        var left = TerraformExpression.Identifier("var.size");
        var right = TerraformExpression.Literal(2);
        var expr = left * right;

        return Verify(expr.ToHcl());
    }

    [Fact]
    public Task BinaryExpression_Division()
    {
        var left = TerraformExpression.Identifier("var.total");
        var right = TerraformExpression.Literal(3);
        var expr = left / right;

        return Verify(expr.ToHcl());
    }

    [Fact]
    public Task BinaryExpression_Complex()
    {
        var index = TerraformExpression.Identifier("count.index");
        var offset = TerraformExpression.Literal(1);
        var multiplier = TerraformExpression.Literal(256);
        var expr = (index + offset) * multiplier;

        return Verify(expr.ToHcl());
    }
}
