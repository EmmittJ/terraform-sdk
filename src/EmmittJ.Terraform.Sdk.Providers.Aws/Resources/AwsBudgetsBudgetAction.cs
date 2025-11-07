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
    public TerraformProperty<string>? AccountId
    {
        get => GetProperty<TerraformProperty<string>>("account_id");
        set => this.WithProperty("account_id", value);
    }

    /// <summary>
    /// The action_type attribute.
    /// </summary>
    public TerraformProperty<string>? ActionType
    {
        get => GetProperty<TerraformProperty<string>>("action_type");
        set => this.WithProperty("action_type", value);
    }

    /// <summary>
    /// The approval_model attribute.
    /// </summary>
    public TerraformProperty<string>? ApprovalModel
    {
        get => GetProperty<TerraformProperty<string>>("approval_model");
        set => this.WithProperty("approval_model", value);
    }

    /// <summary>
    /// The budget_name attribute.
    /// </summary>
    public TerraformProperty<string>? BudgetName
    {
        get => GetProperty<TerraformProperty<string>>("budget_name");
        set => this.WithProperty("budget_name", value);
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ExecutionRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("execution_role_arn");
        set => this.WithProperty("execution_role_arn", value);
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
    /// The notification_type attribute.
    /// </summary>
    public TerraformProperty<string>? NotificationType
    {
        get => GetProperty<TerraformProperty<string>>("notification_type");
        set => this.WithProperty("notification_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
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
