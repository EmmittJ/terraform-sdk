using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for filter in .
/// Nesting mode: list
/// </summary>
public class AzurermConsumptionBudgetSubscriptionFilterBlock
{
}

/// <summary>
/// Block type for notification in .
/// Nesting mode: set
/// </summary>
public class AzurermConsumptionBudgetSubscriptionNotificationBlock
{
    /// <summary>
    /// The contact_emails attribute.
    /// </summary>
    [TerraformPropertyName("contact_emails")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ContactEmails { get; set; }

    /// <summary>
    /// The contact_groups attribute.
    /// </summary>
    [TerraformPropertyName("contact_groups")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ContactGroups { get; set; }

    /// <summary>
    /// The contact_roles attribute.
    /// </summary>
    [TerraformPropertyName("contact_roles")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ContactRoles { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operator is required")]
    [TerraformPropertyName("operator")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Operator { get; set; }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    [TerraformPropertyName("threshold")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Threshold { get; set; }

    /// <summary>
    /// The threshold_type attribute.
    /// </summary>
    [TerraformPropertyName("threshold_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ThresholdType { get; set; }

}

/// <summary>
/// Block type for time_period in .
/// Nesting mode: list
/// </summary>
public class AzurermConsumptionBudgetSubscriptionTimePeriodBlock
{
    /// <summary>
    /// The end_date attribute.
    /// </summary>
    [TerraformPropertyName("end_date")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> EndDate { get; set; } = default!;

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartDate is required")]
    [TerraformPropertyName("start_date")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StartDate { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermConsumptionBudgetSubscriptionTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_consumption_budget_subscription resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermConsumptionBudgetSubscription : TerraformResource
{
    public AzurermConsumptionBudgetSubscription(string name) : base("azurerm_consumption_budget_subscription", name)
    {
    }

    /// <summary>
    /// The amount attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Amount is required")]
    [TerraformPropertyName("amount")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Amount { get; set; }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Etag { get; set; } = default!;

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
    /// The subscription_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionId is required")]
    [TerraformPropertyName("subscription_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SubscriptionId { get; set; }

    /// <summary>
    /// The time_grain attribute.
    /// </summary>
    [TerraformPropertyName("time_grain")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TimeGrain { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    [TerraformPropertyName("filter")]
    public TerraformList<TerraformBlock<AzurermConsumptionBudgetSubscriptionFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for notification.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Notification is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Notification block(s) required")]
    [TerraformPropertyName("notification")]
    public TerraformSet<TerraformBlock<AzurermConsumptionBudgetSubscriptionNotificationBlock>>? Notification { get; set; }

    /// <summary>
    /// Block for time_period.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimePeriod is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TimePeriod block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimePeriod block(s) allowed")]
    [TerraformPropertyName("time_period")]
    public TerraformList<TerraformBlock<AzurermConsumptionBudgetSubscriptionTimePeriodBlock>>? TimePeriod { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermConsumptionBudgetSubscriptionTimeoutsBlock>? Timeouts { get; set; }

}
