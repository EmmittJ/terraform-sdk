using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_budgets_budget_action resource.
/// </summary>
public class AwsBudgetsBudgetAction : TerraformResource
{
    public AwsBudgetsBudgetAction(string name) : base("aws_budgets_budget_action", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("action_id");
        this.DeclareOutput("arn");
        this.DeclareOutput("status");
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
    /// The action_type attribute.
    /// </summary>
    public string? ActionType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("action_type")?.Value;
        set => this.WithProperty("action_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The approval_model attribute.
    /// </summary>
    public string? ApprovalModel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("approval_model")?.Value;
        set => this.WithProperty("approval_model", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The budget_name attribute.
    /// </summary>
    public string? BudgetName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("budget_name")?.Value;
        set => this.WithProperty("budget_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    public string? ExecutionRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("execution_role_arn")?.Value;
        set => this.WithProperty("execution_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The notification_type attribute.
    /// </summary>
    public string? NotificationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("notification_type")?.Value;
        set => this.WithProperty("notification_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The action_id attribute.
    /// </summary>
    public TerraformExpression ActionId => this["action_id"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
