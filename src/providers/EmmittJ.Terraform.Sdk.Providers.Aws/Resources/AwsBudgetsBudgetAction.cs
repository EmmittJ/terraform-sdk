using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for action_threshold in .
/// Nesting mode: list
/// </summary>
public partial class AwsBudgetsBudgetActionActionThresholdBlock() : TerraformBlock("action_threshold")
{
    /// <summary>
    /// The action_threshold_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionThresholdType is required")]
    [TerraformProperty("action_threshold_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ActionThresholdType { get; set; }

    /// <summary>
    /// The action_threshold_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionThresholdValue is required")]
    [TerraformProperty("action_threshold_value")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> ActionThresholdValue { get; set; }

}

/// <summary>
/// Block type for definition in .
/// Nesting mode: list
/// </summary>
public partial class AwsBudgetsBudgetActionDefinitionBlock() : TerraformBlock("definition")
{
}

/// <summary>
/// Block type for subscriber in .
/// Nesting mode: set
/// </summary>
public partial class AwsBudgetsBudgetActionSubscriberBlock() : TerraformBlock("subscriber")
{
    /// <summary>
    /// The address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Address is required")]
    [TerraformProperty("address")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Address { get; set; }

    /// <summary>
    /// The subscription_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionType is required")]
    [TerraformProperty("subscription_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SubscriptionType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsBudgetsBudgetActionTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_budgets_budget_action resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsBudgetsBudgetAction : TerraformResource
{
    public AwsBudgetsBudgetAction(string name) : base("aws_budgets_budget_action", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformProperty("account_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AccountId { get; set; }

    /// <summary>
    /// The action_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionType is required")]
    [TerraformProperty("action_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ActionType { get; set; }

    /// <summary>
    /// The approval_model attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApprovalModel is required")]
    [TerraformProperty("approval_model")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApprovalModel { get; set; }

    /// <summary>
    /// The budget_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BudgetName is required")]
    [TerraformProperty("budget_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BudgetName { get; set; }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRoleArn is required")]
    [TerraformProperty("execution_role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ExecutionRoleArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The notification_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationType is required")]
    [TerraformProperty("notification_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NotificationType { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for action_threshold.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionThreshold is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ActionThreshold block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActionThreshold block(s) allowed")]
    [TerraformProperty("action_threshold")]
    public required TerraformList<AwsBudgetsBudgetActionActionThresholdBlock> ActionThreshold { get; set; } = new();

    /// <summary>
    /// Block for definition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Definition is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Definition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Definition block(s) allowed")]
    [TerraformProperty("definition")]
    public required TerraformList<AwsBudgetsBudgetActionDefinitionBlock> Definition { get; set; } = new();

    /// <summary>
    /// Block for subscriber.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subscriber is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Subscriber block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(11, ErrorMessage = "Maximum 11 Subscriber block(s) allowed")]
    [TerraformProperty("subscriber")]
    public required TerraformSet<AwsBudgetsBudgetActionSubscriberBlock> Subscriber { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsBudgetsBudgetActionTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The action_id attribute.
    /// </summary>
    [TerraformProperty("action_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ActionId { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

}
