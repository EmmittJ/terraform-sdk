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
        get => new TerraformReference<string>(this, "account_id");
        set => SetArgument("account_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string>? NamePrefix
    {
        get => new TerraformReference<string>(this, "name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The auto_adjust_data attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AutoAdjustData
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "auto_adjust_data").ResolveNodes(ctx));
    }

    /// <summary>
    /// The billing_view_arn attribute.
    /// </summary>
    public TerraformValue<string> BillingViewArn
    {
        get => new TerraformReference<string>(this, "billing_view_arn");
    }

    /// <summary>
    /// The budget_exceeded attribute.
    /// </summary>
    public TerraformValue<bool> BudgetExceeded
    {
        get => new TerraformReference<bool>(this, "budget_exceeded");
    }

    /// <summary>
    /// The budget_limit attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> BudgetLimit
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "budget_limit").ResolveNodes(ctx));
    }

    /// <summary>
    /// The budget_type attribute.
    /// </summary>
    public TerraformValue<string> BudgetType
    {
        get => new TerraformReference<string>(this, "budget_type");
    }

    /// <summary>
    /// The calculated_spend attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CalculatedSpend
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "calculated_spend").ResolveNodes(ctx));
    }

    /// <summary>
    /// The cost_filter attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> CostFilter
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "cost_filter").ResolveNodes(ctx));
    }

    /// <summary>
    /// The cost_types attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CostTypes
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "cost_types").ResolveNodes(ctx));
    }

    /// <summary>
    /// The notification attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Notification
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "notification").ResolveNodes(ctx));
    }

    /// <summary>
    /// The planned_limit attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> PlannedLimit
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "planned_limit").ResolveNodes(ctx));
    }

    /// <summary>
    /// The time_period_end attribute.
    /// </summary>
    public TerraformValue<string> TimePeriodEnd
    {
        get => new TerraformReference<string>(this, "time_period_end");
    }

    /// <summary>
    /// The time_period_start attribute.
    /// </summary>
    public TerraformValue<string> TimePeriodStart
    {
        get => new TerraformReference<string>(this, "time_period_start");
    }

    /// <summary>
    /// The time_unit attribute.
    /// </summary>
    public TerraformValue<string> TimeUnit
    {
        get => new TerraformReference<string>(this, "time_unit");
    }

}
