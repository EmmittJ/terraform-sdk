using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Represents a azurerm_lb_rule Terraform data source.
/// Retrieves information about a azurerm_lb_rule.
/// </summary>
public partial class AzurermLbRuleDataSource(string name) : TerraformDataSource("azurerm_lb_rule", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The backend_address_pool_id attribute.
    /// </summary>
    public TerraformValue<string> BackendAddressPoolId
    {
        get => new TerraformReference<string>(this, "backend_address_pool_id");
    }

    /// <summary>
    /// The backend_port attribute.
    /// </summary>
    public TerraformValue<double> BackendPort
    {
        get => new TerraformReference<double>(this, "backend_port");
    }

    /// <summary>
    /// The disable_outbound_snat attribute.
    /// </summary>
    public TerraformValue<bool> DisableOutboundSnat
    {
        get => new TerraformReference<bool>(this, "disable_outbound_snat");
    }

    /// <summary>
    /// The enable_floating_ip attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool> EnableFloatingIp
    {
        get => new TerraformReference<bool>(this, "enable_floating_ip");
    }

    /// <summary>
    /// The enable_tcp_reset attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool> EnableTcpReset
    {
        get => new TerraformReference<bool>(this, "enable_tcp_reset");
    }

    /// <summary>
    /// The floating_ip_enabled attribute.
    /// </summary>
    public TerraformValue<bool> FloatingIpEnabled
    {
        get => new TerraformReference<bool>(this, "floating_ip_enabled");
    }

    /// <summary>
    /// The frontend_ip_configuration_name attribute.
    /// </summary>
    public TerraformValue<string> FrontendIpConfigurationName
    {
        get => new TerraformReference<string>(this, "frontend_ip_configuration_name");
    }

    /// <summary>
    /// The frontend_port attribute.
    /// </summary>
    public TerraformValue<double> FrontendPort
    {
        get => new TerraformReference<double>(this, "frontend_port");
    }

    /// <summary>
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double> IdleTimeoutInMinutes
    {
        get => new TerraformReference<double>(this, "idle_timeout_in_minutes");
    }

    /// <summary>
    /// The load_distribution attribute.
    /// </summary>
    public TerraformValue<string> LoadDistribution
    {
        get => new TerraformReference<string>(this, "load_distribution");
    }

    /// <summary>
    /// The probe_id attribute.
    /// </summary>
    public TerraformValue<string> ProbeId
    {
        get => new TerraformReference<string>(this, "probe_id");
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
    }

    /// <summary>
    /// The tcp_reset_enabled attribute.
    /// </summary>
    public TerraformValue<bool> TcpResetEnabled
    {
        get => new TerraformReference<bool>(this, "tcp_reset_enabled");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermLbRuleDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermLbRuleDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
