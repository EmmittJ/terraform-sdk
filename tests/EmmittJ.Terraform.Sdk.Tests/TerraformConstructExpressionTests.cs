namespace EmmittJ.Terraform.Sdk.Tests;

public class TerraformConstructExpressionTests
{
    [Fact]
    public Task Resource_WithProperties_GeneratesCorrectHcl()
    {
        // Create a map expression for the resource body
        var body = new TerraformMapExpression
        {
            { "cidr_block", TerraformExpression.Literal("10.0.0.0/16") },
            { "enable_dns_hostnames", TerraformExpression.Literal(true) }
        };

        var expr = new TerraformConstructExpression(
            "resource",
            ["aws_vpc", "main"],
            body);

        return Verify(expr.ToHcl());
    }

    [Fact]
    public Task DataSource_WithFilter_GeneratesCorrectHcl()
    {
        var body = new TerraformMapExpression
        {
            { "most_recent", TerraformExpression.Literal(true) },
            { "owners", TerraformExpression.Raw("[\"099720109477\"]") }
        };

        var expr = new TerraformConstructExpression(
            "data",
            ["aws_ami", "ubuntu"],
            body);

        return Verify(expr.ToHcl());
    }

    [Fact]
    public Task Output_WithValue_GeneratesCorrectHcl()
    {
        var body = new TerraformMapExpression
        {
            { "value", TerraformExpression.Identifier("aws_vpc.main.id") },
            { "description", TerraformExpression.Literal("The VPC ID") }
        };

        var expr = new TerraformConstructExpression(
            "output",
            ["vpc_id"],
            body);

        return Verify(expr.ToHcl());
    }

    [Fact]
    public Task Variable_WithType_GeneratesCorrectHcl()
    {
        var body = new TerraformMapExpression
        {
            { "type", TerraformExpression.Raw("string") },
            { "default", TerraformExpression.Literal("us-west-2") },
            { "description", TerraformExpression.Literal("The AWS region") }
        };

        var expr = new TerraformConstructExpression(
            "variable",
            ["region"],
            body);

        return Verify(expr.ToHcl());
    }

    [Fact]
    public Task Provider_WithConfig_GeneratesCorrectHcl()
    {
        var body = new TerraformMapExpression
        {
            { "region", TerraformExpression.Identifier("var.region") },
            { "profile", TerraformExpression.Literal("default") }
        };

        var expr = new TerraformConstructExpression(
            "provider",
            ["aws"],
            body);

        return Verify(expr.ToHcl());
    }

    [Fact]
    public Task Module_WithSource_GeneratesCorrectHcl()
    {
        var body = new TerraformMapExpression
        {
            { "source", TerraformExpression.Literal("./modules/vpc") },
            { "cidr_block", TerraformExpression.Literal("10.0.0.0/16") }
        };

        var expr = new TerraformConstructExpression(
            "module",
            ["vpc"],
            body);

        return Verify(expr.ToHcl());
    }

    [Fact]
    public Task Resource_Empty_GeneratesCorrectHcl()
    {
        var body = new TerraformMapExpression();

        var expr = new TerraformConstructExpression(
            "resource",
            ["null_resource", "example"],
            body);

        return Verify(expr.ToHcl());
    }

    [Fact]
    public Task Resource_WithNestedBlock_GeneratesCorrectHcl()
    {
        // Create a nested block (like timeouts or ingress)
        var nestedBlock = new TerraformMapExpression
        {
            { "create", TerraformExpression.Literal("60m") },
            { "delete", TerraformExpression.Literal("2h") }
        };

        var body = new TerraformMapExpression
        {
            { "name", TerraformExpression.Literal("example") },
            { "timeouts", nestedBlock }
        };

        var expr = new TerraformConstructExpression(
            "resource",
            ["azurerm_resource_group", "example"],
            body);

        return Verify(expr.ToHcl());
    }

    [Fact]
    public Task Resource_WithIndentation_MaintainsCorrectStructure()
    {
        var body = new TerraformMapExpression
        {
            { "ami", TerraformExpression.Literal("ami-12345678") },
            { "instance_type", TerraformExpression.Literal("t2.micro") },
            { "tags", new TerraformMapExpression
                {
                    { "Name", TerraformExpression.Literal("example-instance") },
                    { "Environment", TerraformExpression.Literal("dev") }
                }
            }
        };

        var expr = new TerraformConstructExpression(
            "resource",
            ["aws_instance", "web"],
            body);

        return Verify(expr.ToHcl());
    }

    [Fact]
    public void Constructor_NullBlockType_ThrowsArgumentNullException()
    {
        var body = new TerraformMapExpression();

        Assert.Throws<ArgumentNullException>(() =>
            new TerraformConstructExpression(null!, ["test"], body));
    }

    [Fact]
    public void Constructor_NullLabels_ThrowsArgumentNullException()
    {
        var body = new TerraformMapExpression();

        Assert.Throws<ArgumentNullException>(() =>
            new TerraformConstructExpression("resource", null!, body));
    }

    [Fact]
    public void Constructor_NullBody_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() =>
            new TerraformConstructExpression("resource", ["test", "name"], null!));
    }
}
