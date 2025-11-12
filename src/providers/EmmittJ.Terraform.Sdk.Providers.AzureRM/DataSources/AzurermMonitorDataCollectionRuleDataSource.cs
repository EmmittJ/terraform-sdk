using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMonitorDataCollectionRuleDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_monitor_data_collection_rule.
/// </summary>
public partial class AzurermMonitorDataCollectionRuleDataSource : TerraformDataSource
{
    public AzurermMonitorDataCollectionRuleDataSource(string name) : base("azurerm_monitor_data_collection_rule", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermMonitorDataCollectionRuleDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The data_collection_endpoint_id attribute.
    /// </summary>
    [TerraformProperty("data_collection_endpoint_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DataCollectionEndpointId { get; }

    /// <summary>
    /// The data_flow attribute.
    /// </summary>
    [TerraformProperty("data_flow")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> DataFlow { get; }

    /// <summary>
    /// The data_sources attribute.
    /// </summary>
    [TerraformProperty("data_sources")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> DataSources { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The destinations attribute.
    /// </summary>
    [TerraformProperty("destinations")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Destinations { get; }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformProperty("identity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Identity { get; }

    /// <summary>
    /// The immutable_id attribute.
    /// </summary>
    [TerraformProperty("immutable_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ImmutableId { get; }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformProperty("kind")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Kind { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The stream_declaration attribute.
    /// </summary>
    [TerraformProperty("stream_declaration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> StreamDeclaration { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

}
