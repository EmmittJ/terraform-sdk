using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for dns_config in AzurermTrafficManagerProfile.
/// Nesting mode: list
/// </summary>
public class AzurermTrafficManagerProfileDnsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dns_config";

    /// <summary>
    /// The relative_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelativeName is required")]
    public required TerraformValue<string> RelativeName
    {
        get => new TerraformReference<string>(this, "relative_name");
        set => SetArgument("relative_name", value);
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ttl is required")]
    public required TerraformValue<double> Ttl
    {
        get => new TerraformReference<double>(this, "ttl");
        set => SetArgument("ttl", value);
    }

}


/// <summary>
/// Block type for monitor_config in AzurermTrafficManagerProfile.
/// Nesting mode: list
/// </summary>
public class AzurermTrafficManagerProfileMonitorConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "monitor_config";

    /// <summary>
    /// The expected_status_code_ranges attribute.
    /// </summary>
    public TerraformList<string>? ExpectedStatusCodeRanges
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "expected_status_code_ranges").ResolveNodes(ctx));
        set => SetArgument("expected_status_code_ranges", value);
    }

    /// <summary>
    /// The interval_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? IntervalInSeconds
    {
        get => new TerraformReference<double>(this, "interval_in_seconds");
        set => SetArgument("interval_in_seconds", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
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
    /// The timeout_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? TimeoutInSeconds
    {
        get => new TerraformReference<double>(this, "timeout_in_seconds");
        set => SetArgument("timeout_in_seconds", value);
    }

    /// <summary>
    /// The tolerated_number_of_failures attribute.
    /// </summary>
    public TerraformValue<double>? ToleratedNumberOfFailures
    {
        get => new TerraformReference<double>(this, "tolerated_number_of_failures");
        set => SetArgument("tolerated_number_of_failures", value);
    }

    /// <summary>
    /// CustomHeader block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermTrafficManagerProfileMonitorConfigBlockCustomHeaderBlock>? CustomHeader
    {
        get => GetArgument<TerraformList<AzurermTrafficManagerProfileMonitorConfigBlockCustomHeaderBlock>>("custom_header");
        set => SetArgument("custom_header", value);
    }

}

/// <summary>
/// Block type for custom_header in AzurermTrafficManagerProfileMonitorConfigBlock.
/// Nesting mode: list
/// </summary>
public class AzurermTrafficManagerProfileMonitorConfigBlockCustomHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_header";

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
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermTrafficManagerProfile.
/// Nesting mode: single
/// </summary>
public class AzurermTrafficManagerProfileTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_traffic_manager_profile Terraform resource.
/// Manages a azurerm_traffic_manager_profile resource.
/// </summary>
public partial class AzurermTrafficManagerProfile(string name) : TerraformResource("azurerm_traffic_manager_profile", name)
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
    /// The max_return attribute.
    /// </summary>
    public TerraformValue<double>? MaxReturn
    {
        get => new TerraformReference<double>(this, "max_return");
        set => SetArgument("max_return", value);
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
    /// The profile_status attribute.
    /// </summary>
    public TerraformValue<string>? ProfileStatus
    {
        get => new TerraformReference<string>(this, "profile_status");
        set => SetArgument("profile_status", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The traffic_routing_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrafficRoutingMethod is required")]
    public required TerraformValue<string> TrafficRoutingMethod
    {
        get => new TerraformReference<string>(this, "traffic_routing_method");
        set => SetArgument("traffic_routing_method", value);
    }

    /// <summary>
    /// The traffic_view_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TrafficViewEnabled
    {
        get => new TerraformReference<bool>(this, "traffic_view_enabled");
        set => SetArgument("traffic_view_enabled", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformValue<string> Fqdn
    {
        get => new TerraformReference<string>(this, "fqdn");
    }

    /// <summary>
    /// DnsConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DnsConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsConfig block(s) allowed")]
    public required TerraformList<AzurermTrafficManagerProfileDnsConfigBlock> DnsConfig
    {
        get => GetRequiredArgument<TerraformList<AzurermTrafficManagerProfileDnsConfigBlock>>("dns_config");
        set => SetArgument("dns_config", value);
    }

    /// <summary>
    /// MonitorConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitorConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MonitorConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitorConfig block(s) allowed")]
    public required TerraformList<AzurermTrafficManagerProfileMonitorConfigBlock> MonitorConfig
    {
        get => GetRequiredArgument<TerraformList<AzurermTrafficManagerProfileMonitorConfigBlock>>("monitor_config");
        set => SetArgument("monitor_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermTrafficManagerProfileTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermTrafficManagerProfileTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
