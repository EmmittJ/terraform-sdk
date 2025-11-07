using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_vpn_gateway resource.
/// </summary>
public class AzurermVpnGateway : TerraformResource
{
    public AzurermVpnGateway(string name) : base("azurerm_vpn_gateway", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("ip_configuration");
    }

    /// <summary>
    /// The bgp_route_translation_for_nat_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? BgpRouteTranslationForNatEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("bgp_route_translation_for_nat_enabled");
        set => this.WithProperty("bgp_route_translation_for_nat_enabled", value);
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
    /// The routing_preference attribute.
    /// </summary>
    public TerraformProperty<string>? RoutingPreference
    {
        get => GetProperty<TerraformProperty<string>>("routing_preference");
        set => this.WithProperty("routing_preference", value);
    }

    /// <summary>
    /// The scale_unit attribute.
    /// </summary>
    public TerraformProperty<double>? ScaleUnit
    {
        get => GetProperty<TerraformProperty<double>>("scale_unit");
        set => this.WithProperty("scale_unit", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
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

    /// <summary>
    /// The ip_configuration attribute.
    /// </summary>
    public TerraformExpression IpConfiguration => this["ip_configuration"];

}
