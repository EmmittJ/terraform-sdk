using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for endpoint in .
/// Nesting mode: set
/// </summary>
public partial class AzurermNetworkConnectionMonitorEndpointBlock : TerraformBlockBase
{
    /// <summary>
    /// The address attribute.
    /// </summary>
    [TerraformProperty("address")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Address { get; set; }

    /// <summary>
    /// The coverage_level attribute.
    /// </summary>
    [TerraformProperty("coverage_level")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CoverageLevel { get; set; }

    /// <summary>
    /// The excluded_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("excluded_ip_addresses")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? ExcludedIpAddresses { get; set; }

    /// <summary>
    /// The included_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("included_ip_addresses")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? IncludedIpAddresses { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    [TerraformProperty("target_resource_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TargetResourceId { get; set; }

    /// <summary>
    /// The target_resource_type attribute.
    /// </summary>
    [TerraformProperty("target_resource_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TargetResourceType { get; set; }

}

/// <summary>
/// Block type for test_configuration in .
/// Nesting mode: set
/// </summary>
public partial class AzurermNetworkConnectionMonitorTestConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The preferred_ip_version attribute.
    /// </summary>
    [TerraformProperty("preferred_ip_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PreferredIpVersion { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformProperty("protocol")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Protocol { get; set; }

    /// <summary>
    /// The test_frequency_in_seconds attribute.
    /// </summary>
    [TerraformProperty("test_frequency_in_seconds")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? TestFrequencyInSeconds { get; set; }

}

/// <summary>
/// Block type for test_group in .
/// Nesting mode: set
/// </summary>
public partial class AzurermNetworkConnectionMonitorTestGroupBlock : TerraformBlockBase
{
    /// <summary>
    /// The destination_endpoints attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationEndpoints is required")]
    [TerraformProperty("destination_endpoints")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> DestinationEndpoints { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The source_endpoints attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEndpoints is required")]
    [TerraformProperty("source_endpoints")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> SourceEndpoints { get; set; }

    /// <summary>
    /// The test_configuration_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TestConfigurationNames is required")]
    [TerraformProperty("test_configuration_names")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> TestConfigurationNames { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermNetworkConnectionMonitorTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_network_connection_monitor resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermNetworkConnectionMonitor : TerraformResource
{
    public AzurermNetworkConnectionMonitor(string name) : base("azurerm_network_connection_monitor", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The network_watcher_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkWatcherId is required")]
    [TerraformProperty("network_watcher_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> NetworkWatcherId { get; set; }

    /// <summary>
    /// The notes attribute.
    /// </summary>
    [TerraformProperty("notes")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Notes { get; set; }

    /// <summary>
    /// The output_workspace_resource_ids attribute.
    /// </summary>
    [TerraformProperty("output_workspace_resource_ids")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? OutputWorkspaceResourceIds { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for endpoint.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Endpoint block(s) required")]
    [TerraformProperty("endpoint")]
    public TerraformSet<TerraformBlock<AzurermNetworkConnectionMonitorEndpointBlock>>? Endpoint { get; set; }

    /// <summary>
    /// Block for test_configuration.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TestConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TestConfiguration block(s) required")]
    [TerraformProperty("test_configuration")]
    public TerraformSet<TerraformBlock<AzurermNetworkConnectionMonitorTestConfigurationBlock>>? TestConfiguration { get; set; }

    /// <summary>
    /// Block for test_group.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TestGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TestGroup block(s) required")]
    [TerraformProperty("test_group")]
    public TerraformSet<TerraformBlock<AzurermNetworkConnectionMonitorTestGroupBlock>>? TestGroup { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermNetworkConnectionMonitorTimeoutsBlock>? Timeouts { get; set; }

}
