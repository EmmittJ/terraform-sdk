using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_lb_nat_rule resource.
/// </summary>
public class AzurermLbNatRule : TerraformResource
{
    public AzurermLbNatRule(string name) : base("azurerm_lb_nat_rule", name)
    {
    }

    /// <summary>
    /// The backend_address_pool_id attribute.
    /// </summary>
    [TerraformArgument("backend_address_pool_id")]
    public TerraformValue<string>? BackendAddressPoolId
    {
        get => new TerraformReference<string>(this, "backend_address_pool_id");
        set => SetArgument("backend_address_pool_id", value);
    }

    /// <summary>
    /// The backend_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPort is required")]
    [TerraformArgument("backend_port")]
    public required TerraformValue<double> BackendPort
    {
        get => new TerraformReference<double>(this, "backend_port");
        set => SetArgument("backend_port", value);
    }

    /// <summary>
    /// The enable_floating_ip attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformArgument("enable_floating_ip")]
    public TerraformValue<bool> EnableFloatingIp
    {
        get => new TerraformReference<bool>(this, "enable_floating_ip");
        set => SetArgument("enable_floating_ip", value);
    }

    /// <summary>
    /// The enable_tcp_reset attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformArgument("enable_tcp_reset")]
    public TerraformValue<bool> EnableTcpReset
    {
        get => new TerraformReference<bool>(this, "enable_tcp_reset");
        set => SetArgument("enable_tcp_reset", value);
    }

    /// <summary>
    /// The floating_ip_enabled attribute.
    /// </summary>
    [TerraformArgument("floating_ip_enabled")]
    public TerraformValue<bool> FloatingIpEnabled
    {
        get => new TerraformReference<bool>(this, "floating_ip_enabled");
        set => SetArgument("floating_ip_enabled", value);
    }

    /// <summary>
    /// The frontend_ip_configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendIpConfigurationName is required")]
    [TerraformArgument("frontend_ip_configuration_name")]
    public required TerraformValue<string> FrontendIpConfigurationName
    {
        get => new TerraformReference<string>(this, "frontend_ip_configuration_name");
        set => SetArgument("frontend_ip_configuration_name", value);
    }

    /// <summary>
    /// The frontend_port attribute.
    /// </summary>
    [TerraformArgument("frontend_port")]
    public TerraformValue<double>? FrontendPort
    {
        get => new TerraformReference<double>(this, "frontend_port");
        set => SetArgument("frontend_port", value);
    }

    /// <summary>
    /// The frontend_port_end attribute.
    /// </summary>
    [TerraformArgument("frontend_port_end")]
    public TerraformValue<double>? FrontendPortEnd
    {
        get => new TerraformReference<double>(this, "frontend_port_end");
        set => SetArgument("frontend_port_end", value);
    }

    /// <summary>
    /// The frontend_port_start attribute.
    /// </summary>
    [TerraformArgument("frontend_port_start")]
    public TerraformValue<double>? FrontendPortStart
    {
        get => new TerraformReference<double>(this, "frontend_port_start");
        set => SetArgument("frontend_port_start", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    [TerraformArgument("idle_timeout_in_minutes")]
    public TerraformValue<double>? IdleTimeoutInMinutes
    {
        get => new TerraformReference<double>(this, "idle_timeout_in_minutes");
        set => SetArgument("idle_timeout_in_minutes", value);
    }

    /// <summary>
    /// The loadbalancer_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadbalancerId is required")]
    [TerraformArgument("loadbalancer_id")]
    public required TerraformValue<string> LoadbalancerId
    {
        get => new TerraformReference<string>(this, "loadbalancer_id");
        set => SetArgument("loadbalancer_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformArgument("protocol")]
    public required TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tcp_reset_enabled attribute.
    /// </summary>
    [TerraformArgument("tcp_reset_enabled")]
    public TerraformValue<bool> TcpResetEnabled
    {
        get => new TerraformReference<bool>(this, "tcp_reset_enabled");
        set => SetArgument("tcp_reset_enabled", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermLbNatRuleTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The backend_ip_configuration_id attribute.
    /// </summary>
    [TerraformArgument("backend_ip_configuration_id")]
    public TerraformValue<string> BackendIpConfigurationId
    {
        get => new TerraformReference<string>(this, "backend_ip_configuration_id");
    }

    /// <summary>
    /// The frontend_ip_configuration_id attribute.
    /// </summary>
    [TerraformArgument("frontend_ip_configuration_id")]
    public TerraformValue<string> FrontendIpConfigurationId
    {
        get => new TerraformReference<string>(this, "frontend_ip_configuration_id");
    }

}
