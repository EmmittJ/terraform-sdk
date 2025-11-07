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
    public TerraformLiteralProperty<List<string>>? DnsServers
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("dns_servers");
        set => this.WithProperty("dns_servers", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VirtualNetworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_network_id");
        set => this.WithProperty("virtual_network_id", value);
    }

}
