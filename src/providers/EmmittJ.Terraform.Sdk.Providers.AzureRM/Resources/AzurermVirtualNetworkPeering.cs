using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualNetworkPeeringTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_virtual_network_peering resource.
/// </summary>
public class AzurermVirtualNetworkPeering : TerraformResource
{
    public AzurermVirtualNetworkPeering(string name) : base("azurerm_virtual_network_peering", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("allow_forwarded_traffic");
        SetOutput("allow_gateway_transit");
        SetOutput("allow_virtual_network_access");
        SetOutput("id");
        SetOutput("local_subnet_names");
        SetOutput("name");
        SetOutput("only_ipv6_peering_enabled");
        SetOutput("peer_complete_virtual_networks_enabled");
        SetOutput("remote_subnet_names");
        SetOutput("remote_virtual_network_id");
        SetOutput("resource_group_name");
        SetOutput("triggers");
        SetOutput("use_remote_gateways");
        SetOutput("virtual_network_name");
    }

    /// <summary>
    /// The allow_forwarded_traffic attribute.
    /// </summary>
    public TerraformProperty<bool> AllowForwardedTraffic
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("allow_forwarded_traffic");
        set => SetProperty("allow_forwarded_traffic", value);
    }

    /// <summary>
    /// The allow_gateway_transit attribute.
    /// </summary>
    public TerraformProperty<bool> AllowGatewayTransit
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("allow_gateway_transit");
        set => SetProperty("allow_gateway_transit", value);
    }

    /// <summary>
    /// The allow_virtual_network_access attribute.
    /// </summary>
    public TerraformProperty<bool> AllowVirtualNetworkAccess
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("allow_virtual_network_access");
        set => SetProperty("allow_virtual_network_access", value);
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
    /// The local_subnet_names attribute.
    /// </summary>
    public List<TerraformProperty<string>> LocalSubnetNames
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("local_subnet_names");
        set => SetProperty("local_subnet_names", value);
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
    /// The only_ipv6_peering_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> OnlyIpv6PeeringEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("only_ipv6_peering_enabled");
        set => SetProperty("only_ipv6_peering_enabled", value);
    }

    /// <summary>
    /// The peer_complete_virtual_networks_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PeerCompleteVirtualNetworksEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("peer_complete_virtual_networks_enabled");
        set => SetProperty("peer_complete_virtual_networks_enabled", value);
    }

    /// <summary>
    /// The remote_subnet_names attribute.
    /// </summary>
    public List<TerraformProperty<string>> RemoteSubnetNames
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("remote_subnet_names");
        set => SetProperty("remote_subnet_names", value);
    }

    /// <summary>
    /// The remote_virtual_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteVirtualNetworkId is required")]
    public required TerraformProperty<string> RemoteVirtualNetworkId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("remote_virtual_network_id");
        set => SetProperty("remote_virtual_network_id", value);
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
    /// The triggers attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Triggers
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("triggers");
        set => SetProperty("triggers", value);
    }

    /// <summary>
    /// The use_remote_gateways attribute.
    /// </summary>
    public TerraformProperty<bool> UseRemoteGateways
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("use_remote_gateways");
        set => SetProperty("use_remote_gateways", value);
    }

    /// <summary>
    /// The virtual_network_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkName is required")]
    public required TerraformProperty<string> VirtualNetworkName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("virtual_network_name");
        set => SetProperty("virtual_network_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualNetworkPeeringTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
