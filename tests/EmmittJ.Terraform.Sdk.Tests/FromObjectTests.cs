namespace EmmittJ.Terraform.Sdk.Tests;

/// <summary>
/// Tests for TerraformExpression.FromObject helper method.
/// </summary>
public class FromObjectTests
{
    [Fact]
    public void FromObject_String_CreatesLiteral()
    {
        // Arrange
        object value = "test";

        // Act
        var expr = TerraformExpression.FromObject(value);
        var hcl = expr.ToHcl();

        // Assert
        Assert.Equal("\"test\"", hcl);
    }

    [Fact]
    public void FromObject_Int_CreatesLiteral()
    {
        // Arrange
        object value = 42;

        // Act
        var expr = TerraformExpression.FromObject(value);
        var hcl = expr.ToHcl();

        // Assert
        Assert.Equal("42", hcl);
    }

    [Fact]
    public void FromObject_Bool_CreatesLiteral()
    {
        // Arrange
        object value = true;

        // Act
        var expr = TerraformExpression.FromObject(value);
        var hcl = expr.ToHcl();

        // Assert
        Assert.Equal("true", hcl);
    }

    [Fact]
    public void FromObject_Double_CreatesLiteral()
    {
        // Arrange
        object value = 3.14;

        // Act
        var expr = TerraformExpression.FromObject(value);
        var hcl = expr.ToHcl();

        // Assert
        Assert.Equal("3.14", hcl);
    }

    [Fact]
    public void FromObject_TerraformExpression_ReturnsAsIs()
    {
        // Arrange
        object value = TerraformExpression.Identifier("var.test");

        // Act
        var expr = TerraformExpression.FromObject(value);
        var hcl = expr.ToHcl();

        // Assert
        Assert.Equal("var.test", hcl);
    }

    [Fact]
    public void FromObject_OtherType_UsesToString()
    {
        // Arrange
        object value = new DateTime(2025, 10, 31);

        // Act
        var expr = TerraformExpression.FromObject(value);
        var hcl = expr.ToHcl();

        // Assert - Should convert to string representation
        Assert.Contains("2025", hcl);
        Assert.Contains("10", hcl);
        Assert.Contains("31", hcl);
    }

    [Fact]
    public void DictionaryOfObject_ResolvesDirectly()
    {
        // Arrange
        var dict = new Dictionary<string, object>
        {
            ["string_val"] = "test",
            ["int_val"] = 42,
            ["bool_val"] = true,
            ["double_val"] = 3.14,
            ["expr_val"] = TerraformExpression.Identifier("var.test")
        };

        // Act - Dictionaries are resolved directly via TerraformValueResolver
        var expr = TerraformValueResolver.ResolveValue(dict, null);
        var hcl = expr.ToHcl();

        // Assert
        Assert.Contains("string_val", hcl);
        Assert.Contains("\"test\"", hcl);
        Assert.Contains("int_val", hcl);
        Assert.Contains("42", hcl);
        Assert.Contains("bool_val", hcl);
        Assert.Contains("true", hcl);
        Assert.Contains("double_val", hcl);
        Assert.Contains("3.14", hcl);
        Assert.Contains("expr_val", hcl);
        Assert.Contains("var.test", hcl);
    }

    [Fact]
    public void TerraformMapExpression_WithDictionaryOfObject_RendersCorrectly()
    {
        // Arrange
        var config = new TerraformStack
        {
            Name = "test",
            Terraform = new TerraformSettings
            {
                Backend = new TerraformBackend("s3")
                {
                    ["bucket"] = TerraformExpression.Literal("my-bucket"),
                    ["key"] = TerraformExpression.Literal("terraform.tfstate"),
                    ["region"] = TerraformExpression.Literal("us-west-2"),
                    ["encrypt"] = TerraformExpression.Literal(true),
                    ["version"] = TerraformExpression.Literal(5)
                }
            }
        };

        // Act
        var hcl = config.ToHcl();

        // Assert
        Assert.Contains("backend \"s3\"", hcl);
        Assert.Contains("bucket = \"my-bucket\"", hcl);
        Assert.Contains("encrypt = true", hcl);
        Assert.Contains("version = 5", hcl);
    }
}

