namespace EmmittJ.Terraform.Sdk.Tests;

public class TerraformResourceTests
{
    [Fact]
    public Task Resource_MinimalDeclaration()
    {
        var config = new TerraformStack();
        var resource = new TerraformResource("aws_vpc", "main");
        config.Add(resource);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Resource_WithSingleProperty()
    {
        var config = new TerraformStack();
        config.Add(new TerraformResource("aws_vpc", "main")
            .WithProperty("cidr_block", "10.0.0.0/16"));

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Resource_WithMultipleProperties()
    {
        var config = new TerraformStack();
        config.Add(new TerraformResource("aws_instance", "web")
            .WithProperty("ami", "ami-12345678")
            .WithProperty("instance_type", "t2.micro"));

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Resource_WithVariableReference()
    {
        var config = new TerraformStack();

        var cidrVar = new TerraformVariable("vpc_cidr")
        {
            Default = "10.0.0.0/16",
            Type = "string"
        };
        config.Add(cidrVar);

        config.Add(new TerraformResource("aws_vpc", "main")
            .WithProperty("cidr_block", cidrVar.AsReference()));

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Resource_WithResourceReference()
    {
        var config = new TerraformStack();

        var vpc = new TerraformResource("aws_vpc", "main")
            .WithProperty("cidr_block", "10.0.0.0/16")
            .DeclareOutput("id");
        config.Add(vpc);

        config.Add(new TerraformResource("aws_subnet", "public")
            .WithProperty("vpc_id", vpc["id"])
            .WithProperty("cidr_block", "10.0.1.0/24"));

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Resource_WithExpression()
    {
        var config = new TerraformStack();

        config.Add(new TerraformResource("aws_subnet", "calculated")
            .WithProperty("cidr_block",
                TerraformExpression.Raw("cidrsubnet(\"10.0.0.0/16\", 8, count.index)")));

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Resource_WithCount()
    {
        var config = new TerraformStack();

        var resource = new TerraformResource("aws_subnet", "az")
        {
            Count = 3
        };
        config.Add(resource
            .WithProperty("cidr_block",
                TerraformExpression.Raw("cidrsubnet(\"10.0.0.0/16\", 8, count.index)")));

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Resource_WithForEach()
    {
        var config = new TerraformStack();

        var azs = new TerraformVariable("availability_zones")
        {
            Type = "set(string)"
        };
        config.Add(azs);

        var resource = new TerraformResource("aws_subnet", "az")
        {
            ForEach = azs.AsReference()
        };
        config.Add(resource
            .WithProperty("availability_zone", TerraformExpression.Identifier("each.value"))
            .WithProperty("cidr_block", "10.0.1.0/24"));

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Resource_WithProvider()
    {
        var config = new TerraformStack();

        var resource = new TerraformResource("aws_instance", "web")
        {
            Provider = "aws.west"
        };
        config.Add(resource.WithProperty("ami", "ami-12345678"));

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Resource_WithDependsOn()
    {
        var config = new TerraformStack();

        config.Add(new TerraformResource("aws_vpc", "main")
            .WithProperty("cidr_block", "10.0.0.0/16"));

        config.Add(new TerraformResource("aws_internet_gateway", "main")
            .WithProperty("vpc_id", "aws_vpc.main.id"));

        var route = new TerraformResource("aws_route", "internet");
        route.DependsOn.Add("aws_internet_gateway.main");
        config.Add(route
            .WithProperty("route_table_id", "aws_route_table.main.id")
            .WithProperty("gateway_id", "aws_internet_gateway.main.id"));

        return Verify(config.ToHcl());
    }

    [Fact]
    public void Resource_AsReference()
    {
        var resource = new TerraformResource("aws_vpc", "main");
        var expr = resource.AsReference();

        Assert.Equal("aws_vpc.main", expr.ToHcl());
    }

    [Fact]
    public void Resource_IndexerAccess_CreatesReference()
    {
        var resource = new TerraformResource("aws_vpc", "main");
        resource.DeclareOutput("cidr_block");
        var reference = resource["cidr_block"];

        Assert.NotNull(reference);
        Assert.Equal("aws_vpc.main.cidr_block", reference.ToHcl());
    }

    [Fact]
    public Task CompleteExample_MultipleResourcesWithReferences()
    {
        var config = new TerraformStack();

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
            .WithProperty("cidr_block", cidr.AsReference())
            .DeclareOutput("id")
            .DeclareOutput("cidr_block");
        config.Add(vpc);

        // Subnet
        var subnet = new TerraformResource("aws_subnet", "public")
            .WithProperty("vpc_id", vpc["id"])
            .WithProperty("cidr_block",
                TerraformExpression.Raw("cidrsubnet(aws_vpc.main.cidr_block, 8, 1)"));
        config.Add(subnet);

        return Verify(config.ToHcl());
    }
}

