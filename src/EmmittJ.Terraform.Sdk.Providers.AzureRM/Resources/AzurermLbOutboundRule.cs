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
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
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
    }

    /// <summary>
    /// The allocated_outbound_ports attribute.
    /// </summary>
    public TerraformProperty<double>? AllocatedOutboundPorts
    {
        get => GetProperty<TerraformProperty<double>>("allocated_outbound_ports");
        set => this.WithProperty("allocated_outbound_ports", value);
    }

    /// <summary>
    /// The backend_address_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendAddressPoolId is required")]
    public required TerraformProperty<string> BackendAddressPoolId
    {
        get => GetProperty<TerraformProperty<string>>("backend_address_pool_id");
        set => this.WithProperty("backend_address_pool_id", value);
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
    /// The loadbalancer_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadbalancerId is required")]
    public required TerraformProperty<string> LoadbalancerId
    {
        get => GetProperty<TerraformProperty<string>>("loadbalancer_id");
        set => this.WithProperty("loadbalancer_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
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
    /// Block for frontend_ip_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermLbOutboundRuleFrontendIpConfigurationBlock>? FrontendIpConfiguration
    {
        get => GetProperty<List<AzurermLbOutboundRuleFrontendIpConfigurationBlock>>("frontend_ip_configuration");
        set => this.WithProperty("frontend_ip_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLbOutboundRuleTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermLbOutboundRuleTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
