using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for frontend_ip_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermLbOutboundRuleFrontendIpConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLbOutboundRuleTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_lb_outbound_rule resource.
/// </summary>
public class AzurermLbOutboundRule : TerraformResource
{
    public AzurermLbOutboundRule(string name) : base("azurerm_lb_outbound_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("allocated_outbound_ports");
        SetOutput("backend_address_pool_id");
        SetOutput("enable_tcp_reset");
        SetOutput("id");
        SetOutput("idle_timeout_in_minutes");
        SetOutput("loadbalancer_id");
        SetOutput("name");
        SetOutput("protocol");
        SetOutput("tcp_reset_enabled");
    }

    /// <summary>
    /// The allocated_outbound_ports attribute.
    /// </summary>
    public TerraformProperty<double> AllocatedOutboundPorts
    {
        get => GetRequiredOutput<TerraformProperty<double>>("allocated_outbound_ports");
        set => SetProperty("allocated_outbound_ports", value);
    }

    /// <summary>
    /// The backend_address_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendAddressPoolId is required")]
    public required TerraformProperty<string> BackendAddressPoolId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("backend_address_pool_id");
        set => SetProperty("backend_address_pool_id", value);
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
    /// Block for frontend_ip_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermLbOutboundRuleFrontendIpConfigurationBlock>? FrontendIpConfiguration
    {
        set => SetProperty("frontend_ip_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLbOutboundRuleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
