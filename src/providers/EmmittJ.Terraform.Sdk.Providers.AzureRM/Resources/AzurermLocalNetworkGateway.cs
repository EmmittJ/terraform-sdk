using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for bgp_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermLocalNetworkGatewayBgpSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The asn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Asn is required")]
    public required TerraformProperty<double> Asn
    {
        set => SetProperty("asn", value);
    }

    /// <summary>
    /// The bgp_peering_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BgpPeeringAddress is required")]
    public required TerraformProperty<string> BgpPeeringAddress
    {
        set => SetProperty("bgp_peering_address", value);
    }

    /// <summary>
    /// The peer_weight attribute.
    /// </summary>
    public TerraformProperty<double>? PeerWeight
    {
        set => SetProperty("peer_weight", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLocalNetworkGatewayTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_local_network_gateway resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermLocalNetworkGateway : TerraformResource
{
    public AzurermLocalNetworkGateway(string name) : base("azurerm_local_network_gateway", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("address_space");
        SetOutput("gateway_address");
        SetOutput("gateway_fqdn");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("tags");
    }

    /// <summary>
    /// The address_space attribute.
    /// </summary>
    public List<TerraformProperty<string>> AddressSpace
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("address_space");
        set => SetProperty("address_space", value);
    }

    /// <summary>
    /// The gateway_address attribute.
    /// </summary>
    public TerraformProperty<string> GatewayAddress
    {
        get => GetRequiredOutput<TerraformProperty<string>>("gateway_address");
        set => SetProperty("gateway_address", value);
    }

    /// <summary>
    /// The gateway_fqdn attribute.
    /// </summary>
    public TerraformProperty<string> GatewayFqdn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("gateway_fqdn");
        set => SetProperty("gateway_fqdn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for bgp_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BgpSettings block(s) allowed")]
    public List<AzurermLocalNetworkGatewayBgpSettingsBlock>? BgpSettings
    {
        set => SetProperty("bgp_settings", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLocalNetworkGatewayTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
