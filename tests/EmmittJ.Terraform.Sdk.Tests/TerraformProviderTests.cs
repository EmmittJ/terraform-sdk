namespace EmmittJ.Terraform.Sdk.Tests;

public class TerraformProviderTests
{
    [Fact]
    public Task Provider_BasicConfiguration_GeneratesHcl()
    {
        var provider = new TerraformProvider("aws");
        provider["region"] = "us-east-1";

        return Verify(provider.Resolve());
    }

    [Fact]
    public Task Provider_WithAlias_GeneratesHcl()
    {
        var provider = new TerraformProvider("aws")
        {
            Alias = "west"
        };
        provider["region"] = "us-west-2";

        return Verify(provider.Resolve());
    }

    [Fact]
    public Task Provider_WithMultipleProperties_GeneratesHcl()
    {
        var provider = new TerraformProvider("azurerm");
        provider["features"] = TerraformExpression.Raw("{}");
        provider["subscription_id"] = "12345-67890";
        provider["tenant_id"] = "abcde-fghij";

        return Verify(provider.Resolve());
    }

    [Fact]
    public Task Provider_WithReference_GeneratesHcl()
    {
        var regionVar = new TerraformVariable("aws_region") { Type = "string" };
        var provider = new TerraformProvider("aws");
        provider["region"] = regionVar.AsReference();

        return Verify(provider.Resolve());
    }

    [Fact]
    public Task Provider_WithExpression_GeneratesHcl()
    {
        var provider = new TerraformProvider("aws");
        provider["region"] = TerraformExpression.Identifier("var.region");
        provider["skip_metadata_api_check"] = true;

        return Verify(provider.Resolve());
    }

    [Fact]
    public void Provider_AsReference_WithoutAlias_ReturnsName()
    {
        var provider = new TerraformProvider("aws");
        var expr = provider.AsReference();

        Assert.Equal("aws", expr.ToHcl());
    }

    [Fact]
    public void Provider_AsReference_WithAlias_ReturnsNameAndAlias()
    {
        var provider = new TerraformProvider("aws") { Alias = "west" };
        var expr = provider.AsReference();

        Assert.Equal("aws.west", expr.ToHcl());
    }

    [Fact]
    public Task Provider_FluentChaining_MaintainsType()
    {
        var provider = new TerraformProvider("google");
        provider["project"] = "my-project";
        provider["region"] = "us-central1";
        provider["zone"] = "us-central1-a";

        // Verify type
        Assert.IsType<TerraformProvider>(provider);

        return Verify(provider.Resolve());
    }

    [Fact]
    public Task Provider_InConfiguration_GeneratesHcl()
    {
        var config = new TerraformStack();
        var provider = new TerraformProvider("aws");
        provider["region"] = "us-east-1";

        config.Add(provider);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Provider_MultipleAliases_GeneratesHcl()
    {
        var config = new TerraformStack();

        var eastProvider = new TerraformProvider("aws")
        {
            Alias = "east"
        };
        eastProvider["region"] = "us-east-1";

        var westProvider = new TerraformProvider("aws")
        {
            Alias = "west"
        };
        westProvider["region"] = "us-west-2";

        config.Add(eastProvider);
        config.Add(westProvider);

        return Verify(config.ToHcl());
    }
}

