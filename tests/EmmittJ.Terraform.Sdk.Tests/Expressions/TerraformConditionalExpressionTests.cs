namespace EmmittJ.Terraform.Sdk.Tests.Expressions;

using EmmittJ.Terraform.Sdk.Tests.TestHelpers;

/// <summary>
/// Tests for conditional (ternary) expressions.
/// </summary>
[Trait("Category", "Unit")]
[Trait("Layer", "Expression")]
public class TerraformConditionalExpressionTests
{
    private readonly ITerraformContext _context = TerraformTestHelpers.CreateContext();

    [Fact]
    public Task ConditionalExpression_SimpleLiterals_RendersCorrectly()
    {
        // Arrange
        var condition = TerraformExpression.Literal(true);
        var trueValue = TerraformExpression.Literal("yes");
        var falseValue = TerraformExpression.Literal("no");
        var expression = TerraformExpression.Conditional(condition, trueValue, falseValue);

        // Act
        var hcl = expression.ToHcl(_context);

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task ConditionalExpression_WithComparison_RendersCorrectly()
    {
        // Arrange
        var binaryExprType = typeof(TerraformExpression).Assembly.GetType("EmmittJ.Terraform.Sdk.BinaryExpression");
        var condition = (TerraformExpression)Activator.CreateInstance(
            binaryExprType!,
            TerraformExpression.Identifier("var.environment"),
            BinaryOperator.Equal,
            TerraformExpression.Literal("production")
        )!;

        var trueValue = TerraformExpression.Literal("t3.large");
        var falseValue = TerraformExpression.Literal("t3.micro");
        var expression = TerraformExpression.Conditional(condition, trueValue, falseValue);

        // Act
        var hcl = expression.ToHcl(_context);

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task ConditionalExpression_WithVariables_RendersCorrectly()
    {
        // Arrange
        var condition = TerraformExpression.Identifier("var.enable_monitoring");
        var trueValue = TerraformExpression.Literal(60);
        var falseValue = TerraformExpression.Literal(300);
        var expression = TerraformExpression.Conditional(condition, trueValue, falseValue);

        // Act
        var hcl = expression.ToHcl(_context);

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task ConditionalExpression_NestedConditionals_RendersCorrectly()
    {
        // Arrange
        var binaryExprType = typeof(TerraformExpression).Assembly.GetType("EmmittJ.Terraform.Sdk.BinaryExpression");

        var outerCondition = (TerraformExpression)Activator.CreateInstance(
            binaryExprType!,
            TerraformExpression.Identifier("var.environment"),
            BinaryOperator.Equal,
            TerraformExpression.Literal("production")
        )!;

        var innerCondition = (TerraformExpression)Activator.CreateInstance(
            binaryExprType!,
            TerraformExpression.Identifier("var.size"),
            BinaryOperator.Equal,
            TerraformExpression.Literal("large")
        )!;

        var innerConditional = TerraformExpression.Conditional(
            innerCondition,
            TerraformExpression.Literal("t3.xlarge"),
            TerraformExpression.Literal("t3.large")
        );

        var expression = TerraformExpression.Conditional(
            outerCondition,
            innerConditional,
            TerraformExpression.Literal("t3.micro")
        );

        // Act
        var hcl = expression.ToHcl(_context);

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task ConditionalExpression_WithComplexExpressions_RendersCorrectly()
    {
        // Arrange
        var condition = TerraformExpression.Identifier("var.use_custom_config");
        var trueValue = TerraformExpression.Identifier("var.custom_config");
        var falseValue = new TerraformMapExpression
        {
            ["setting1"] = TerraformExpression.Literal("default1"),
            ["setting2"] = TerraformExpression.Literal("default2")
        };
        var expression = TerraformExpression.Conditional(condition, trueValue, falseValue);

        // Act
        var hcl = expression.ToHcl(_context);

        // Assert
        return Verify(hcl);
    }
}
