using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_budgets_budget resource.
/// </summary>
public class AwsBudgetsBudget : TerraformResource
{
    public AwsBudgetsBudget(string name) : base("aws_budgets_budget", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
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
    /// The billing_view_arn attribute.
    /// </summary>
    public string? BillingViewArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("billing_view_arn")?.Value;
        set => this.WithProperty("billing_view_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The budget_type attribute.
    /// </summary>
    public string? BudgetType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("budget_type")?.Value;
        set => this.WithProperty("budget_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The limit_amount attribute.
    /// </summary>
    public string? LimitAmount
    {
        get => GetProperty<TerraformLiteralProperty<string>>("limit_amount")?.Value;
        set => this.WithProperty("limit_amount", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The limit_unit attribute.
    /// </summary>
    public string? LimitUnit
    {
        get => GetProperty<TerraformLiteralProperty<string>>("limit_unit")?.Value;
        set => this.WithProperty("limit_unit", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The time_period_end attribute.
    /// </summary>
    public string? TimePeriodEnd
    {
        get => GetProperty<TerraformLiteralProperty<string>>("time_period_end")?.Value;
        set => this.WithProperty("time_period_end", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The time_period_start attribute.
    /// </summary>
    public string? TimePeriodStart
    {
        get => GetProperty<TerraformLiteralProperty<string>>("time_period_start")?.Value;
        set => this.WithProperty("time_period_start", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The time_unit attribute.
    /// </summary>
    public string? TimeUnit
    {
        get => GetProperty<TerraformLiteralProperty<string>>("time_unit")?.Value;
        set => this.WithProperty("time_unit", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
