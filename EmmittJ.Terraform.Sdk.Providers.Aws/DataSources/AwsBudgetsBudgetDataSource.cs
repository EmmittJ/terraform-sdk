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
    public string? AccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_id")?.Value;
        set => this.WithProperty("account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public string? NamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_prefix")?.Value;
        set => this.WithProperty("name_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
