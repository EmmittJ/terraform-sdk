using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_adjust_data in AwsBudgetsBudget.
/// Nesting mode: list
/// </summary>
public class AwsBudgetsBudgetAutoAdjustDataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto_adjust_data";

    /// <summary>
    /// The auto_adjust_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoAdjustType is required")]
    public required TerraformValue<string> AutoAdjustType
    {
        get => new TerraformReference<string>(this, "auto_adjust_type");
        set => SetArgument("auto_adjust_type", value);
    }

    /// <summary>
    /// The last_auto_adjust_time attribute.
    /// </summary>
    public TerraformValue<string> LastAutoAdjustTime
    {
        get => new TerraformReference<string>(this, "last_auto_adjust_time");
    }

    /// <summary>
    /// HistoricalOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HistoricalOptions block(s) allowed")]
    public TerraformList<AwsBudgetsBudgetAutoAdjustDataBlockHistoricalOptionsBlock>? HistoricalOptions
    {
        get => GetArgument<TerraformList<AwsBudgetsBudgetAutoAdjustDataBlockHistoricalOptionsBlock>>("historical_options");
        set => SetArgument("historical_options", value);
    }

}

/// <summary>
/// Block type for historical_options in AwsBudgetsBudgetAutoAdjustDataBlock.
/// Nesting mode: list
/// </summary>
public class AwsBudgetsBudgetAutoAdjustDataBlockHistoricalOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "historical_options";

    /// <summary>
    /// The budget_adjustment_period attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BudgetAdjustmentPeriod is required")]
    public required TerraformValue<double> BudgetAdjustmentPeriod
    {
        get => new TerraformReference<double>(this, "budget_adjustment_period");
        set => SetArgument("budget_adjustment_period", value);
    }

    /// <summary>
    /// The lookback_available_periods attribute.
    /// </summary>
    public TerraformValue<double> LookbackAvailablePeriods
    {
        get => new TerraformReference<double>(this, "lookback_available_periods");
    }

}


/// <summary>
/// Block type for cost_filter in AwsBudgetsBudget.
/// Nesting mode: set
/// </summary>
public class AwsBudgetsBudgetCostFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cost_filter";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for cost_types in AwsBudgetsBudget.
/// Nesting mode: list
/// </summary>
public class AwsBudgetsBudgetCostTypesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cost_types";

    /// <summary>
    /// The include_credit attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeCredit
    {
        get => new TerraformReference<bool>(this, "include_credit");
        set => SetArgument("include_credit", value);
    }

    /// <summary>
    /// The include_discount attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeDiscount
    {
        get => new TerraformReference<bool>(this, "include_discount");
        set => SetArgument("include_discount", value);
    }

    /// <summary>
    /// The include_other_subscription attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeOtherSubscription
    {
        get => new TerraformReference<bool>(this, "include_other_subscription");
        set => SetArgument("include_other_subscription", value);
    }

    /// <summary>
    /// The include_recurring attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeRecurring
    {
        get => new TerraformReference<bool>(this, "include_recurring");
        set => SetArgument("include_recurring", value);
    }

    /// <summary>
    /// The include_refund attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeRefund
    {
        get => new TerraformReference<bool>(this, "include_refund");
        set => SetArgument("include_refund", value);
    }

    /// <summary>
    /// The include_subscription attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeSubscription
    {
        get => new TerraformReference<bool>(this, "include_subscription");
        set => SetArgument("include_subscription", value);
    }

    /// <summary>
    /// The include_support attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeSupport
    {
        get => new TerraformReference<bool>(this, "include_support");
        set => SetArgument("include_support", value);
    }

    /// <summary>
    /// The include_tax attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeTax
    {
        get => new TerraformReference<bool>(this, "include_tax");
        set => SetArgument("include_tax", value);
    }

    /// <summary>
    /// The include_upfront attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeUpfront
    {
        get => new TerraformReference<bool>(this, "include_upfront");
        set => SetArgument("include_upfront", value);
    }

    /// <summary>
    /// The use_amortized attribute.
    /// </summary>
    public TerraformValue<bool>? UseAmortized
    {
        get => new TerraformReference<bool>(this, "use_amortized");
        set => SetArgument("use_amortized", value);
    }

    /// <summary>
    /// The use_blended attribute.
    /// </summary>
    public TerraformValue<bool>? UseBlended
    {
        get => new TerraformReference<bool>(this, "use_blended");
        set => SetArgument("use_blended", value);
    }

}


/// <summary>
/// Block type for notification in AwsBudgetsBudget.
/// Nesting mode: set
/// </summary>
public class AwsBudgetsBudgetNotificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notification";

    /// <summary>
    /// The comparison_operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComparisonOperator is required")]
    public required TerraformValue<string> ComparisonOperator
    {
        get => new TerraformReference<string>(this, "comparison_operator");
        set => SetArgument("comparison_operator", value);
    }

    /// <summary>
    /// The notification_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationType is required")]
    public required TerraformValue<string> NotificationType
    {
        get => new TerraformReference<string>(this, "notification_type");
        set => SetArgument("notification_type", value);
    }

    /// <summary>
    /// The subscriber_email_addresses attribute.
    /// </summary>
    public TerraformSet<string>? SubscriberEmailAddresses
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subscriber_email_addresses").ResolveNodes(ctx));
        set => SetArgument("subscriber_email_addresses", value);
    }

    /// <summary>
    /// The subscriber_sns_topic_arns attribute.
    /// </summary>
    public TerraformSet<string>? SubscriberSnsTopicArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subscriber_sns_topic_arns").ResolveNodes(ctx));
        set => SetArgument("subscriber_sns_topic_arns", value);
    }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    public required TerraformValue<double> Threshold
    {
        get => new TerraformReference<double>(this, "threshold");
        set => SetArgument("threshold", value);
    }

    /// <summary>
    /// The threshold_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThresholdType is required")]
    public required TerraformValue<string> ThresholdType
    {
        get => new TerraformReference<string>(this, "threshold_type");
        set => SetArgument("threshold_type", value);
    }

}


/// <summary>
/// Block type for planned_limit in AwsBudgetsBudget.
/// Nesting mode: set
/// </summary>
public class AwsBudgetsBudgetPlannedLimitBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "planned_limit";

    /// <summary>
    /// The amount attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Amount is required")]
    public required TerraformValue<string> Amount
    {
        get => new TerraformReference<string>(this, "amount");
        set => SetArgument("amount", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    public required TerraformValue<string> StartTime
    {
        get => new TerraformReference<string>(this, "start_time");
        set => SetArgument("start_time", value);
    }

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Unit is required")]
    public required TerraformValue<string> Unit
    {
        get => new TerraformReference<string>(this, "unit");
        set => SetArgument("unit", value);
    }

}


/// <summary>
/// Represents a aws_budgets_budget Terraform resource.
/// Manages a aws_budgets_budget resource.
/// </summary>
public partial class AwsBudgetsBudget(string name) : TerraformResource("aws_budgets_budget", name)
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformValue<string> AccountId
    {
        get => new TerraformReference<string>(this, "account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The billing_view_arn attribute.
    /// </summary>
    public TerraformValue<string>? BillingViewArn
    {
        get => new TerraformReference<string>(this, "billing_view_arn");
        set => SetArgument("billing_view_arn", value);
    }

    /// <summary>
    /// The budget_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BudgetType is required")]
    public required TerraformValue<string> BudgetType
    {
        get => new TerraformReference<string>(this, "budget_type");
        set => SetArgument("budget_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The limit_amount attribute.
    /// </summary>
    public TerraformValue<string> LimitAmount
    {
        get => new TerraformReference<string>(this, "limit_amount");
        set => SetArgument("limit_amount", value);
    }

    /// <summary>
    /// The limit_unit attribute.
    /// </summary>
    public TerraformValue<string> LimitUnit
    {
        get => new TerraformReference<string>(this, "limit_unit");
        set => SetArgument("limit_unit", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string> NamePrefix
    {
        get => new TerraformReference<string>(this, "name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The time_period_end attribute.
    /// </summary>
    public TerraformValue<string>? TimePeriodEnd
    {
        get => new TerraformReference<string>(this, "time_period_end");
        set => SetArgument("time_period_end", value);
    }

    /// <summary>
    /// The time_period_start attribute.
    /// </summary>
    public TerraformValue<string> TimePeriodStart
    {
        get => new TerraformReference<string>(this, "time_period_start");
        set => SetArgument("time_period_start", value);
    }

    /// <summary>
    /// The time_unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeUnit is required")]
    public required TerraformValue<string> TimeUnit
    {
        get => new TerraformReference<string>(this, "time_unit");
        set => SetArgument("time_unit", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// AutoAdjustData block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoAdjustData block(s) allowed")]
    public TerraformList<AwsBudgetsBudgetAutoAdjustDataBlock>? AutoAdjustData
    {
        get => GetArgument<TerraformList<AwsBudgetsBudgetAutoAdjustDataBlock>>("auto_adjust_data");
        set => SetArgument("auto_adjust_data", value);
    }

    /// <summary>
    /// CostFilter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsBudgetsBudgetCostFilterBlock>? CostFilter
    {
        get => GetArgument<TerraformSet<AwsBudgetsBudgetCostFilterBlock>>("cost_filter");
        set => SetArgument("cost_filter", value);
    }

    /// <summary>
    /// CostTypes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CostTypes block(s) allowed")]
    public TerraformList<AwsBudgetsBudgetCostTypesBlock>? CostTypes
    {
        get => GetArgument<TerraformList<AwsBudgetsBudgetCostTypesBlock>>("cost_types");
        set => SetArgument("cost_types", value);
    }

    /// <summary>
    /// Notification block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsBudgetsBudgetNotificationBlock>? Notification
    {
        get => GetArgument<TerraformSet<AwsBudgetsBudgetNotificationBlock>>("notification");
        set => SetArgument("notification", value);
    }

    /// <summary>
    /// PlannedLimit block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsBudgetsBudgetPlannedLimitBlock>? PlannedLimit
    {
        get => GetArgument<TerraformSet<AwsBudgetsBudgetPlannedLimitBlock>>("planned_limit");
        set => SetArgument("planned_limit", value);
    }

}
