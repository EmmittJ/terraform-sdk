using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermLbRuleDataSource.
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
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
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
    /// The backend_address_pool_id attribute.
    /// </summary>
    public TerraformValue<string> BackendAddressPoolId
        => AsReference("backend_address_pool_id");

    /// <summary>
    /// The backend_port attribute.
    /// </summary>
    public TerraformValue<double> BackendPort
        => AsReference("backend_port");

    /// <summary>
    /// The disable_outbound_snat attribute.
    /// </summary>
    public TerraformValue<bool> DisableOutboundSnat
        => AsReference("disable_outbound_snat");

    /// <summary>
    /// The enable_floating_ip attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool> EnableFloatingIp
        => AsReference("enable_floating_ip");

    /// <summary>
    /// The enable_tcp_reset attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool> EnableTcpReset
        => AsReference("enable_tcp_reset");

    /// <summary>
    /// The floating_ip_enabled attribute.
    /// </summary>
    public TerraformValue<bool> FloatingIpEnabled
        => AsReference("floating_ip_enabled");

    /// <summary>
    /// The frontend_ip_configuration_name attribute.
    /// </summary>
    public TerraformValue<string> FrontendIpConfigurationName
        => AsReference("frontend_ip_configuration_name");

    /// <summary>
    /// The frontend_port attribute.
    /// </summary>
    public TerraformValue<double> FrontendPort
        => AsReference("frontend_port");

    /// <summary>
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double> IdleTimeoutInMinutes
        => AsReference("idle_timeout_in_minutes");

    /// <summary>
    /// The load_distribution attribute.
    /// </summary>
    public TerraformValue<string> LoadDistribution
        => AsReference("load_distribution");

    /// <summary>
    /// The probe_id attribute.
    /// </summary>
    public TerraformValue<string> ProbeId
        => AsReference("probe_id");

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string> Protocol
        => AsReference("protocol");

    /// <summary>
    /// The tcp_reset_enabled attribute.
    /// </summary>
    public TerraformValue<bool> TcpResetEnabled
        => AsReference("tcp_reset_enabled");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermLbRuleDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermLbRuleDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
