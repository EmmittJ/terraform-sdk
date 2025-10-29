namespace EmmittJ.Terraform.Sdk.Tests;

public class TerraformResourceTests
{
    [Fact]
    public Task Resource_MinimalDeclaration()
    {
        var config = new TerraformConfiguration("main");
        var resource = new TerraformResource("aws_vpc", "main");
        config.Add(resource);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Resource_WithSingleProperty()
    {
        var config = new TerraformConfiguration("main");
        config.Add(new TerraformResource("aws_vpc", "main")
            .Set("cidr_block", "10.0.0.0/16"));

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Resource_WithMultipleProperties()
    {
        var config = new TerraformConfiguration("main");
        config.Add(new TerraformResource("aws_instance", "web")
            .Set("ami", "ami-12345678")
            .Set("instance_type", "t2.micro"));

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Resource_WithVariableReference()
    {
        var config = new TerraformConfiguration("main");

        var cidrVar = new TerraformVariable("vpc_cidr")
        {
            Default = "10.0.0.0/16",
            Type = "string"
        };
        config.Add(cidrVar);

        config.Add(new TerraformResource("aws_vpc", "main")
            .Set("cidr_block", cidrVar.AsReference()));

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Resource_WithResourceReference()
    {
        var config = new TerraformConfiguration("main");

        var vpc = new TerraformResource("aws_vpc", "main")
            .Set("cidr_block", "10.0.0.0/16")
            .DeclareOutput("id");
        config.Add(vpc);

        config.Add(new TerraformResource("aws_subnet", "public")
            .Set("vpc_id", vpc["id"])
            .Set("cidr_block", "10.0.1.0/24"));

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Resource_WithExpression()
    {
        var config = new TerraformConfiguration("main");

        config.Add(new TerraformResource("aws_subnet", "calculated")
            .Set("cidr_block",
                TerraformExpression.Raw("cidrsubnet(\"10.0.0.0/16\", 8, count.index)")));

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Resource_WithCount()
    {
        var config = new TerraformConfiguration("main");

        var resource = new TerraformResource("aws_subnet", "az")
        {
            Count = 3
        };
        config.Add(resource
            .Set("cidr_block",
                TerraformExpression.Raw("cidrsubnet(\"10.0.0.0/16\", 8, count.index)")));

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Resource_WithForEach()
    {
        var config = new TerraformConfiguration("main");

        var azs = new TerraformVariable("availability_zones")
        {
            Type = "set(string)"
        };
        config.Add(azs);

        var resource = new TerraformResource("aws_subnet", "az")
        {
            ForEach = new TerraformValue<object>(azs.AsReference())
        };
        config.Add(resource
            .Set("availability_zone", TerraformExpression.Identifier("each.value"))
            .Set("cidr_block", "10.0.1.0/24"));

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Resource_WithProvider()
    {
        var config = new TerraformConfiguration("main");

        var resource = new TerraformResource("aws_instance", "web")
        {
            Provider = "aws.west"
        };
        config.Add(resource.Set("ami", "ami-12345678"));

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Resource_WithDependsOn()
    {
        var config = new TerraformConfiguration("main");

        config.Add(new TerraformResource("aws_vpc", "main")
            .Set("cidr_block", "10.0.0.0/16"));

        config.Add(new TerraformResource("aws_internet_gateway", "main")
            .Set("vpc_id", "aws_vpc.main.id"));

        var route = new TerraformResource("aws_route", "internet");
        route.DependsOn.Add("aws_internet_gateway.main");
        config.Add(route
            .Set("route_table_id", "aws_route_table.main.id")
            .Set("gateway_id", "aws_internet_gateway.main.id"));

        return Verify(config.ToHcl());
    }

    [Fact]
    public void Resource_GetReferenceExpression()
    {
        var resource = new TerraformResource("aws_vpc", "main");
        var expr = resource.GetReferenceExpression();

        Assert.Equal("aws_vpc.main", expr.ToHcl());
    }

    [Fact]
    public void Resource_IndexerAccess_CreatesReference()
    {
        var resource = new TerraformResource("aws_vpc", "main");
        resource.DeclareOutput("cidr_block");
        var reference = resource["cidr_block"];

        Assert.NotNull(reference);
        Assert.Equal("aws_vpc.main.cidr_block", reference.ToExpression().ToHcl());
    }

    [Fact]
    public Task CompleteExample_MultipleResourcesWithReferences()
    {
        var config = new TerraformConfiguration("main");

        // Variables
        var cidr = new TerraformVariable("vpc_cidr")
        {
            Description = "VPC CIDR block",
            Type = "string",
            Default = "10.0.0.0/16"
        };
        config.Add(cidr);

        // VPC
        var vpc = new TerraformResource("aws_vpc", "main")
            .Set("cidr_block", cidr.AsReference())
            .DeclareOutput("id")
            .DeclareOutput("cidr_block");
        config.Add(vpc);

        // Subnet
        var subnet = new TerraformResource("aws_subnet", "public")
            .Set("vpc_id", vpc["id"])
            .Set("cidr_block",
                TerraformExpression.Raw("cidrsubnet(aws_vpc.main.cidr_block, 8, 1)"));
        config.Add(subnet);

        return Verify(config.ToHcl());
    }
}
