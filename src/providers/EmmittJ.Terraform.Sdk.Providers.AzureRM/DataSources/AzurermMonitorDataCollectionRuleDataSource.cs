using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorDataCollectionRuleDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_monitor_data_collection_rule.
/// </summary>
public class AzurermMonitorDataCollectionRuleDataSource : TerraformDataSource
{
    public AzurermMonitorDataCollectionRuleDataSource(string name) : base("azurerm_monitor_data_collection_rule", name)
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
    public TerraformBlock<AzurermMonitorDataCollectionRuleDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The data_collection_endpoint_id attribute.
    /// </summary>
    [TerraformPropertyName("data_collection_endpoint_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DataCollectionEndpointId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "data_collection_endpoint_id");

    /// <summary>
    /// The data_flow attribute.
    /// </summary>
    [TerraformPropertyName("data_flow")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DataFlow => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "data_flow");

    /// <summary>
    /// The data_sources attribute.
    /// </summary>
    [TerraformPropertyName("data_sources")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DataSources => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "data_sources");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The destinations attribute.
    /// </summary>
    [TerraformPropertyName("destinations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Destinations => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "destinations");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Identity => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "identity");

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
    /// The stream_declaration attribute.
    /// </summary>
    [TerraformPropertyName("stream_declaration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> StreamDeclaration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "stream_declaration");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

}
