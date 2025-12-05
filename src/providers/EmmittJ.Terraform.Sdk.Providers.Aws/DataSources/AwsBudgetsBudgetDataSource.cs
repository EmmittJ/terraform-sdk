using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_budgets_budget Terraform data source.
/// Retrieves information about a aws_budgets_budget.
/// </summary>
public partial class AwsBudgetsBudgetDataSource(string name) : TerraformDataSource("aws_budgets_budget", name)
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformValue<string> AccountId
    {
        get => GetArgument<TerraformValue<string>>("account_id") ?? CreateReference("account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string>? NamePrefix
    {
        get => GetArgument<TerraformValue<string>>("name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The auto_adjust_data attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AutoAdjustData
        => CreateReference("auto_adjust_data");

    /// <summary>
    /// The billing_view_arn attribute.
    /// </summary>
    public TerraformValue<string> BillingViewArn
        => CreateReference("billing_view_arn");

    /// <summary>
    /// The budget_exceeded attribute.
    /// </summary>
    public TerraformValue<bool> BudgetExceeded
        => CreateReference("budget_exceeded");

    /// <summary>
    /// The budget_limit attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> BudgetLimit
        => CreateReference("budget_limit");

    /// <summary>
    /// The budget_type attribute.
    /// </summary>
    public TerraformValue<string> BudgetType
        => CreateReference("budget_type");

    /// <summary>
    /// The calculated_spend attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CalculatedSpend
        => CreateReference("calculated_spend");

    /// <summary>
    /// The cost_filter attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> CostFilter
        => CreateReference("cost_filter");

    /// <summary>
    /// The cost_types attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CostTypes
        => CreateReference("cost_types");

    /// <summary>
    /// The notification attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Notification
        => CreateReference("notification");

    /// <summary>
    /// The planned_limit attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> PlannedLimit
        => CreateReference("planned_limit");

    /// <summary>
    /// The time_period_end attribute.
    /// </summary>
    public TerraformValue<string> TimePeriodEnd
        => CreateReference("time_period_end");

    /// <summary>
    /// The time_period_start attribute.
    /// </summary>
    public TerraformValue<string> TimePeriodStart
        => CreateReference("time_period_start");

    /// <summary>
    /// The time_unit attribute.
    /// </summary>
    public TerraformValue<string> TimeUnit
        => CreateReference("time_unit");

}
