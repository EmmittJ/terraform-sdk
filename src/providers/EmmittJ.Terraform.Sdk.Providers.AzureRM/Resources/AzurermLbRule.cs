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
public class AzurermLbRuleTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_lb_rule resource.
/// </summary>
public class AzurermLbRule : TerraformResource
{
    public AzurermLbRule(string name) : base("azurerm_lb_rule", name)
    {
    }

    /// <summary>
    /// The backend_address_pool_ids attribute.
    /// </summary>
    [TerraformArgument("backend_address_pool_ids")]
    public TerraformList<string>? BackendAddressPoolIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "backend_address_pool_ids").ResolveNodes(ctx));
        set => SetArgument("backend_address_pool_ids", value);
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
    /// The disable_outbound_snat attribute.
    /// </summary>
    [TerraformArgument("disable_outbound_snat")]
    public TerraformValue<bool>? DisableOutboundSnat
    {
        get => new TerraformReference<bool>(this, "disable_outbound_snat");
        set => SetArgument("disable_outbound_snat", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendPort is required")]
    [TerraformArgument("frontend_port")]
    public required TerraformValue<double> FrontendPort
    {
        get => new TerraformReference<double>(this, "frontend_port");
        set => SetArgument("frontend_port", value);
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
    /// The load_distribution attribute.
    /// </summary>
    [TerraformArgument("load_distribution")]
    public TerraformValue<string>? LoadDistribution
    {
        get => new TerraformReference<string>(this, "load_distribution");
        set => SetArgument("load_distribution", value);
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
    /// The probe_id attribute.
    /// </summary>
    [TerraformArgument("probe_id")]
    public TerraformValue<string>? ProbeId
    {
        get => new TerraformReference<string>(this, "probe_id");
        set => SetArgument("probe_id", value);
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
    public AzurermLbRuleTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The frontend_ip_configuration_id attribute.
    /// </summary>
    [TerraformArgument("frontend_ip_configuration_id")]
    public TerraformValue<string> FrontendIpConfigurationId
    {
        get => new TerraformReference<string>(this, "frontend_ip_configuration_id");
    }

}
