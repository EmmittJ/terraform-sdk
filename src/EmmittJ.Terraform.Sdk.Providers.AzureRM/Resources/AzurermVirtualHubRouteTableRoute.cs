using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_virtual_hub_route_table_route resource.
/// </summary>
public class AzurermVirtualHubRouteTableRoute : TerraformResource
{
    public AzurermVirtualHubRouteTableRoute(string name) : base("azurerm_virtual_hub_route_table_route", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The destinations attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Destinations
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("destinations");
        set => this.WithProperty("destinations", value);
    }

    /// <summary>
    /// The destinations_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DestinationsType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destinations_type");
        set => this.WithProperty("destinations_type", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The next_hop attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NextHop
    {
        get => GetProperty<TerraformLiteralProperty<string>>("next_hop");
        set => this.WithProperty("next_hop", value);
    }

    /// <summary>
    /// The next_hop_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NextHopType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("next_hop_type");
        set => this.WithProperty("next_hop_type", value);
    }

    /// <summary>
    /// The route_table_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RouteTableId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("route_table_id");
        set => this.WithProperty("route_table_id", value);
    }

}
