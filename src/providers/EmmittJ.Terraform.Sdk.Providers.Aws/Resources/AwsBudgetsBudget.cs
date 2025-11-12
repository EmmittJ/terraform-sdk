using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_adjust_data in .
/// Nesting mode: list
/// </summary>
public partial class AwsBudgetsBudgetAutoAdjustDataBlock() : TerraformBlock("auto_adjust_data")
{
    /// <summary>
    /// The auto_adjust_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoAdjustType is required")]
    [TerraformProperty("auto_adjust_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AutoAdjustType { get; set; }


}

/// <summary>
/// Block type for cost_filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsBudgetsBudgetCostFilterBlock() : TerraformBlock("cost_filter")
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? Values { get; set; }

}

/// <summary>
/// Block type for cost_types in .
/// Nesting mode: list
/// </summary>
public partial class AwsBudgetsBudgetCostTypesBlock() : TerraformBlock("cost_types")
{
    /// <summary>
    /// The include_credit attribute.
    /// </summary>
    [TerraformProperty("include_credit")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludeCredit { get; set; }

    /// <summary>
    /// The include_discount attribute.
    /// </summary>
    [TerraformProperty("include_discount")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludeDiscount { get; set; }

    /// <summary>
    /// The include_other_subscription attribute.
    /// </summary>
    [TerraformProperty("include_other_subscription")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludeOtherSubscription { get; set; }

    /// <summary>
    /// The include_recurring attribute.
    /// </summary>
    [TerraformProperty("include_recurring")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludeRecurring { get; set; }

    /// <summary>
    /// The include_refund attribute.
    /// </summary>
    [TerraformProperty("include_refund")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludeRefund { get; set; }

    /// <summary>
    /// The include_subscription attribute.
    /// </summary>
    [TerraformProperty("include_subscription")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludeSubscription { get; set; }

    /// <summary>
    /// The include_support attribute.
    /// </summary>
    [TerraformProperty("include_support")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludeSupport { get; set; }

    /// <summary>
    /// The include_tax attribute.
    /// </summary>
    [TerraformProperty("include_tax")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludeTax { get; set; }

    /// <summary>
    /// The include_upfront attribute.
    /// </summary>
    [TerraformProperty("include_upfront")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludeUpfront { get; set; }

    /// <summary>
    /// The use_amortized attribute.
    /// </summary>
    [TerraformProperty("use_amortized")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UseAmortized { get; set; }

    /// <summary>
    /// The use_blended attribute.
    /// </summary>
    [TerraformProperty("use_blended")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UseBlended { get; set; }

}

/// <summary>
/// Block type for notification in .
/// Nesting mode: set
/// </summary>
public partial class AwsBudgetsBudgetNotificationBlock() : TerraformBlock("notification")
{
    /// <summary>
    /// The comparison_operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComparisonOperator is required")]
    [TerraformProperty("comparison_operator")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ComparisonOperator { get; set; }

    /// <summary>
    /// The notification_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationType is required")]
    [TerraformProperty("notification_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NotificationType { get; set; }

    /// <summary>
    /// The subscriber_email_addresses attribute.
    /// </summary>
    [TerraformProperty("subscriber_email_addresses")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SubscriberEmailAddresses { get; set; }

    /// <summary>
    /// The subscriber_sns_topic_arns attribute.
    /// </summary>
    [TerraformProperty("subscriber_sns_topic_arns")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SubscriberSnsTopicArns { get; set; }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    [TerraformProperty("threshold")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Threshold { get; set; }

    /// <summary>
    /// The threshold_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThresholdType is required")]
    [TerraformProperty("threshold_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ThresholdType { get; set; }

}

/// <summary>
/// Block type for planned_limit in .
/// Nesting mode: set
/// </summary>
public partial class AwsBudgetsBudgetPlannedLimitBlock() : TerraformBlock("planned_limit")
{
    /// <summary>
    /// The amount attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Amount is required")]
    [TerraformProperty("amount")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Amount { get; set; }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    [TerraformProperty("start_time")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StartTime { get; set; }

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Unit is required")]
    [TerraformProperty("unit")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Unit { get; set; }

}

/// <summary>
/// Manages a aws_budgets_budget resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsBudgetsBudget : TerraformResource
{
    public AwsBudgetsBudget(string name) : base("aws_budgets_budget", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformProperty("account_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AccountId { get; set; }

    /// <summary>
    /// The billing_view_arn attribute.
    /// </summary>
    [TerraformProperty("billing_view_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BillingViewArn { get; set; }

    /// <summary>
    /// The budget_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BudgetType is required")]
    [TerraformProperty("budget_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BudgetType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The limit_amount attribute.
    /// </summary>
    [TerraformProperty("limit_amount")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LimitAmount { get; set; }

    /// <summary>
    /// The limit_unit attribute.
    /// </summary>
    [TerraformProperty("limit_unit")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LimitUnit { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformProperty("name_prefix")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NamePrefix { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The time_period_end attribute.
    /// </summary>
    [TerraformProperty("time_period_end")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TimePeriodEnd { get; set; }

    /// <summary>
    /// The time_period_start attribute.
    /// </summary>
    [TerraformProperty("time_period_start")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TimePeriodStart { get; set; }

    /// <summary>
    /// The time_unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeUnit is required")]
    [TerraformProperty("time_unit")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TimeUnit { get; set; }

    /// <summary>
    /// Block for auto_adjust_data.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoAdjustData block(s) allowed")]
    [TerraformProperty("auto_adjust_data")]
    public TerraformList<AwsBudgetsBudgetAutoAdjustDataBlock> AutoAdjustData { get; set; } = new();

    /// <summary>
    /// Block for cost_filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("cost_filter")]
    public TerraformSet<AwsBudgetsBudgetCostFilterBlock> CostFilter { get; set; } = new();

    /// <summary>
    /// Block for cost_types.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CostTypes block(s) allowed")]
    [TerraformProperty("cost_types")]
    public TerraformList<AwsBudgetsBudgetCostTypesBlock> CostTypes { get; set; } = new();

    /// <summary>
    /// Block for notification.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("notification")]
    public TerraformSet<AwsBudgetsBudgetNotificationBlock> Notification { get; set; } = new();

    /// <summary>
    /// Block for planned_limit.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("planned_limit")]
    public TerraformSet<AwsBudgetsBudgetPlannedLimitBlock> PlannedLimit { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
