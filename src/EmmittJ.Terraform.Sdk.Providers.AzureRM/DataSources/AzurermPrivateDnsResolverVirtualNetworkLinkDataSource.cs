using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_private_dns_resolver_virtual_network_link.
/// </summary>
public class AzurermPrivateDnsResolverVirtualNetworkLinkDataSource : TerraformDataSource
{
    public AzurermPrivateDnsResolverVirtualNetworkLinkDataSource(string name) : base("azurerm_private_dns_resolver_virtual_network_link", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("metadata");
        this.DeclareOutput("virtual_network_id");
    }

    /// <summary>
    /// The dns_forwarding_ruleset_id attribute.
    /// </summary>
    public string? DnsForwardingRulesetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dns_forwarding_ruleset_id")?.Value;
        set => this.WithProperty("dns_forwarding_ruleset_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformExpression Metadata => this["metadata"];

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformExpression VirtualNetworkId => this["virtual_network_id"];

}
