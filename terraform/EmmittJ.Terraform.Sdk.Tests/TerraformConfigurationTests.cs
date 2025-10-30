namespace EmmittJ.Terraform.Sdk.Tests;

public class TerraformConfigurationTests
{
    [Fact]
    public Task Configuration_Empty()
    {
        var config = new TerraformConfiguration("main");

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Configuration_WithSingleVariable()
    {
        var config = new TerraformConfiguration("main");
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
        var config = new TerraformConfiguration("main");
        var resource = new TerraformResource("aws_vpc", "main")
            .WithProperty("cidr_block", "10.0.0.0/16");
        config.Add(resource);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Configuration_OrganizesByType()
    {
        var config = new TerraformConfiguration("main");

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
        var config = new TerraformConfiguration("my-config");
        var variable = new TerraformVariable("test");
        config.Add(variable);

        Assert.Single(config.Constructs);
        Assert.Contains(variable, config.Constructs);
    }
}

