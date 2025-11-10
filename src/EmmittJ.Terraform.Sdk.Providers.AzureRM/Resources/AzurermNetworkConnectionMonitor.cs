using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for endpoint in .
/// Nesting mode: set
/// </summary>
public class AzurermNetworkConnectionMonitorEndpointBlock : TerraformBlock
{
    /// <summary>
    /// The address attribute.
    /// </summary>
    public TerraformProperty<string>? Address
    {
        get => GetProperty<TerraformProperty<string>>("address");
        set => WithProperty("address", value);
    }

    /// <summary>
    /// The coverage_level attribute.
    /// </summary>
    public TerraformProperty<string>? CoverageLevel
    {
        get => GetProperty<TerraformProperty<string>>("coverage_level");
        set => WithProperty("coverage_level", value);
    }

    /// <summary>
    /// The excluded_ip_addresses attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ExcludedIpAddresses
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("excluded_ip_addresses");
        set => WithProperty("excluded_ip_addresses", value);
    }

    /// <summary>
    /// The included_ip_addresses attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IncludedIpAddresses
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("included_ip_addresses");
        set => WithProperty("included_ip_addresses", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? TargetResourceId
    {
        get => GetProperty<TerraformProperty<string>>("target_resource_id");
        set => WithProperty("target_resource_id", value);
    }

    /// <summary>
    /// The target_resource_type attribute.
    /// </summary>
    public TerraformProperty<string>? TargetResourceType
    {
        get => GetProperty<TerraformProperty<string>>("target_resource_type");
        set => WithProperty("target_resource_type", value);
    }

}

/// <summary>
/// Block type for test_configuration in .
/// Nesting mode: set
/// </summary>
public class AzurermNetworkConnectionMonitorTestConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The preferred_ip_version attribute.
    /// </summary>
    public TerraformProperty<string>? PreferredIpVersion
    {
        get => GetProperty<TerraformProperty<string>>("preferred_ip_version");
        set => WithProperty("preferred_ip_version", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => WithProperty("protocol", value);
    }

    /// <summary>
    /// The test_frequency_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? TestFrequencyInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("test_frequency_in_seconds");
        set => WithProperty("test_frequency_in_seconds", value);
    }

}

/// <summary>
/// Block type for test_group in .
/// Nesting mode: set
/// </summary>
public class AzurermNetworkConnectionMonitorTestGroupBlock : TerraformBlock
{
    /// <summary>
    /// The destination_endpoints attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationEndpoints is required")]
    public HashSet<TerraformProperty<string>>? DestinationEndpoints
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("destination_endpoints");
        set => WithProperty("destination_endpoints", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The source_endpoints attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEndpoints is required")]
    public HashSet<TerraformProperty<string>>? SourceEndpoints
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("source_endpoints");
        set => WithProperty("source_endpoints", value);
    }

    /// <summary>
    /// The test_configuration_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TestConfigurationNames is required")]
    public HashSet<TerraformProperty<string>>? TestConfigurationNames
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("test_configuration_names");
        set => WithProperty("test_configuration_names", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetworkConnectionMonitorTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_network_connection_monitor resource.
/// </summary>
public class AzurermNetworkConnectionMonitor : TerraformResource
{
    public AzurermNetworkConnectionMonitor(string name) : base("azurerm_network_connection_monitor", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The network_watcher_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkWatcherId is required")]
    public required TerraformProperty<string> NetworkWatcherId
    {
        get => GetProperty<TerraformProperty<string>>("network_watcher_id");
        set => this.WithProperty("network_watcher_id", value);
    }

    /// <summary>
    /// The notes attribute.
    /// </summary>
    public TerraformProperty<string>? Notes
    {
        get => GetProperty<TerraformProperty<string>>("notes");
        set => this.WithProperty("notes", value);
    }

    /// <summary>
    /// The output_workspace_resource_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? OutputWorkspaceResourceIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("output_workspace_resource_ids");
        set => this.WithProperty("output_workspace_resource_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for endpoint.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Endpoint block(s) required")]
    public HashSet<AzurermNetworkConnectionMonitorEndpointBlock>? Endpoint
    {
        get => GetProperty<HashSet<AzurermNetworkConnectionMonitorEndpointBlock>>("endpoint");
        set => this.WithProperty("endpoint", value);
    }

    /// <summary>
    /// Block for test_configuration.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TestConfiguration block(s) required")]
    public HashSet<AzurermNetworkConnectionMonitorTestConfigurationBlock>? TestConfiguration
    {
        get => GetProperty<HashSet<AzurermNetworkConnectionMonitorTestConfigurationBlock>>("test_configuration");
        set => this.WithProperty("test_configuration", value);
    }

    /// <summary>
    /// Block for test_group.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TestGroup block(s) required")]
    public HashSet<AzurermNetworkConnectionMonitorTestGroupBlock>? TestGroup
    {
        get => GetProperty<HashSet<AzurermNetworkConnectionMonitorTestGroupBlock>>("test_group");
        set => this.WithProperty("test_group", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetworkConnectionMonitorTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermNetworkConnectionMonitorTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
