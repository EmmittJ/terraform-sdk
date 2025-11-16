using EmmittJ.Terraform.Sdk;
using Xunit;

namespace EmmittJ.Terraform.Sdk.Tests.Expressions;

/// <summary>
/// Tests for TerraformExpression HCL generation.
/// These tests validate the second layer of the SDK: Expressions → HCL
/// </summary>
[Trait("Category", "Unit")]
[Trait("Layer", "Expressions")]
public class TerraformExpressionTests
{
    private static ITerraformContext CreateContext() => TerraformContext.Temporary();

    [Theory]
    [InlineData("test", "\"test\"")]
    [InlineData("hello world", "\"hello world\"")]
    [InlineData("", "\"\"")]
    public void LiteralExpression_String_GeneratesCorrectHCL(string value, string expectedHcl)
    {
        var expr = TerraformExpression.Literal(value);
        var context = CreateContext();

        var hcl = expr.ToHcl(context);

        Assert.Equal(expectedHcl, hcl);
    }

    [Theory]
    [InlineData(0, "0")]
    [InlineData(42, "42")]
    [InlineData(-100, "-100")]
    [InlineData(int.MaxValue, "2147483647")]
    public void LiteralExpression_Integer_GeneratesCorrectHCL(int value, string expectedHcl)
    {
        var expr = TerraformExpression.Literal(value);
        var context = CreateContext();

        var hcl = expr.ToHcl(context);

        Assert.Equal(expectedHcl, hcl);
    }

    [Theory]
    [InlineData(true, "true")]
    [InlineData(false, "false")]
    public void LiteralExpression_Boolean_GeneratesCorrectHCL(bool value, string expectedHcl)
    {
        var expr = TerraformExpression.Literal(value);
        var context = CreateContext();

        var hcl = expr.ToHcl(context);

        Assert.Equal(expectedHcl, hcl);
    }

    [Fact]
    public void LiteralExpression_Null_GeneratesCorrectHCL()
    {
        var expr = TerraformExpression.Literal<string?>(null);
        var context = CreateContext();

        var hcl = expr.ToHcl(context);

        Assert.Equal("null", hcl);
    }

    [Theory]
    [InlineData(3.14, "3.14")]
    [InlineData(0.0, "0")]
    [InlineData(-2.5, "-2.5")]
    public void LiteralExpression_Double_GeneratesCorrectHCL(double value, string expectedHcl)
    {
        var expr = TerraformExpression.Literal(value);
        var context = CreateContext();

        var hcl = expr.ToHcl(context);

        Assert.Equal(expectedHcl, hcl);
    }

    [Fact]
    public Task ListExpression_Empty_GeneratesCorrectHCL()
    {
        var expr = TerraformExpression.List();
        var context = CreateContext();

        var hcl = expr.ToHcl(context);

        return Verify(hcl).UseMethodName("ListExpression_Empty");
    }

    [Fact]
    public Task ListExpression_WithStrings_GeneratesCorrectHCL()
    {
        var expr = TerraformExpression.List(
            TerraformExpression.Literal("item1"),
            TerraformExpression.Literal("item2"),
            TerraformExpression.Literal("item3")
        );
        var context = CreateContext();

        var hcl = expr.ToHcl(context);

        return Verify(hcl).UseMethodName("ListExpression_WithStrings");
    }

    [Fact]
    public Task ListExpression_WithMixedTypes_GeneratesCorrectHCL()
    {
        var expr = TerraformExpression.List(
            TerraformExpression.Literal("string"),
            TerraformExpression.Literal(42),
            TerraformExpression.Literal(true)
        );
        var context = CreateContext();

        var hcl = expr.ToHcl(context);

        return Verify(hcl).UseMethodName("ListExpression_WithMixedTypes");
    }

    [Fact]
    public Task MapExpression_Empty_GeneratesCorrectHCL()
    {
        var expr = new TerraformMapExpression();
        var context = CreateContext();

        var hcl = expr.ToHcl(context);

        return Verify(hcl).UseMethodName("MapExpression_Empty");
    }

    [Fact]
    public Task MapExpression_WithSimpleValues_GeneratesCorrectHCL()
    {
        var map = new TerraformMapExpression();
        map.Add("name", TerraformExpression.Literal("example"));
        map.Add("count", TerraformExpression.Literal(3));
        map.Add("enabled", TerraformExpression.Literal(true));

        var context = CreateContext();
        var hcl = map.ToHcl(context);

        return Verify(hcl).UseMethodName("MapExpression_WithSimpleValues");
    }

    [Fact]
    public Task MapExpression_WithNestedMap_GeneratesCorrectHCL()
    {
        var innerMap = new TerraformMapExpression();
        innerMap.Add("inner_key", TerraformExpression.Literal("inner_value"));

        var outerMap = new TerraformMapExpression();
        outerMap.Add("outer_key", TerraformExpression.Literal("outer_value"));
        outerMap.Add("nested", innerMap);

        var context = CreateContext();
        var hcl = outerMap.ToHcl(context);

        return Verify(hcl).UseMethodName("MapExpression_WithNestedMap");
    }

    [Fact]
    public Task MapExpression_WithNestedList_GeneratesCorrectHCL()
    {
        var list = TerraformExpression.List(
            TerraformExpression.Literal("item1"),
            TerraformExpression.Literal("item2")
        );

        var map = new TerraformMapExpression();
        map.Add("items", list);
        map.Add("name", TerraformExpression.Literal("test"));

        var context = CreateContext();
        var hcl = map.ToHcl(context);

        return Verify(hcl).UseMethodName("MapExpression_WithNestedList");
    }

    [Fact]
    public Task ListExpression_WithNestedMaps_GeneratesCorrectHCL()
    {
        var map1 = new TerraformMapExpression();
        map1.Add("name", TerraformExpression.Literal("first"));

        var map2 = new TerraformMapExpression();
        map2.Add("name", TerraformExpression.Literal("second"));

        var list = TerraformExpression.List(map1, map2);

        var context = CreateContext();
        var hcl = list.ToHcl(context);

        return Verify(hcl).UseMethodName("ListExpression_WithNestedMaps");
    }

    [Fact]
    public void RawExpression_GeneratesExactHCL()
    {
        var expr = TerraformExpression.Raw("var.region");
        var context = CreateContext();

        var hcl = expr.ToHcl(context);

        Assert.Equal("var.region", hcl);
    }

    [Fact]
    public void IdentifierExpression_GeneratesCorrectHCL()
    {
        var expr = TerraformExpression.Identifier("aws_vpc.main.id");
        var context = CreateContext();

        var hcl = expr.ToHcl(context);

        Assert.Equal("aws_vpc.main.id", hcl);
    }

    [Fact]
    public Task FunctionCallExpression_WithNoArgs_GeneratesCorrectHCL()
    {
        var expr = TerraformExpressionExtensions.Call("timestamp");
        var context = CreateContext();

        var hcl = expr.ToHcl(context);

        return Verify(hcl).UseMethodName("FunctionCallExpression_WithNoArgs");
    }

    [Fact]
    public Task FunctionCallExpression_WithSingleArg_GeneratesCorrectHCL()
    {
        var expr = TerraformExpressionExtensions.Call("file", TerraformExpression.Literal("path/to/file.txt"));
        var context = CreateContext();

        var hcl = expr.ToHcl(context);

        return Verify(hcl).UseMethodName("FunctionCallExpression_WithSingleArg");
    }

    [Fact]
    public Task FunctionCallExpression_WithMultipleArgs_GeneratesCorrectHCL()
    {
        var expr = TerraformExpressionExtensions.Call("join",
            TerraformExpression.Literal(", "),
            TerraformExpression.List(
                TerraformExpression.Literal("a"),
                TerraformExpression.Literal("b"),
                TerraformExpression.Literal("c")
            ));
        var context = CreateContext();

        var hcl = expr.ToHcl(context);

        return Verify(hcl).UseMethodName("FunctionCallExpression_WithMultipleArgs");
    }
}
