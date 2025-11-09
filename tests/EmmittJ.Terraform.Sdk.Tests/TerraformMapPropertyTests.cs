namespace EmmittJ.Terraform.Sdk.Tests;

/// <summary>
/// Tests for TerraformMapProperty&lt;TKey, TValue&gt;.
/// </summary>
public class TerraformMapPropertyTests
{
    [Fact]
    public void MapProperty_StringString_RendersCorrectly()
    {
        // Arrange - Using implicit conversion from Dictionary<string, string>
        var tags = new Dictionary<string, string>
        {
            ["Name"] = "MyInstance",
            ["Environment"] = "Production",
            ["Owner"] = "DevTeam"
        };

        TerraformMapProperty<string> property = tags;

        // Act
        var expr = property.Resolve();
        var hcl = expr.ToHcl();

        // Assert
        Assert.Contains("Name", hcl);
        Assert.Contains("\"MyInstance\"", hcl);
        Assert.Contains("Environment", hcl);
        Assert.Contains("\"Production\"", hcl);
        Assert.Contains("Owner", hcl);
        Assert.Contains("\"DevTeam\"", hcl);
    }

    [Fact]
    public void MapProperty_StringInt_RendersCorrectly()
    {
        // Arrange - Using implicit conversion
        var limits = new Dictionary<string, int>
        {
            ["MaxConnections"] = 100,
            ["TimeoutSeconds"] = 30,
            ["RetryCount"] = 3
        };

        TerraformMapProperty<int> property = limits;

        // Act
        var expr = property.Resolve();
        var hcl = expr.ToHcl();

        // Assert
        Assert.Contains("MaxConnections", hcl);
        Assert.Contains("100", hcl);
        Assert.Contains("TimeoutSeconds", hcl);
        Assert.Contains("30", hcl);
        Assert.Contains("RetryCount", hcl);
        Assert.Contains("3", hcl);
    }

    [Fact]
    public void MapProperty_StringObject_WithMixedTypes_RendersCorrectly()
    {
        // Arrange - Using implicit conversion (explicit cast)
        var config = new Dictionary<string, object>
        {
            ["name"] = "test-config",
            ["enabled"] = true,
            ["count"] = 5,
            ["threshold"] = 0.95
        };

        TerraformMapProperty<object> property = config;

        // Act
        var expr = property.Resolve();
        var hcl = expr.ToHcl();

        // Assert
        Assert.Contains("name", hcl);
        Assert.Contains("\"test-config\"", hcl);
        Assert.Contains("enabled", hcl);
        Assert.Contains("true", hcl);
        Assert.Contains("count", hcl);
        Assert.Contains("5", hcl);
        Assert.Contains("threshold", hcl);
        Assert.Contains("0.95", hcl);
    }

    [Fact]
    public void MapProperty_ImplicitConversion_FromDictionary()
    {
        // Arrange
        var tags = new Dictionary<string, string>
        {
            ["Project"] = "AspireApp",
            ["CostCenter"] = "Engineering"
        };

        // Act - Implicit conversion
        TerraformMapProperty<string> property = tags;
        var expr = property.Resolve();
        var hcl = expr.ToHcl();

        // Assert
        Assert.Contains("Project", hcl);
        Assert.Contains("\"AspireApp\"", hcl);
        Assert.Contains("CostCenter", hcl);
        Assert.Contains("\"Engineering\"", hcl);
    }

    [Fact]
    public void MapProperty_WithTerraformExpressions_RendersCorrectly()
    {
        // Arrange - Mix literals and expressions - TerraformMapProperty handles any value type
        var dynamicConfig = new Dictionary<string, object>
        {
            ["instance_type"] = TerraformExpression.Identifier("var.instance_type"),
            ["ami"] = "ami-12345",  // Literal string
            ["subnet_id"] = TerraformExpression.Raw("aws_subnet.main.id")
        };

        TerraformMapProperty<object> property = dynamicConfig;

        // Act
        var expr = property.Resolve();
        var hcl = expr.ToHcl();

        // Assert
        Assert.Contains("instance_type", hcl);
        Assert.Contains("var.instance_type", hcl);
        Assert.Contains("ami", hcl);
        Assert.Contains("\"ami-12345\"", hcl);
        Assert.Contains("subnet_id", hcl);
        Assert.Contains("aws_subnet.main.id", hcl);
    }

    [Fact]
    public Task MapProperty_InResource_RendersAsProperty()
    {
        // Arrange
        var resource = new TerraformResource("aws_instance", "example");
        var tags = new Dictionary<string, string>
        {
            ["Name"] = "TestInstance",
            ["Environment"] = "Development"
        };

        // Act - Using implicit conversion from Dictionary
        resource.WithProperty("tags", tags);

        var stack = new TerraformStack();
        stack.Add(resource);

        // Assert
        return Verify(stack.ToHcl());
    }

    [Fact]
    public void MapProperty_Prepare_PreparesNestedExpressions()
    {
        // Arrange
        var context = TerraformContext.Temporary();
        var resource = new TerraformResource("aws_vpc", "main");

        var config = new Dictionary<string, TerraformProperty<string>>
        {
            ["vpc_id"] = TerraformExpression.Raw("aws_vpc.main.id")
        };

        var property = new TerraformMapProperty<TerraformProperty<string>>(config);

        context.Scope.Add(resource);

        // Act - Prepare should track dependencies
        using (context.SetCurrentConstruct(resource))
        {
            property.Prepare(context);
        }

        // Assert - The prepare method should have been called on nested expressions
        var expr = property.Resolve(context);
        var hcl = expr.ToHcl();
        Assert.Contains("aws_vpc.main.id", hcl);
    }

    [Fact]
    public void MapProperty_WithNullValue_HandlesGracefully()
    {
        // Arrange - Using implicit conversion
        var config = new Dictionary<string, string?>
        {
            ["key1"] = "value1",
            ["key2"] = null,
            ["key3"] = "value3"
        };

        TerraformMapProperty<string?> property = config;

        // Act
        var expr = property.Resolve();
        var hcl = expr.ToHcl();

        // Assert
        Assert.Contains("key1", hcl);
        Assert.Contains("\"value1\"", hcl);
        Assert.Contains("key2", hcl);
        Assert.Contains("key3", hcl);
        Assert.Contains("\"value3\"", hcl);
    }

    [Fact]
    public void MapProperty_Empty_RendersEmptyObject()
    {
        // Arrange - Using implicit conversion
        var empty = new Dictionary<string, string>();
        TerraformMapProperty<string> property = empty;

        // Act
        var expr = property.Resolve();
        var hcl = expr.ToHcl();

        // Assert
        Assert.Contains("{", hcl);
        Assert.Contains("}", hcl);
    }
}
