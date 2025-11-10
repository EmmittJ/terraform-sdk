using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for action_threshold in .
/// Nesting mode: list
/// </summary>
public class AwsBudgetsBudgetActionActionThresholdBlock : TerraformBlock
{
    /// <summary>
    /// The action_threshold_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionThresholdType is required")]
    public required TerraformProperty<string> ActionThresholdType
    {
        get => GetProperty<TerraformProperty<string>>("action_threshold_type");
        set => WithProperty("action_threshold_type", value);
    }

    /// <summary>
    /// The action_threshold_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionThresholdValue is required")]
    public required TerraformProperty<double> ActionThresholdValue
    {
        get => GetProperty<TerraformProperty<double>>("action_threshold_value");
        set => WithProperty("action_threshold_value", value);
    }

}

/// <summary>
/// Block type for definition in .
/// Nesting mode: list
/// </summary>
public class AwsBudgetsBudgetActionDefinitionBlock : TerraformBlock
{
}

/// <summary>
/// Block type for subscriber in .
/// Nesting mode: set
/// </summary>
public class AwsBudgetsBudgetActionSubscriberBlock : TerraformBlock
{
    /// <summary>
    /// The address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Address is required")]
    public required TerraformProperty<string> Address
    {
        get => GetProperty<TerraformProperty<string>>("address");
        set => WithProperty("address", value);
    }

    /// <summary>
    /// The subscription_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionType is required")]
    public required TerraformProperty<string> SubscriptionType
    {
        get => GetProperty<TerraformProperty<string>>("subscription_type");
        set => WithProperty("subscription_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsBudgetsBudgetActionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_budgets_budget_action resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionType is required")]
    public required TerraformProperty<string> ActionType
    {
        get => GetProperty<TerraformProperty<string>>("action_type");
        set => this.WithProperty("action_type", value);
    }

    /// <summary>
    /// The approval_model attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApprovalModel is required")]
    public required TerraformProperty<string> ApprovalModel
    {
        get => GetProperty<TerraformProperty<string>>("approval_model");
        set => this.WithProperty("approval_model", value);
    }

    /// <summary>
    /// The budget_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BudgetName is required")]
    public required TerraformProperty<string> BudgetName
    {
        get => GetProperty<TerraformProperty<string>>("budget_name");
        set => this.WithProperty("budget_name", value);
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRoleArn is required")]
    public required TerraformProperty<string> ExecutionRoleArn
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationType is required")]
    public required TerraformProperty<string> NotificationType
    {
        get => GetProperty<TerraformProperty<string>>("notification_type");
        set => this.WithProperty("notification_type", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for action_threshold.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ActionThreshold block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActionThreshold block(s) allowed")]
    public List<AwsBudgetsBudgetActionActionThresholdBlock>? ActionThreshold
    {
        get => GetProperty<List<AwsBudgetsBudgetActionActionThresholdBlock>>("action_threshold");
        set => this.WithProperty("action_threshold", value);
    }

    /// <summary>
    /// Block for definition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Definition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Definition block(s) allowed")]
    public List<AwsBudgetsBudgetActionDefinitionBlock>? Definition
    {
        get => GetProperty<List<AwsBudgetsBudgetActionDefinitionBlock>>("definition");
        set => this.WithProperty("definition", value);
    }

    /// <summary>
    /// Block for subscriber.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Subscriber block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(11, ErrorMessage = "Maximum 11 Subscriber block(s) allowed")]
    public HashSet<AwsBudgetsBudgetActionSubscriberBlock>? Subscriber
    {
        get => GetProperty<HashSet<AwsBudgetsBudgetActionSubscriberBlock>>("subscriber");
        set => this.WithProperty("subscriber", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsBudgetsBudgetActionTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsBudgetsBudgetActionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
