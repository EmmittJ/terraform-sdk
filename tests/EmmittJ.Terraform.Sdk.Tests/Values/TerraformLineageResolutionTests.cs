using EmmittJ.Terraform.Sdk;
using Xunit;

namespace EmmittJ.Terraform.Sdk.Tests.Values;

/// <summary>
/// Tests for how TerraformValue resolves when lineage is present.
/// Validates that lineage takes precedence over inner values when resolving.
/// </summary>
[Trait("Category", "Unit")]
[Trait("Layer", "Values")]
public class TerraformLineageResolutionTests
{
    private static ITerraformContext CreateContext() => TerraformContext.Temporary();

    #region Value Without Lineage

    [Fact]
    public void Value_WithoutLineage_ResolvesToLiteral()
    {
        TerraformValue<string> value = "my-value";
        var context = CreateContext();

        var nodes = value.ResolveNodes(context).ToList();

        Assert.Single(nodes);
        var expr = Assert.IsAssignableFrom<TerraformExpression>(nodes[0]);
        Assert.Equal("\"my-value\"", expr.ToHcl(context));
    }

    [Fact]
    public void Value_WithoutLineage_IntegerResolvesToLiteral()
    {
        TerraformValue<int> value = 42;
        var context = CreateContext();

        var nodes = value.ResolveNodes(context).ToList();

        Assert.Single(nodes);
        var expr = Assert.IsAssignableFrom<TerraformExpression>(nodes[0]);
        Assert.Equal("42", expr.ToHcl(context));
    }

    [Fact]
    public void Value_WithoutLineage_BooleanResolvesToLiteral()
    {
        TerraformValue<bool> value = true;
        var context = CreateContext();

        var nodes = value.ResolveNodes(context).ToList();

        Assert.Single(nodes);
        var expr = Assert.IsAssignableFrom<TerraformExpression>(nodes[0]);
        Assert.Equal("true", expr.ToHcl(context));
    }

    #endregion

    #region Value With Lineage

    [Fact]
    public void Value_WithLineage_ResolvesToReference()
    {
        TerraformValue<string> value = "my-value";
        value.Lineage = new TerraformLineage("aws_vpc.main").WithMember("id");
        var context = CreateContext();

        var nodes = value.ResolveNodes(context).ToList();

        Assert.Single(nodes);
        var expr = Assert.IsAssignableFrom<TerraformExpression>(nodes[0]);
        Assert.Equal("aws_vpc.main.id", expr.ToHcl(context));
    }

    [Fact]
    public void Value_WithLineage_IgnoresInnerValue()
    {
        // Even though the inner value is "literal-value", lineage should take precedence
        TerraformValue<string> value = "literal-value";
        value.Lineage = new TerraformLineage("aws_instance.web").WithMember("private_ip");
        var context = CreateContext();

        var nodes = value.ResolveNodes(context).ToList();

        Assert.Single(nodes);
        var expr = Assert.IsAssignableFrom<TerraformExpression>(nodes[0]);
        Assert.Equal("aws_instance.web.private_ip", expr.ToHcl(context));
    }

    [Fact]
    public void Value_WithLineage_ComplexPath()
    {
        TerraformValue<string> value = "ignored";
        value.Lineage = new TerraformLineage("azurerm_container_app.app")
            .WithMember("ingress")
            .WithIndex(0)
            .WithMember("fqdn");
        var context = CreateContext();

        var nodes = value.ResolveNodes(context).ToList();

        Assert.Single(nodes);
        var expr = Assert.IsAssignableFrom<TerraformExpression>(nodes[0]);
        Assert.Equal("azurerm_container_app.app.ingress[0].fqdn", expr.ToHcl(context));
    }

    #endregion

    #region WithLineage Method

    [Fact]
    public void WithLineage_CreatesNewValueWithLineage()
    {
        TerraformValue<string> original = "my-value";
        var lineage = new TerraformLineage("aws_vpc.main").WithMember("cidr_block");

        var withLineage = original.WithLineage(lineage);

        Assert.Null(original.Lineage);
        Assert.NotNull(withLineage.Lineage);
        Assert.Equal(lineage, withLineage.Lineage);
    }

    [Fact]
    public void WithLineage_NewValueResolvesToReference()
    {
        TerraformValue<string> original = "10.0.0.0/16";
        var lineage = new TerraformLineage("aws_vpc.main").WithMember("cidr_block");
        var context = CreateContext();

        var withLineage = original.WithLineage(lineage);
        var nodes = withLineage.ResolveNodes(context).ToList();

        Assert.Single(nodes);
        var expr = Assert.IsAssignableFrom<TerraformExpression>(nodes[0]);
        Assert.Equal("aws_vpc.main.cidr_block", expr.ToHcl(context));
    }

    [Fact]
    public void WithLineage_OriginalStillResolvesToLiteral()
    {
        TerraformValue<string> original = "10.0.0.0/16";
        var lineage = new TerraformLineage("aws_vpc.main").WithMember("cidr_block");
        var context = CreateContext();

        _ = original.WithLineage(lineage);
        var nodes = original.ResolveNodes(context).ToList();

        Assert.Single(nodes);
        var expr = Assert.IsAssignableFrom<TerraformExpression>(nodes[0]);
        Assert.Equal("\"10.0.0.0/16\"", expr.ToHcl(context));
    }

    [Fact]
    public void WithLineage_NullLineage_ClearsLineage()
    {
        TerraformValue<string> value = "my-value";
        value.Lineage = new TerraformLineage("aws_vpc.main").WithMember("id");
        var context = CreateContext();

        var cleared = value.WithLineage(null);
        var nodes = cleared.ResolveNodes(context).ToList();

        Assert.Single(nodes);
        var expr = Assert.IsAssignableFrom<TerraformExpression>(nodes[0]);
        Assert.Equal("\"my-value\"", expr.ToHcl(context));
    }

    #endregion

    #region Lineage Propagation Through Assignment

    [Fact]
    public void Assignment_ValueWithLineage_PreservesLineage()
    {
        TerraformValue<string> source = "original";
        source.Lineage = new TerraformLineage("aws_vpc.main").WithMember("id");

        TerraformValue<string> target = source;
        var context = CreateContext();

        var nodes = target.ResolveNodes(context).ToList();
        Assert.Single(nodes);
        var expr = Assert.IsAssignableFrom<TerraformExpression>(nodes[0]);
        Assert.Equal("aws_vpc.main.id", expr.ToHcl(context));
    }

    #endregion
}
