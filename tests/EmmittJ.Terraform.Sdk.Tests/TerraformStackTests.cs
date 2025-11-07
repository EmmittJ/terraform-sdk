namespace EmmittJ.Terraform.Sdk.Tests;

public class TerraformStackTests
{
    [Fact]
    public Task Configuration_Empty()
    {
        var config = new TerraformStack();

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Configuration_WithSingleVariable()
    {
        var config = new TerraformStack();
        var variable = new TerraformVariable("region")
        {
            Default = "us-east-1"
        };
        config.Add(variable);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Configuration_WithSingleResource()
    {
        var config = new TerraformStack();
        var resource = new TerraformResource("aws_vpc", "main")
            .WithProperty("cidr_block", "10.0.0.0/16");
        config.Add(resource);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Configuration_OrganizesByType()
    {
        var config = new TerraformStack();

        // Add in mixed order
        config.Add(new TerraformResource("aws_vpc", "main")
            .WithProperty("cidr_block", "10.0.0.0/16"));

        config.Add(new TerraformVariable("region"));

        config.Add(new TerraformResource("aws_subnet", "public")
            .WithProperty("cidr_block", "10.0.1.0/24"));

        config.Add(new TerraformVariable("environment"));

        // Verify they're organized: variables first, then resources
        return Verify(config.ToHcl());
    }

    [Fact]
    public void Configuration_Constructs_AreAccessible()
    {
        var config = new TerraformStack()
        {
            Name = "my-config"
        };
        var variable = new TerraformVariable("test");
        config.Add(variable);

        Assert.Single(config.Constructs);
        Assert.Contains(variable, config.Constructs);
    }
}

