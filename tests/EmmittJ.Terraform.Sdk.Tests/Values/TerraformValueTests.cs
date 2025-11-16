using EmmittJ.Terraform.Sdk;
using Xunit;

namespace EmmittJ.Terraform.Sdk.Tests.Values;

/// <summary>
/// Tests for TerraformValue resolution to expressions.
/// These tests validate the first layer of the SDK: Values → Expressions
/// </summary>
[Trait("Category", "Unit")]
[Trait("Layer", "Values")]
public class TerraformValueTests
{
    private static ITerraformContext CreateContext() => TerraformContext.Temporary();

    [Fact]
    public void TerraformValue_String_ResolvesToLiteralExpression()
    {
        TerraformValue<string> value = "test";
        var context = CreateContext();

        var nodes = value.ResolveNodes(context).ToList();

        Assert.Single(nodes);
        var expression = Assert.IsAssignableFrom<TerraformExpression>(nodes[0]);
        Assert.Equal("\"test\"", expression.ToHcl(context));
    }

    [Fact]
    public void TerraformValue_Integer_ResolvesToLiteralExpression()
    {
        TerraformValue<int> value = 42;
        var context = CreateContext();

        var nodes = value.ResolveNodes(context).ToList();

        Assert.Single(nodes);
        var expression = Assert.IsAssignableFrom<TerraformExpression>(nodes[0]);
        Assert.Equal("42", expression.ToHcl(context));
    }

    [Fact]
    public void TerraformValue_Boolean_ResolvesToLiteralExpression()
    {
        TerraformValue<bool> valueTrue = true;
        TerraformValue<bool> valueFalse = false;
        var context = CreateContext();

        var nodesTrue = valueTrue.ResolveNodes(context).ToList();
        var nodesFalse = valueFalse.ResolveNodes(context).ToList();

        Assert.Single(nodesTrue);
        Assert.Single(nodesFalse);
        var exprTrue = Assert.IsAssignableFrom<TerraformExpression>(nodesTrue[0]);
        var exprFalse = Assert.IsAssignableFrom<TerraformExpression>(nodesFalse[0]);
        Assert.Equal("true", exprTrue.ToHcl(context));
        Assert.Equal("false", exprFalse.ToHcl(context));
    }

    [Fact]
    public void TerraformValue_Null_ResolvesToNullLiteral()
    {
        TerraformValue<string?> value = (string?)null;
        var context = CreateContext();

        var nodes = value.ResolveNodes(context).ToList();

        Assert.Single(nodes);
        var expression = Assert.IsAssignableFrom<TerraformExpression>(nodes[0]);
        Assert.Equal("null", expression.ToHcl(context));
    }

    [Theory]
    [InlineData(123L, "123")]
    [InlineData(0L, "0")]
    [InlineData(-42L, "-42")]
    public void TerraformValue_Long_ResolvesToLiteralExpression(long input, string expectedHcl)
    {
        TerraformValue<long> value = input;
        var context = CreateContext();

        var nodes = value.ResolveNodes(context).ToList();

        Assert.Single(nodes);
        var expression = Assert.IsAssignableFrom<TerraformExpression>(nodes[0]);
        Assert.Equal(expectedHcl, expression.ToHcl(context));
    }

    [Theory]
    [InlineData(3.14, "3.14")]
    [InlineData(0.0, "0")]
    [InlineData(-2.5, "-2.5")]
    public void TerraformValue_Double_ResolvesToLiteralExpression(double input, string expectedHcl)
    {
        TerraformValue<double> value = input;
        var context = CreateContext();

        var nodes = value.ResolveNodes(context).ToList();

        Assert.Single(nodes);
        var expression = Assert.IsAssignableFrom<TerraformExpression>(nodes[0]);
        Assert.Equal(expectedHcl, expression.ToHcl(context));
    }

    [Fact]
    public void TerraformValue_StringWithSpecialCharacters_EscapesCorrectly()
    {
        TerraformValue<string> value = "test\"quote\nline\ttab\\backslash";
        var context = CreateContext();

        var nodes = value.ResolveNodes(context).ToList();

        Assert.Single(nodes);
        var expression = Assert.IsAssignableFrom<TerraformExpression>(nodes[0]);
        var hcl = expression.ToHcl(context);
        Assert.Contains("\\\"", hcl);
        Assert.Contains("\\n", hcl);
        Assert.Contains("\\t", hcl);
        Assert.Contains("\\\\", hcl);
    }

}

public class CustomTestClass
{
    public string Name { get; set; } = string.Empty;
}
