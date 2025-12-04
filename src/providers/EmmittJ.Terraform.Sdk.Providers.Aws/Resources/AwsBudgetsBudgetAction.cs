using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for action_threshold in AwsBudgetsBudgetAction.
/// Nesting mode: list
/// </summary>
public class AwsBudgetsBudgetActionActionThresholdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action_threshold";

    /// <summary>
    /// The action_threshold_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionThresholdType is required")]
    public required TerraformValue<string> ActionThresholdType
    {
        get => GetArgument<TerraformValue<string>>("action_threshold_type");
        set => SetArgument("action_threshold_type", value);
    }

    /// <summary>
    /// The action_threshold_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionThresholdValue is required")]
    public required TerraformValue<double> ActionThresholdValue
    {
        get => GetArgument<TerraformValue<double>>("action_threshold_value");
        set => SetArgument("action_threshold_value", value);
    }

}


/// <summary>
/// Block type for definition in AwsBudgetsBudgetAction.
/// Nesting mode: list
/// </summary>
public class AwsBudgetsBudgetActionDefinitionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "definition";

    /// <summary>
    /// IamActionDefinition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IamActionDefinition block(s) allowed")]
    public TerraformList<AwsBudgetsBudgetActionDefinitionBlockIamActionDefinitionBlock>? IamActionDefinition
    {
        get => GetArgument<TerraformList<AwsBudgetsBudgetActionDefinitionBlockIamActionDefinitionBlock>>("iam_action_definition");
        set => SetArgument("iam_action_definition", value);
    }

    /// <summary>
    /// ScpActionDefinition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScpActionDefinition block(s) allowed")]
    public TerraformList<AwsBudgetsBudgetActionDefinitionBlockScpActionDefinitionBlock>? ScpActionDefinition
    {
        get => GetArgument<TerraformList<AwsBudgetsBudgetActionDefinitionBlockScpActionDefinitionBlock>>("scp_action_definition");
        set => SetArgument("scp_action_definition", value);
    }

    /// <summary>
    /// SsmActionDefinition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SsmActionDefinition block(s) allowed")]
    public TerraformList<AwsBudgetsBudgetActionDefinitionBlockSsmActionDefinitionBlock>? SsmActionDefinition
    {
        get => GetArgument<TerraformList<AwsBudgetsBudgetActionDefinitionBlockSsmActionDefinitionBlock>>("ssm_action_definition");
        set => SetArgument("ssm_action_definition", value);
    }

}

/// <summary>
/// Block type for iam_action_definition in AwsBudgetsBudgetActionDefinitionBlock.
/// Nesting mode: list
/// </summary>
public class AwsBudgetsBudgetActionDefinitionBlockIamActionDefinitionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "iam_action_definition";

    /// <summary>
    /// The groups attribute.
    /// </summary>
    public TerraformSet<string>? Groups
    {
        get => GetArgument<TerraformSet<string>>("groups");
        set => SetArgument("groups", value);
    }

    /// <summary>
    /// The policy_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyArn is required")]
    public required TerraformValue<string> PolicyArn
    {
        get => GetArgument<TerraformValue<string>>("policy_arn");
        set => SetArgument("policy_arn", value);
    }

    /// <summary>
    /// The roles attribute.
    /// </summary>
    public TerraformSet<string>? Roles
    {
        get => GetArgument<TerraformSet<string>>("roles");
        set => SetArgument("roles", value);
    }

    /// <summary>
    /// The users attribute.
    /// </summary>
    public TerraformSet<string>? Users
    {
        get => GetArgument<TerraformSet<string>>("users");
        set => SetArgument("users", value);
    }

}

/// <summary>
/// Block type for scp_action_definition in AwsBudgetsBudgetActionDefinitionBlock.
/// Nesting mode: list
/// </summary>
public class AwsBudgetsBudgetActionDefinitionBlockScpActionDefinitionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scp_action_definition";

    /// <summary>
    /// The policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyId is required")]
    public required TerraformValue<string> PolicyId
    {
        get => GetArgument<TerraformValue<string>>("policy_id");
        set => SetArgument("policy_id", value);
    }

    /// <summary>
    /// The target_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetIds is required")]
    public required TerraformSet<string> TargetIds
    {
        get => GetArgument<TerraformSet<string>>("target_ids");
        set => SetArgument("target_ids", value);
    }

}

/// <summary>
/// Block type for ssm_action_definition in AwsBudgetsBudgetActionDefinitionBlock.
/// Nesting mode: list
/// </summary>
public class AwsBudgetsBudgetActionDefinitionBlockSsmActionDefinitionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssm_action_definition";

    /// <summary>
    /// The action_sub_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionSubType is required")]
    public required TerraformValue<string> ActionSubType
    {
        get => GetArgument<TerraformValue<string>>("action_sub_type");
        set => SetArgument("action_sub_type", value);
    }

    /// <summary>
    /// The instance_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceIds is required")]
    public required TerraformSet<string> InstanceIds
    {
        get => GetArgument<TerraformSet<string>>("instance_ids");
        set => SetArgument("instance_ids", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    public required TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

}


/// <summary>
/// Block type for subscriber in AwsBudgetsBudgetAction.
/// Nesting mode: set
/// </summary>
public class AwsBudgetsBudgetActionSubscriberBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "subscriber";

    /// <summary>
    /// The address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Address is required")]
    public required TerraformValue<string> Address
    {
        get => GetArgument<TerraformValue<string>>("address");
        set => SetArgument("address", value);
    }

    /// <summary>
    /// The subscription_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionType is required")]
    public required TerraformValue<string> SubscriptionType
    {
        get => GetArgument<TerraformValue<string>>("subscription_type");
        set => SetArgument("subscription_type", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsBudgetsBudgetAction.
/// Nesting mode: single
/// </summary>
public class AwsBudgetsBudgetActionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_budgets_budget_action Terraform resource.
/// Manages a aws_budgets_budget_action resource.
/// </summary>
public partial class AwsBudgetsBudgetAction(string name) : TerraformResource("aws_budgets_budget_action", name)
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformValue<string>? AccountId
    {
        get => GetArgument<TerraformValue<string>>("account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The action_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionType is required")]
    public required TerraformValue<string> ActionType
    {
        get => GetArgument<TerraformValue<string>>("action_type");
        set => SetArgument("action_type", value);
    }

    /// <summary>
    /// The approval_model attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApprovalModel is required")]
    public required TerraformValue<string> ApprovalModel
    {
        get => GetArgument<TerraformValue<string>>("approval_model");
        set => SetArgument("approval_model", value);
    }

    /// <summary>
    /// The budget_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BudgetName is required")]
    public required TerraformValue<string> BudgetName
    {
        get => GetArgument<TerraformValue<string>>("budget_name");
        set => SetArgument("budget_name", value);
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRoleArn is required")]
    public required TerraformValue<string> ExecutionRoleArn
    {
        get => GetArgument<TerraformValue<string>>("execution_role_arn");
        set => SetArgument("execution_role_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The notification_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationType is required")]
    public required TerraformValue<string> NotificationType
    {
        get => GetArgument<TerraformValue<string>>("notification_type");
        set => SetArgument("notification_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The action_id attribute.
    /// </summary>
    public TerraformValue<string> ActionId
        => AsReference("action_id");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// ActionThreshold block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionThreshold is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ActionThreshold block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActionThreshold block(s) allowed")]
    public required TerraformList<AwsBudgetsBudgetActionActionThresholdBlock> ActionThreshold
    {
        get => GetRequiredArgument<TerraformList<AwsBudgetsBudgetActionActionThresholdBlock>>("action_threshold");
        set => SetArgument("action_threshold", value);
    }

    /// <summary>
    /// Definition block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Definition is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Definition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Definition block(s) allowed")]
    public required TerraformList<AwsBudgetsBudgetActionDefinitionBlock> Definition
    {
        get => GetRequiredArgument<TerraformList<AwsBudgetsBudgetActionDefinitionBlock>>("definition");
        set => SetArgument("definition", value);
    }

    /// <summary>
    /// Subscriber block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subscriber is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Subscriber block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(11, ErrorMessage = "Maximum 11 Subscriber block(s) allowed")]
    public required TerraformSet<AwsBudgetsBudgetActionSubscriberBlock> Subscriber
    {
        get => GetRequiredArgument<TerraformSet<AwsBudgetsBudgetActionSubscriberBlock>>("subscriber");
        set => SetArgument("subscriber", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsBudgetsBudgetActionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsBudgetsBudgetActionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
