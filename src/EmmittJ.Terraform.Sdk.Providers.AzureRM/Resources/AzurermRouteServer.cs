using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_route_server resource.
/// </summary>
public class AzurermRouteServer : TerraformResource
{
    public AzurermRouteServer(string name) : base("azurerm_route_server", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("routing_state");
        this.DeclareOutput("virtual_router_asn");
        this.DeclareOutput("virtual_router_ips");
    }

    /// <summary>
    /// The branch_to_branch_traffic_enabled attribute.
    /// </summary>
    public bool? BranchToBranchTrafficEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("branch_to_branch_traffic_enabled")?.Value;
        set => this.WithProperty("branch_to_branch_traffic_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The hub_routing_preference attribute.
    /// </summary>
    public string? HubRoutingPreference
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hub_routing_preference")?.Value;
        set => this.WithProperty("hub_routing_preference", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The public_ip_address_id attribute.
    /// </summary>
    public string? PublicIpAddressId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("public_ip_address_id")?.Value;
        set => this.WithProperty("public_ip_address_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public string? Sku
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku")?.Value;
        set => this.WithProperty("sku", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public string? SubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_id")?.Value;
        set => this.WithProperty("subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The routing_state attribute.
    /// </summary>
    public TerraformExpression RoutingState => this["routing_state"];

    /// <summary>
    /// The virtual_router_asn attribute.
    /// </summary>
    public TerraformExpression VirtualRouterAsn => this["virtual_router_asn"];

    /// <summary>
    /// The virtual_router_ips attribute.
    /// </summary>
    public TerraformExpression VirtualRouterIps => this["virtual_router_ips"];

}
