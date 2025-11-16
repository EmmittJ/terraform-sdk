using EmmittJ.Terraform.Sdk;
using EmmittJ.Terraform.Sdk.Tests.TestHelpers;
using Xunit;

namespace EmmittJ.Terraform.Sdk.Tests.Values;

/// <summary>
/// Tests for TerraformList, TerraformMap, and TerraformSet value types.
/// These tests validate collection handling in the polymorphic value system.
/// </summary>
[Trait("Category", "Unit")]
[Trait("Layer", "Values")]
public class TerraformCollectionTests
{
    [Fact]
    public Task TerraformList_WithStrings_ResolvesToListExpression()
    {
        var list = new TerraformList<string>(new[] { "item1", "item2", "item3" });
        var context = TerraformTestHelpers.CreateContext();

        var nodes = list.ResolveNodes(context).ToList();

        Assert.Single(nodes);
        var hcl = nodes[0].ToHcl(context);

        return Verify(hcl).UseMethodName("TerraformList_WithStrings");
    }

    [Fact]
    public Task TerraformList_WithIntegers_ResolvesToListExpression()
    {
        var list = new TerraformList<int>(new[] { 1, 2, 3, 5, 8 });
        var context = TerraformTestHelpers.CreateContext();

        var nodes = list.ResolveNodes(context).ToList();

        Assert.Single(nodes);
        var hcl = nodes[0].ToHcl(context);

        return Verify(hcl).UseMethodName("TerraformList_WithIntegers");
    }

    [Fact]
    public Task TerraformList_Empty_ResolvesToEmptyList()
    {
        var list = new TerraformList<string>(Array.Empty<string>());
        var context = TerraformTestHelpers.CreateContext();

        var nodes = list.ResolveNodes(context).ToList();

        Assert.Single(nodes);
        var hcl = nodes[0].ToHcl(context);

        return Verify(hcl).UseMethodName("TerraformList_Empty");
    }

    [Fact]
    public Task TerraformMap_WithStringValues_ResolvesToMapExpression()
    {
        var map = new TerraformMap<string>
        {
            ["name"] = "example",
            ["environment"] = "production",
            ["region"] = "us-west-2"
        };
        var context = TerraformTestHelpers.CreateContext();

        var nodes = map.ResolveNodes(context).ToList();

        Assert.Single(nodes);
        var hcl = nodes[0].ToHcl(context);

        return Verify(hcl).UseMethodName("TerraformMap_WithStringValues");
    }

    [Fact]
    public Task TerraformMap_WithIntegerValues_ResolvesToMapExpression()
    {
        var map = new TerraformMap<int>
        {
            ["count"] = 3,
            ["size"] = 100,
            ["replicas"] = 2
        };
        var context = TerraformTestHelpers.CreateContext();

        var nodes = map.ResolveNodes(context).ToList();

        Assert.Single(nodes);
        var hcl = nodes[0].ToHcl(context);

        return Verify(hcl).UseMethodName("TerraformMap_WithIntegerValues");
    }

    [Fact]
    public Task TerraformMap_Empty_ResolvesToEmptyMap()
    {
        var map = new TerraformMap<string>();
        var context = TerraformTestHelpers.CreateContext();

        var nodes = map.ResolveNodes(context).ToList();

        Assert.Single(nodes);
        var hcl = nodes[0].ToHcl(context);

        return Verify(hcl).UseMethodName("TerraformMap_Empty");
    }

    [Fact]
    public Task TerraformSet_WithStrings_ResolvesToSetExpression()
    {
        var set = new TerraformSet<string>(new[] { "aws", "azure", "gcp" });
        var context = TerraformTestHelpers.CreateContext();

        var nodes = set.ResolveNodes(context).ToList();

        Assert.Single(nodes);
        var hcl = nodes[0].ToHcl(context);

        return Verify(hcl).UseMethodName("TerraformSet_WithStrings");
    }
}
