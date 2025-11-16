using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<string>(this, "backend_address_pool_id");
        set => SetArgument("backend_address_pool_id", value);
    }

    /// <summary>
    /// The backend_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPort is required")]
    public required TerraformValue<double> BackendPort
    {
        get => new TerraformReference<double>(this, "backend_port");
        set => SetArgument("backend_port", value);
    }

    /// <summary>
    /// The enable_floating_ip attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool> EnableFloatingIp
    {
        get => new TerraformReference<bool>(this, "enable_floating_ip");
        set => SetArgument("enable_floating_ip", value);
    }

    /// <summary>
    /// The enable_tcp_reset attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool> EnableTcpReset
    {
        get => new TerraformReference<bool>(this, "enable_tcp_reset");
        set => SetArgument("enable_tcp_reset", value);
    }

    /// <summary>
    /// The floating_ip_enabled attribute.
    /// </summary>
    public TerraformValue<bool> FloatingIpEnabled
    {
        get => new TerraformReference<bool>(this, "floating_ip_enabled");
        set => SetArgument("floating_ip_enabled", value);
    }

    /// <summary>
    /// The frontend_ip_configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendIpConfigurationName is required")]
    public required TerraformValue<string> FrontendIpConfigurationName
    {
        get => new TerraformReference<string>(this, "frontend_ip_configuration_name");
        set => SetArgument("frontend_ip_configuration_name", value);
    }

    /// <summary>
    /// The frontend_port attribute.
    /// </summary>
    public TerraformValue<double>? FrontendPort
    {
        get => new TerraformReference<double>(this, "frontend_port");
        set => SetArgument("frontend_port", value);
    }

    /// <summary>
    /// The frontend_port_end attribute.
    /// </summary>
    public TerraformValue<double>? FrontendPortEnd
    {
        get => new TerraformReference<double>(this, "frontend_port_end");
        set => SetArgument("frontend_port_end", value);
    }

    /// <summary>
    /// The frontend_port_start attribute.
    /// </summary>
    public TerraformValue<double>? FrontendPortStart
    {
        get => new TerraformReference<double>(this, "frontend_port_start");
        set => SetArgument("frontend_port_start", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? IdleTimeoutInMinutes
    {
        get => new TerraformReference<double>(this, "idle_timeout_in_minutes");
        set => SetArgument("idle_timeout_in_minutes", value);
    }

    /// <summary>
    /// The loadbalancer_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadbalancerId is required")]
    public required TerraformValue<string> LoadbalancerId
    {
        get => new TerraformReference<string>(this, "loadbalancer_id");
        set => SetArgument("loadbalancer_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tcp_reset_enabled attribute.
    /// </summary>
    public TerraformValue<bool> TcpResetEnabled
    {
        get => new TerraformReference<bool>(this, "tcp_reset_enabled");
        set => SetArgument("tcp_reset_enabled", value);
    }

    /// <summary>
    /// The backend_ip_configuration_id attribute.
    /// </summary>
    public TerraformValue<string> BackendIpConfigurationId
    {
        get => new TerraformReference<string>(this, "backend_ip_configuration_id");
    }

    /// <summary>
    /// The frontend_ip_configuration_id attribute.
    /// </summary>
    public TerraformValue<string> FrontendIpConfigurationId
    {
        get => new TerraformReference<string>(this, "frontend_ip_configuration_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermLbNatRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermLbNatRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
