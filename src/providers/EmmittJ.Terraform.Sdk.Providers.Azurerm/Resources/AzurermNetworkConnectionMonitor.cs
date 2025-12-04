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
        get => GetArgument<TerraformValue<string>>("address");
        set => SetArgument("address", value);
    }

    /// <summary>
    /// The coverage_level attribute.
    /// </summary>
    public TerraformValue<string>? CoverageLevel
    {
        get => GetArgument<TerraformValue<string>>("coverage_level");
        set => SetArgument("coverage_level", value);
    }

    /// <summary>
    /// The excluded_ip_addresses attribute.
    /// </summary>
    public TerraformSet<string>? ExcludedIpAddresses
    {
        get => GetArgument<TerraformSet<string>>("excluded_ip_addresses");
        set => SetArgument("excluded_ip_addresses", value);
    }

    /// <summary>
    /// The included_ip_addresses attribute.
    /// </summary>
    public TerraformSet<string>? IncludedIpAddresses
    {
        get => GetArgument<TerraformSet<string>>("included_ip_addresses");
        set => SetArgument("included_ip_addresses", value);
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
    /// The target_resource_id attribute.
    /// </summary>
    public TerraformValue<string>? TargetResourceId
    {
        get => GetArgument<TerraformValue<string>>("target_resource_id");
        set => SetArgument("target_resource_id", value);
    }

    /// <summary>
    /// The target_resource_type attribute.
    /// </summary>
    public TerraformValue<string>? TargetResourceType
    {
        get => GetArgument<TerraformValue<string>>("target_resource_type");
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
        get => GetArgument<TerraformValue<string>>("type");
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
        get => GetArgument<TerraformValue<string>>("address");
        set => SetArgument("address", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
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
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The preferred_ip_version attribute.
    /// </summary>
    public TerraformValue<string>? PreferredIpVersion
    {
        get => GetArgument<TerraformValue<string>>("preferred_ip_version");
        set => SetArgument("preferred_ip_version", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => GetRequiredArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The test_frequency_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? TestFrequencyInSeconds
    {
        get => GetArgument<TerraformValue<double>>("test_frequency_in_seconds");
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
        get => GetArgument<TerraformValue<string>>("method");
        set => SetArgument("method", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The prefer_https attribute.
    /// </summary>
    public TerraformValue<bool>? PreferHttps
    {
        get => GetArgument<TerraformValue<bool>>("prefer_https");
        set => SetArgument("prefer_https", value);
    }

    /// <summary>
    /// The valid_status_code_ranges attribute.
    /// </summary>
    public TerraformSet<string>? ValidStatusCodeRanges
    {
        get => GetArgument<TerraformSet<string>>("valid_status_code_ranges");
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
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
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
        get => GetArgument<TerraformValue<bool>>("trace_route_enabled");
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
        get => GetArgument<TerraformValue<double>>("checks_failed_percent");
        set => SetArgument("checks_failed_percent", value);
    }

    /// <summary>
    /// The round_trip_time_ms attribute.
    /// </summary>
    public TerraformValue<double>? RoundTripTimeMs
    {
        get => GetArgument<TerraformValue<double>>("round_trip_time_ms");
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
        get => GetArgument<TerraformValue<string>>("destination_port_behavior");
        set => SetArgument("destination_port_behavior", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => GetRequiredArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The trace_route_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TraceRouteEnabled
    {
        get => GetArgument<TerraformValue<bool>>("trace_route_enabled");
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
        get => GetRequiredArgument<TerraformSet<string>>("destination_endpoints");
        set => SetArgument("destination_endpoints", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
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
    /// The source_endpoints attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEndpoints is required")]
    public required TerraformSet<string> SourceEndpoints
    {
        get => GetRequiredArgument<TerraformSet<string>>("source_endpoints");
        set => SetArgument("source_endpoints", value);
    }

    /// <summary>
    /// The test_configuration_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TestConfigurationNames is required")]
    public required TerraformSet<string> TestConfigurationNames
    {
        get => GetRequiredArgument<TerraformSet<string>>("test_configuration_names");
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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
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
    /// The network_watcher_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkWatcherId is required")]
    public required TerraformValue<string> NetworkWatcherId
    {
        get => GetRequiredArgument<TerraformValue<string>>("network_watcher_id");
        set => SetArgument("network_watcher_id", value);
    }

    /// <summary>
    /// The notes attribute.
    /// </summary>
    public TerraformValue<string>? Notes
    {
        get => GetArgument<TerraformValue<string>>("notes");
        set => SetArgument("notes", value);
    }

    /// <summary>
    /// The output_workspace_resource_ids attribute.
    /// </summary>
    public TerraformSet<string>? OutputWorkspaceResourceIds
    {
        get => GetArgument<TerraformSet<string>>("output_workspace_resource_ids");
        set => SetArgument("output_workspace_resource_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
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
