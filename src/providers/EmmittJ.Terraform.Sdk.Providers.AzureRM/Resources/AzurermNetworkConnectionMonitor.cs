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
        set => SetProperty("address", value);
    }

    /// <summary>
    /// The coverage_level attribute.
    /// </summary>
    public TerraformProperty<string>? CoverageLevel
    {
        set => SetProperty("coverage_level", value);
    }

    /// <summary>
    /// The excluded_ip_addresses attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ExcludedIpAddresses
    {
        set => SetProperty("excluded_ip_addresses", value);
    }

    /// <summary>
    /// The included_ip_addresses attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IncludedIpAddresses
    {
        set => SetProperty("included_ip_addresses", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? TargetResourceId
    {
        set => SetProperty("target_resource_id", value);
    }

    /// <summary>
    /// The target_resource_type attribute.
    /// </summary>
    public TerraformProperty<string>? TargetResourceType
    {
        set => SetProperty("target_resource_type", value);
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
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The preferred_ip_version attribute.
    /// </summary>
    public TerraformProperty<string>? PreferredIpVersion
    {
        set => SetProperty("preferred_ip_version", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        set => SetProperty("protocol", value);
    }

    /// <summary>
    /// The test_frequency_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? TestFrequencyInSeconds
    {
        set => SetProperty("test_frequency_in_seconds", value);
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
        set => SetProperty("destination_endpoints", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The source_endpoints attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEndpoints is required")]
    public HashSet<TerraformProperty<string>>? SourceEndpoints
    {
        set => SetProperty("source_endpoints", value);
    }

    /// <summary>
    /// The test_configuration_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TestConfigurationNames is required")]
    public HashSet<TerraformProperty<string>>? TestConfigurationNames
    {
        set => SetProperty("test_configuration_names", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_network_connection_monitor resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermNetworkConnectionMonitor : TerraformResource
{
    public AzurermNetworkConnectionMonitor(string name) : base("azurerm_network_connection_monitor", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("network_watcher_id");
        SetOutput("notes");
        SetOutput("output_workspace_resource_ids");
        SetOutput("tags");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The network_watcher_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkWatcherId is required")]
    public required TerraformProperty<string> NetworkWatcherId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_watcher_id");
        set => SetProperty("network_watcher_id", value);
    }

    /// <summary>
    /// The notes attribute.
    /// </summary>
    public TerraformProperty<string> Notes
    {
        get => GetRequiredOutput<TerraformProperty<string>>("notes");
        set => SetProperty("notes", value);
    }

    /// <summary>
    /// The output_workspace_resource_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> OutputWorkspaceResourceIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("output_workspace_resource_ids");
        set => SetProperty("output_workspace_resource_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for endpoint.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Endpoint block(s) required")]
    public HashSet<AzurermNetworkConnectionMonitorEndpointBlock>? Endpoint
    {
        set => SetProperty("endpoint", value);
    }

    /// <summary>
    /// Block for test_configuration.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TestConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TestConfiguration block(s) required")]
    public HashSet<AzurermNetworkConnectionMonitorTestConfigurationBlock>? TestConfiguration
    {
        set => SetProperty("test_configuration", value);
    }

    /// <summary>
    /// Block for test_group.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TestGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TestGroup block(s) required")]
    public HashSet<AzurermNetworkConnectionMonitorTestGroupBlock>? TestGroup
    {
        set => SetProperty("test_group", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetworkConnectionMonitorTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
