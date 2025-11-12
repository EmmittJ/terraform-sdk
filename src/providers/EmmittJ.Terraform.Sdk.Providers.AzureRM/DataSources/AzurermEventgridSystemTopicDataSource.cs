using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermEventgridSystemTopicDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_eventgrid_system_topic.
/// </summary>
public partial class AzurermEventgridSystemTopicDataSource : TerraformDataSource
{
    public AzurermEventgridSystemTopicDataSource(string name) : base("azurerm_eventgrid_system_topic", name)
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
    public AzurermEventgridSystemTopicDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformProperty("identity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Identity { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The metric_arm_resource_id attribute.
    /// </summary>
    [TerraformProperty("metric_arm_resource_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MetricArmResourceId { get; }

    /// <summary>
    /// The metric_resource_id attribute.
    /// </summary>
    [TerraformProperty("metric_resource_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MetricResourceId { get; }

    /// <summary>
    /// The source_arm_resource_id attribute.
    /// </summary>
    [TerraformProperty("source_arm_resource_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SourceArmResourceId { get; }

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    [TerraformProperty("source_resource_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SourceResourceId { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The topic_type attribute.
    /// </summary>
    [TerraformProperty("topic_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TopicType { get; }

}
