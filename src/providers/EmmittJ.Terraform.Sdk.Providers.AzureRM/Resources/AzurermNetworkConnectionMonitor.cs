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
/// Block type for endpoint in .
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
    [TerraformArgument("address")]
    public TerraformValue<string>? Address
    {
        get => new TerraformReference<string>(this, "address");
        set => SetArgument("address", value);
    }

    /// <summary>
    /// The coverage_level attribute.
    /// </summary>
    [TerraformArgument("coverage_level")]
    public TerraformValue<string>? CoverageLevel
    {
        get => new TerraformReference<string>(this, "coverage_level");
        set => SetArgument("coverage_level", value);
    }

    /// <summary>
    /// The excluded_ip_addresses attribute.
    /// </summary>
    [TerraformArgument("excluded_ip_addresses")]
    public TerraformSet<string>? ExcludedIpAddresses
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "excluded_ip_addresses").ResolveNodes(ctx));
        set => SetArgument("excluded_ip_addresses", value);
    }

    /// <summary>
    /// The included_ip_addresses attribute.
    /// </summary>
    [TerraformArgument("included_ip_addresses")]
    public TerraformSet<string>? IncludedIpAddresses
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "included_ip_addresses").ResolveNodes(ctx));
        set => SetArgument("included_ip_addresses", value);
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
    /// The target_resource_id attribute.
    /// </summary>
    [TerraformArgument("target_resource_id")]
    public TerraformValue<string>? TargetResourceId
    {
        get => new TerraformReference<string>(this, "target_resource_id");
        set => SetArgument("target_resource_id", value);
    }

    /// <summary>
    /// The target_resource_type attribute.
    /// </summary>
    [TerraformArgument("target_resource_type")]
    public TerraformValue<string>? TargetResourceType
    {
        get => new TerraformReference<string>(this, "target_resource_type");
        set => SetArgument("target_resource_type", value);
    }

}

/// <summary>
/// Block type for test_configuration in .
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
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The preferred_ip_version attribute.
    /// </summary>
    [TerraformArgument("preferred_ip_version")]
    public TerraformValue<string>? PreferredIpVersion
    {
        get => new TerraformReference<string>(this, "preferred_ip_version");
        set => SetArgument("preferred_ip_version", value);
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
    /// The test_frequency_in_seconds attribute.
    /// </summary>
    [TerraformArgument("test_frequency_in_seconds")]
    public TerraformValue<double>? TestFrequencyInSeconds
    {
        get => new TerraformReference<double>(this, "test_frequency_in_seconds");
        set => SetArgument("test_frequency_in_seconds", value);
    }

}

/// <summary>
/// Block type for test_group in .
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
    [TerraformArgument("destination_endpoints")]
    public required TerraformSet<string> DestinationEndpoints
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "destination_endpoints").ResolveNodes(ctx));
        set => SetArgument("destination_endpoints", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformArgument("enabled")]
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
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
    /// The source_endpoints attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEndpoints is required")]
    [TerraformArgument("source_endpoints")]
    public required TerraformSet<string> SourceEndpoints
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "source_endpoints").ResolveNodes(ctx));
        set => SetArgument("source_endpoints", value);
    }

    /// <summary>
    /// The test_configuration_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TestConfigurationNames is required")]
    [TerraformArgument("test_configuration_names")]
    public required TerraformSet<string> TestConfigurationNames
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "test_configuration_names").ResolveNodes(ctx));
        set => SetArgument("test_configuration_names", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The network_watcher_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkWatcherId is required")]
    [TerraformArgument("network_watcher_id")]
    public required TerraformValue<string> NetworkWatcherId
    {
        get => new TerraformReference<string>(this, "network_watcher_id");
        set => SetArgument("network_watcher_id", value);
    }

    /// <summary>
    /// The notes attribute.
    /// </summary>
    [TerraformArgument("notes")]
    public TerraformValue<string>? Notes
    {
        get => new TerraformReference<string>(this, "notes");
        set => SetArgument("notes", value);
    }

    /// <summary>
    /// The output_workspace_resource_ids attribute.
    /// </summary>
    [TerraformArgument("output_workspace_resource_ids")]
    public TerraformSet<string>? OutputWorkspaceResourceIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "output_workspace_resource_ids").ResolveNodes(ctx));
        set => SetArgument("output_workspace_resource_ids", value);
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
    /// Block for endpoint.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Endpoint block(s) required")]
    [TerraformArgument("endpoint")]
    public required TerraformSet<AzurermNetworkConnectionMonitorEndpointBlock> Endpoint { get; set; } = new();

    /// <summary>
    /// Block for test_configuration.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TestConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TestConfiguration block(s) required")]
    [TerraformArgument("test_configuration")]
    public required TerraformSet<AzurermNetworkConnectionMonitorTestConfigurationBlock> TestConfiguration { get; set; } = new();

    /// <summary>
    /// Block for test_group.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TestGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TestGroup block(s) required")]
    [TerraformArgument("test_group")]
    public required TerraformSet<AzurermNetworkConnectionMonitorTestGroupBlock> TestGroup { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermNetworkConnectionMonitorTimeoutsBlock Timeouts { get; set; } = new();

}
