namespace EmmittJ.Terraform.Sdk.Tests.Expressions;

using EmmittJ.Terraform.Sdk.Tests.TestHelpers;
using System.Reflection;

/// <summary>
/// Tests for operator expressions (arithmetic, logical, comparison).
/// </summary>
[Trait("Category", "Unit")]
[Trait("Layer", "Expression")]
public class TerraformOperatorExpressionTests
{
    private readonly ITerraformContext _context = TerraformTestHelpers.CreateContext();

    /// <summary>
    /// Helper method to create binary expressions using reflection (since BinaryExpression is internal).
    /// </summary>
    private static TerraformExpression CreateBinaryExpression(TerraformExpression left, BinaryOperator op, TerraformExpression right)
    {
        var binaryExprType = typeof(TerraformExpression).Assembly.GetType("EmmittJ.Terraform.Sdk.BinaryExpression");
        return (TerraformExpression)Activator.CreateInstance(binaryExprType!, left, op, right)!;
    }

    #region Arithmetic Operators

    [Fact]
    public Task ArithmeticOperator_Addition_RendersCorrectly()
    {
        // Arrange
        var left = TerraformExpression.Literal(5);
        var right = TerraformExpression.Literal(3);
        var expression = left + right;

        // Act
        var hcl = expression.ToHcl(_context);

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task ArithmeticOperator_Subtraction_RendersCorrectly()
    {
        // Arrange
        var left = TerraformExpression.Literal(10);
        var right = TerraformExpression.Literal(3);
        var expression = left - right;

        // Act
        var hcl = expression.ToHcl(_context);

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task ArithmeticOperator_Multiplication_RendersCorrectly()
    {
        // Arrange
        var left = TerraformExpression.Literal(4);
        var right = TerraformExpression.Literal(5);
        var expression = left * right;

        // Act
        var hcl = expression.ToHcl(_context);

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task ArithmeticOperator_Division_RendersCorrectly()
    {
        // Arrange
        var left = TerraformExpression.Literal(20);
        var right = TerraformExpression.Literal(4);
        var expression = left / right;

        // Act
        var hcl = expression.ToHcl(_context);

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task ArithmeticOperator_WithVariables_RendersCorrectly()
    {
        // Arrange
        var varCount = TerraformExpression.Identifier("var.instance_count");
        var multiplier = TerraformExpression.Literal(2);
        var expression = varCount * multiplier;

        // Act
        var hcl = expression.ToHcl(_context);

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task ArithmeticOperator_ChainedOperations_RendersCorrectly()
    {
        // Arrange
        var a = TerraformExpression.Literal(10);
        var b = TerraformExpression.Literal(5);
        var c = TerraformExpression.Literal(2);
        var expression = a + b * c; // Should be "10 + 5 * 2" (no automatic parentheses)

        // Act
        var hcl = expression.ToHcl(_context);

        // Assert
        return Verify(hcl);
    }

    #endregion

    #region Comparison Operators

    [Fact]
    public Task ComparisonOperator_Equal_RendersCorrectly()
    {
        // Arrange
        var left = TerraformExpression.Identifier("var.environment");
        var right = TerraformExpression.Literal("production");
        var expression = CreateBinaryExpression(left, BinaryOperator.Equal, right);

        // Act
        var hcl = expression.ToHcl(_context);

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task ComparisonOperator_NotEqual_RendersCorrectly()
    {
        // Arrange
        var left = TerraformExpression.Identifier("var.region");
        var right = TerraformExpression.Literal("us-east-1");
        var expression = CreateBinaryExpression(left, BinaryOperator.NotEqual, right);

        // Act
        var hcl = expression.ToHcl(_context);

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task ComparisonOperator_LessThan_RendersCorrectly()
    {
        // Arrange
        var left = TerraformExpression.Identifier("var.instance_count");
        var right = TerraformExpression.Literal(10);
        var expression = CreateBinaryExpression(left, BinaryOperator.LessThan, right);

        // Act
        var hcl = expression.ToHcl(_context);

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task ComparisonOperator_GreaterThan_RendersCorrectly()
    {
        // Arrange
        var left = TerraformExpression.Identifier("var.cpu_count");
        var right = TerraformExpression.Literal(2);
        var expression = CreateBinaryExpression(left, BinaryOperator.GreaterThan, right);

        // Act
        var hcl = expression.ToHcl(_context);

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task ComparisonOperator_LessThanOrEqual_RendersCorrectly()
    {
        // Arrange
        var left = TerraformExpression.Literal(5);
        var right = TerraformExpression.Literal(10);
        var expression = CreateBinaryExpression(left, BinaryOperator.LessThanOrEqual, right);

        // Act
        var hcl = expression.ToHcl(_context);

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task ComparisonOperator_GreaterThanOrEqual_RendersCorrectly()
    {
        // Arrange
        var left = TerraformExpression.Literal(10);
        var right = TerraformExpression.Literal(5);
        var expression = CreateBinaryExpression(left, BinaryOperator.GreaterThanOrEqual, right);

        // Act
        var hcl = expression.ToHcl(_context);

        // Assert
        return Verify(hcl);
    }

    #endregion

    #region Logical Operators

    [Fact]
    public Task LogicalOperator_And_RendersCorrectly()
    {
        // Arrange
        var left = CreateBinaryExpression(
            TerraformExpression.Identifier("var.enabled"),
            BinaryOperator.Equal,
            TerraformExpression.Literal(true)
        );
        var right = CreateBinaryExpression(
            TerraformExpression.Identifier("var.environment"),
            BinaryOperator.Equal,
            TerraformExpression.Literal("production")
        );
        var expression = CreateBinaryExpression(left, BinaryOperator.And, right);

        // Act
        var hcl = expression.ToHcl(_context);

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task LogicalOperator_Or_RendersCorrectly()
    {
        // Arrange
        var left = CreateBinaryExpression(
            TerraformExpression.Identifier("var.environment"),
            BinaryOperator.Equal,
            TerraformExpression.Literal("production")
        );
        var right = CreateBinaryExpression(
            TerraformExpression.Identifier("var.environment"),
            BinaryOperator.Equal,
            TerraformExpression.Literal("staging")
        );
        var expression = CreateBinaryExpression(left, BinaryOperator.Or, right);

        // Act
        var hcl = expression.ToHcl(_context);

        // Assert
        return Verify(hcl);
    }

    #endregion
}
