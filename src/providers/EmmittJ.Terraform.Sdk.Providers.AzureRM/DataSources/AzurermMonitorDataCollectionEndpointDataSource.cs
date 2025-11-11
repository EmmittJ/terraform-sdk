using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorDataCollectionEndpointDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_monitor_data_collection_endpoint.
/// </summary>
public class AzurermMonitorDataCollectionEndpointDataSource : TerraformDataSource
{
    public AzurermMonitorDataCollectionEndpointDataSource(string name) : base("azurerm_monitor_data_collection_endpoint", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMonitorDataCollectionEndpointDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The configuration_access_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("configuration_access_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ConfigurationAccessEndpoint => new TerraformReference(this, "configuration_access_endpoint");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The immutable_id attribute.
    /// </summary>
    [TerraformPropertyName("immutable_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ImmutableId => new TerraformReference(this, "immutable_id");

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformPropertyName("kind")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Kind => new TerraformReference(this, "kind");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The logs_ingestion_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("logs_ingestion_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LogsIngestionEndpoint => new TerraformReference(this, "logs_ingestion_endpoint");

    /// <summary>
    /// The metrics_ingestion_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("metrics_ingestion_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MetricsIngestionEndpoint => new TerraformReference(this, "metrics_ingestion_endpoint");

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> PublicNetworkAccessEnabled => new TerraformReference(this, "public_network_access_enabled");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

}
