namespace EmmittJ.Terraform.Sdk.Tests;

public class TerraformValueTests
{
    [Fact]
    public void Unset_Value_IsEmpty()
    {
        var value = new TerraformValue<string>();

        Assert.Equal(TerraformValueKind.Unset, value.Kind);
        Assert.True(value.IsEmpty);
    }

    [Fact]
    public void Literal_Value_HasCorrectKind()
    {
        var value = new TerraformValue<string>("test");

        Assert.Equal(TerraformValueKind.Literal, value.Kind);
        Assert.False(value.IsEmpty);
        Assert.Equal("test", value.LiteralValue);
    }

    [Fact]
    public void Expression_Value_HasCorrectKind()
    {
        var expr = TerraformExpression.Identifier("test");
        var value = new TerraformValue<string>(expr);

        Assert.Equal(TerraformValueKind.Expression, value.Kind);
        Assert.False(value.IsEmpty);
    }

    [Fact]
    public void Reference_Value_HasCorrectKind()
    {
        var variable = new TerraformVariable("test");
        var reference = variable.AsReference();
        var value = new TerraformValue<string>(reference);

        Assert.Equal(TerraformValueKind.Reference, value.Kind);
        Assert.False(value.IsEmpty);
    }

    [Fact]
    public void ImplicitConversion_FromLiteral_CreatesLiteralValue()
    {
        TerraformValue<string> value = "test";

        Assert.Equal(TerraformValueKind.Literal, value.Kind);
        Assert.Equal("test", value.LiteralValue);
    }

    [Fact]
    public void ImplicitConversion_FromExpression_CreatesExpressionValue()
    {
        var expr = TerraformExpression.Identifier("test");
        TerraformValue<string> value = expr;

        Assert.Equal(TerraformValueKind.Expression, value.Kind);
    }

    [Fact]
    public void Clear_ResetsToUnset()
    {
        var value = new TerraformValue<string>("test");
        Assert.False(value.IsEmpty);

        value.Clear();

        Assert.True(value.IsEmpty);
        Assert.Equal(TerraformValueKind.Unset, value.Kind);
    }

    [Fact]
    public Task Compile_LiteralString_ReturnsQuotedHcl()
    {
        var value = new TerraformValue<string>("hello");
        var context = TerraformContext.Temporary();
        context.Prepare(value);
        var expr = context.ToHcl(value);

        return Verify(expr.ToHcl());
    }

    [Fact]
    public Task Compile_LiteralInt_ReturnsUnquotedHcl()
    {
        var value = new TerraformValue<int>(42);
        var context = TerraformContext.Temporary();
        context.Prepare(value);
        var expr = context.ToHcl(value);

        return Verify(expr.ToHcl());
    }

    [Fact]
    public Task Compile_LiteralBool_ReturnsLowercaseHcl()
    {
        var value = new TerraformValue<bool>(true);
        var context = TerraformContext.Temporary();
        context.Prepare(value);
        var expr = context.ToHcl(value);

        return Verify(expr.ToHcl());
    }

    [Fact]
    public Task Compile_Expression_ReturnsExpressionHcl()
    {
        var expr = TerraformExpression.Identifier("count.index");
        var value = new TerraformValue<int>(expr);
        var context = TerraformContext.Temporary();
        context.Prepare(value);
        var compiled = context.ToHcl(value);

        return Verify(compiled.ToHcl());
    }

    [Fact]
    public Task Compile_Reference_ReturnsReferenceHcl()
    {
        var variable = new TerraformVariable("region");
        var reference = variable.AsReference();
        var value = new TerraformValue<string>(reference);
        var context = TerraformContext.Temporary();
        context.Prepare(value);
        var expr = context.ToHcl(value);

        return Verify(expr.ToHcl());
    }

    [Fact]
    public void Compile_UnsetValue_ThrowsException()
    {
        var value = new TerraformValue<string>();
        var context = TerraformContext.Temporary();

        Assert.Throws<InvalidOperationException>(() => context.ToHcl(value));
    }
}
