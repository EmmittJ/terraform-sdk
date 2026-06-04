// Licensed under the MIT License.

using Aspire.Hosting.ApplicationModel;
using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Aspire.Hosting.Terraform.Tests;

/// <summary>
/// Tests for <see cref="TerraformRawExpression"/>, the cross-language raw-HCL escape-hatch,
/// and its lowering through the Aspire expression system into the Terraform AST.
/// </summary>
public class TerraformRawExpressionTests
{
    private static string Render(TerraformValue<string> value)
    {
        var context = TerraformContext.Temporary();
        return string.Concat(value.ResolveNodes(context).Select(node => node.ToHcl(context)));
    }

    private static TerraformProvisioningResource CreateProvisioningResource()
    {
        var builder = DistributedApplication.CreateBuilder();
        var environment = builder.AddTerraformEnvironment("env").Resource;
        return new TerraformProvisioningResource("module", environment);
    }

    [Fact]
    public void Create_SetsHcl()
    {
        var raw = TerraformRawExpression.Create("module.network.vnet_id");

        Assert.Equal("module.network.vnet_id", raw.Hcl);
    }

    [Fact]
    public void Constructor_ThrowsOnNullOrEmpty()
    {
        Assert.Throws<ArgumentNullException>(() => new TerraformRawExpression(null!));
        Assert.Throws<ArgumentException>(() => new TerraformRawExpression(string.Empty));
    }

    [Fact]
    public void ValueExpression_ReturnsVerbatimHcl()
    {
        var raw = TerraformRawExpression.Create("var.enabled ? \"a\" : \"b\"");

        Assert.Equal("var.enabled ? \"a\" : \"b\"", ((IManifestExpressionProvider)raw).ValueExpression);
    }

    [Fact]
    public async Task GetValueAsync_ReturnsVerbatimHcl()
    {
        var raw = TerraformRawExpression.Create("module.network.vnet_id");

        var value = await ((IValueProvider)raw).GetValueAsync();

        Assert.Equal("module.network.vnet_id", value);
    }

    [Fact]
    public void Equality_IsBasedOnHcl()
    {
        var a = TerraformRawExpression.Create("module.x.id");
        var b = TerraformRawExpression.Create("module.x.id");
        var c = TerraformRawExpression.Create("module.y.id");

        Assert.Equal(a, b);
        Assert.Equal(a.GetHashCode(), b.GetHashCode());
        Assert.NotEqual(a, c);
    }

    [Fact]
    public void ToTerraformValue_RendersVerbatimUnquoted()
    {
        var raw = TerraformRawExpression.Create("module.network.vnet_id");

        var rendered = Render(raw.ToTerraformValue());

        // Symbolic reference must NOT be wrapped in quotes.
        Assert.Equal("module.network.vnet_id", rendered);
    }

    [Fact]
    public void ResolveValueProvider_RawExpression_RendersSymbolic()
    {
        var infra = CreateProvisioningResource();
        var raw = TerraformRawExpression.Create("module.network.vnet_id");

        var resolved = infra.ResolveValueProvider(raw);

        Assert.Equal("module.network.vnet_id", Render(resolved));
    }

    [Fact]
    public void ResolveValueProvider_String_RendersQuotedLiteral()
    {
        var infra = CreateProvisioningResource();

        var resolved = infra.ResolveValueProvider("module.network.vnet_id");

        // A plain string is data, not an expression: it must be quoted.
        Assert.Equal("\"module.network.vnet_id\"", Render(resolved));
    }

    [Fact]
    public void ResolveValueProvider_RawExpression_EmbeddedInReferenceExpression_RendersSymbolic()
    {
        var infra = CreateProvisioningResource();
        var raw = TerraformRawExpression.Create("module.network.vnet_id");

        // A single-hole ReferenceExpression carrying the raw provider resolves to the symbolic form.
        var expression = ReferenceExpression.Create($"{raw}");
        var resolved = infra.ResolveValueProvider(expression);

        Assert.Equal("module.network.vnet_id", Render(resolved));
    }
}
