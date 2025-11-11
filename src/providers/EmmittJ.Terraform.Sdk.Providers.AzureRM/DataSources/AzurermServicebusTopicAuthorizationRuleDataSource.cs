using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermServicebusTopicAuthorizationRuleDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_servicebus_topic_authorization_rule.
/// </summary>
public class AzurermServicebusTopicAuthorizationRuleDataSource : TerraformDataSource
{
    public AzurermServicebusTopicAuthorizationRuleDataSource(string name) : base("azurerm_servicebus_topic_authorization_rule", name)
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
    /// The namespace_name attribute.
    /// </summary>
    [TerraformPropertyName("namespace_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NamespaceName { get; set; }

    /// <summary>
    /// The queue_name attribute.
    /// </summary>
    [TerraformPropertyName("queue_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? QueueName { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [TerraformPropertyName("resource_group_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ResourceGroupName { get; set; }

    /// <summary>
    /// The topic_id attribute.
    /// </summary>
    [TerraformPropertyName("topic_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TopicId { get; set; }

    /// <summary>
    /// The topic_name attribute.
    /// </summary>
    [TerraformPropertyName("topic_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TopicName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermServicebusTopicAuthorizationRuleDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The listen attribute.
    /// </summary>
    [TerraformPropertyName("listen")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Listen => new TerraformReference(this, "listen");

    /// <summary>
    /// The manage attribute.
    /// </summary>
    [TerraformPropertyName("manage")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Manage => new TerraformReference(this, "manage");

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("primary_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryConnectionString => new TerraformReference(this, "primary_connection_string");

    /// <summary>
    /// The primary_connection_string_alias attribute.
    /// </summary>
    [TerraformPropertyName("primary_connection_string_alias")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryConnectionStringAlias => new TerraformReference(this, "primary_connection_string_alias");

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    [TerraformPropertyName("primary_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryKey => new TerraformReference(this, "primary_key");

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("secondary_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryConnectionString => new TerraformReference(this, "secondary_connection_string");

    /// <summary>
    /// The secondary_connection_string_alias attribute.
    /// </summary>
    [TerraformPropertyName("secondary_connection_string_alias")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryConnectionStringAlias => new TerraformReference(this, "secondary_connection_string_alias");

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    [TerraformPropertyName("secondary_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryKey => new TerraformReference(this, "secondary_key");

    /// <summary>
    /// The send attribute.
    /// </summary>
    [TerraformPropertyName("send")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Send => new TerraformReference(this, "send");

}
