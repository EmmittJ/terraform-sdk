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
/// Block type for dns_config in .
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
    [TerraformArgument("relative_name")]
    public required TerraformValue<string> RelativeName
    {
        get => new TerraformReference<string>(this, "relative_name");
        set => SetArgument("relative_name", value);
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ttl is required")]
    [TerraformArgument("ttl")]
    public required TerraformValue<double> Ttl
    {
        get => new TerraformReference<double>(this, "ttl");
        set => SetArgument("ttl", value);
    }

}

/// <summary>
/// Block type for monitor_config in .
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
    [TerraformArgument("expected_status_code_ranges")]
    public TerraformList<string>? ExpectedStatusCodeRanges
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "expected_status_code_ranges").ResolveNodes(ctx));
        set => SetArgument("expected_status_code_ranges", value);
    }

    /// <summary>
    /// The interval_in_seconds attribute.
    /// </summary>
    [TerraformArgument("interval_in_seconds")]
    public TerraformValue<double>? IntervalInSeconds
    {
        get => new TerraformReference<double>(this, "interval_in_seconds");
        set => SetArgument("interval_in_seconds", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformArgument("path")]
    public TerraformValue<string>? Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    [TerraformArgument("port")]
    public required TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
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
    /// The timeout_in_seconds attribute.
    /// </summary>
    [TerraformArgument("timeout_in_seconds")]
    public TerraformValue<double>? TimeoutInSeconds
    {
        get => new TerraformReference<double>(this, "timeout_in_seconds");
        set => SetArgument("timeout_in_seconds", value);
    }

    /// <summary>
    /// The tolerated_number_of_failures attribute.
    /// </summary>
    [TerraformArgument("tolerated_number_of_failures")]
    public TerraformValue<double>? ToleratedNumberOfFailures
    {
        get => new TerraformReference<double>(this, "tolerated_number_of_failures");
        set => SetArgument("tolerated_number_of_failures", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
/// Manages a azurerm_traffic_manager_profile resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermTrafficManagerProfile : TerraformResource
{
    public AzurermTrafficManagerProfile(string name) : base("azurerm_traffic_manager_profile", name)
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
    /// The max_return attribute.
    /// </summary>
    [TerraformArgument("max_return")]
    public TerraformValue<double>? MaxReturn
    {
        get => new TerraformReference<double>(this, "max_return");
        set => SetArgument("max_return", value);
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
    /// The profile_status attribute.
    /// </summary>
    [TerraformArgument("profile_status")]
    public TerraformValue<string>? ProfileStatus
    {
        get => new TerraformReference<string>(this, "profile_status");
        set => SetArgument("profile_status", value);
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
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The traffic_routing_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrafficRoutingMethod is required")]
    [TerraformArgument("traffic_routing_method")]
    public required TerraformValue<string> TrafficRoutingMethod
    {
        get => new TerraformReference<string>(this, "traffic_routing_method");
        set => SetArgument("traffic_routing_method", value);
    }

    /// <summary>
    /// The traffic_view_enabled attribute.
    /// </summary>
    [TerraformArgument("traffic_view_enabled")]
    public TerraformValue<bool>? TrafficViewEnabled
    {
        get => new TerraformReference<bool>(this, "traffic_view_enabled");
        set => SetArgument("traffic_view_enabled", value);
    }

    /// <summary>
    /// Block for dns_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DnsConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsConfig block(s) allowed")]
    [TerraformArgument("dns_config")]
    public required TerraformList<AzurermTrafficManagerProfileDnsConfigBlock> DnsConfig { get; set; } = new();

    /// <summary>
    /// Block for monitor_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitorConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MonitorConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitorConfig block(s) allowed")]
    [TerraformArgument("monitor_config")]
    public required TerraformList<AzurermTrafficManagerProfileMonitorConfigBlock> MonitorConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermTrafficManagerProfileTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformArgument("fqdn")]
    public TerraformValue<string> Fqdn
    {
        get => new TerraformReference<string>(this, "fqdn");
    }

}
