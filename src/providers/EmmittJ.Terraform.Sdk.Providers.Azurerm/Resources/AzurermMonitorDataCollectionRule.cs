using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for data_flow in AzurermMonitorDataCollectionRule.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleDataFlowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_flow";

    /// <summary>
    /// The built_in_transform attribute.
    /// </summary>
    public TerraformValue<string>? BuiltInTransform
    {
        get => GetArgument<TerraformValue<string>>("built_in_transform");
        set => SetArgument("built_in_transform", value);
    }

    /// <summary>
    /// The destinations attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destinations is required")]
    public TerraformList<string>? Destinations
    {
        get => GetArgument<TerraformList<string>>("destinations");
        set => SetArgument("destinations", value);
    }

    /// <summary>
    /// The output_stream attribute.
    /// </summary>
    public TerraformValue<string>? OutputStream
    {
        get => GetArgument<TerraformValue<string>>("output_stream");
        set => SetArgument("output_stream", value);
    }

    /// <summary>
    /// The streams attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Streams is required")]
    public TerraformList<string>? Streams
    {
        get => GetArgument<TerraformList<string>>("streams");
        set => SetArgument("streams", value);
    }

    /// <summary>
    /// The transform_kql attribute.
    /// </summary>
    public TerraformValue<string>? TransformKql
    {
        get => GetArgument<TerraformValue<string>>("transform_kql");
        set => SetArgument("transform_kql", value);
    }

}


/// <summary>
/// Block type for data_sources in AzurermMonitorDataCollectionRule.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleDataSourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_sources";

    /// <summary>
    /// DataImport block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataImport block(s) allowed")]
    public TerraformList<AzurermMonitorDataCollectionRuleDataSourcesBlockDataImportBlock>? DataImport
    {
        get => GetArgument<TerraformList<AzurermMonitorDataCollectionRuleDataSourcesBlockDataImportBlock>>("data_import");
        set => SetArgument("data_import", value);
    }

    /// <summary>
    /// Extension block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMonitorDataCollectionRuleDataSourcesBlockExtensionBlock>? Extension
    {
        get => GetArgument<TerraformList<AzurermMonitorDataCollectionRuleDataSourcesBlockExtensionBlock>>("extension");
        set => SetArgument("extension", value);
    }

    /// <summary>
    /// IisLog block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMonitorDataCollectionRuleDataSourcesBlockIisLogBlock>? IisLog
    {
        get => GetArgument<TerraformList<AzurermMonitorDataCollectionRuleDataSourcesBlockIisLogBlock>>("iis_log");
        set => SetArgument("iis_log", value);
    }

    /// <summary>
    /// LogFile block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMonitorDataCollectionRuleDataSourcesBlockLogFileBlock>? LogFile
    {
        get => GetArgument<TerraformList<AzurermMonitorDataCollectionRuleDataSourcesBlockLogFileBlock>>("log_file");
        set => SetArgument("log_file", value);
    }

    /// <summary>
    /// PerformanceCounter block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMonitorDataCollectionRuleDataSourcesBlockPerformanceCounterBlock>? PerformanceCounter
    {
        get => GetArgument<TerraformList<AzurermMonitorDataCollectionRuleDataSourcesBlockPerformanceCounterBlock>>("performance_counter");
        set => SetArgument("performance_counter", value);
    }

    /// <summary>
    /// PlatformTelemetry block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMonitorDataCollectionRuleDataSourcesBlockPlatformTelemetryBlock>? PlatformTelemetry
    {
        get => GetArgument<TerraformList<AzurermMonitorDataCollectionRuleDataSourcesBlockPlatformTelemetryBlock>>("platform_telemetry");
        set => SetArgument("platform_telemetry", value);
    }

    /// <summary>
    /// PrometheusForwarder block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMonitorDataCollectionRuleDataSourcesBlockPrometheusForwarderBlock>? PrometheusForwarder
    {
        get => GetArgument<TerraformList<AzurermMonitorDataCollectionRuleDataSourcesBlockPrometheusForwarderBlock>>("prometheus_forwarder");
        set => SetArgument("prometheus_forwarder", value);
    }

    /// <summary>
    /// Syslog block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMonitorDataCollectionRuleDataSourcesBlockSyslogBlock>? Syslog
    {
        get => GetArgument<TerraformList<AzurermMonitorDataCollectionRuleDataSourcesBlockSyslogBlock>>("syslog");
        set => SetArgument("syslog", value);
    }

    /// <summary>
    /// WindowsEventLog block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMonitorDataCollectionRuleDataSourcesBlockWindowsEventLogBlock>? WindowsEventLog
    {
        get => GetArgument<TerraformList<AzurermMonitorDataCollectionRuleDataSourcesBlockWindowsEventLogBlock>>("windows_event_log");
        set => SetArgument("windows_event_log", value);
    }

    /// <summary>
    /// WindowsFirewallLog block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMonitorDataCollectionRuleDataSourcesBlockWindowsFirewallLogBlock>? WindowsFirewallLog
    {
        get => GetArgument<TerraformList<AzurermMonitorDataCollectionRuleDataSourcesBlockWindowsFirewallLogBlock>>("windows_firewall_log");
        set => SetArgument("windows_firewall_log", value);
    }

}

/// <summary>
/// Block type for data_import in AzurermMonitorDataCollectionRuleDataSourcesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleDataSourcesBlockDataImportBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_import";

    /// <summary>
    /// EventHubDataSource block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventHubDataSource is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EventHubDataSource block(s) required")]
    public required TerraformList<AzurermMonitorDataCollectionRuleDataSourcesBlockDataImportBlockEventHubDataSourceBlock> EventHubDataSource
    {
        get => GetRequiredArgument<TerraformList<AzurermMonitorDataCollectionRuleDataSourcesBlockDataImportBlockEventHubDataSourceBlock>>("event_hub_data_source");
        set => SetArgument("event_hub_data_source", value);
    }

}

/// <summary>
/// Block type for event_hub_data_source in AzurermMonitorDataCollectionRuleDataSourcesBlockDataImportBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleDataSourcesBlockDataImportBlockEventHubDataSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "event_hub_data_source";

    /// <summary>
    /// The consumer_group attribute.
    /// </summary>
    public TerraformValue<string>? ConsumerGroup
    {
        get => GetArgument<TerraformValue<string>>("consumer_group");
        set => SetArgument("consumer_group", value);
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
    /// The stream attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Stream is required")]
    public required TerraformValue<string> Stream
    {
        get => GetRequiredArgument<TerraformValue<string>>("stream");
        set => SetArgument("stream", value);
    }

}

/// <summary>
/// Block type for extension in AzurermMonitorDataCollectionRuleDataSourcesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleDataSourcesBlockExtensionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "extension";

    /// <summary>
    /// The extension_json attribute.
    /// </summary>
    public TerraformValue<string>? ExtensionJson
    {
        get => GetArgument<TerraformValue<string>>("extension_json");
        set => SetArgument("extension_json", value);
    }

    /// <summary>
    /// The extension_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExtensionName is required")]
    public required TerraformValue<string> ExtensionName
    {
        get => GetRequiredArgument<TerraformValue<string>>("extension_name");
        set => SetArgument("extension_name", value);
    }

    /// <summary>
    /// The input_data_sources attribute.
    /// </summary>
    public TerraformList<string>? InputDataSources
    {
        get => GetArgument<TerraformList<string>>("input_data_sources");
        set => SetArgument("input_data_sources", value);
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
    /// The streams attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Streams is required")]
    public TerraformList<string>? Streams
    {
        get => GetArgument<TerraformList<string>>("streams");
        set => SetArgument("streams", value);
    }

}

/// <summary>
/// Block type for iis_log in AzurermMonitorDataCollectionRuleDataSourcesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleDataSourcesBlockIisLogBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "iis_log";

    /// <summary>
    /// The log_directories attribute.
    /// </summary>
    public TerraformList<string>? LogDirectories
    {
        get => GetArgument<TerraformList<string>>("log_directories");
        set => SetArgument("log_directories", value);
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
    /// The streams attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Streams is required")]
    public TerraformList<string>? Streams
    {
        get => GetArgument<TerraformList<string>>("streams");
        set => SetArgument("streams", value);
    }

}

/// <summary>
/// Block type for log_file in AzurermMonitorDataCollectionRuleDataSourcesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleDataSourcesBlockLogFileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "log_file";

    /// <summary>
    /// The file_patterns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilePatterns is required")]
    public TerraformList<string>? FilePatterns
    {
        get => GetArgument<TerraformList<string>>("file_patterns");
        set => SetArgument("file_patterns", value);
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    public required TerraformValue<string> Format
    {
        get => GetRequiredArgument<TerraformValue<string>>("format");
        set => SetArgument("format", value);
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
    /// The streams attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Streams is required")]
    public TerraformList<string>? Streams
    {
        get => GetArgument<TerraformList<string>>("streams");
        set => SetArgument("streams", value);
    }

    /// <summary>
    /// Settings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Settings block(s) allowed")]
    public TerraformList<AzurermMonitorDataCollectionRuleDataSourcesBlockLogFileBlockSettingsBlock>? Settings
    {
        get => GetArgument<TerraformList<AzurermMonitorDataCollectionRuleDataSourcesBlockLogFileBlockSettingsBlock>>("settings");
        set => SetArgument("settings", value);
    }

}

/// <summary>
/// Block type for settings in AzurermMonitorDataCollectionRuleDataSourcesBlockLogFileBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleDataSourcesBlockLogFileBlockSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "settings";

    /// <summary>
    /// Text block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Text is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Text block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Text block(s) allowed")]
    public required TerraformList<AzurermMonitorDataCollectionRuleDataSourcesBlockLogFileBlockSettingsBlockTextBlock> Text
    {
        get => GetRequiredArgument<TerraformList<AzurermMonitorDataCollectionRuleDataSourcesBlockLogFileBlockSettingsBlockTextBlock>>("text");
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for text in AzurermMonitorDataCollectionRuleDataSourcesBlockLogFileBlockSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleDataSourcesBlockLogFileBlockSettingsBlockTextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "text";

    /// <summary>
    /// The record_start_timestamp_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecordStartTimestampFormat is required")]
    public required TerraformValue<string> RecordStartTimestampFormat
    {
        get => GetRequiredArgument<TerraformValue<string>>("record_start_timestamp_format");
        set => SetArgument("record_start_timestamp_format", value);
    }

}

/// <summary>
/// Block type for performance_counter in AzurermMonitorDataCollectionRuleDataSourcesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleDataSourcesBlockPerformanceCounterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "performance_counter";

    /// <summary>
    /// The counter_specifiers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CounterSpecifiers is required")]
    public TerraformList<string>? CounterSpecifiers
    {
        get => GetArgument<TerraformList<string>>("counter_specifiers");
        set => SetArgument("counter_specifiers", value);
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
    /// The sampling_frequency_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SamplingFrequencyInSeconds is required")]
    public required TerraformValue<double> SamplingFrequencyInSeconds
    {
        get => GetRequiredArgument<TerraformValue<double>>("sampling_frequency_in_seconds");
        set => SetArgument("sampling_frequency_in_seconds", value);
    }

    /// <summary>
    /// The streams attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Streams is required")]
    public TerraformList<string>? Streams
    {
        get => GetArgument<TerraformList<string>>("streams");
        set => SetArgument("streams", value);
    }

}

/// <summary>
/// Block type for platform_telemetry in AzurermMonitorDataCollectionRuleDataSourcesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleDataSourcesBlockPlatformTelemetryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "platform_telemetry";

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
    /// The streams attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Streams is required")]
    public TerraformList<string>? Streams
    {
        get => GetArgument<TerraformList<string>>("streams");
        set => SetArgument("streams", value);
    }

}

/// <summary>
/// Block type for prometheus_forwarder in AzurermMonitorDataCollectionRuleDataSourcesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleDataSourcesBlockPrometheusForwarderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "prometheus_forwarder";

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
    /// The streams attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Streams is required")]
    public TerraformList<string>? Streams
    {
        get => GetArgument<TerraformList<string>>("streams");
        set => SetArgument("streams", value);
    }

    /// <summary>
    /// LabelIncludeFilter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermMonitorDataCollectionRuleDataSourcesBlockPrometheusForwarderBlockLabelIncludeFilterBlock>? LabelIncludeFilter
    {
        get => GetArgument<TerraformSet<AzurermMonitorDataCollectionRuleDataSourcesBlockPrometheusForwarderBlockLabelIncludeFilterBlock>>("label_include_filter");
        set => SetArgument("label_include_filter", value);
    }

}

/// <summary>
/// Block type for label_include_filter in AzurermMonitorDataCollectionRuleDataSourcesBlockPrometheusForwarderBlock.
/// Nesting mode: set
/// </summary>
public class AzurermMonitorDataCollectionRuleDataSourcesBlockPrometheusForwarderBlockLabelIncludeFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "label_include_filter";

    /// <summary>
    /// The label attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Label is required")]
    public required TerraformValue<string> Label
    {
        get => GetRequiredArgument<TerraformValue<string>>("label");
        set => SetArgument("label", value);
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
/// Block type for syslog in AzurermMonitorDataCollectionRuleDataSourcesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleDataSourcesBlockSyslogBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "syslog";

    /// <summary>
    /// The facility_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FacilityNames is required")]
    public TerraformList<string>? FacilityNames
    {
        get => GetArgument<TerraformList<string>>("facility_names");
        set => SetArgument("facility_names", value);
    }

    /// <summary>
    /// The log_levels attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogLevels is required")]
    public TerraformList<string>? LogLevels
    {
        get => GetArgument<TerraformList<string>>("log_levels");
        set => SetArgument("log_levels", value);
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
    /// The streams attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Streams is required")]
    public TerraformList<string>? Streams
    {
        get => GetArgument<TerraformList<string>>("streams");
        set => SetArgument("streams", value);
    }

}

/// <summary>
/// Block type for windows_event_log in AzurermMonitorDataCollectionRuleDataSourcesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleDataSourcesBlockWindowsEventLogBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "windows_event_log";

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
    /// The streams attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Streams is required")]
    public TerraformList<string>? Streams
    {
        get => GetArgument<TerraformList<string>>("streams");
        set => SetArgument("streams", value);
    }

    /// <summary>
    /// The x_path_queries attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "XPathQueries is required")]
    public TerraformList<string>? XPathQueries
    {
        get => GetArgument<TerraformList<string>>("x_path_queries");
        set => SetArgument("x_path_queries", value);
    }

}

/// <summary>
/// Block type for windows_firewall_log in AzurermMonitorDataCollectionRuleDataSourcesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleDataSourcesBlockWindowsFirewallLogBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "windows_firewall_log";

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
    /// The streams attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Streams is required")]
    public TerraformList<string>? Streams
    {
        get => GetArgument<TerraformList<string>>("streams");
        set => SetArgument("streams", value);
    }

}


/// <summary>
/// Block type for destinations in AzurermMonitorDataCollectionRule.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleDestinationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destinations";

    /// <summary>
    /// AzureMonitorMetrics block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureMonitorMetrics block(s) allowed")]
    public TerraformList<AzurermMonitorDataCollectionRuleDestinationsBlockAzureMonitorMetricsBlock>? AzureMonitorMetrics
    {
        get => GetArgument<TerraformList<AzurermMonitorDataCollectionRuleDestinationsBlockAzureMonitorMetricsBlock>>("azure_monitor_metrics");
        set => SetArgument("azure_monitor_metrics", value);
    }

    /// <summary>
    /// EventHub block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventHub block(s) allowed")]
    public TerraformList<AzurermMonitorDataCollectionRuleDestinationsBlockEventHubBlock>? EventHub
    {
        get => GetArgument<TerraformList<AzurermMonitorDataCollectionRuleDestinationsBlockEventHubBlock>>("event_hub");
        set => SetArgument("event_hub", value);
    }

    /// <summary>
    /// EventHubDirect block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventHubDirect block(s) allowed")]
    public TerraformList<AzurermMonitorDataCollectionRuleDestinationsBlockEventHubDirectBlock>? EventHubDirect
    {
        get => GetArgument<TerraformList<AzurermMonitorDataCollectionRuleDestinationsBlockEventHubDirectBlock>>("event_hub_direct");
        set => SetArgument("event_hub_direct", value);
    }

    /// <summary>
    /// LogAnalytics block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMonitorDataCollectionRuleDestinationsBlockLogAnalyticsBlock>? LogAnalytics
    {
        get => GetArgument<TerraformList<AzurermMonitorDataCollectionRuleDestinationsBlockLogAnalyticsBlock>>("log_analytics");
        set => SetArgument("log_analytics", value);
    }

    /// <summary>
    /// MonitorAccount block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMonitorDataCollectionRuleDestinationsBlockMonitorAccountBlock>? MonitorAccount
    {
        get => GetArgument<TerraformList<AzurermMonitorDataCollectionRuleDestinationsBlockMonitorAccountBlock>>("monitor_account");
        set => SetArgument("monitor_account", value);
    }

    /// <summary>
    /// StorageBlob block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMonitorDataCollectionRuleDestinationsBlockStorageBlobBlock>? StorageBlob
    {
        get => GetArgument<TerraformList<AzurermMonitorDataCollectionRuleDestinationsBlockStorageBlobBlock>>("storage_blob");
        set => SetArgument("storage_blob", value);
    }

    /// <summary>
    /// StorageBlobDirect block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMonitorDataCollectionRuleDestinationsBlockStorageBlobDirectBlock>? StorageBlobDirect
    {
        get => GetArgument<TerraformList<AzurermMonitorDataCollectionRuleDestinationsBlockStorageBlobDirectBlock>>("storage_blob_direct");
        set => SetArgument("storage_blob_direct", value);
    }

    /// <summary>
    /// StorageTableDirect block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMonitorDataCollectionRuleDestinationsBlockStorageTableDirectBlock>? StorageTableDirect
    {
        get => GetArgument<TerraformList<AzurermMonitorDataCollectionRuleDestinationsBlockStorageTableDirectBlock>>("storage_table_direct");
        set => SetArgument("storage_table_direct", value);
    }

}

/// <summary>
/// Block type for azure_monitor_metrics in AzurermMonitorDataCollectionRuleDestinationsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleDestinationsBlockAzureMonitorMetricsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "azure_monitor_metrics";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for event_hub in AzurermMonitorDataCollectionRuleDestinationsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleDestinationsBlockEventHubBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "event_hub";

    /// <summary>
    /// The event_hub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventHubId is required")]
    public required TerraformValue<string> EventHubId
    {
        get => GetRequiredArgument<TerraformValue<string>>("event_hub_id");
        set => SetArgument("event_hub_id", value);
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

}

/// <summary>
/// Block type for event_hub_direct in AzurermMonitorDataCollectionRuleDestinationsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleDestinationsBlockEventHubDirectBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "event_hub_direct";

    /// <summary>
    /// The event_hub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventHubId is required")]
    public required TerraformValue<string> EventHubId
    {
        get => GetRequiredArgument<TerraformValue<string>>("event_hub_id");
        set => SetArgument("event_hub_id", value);
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

}

/// <summary>
/// Block type for log_analytics in AzurermMonitorDataCollectionRuleDestinationsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleDestinationsBlockLogAnalyticsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "log_analytics";

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
    /// The workspace_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceResourceId is required")]
    public required TerraformValue<string> WorkspaceResourceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("workspace_resource_id");
        set => SetArgument("workspace_resource_id", value);
    }

}

/// <summary>
/// Block type for monitor_account in AzurermMonitorDataCollectionRuleDestinationsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleDestinationsBlockMonitorAccountBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "monitor_account";

    /// <summary>
    /// The monitor_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitorAccountId is required")]
    public required TerraformValue<string> MonitorAccountId
    {
        get => GetRequiredArgument<TerraformValue<string>>("monitor_account_id");
        set => SetArgument("monitor_account_id", value);
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

}

/// <summary>
/// Block type for storage_blob in AzurermMonitorDataCollectionRuleDestinationsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleDestinationsBlockStorageBlobBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_blob";

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    public required TerraformValue<string> ContainerName
    {
        get => GetRequiredArgument<TerraformValue<string>>("container_name");
        set => SetArgument("container_name", value);
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
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformValue<string> StorageAccountId
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

}

/// <summary>
/// Block type for storage_blob_direct in AzurermMonitorDataCollectionRuleDestinationsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleDestinationsBlockStorageBlobDirectBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_blob_direct";

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    public required TerraformValue<string> ContainerName
    {
        get => GetRequiredArgument<TerraformValue<string>>("container_name");
        set => SetArgument("container_name", value);
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
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformValue<string> StorageAccountId
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

}

/// <summary>
/// Block type for storage_table_direct in AzurermMonitorDataCollectionRuleDestinationsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleDestinationsBlockStorageTableDirectBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_table_direct";

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
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformValue<string> StorageAccountId
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformValue<string> TableName
    {
        get => GetRequiredArgument<TerraformValue<string>>("table_name");
        set => SetArgument("table_name", value);
    }

}


/// <summary>
/// Block type for identity in AzurermMonitorDataCollectionRule.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public TerraformSet<string>? IdentityIds
    {
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
        => CreateReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => CreateReference("tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for stream_declaration in AzurermMonitorDataCollectionRule.
/// Nesting mode: set
/// </summary>
public class AzurermMonitorDataCollectionRuleStreamDeclarationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "stream_declaration";

    /// <summary>
    /// The stream_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamName is required")]
    public required TerraformValue<string> StreamName
    {
        get => GetRequiredArgument<TerraformValue<string>>("stream_name");
        set => SetArgument("stream_name", value);
    }

    /// <summary>
    /// Column block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Column is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Column block(s) required")]
    public required TerraformList<AzurermMonitorDataCollectionRuleStreamDeclarationBlockColumnBlock> Column
    {
        get => GetRequiredArgument<TerraformList<AzurermMonitorDataCollectionRuleStreamDeclarationBlockColumnBlock>>("column");
        set => SetArgument("column", value);
    }

}

/// <summary>
/// Block type for column in AzurermMonitorDataCollectionRuleStreamDeclarationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleStreamDeclarationBlockColumnBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "column";

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
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermMonitorDataCollectionRule.
/// Nesting mode: single
/// </summary>
public class AzurermMonitorDataCollectionRuleTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_monitor_data_collection_rule Terraform resource.
/// Manages a azurerm_monitor_data_collection_rule resource.
/// </summary>
public partial class AzurermMonitorDataCollectionRule(string name) : TerraformResource("azurerm_monitor_data_collection_rule", name)
{
    /// <summary>
    /// The data_collection_endpoint_id attribute.
    /// </summary>
    public TerraformValue<string>? DataCollectionEndpointId
    {
        get => GetArgument<TerraformValue<string>>("data_collection_endpoint_id");
        set => SetArgument("data_collection_endpoint_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformValue<string>? Kind
    {
        get => GetArgument<TerraformValue<string>>("kind");
        set => SetArgument("kind", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
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
    /// The immutable_id attribute.
    /// </summary>
    public TerraformValue<string> ImmutableId
        => CreateReference("immutable_id");

    /// <summary>
    /// DataFlow block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFlow is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DataFlow block(s) required")]
    public required TerraformList<AzurermMonitorDataCollectionRuleDataFlowBlock> DataFlow
    {
        get => GetRequiredArgument<TerraformList<AzurermMonitorDataCollectionRuleDataFlowBlock>>("data_flow");
        set => SetArgument("data_flow", value);
    }

    /// <summary>
    /// DataSources block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataSources block(s) allowed")]
    public TerraformList<AzurermMonitorDataCollectionRuleDataSourcesBlock>? DataSources
    {
        get => GetArgument<TerraformList<AzurermMonitorDataCollectionRuleDataSourcesBlock>>("data_sources");
        set => SetArgument("data_sources", value);
    }

    /// <summary>
    /// Destinations block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destinations is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destinations block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destinations block(s) allowed")]
    public required TerraformList<AzurermMonitorDataCollectionRuleDestinationsBlock> Destinations
    {
        get => GetRequiredArgument<TerraformList<AzurermMonitorDataCollectionRuleDestinationsBlock>>("destinations");
        set => SetArgument("destinations", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermMonitorDataCollectionRuleIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermMonitorDataCollectionRuleIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// StreamDeclaration block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermMonitorDataCollectionRuleStreamDeclarationBlock>? StreamDeclaration
    {
        get => GetArgument<TerraformSet<AzurermMonitorDataCollectionRuleStreamDeclarationBlock>>("stream_declaration");
        set => SetArgument("stream_declaration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMonitorDataCollectionRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMonitorDataCollectionRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
