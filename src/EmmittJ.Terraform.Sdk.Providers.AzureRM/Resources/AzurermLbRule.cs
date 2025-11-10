using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLbRuleTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_lb_rule resource.
/// </summary>
public class AzurermLbRule : TerraformResource
{
    public AzurermLbRule(string name) : base("azurerm_lb_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("frontend_ip_configuration_id");
    }

    /// <summary>
    /// The backend_address_pool_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>>? BackendAddressPoolIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("backend_address_pool_ids");
        set => this.WithProperty("backend_address_pool_ids", value);
    }

    /// <summary>
    /// The backend_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPort is required")]
    public required TerraformProperty<double> BackendPort
    {
        get => GetRequiredProperty<TerraformProperty<double>>("backend_port");
        set => this.WithProperty("backend_port", value);
    }

    /// <summary>
    /// The disable_outbound_snat attribute.
    /// </summary>
    public TerraformProperty<bool>? DisableOutboundSnat
    {
        get => GetProperty<TerraformProperty<bool>>("disable_outbound_snat");
        set => this.WithProperty("disable_outbound_snat", value);
    }

    /// <summary>
    /// The enable_floating_ip attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool>? EnableFloatingIp
    {
        get => GetProperty<TerraformProperty<bool>>("enable_floating_ip");
        set => this.WithProperty("enable_floating_ip", value);
    }

    /// <summary>
    /// The enable_tcp_reset attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool>? EnableTcpReset
    {
        get => GetProperty<TerraformProperty<bool>>("enable_tcp_reset");
        set => this.WithProperty("enable_tcp_reset", value);
    }

    /// <summary>
    /// The floating_ip_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? FloatingIpEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("floating_ip_enabled");
        set => this.WithProperty("floating_ip_enabled", value);
    }

    /// <summary>
    /// The frontend_ip_configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendIpConfigurationName is required")]
    public required TerraformProperty<string> FrontendIpConfigurationName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("frontend_ip_configuration_name");
        set => this.WithProperty("frontend_ip_configuration_name", value);
    }

    /// <summary>
    /// The frontend_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendPort is required")]
    public required TerraformProperty<double> FrontendPort
    {
        get => GetRequiredProperty<TerraformProperty<double>>("frontend_port");
        set => this.WithProperty("frontend_port", value);
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
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? IdleTimeoutInMinutes
    {
        get => GetProperty<TerraformProperty<double>>("idle_timeout_in_minutes");
        set => this.WithProperty("idle_timeout_in_minutes", value);
    }

    /// <summary>
    /// The load_distribution attribute.
    /// </summary>
    public TerraformProperty<string>? LoadDistribution
    {
        get => GetProperty<TerraformProperty<string>>("load_distribution");
        set => this.WithProperty("load_distribution", value);
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
    /// The probe_id attribute.
    /// </summary>
    public TerraformProperty<string>? ProbeId
    {
        get => GetProperty<TerraformProperty<string>>("probe_id");
        set => this.WithProperty("probe_id", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        get => GetRequiredProperty<TerraformProperty<string>>("protocol");
        set => this.WithProperty("protocol", value);
    }

    /// <summary>
    /// The tcp_reset_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TcpResetEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("tcp_reset_enabled");
        set => this.WithProperty("tcp_reset_enabled", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLbRuleTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermLbRuleTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The frontend_ip_configuration_id attribute.
    /// </summary>
    public TerraformExpression FrontendIpConfigurationId => this["frontend_ip_configuration_id"];

}
