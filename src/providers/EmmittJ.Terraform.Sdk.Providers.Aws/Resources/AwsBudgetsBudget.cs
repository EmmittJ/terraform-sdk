using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_adjust_data in .
/// Nesting mode: list
/// </summary>
public class AwsBudgetsBudgetAutoAdjustDataBlock : ITerraformBlock
{
    /// <summary>
    /// The auto_adjust_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoAdjustType is required")]
    [TerraformPropertyName("auto_adjust_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AutoAdjustType { get; set; }

    /// <summary>
    /// The last_auto_adjust_time attribute.
    /// </summary>
    [TerraformPropertyName("last_auto_adjust_time")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastAutoAdjustTime => new TerraformReferenceProperty<TerraformProperty<string>>("", "last_auto_adjust_time");

}

/// <summary>
/// Block type for cost_filter in .
/// Nesting mode: set
/// </summary>
public class AwsBudgetsBudgetCostFilterBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? Values { get; set; }

}

/// <summary>
/// Block type for cost_types in .
/// Nesting mode: list
/// </summary>
public class AwsBudgetsBudgetCostTypesBlock : ITerraformBlock
{
    /// <summary>
    /// The include_credit attribute.
    /// </summary>
    [TerraformPropertyName("include_credit")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeCredit { get; set; }

    /// <summary>
    /// The include_discount attribute.
    /// </summary>
    [TerraformPropertyName("include_discount")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeDiscount { get; set; }

    /// <summary>
    /// The include_other_subscription attribute.
    /// </summary>
    [TerraformPropertyName("include_other_subscription")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeOtherSubscription { get; set; }

    /// <summary>
    /// The include_recurring attribute.
    /// </summary>
    [TerraformPropertyName("include_recurring")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeRecurring { get; set; }

    /// <summary>
    /// The include_refund attribute.
    /// </summary>
    [TerraformPropertyName("include_refund")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeRefund { get; set; }

    /// <summary>
    /// The include_subscription attribute.
    /// </summary>
    [TerraformPropertyName("include_subscription")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeSubscription { get; set; }

    /// <summary>
    /// The include_support attribute.
    /// </summary>
    [TerraformPropertyName("include_support")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeSupport { get; set; }

    /// <summary>
    /// The include_tax attribute.
    /// </summary>
    [TerraformPropertyName("include_tax")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeTax { get; set; }

    /// <summary>
    /// The include_upfront attribute.
    /// </summary>
    [TerraformPropertyName("include_upfront")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeUpfront { get; set; }

    /// <summary>
    /// The use_amortized attribute.
    /// </summary>
    [TerraformPropertyName("use_amortized")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UseAmortized { get; set; }

    /// <summary>
    /// The use_blended attribute.
    /// </summary>
    [TerraformPropertyName("use_blended")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UseBlended { get; set; }

}

/// <summary>
/// Block type for notification in .
/// Nesting mode: set
/// </summary>
public class AwsBudgetsBudgetNotificationBlock : ITerraformBlock
{
    /// <summary>
    /// The comparison_operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComparisonOperator is required")]
    [TerraformPropertyName("comparison_operator")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ComparisonOperator { get; set; }

    /// <summary>
    /// The notification_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationType is required")]
    [TerraformPropertyName("notification_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NotificationType { get; set; }

    /// <summary>
    /// The subscriber_email_addresses attribute.
    /// </summary>
    [TerraformPropertyName("subscriber_email_addresses")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SubscriberEmailAddresses { get; set; }

    /// <summary>
    /// The subscriber_sns_topic_arns attribute.
    /// </summary>
    [TerraformPropertyName("subscriber_sns_topic_arns")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SubscriberSnsTopicArns { get; set; }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    [TerraformPropertyName("threshold")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Threshold { get; set; }

    /// <summary>
    /// The threshold_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThresholdType is required")]
    [TerraformPropertyName("threshold_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ThresholdType { get; set; }

}

/// <summary>
/// Block type for planned_limit in .
/// Nesting mode: set
/// </summary>
public class AwsBudgetsBudgetPlannedLimitBlock : ITerraformBlock
{
    /// <summary>
    /// The amount attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Amount is required")]
    [TerraformPropertyName("amount")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Amount { get; set; }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    [TerraformPropertyName("start_time")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StartTime { get; set; }

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Unit is required")]
    [TerraformPropertyName("unit")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Unit { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AccountId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "account_id");

    /// <summary>
    /// The billing_view_arn attribute.
    /// </summary>
    [TerraformPropertyName("billing_view_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BillingViewArn { get; set; }

    /// <summary>
    /// The budget_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BudgetType is required")]
    [TerraformPropertyName("budget_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> BudgetType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The limit_amount attribute.
    /// </summary>
    [TerraformPropertyName("limit_amount")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LimitAmount { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "limit_amount");

    /// <summary>
    /// The limit_unit attribute.
    /// </summary>
    [TerraformPropertyName("limit_unit")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LimitUnit { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "limit_unit");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NamePrefix { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name_prefix");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The time_period_end attribute.
    /// </summary>
    [TerraformPropertyName("time_period_end")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TimePeriodEnd { get; set; }

    /// <summary>
    /// The time_period_start attribute.
    /// </summary>
    [TerraformPropertyName("time_period_start")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TimePeriodStart { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_period_start");

    /// <summary>
    /// The time_unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeUnit is required")]
    [TerraformPropertyName("time_unit")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TimeUnit { get; set; }

    /// <summary>
    /// Block for auto_adjust_data.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoAdjustData block(s) allowed")]
    [TerraformPropertyName("auto_adjust_data")]
    public TerraformList<TerraformBlock<AwsBudgetsBudgetAutoAdjustDataBlock>>? AutoAdjustData { get; set; } = new();

    /// <summary>
    /// Block for cost_filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("cost_filter")]
    public TerraformSet<TerraformBlock<AwsBudgetsBudgetCostFilterBlock>>? CostFilter { get; set; } = new();

    /// <summary>
    /// Block for cost_types.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CostTypes block(s) allowed")]
    [TerraformPropertyName("cost_types")]
    public TerraformList<TerraformBlock<AwsBudgetsBudgetCostTypesBlock>>? CostTypes { get; set; } = new();

    /// <summary>
    /// Block for notification.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("notification")]
    public TerraformSet<TerraformBlock<AwsBudgetsBudgetNotificationBlock>>? Notification { get; set; } = new();

    /// <summary>
    /// Block for planned_limit.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("planned_limit")]
    public TerraformSet<TerraformBlock<AwsBudgetsBudgetPlannedLimitBlock>>? PlannedLimit { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
