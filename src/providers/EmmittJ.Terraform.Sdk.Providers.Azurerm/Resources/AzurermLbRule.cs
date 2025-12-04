using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermLbRule.
/// Nesting mode: single
/// </summary>
public class AzurermLbRuleTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_lb_rule Terraform resource.
/// Manages a azurerm_lb_rule resource.
/// </summary>
public partial class AzurermLbRule(string name) : TerraformResource("azurerm_lb_rule", name)
{
    /// <summary>
    /// The backend_address_pool_ids attribute.
    /// </summary>
    public TerraformList<string>? BackendAddressPoolIds
    {
        get => GetArgument<TerraformList<string>>("backend_address_pool_ids");
        set => SetArgument("backend_address_pool_ids", value);
    }

    /// <summary>
    /// The backend_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPort is required")]
    public required TerraformValue<double> BackendPort
    {
        get => GetRequiredArgument<TerraformValue<double>>("backend_port");
        set => SetArgument("backend_port", value);
    }

    /// <summary>
    /// The disable_outbound_snat attribute.
    /// </summary>
    public TerraformValue<bool>? DisableOutboundSnat
    {
        get => GetArgument<TerraformValue<bool>>("disable_outbound_snat");
        set => SetArgument("disable_outbound_snat", value);
    }

    /// <summary>
    /// The enable_floating_ip attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool> EnableFloatingIp
    {
        get => GetArgument<TerraformValue<bool>>("enable_floating_ip") ?? AsReference("enable_floating_ip");
        set => SetArgument("enable_floating_ip", value);
    }

    /// <summary>
    /// The enable_tcp_reset attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool> EnableTcpReset
    {
        get => GetArgument<TerraformValue<bool>>("enable_tcp_reset") ?? AsReference("enable_tcp_reset");
        set => SetArgument("enable_tcp_reset", value);
    }

    /// <summary>
    /// The floating_ip_enabled attribute.
    /// </summary>
    public TerraformValue<bool> FloatingIpEnabled
    {
        get => GetArgument<TerraformValue<bool>>("floating_ip_enabled") ?? AsReference("floating_ip_enabled");
        set => SetArgument("floating_ip_enabled", value);
    }

    /// <summary>
    /// The frontend_ip_configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendIpConfigurationName is required")]
    public required TerraformValue<string> FrontendIpConfigurationName
    {
        get => GetRequiredArgument<TerraformValue<string>>("frontend_ip_configuration_name");
        set => SetArgument("frontend_ip_configuration_name", value);
    }

    /// <summary>
    /// The frontend_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendPort is required")]
    public required TerraformValue<double> FrontendPort
    {
        get => GetRequiredArgument<TerraformValue<double>>("frontend_port");
        set => SetArgument("frontend_port", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? IdleTimeoutInMinutes
    {
        get => GetArgument<TerraformValue<double>>("idle_timeout_in_minutes");
        set => SetArgument("idle_timeout_in_minutes", value);
    }

    /// <summary>
    /// The load_distribution attribute.
    /// </summary>
    public TerraformValue<string>? LoadDistribution
    {
        get => GetArgument<TerraformValue<string>>("load_distribution");
        set => SetArgument("load_distribution", value);
    }

    /// <summary>
    /// The loadbalancer_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadbalancerId is required")]
    public required TerraformValue<string> LoadbalancerId
    {
        get => GetRequiredArgument<TerraformValue<string>>("loadbalancer_id");
        set => SetArgument("loadbalancer_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The probe_id attribute.
    /// </summary>
    public TerraformValue<string>? ProbeId
    {
        get => GetArgument<TerraformValue<string>>("probe_id");
        set => SetArgument("probe_id", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => GetRequiredArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The tcp_reset_enabled attribute.
    /// </summary>
    public TerraformValue<bool> TcpResetEnabled
    {
        get => GetArgument<TerraformValue<bool>>("tcp_reset_enabled") ?? AsReference("tcp_reset_enabled");
        set => SetArgument("tcp_reset_enabled", value);
    }

    /// <summary>
    /// The frontend_ip_configuration_id attribute.
    /// </summary>
    public TerraformValue<string> FrontendIpConfigurationId
        => AsReference("frontend_ip_configuration_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermLbRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermLbRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
