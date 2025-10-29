namespace EmmittJ.Terraform.Sdk.Tests;

public class TerraformVariableTests
{
    [Fact]
    public Task Variable_MinimalDeclaration()
    {
        var config = new TerraformConfiguration("main");
        var variable = new TerraformVariable("test_var");
        config.Add(variable);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Variable_WithDescription()
    {
        var config = new TerraformConfiguration("main");
        var variable = new TerraformVariable("test_var")
        {
            Description = "A test variable for demonstration"
        };
        config.Add(variable);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Variable_WithType()
    {
        var config = new TerraformConfiguration("main");
        var variable = new TerraformVariable("test_var")
        {
            Type = "string"
        };
        config.Add(variable);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Variable_WithDefault()
    {
        var config = new TerraformConfiguration("main");
        var variable = new TerraformVariable("test_var")
        {
            Default = "default_value"
        };
        config.Add(variable);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Variable_WithSensitive()
    {
        var config = new TerraformConfiguration("main");
        var variable = new TerraformVariable("password")
        {
            Type = "string",
            Sensitive = true
        };
        config.Add(variable);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Variable_Complete()
    {
        var config = new TerraformConfiguration("main");
        var variable = new TerraformVariable("aws_region")
        {
            Description = "AWS region to deploy resources",
            Type = "string",
            Default = "us-west-2",
            Sensitive = false
        };
        config.Add(variable);

        return Verify(config.ToHcl());
    }

    [Fact]
    public void Variable_GetReferenceExpression_ReturnsCorrectHcl()
    {
        var variable = new TerraformVariable("test_var");
        var expr = variable.GetReferenceExpression();

        Assert.Equal("var.test_var", expr.ToHcl());
    }

    [Fact]
    public void Variable_AsReference_CreatesReference()
    {
        var variable = new TerraformVariable("test_var");
        var reference = variable.AsReference();

        Assert.NotNull(reference);
        Assert.Equal("var.test_var", reference.ToExpression().ToHcl());
    }

    [Fact]
    public Task MultipleVariables_OrderedCorrectly()
    {
        var config = new TerraformConfiguration("main");

        var region = new TerraformVariable("region")
        {
            Description = "AWS region",
            Type = "string",
            Default = "us-east-1"
        };

        var environment = new TerraformVariable("environment")
        {
            Description = "Environment name",
            Type = "string"
        };

        var instanceCount = new TerraformVariable("instance_count")
        {
            Description = "Number of instances",
            Type = "number",
            Default = 3
        };

        config.Add(region);
        config.Add(environment);
        config.Add(instanceCount);

        return Verify(config.ToHcl());
    }
}
