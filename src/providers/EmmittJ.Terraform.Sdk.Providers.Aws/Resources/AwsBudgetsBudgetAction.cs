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
        set => SetProperty("action_threshold_type", value);
    }

    /// <summary>
    /// The action_threshold_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionThresholdValue is required")]
    public required TerraformProperty<double> ActionThresholdValue
    {
        set => SetProperty("action_threshold_value", value);
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
        set => SetProperty("address", value);
    }

    /// <summary>
    /// The subscription_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionType is required")]
    public required TerraformProperty<string> SubscriptionType
    {
        set => SetProperty("subscription_type", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("action_id");
        SetOutput("arn");
        SetOutput("status");
        SetOutput("account_id");
        SetOutput("action_type");
        SetOutput("approval_model");
        SetOutput("budget_name");
        SetOutput("execution_role_arn");
        SetOutput("id");
        SetOutput("notification_type");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformProperty<string> AccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("account_id");
        set => SetProperty("account_id", value);
    }

    /// <summary>
    /// The action_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionType is required")]
    public required TerraformProperty<string> ActionType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("action_type");
        set => SetProperty("action_type", value);
    }

    /// <summary>
    /// The approval_model attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApprovalModel is required")]
    public required TerraformProperty<string> ApprovalModel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("approval_model");
        set => SetProperty("approval_model", value);
    }

    /// <summary>
    /// The budget_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BudgetName is required")]
    public required TerraformProperty<string> BudgetName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("budget_name");
        set => SetProperty("budget_name", value);
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRoleArn is required")]
    public required TerraformProperty<string> ExecutionRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("execution_role_arn");
        set => SetProperty("execution_role_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The notification_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationType is required")]
    public required TerraformProperty<string> NotificationType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("notification_type");
        set => SetProperty("notification_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for action_threshold.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionThreshold is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ActionThreshold block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActionThreshold block(s) allowed")]
    public List<AwsBudgetsBudgetActionActionThresholdBlock>? ActionThreshold
    {
        set => SetProperty("action_threshold", value);
    }

    /// <summary>
    /// Block for definition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Definition is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Definition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Definition block(s) allowed")]
    public List<AwsBudgetsBudgetActionDefinitionBlock>? Definition
    {
        set => SetProperty("definition", value);
    }

    /// <summary>
    /// Block for subscriber.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subscriber is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Subscriber block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(11, ErrorMessage = "Maximum 11 Subscriber block(s) allowed")]
    public HashSet<AwsBudgetsBudgetActionSubscriberBlock>? Subscriber
    {
        set => SetProperty("subscriber", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsBudgetsBudgetActionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
