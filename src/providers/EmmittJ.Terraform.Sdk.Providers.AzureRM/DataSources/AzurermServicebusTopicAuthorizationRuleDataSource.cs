using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermServicebusTopicAuthorizationRuleDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_servicebus_topic_authorization_rule.
/// </summary>
public partial class AzurermServicebusTopicAuthorizationRuleDataSource : TerraformDataSource
{
    public AzurermServicebusTopicAuthorizationRuleDataSource(string name) : base("azurerm_servicebus_topic_authorization_rule", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [TerraformProperty("namespace_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? NamespaceName { get; set; }

    /// <summary>
    /// The queue_name attribute.
    /// </summary>
    [TerraformProperty("queue_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? QueueName { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [TerraformProperty("resource_group_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ResourceGroupName { get; set; }

    /// <summary>
    /// The topic_id attribute.
    /// </summary>
    [TerraformProperty("topic_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TopicId { get; set; }

    /// <summary>
    /// The topic_name attribute.
    /// </summary>
    [TerraformProperty("topic_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TopicName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermServicebusTopicAuthorizationRuleDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The listen attribute.
    /// </summary>
    [TerraformProperty("listen")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Listen { get; }

    /// <summary>
    /// The manage attribute.
    /// </summary>
    [TerraformProperty("manage")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Manage { get; }

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    [TerraformProperty("primary_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryConnectionString { get; }

    /// <summary>
    /// The primary_connection_string_alias attribute.
    /// </summary>
    [TerraformProperty("primary_connection_string_alias")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryConnectionStringAlias { get; }

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    [TerraformProperty("primary_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryKey { get; }

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    [TerraformProperty("secondary_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryConnectionString { get; }

    /// <summary>
    /// The secondary_connection_string_alias attribute.
    /// </summary>
    [TerraformProperty("secondary_connection_string_alias")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryConnectionStringAlias { get; }

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    [TerraformProperty("secondary_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryKey { get; }

    /// <summary>
    /// The send attribute.
    /// </summary>
    [TerraformProperty("send")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Send { get; }

}
