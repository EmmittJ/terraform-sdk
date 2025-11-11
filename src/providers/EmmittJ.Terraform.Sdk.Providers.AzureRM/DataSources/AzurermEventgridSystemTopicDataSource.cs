using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermEventgridSystemTopicDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_eventgrid_system_topic.
/// </summary>
public class AzurermEventgridSystemTopicDataSource : TerraformDataSource
{
    public AzurermEventgridSystemTopicDataSource(string name) : base("azurerm_eventgrid_system_topic", name)
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
    public TerraformBlock<AzurermEventgridSystemTopicDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Identity => new TerraformReference(this, "identity");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The metric_arm_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("metric_arm_resource_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MetricArmResourceId => new TerraformReference(this, "metric_arm_resource_id");

    /// <summary>
    /// The metric_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("metric_resource_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MetricResourceId => new TerraformReference(this, "metric_resource_id");

    /// <summary>
    /// The source_arm_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("source_arm_resource_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SourceArmResourceId => new TerraformReference(this, "source_arm_resource_id");

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("source_resource_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SourceResourceId => new TerraformReference(this, "source_resource_id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The topic_type attribute.
    /// </summary>
    [TerraformPropertyName("topic_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TopicType => new TerraformReference(this, "topic_type");

}
