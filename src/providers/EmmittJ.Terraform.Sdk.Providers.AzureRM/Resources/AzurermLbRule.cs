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
        SetOutput("frontend_ip_configuration_id");
        SetOutput("backend_address_pool_ids");
        SetOutput("backend_port");
        SetOutput("disable_outbound_snat");
        SetOutput("enable_floating_ip");
        SetOutput("enable_tcp_reset");
        SetOutput("floating_ip_enabled");
        SetOutput("frontend_ip_configuration_name");
        SetOutput("frontend_port");
        SetOutput("id");
        SetOutput("idle_timeout_in_minutes");
        SetOutput("load_distribution");
        SetOutput("loadbalancer_id");
        SetOutput("name");
        SetOutput("probe_id");
        SetOutput("protocol");
        SetOutput("tcp_reset_enabled");
    }

    /// <summary>
    /// The backend_address_pool_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>> BackendAddressPoolIds
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("backend_address_pool_ids");
        set => SetProperty("backend_address_pool_ids", value);
    }

    /// <summary>
    /// The backend_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPort is required")]
    public required TerraformProperty<double> BackendPort
    {
        get => GetRequiredOutput<TerraformProperty<double>>("backend_port");
        set => SetProperty("backend_port", value);
    }

    /// <summary>
    /// The disable_outbound_snat attribute.
    /// </summary>
    public TerraformProperty<bool> DisableOutboundSnat
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disable_outbound_snat");
        set => SetProperty("disable_outbound_snat", value);
    }

    /// <summary>
    /// The enable_floating_ip attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool> EnableFloatingIp
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_floating_ip");
        set => SetProperty("enable_floating_ip", value);
    }

    /// <summary>
    /// The enable_tcp_reset attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool> EnableTcpReset
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_tcp_reset");
        set => SetProperty("enable_tcp_reset", value);
    }

    /// <summary>
    /// The floating_ip_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> FloatingIpEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("floating_ip_enabled");
        set => SetProperty("floating_ip_enabled", value);
    }

    /// <summary>
    /// The frontend_ip_configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendIpConfigurationName is required")]
    public required TerraformProperty<string> FrontendIpConfigurationName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("frontend_ip_configuration_name");
        set => SetProperty("frontend_ip_configuration_name", value);
    }

    /// <summary>
    /// The frontend_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendPort is required")]
    public required TerraformProperty<double> FrontendPort
    {
        get => GetRequiredOutput<TerraformProperty<double>>("frontend_port");
        set => SetProperty("frontend_port", value);
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
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double> IdleTimeoutInMinutes
    {
        get => GetRequiredOutput<TerraformProperty<double>>("idle_timeout_in_minutes");
        set => SetProperty("idle_timeout_in_minutes", value);
    }

    /// <summary>
    /// The load_distribution attribute.
    /// </summary>
    public TerraformProperty<string> LoadDistribution
    {
        get => GetRequiredOutput<TerraformProperty<string>>("load_distribution");
        set => SetProperty("load_distribution", value);
    }

    /// <summary>
    /// The loadbalancer_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadbalancerId is required")]
    public required TerraformProperty<string> LoadbalancerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("loadbalancer_id");
        set => SetProperty("loadbalancer_id", value);
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
    /// The probe_id attribute.
    /// </summary>
    public TerraformProperty<string> ProbeId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("probe_id");
        set => SetProperty("probe_id", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        get => GetRequiredOutput<TerraformProperty<string>>("protocol");
        set => SetProperty("protocol", value);
    }

    /// <summary>
    /// The tcp_reset_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> TcpResetEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("tcp_reset_enabled");
        set => SetProperty("tcp_reset_enabled", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLbRuleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The frontend_ip_configuration_id attribute.
    /// </summary>
    public TerraformExpression FrontendIpConfigurationId => this["frontend_ip_configuration_id"];

}
