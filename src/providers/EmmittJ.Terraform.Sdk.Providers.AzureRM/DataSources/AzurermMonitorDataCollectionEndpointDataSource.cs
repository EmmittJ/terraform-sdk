using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorDataCollectionEndpointDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMonitorDataCollectionEndpointDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The configuration_access_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("configuration_access_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ConfigurationAccessEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "configuration_access_endpoint");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The immutable_id attribute.
    /// </summary>
    [TerraformPropertyName("immutable_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ImmutableId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "immutable_id");

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformPropertyName("kind")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Kind => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kind");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The logs_ingestion_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("logs_ingestion_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LogsIngestionEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "logs_ingestion_endpoint");

    /// <summary>
    /// The metrics_ingestion_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("metrics_ingestion_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MetricsIngestionEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "metrics_ingestion_endpoint");

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> PublicNetworkAccessEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "public_network_access_enabled");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

}
