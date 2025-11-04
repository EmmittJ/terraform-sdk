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
    public HashSet<string>? Destinations
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("destinations")?.Value;
        set => this.WithProperty("destinations", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The destinations_type attribute.
    /// </summary>
    public string? DestinationsType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destinations_type")?.Value;
        set => this.WithProperty("destinations_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The next_hop attribute.
    /// </summary>
    public string? NextHop
    {
        get => GetProperty<TerraformLiteralProperty<string>>("next_hop")?.Value;
        set => this.WithProperty("next_hop", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The next_hop_type attribute.
    /// </summary>
    public string? NextHopType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("next_hop_type")?.Value;
        set => this.WithProperty("next_hop_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The route_table_id attribute.
    /// </summary>
    public string? RouteTableId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("route_table_id")?.Value;
        set => this.WithProperty("route_table_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
