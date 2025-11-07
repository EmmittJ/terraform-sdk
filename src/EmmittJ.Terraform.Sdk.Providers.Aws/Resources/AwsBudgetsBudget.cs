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
    public TerraformLiteralProperty<string>? AccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_id");
        set => this.WithProperty("account_id", value);
    }

    /// <summary>
    /// The billing_view_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BillingViewArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("billing_view_arn");
        set => this.WithProperty("billing_view_arn", value);
    }

    /// <summary>
    /// The budget_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BudgetType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("budget_type");
        set => this.WithProperty("budget_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The limit_amount attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LimitAmount
    {
        get => GetProperty<TerraformLiteralProperty<string>>("limit_amount");
        set => this.WithProperty("limit_amount", value);
    }

    /// <summary>
    /// The limit_unit attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LimitUnit
    {
        get => GetProperty<TerraformLiteralProperty<string>>("limit_unit");
        set => this.WithProperty("limit_unit", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The time_period_end attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TimePeriodEnd
    {
        get => GetProperty<TerraformLiteralProperty<string>>("time_period_end");
        set => this.WithProperty("time_period_end", value);
    }

    /// <summary>
    /// The time_period_start attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TimePeriodStart
    {
        get => GetProperty<TerraformLiteralProperty<string>>("time_period_start");
        set => this.WithProperty("time_period_start", value);
    }

    /// <summary>
    /// The time_unit attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TimeUnit
    {
        get => GetProperty<TerraformLiteralProperty<string>>("time_unit");
        set => this.WithProperty("time_unit", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
