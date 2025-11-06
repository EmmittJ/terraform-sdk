using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_frontdoor resource.
/// </summary>
public class AzurermFrontdoor : TerraformResource
{
    public AzurermFrontdoor(string name) : base("azurerm_frontdoor", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("backend_pool_health_probes");
        this.DeclareOutput("backend_pool_load_balancing_settings");
        this.DeclareOutput("backend_pools");
        this.DeclareOutput("cname");
        this.DeclareOutput("explicit_resource_order");
        this.DeclareOutput("frontend_endpoints");
        this.DeclareOutput("header_frontdoor_id");
        this.DeclareOutput("routing_rules");
    }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    public string? FriendlyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("friendly_name")?.Value;
        set => this.WithProperty("friendly_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The load_balancer_enabled attribute.
    /// </summary>
    public bool? LoadBalancerEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("load_balancer_enabled")?.Value;
        set => this.WithProperty("load_balancer_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The backend_pool_health_probes attribute.
    /// </summary>
    public TerraformExpression BackendPoolHealthProbes => this["backend_pool_health_probes"];

    /// <summary>
    /// The backend_pool_load_balancing_settings attribute.
    /// </summary>
    public TerraformExpression BackendPoolLoadBalancingSettings => this["backend_pool_load_balancing_settings"];

    /// <summary>
    /// The backend_pools attribute.
    /// </summary>
    public TerraformExpression BackendPools => this["backend_pools"];

    /// <summary>
    /// The cname attribute.
    /// </summary>
    public TerraformExpression Cname => this["cname"];

    /// <summary>
    /// The explicit_resource_order attribute.
    /// </summary>
    public TerraformExpression ExplicitResourceOrder => this["explicit_resource_order"];

    /// <summary>
    /// The frontend_endpoints attribute.
    /// </summary>
    public TerraformExpression FrontendEndpoints => this["frontend_endpoints"];

    /// <summary>
    /// The header_frontdoor_id attribute.
    /// </summary>
    public TerraformExpression HeaderFrontdoorId => this["header_frontdoor_id"];

    /// <summary>
    /// The routing_rules attribute.
    /// </summary>
    public TerraformExpression RoutingRules => this["routing_rules"];

}
