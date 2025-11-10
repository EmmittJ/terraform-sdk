using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for endpoint in .
/// Nesting mode: set
/// </summary>
public class AzurermNetworkConnectionMonitorEndpointBlock : ITerraformBlock
{
    /// <summary>
    /// The address attribute.
    /// </summary>
    [TerraformPropertyName("address")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Address { get; set; }

    /// <summary>
    /// The coverage_level attribute.
    /// </summary>
    [TerraformPropertyName("coverage_level")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CoverageLevel { get; set; }

    /// <summary>
    /// The excluded_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("excluded_ip_addresses")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ExcludedIpAddresses { get; set; }

    /// <summary>
    /// The included_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("included_ip_addresses")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? IncludedIpAddresses { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("target_resource_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TargetResourceId { get; set; }

    /// <summary>
    /// The target_resource_type attribute.
    /// </summary>
    [TerraformPropertyName("target_resource_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TargetResourceType { get; set; }

}

/// <summary>
/// Block type for test_configuration in .
/// Nesting mode: set
/// </summary>
public class AzurermNetworkConnectionMonitorTestConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The preferred_ip_version attribute.
    /// </summary>
    [TerraformPropertyName("preferred_ip_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PreferredIpVersion { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformPropertyName("protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Protocol { get; set; }

    /// <summary>
    /// The test_frequency_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("test_frequency_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? TestFrequencyInSeconds { get; set; }

}

/// <summary>
/// Block type for test_group in .
/// Nesting mode: set
/// </summary>
public class AzurermNetworkConnectionMonitorTestGroupBlock : ITerraformBlock
{
    /// <summary>
    /// The destination_endpoints attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationEndpoints is required")]
    [TerraformPropertyName("destination_endpoints")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? DestinationEndpoints { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The source_endpoints attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEndpoints is required")]
    [TerraformPropertyName("source_endpoints")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SourceEndpoints { get; set; }

    /// <summary>
    /// The test_configuration_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TestConfigurationNames is required")]
    [TerraformPropertyName("test_configuration_names")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? TestConfigurationNames { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetworkConnectionMonitorTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The network_watcher_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkWatcherId is required")]
    [TerraformPropertyName("network_watcher_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NetworkWatcherId { get; set; }

    /// <summary>
    /// The notes attribute.
    /// </summary>
    [TerraformPropertyName("notes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Notes { get; set; }

    /// <summary>
    /// The output_workspace_resource_ids attribute.
    /// </summary>
    [TerraformPropertyName("output_workspace_resource_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? OutputWorkspaceResourceIds { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for endpoint.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Endpoint block(s) required")]
    [TerraformPropertyName("endpoint")]
    public TerraformSet<TerraformBlock<AzurermNetworkConnectionMonitorEndpointBlock>>? Endpoint { get; set; } = new();

    /// <summary>
    /// Block for test_configuration.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TestConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TestConfiguration block(s) required")]
    [TerraformPropertyName("test_configuration")]
    public TerraformSet<TerraformBlock<AzurermNetworkConnectionMonitorTestConfigurationBlock>>? TestConfiguration { get; set; } = new();

    /// <summary>
    /// Block for test_group.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TestGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TestGroup block(s) required")]
    [TerraformPropertyName("test_group")]
    public TerraformSet<TerraformBlock<AzurermNetworkConnectionMonitorTestGroupBlock>>? TestGroup { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermNetworkConnectionMonitorTimeoutsBlock>? Timeouts { get; set; } = new();

}
