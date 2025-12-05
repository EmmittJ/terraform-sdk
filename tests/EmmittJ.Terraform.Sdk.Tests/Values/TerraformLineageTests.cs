using EmmittJ.Terraform.Sdk;
using Xunit;

namespace EmmittJ.Terraform.Sdk.Tests.Values;

/// <summary>
/// Unit tests for TerraformLineage and path segment construction.
/// Tests the core lineage building blocks in isolation.
/// </summary>
[Trait("Category", "Unit")]
[Trait("Layer", "Values")]
public class TerraformLineageTests
{
    private static ITerraformContext CreateContext() => TerraformContext.Temporary();

    #region Lineage Creation

    [Fact]
    public void Lineage_WithIdentifier_CreatesSingleSegmentPath()
    {
        var lineage = new TerraformLineage("aws_vpc.main");

        Assert.Single(lineage.Path);
        Assert.IsType<IdentifierSegment>(lineage.Path[0]);
        Assert.Equal("aws_vpc.main", ((IdentifierSegment)lineage.Path[0]).Identifier);
    }

    [Fact]
    public void Lineage_WithMember_AppendsSegment()
    {
        var lineage = new TerraformLineage("aws_vpc.main")
            .WithMember("id");

        Assert.Equal(2, lineage.Path.Length);
        Assert.IsType<IdentifierSegment>(lineage.Path[0]);
        Assert.IsType<MemberSegment>(lineage.Path[1]);
        Assert.Equal("id", ((MemberSegment)lineage.Path[1]).Name);
    }

    [Fact]
    public void Lineage_WithIndex_AppendsSegment()
    {
        var lineage = new TerraformLineage("aws_instance.web")
            .WithMember("ebs_block_device")
            .WithIndex(0);

        Assert.Equal(3, lineage.Path.Length);
        Assert.IsType<IndexSegment>(lineage.Path[2]);
        Assert.Equal(0, ((IndexSegment)lineage.Path[2]).Index);
    }

    [Fact]
    public void Lineage_WithKey_AppendsSegment()
    {
        var lineage = new TerraformLineage("aws_instance.web")
            .WithMember("tags")
            .WithKey("Environment");

        Assert.Equal(3, lineage.Path.Length);
        Assert.IsType<KeySegment>(lineage.Path[2]);
        Assert.Equal("Environment", ((KeySegment)lineage.Path[2]).Key);
    }

    [Fact]
    public void Lineage_IsImmutable_OriginalUnchanged()
    {
        var original = new TerraformLineage("aws_vpc.main");
        var extended = original.WithMember("id");

        Assert.Single(original.Path);
        Assert.Equal(2, extended.Path.Length);
    }

    [Fact]
    public void Lineage_ChainedExtensions_BuildCorrectPath()
    {
        var lineage = new TerraformLineage("aws_instance.web")
            .WithMember("network_interface")
            .WithIndex(0)
            .WithMember("private_ip");

        Assert.Equal(4, lineage.Path.Length);
        Assert.IsType<IdentifierSegment>(lineage.Path[0]);
        Assert.IsType<MemberSegment>(lineage.Path[1]);
        Assert.IsType<IndexSegment>(lineage.Path[2]);
        Assert.IsType<MemberSegment>(lineage.Path[3]);
    }

    #endregion

    #region BuildExpression

    [Fact]
    public void BuildExpression_Identifier_ReturnsIdentifierExpression()
    {
        var lineage = new TerraformLineage("aws_vpc.main");
        var context = CreateContext();

        var expr = lineage.BuildExpression();

        Assert.Equal("aws_vpc.main", expr.ToHcl(context));
    }

    [Fact]
    public void BuildExpression_IdentifierWithMember_ReturnsMemberAccess()
    {
        var lineage = new TerraformLineage("aws_vpc.main")
            .WithMember("id");
        var context = CreateContext();

        var expr = lineage.BuildExpression();

        Assert.Equal("aws_vpc.main.id", expr.ToHcl(context));
    }

    [Fact]
    public void BuildExpression_WithIndex_ReturnsIndexExpression()
    {
        var lineage = new TerraformLineage("aws_instance.web")
            .WithMember("ebs_block_device")
            .WithIndex(0);
        var context = CreateContext();

        var expr = lineage.BuildExpression();

        Assert.Equal("aws_instance.web.ebs_block_device[0]", expr.ToHcl(context));
    }

    [Fact]
    public void BuildExpression_WithKey_ReturnsKeyExpression()
    {
        var lineage = new TerraformLineage("aws_instance.web")
            .WithMember("tags")
            .WithKey("Environment");
        var context = CreateContext();

        var expr = lineage.BuildExpression();

        Assert.Equal("aws_instance.web.tags[\"Environment\"]", expr.ToHcl(context));
    }

    [Fact]
    public void BuildExpression_ComplexPath_ChainsCorrectly()
    {
        var lineage = new TerraformLineage("azurerm_container_app.app")
            .WithMember("ingress")
            .WithIndex(0)
            .WithMember("fqdn");
        var context = CreateContext();

        var expr = lineage.BuildExpression();

        Assert.Equal("azurerm_container_app.app.ingress[0].fqdn", expr.ToHcl(context));
    }

    [Fact]
    public void BuildExpression_DataSource_HandlesDataPrefix()
    {
        var lineage = new TerraformLineage("data.aws_ami.ubuntu")
            .WithMember("id");
        var context = CreateContext();

        var expr = lineage.BuildExpression();

        Assert.Equal("data.aws_ami.ubuntu.id", expr.ToHcl(context));
    }

    [Fact]
    public void BuildExpression_Variable_HandlesVarPrefix()
    {
        var lineage = new TerraformLineage("var")
            .WithMember("location");
        var context = CreateContext();

        var expr = lineage.BuildExpression();

        Assert.Equal("var.location", expr.ToHcl(context));
    }

    [Fact]
    public void BuildExpression_Local_HandlesLocalPrefix()
    {
        var lineage = new TerraformLineage("local")
            .WithMember("common_tags");
        var context = CreateContext();

        var expr = lineage.BuildExpression();

        Assert.Equal("local.common_tags", expr.ToHcl(context));
    }

    #endregion

    #region Path Segment Apply

    [Fact]
    public void IdentifierSegment_Apply_IgnoresSource()
    {
        var segment = new IdentifierSegment("aws_vpc.main");
        var someExpr = TerraformExpression.Identifier("other");
        var context = CreateContext();

        var result = segment.Apply(someExpr);

        Assert.Equal("aws_vpc.main", result.ToHcl(context));
    }

    [Fact]
    public void MemberSegment_Apply_RequiresSource()
    {
        var segment = new MemberSegment("id");

        Assert.Throws<InvalidOperationException>(() => segment.Apply(null));
    }

    [Fact]
    public void MemberSegment_Apply_ExtendSource()
    {
        var segment = new MemberSegment("id");
        var source = TerraformExpression.Identifier("aws_vpc.main");
        var context = CreateContext();

        var result = segment.Apply(source);

        Assert.Equal("aws_vpc.main.id", result.ToHcl(context));
    }

    [Fact]
    public void IndexSegment_Apply_RequiresSource()
    {
        var segment = new IndexSegment(0);

        Assert.Throws<InvalidOperationException>(() => segment.Apply(null));
    }

    [Fact]
    public void IndexSegment_Apply_ExtendSource()
    {
        var segment = new IndexSegment(0);
        var source = TerraformExpression.Identifier("aws_instance.web").Member("ebs_block_device");
        var context = CreateContext();

        var result = segment.Apply(source);

        Assert.Equal("aws_instance.web.ebs_block_device[0]", result.ToHcl(context));
    }

    [Fact]
    public void KeySegment_Apply_RequiresSource()
    {
        var segment = new KeySegment("Environment");

        Assert.Throws<InvalidOperationException>(() => segment.Apply(null));
    }

    [Fact]
    public void KeySegment_Apply_ExtendSource()
    {
        var segment = new KeySegment("Environment");
        var source = TerraformExpression.Identifier("aws_instance.web").Member("tags");
        var context = CreateContext();

        var result = segment.Apply(source);

        Assert.Equal("aws_instance.web.tags[\"Environment\"]", result.ToHcl(context));
    }

    #endregion

    #region ToString

    [Fact]
    public void ToString_ReturnsHclRepresentation()
    {
        var lineage = new TerraformLineage("aws_vpc.main")
            .WithMember("id");

        Assert.Equal("aws_vpc.main.id", lineage.ToString());
    }

    [Fact]
    public void ToString_EmptyPath_ReturnsEmpty()
    {
        var lineage = new TerraformLineage([]);

        Assert.Equal(string.Empty, lineage.ToString());
    }

    #endregion
}
