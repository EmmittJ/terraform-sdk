using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_route resource.
/// </summary>
public class AzurermRoute : TerraformResource
{
    public AzurermRoute(string name) : base("azurerm_route", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The address_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? AddressPrefix
    {
        get => GetProperty<TerraformProperty<string>>("address_prefix");
        set => this.WithProperty("address_prefix", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The next_hop_in_ip_address attribute.
    /// </summary>
    public TerraformProperty<string>? NextHopInIpAddress
    {
        get => GetProperty<TerraformProperty<string>>("next_hop_in_ip_address");
        set => this.WithProperty("next_hop_in_ip_address", value);
    }

    /// <summary>
    /// The next_hop_type attribute.
    /// </summary>
    public TerraformProperty<string>? NextHopType
    {
        get => GetProperty<TerraformProperty<string>>("next_hop_type");
        set => this.WithProperty("next_hop_type", value);
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
    /// The route_table_name attribute.
    /// </summary>
    public TerraformProperty<string>? RouteTableName
    {
        get => GetProperty<TerraformProperty<string>>("route_table_name");
        set => this.WithProperty("route_table_name", value);
    }

}
