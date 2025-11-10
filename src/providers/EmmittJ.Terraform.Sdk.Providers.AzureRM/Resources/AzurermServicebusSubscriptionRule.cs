using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for correlation_filter in .
/// Nesting mode: list
/// </summary>
public class AzurermServicebusSubscriptionRuleCorrelationFilterBlock : ITerraformBlock
{
    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [TerraformPropertyName("content_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ContentType { get; set; }

    /// <summary>
    /// The correlation_id attribute.
    /// </summary>
    [TerraformPropertyName("correlation_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CorrelationId { get; set; }

    /// <summary>
    /// The label attribute.
    /// </summary>
    [TerraformPropertyName("label")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Label { get; set; }

    /// <summary>
    /// The message_id attribute.
    /// </summary>
    [TerraformPropertyName("message_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MessageId { get; set; }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    [TerraformPropertyName("properties")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Properties { get; set; }

    /// <summary>
    /// The reply_to attribute.
    /// </summary>
    [TerraformPropertyName("reply_to")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ReplyTo { get; set; }

    /// <summary>
    /// The reply_to_session_id attribute.
    /// </summary>
    [TerraformPropertyName("reply_to_session_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ReplyToSessionId { get; set; }

    /// <summary>
    /// The session_id attribute.
    /// </summary>
    [TerraformPropertyName("session_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SessionId { get; set; }

    /// <summary>
    /// The to attribute.
    /// </summary>
    [TerraformPropertyName("to")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? To { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermServicebusSubscriptionRuleTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_servicebus_subscription_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermServicebusSubscriptionRule : TerraformResource
{
    public AzurermServicebusSubscriptionRule(string name) : base("azurerm_servicebus_subscription_rule", name)
    {
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    [TerraformPropertyName("action")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Action { get; set; }

    /// <summary>
    /// The filter_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterType is required")]
    [TerraformPropertyName("filter_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FilterType { get; set; }

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
    /// The sql_filter attribute.
    /// </summary>
    [TerraformPropertyName("sql_filter")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SqlFilter { get; set; }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionId is required")]
    [TerraformPropertyName("subscription_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SubscriptionId { get; set; }

    /// <summary>
    /// Block for correlation_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorrelationFilter block(s) allowed")]
    [TerraformPropertyName("correlation_filter")]
    public TerraformList<TerraformBlock<AzurermServicebusSubscriptionRuleCorrelationFilterBlock>>? CorrelationFilter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermServicebusSubscriptionRuleTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The sql_filter_compatibility_level attribute.
    /// </summary>
    [TerraformPropertyName("sql_filter_compatibility_level")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> SqlFilterCompatibilityLevel => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "sql_filter_compatibility_level");

}
