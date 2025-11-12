using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for correlation_filter in .
/// Nesting mode: list
/// </summary>
public partial class AzurermServicebusSubscriptionRuleCorrelationFilterBlock() : TerraformBlock("correlation_filter")
{
    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [TerraformProperty("content_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContentType { get; set; }

    /// <summary>
    /// The correlation_id attribute.
    /// </summary>
    [TerraformProperty("correlation_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CorrelationId { get; set; }

    /// <summary>
    /// The label attribute.
    /// </summary>
    [TerraformProperty("label")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Label { get; set; }

    /// <summary>
    /// The message_id attribute.
    /// </summary>
    [TerraformProperty("message_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MessageId { get; set; }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    [TerraformProperty("properties")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Properties { get; set; }

    /// <summary>
    /// The reply_to attribute.
    /// </summary>
    [TerraformProperty("reply_to")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ReplyTo { get; set; }

    /// <summary>
    /// The reply_to_session_id attribute.
    /// </summary>
    [TerraformProperty("reply_to_session_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ReplyToSessionId { get; set; }

    /// <summary>
    /// The session_id attribute.
    /// </summary>
    [TerraformProperty("session_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SessionId { get; set; }

    /// <summary>
    /// The to attribute.
    /// </summary>
    [TerraformProperty("to")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? To { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermServicebusSubscriptionRuleTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_servicebus_subscription_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermServicebusSubscriptionRule : TerraformResource
{
    public AzurermServicebusSubscriptionRule(string name) : base("azurerm_servicebus_subscription_rule", name)
    {
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    [TerraformProperty("action")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Action { get; set; }

    /// <summary>
    /// The filter_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterType is required")]
    [TerraformProperty("filter_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FilterType { get; set; }

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
    /// The sql_filter attribute.
    /// </summary>
    [TerraformProperty("sql_filter")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SqlFilter { get; set; }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionId is required")]
    [TerraformProperty("subscription_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SubscriptionId { get; set; }

    /// <summary>
    /// Block for correlation_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorrelationFilter block(s) allowed")]
    [TerraformProperty("correlation_filter")]
    public TerraformList<AzurermServicebusSubscriptionRuleCorrelationFilterBlock> CorrelationFilter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermServicebusSubscriptionRuleTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The sql_filter_compatibility_level attribute.
    /// </summary>
    [TerraformProperty("sql_filter_compatibility_level")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> SqlFilterCompatibilityLevel { get; }

}
