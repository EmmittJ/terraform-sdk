namespace EmmittJ.Terraform.Sdk.Tests;

public class TerraformOutputTests
{
    [Fact]
    public Task Output_WithLiteralValue_GeneratesHcl()
    {
        var output = new TerraformOutput("vpc_id")
        {
            Value = "vpc-12345"
        };

        return Verify(output.Resolve());
    }

    [Fact]
    public Task Output_WithResourceReference_GeneratesHcl()
    {
        var vpc = new TerraformResource("aws_vpc", "main");
        vpc.WithOutput("id");

        var output = new TerraformOutput("vpc_id")
        {
            Value = vpc["id"]
        };

        return Verify(output.Resolve());
    }

    [Fact]
    public Task Output_WithDescription_GeneratesHcl()
    {
        var output = new TerraformOutput("region")
        {
            Value = "us-east-1",
            Description = "The AWS region"
        };

        return Verify(output.Resolve());
    }

    [Fact]
    public Task Output_WithSensitive_GeneratesHcl()
    {
        var output = new TerraformOutput("db_password")
        {
            Value = "super-secret",
            Sensitive = true
        };

        return Verify(output.Resolve());
    }

    [Fact]
    public Task Output_WithDependsOn_GeneratesHcl()
    {
        var output = new TerraformOutput("endpoint")
        {
            Value = "https://example.com"
        };
        output.DependsOn.Add("aws_instance.web");

        return Verify(output.Resolve());
    }

    [Fact]
    public Task Output_WithAllAttributes_GeneratesHcl()
    {
        var output = new TerraformOutput("connection_string")
        {
            Value = "postgres://localhost:5432/mydb",
            Description = "Database connection string",
            Sensitive = true
        };
        output.DependsOn.Add("aws_db_instance.main");

        return Verify(output.Resolve());
    }

    [Fact]
    public Task Output_WithExpression_GeneratesHcl()
    {
        var output = new TerraformOutput("subnet_ids")
        {
            Value = TerraformExpression.Raw("[for s in aws_subnet.private : s.id]")
        };

        return Verify(output.Resolve());
    }

    [Fact]
    public void Output_WithoutValue_ThrowsException()
    {
        var output = new TerraformOutput("test");

        var ex = Assert.Throws<TerraformStackException>(() => output.Resolve());
        Assert.Contains("must have a value set", ex.Message);
    }

    [Fact]
    public Task Output_InConfiguration_GeneratesHcl()
    {
        var config = new TerraformStack();
        var output = new TerraformOutput("vpc_id")
        {
            Value = "vpc-12345",
            Description = "VPC ID"
        };

        config.Add(output);

        return Verify(config.ToHcl());
    }

    [Fact]
    public void Output_AsReference_ReturnsCorrectIdentifier()
    {
        var output = new TerraformOutput("vpc_id");
        var expr = output.AsReference();

        Assert.Equal("output.vpc_id", expr.ToHcl());
    }
}
