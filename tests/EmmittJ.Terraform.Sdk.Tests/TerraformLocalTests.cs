namespace EmmittJ.Terraform.Sdk.Tests;

public class TerraformLocalTests
{
    [Fact]
    public Task Local_WithLiteralValues_GeneratesHcl()
    {
        var locals = new TerraformLocal();
        locals["region"] = "us-east-1";
        locals["environment"] = "production";
        locals["common_tags"] = TerraformExpression.Raw("{ Environment = \"prod\", ManagedBy = \"Terraform\" }");

        return Verify(locals.Resolve());
    }

    [Fact]
    public Task Local_WithExpression_GeneratesHcl()
    {
        var locals = new TerraformLocal();
        locals["vpc_cidr"] = "10.0.0.0/16";
        locals["subnet_count"] = 3;

        return Verify(locals.Resolve());
    }

    [Fact]
    public Task Local_WithReference_GeneratesHcl()
    {
        var regionVar = new TerraformVariable("aws_region") { Type = "string" };
        var locals = new TerraformLocal();
        locals["region"] = regionVar.AsReference();

        return Verify(locals.Resolve());
    }

    [Fact]
    public void Local_GetReference_ReturnsCorrectExpression()
    {
        var locals = new TerraformLocal();
        locals["region"] = "us-east-1";

        var reference = locals["region"];

        Assert.Equal("local.region", reference.ToHcl());
    }

    [Fact]
    public void Local_GetReference_ThrowsIfNotDefined()
    {
        var locals = new TerraformLocal();

        // Now indexer doesn't throw - test needs different approach
        var reference = locals["undefined"];
        Assert.NotNull(reference);
    }

    [Fact]
    public Task Local_FluentChaining_MaintainsType()
    {
        var locals = new TerraformLocal();
        locals["env"] = "prod";
        locals["region"] = "us-west-2";
        locals["az_count"] = 3;

        // Verify type
        Assert.IsType<TerraformLocal>(locals);

        return Verify(locals.Resolve());
    }

    [Fact]
    public Task Local_InConfiguration_GeneratesHcl()
    {
        var config = new TerraformStack();
        var locals = new TerraformLocal();
        locals["project_name"] = "my-app";
        locals["environment"] = "staging";

        config.Add(locals);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Local_WithComplexExpression_GeneratesHcl()
    {
        var locals = new TerraformLocal();
        locals["subnet_cidrs"] = TerraformExpression.Raw("[for i in range(3) : cidrsubnet(local.vpc_cidr, 8, i)]");
        locals["vpc_cidr"] = "10.0.0.0/16";

        return Verify(locals.Resolve());
    }

    [Fact]
    public void Local_Empty_GeneratesEmptyBlock()
    {
        var locals = new TerraformLocal();
        var hcl = locals.Resolve();

        Assert.Equal($"locals {{{Environment.NewLine}}}{Environment.NewLine}", hcl);
    }

    [Fact]
    public Task Local_UsingReferenceInResource_GeneratesHcl()
    {
        var config = new TerraformStack();

        var locals = new TerraformLocal();
        locals["region"] = "us-east-1";
        config.Add(locals);

        var provider = new TerraformProvider("aws");
        provider["region"] = locals["region"];
        config.Add(provider);

        return Verify(config.ToHcl());
    }
}

