using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for bgp_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermVpnGatewayBgpSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The asn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Asn is required")]
    public required TerraformProperty<double> Asn
    {
        get => GetRequiredProperty<TerraformProperty<double>>("asn");
        set => WithProperty("asn", value);
    }

    /// <summary>
    /// The bgp_peering_address attribute.
    /// </summary>
    public TerraformProperty<string>? BgpPeeringAddress
    {
        get => GetProperty<TerraformProperty<string>>("bgp_peering_address");
        set => WithProperty("bgp_peering_address", value);
    }

    /// <summary>
    /// The peer_weight attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerWeight is required")]
    public required TerraformProperty<double> PeerWeight
    {
        get => GetRequiredProperty<TerraformProperty<double>>("peer_weight");
        set => WithProperty("peer_weight", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVpnGatewayTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_vpn_gateway resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermVpnGateway : TerraformResource
{
    public AzurermVpnGateway(string name) : base("azurerm_vpn_gateway", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutputp_configuration");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
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
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualHubId is required")]
    public required TerraformProperty<string> VirtualHubId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("virtual_hub_id");
        set => this.WithProperty("virtual_hub_id", value);
    }

    /// <summary>
    /// Block for bgp_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BgpSettings block(s) allowed")]
    public List<AzurermVpnGatewayBgpSettingsBlock>? BgpSettings
    {
        get => GetProperty<List<AzurermVpnGatewayBgpSettingsBlock>>("bgp_settings");
        set => this.WithProperty("bgp_settings", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVpnGatewayTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermVpnGatewayTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The ip_configuration attribute.
    /// </summary>
    public TerraformExpression IpConfiguration => this["ip_configuration"];

}
