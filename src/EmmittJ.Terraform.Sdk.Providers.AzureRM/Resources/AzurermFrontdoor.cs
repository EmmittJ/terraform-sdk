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
    public TerraformProperty<string>? FriendlyName
    {
        get => GetProperty<TerraformProperty<string>>("friendly_name");
        set => this.WithProperty("friendly_name", value);
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
    /// The load_balancer_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LoadBalancerEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("load_balancer_enabled");
        set => this.WithProperty("load_balancer_enabled", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
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
