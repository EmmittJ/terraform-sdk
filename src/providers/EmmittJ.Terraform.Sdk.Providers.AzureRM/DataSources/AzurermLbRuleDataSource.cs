using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLbRuleDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

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
        this.WithOutput("backend_address_pool_id");
        this.WithOutput("backend_port");
        this.WithOutput("disable_outbound_snat");
        this.WithOutput("enable_floating_ip");
        this.WithOutput("enable_tcp_reset");
        this.WithOutput("floating_ip_enabled");
        this.WithOutput("frontend_ip_configuration_name");
        this.WithOutput("frontend_port");
        this.WithOutput("idle_timeout_in_minutes");
        this.WithOutput("load_distribution");
        this.WithOutput("probe_id");
        this.WithOutput("protocol");
        this.WithOutput("tcp_reset_enabled");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadbalancerId is required")]
    public required TerraformProperty<string> LoadbalancerId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("loadbalancer_id");
        set => this.WithProperty("loadbalancer_id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLbRuleDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermLbRuleDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
