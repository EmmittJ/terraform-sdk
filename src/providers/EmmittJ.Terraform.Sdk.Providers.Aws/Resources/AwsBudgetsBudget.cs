using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_adjust_data in .
/// Nesting mode: list
/// </summary>
public class AwsBudgetsBudgetAutoAdjustDataBlock
{
    /// <summary>
    /// The auto_adjust_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoAdjustType is required")]
    [TerraformPropertyName("auto_adjust_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AutoAdjustType { get; set; }


}

/// <summary>
/// Block type for cost_filter in .
/// Nesting mode: set
/// </summary>
public class AwsBudgetsBudgetCostFilterBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? Values { get; set; }

}

/// <summary>
/// Block type for cost_types in .
/// Nesting mode: list
/// </summary>
public class AwsBudgetsBudgetCostTypesBlock
{
    /// <summary>
    /// The include_credit attribute.
    /// </summary>
    [TerraformPropertyName("include_credit")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludeCredit { get; set; }

    /// <summary>
    /// The include_discount attribute.
    /// </summary>
    [TerraformPropertyName("include_discount")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludeDiscount { get; set; }

    /// <summary>
    /// The include_other_subscription attribute.
    /// </summary>
    [TerraformPropertyName("include_other_subscription")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludeOtherSubscription { get; set; }

    /// <summary>
    /// The include_recurring attribute.
    /// </summary>
    [TerraformPropertyName("include_recurring")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludeRecurring { get; set; }

    /// <summary>
    /// The include_refund attribute.
    /// </summary>
    [TerraformPropertyName("include_refund")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludeRefund { get; set; }

    /// <summary>
    /// The include_subscription attribute.
    /// </summary>
    [TerraformPropertyName("include_subscription")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludeSubscription { get; set; }

    /// <summary>
    /// The include_support attribute.
    /// </summary>
    [TerraformPropertyName("include_support")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludeSupport { get; set; }

    /// <summary>
    /// The include_tax attribute.
    /// </summary>
    [TerraformPropertyName("include_tax")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludeTax { get; set; }

    /// <summary>
    /// The include_upfront attribute.
    /// </summary>
    [TerraformPropertyName("include_upfront")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludeUpfront { get; set; }

    /// <summary>
    /// The use_amortized attribute.
    /// </summary>
    [TerraformPropertyName("use_amortized")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? UseAmortized { get; set; }

    /// <summary>
    /// The use_blended attribute.
    /// </summary>
    [TerraformPropertyName("use_blended")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? UseBlended { get; set; }

}

/// <summary>
/// Block type for notification in .
/// Nesting mode: set
/// </summary>
public class AwsBudgetsBudgetNotificationBlock
{
    /// <summary>
    /// The comparison_operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComparisonOperator is required")]
    [TerraformPropertyName("comparison_operator")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ComparisonOperator { get; set; }

    /// <summary>
    /// The notification_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationType is required")]
    [TerraformPropertyName("notification_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> NotificationType { get; set; }

    /// <summary>
    /// The subscriber_email_addresses attribute.
    /// </summary>
    [TerraformPropertyName("subscriber_email_addresses")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? SubscriberEmailAddresses { get; set; }

    /// <summary>
    /// The subscriber_sns_topic_arns attribute.
    /// </summary>
    [TerraformPropertyName("subscriber_sns_topic_arns")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? SubscriberSnsTopicArns { get; set; }

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThresholdType is required")]
    [TerraformPropertyName("threshold_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ThresholdType { get; set; }

}

/// <summary>
/// Block type for planned_limit in .
/// Nesting mode: set
/// </summary>
public class AwsBudgetsBudgetPlannedLimitBlock
{
    /// <summary>
    /// The amount attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Amount is required")]
    [TerraformPropertyName("amount")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Amount { get; set; }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    [TerraformPropertyName("start_time")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StartTime { get; set; }

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Unit is required")]
    [TerraformPropertyName("unit")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Unit { get; set; }

}

/// <summary>
/// Manages a aws_budgets_budget resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsBudgetsBudget : TerraformResource
{
    public AwsBudgetsBudget(string name) : base("aws_budgets_budget", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformPropertyName("account_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AccountId { get; set; } = default!;

    /// <summary>
    /// The billing_view_arn attribute.
    /// </summary>
    [TerraformPropertyName("billing_view_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BillingViewArn { get; set; }

    /// <summary>
    /// The budget_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BudgetType is required")]
    [TerraformPropertyName("budget_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> BudgetType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The limit_amount attribute.
    /// </summary>
    [TerraformPropertyName("limit_amount")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> LimitAmount { get; set; } = default!;

    /// <summary>
    /// The limit_unit attribute.
    /// </summary>
    [TerraformPropertyName("limit_unit")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> LimitUnit { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NamePrefix { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The time_period_end attribute.
    /// </summary>
    [TerraformPropertyName("time_period_end")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TimePeriodEnd { get; set; }

    /// <summary>
    /// The time_period_start attribute.
    /// </summary>
    [TerraformPropertyName("time_period_start")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> TimePeriodStart { get; set; } = default!;

    /// <summary>
    /// The time_unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeUnit is required")]
    [TerraformPropertyName("time_unit")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TimeUnit { get; set; }

    /// <summary>
    /// Block for auto_adjust_data.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoAdjustData block(s) allowed")]
    [TerraformPropertyName("auto_adjust_data")]
    public TerraformList<TerraformBlock<AwsBudgetsBudgetAutoAdjustDataBlock>>? AutoAdjustData { get; set; }

    /// <summary>
    /// Block for cost_filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("cost_filter")]
    public TerraformSet<TerraformBlock<AwsBudgetsBudgetCostFilterBlock>>? CostFilter { get; set; }

    /// <summary>
    /// Block for cost_types.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CostTypes block(s) allowed")]
    [TerraformPropertyName("cost_types")]
    public TerraformList<TerraformBlock<AwsBudgetsBudgetCostTypesBlock>>? CostTypes { get; set; }

    /// <summary>
    /// Block for notification.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("notification")]
    public TerraformSet<TerraformBlock<AwsBudgetsBudgetNotificationBlock>>? Notification { get; set; }

    /// <summary>
    /// Block for planned_limit.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("planned_limit")]
    public TerraformSet<TerraformBlock<AwsBudgetsBudgetPlannedLimitBlock>>? PlannedLimit { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
