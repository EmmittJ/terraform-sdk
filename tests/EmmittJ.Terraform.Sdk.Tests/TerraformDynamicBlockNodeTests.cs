namespace EmmittJ.Terraform.Sdk.Tests;

/// <summary>
/// Tests for TerraformDynamicBlockNode HCL serialization.
/// </summary>
public class TerraformDynamicBlockNodeTests
{
    [Fact]
    public void ToHcl_WithBasicContent_RendersCorrectly()
    {
        // Arrange
        var forEachExpr = TerraformExpression.Identifier("var.ingress_rules");
        var contentMap = new TerraformMapExpression
        {
            ["from_port"] = TerraformExpression.Identifier("ingress.value.from_port"),
            ["to_port"] = TerraformExpression.Identifier("ingress.value.to_port")
        };

        var dynamicBlock = new TerraformDynamicBlockNode(
            "ingress",
            forEachExpr,
            contentMap);

        var context = TerraformContext.Temporary();

        // Act
        var hcl = dynamicBlock.ToHcl(context);

        // Assert
        var expected = @"dynamic ""ingress"" {
  for_each = var.ingress_rules

  content {
    from_port = ingress.value.from_port
    to_port = ingress.value.to_port
  }
}";
        Assert.Equal(expected, hcl);
    }

    [Fact]
    public void ToHcl_WithCustomIterator_RendersCorrectly()
    {
        // Arrange
        var forEachExpr = TerraformExpression.Identifier("var.rules");
        var contentMap = new TerraformMapExpression
        {
            ["from_port"] = TerraformExpression.Identifier("rule.value.from_port"),
            ["to_port"] = TerraformExpression.Identifier("rule.value.to_port")
        };

        var dynamicBlock = new TerraformDynamicBlockNode(
            "ingress",
            forEachExpr,
            contentMap,
            iterator: "rule");

        var context = TerraformContext.Temporary();

        // Act
        var hcl = dynamicBlock.ToHcl(context);

        // Assert
        var expected = @"dynamic ""ingress"" {
  for_each = var.rules
  iterator = rule

  content {
    from_port = rule.value.from_port
    to_port = rule.value.to_port
  }
}";
        Assert.Equal(expected, hcl);
    }

    [Fact]
    public void ToHcl_WithComplexContent_RendersCorrectly()
    {
        // Arrange
        var forEachExpr = TerraformExpression.Identifier("var.settings");
        var contentMap = new TerraformMapExpression
        {
            ["namespace"] = TerraformExpression.Identifier("setting.value.namespace"),
            ["name"] = TerraformExpression.Identifier("setting.value.name"),
            ["value"] = TerraformExpression.Identifier("setting.value.value")
        };

        var dynamicBlock = new TerraformDynamicBlockNode(
            "setting",
            forEachExpr,
            contentMap,
            iterator: "setting");

        var context = TerraformContext.Temporary();

        // Act
        var hcl = dynamicBlock.ToHcl(context);

        // Assert
        Assert.Contains(@"dynamic ""setting"" {", hcl);
        Assert.Contains("for_each = var.settings", hcl);
        Assert.Contains("iterator = setting", hcl);
        Assert.Contains("content {", hcl);
        Assert.Contains("namespace = setting.value.namespace", hcl);
        Assert.Contains("name = setting.value.name", hcl);
        Assert.Contains("value = setting.value.value", hcl);
    }

    [Fact]
    public void ToHcl_WithIndentation_PreservesIndentation()
    {
        // Arrange
        var context = TerraformContext.Temporary();
        context.PushIndent();

        var forEachExpr = TerraformExpression.Identifier("var.rules");
        var contentMap = new TerraformMapExpression
        {
            ["port"] = TerraformExpression.Literal(80)
        };

        var dynamicBlock = new TerraformDynamicBlockNode(
            "rule",
            forEachExpr,
            contentMap);

        // Act
        var hcl = dynamicBlock.ToHcl(context);

        // Assert
        Assert.StartsWith("  dynamic", hcl); // Should be indented
        Assert.Contains("\n    for_each", hcl); // Inner content should be double-indented
    }
}
