using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_virtual_network_dns_servers resource.
/// </summary>
public class AzurermVirtualNetworkDnsServers : TerraformResource
{
    public AzurermVirtualNetworkDnsServers(string name) : base("azurerm_virtual_network_dns_servers", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    public List<string>? DnsServers
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("dns_servers")?.Value;
        set => this.WithProperty("dns_servers", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The virtual_network_id attribute.
    /// </summary>
    public string? VirtualNetworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_network_id")?.Value;
        set => this.WithProperty("virtual_network_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
