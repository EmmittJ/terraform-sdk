namespace EmmittJ.Terraform.Sdk.Tests.Expressions;

using EmmittJ.Terraform.Sdk.Tests.TestHelpers;

/// <summary>
/// Tests for index access and splat expressions.
/// </summary>
[Trait("Category", "Unit")]
[Trait("Layer", "Expression")]
public class TerraformIndexAndSplatExpressionTests
{
    private readonly ITerraformContext _context = TerraformTestHelpers.CreateContext();

    #region Index Expressions

    [Fact]
    public Task IndexExpression_NumericIndex_RendersCorrectly()
    {
        // Arrange
        var source = TerraformExpression.Identifier("var.subnet_ids");
        var index = TerraformExpression.Literal(0);
        var expression = TerraformExpression.Index(source, index);

        // Act
        var hcl = expression.ToHcl(_context);

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task IndexExpression_StringKey_RendersCorrectly()
    {
        // Arrange
        var source = TerraformExpression.Identifier("var.tags");
        var key = TerraformExpression.Literal("Environment");
        var expression = TerraformExpression.Index(source, key);

        // Act
        var hcl = expression.ToHcl(_context);

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task IndexExpression_ChainedAccess_RendersCorrectly()
    {
        // Arrange
        var list = TerraformExpression.Identifier("var.instances");
        var firstElement = TerraformExpression.Index(list, TerraformExpression.Literal(0));
        var attribute = firstElement["id"];
        var expression = attribute;

        // Act
        var hcl = expression.ToHcl(_context);

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task IndexExpression_WithVariableIndex_RendersCorrectly()
    {
        // Arrange
        var source = TerraformExpression.Identifier("var.availability_zones");
        var indexVar = TerraformExpression.Identifier("count.index");
        var expression = TerraformExpression.Index(source, indexVar);

        // Act
        var hcl = expression.ToHcl(_context);

        // Assert
        return Verify(hcl);
    }

    #endregion

    #region Splat Expressions

    [Fact]
    public Task SplatExpression_SimpleList_RendersCorrectly()
    {
        // Arrange
        var source = TerraformExpression.Identifier("var.instances");
        var expression = TerraformExpression.Splat(source);

        // Act
        var hcl = expression.ToHcl(_context);

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task SplatExpression_WithAttribute_RendersCorrectly()
    {
        // Arrange
        var source = TerraformExpression.Identifier("aws_instance.web");
        var expression = TerraformExpression.Splat(source, "id");

        // Act
        var hcl = expression.ToHcl(_context);

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task SplatExpression_UsingExtensionMethod_RendersCorrectly()
    {
        // Arrange
        var source = TerraformExpression.Identifier("aws_subnet.private");
        var expression = source.Splat("id");

        // Act
        var hcl = expression.ToHcl(_context);

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task SplatExpression_NestedAttribute_RendersCorrectly()
    {
        // Arrange
        var source = TerraformExpression.Identifier("aws_instance.app");
        var splatExpression = TerraformExpression.Splat(source, "network_interface");
        var nestedAccess = splatExpression["subnet_id"];

        // Act
        var hcl = nestedAccess.ToHcl(_context);

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task SplatExpression_WithIndex_RendersCorrectly()
    {
        // Arrange
        var source = TerraformExpression.Identifier("aws_instance.cluster");
        var splatExpression = TerraformExpression.Splat(source, "private_ip");
        var indexed = TerraformExpression.Index(splatExpression, TerraformExpression.Literal(0));

        // Act
        var hcl = indexed.ToHcl(_context);

        // Assert
        return Verify(hcl);
    }

    #endregion

    #region Combined Expressions

    [Fact]
    public Task CombinedExpression_SplatInFunction_RendersCorrectly()
    {
        // Arrange
        var instances = TerraformExpression.Identifier("aws_instance.web");
        var ids = TerraformExpression.Splat(instances, "id");
        var expression = TerraformExpressionExtensions.Call("join",
            TerraformExpression.Literal(","),
            ids);

        // Act
        var hcl = expression.ToHcl(_context);

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task CombinedExpression_IndexWithMemberAccess_RendersCorrectly()
    {
        // Arrange
        var vpc = TerraformExpression.Identifier("data.aws_vpc.main");
        var subnets = vpc["subnet_ids"];
        var firstSubnet = TerraformExpression.Index(subnets, TerraformExpression.Literal(0));

        // Act
        var hcl = firstSubnet.ToHcl(_context);

        // Assert
        return Verify(hcl);
    }

    #endregion
}
