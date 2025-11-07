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
    public TerraformProperty<string>? DnsForwardingRulesetId
    {
        get => GetProperty<TerraformProperty<string>>("dns_forwarding_ruleset_id");
        set => this.WithProperty("dns_forwarding_ruleset_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Metadata
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("metadata");
        set => this.WithProperty("metadata", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualNetworkId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_network_id");
        set => this.WithProperty("virtual_network_id", value);
    }

}
