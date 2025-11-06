using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_network_manager_ipam_pool_static_cidr resource.
/// </summary>
public class AzurermNetworkManagerIpamPoolStaticCidr : TerraformResource
{
    public AzurermNetworkManagerIpamPoolStaticCidr(string name) : base("azurerm_network_manager_ipam_pool_static_cidr", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    public List<string>? AddressPrefixes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("address_prefixes")?.Value;
        set => this.WithProperty("address_prefixes", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The ipam_pool_id attribute.
    /// </summary>
    public string? IpamPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ipam_pool_id")?.Value;
        set => this.WithProperty("ipam_pool_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The number_of_ip_addresses_to_allocate attribute.
    /// </summary>
    public string? NumberOfIpAddressesToAllocate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("number_of_ip_addresses_to_allocate")?.Value;
        set => this.WithProperty("number_of_ip_addresses_to_allocate", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
