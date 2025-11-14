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
public class AzurermLbRuleDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_lb_rule.
/// </summary>
public class AzurermLbRuleDataSource : TerraformDataSource
{
    public AzurermLbRuleDataSource(string name) : base("azurerm_lb_rule", name)
    {
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermLbRuleDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The backend_address_pool_id attribute.
    /// </summary>
    [TerraformArgument("backend_address_pool_id")]
    public TerraformValue<string> BackendAddressPoolId
    {
        get => new TerraformReference<string>(this, "backend_address_pool_id");
    }

    /// <summary>
    /// The backend_port attribute.
    /// </summary>
    [TerraformArgument("backend_port")]
    public TerraformValue<double> BackendPort
    {
        get => new TerraformReference<double>(this, "backend_port");
    }

    /// <summary>
    /// The disable_outbound_snat attribute.
    /// </summary>
    [TerraformArgument("disable_outbound_snat")]
    public TerraformValue<bool> DisableOutboundSnat
    {
        get => new TerraformReference<bool>(this, "disable_outbound_snat");
    }

    /// <summary>
    /// The enable_floating_ip attribute.
    /// </summary>
    [TerraformArgument("enable_floating_ip")]
    public TerraformValue<bool> EnableFloatingIp
    {
        get => new TerraformReference<bool>(this, "enable_floating_ip");
    }

    /// <summary>
    /// The enable_tcp_reset attribute.
    /// </summary>
    [TerraformArgument("enable_tcp_reset")]
    public TerraformValue<bool> EnableTcpReset
    {
        get => new TerraformReference<bool>(this, "enable_tcp_reset");
    }

    /// <summary>
    /// The floating_ip_enabled attribute.
    /// </summary>
    [TerraformArgument("floating_ip_enabled")]
    public TerraformValue<bool> FloatingIpEnabled
    {
        get => new TerraformReference<bool>(this, "floating_ip_enabled");
    }

    /// <summary>
    /// The frontend_ip_configuration_name attribute.
    /// </summary>
    [TerraformArgument("frontend_ip_configuration_name")]
    public TerraformValue<string> FrontendIpConfigurationName
    {
        get => new TerraformReference<string>(this, "frontend_ip_configuration_name");
    }

    /// <summary>
    /// The frontend_port attribute.
    /// </summary>
    [TerraformArgument("frontend_port")]
    public TerraformValue<double> FrontendPort
    {
        get => new TerraformReference<double>(this, "frontend_port");
    }

    /// <summary>
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    [TerraformArgument("idle_timeout_in_minutes")]
    public TerraformValue<double> IdleTimeoutInMinutes
    {
        get => new TerraformReference<double>(this, "idle_timeout_in_minutes");
    }

    /// <summary>
    /// The load_distribution attribute.
    /// </summary>
    [TerraformArgument("load_distribution")]
    public TerraformValue<string> LoadDistribution
    {
        get => new TerraformReference<string>(this, "load_distribution");
    }

    /// <summary>
    /// The probe_id attribute.
    /// </summary>
    [TerraformArgument("probe_id")]
    public TerraformValue<string> ProbeId
    {
        get => new TerraformReference<string>(this, "probe_id");
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformArgument("protocol")]
    public TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
    }

    /// <summary>
    /// The tcp_reset_enabled attribute.
    /// </summary>
    [TerraformArgument("tcp_reset_enabled")]
    public TerraformValue<bool> TcpResetEnabled
    {
        get => new TerraformReference<bool>(this, "tcp_reset_enabled");
    }

}
