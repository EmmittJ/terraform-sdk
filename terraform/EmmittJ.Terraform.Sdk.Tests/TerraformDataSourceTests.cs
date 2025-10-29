namespace EmmittJ.Terraform.Sdk.Tests;

public class TerraformDataSourceTests
{
    [Fact]
    public Task DataSource_BasicConfiguration_GeneratesHcl()
    {
        var dataSource = new TerraformDataSource("aws_ami", "ubuntu")
            .Set("most_recent", true)
            .Set("owners", "099720109477")
            .DeclareOutput("id");

        return Verify(dataSource.Resolve());
    }

    [Fact]
    public Task DataSource_WithCount_GeneratesHcl()
    {
        var dataSource = new TerraformDataSource("aws_availability_zones", "available")
        {
            Count = 3
        };
        dataSource.Set("state", "available");

        return Verify(dataSource.Resolve());
    }

    [Fact]
    public Task DataSource_WithForEach_GeneratesHcl()
    {
        var subnetIds = new TerraformVariable("subnet_ids") { Type = "set(string)" };
        var dataSource = new TerraformDataSource("aws_subnet", "selected")
        {
            ForEach = subnetIds.AsReference()
        };
        dataSource.Set("id", TerraformExpression.Identifier("each.value"));

        return Verify(dataSource.Resolve());
    }

    [Fact]
    public Task DataSource_WithProvider_GeneratesHcl()
    {
        var dataSource = new TerraformDataSource("aws_region", "current")
        {
            Provider = "aws.west"
        };

        return Verify(dataSource.Resolve());
    }

    [Fact]
    public Task DataSource_WithDependsOn_GeneratesHcl()
    {
        var dataSource = new TerraformDataSource("aws_vpc", "selected");
        dataSource.DependsOn.Add("aws_internet_gateway.main");
        dataSource.Set("id", "vpc-12345");

        return Verify(dataSource.Resolve());
    }

    [Fact]
    public Task DataSource_WithReference_GeneratesHcl()
    {
        var variable = new TerraformVariable("vpc_id") { Type = "string" };
        var dataSource = new TerraformDataSource("aws_vpc", "selected")
            .Set("id", variable.AsReference())
            .DeclareOutput("cidr_block");

        return Verify(dataSource.Resolve());
    }

    [Fact]
    public Task DataSource_WithExpression_GeneratesHcl()
    {
        var dataSource = new TerraformDataSource("aws_ami", "filtered")
            .Set("most_recent", TerraformExpression.Literal(true))
            .Set("owners", "self");

        return Verify(dataSource.Resolve());
    }

    [Fact]
    public void DataSource_GetReferenceExpression_ReturnsCorrectIdentifier()
    {
        var dataSource = new TerraformDataSource("aws_ami", "ubuntu");
        var expr = dataSource.GetReferenceExpression();

        Assert.Equal("data.aws_ami.ubuntu", expr.ToHcl());
    }

    [Fact]
    public void DataSource_GetOutput_ThrowsIfNotDeclared()
    {
        var dataSource = new TerraformDataSource("aws_ami", "ubuntu");

        var ex = Assert.Throws<InvalidOperationException>(() => dataSource["id"]);
        Assert.Contains("has not been declared as an output", ex.Message);
    }

    [Fact]
    public void DataSource_GetOutput_ReturnsReferenceWhenDeclared()
    {
        var dataSource = new TerraformDataSource("aws_ami", "ubuntu")
            .DeclareOutput("id");

        var reference = dataSource["id"];

        Assert.Equal("data.aws_ami.ubuntu.id", reference.ToExpression().ToHcl());
    }

    [Fact]
    public Task DataSource_FluentChaining_MaintainsType()
    {
        var dataSource = new TerraformDataSource("aws_ami", "ubuntu")
            .Set("most_recent", true)
            .Set("owners", "099720109477")
            .DeclareOutput("id")
            .DeclareOutput("name");

        // Verify fluent chaining returns TerraformDataSource
        Assert.IsType<TerraformDataSource>(dataSource);

        return Verify(dataSource.Resolve());
    }

    [Fact]
    public Task DataSource_InConfiguration_GeneratesHcl()
    {
        var config = new TerraformConfiguration();
        var dataSource = new TerraformDataSource("aws_ami", "ubuntu")
            .Set("most_recent", true)
            .DeclareOutput("id");

        config.Add(dataSource);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task DataSource_ComplexFilter_GeneratesHcl()
    {
        var dataSource = new TerraformDataSource("aws_ami", "ubuntu")
            .Set("most_recent", true)
            .Set("owners", "099720109477");

        // In real usage, this would be a complex object, but for now we use a simple value
        dataSource.Set("filter_name", "name");
        dataSource.Set("filter_values", "ubuntu/images/*");

        dataSource.DeclareOutput("id");

        return Verify(dataSource.Resolve());
    }

    [Fact]
    public Task DataSource_WithAllMetaArguments_GeneratesHcl()
    {
        var dataSource = new TerraformDataSource("aws_subnet", "selected")
        {
            Count = 2,
            Provider = "aws.west"
        };
        dataSource.DependsOn.Add("aws_vpc.main");
        dataSource.Set("vpc_id", "vpc-12345");
        dataSource.DeclareOutput("id");

        return Verify(dataSource.Resolve());
    }
}
