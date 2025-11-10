using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for route in .
/// Nesting mode: set
/// </summary>
public class AzurermVirtualHubRouteBlock : TerraformBlock
{
    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressPrefixes is required")]
    public List<TerraformProperty<string>>? AddressPrefixes
    {
        set => SetProperty("address_prefixes", value);
    }

    /// <summary>
    /// The next_hop_ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NextHopIpAddress is required")]
    public required TerraformProperty<string> NextHopIpAddress
    {
        set => SetProperty("next_hop_ip_address", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualHubTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_virtual_hub resource.
/// </summary>
public class AzurermVirtualHub : TerraformResource
{
    public AzurermVirtualHub(string name) : base("azurerm_virtual_hub", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("default_route_table_id");
        SetOutput("virtual_router_asn");
        SetOutput("virtual_router_ips");
        SetOutput("address_prefix");
        SetOutput("branch_to_branch_traffic_enabled");
        SetOutput("hub_routing_preference");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("sku");
        SetOutput("tags");
        SetOutput("virtual_router_auto_scale_min_capacity");
        SetOutput("virtual_wan_id");
    }

    /// <summary>
    /// The address_prefix attribute.
    /// </summary>
    public TerraformProperty<string> AddressPrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("address_prefix");
        set => SetProperty("address_prefix", value);
    }

    /// <summary>
    /// The branch_to_branch_traffic_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> BranchToBranchTrafficEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("branch_to_branch_traffic_enabled");
        set => SetProperty("branch_to_branch_traffic_enabled", value);
    }

    /// <summary>
    /// The hub_routing_preference attribute.
    /// </summary>
    public TerraformProperty<string> HubRoutingPreference
    {
        get => GetRequiredOutput<TerraformProperty<string>>("hub_routing_preference");
        set => SetProperty("hub_routing_preference", value);
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
    /// The sku attribute.
    /// </summary>
    public TerraformProperty<string> Sku
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku");
        set => SetProperty("sku", value);
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
    /// The virtual_router_auto_scale_min_capacity attribute.
    /// </summary>
    public TerraformProperty<double> VirtualRouterAutoScaleMinCapacity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("virtual_router_auto_scale_min_capacity");
        set => SetProperty("virtual_router_auto_scale_min_capacity", value);
    }

    /// <summary>
    /// The virtual_wan_id attribute.
    /// </summary>
    public TerraformProperty<string> VirtualWanId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("virtual_wan_id");
        set => SetProperty("virtual_wan_id", value);
    }

    /// <summary>
    /// Block for route.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermVirtualHubRouteBlock>? Route
    {
        set => SetProperty("route", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualHubTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The default_route_table_id attribute.
    /// </summary>
    public TerraformExpression DefaultRouteTableId => this["default_route_table_id"];

    /// <summary>
    /// The virtual_router_asn attribute.
    /// </summary>
    public TerraformExpression VirtualRouterAsn => this["virtual_router_asn"];

    /// <summary>
    /// The virtual_router_ips attribute.
    /// </summary>
    public TerraformExpression VirtualRouterIps => this["virtual_router_ips"];

}
