using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_adjust_data in .
/// Nesting mode: list
/// </summary>
public class AwsBudgetsBudgetAutoAdjustDataBlock : TerraformBlock
{
    /// <summary>
    /// The auto_adjust_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoAdjustType is required")]
    public required TerraformProperty<string> AutoAdjustType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("auto_adjust_type");
        set => WithProperty("auto_adjust_type", value);
    }

    /// <summary>
    /// The last_auto_adjust_time attribute.
    /// </summary>
    public TerraformProperty<string>? LastAutoAdjustTime
    {
        get => GetProperty<TerraformProperty<string>>("last_auto_adjust_time");
        set => WithProperty("last_auto_adjust_time", value);
    }

}

/// <summary>
/// Block type for cost_filter in .
/// Nesting mode: set
/// </summary>
public class AwsBudgetsBudgetCostFilterBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public List<TerraformProperty<string>>? Values
    {
        get => GetProperty<List<TerraformProperty<string>>>("values");
        set => WithProperty("values", value);
    }

}

/// <summary>
/// Block type for cost_types in .
/// Nesting mode: list
/// </summary>
public class AwsBudgetsBudgetCostTypesBlock : TerraformBlock
{
    /// <summary>
    /// The include_credit attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeCredit
    {
        get => GetProperty<TerraformProperty<bool>>("include_credit");
        set => WithProperty("include_credit", value);
    }

    /// <summary>
    /// The include_discount attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeDiscount
    {
        get => GetProperty<TerraformProperty<bool>>("include_discount");
        set => WithProperty("include_discount", value);
    }

    /// <summary>
    /// The include_other_subscription attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeOtherSubscription
    {
        get => GetProperty<TerraformProperty<bool>>("include_other_subscription");
        set => WithProperty("include_other_subscription", value);
    }

    /// <summary>
    /// The include_recurring attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeRecurring
    {
        get => GetProperty<TerraformProperty<bool>>("include_recurring");
        set => WithProperty("include_recurring", value);
    }

    /// <summary>
    /// The include_refund attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeRefund
    {
        get => GetProperty<TerraformProperty<bool>>("include_refund");
        set => WithProperty("include_refund", value);
    }

    /// <summary>
    /// The include_subscription attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeSubscription
    {
        get => GetProperty<TerraformProperty<bool>>("include_subscription");
        set => WithProperty("include_subscription", value);
    }

    /// <summary>
    /// The include_support attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeSupport
    {
        get => GetProperty<TerraformProperty<bool>>("include_support");
        set => WithProperty("include_support", value);
    }

    /// <summary>
    /// The include_tax attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeTax
    {
        get => GetProperty<TerraformProperty<bool>>("include_tax");
        set => WithProperty("include_tax", value);
    }

    /// <summary>
    /// The include_upfront attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeUpfront
    {
        get => GetProperty<TerraformProperty<bool>>("include_upfront");
        set => WithProperty("include_upfront", value);
    }

    /// <summary>
    /// The use_amortized attribute.
    /// </summary>
    public TerraformProperty<bool>? UseAmortized
    {
        get => GetProperty<TerraformProperty<bool>>("use_amortized");
        set => WithProperty("use_amortized", value);
    }

    /// <summary>
    /// The use_blended attribute.
    /// </summary>
    public TerraformProperty<bool>? UseBlended
    {
        get => GetProperty<TerraformProperty<bool>>("use_blended");
        set => WithProperty("use_blended", value);
    }

}

/// <summary>
/// Block type for notification in .
/// Nesting mode: set
/// </summary>
public class AwsBudgetsBudgetNotificationBlock : TerraformBlock
{
    /// <summary>
    /// The comparison_operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComparisonOperator is required")]
    public required TerraformProperty<string> ComparisonOperator
    {
        get => GetRequiredProperty<TerraformProperty<string>>("comparison_operator");
        set => WithProperty("comparison_operator", value);
    }

    /// <summary>
    /// The notification_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationType is required")]
    public required TerraformProperty<string> NotificationType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("notification_type");
        set => WithProperty("notification_type", value);
    }

    /// <summary>
    /// The subscriber_email_addresses attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SubscriberEmailAddresses
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subscriber_email_addresses");
        set => WithProperty("subscriber_email_addresses", value);
    }

    /// <summary>
    /// The subscriber_sns_topic_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SubscriberSnsTopicArns
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subscriber_sns_topic_arns");
        set => WithProperty("subscriber_sns_topic_arns", value);
    }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    public required TerraformProperty<double> Threshold
    {
        get => GetRequiredProperty<TerraformProperty<double>>("threshold");
        set => WithProperty("threshold", value);
    }

    /// <summary>
    /// The threshold_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThresholdType is required")]
    public required TerraformProperty<string> ThresholdType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("threshold_type");
        set => WithProperty("threshold_type", value);
    }

}

/// <summary>
/// Block type for planned_limit in .
/// Nesting mode: set
/// </summary>
public class AwsBudgetsBudgetPlannedLimitBlock : TerraformBlock
{
    /// <summary>
    /// The amount attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Amount is required")]
    public required TerraformProperty<string> Amount
    {
        get => GetRequiredProperty<TerraformProperty<string>>("amount");
        set => WithProperty("amount", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    public required TerraformProperty<string> StartTime
    {
        get => GetRequiredProperty<TerraformProperty<string>>("start_time");
        set => WithProperty("start_time", value);
    }

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Unit is required")]
    public required TerraformProperty<string> Unit
    {
        get => GetRequiredProperty<TerraformProperty<string>>("unit");
        set => WithProperty("unit", value);
    }

}

/// <summary>
/// Manages a aws_budgets_budget resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsBudgetsBudget : TerraformResource
{
    public AwsBudgetsBudget(string name) : base("aws_budgets_budget", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformProperty<string>? AccountId
    {
        get => GetProperty<TerraformProperty<string>>("account_id");
        set => this.WithProperty("account_id", value);
    }

    /// <summary>
    /// The billing_view_arn attribute.
    /// </summary>
    public TerraformProperty<string>? BillingViewArn
    {
        get => GetProperty<TerraformProperty<string>>("billing_view_arn");
        set => this.WithProperty("billing_view_arn", value);
    }

    /// <summary>
    /// The budget_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BudgetType is required")]
    public required TerraformProperty<string> BudgetType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("budget_type");
        set => this.WithProperty("budget_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The limit_amount attribute.
    /// </summary>
    public TerraformProperty<string>? LimitAmount
    {
        get => GetProperty<TerraformProperty<string>>("limit_amount");
        set => this.WithProperty("limit_amount", value);
    }

    /// <summary>
    /// The limit_unit attribute.
    /// </summary>
    public TerraformProperty<string>? LimitUnit
    {
        get => GetProperty<TerraformProperty<string>>("limit_unit");
        set => this.WithProperty("limit_unit", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The time_period_end attribute.
    /// </summary>
    public TerraformProperty<string>? TimePeriodEnd
    {
        get => GetProperty<TerraformProperty<string>>("time_period_end");
        set => this.WithProperty("time_period_end", value);
    }

    /// <summary>
    /// The time_period_start attribute.
    /// </summary>
    public TerraformProperty<string>? TimePeriodStart
    {
        get => GetProperty<TerraformProperty<string>>("time_period_start");
        set => this.WithProperty("time_period_start", value);
    }

    /// <summary>
    /// The time_unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeUnit is required")]
    public required TerraformProperty<string> TimeUnit
    {
        get => GetRequiredProperty<TerraformProperty<string>>("time_unit");
        set => this.WithProperty("time_unit", value);
    }

    /// <summary>
    /// Block for auto_adjust_data.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoAdjustData block(s) allowed")]
    public List<AwsBudgetsBudgetAutoAdjustDataBlock>? AutoAdjustData
    {
        get => GetProperty<List<AwsBudgetsBudgetAutoAdjustDataBlock>>("auto_adjust_data");
        set => this.WithProperty("auto_adjust_data", value);
    }

    /// <summary>
    /// Block for cost_filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsBudgetsBudgetCostFilterBlock>? CostFilter
    {
        get => GetProperty<HashSet<AwsBudgetsBudgetCostFilterBlock>>("cost_filter");
        set => this.WithProperty("cost_filter", value);
    }

    /// <summary>
    /// Block for cost_types.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CostTypes block(s) allowed")]
    public List<AwsBudgetsBudgetCostTypesBlock>? CostTypes
    {
        get => GetProperty<List<AwsBudgetsBudgetCostTypesBlock>>("cost_types");
        set => this.WithProperty("cost_types", value);
    }

    /// <summary>
    /// Block for notification.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsBudgetsBudgetNotificationBlock>? Notification
    {
        get => GetProperty<HashSet<AwsBudgetsBudgetNotificationBlock>>("notification");
        set => this.WithProperty("notification", value);
    }

    /// <summary>
    /// Block for planned_limit.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsBudgetsBudgetPlannedLimitBlock>? PlannedLimit
    {
        get => GetProperty<HashSet<AwsBudgetsBudgetPlannedLimitBlock>>("planned_limit");
        set => this.WithProperty("planned_limit", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
