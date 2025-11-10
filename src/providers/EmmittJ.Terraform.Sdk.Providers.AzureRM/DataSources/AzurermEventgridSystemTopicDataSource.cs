using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermEventgridSystemTopicDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    public TerraformBlock<AzurermEventgridSystemTopicDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Identity => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "identity");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The metric_arm_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("metric_arm_resource_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MetricArmResourceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "metric_arm_resource_id");

    /// <summary>
    /// The metric_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("metric_resource_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MetricResourceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "metric_resource_id");

    /// <summary>
    /// The source_arm_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("source_arm_resource_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceArmResourceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_arm_resource_id");

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("source_resource_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceResourceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_resource_id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The topic_type attribute.
    /// </summary>
    [TerraformPropertyName("topic_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TopicType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "topic_type");

}
