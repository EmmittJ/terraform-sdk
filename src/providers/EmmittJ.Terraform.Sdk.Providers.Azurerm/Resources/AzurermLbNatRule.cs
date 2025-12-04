using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermLbNatRule.
/// Nesting mode: single
/// </summary>
public class AzurermLbNatRuleTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_lb_nat_rule Terraform resource.
/// Manages a azurerm_lb_nat_rule resource.
/// </summary>
public partial class AzurermLbNatRule(string name) : TerraformResource("azurerm_lb_nat_rule", name)
{
    /// <summary>
    /// The backend_address_pool_id attribute.
    /// </summary>
    public TerraformValue<string>? BackendAddressPoolId
    {
        get => GetArgument<TerraformValue<string>>("backend_address_pool_id");
        set => SetArgument("backend_address_pool_id", value);
    }

    /// <summary>
    /// The backend_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPort is required")]
    public required TerraformValue<double> BackendPort
    {
        get => GetArgument<TerraformValue<double>>("backend_port");
        set => SetArgument("backend_port", value);
    }

    /// <summary>
    /// The enable_floating_ip attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool>? EnableFloatingIp
    {
        get => GetArgument<TerraformValue<bool>>("enable_floating_ip");
        set => SetArgument("enable_floating_ip", value);
    }

    /// <summary>
    /// The enable_tcp_reset attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool>? EnableTcpReset
    {
        get => GetArgument<TerraformValue<bool>>("enable_tcp_reset");
        set => SetArgument("enable_tcp_reset", value);
    }

    /// <summary>
    /// The floating_ip_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? FloatingIpEnabled
    {
        get => GetArgument<TerraformValue<bool>>("floating_ip_enabled");
        set => SetArgument("floating_ip_enabled", value);
    }

    /// <summary>
    /// The frontend_ip_configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendIpConfigurationName is required")]
    public required TerraformValue<string> FrontendIpConfigurationName
    {
        get => GetArgument<TerraformValue<string>>("frontend_ip_configuration_name");
        set => SetArgument("frontend_ip_configuration_name", value);
    }

    /// <summary>
    /// The frontend_port attribute.
    /// </summary>
    public TerraformValue<double>? FrontendPort
    {
        get => GetArgument<TerraformValue<double>>("frontend_port");
        set => SetArgument("frontend_port", value);
    }

    /// <summary>
    /// The frontend_port_end attribute.
    /// </summary>
    public TerraformValue<double>? FrontendPortEnd
    {
        get => GetArgument<TerraformValue<double>>("frontend_port_end");
        set => SetArgument("frontend_port_end", value);
    }

    /// <summary>
    /// The frontend_port_start attribute.
    /// </summary>
    public TerraformValue<double>? FrontendPortStart
    {
        get => GetArgument<TerraformValue<double>>("frontend_port_start");
        set => SetArgument("frontend_port_start", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
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
    /// The loadbalancer_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadbalancerId is required")]
    public required TerraformValue<string> LoadbalancerId
    {
        get => GetArgument<TerraformValue<string>>("loadbalancer_id");
        set => SetArgument("loadbalancer_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => GetArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tcp_reset_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TcpResetEnabled
    {
        get => GetArgument<TerraformValue<bool>>("tcp_reset_enabled");
        set => SetArgument("tcp_reset_enabled", value);
    }

    /// <summary>
    /// The backend_ip_configuration_id attribute.
    /// </summary>
    public TerraformValue<string> BackendIpConfigurationId
        => AsReference("backend_ip_configuration_id");

    /// <summary>
    /// The frontend_ip_configuration_id attribute.
    /// </summary>
    public TerraformValue<string> FrontendIpConfigurationId
        => AsReference("frontend_ip_configuration_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermLbNatRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermLbNatRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
