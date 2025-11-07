using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_lb_rule.
/// </summary>
public class AzurermLbRuleDataSource : TerraformDataSource
{
    public AzurermLbRuleDataSource(string name) : base("azurerm_lb_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("backend_address_pool_id");
        this.DeclareOutput("backend_port");
        this.DeclareOutput("disable_outbound_snat");
        this.DeclareOutput("enable_floating_ip");
        this.DeclareOutput("enable_tcp_reset");
        this.DeclareOutput("floating_ip_enabled");
        this.DeclareOutput("frontend_ip_configuration_name");
        this.DeclareOutput("frontend_port");
        this.DeclareOutput("idle_timeout_in_minutes");
        this.DeclareOutput("load_distribution");
        this.DeclareOutput("probe_id");
        this.DeclareOutput("protocol");
        this.DeclareOutput("tcp_reset_enabled");
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
    /// The loadbalancer_id attribute.
    /// </summary>
    public TerraformProperty<string>? LoadbalancerId
    {
        get => GetProperty<TerraformProperty<string>>("loadbalancer_id");
        set => this.WithProperty("loadbalancer_id", value);
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
    /// The backend_address_pool_id attribute.
    /// </summary>
    public TerraformExpression BackendAddressPoolId => this["backend_address_pool_id"];

    /// <summary>
    /// The backend_port attribute.
    /// </summary>
    public TerraformExpression BackendPort => this["backend_port"];

    /// <summary>
    /// The disable_outbound_snat attribute.
    /// </summary>
    public TerraformExpression DisableOutboundSnat => this["disable_outbound_snat"];

    /// <summary>
    /// The enable_floating_ip attribute.
    /// </summary>
    public TerraformExpression EnableFloatingIp => this["enable_floating_ip"];

    /// <summary>
    /// The enable_tcp_reset attribute.
    /// </summary>
    public TerraformExpression EnableTcpReset => this["enable_tcp_reset"];

    /// <summary>
    /// The floating_ip_enabled attribute.
    /// </summary>
    public TerraformExpression FloatingIpEnabled => this["floating_ip_enabled"];

    /// <summary>
    /// The frontend_ip_configuration_name attribute.
    /// </summary>
    public TerraformExpression FrontendIpConfigurationName => this["frontend_ip_configuration_name"];

    /// <summary>
    /// The frontend_port attribute.
    /// </summary>
    public TerraformExpression FrontendPort => this["frontend_port"];

    /// <summary>
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    public TerraformExpression IdleTimeoutInMinutes => this["idle_timeout_in_minutes"];

    /// <summary>
    /// The load_distribution attribute.
    /// </summary>
    public TerraformExpression LoadDistribution => this["load_distribution"];

    /// <summary>
    /// The probe_id attribute.
    /// </summary>
    public TerraformExpression ProbeId => this["probe_id"];

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformExpression Protocol => this["protocol"];

    /// <summary>
    /// The tcp_reset_enabled attribute.
    /// </summary>
    public TerraformExpression TcpResetEnabled => this["tcp_reset_enabled"];

}
