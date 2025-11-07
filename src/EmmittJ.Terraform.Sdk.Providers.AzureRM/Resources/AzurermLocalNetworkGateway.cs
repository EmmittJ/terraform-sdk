using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_local_network_gateway resource.
/// </summary>
public class AzurermLocalNetworkGateway : TerraformResource
{
    public AzurermLocalNetworkGateway(string name) : base("azurerm_local_network_gateway", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The address_space attribute.
    /// </summary>
    public TerraformProperty<List<string>>? AddressSpace
    {
        get => GetProperty<TerraformProperty<List<string>>>("address_space");
        set => this.WithProperty("address_space", value);
    }

    /// <summary>
    /// The gateway_address attribute.
    /// </summary>
    public TerraformProperty<string>? GatewayAddress
    {
        get => GetProperty<TerraformProperty<string>>("gateway_address");
        set => this.WithProperty("gateway_address", value);
    }

    /// <summary>
    /// The gateway_fqdn attribute.
    /// </summary>
    public TerraformProperty<string>? GatewayFqdn
    {
        get => GetProperty<TerraformProperty<string>>("gateway_fqdn");
        set => this.WithProperty("gateway_fqdn", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
