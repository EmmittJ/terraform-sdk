using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for endpoint in AzurermNetworkConnectionMonitor.
/// Nesting mode: set
/// </summary>
public class AzurermNetworkConnectionMonitorEndpointBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "endpoint";

    /// <summary>
    /// The address attribute.
    /// </summary>
    public TerraformValue<string>? Address
    {
        get => new TerraformReference<string>(this, "address");
        set => SetArgument("address", value);
    }

    /// <summary>
    /// The coverage_level attribute.
    /// </summary>
    public TerraformValue<string>? CoverageLevel
    {
        get => new TerraformReference<string>(this, "coverage_level");
        set => SetArgument("coverage_level", value);
    }

    /// <summary>
    /// The excluded_ip_addresses attribute.
    /// </summary>
    public TerraformSet<string>? ExcludedIpAddresses
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "excluded_ip_addresses").ResolveNodes(ctx));
        set => SetArgument("excluded_ip_addresses", value);
    }

    /// <summary>
    /// The included_ip_addresses attribute.
    /// </summary>
    public TerraformSet<string>? IncludedIpAddresses
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "included_ip_addresses").ResolveNodes(ctx));
        set => SetArgument("included_ip_addresses", value);
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
    /// The target_resource_id attribute.
    /// </summary>
    public TerraformValue<string>? TargetResourceId
    {
        get => new TerraformReference<string>(this, "target_resource_id");
        set => SetArgument("target_resource_id", value);
    }

    /// <summary>
    /// The target_resource_type attribute.
    /// </summary>
    public TerraformValue<string>? TargetResourceType
    {
        get => new TerraformReference<string>(this, "target_resource_type");
        set => SetArgument("target_resource_type", value);
    }

    /// <summary>
    /// Filter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    public TerraformList<AzurermNetworkConnectionMonitorEndpointBlockFilterBlock>? Filter
    {
        get => GetArgument<TerraformList<AzurermNetworkConnectionMonitorEndpointBlockFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}

/// <summary>
/// Block type for filter in AzurermNetworkConnectionMonitorEndpointBlock.
/// Nesting mode: list
/// </summary>
public class AzurermNetworkConnectionMonitorEndpointBlockFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Item block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermNetworkConnectionMonitorEndpointBlockFilterBlockItemBlock>? Item
    {
        get => GetArgument<TerraformSet<AzurermNetworkConnectionMonitorEndpointBlockFilterBlockItemBlock>>("item");
        set => SetArgument("item", value);
    }

}

/// <summary>
/// Block type for item in AzurermNetworkConnectionMonitorEndpointBlockFilterBlock.
/// Nesting mode: set
/// </summary>
public class AzurermNetworkConnectionMonitorEndpointBlockFilterBlockItemBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "item";

    /// <summary>
    /// The address attribute.
    /// </summary>
    public TerraformValue<string>? Address
    {
        get => new TerraformReference<string>(this, "address");
        set => SetArgument("address", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for test_configuration in AzurermNetworkConnectionMonitor.
/// Nesting mode: set
/// </summary>
public class AzurermNetworkConnectionMonitorTestConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "test_configuration";

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
    /// The preferred_ip_version attribute.
    /// </summary>
    public TerraformValue<string>? PreferredIpVersion
    {
        get => new TerraformReference<string>(this, "preferred_ip_version");
        set => SetArgument("preferred_ip_version", value);
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
    /// The test_frequency_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? TestFrequencyInSeconds
    {
        get => new TerraformReference<double>(this, "test_frequency_in_seconds");
        set => SetArgument("test_frequency_in_seconds", value);
    }

    /// <summary>
    /// HttpConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpConfiguration block(s) allowed")]
    public TerraformList<AzurermNetworkConnectionMonitorTestConfigurationBlockHttpConfigurationBlock>? HttpConfiguration
    {
        get => GetArgument<TerraformList<AzurermNetworkConnectionMonitorTestConfigurationBlockHttpConfigurationBlock>>("http_configuration");
        set => SetArgument("http_configuration", value);
    }

    /// <summary>
    /// IcmpConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IcmpConfiguration block(s) allowed")]
    public TerraformList<AzurermNetworkConnectionMonitorTestConfigurationBlockIcmpConfigurationBlock>? IcmpConfiguration
    {
        get => GetArgument<TerraformList<AzurermNetworkConnectionMonitorTestConfigurationBlockIcmpConfigurationBlock>>("icmp_configuration");
        set => SetArgument("icmp_configuration", value);
    }

    /// <summary>
    /// SuccessThreshold block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SuccessThreshold block(s) allowed")]
    public TerraformList<AzurermNetworkConnectionMonitorTestConfigurationBlockSuccessThresholdBlock>? SuccessThreshold
    {
        get => GetArgument<TerraformList<AzurermNetworkConnectionMonitorTestConfigurationBlockSuccessThresholdBlock>>("success_threshold");
        set => SetArgument("success_threshold", value);
    }

    /// <summary>
    /// TcpConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TcpConfiguration block(s) allowed")]
    public TerraformList<AzurermNetworkConnectionMonitorTestConfigurationBlockTcpConfigurationBlock>? TcpConfiguration
    {
        get => GetArgument<TerraformList<AzurermNetworkConnectionMonitorTestConfigurationBlockTcpConfigurationBlock>>("tcp_configuration");
        set => SetArgument("tcp_configuration", value);
    }

}

/// <summary>
/// Block type for http_configuration in AzurermNetworkConnectionMonitorTestConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermNetworkConnectionMonitorTestConfigurationBlockHttpConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_configuration";

    /// <summary>
    /// The method attribute.
    /// </summary>
    public TerraformValue<string>? Method
    {
        get => new TerraformReference<string>(this, "method");
        set => SetArgument("method", value);
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
    public TerraformValue<double>? Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The prefer_https attribute.
    /// </summary>
    public TerraformValue<bool>? PreferHttps
    {
        get => new TerraformReference<bool>(this, "prefer_https");
        set => SetArgument("prefer_https", value);
    }

    /// <summary>
    /// The valid_status_code_ranges attribute.
    /// </summary>
    public TerraformSet<string>? ValidStatusCodeRanges
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "valid_status_code_ranges").ResolveNodes(ctx));
        set => SetArgument("valid_status_code_ranges", value);
    }

    /// <summary>
    /// RequestHeader block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermNetworkConnectionMonitorTestConfigurationBlockHttpConfigurationBlockRequestHeaderBlock>? RequestHeader
    {
        get => GetArgument<TerraformSet<AzurermNetworkConnectionMonitorTestConfigurationBlockHttpConfigurationBlockRequestHeaderBlock>>("request_header");
        set => SetArgument("request_header", value);
    }

}

/// <summary>
/// Block type for request_header in AzurermNetworkConnectionMonitorTestConfigurationBlockHttpConfigurationBlock.
/// Nesting mode: set
/// </summary>
public class AzurermNetworkConnectionMonitorTestConfigurationBlockHttpConfigurationBlockRequestHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_header";

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
/// Block type for icmp_configuration in AzurermNetworkConnectionMonitorTestConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermNetworkConnectionMonitorTestConfigurationBlockIcmpConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "icmp_configuration";

    /// <summary>
    /// The trace_route_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TraceRouteEnabled
    {
        get => new TerraformReference<bool>(this, "trace_route_enabled");
        set => SetArgument("trace_route_enabled", value);
    }

}

/// <summary>
/// Block type for success_threshold in AzurermNetworkConnectionMonitorTestConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermNetworkConnectionMonitorTestConfigurationBlockSuccessThresholdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "success_threshold";

    /// <summary>
    /// The checks_failed_percent attribute.
    /// </summary>
    public TerraformValue<double>? ChecksFailedPercent
    {
        get => new TerraformReference<double>(this, "checks_failed_percent");
        set => SetArgument("checks_failed_percent", value);
    }

    /// <summary>
    /// The round_trip_time_ms attribute.
    /// </summary>
    public TerraformValue<double>? RoundTripTimeMs
    {
        get => new TerraformReference<double>(this, "round_trip_time_ms");
        set => SetArgument("round_trip_time_ms", value);
    }

}

/// <summary>
/// Block type for tcp_configuration in AzurermNetworkConnectionMonitorTestConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermNetworkConnectionMonitorTestConfigurationBlockTcpConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tcp_configuration";

    /// <summary>
    /// The destination_port_behavior attribute.
    /// </summary>
    public TerraformValue<string>? DestinationPortBehavior
    {
        get => new TerraformReference<string>(this, "destination_port_behavior");
        set => SetArgument("destination_port_behavior", value);
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
    /// The trace_route_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TraceRouteEnabled
    {
        get => new TerraformReference<bool>(this, "trace_route_enabled");
        set => SetArgument("trace_route_enabled", value);
    }

}


/// <summary>
/// Block type for test_group in AzurermNetworkConnectionMonitor.
/// Nesting mode: set
/// </summary>
public class AzurermNetworkConnectionMonitorTestGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "test_group";

    /// <summary>
    /// The destination_endpoints attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationEndpoints is required")]
    public required TerraformSet<string> DestinationEndpoints
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "destination_endpoints").ResolveNodes(ctx));
        set => SetArgument("destination_endpoints", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
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
    /// The source_endpoints attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEndpoints is required")]
    public required TerraformSet<string> SourceEndpoints
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "source_endpoints").ResolveNodes(ctx));
        set => SetArgument("source_endpoints", value);
    }

    /// <summary>
    /// The test_configuration_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TestConfigurationNames is required")]
    public required TerraformSet<string> TestConfigurationNames
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "test_configuration_names").ResolveNodes(ctx));
        set => SetArgument("test_configuration_names", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermNetworkConnectionMonitor.
/// Nesting mode: single
/// </summary>
public class AzurermNetworkConnectionMonitorTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_network_connection_monitor Terraform resource.
/// Manages a azurerm_network_connection_monitor resource.
/// </summary>
public partial class AzurermNetworkConnectionMonitor(string name) : TerraformResource("azurerm_network_connection_monitor", name)
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The network_watcher_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkWatcherId is required")]
    public required TerraformValue<string> NetworkWatcherId
    {
        get => new TerraformReference<string>(this, "network_watcher_id");
        set => SetArgument("network_watcher_id", value);
    }

    /// <summary>
    /// The notes attribute.
    /// </summary>
    public TerraformValue<string>? Notes
    {
        get => new TerraformReference<string>(this, "notes");
        set => SetArgument("notes", value);
    }

    /// <summary>
    /// The output_workspace_resource_ids attribute.
    /// </summary>
    public TerraformSet<string>? OutputWorkspaceResourceIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "output_workspace_resource_ids").ResolveNodes(ctx));
        set => SetArgument("output_workspace_resource_ids", value);
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
    /// Endpoint block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Endpoint block(s) required")]
    public required TerraformSet<AzurermNetworkConnectionMonitorEndpointBlock> Endpoint
    {
        get => GetRequiredArgument<TerraformSet<AzurermNetworkConnectionMonitorEndpointBlock>>("endpoint");
        set => SetArgument("endpoint", value);
    }

    /// <summary>
    /// TestConfiguration block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TestConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TestConfiguration block(s) required")]
    public required TerraformSet<AzurermNetworkConnectionMonitorTestConfigurationBlock> TestConfiguration
    {
        get => GetRequiredArgument<TerraformSet<AzurermNetworkConnectionMonitorTestConfigurationBlock>>("test_configuration");
        set => SetArgument("test_configuration", value);
    }

    /// <summary>
    /// TestGroup block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TestGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TestGroup block(s) required")]
    public required TerraformSet<AzurermNetworkConnectionMonitorTestGroupBlock> TestGroup
    {
        get => GetRequiredArgument<TerraformSet<AzurermNetworkConnectionMonitorTestGroupBlock>>("test_group");
        set => SetArgument("test_group", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetworkConnectionMonitorTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetworkConnectionMonitorTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
