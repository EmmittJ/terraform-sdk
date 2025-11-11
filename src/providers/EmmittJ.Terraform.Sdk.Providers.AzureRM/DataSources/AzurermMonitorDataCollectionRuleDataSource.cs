using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorDataCollectionRuleDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    public TerraformBlock<AzurermMonitorDataCollectionRuleDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The data_collection_endpoint_id attribute.
    /// </summary>
    [TerraformPropertyName("data_collection_endpoint_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DataCollectionEndpointId => new TerraformReference(this, "data_collection_endpoint_id");

    /// <summary>
    /// The data_flow attribute.
    /// </summary>
    [TerraformPropertyName("data_flow")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DataFlow => new TerraformReference(this, "data_flow");

    /// <summary>
    /// The data_sources attribute.
    /// </summary>
    [TerraformPropertyName("data_sources")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DataSources => new TerraformReference(this, "data_sources");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The destinations attribute.
    /// </summary>
    [TerraformPropertyName("destinations")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Destinations => new TerraformReference(this, "destinations");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Identity => new TerraformReference(this, "identity");

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
    /// The stream_declaration attribute.
    /// </summary>
    [TerraformPropertyName("stream_declaration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> StreamDeclaration => new TerraformReference(this, "stream_declaration");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

}
