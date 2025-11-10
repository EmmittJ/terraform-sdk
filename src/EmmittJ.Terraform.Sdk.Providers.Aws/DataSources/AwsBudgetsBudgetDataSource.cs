using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_budgets_budget.
/// </summary>
public class AwsBudgetsBudgetDataSource : TerraformDataSource
{
    public AwsBudgetsBudgetDataSource(string name) : base("aws_budgets_budget", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("auto_adjust_data");
        this.DeclareOutput("billing_view_arn");
        this.DeclareOutput("budget_exceeded");
        this.DeclareOutput("budget_limit");
        this.DeclareOutput("budget_type");
        this.DeclareOutput("calculated_spend");
        this.DeclareOutput("cost_filter");
        this.DeclareOutput("cost_types");
        this.DeclareOutput("notification");
        this.DeclareOutput("planned_limit");
        this.DeclareOutput("time_period_end");
        this.DeclareOutput("time_period_start");
        this.DeclareOutput("time_unit");
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The auto_adjust_data attribute.
    /// </summary>
    public TerraformExpression AutoAdjustData => this["auto_adjust_data"];

    /// <summary>
    /// The billing_view_arn attribute.
    /// </summary>
    public TerraformExpression BillingViewArn => this["billing_view_arn"];

    /// <summary>
    /// The budget_exceeded attribute.
    /// </summary>
    public TerraformExpression BudgetExceeded => this["budget_exceeded"];

    /// <summary>
    /// The budget_limit attribute.
    /// </summary>
    public TerraformExpression BudgetLimit => this["budget_limit"];

    /// <summary>
    /// The budget_type attribute.
    /// </summary>
    public TerraformExpression BudgetType => this["budget_type"];

    /// <summary>
    /// The calculated_spend attribute.
    /// </summary>
    public TerraformExpression CalculatedSpend => this["calculated_spend"];

    /// <summary>
    /// The cost_filter attribute.
    /// </summary>
    public TerraformExpression CostFilter => this["cost_filter"];

    /// <summary>
    /// The cost_types attribute.
    /// </summary>
    public TerraformExpression CostTypes => this["cost_types"];

    /// <summary>
    /// The notification attribute.
    /// </summary>
    public TerraformExpression Notification => this["notification"];

    /// <summary>
    /// The planned_limit attribute.
    /// </summary>
    public TerraformExpression PlannedLimit => this["planned_limit"];

    /// <summary>
    /// The time_period_end attribute.
    /// </summary>
    public TerraformExpression TimePeriodEnd => this["time_period_end"];

    /// <summary>
    /// The time_period_start attribute.
    /// </summary>
    public TerraformExpression TimePeriodStart => this["time_period_start"];

    /// <summary>
    /// The time_unit attribute.
    /// </summary>
    public TerraformExpression TimeUnit => this["time_unit"];

}
