using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_private_dns_resolver_virtual_network_link resource.
/// </summary>
public class AzurermPrivateDnsResolverVirtualNetworkLink : TerraformResource
{
    public AzurermPrivateDnsResolverVirtualNetworkLink(string name) : base("azurerm_private_dns_resolver_virtual_network_link", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The metadata attribute.
    /// </summary>
    public Dictionary<string, string>? Metadata
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("metadata")?.Value;
        set => this.WithProperty("metadata", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
    /// The virtual_network_id attribute.
    /// </summary>
    public string? VirtualNetworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_network_id")?.Value;
        set => this.WithProperty("virtual_network_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
