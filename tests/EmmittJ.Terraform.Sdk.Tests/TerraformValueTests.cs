using EmmittJ.Terraform.Sdk;
using Xunit;

namespace EmmittJ.Terraform.Sdk.Tests;

public class TerraformValueTests
{
    private class TestConstruct : TerraformResource
    {
        public TestConstruct(string name) : base("test_resource", name)
        {
        }
    }

    private class TestResolveContext : ITerraformResolveContext
    {
        public object Scope { get; }

        public TestResolveContext(object scope)
        {
            Scope = scope;
        }
    }

    #region Implicit Conversion Tests

    [Fact]
    public void ImplicitConversion_FromString_CreatesLiteralValue()
    {
        // Arrange & Act
        TerraformValue<string> value = "test-value";
        var context = new TestResolveContext(new TestConstruct("test"));

        // Assert
        Assert.True(value.HasValue);
        var expression = value.Resolve(context);
        Assert.Equal("\"test-value\"", expression.ToHcl());
    }

    [Fact]
    public void ImplicitConversion_FromInt_CreatesLiteralValue()
    {
        // Arrange & Act
        TerraformValue<double> value = 42;
        var context = new TestResolveContext(new TestConstruct("test"));

        // Assert
        Assert.True(value.HasValue);
        var expression = value.Resolve(context);
        Assert.Equal("42", expression.ToHcl());
    }

    [Fact]
    public void ImplicitConversion_FromDouble_CreatesLiteralValue()
    {
        // Arrange & Act
        TerraformValue<double> value = 42.5;
        var context = new TestResolveContext(new TestConstruct("test"));

        // Assert
        Assert.True(value.HasValue);
        var expression = value.Resolve(context);
        Assert.Equal("42.5", expression.ToHcl());
    }

    [Fact]
    public void ImplicitConversion_FromBool_CreatesLiteralValue()
    {
        // Arrange & Act
        TerraformValue<bool> value = true;
        var context = new TestResolveContext(new TestConstruct("test"));

        // Assert
        Assert.True(value.HasValue);
        var expression = value.Resolve(context);
        Assert.Equal("true", expression.ToHcl());
    }

    [Fact]
    public void ImplicitConversion_FromNull_CreatesNullLiteral()
    {
        // Arrange & Act
        TerraformValue<string?> value = (string?)null;
        var context = new TestResolveContext(new TestConstruct("test"));

        // Assert
        Assert.True(value.HasValue);
        var expression = value.Resolve(context);
        Assert.Equal("null", expression.ToHcl());
    }

    [Fact]
    public void ImplicitConversion_FromResolvable_WorksCorrectly()
    {
        // Arrange
        var construct = new TestConstruct("my-resource");
        var reference = new TerraformReference(construct, "id");

        // Act
        TerraformValue<string> value = reference;
        var context = new TestResolveContext(construct);

        // Assert
        Assert.True(value.HasValue);
        var expression = value.Resolve(context);
        Assert.Equal("test_resource.my-resource.id", expression.ToHcl());
    }

    [Fact]
    public void ImplicitConversion_FromTerraformExpression_WorksCorrectly()
    {
        // Arrange
        var expr = TerraformExpression.Literal("expression-value");

        // Act
        TerraformValue<string> value = expr;
        var context = new TestResolveContext(new TestConstruct("test"));

        // Assert
        Assert.True(value.HasValue);
        var expression = value.Resolve(context);
        Assert.Equal("\"expression-value\"", expression.ToHcl());
    }

    [Fact]
    public void ImplicitConversion_FromLazyValue_WorksCorrectly()
    {
        // Arrange
        var lazy = new TerraformLazyValue(ctx => TerraformExpression.Literal($"lazy-{((NamedTerraformConstruct)ctx.Scope).ConstructName}"));

        // Act
        TerraformValue<string> value = lazy;
        var context = new TestResolveContext(new TestConstruct("test-resource"));

        // Assert
        Assert.True(value.HasValue);
        var expression = value.Resolve(context);
        Assert.Equal("\"lazy-test-resource\"", expression.ToHcl());
    }

    #endregion

    #region Resolution Tests

    [Fact]
    public void Resolve_WithLiteralString_ProducesLiteralExpression()
    {
        // Arrange
        TerraformValue<string> value = "my-value";
        var context = new TestResolveContext(new TestConstruct("test"));

        // Act
        var expression = value.Resolve(context);

        // Assert
        Assert.NotNull(expression);
        Assert.Equal("\"my-value\"", expression.ToHcl());
    }

    [Fact]
    public void Resolve_WithReference_ProducesIdentifierExpression()
    {
        // Arrange
        var construct = new TestConstruct("vpc");
        var reference = new TerraformReference(construct, "id");
        TerraformValue<string> value = reference;
        var context = new TestResolveContext(construct);

        // Act
        var expression = value.Resolve(context);

        // Assert
        Assert.NotNull(expression);
        Assert.Equal("test_resource.vpc.id", expression.ToHcl());
    }

    [Fact]
    public void Resolve_WithExpression_ReturnsSameExpression()
    {
        // Arrange
        var originalExpr = TerraformExpression.Interpolate(
            TerraformExpression.Literal("prefix-"),
            TerraformExpression.Literal("value"),
            TerraformExpression.Literal("-suffix")
        );
        TerraformValue<string> value = originalExpr;
        var context = new TestResolveContext(new TestConstruct("test"));

        // Act
        var expression = value.Resolve(context);

        // Assert
        Assert.NotNull(expression);
        Assert.Same(originalExpr, expression);
    }

    #endregion

    #region Nullable Tests

    [Fact]
    public void NullableValue_WithNull_HasValue()
    {
        // Arrange & Act
        TerraformValue<string?> value = (string?)null;

        // Assert
        Assert.True(value.HasValue); // Even null literals have a value (they resolve to null expression)
    }

    [Fact]
    public void NullableValue_WithString_HasValue()
    {
        // Arrange & Act
        TerraformValue<string?> value = "test";

        // Assert
        Assert.True(value.HasValue);
    }

    [Fact]
    public void DefaultStruct_HasNoValue()
    {
        // Arrange & Act
        TerraformValue<string> value = default;

        // Assert
        Assert.False(value.HasValue);
    }

    [Fact]
    public void DefaultStruct_Resolve_ThrowsException()
    {
        // Arrange
        TerraformValue<string> value = default;
        var context = new TestResolveContext(new TestConstruct("test"));

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => value.Resolve(context));
    }

    #endregion

    #region Static Helper Tests

    [Fact]
    public void FromLiteral_CreatesValue()
    {
        // Act
        var value = TerraformValue.FromLiteral("test");
        var context = new TestResolveContext(new TestConstruct("test"));

        // Assert
        Assert.True(value.HasValue);
        var expression = value.Resolve(context);
        Assert.Equal("\"test\"", expression.ToHcl());
    }

    [Fact]
    public void FromReference_CreatesValue()
    {
        // Arrange
        var construct = new TestConstruct("resource");
        var reference = new TerraformReference(construct, "name");

        // Act
        var value = TerraformValue.FromReference<string>(reference);
        var context = new TestResolveContext(construct);

        // Assert
        Assert.True(value.HasValue);
        var expression = value.Resolve(context);
        Assert.Equal("test_resource.resource.name", expression.ToHcl());
    }

    [Fact]
    public void FromExpression_CreatesValue()
    {
        // Arrange
        var expr = TerraformExpression.Literal(123);

        // Act
        var value = TerraformValue.FromExpression<double>(expr);
        var context = new TestResolveContext(new TestConstruct("test"));

        // Assert
        Assert.True(value.HasValue);
        var expression = value.Resolve(context);
        Assert.Equal("123", expression.ToHcl());
    }

    #endregion

    #region Complex Scenarios

    [Fact]
    public void ComplexExpression_ConditionalAssignment_WorksCorrectly()
    {
        // Arrange
        var condition = TerraformExpression.Identifier("var.is_production");
        var trueValue = TerraformExpression.Literal("prod-value");
        var falseValue = TerraformExpression.Literal("dev-value");
        var conditional = TerraformExpression.Conditional(condition, trueValue, falseValue);

        // Act
        TerraformValue<string> value = conditional;
        var context = new TestResolveContext(new TestConstruct("test"));

        // Assert
        Assert.True(value.HasValue);
        var expression = value.Resolve(context);
        var hcl = expression.ToHcl();
        Assert.Contains("var.is_production", hcl);
        Assert.Contains("prod-value", hcl);
        Assert.Contains("dev-value", hcl);
    }

    [Fact]
    public void StringInterpolation_WorksCorrectly()
    {
        // Arrange
        var interpolated = TerraformExpression.Interpolate(
            TerraformExpression.Literal("prefix-"),
            TerraformExpression.Identifier("var.name"),
            TerraformExpression.Literal("-suffix")
        );

        // Act
        TerraformValue<string> value = interpolated;
        var context = new TestResolveContext(new TestConstruct("test"));

        // Assert
        Assert.True(value.HasValue);
        var expression = value.Resolve(context);
        var hcl = expression.ToHcl();
        Assert.Contains("prefix-", hcl);
        Assert.Contains("var.name", hcl);
        Assert.Contains("-suffix", hcl);
    }

    #endregion
}
