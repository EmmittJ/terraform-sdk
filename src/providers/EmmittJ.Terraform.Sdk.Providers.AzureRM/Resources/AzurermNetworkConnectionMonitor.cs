using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for endpoint in .
/// Nesting mode: set
/// </summary>
public class AzurermNetworkConnectionMonitorEndpointBlock
{
    /// <summary>
    /// The address attribute.
    /// </summary>
    [TerraformPropertyName("address")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Address { get; set; }

    /// <summary>
    /// The coverage_level attribute.
    /// </summary>
    [TerraformPropertyName("coverage_level")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CoverageLevel { get; set; }

    /// <summary>
    /// The excluded_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("excluded_ip_addresses")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? ExcludedIpAddresses { get; set; }

    /// <summary>
    /// The included_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("included_ip_addresses")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? IncludedIpAddresses { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("target_resource_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TargetResourceId { get; set; }

    /// <summary>
    /// The target_resource_type attribute.
    /// </summary>
    [TerraformPropertyName("target_resource_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TargetResourceType { get; set; }

}

/// <summary>
/// Block type for test_configuration in .
/// Nesting mode: set
/// </summary>
public class AzurermNetworkConnectionMonitorTestConfigurationBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The preferred_ip_version attribute.
    /// </summary>
    [TerraformPropertyName("preferred_ip_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PreferredIpVersion { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformPropertyName("protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Protocol { get; set; }

    /// <summary>
    /// The test_frequency_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("test_frequency_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TestFrequencyInSeconds { get; set; }

}

/// <summary>
/// Block type for test_group in .
/// Nesting mode: set
/// </summary>
public class AzurermNetworkConnectionMonitorTestGroupBlock
{
    /// <summary>
    /// The destination_endpoints attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationEndpoints is required")]
    [TerraformPropertyName("destination_endpoints")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> DestinationEndpoints { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The source_endpoints attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEndpoints is required")]
    [TerraformPropertyName("source_endpoints")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> SourceEndpoints { get; set; }

    /// <summary>
    /// The test_configuration_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TestConfigurationNames is required")]
    [TerraformPropertyName("test_configuration_names")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> TestConfigurationNames { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetworkConnectionMonitorTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_network_connection_monitor resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermNetworkConnectionMonitor : TerraformResource
{
    public AzurermNetworkConnectionMonitor(string name) : base("azurerm_network_connection_monitor", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The network_watcher_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkWatcherId is required")]
    [TerraformPropertyName("network_watcher_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> NetworkWatcherId { get; set; }

    /// <summary>
    /// The notes attribute.
    /// </summary>
    [TerraformPropertyName("notes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Notes { get; set; }

    /// <summary>
    /// The output_workspace_resource_ids attribute.
    /// </summary>
    [TerraformPropertyName("output_workspace_resource_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? OutputWorkspaceResourceIds { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for endpoint.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Endpoint block(s) required")]
    [TerraformPropertyName("endpoint")]
    public TerraformSet<TerraformBlock<AzurermNetworkConnectionMonitorEndpointBlock>>? Endpoint { get; set; }

    /// <summary>
    /// Block for test_configuration.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TestConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TestConfiguration block(s) required")]
    [TerraformPropertyName("test_configuration")]
    public TerraformSet<TerraformBlock<AzurermNetworkConnectionMonitorTestConfigurationBlock>>? TestConfiguration { get; set; }

    /// <summary>
    /// Block for test_group.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TestGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TestGroup block(s) required")]
    [TerraformPropertyName("test_group")]
    public TerraformSet<TerraformBlock<AzurermNetworkConnectionMonitorTestGroupBlock>>? TestGroup { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermNetworkConnectionMonitorTimeoutsBlock>? Timeouts { get; set; }

}
