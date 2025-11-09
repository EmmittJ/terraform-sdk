using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("default_route_table_id");
        this.DeclareOutput("virtual_router_asn");
        this.DeclareOutput("virtual_router_ips");
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
    /// The branch_to_branch_traffic_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? BranchToBranchTrafficEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("branch_to_branch_traffic_enabled");
        set => this.WithProperty("branch_to_branch_traffic_enabled", value);
    }

    /// <summary>
    /// The hub_routing_preference attribute.
    /// </summary>
    public TerraformProperty<string>? HubRoutingPreference
    {
        get => GetProperty<TerraformProperty<string>>("hub_routing_preference");
        set => this.WithProperty("hub_routing_preference", value);
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
    /// The sku attribute.
    /// </summary>
    public TerraformProperty<string>? Sku
    {
        get => GetProperty<TerraformProperty<string>>("sku");
        set => this.WithProperty("sku", value);
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
    /// The virtual_router_auto_scale_min_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? VirtualRouterAutoScaleMinCapacity
    {
        get => GetProperty<TerraformProperty<double>>("virtual_router_auto_scale_min_capacity");
        set => this.WithProperty("virtual_router_auto_scale_min_capacity", value);
    }

    /// <summary>
    /// The virtual_wan_id attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualWanId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_wan_id");
        set => this.WithProperty("virtual_wan_id", value);
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
