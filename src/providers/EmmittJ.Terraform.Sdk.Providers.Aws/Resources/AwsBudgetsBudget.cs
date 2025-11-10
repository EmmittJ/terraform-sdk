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
        set => SetProperty("auto_adjust_type", value);
    }

    /// <summary>
    /// The last_auto_adjust_time attribute.
    /// </summary>
    public TerraformProperty<string>? LastAutoAdjustTime
    {
        set => SetProperty("last_auto_adjust_time", value);
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
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public List<TerraformProperty<string>>? Values
    {
        set => SetProperty("values", value);
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
        set => SetProperty("include_credit", value);
    }

    /// <summary>
    /// The include_discount attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeDiscount
    {
        set => SetProperty("include_discount", value);
    }

    /// <summary>
    /// The include_other_subscription attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeOtherSubscription
    {
        set => SetProperty("include_other_subscription", value);
    }

    /// <summary>
    /// The include_recurring attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeRecurring
    {
        set => SetProperty("include_recurring", value);
    }

    /// <summary>
    /// The include_refund attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeRefund
    {
        set => SetProperty("include_refund", value);
    }

    /// <summary>
    /// The include_subscription attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeSubscription
    {
        set => SetProperty("include_subscription", value);
    }

    /// <summary>
    /// The include_support attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeSupport
    {
        set => SetProperty("include_support", value);
    }

    /// <summary>
    /// The include_tax attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeTax
    {
        set => SetProperty("include_tax", value);
    }

    /// <summary>
    /// The include_upfront attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeUpfront
    {
        set => SetProperty("include_upfront", value);
    }

    /// <summary>
    /// The use_amortized attribute.
    /// </summary>
    public TerraformProperty<bool>? UseAmortized
    {
        set => SetProperty("use_amortized", value);
    }

    /// <summary>
    /// The use_blended attribute.
    /// </summary>
    public TerraformProperty<bool>? UseBlended
    {
        set => SetProperty("use_blended", value);
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
        set => SetProperty("comparison_operator", value);
    }

    /// <summary>
    /// The notification_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationType is required")]
    public required TerraformProperty<string> NotificationType
    {
        set => SetProperty("notification_type", value);
    }

    /// <summary>
    /// The subscriber_email_addresses attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SubscriberEmailAddresses
    {
        set => SetProperty("subscriber_email_addresses", value);
    }

    /// <summary>
    /// The subscriber_sns_topic_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SubscriberSnsTopicArns
    {
        set => SetProperty("subscriber_sns_topic_arns", value);
    }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    public required TerraformProperty<double> Threshold
    {
        set => SetProperty("threshold", value);
    }

    /// <summary>
    /// The threshold_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThresholdType is required")]
    public required TerraformProperty<string> ThresholdType
    {
        set => SetProperty("threshold_type", value);
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
        set => SetProperty("amount", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    public required TerraformProperty<string> StartTime
    {
        set => SetProperty("start_time", value);
    }

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Unit is required")]
    public required TerraformProperty<string> Unit
    {
        set => SetProperty("unit", value);
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
        SetOutput("arn");
        SetOutput("account_id");
        SetOutput("billing_view_arn");
        SetOutput("budget_type");
        SetOutput("id");
        SetOutput("limit_amount");
        SetOutput("limit_unit");
        SetOutput("name");
        SetOutput("name_prefix");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("time_period_end");
        SetOutput("time_period_start");
        SetOutput("time_unit");
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformProperty<string> AccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("account_id");
        set => SetProperty("account_id", value);
    }

    /// <summary>
    /// The billing_view_arn attribute.
    /// </summary>
    public TerraformProperty<string> BillingViewArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("billing_view_arn");
        set => SetProperty("billing_view_arn", value);
    }

    /// <summary>
    /// The budget_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BudgetType is required")]
    public required TerraformProperty<string> BudgetType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("budget_type");
        set => SetProperty("budget_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The limit_amount attribute.
    /// </summary>
    public TerraformProperty<string> LimitAmount
    {
        get => GetRequiredOutput<TerraformProperty<string>>("limit_amount");
        set => SetProperty("limit_amount", value);
    }

    /// <summary>
    /// The limit_unit attribute.
    /// </summary>
    public TerraformProperty<string> LimitUnit
    {
        get => GetRequiredOutput<TerraformProperty<string>>("limit_unit");
        set => SetProperty("limit_unit", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string> NamePrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name_prefix");
        set => SetProperty("name_prefix", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The time_period_end attribute.
    /// </summary>
    public TerraformProperty<string> TimePeriodEnd
    {
        get => GetRequiredOutput<TerraformProperty<string>>("time_period_end");
        set => SetProperty("time_period_end", value);
    }

    /// <summary>
    /// The time_period_start attribute.
    /// </summary>
    public TerraformProperty<string> TimePeriodStart
    {
        get => GetRequiredOutput<TerraformProperty<string>>("time_period_start");
        set => SetProperty("time_period_start", value);
    }

    /// <summary>
    /// The time_unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeUnit is required")]
    public required TerraformProperty<string> TimeUnit
    {
        get => GetRequiredOutput<TerraformProperty<string>>("time_unit");
        set => SetProperty("time_unit", value);
    }

    /// <summary>
    /// Block for auto_adjust_data.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoAdjustData block(s) allowed")]
    public List<AwsBudgetsBudgetAutoAdjustDataBlock>? AutoAdjustData
    {
        set => SetProperty("auto_adjust_data", value);
    }

    /// <summary>
    /// Block for cost_filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsBudgetsBudgetCostFilterBlock>? CostFilter
    {
        set => SetProperty("cost_filter", value);
    }

    /// <summary>
    /// Block for cost_types.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CostTypes block(s) allowed")]
    public List<AwsBudgetsBudgetCostTypesBlock>? CostTypes
    {
        set => SetProperty("cost_types", value);
    }

    /// <summary>
    /// Block for notification.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsBudgetsBudgetNotificationBlock>? Notification
    {
        set => SetProperty("notification", value);
    }

    /// <summary>
    /// Block for planned_limit.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsBudgetsBudgetPlannedLimitBlock>? PlannedLimit
    {
        set => SetProperty("planned_limit", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
