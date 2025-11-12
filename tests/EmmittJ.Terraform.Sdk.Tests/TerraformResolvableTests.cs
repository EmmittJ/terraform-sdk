using Xunit;

namespace EmmittJ.Terraform.Sdk.Tests;

public class TerraformResolvableTests
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

    [Fact]
    public void TerraformLiteralValue_String_ResolvesToLiteralExpression()
    {
        // Arrange
        TerraformValue<string> value = "test-value"; // Implicit conversion creates TerraformLiteralValue
        var context = new TestResolveContext(new TestConstruct("test"));

        // Act
        var expression = value.Resolve(context);

        // Assert
        Assert.NotNull(expression);
        var hcl = expression.ToHcl();
        Assert.Equal("\"test-value\"", hcl);
    }

    [Fact]
    public void TerraformLiteralValue_Number_ResolvesToLiteralExpression()
    {
        // Arrange
        TerraformValue<double> value = 42.5; // Implicit conversion creates TerraformLiteralValue
        var context = new TestResolveContext(new TestConstruct("test"));

        // Act
        var expression = value.Resolve(context);

        // Assert
        Assert.NotNull(expression);
        var hcl = expression.ToHcl();
        Assert.Equal("42.5", hcl);
    }

    [Fact]
    public void TerraformLiteralValue_Bool_ResolvesToLiteralExpression()
    {
        // Arrange
        TerraformValue<bool> value = true; // Implicit conversion creates TerraformLiteralValue
        var context = new TestResolveContext(new TestConstruct("test"));

        // Act
        var expression = value.Resolve(context);

        // Assert
        Assert.NotNull(expression);
        var hcl = expression.ToHcl();
        Assert.Equal("true", hcl);
    }

    [Fact]
    public void TerraformLiteralValue_Null_ResolvesToNullExpression()
    {
        // Arrange
        TerraformValue<string?> value = (string?)null; // Implicit conversion creates TerraformLiteralValue
        var context = new TestResolveContext(new TestConstruct("test"));

        // Act
        var expression = value.Resolve(context);

        // Assert
        Assert.NotNull(expression);
        var hcl = expression.ToHcl();
        Assert.Equal("null", hcl);
    }

    [Fact]
    public void TerraformReference_ResolvesToIdentifierExpression()
    {
        // Arrange
        var construct = new TestConstruct("my-resource");
        var reference = new TerraformReference(construct, "id");
        var context = new TestResolveContext(construct);

        // Act
        var expression = reference.Resolve(context);

        // Assert
        Assert.NotNull(expression);
        var hcl = expression.ToHcl();
        Assert.Equal("test_resource.my-resource.id", hcl);
    }

    [Fact]
    public void TerraformReference_ThrowsOnNullConstruct()
    {
        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => new TerraformReference(null!, "id"));
    }

    [Fact]
    public void TerraformReference_ThrowsOnNullAttributeName()
    {
        // Arrange
        var construct = new TestConstruct("test");

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => new TerraformReference(construct, null!));
    }

    [Fact]
    public void TerraformLazyValue_ResolvesLazily()
    {
        // Arrange
        var invoked = false;
        var lazy = new TerraformLazyValue(ctx =>
        {
            invoked = true;
            return TerraformExpression.Literal("computed-value");
        });
        var context = new TestResolveContext(new TestConstruct("test"));

        // Act
        Assert.False(invoked, "Should not invoke before Resolve");
        var expression = lazy.Resolve(context);

        // Assert
        Assert.True(invoked, "Should invoke during Resolve");
        Assert.NotNull(expression);
        var hcl = expression.ToHcl();
        Assert.Equal("\"computed-value\"", hcl);
    }

    [Fact]
    public void TerraformLazyValue_ReceivesContext()
    {
        // Arrange
        var construct = new TestConstruct("my-construct");
        var context = new TestResolveContext(construct);
        ITerraformResolveContext? receivedContext = null;

        var lazy = new TerraformLazyValue(ctx =>
        {
            receivedContext = ctx;
            return TerraformExpression.Literal("test");
        });

        // Act
        lazy.Resolve(context);

        // Assert
        Assert.NotNull(receivedContext);
        Assert.Same(context, receivedContext);
        Assert.Same(construct, receivedContext.Scope);
    }

    [Fact]
    public void TerraformLazyValue_ThrowsOnNullProducer()
    {
        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => new TerraformLazyValue(null!));
    }

    [Fact]
    public void TerraformLazyValue_CanProduceComplexExpressions()
    {
        // Arrange
        var lazy = new TerraformLazyValue(ctx =>
        {
            var prefix = TerraformExpression.Literal("prefix-");
            var scopeName = TerraformExpression.Literal(((NamedTerraformConstruct)ctx.Scope).ConstructName);
            var suffix = TerraformExpression.Literal("-suffix");
            return TerraformExpression.Interpolate(prefix, scopeName, suffix);
        });
        var context = new TestResolveContext(new TestConstruct("test-resource"));

        // Act
        var expression = lazy.Resolve(context);

        // Assert
        Assert.NotNull(expression);
        var hcl = expression.ToHcl();
        Assert.Equal("\"prefix-${\"test-resource\"}-suffix\"", hcl);
    }
}
