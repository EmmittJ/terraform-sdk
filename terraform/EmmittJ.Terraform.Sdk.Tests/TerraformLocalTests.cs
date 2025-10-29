namespace EmmittJ.Terraform.Sdk.Tests;

public class TerraformLocalTests
{
    [Fact]
    public Task Local_WithLiteralValues_GeneratesHcl()
    {
        var locals = new TerraformLocal()
            .Set("region", "us-east-1")
            .Set("environment", "production")
            .Set("common_tags", TerraformExpression.Raw("{ Environment = \"prod\", ManagedBy = \"Terraform\" }"));

        return Verify(locals.Resolve());
    }

    [Fact]
    public Task Local_WithExpression_GeneratesHcl()
    {
        var locals = new TerraformLocal()
            .Set("vpc_cidr", "10.0.0.0/16")
            .Set("subnet_count", 3);

        return Verify(locals.Resolve());
    }

    [Fact]
    public Task Local_WithReference_GeneratesHcl()
    {
        var regionVar = new TerraformVariable("aws_region") { Type = "string" };
        var locals = new TerraformLocal()
            .Set("region", regionVar.AsReference());

        return Verify(locals.Resolve());
    }

    [Fact]
    public void Local_GetReference_ReturnsCorrectExpression()
    {
        var locals = new TerraformLocal()
            .Set("region", "us-east-1");

        var reference = locals["region"];

        Assert.Equal("local.region", reference.ToExpression().ToHcl());
    }

    [Fact]
    public void Local_GetReference_ThrowsIfNotDefined()
    {
        var locals = new TerraformLocal();

        var ex = Assert.Throws<InvalidOperationException>(() => locals["undefined"]);
        Assert.Contains("has not been defined", ex.Message);
    }

    [Fact]
    public Task Local_FluentChaining_MaintainsType()
    {
        var locals = new TerraformLocal()
            .Set("env", "prod")
            .Set("region", "us-west-2")
            .Set("az_count", 3);

        // Verify fluent chaining returns TerraformLocal
        Assert.IsType<TerraformLocal>(locals);

        return Verify(locals.Resolve());
    }

    [Fact]
    public Task Local_InConfiguration_GeneratesHcl()
    {
        var config = new TerraformConfiguration();
        var locals = new TerraformLocal()
            .Set("project_name", "my-app")
            .Set("environment", "staging");

        config.Add(locals);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Local_WithComplexExpression_GeneratesHcl()
    {
        var locals = new TerraformLocal()
            .Set("subnet_cidrs", TerraformExpression.Raw("[for i in range(3) : cidrsubnet(local.vpc_cidr, 8, i)]"))
            .Set("vpc_cidr", "10.0.0.0/16");

        return Verify(locals.Resolve());
    }

    [Fact]
    public void Local_Empty_GeneratesEmptyString()
    {
        var locals = new TerraformLocal();
        var hcl = locals.Resolve();

        Assert.Equal(string.Empty, hcl);
    }

    [Fact]
    public Task Local_UsingReferenceInResource_GeneratesHcl()
    {
        var config = new TerraformConfiguration();

        var locals = new TerraformLocal()
            .Set("region", "us-east-1");
        config.Add(locals);

        var provider = new TerraformProvider("aws")
            .Set("region", locals["region"]);
        config.Add(provider);

        return Verify(config.ToHcl());
    }
}
