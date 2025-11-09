using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_express_route_gateway resource.
/// </summary>
public class AzurermExpressRouteGateway : TerraformResource
{
    public AzurermExpressRouteGateway(string name) : base("azurerm_express_route_gateway", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The allow_non_virtual_wan_traffic attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowNonVirtualWanTraffic
    {
        get => GetProperty<TerraformProperty<bool>>("allow_non_virtual_wan_traffic");
        set => this.WithProperty("allow_non_virtual_wan_traffic", value);
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
    /// The scale_units attribute.
    /// </summary>
    public TerraformProperty<double>? ScaleUnits
    {
        get => GetProperty<TerraformProperty<double>>("scale_units");
        set => this.WithProperty("scale_units", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualHubId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_hub_id");
        set => this.WithProperty("virtual_hub_id", value);
    }

}
