using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for activation_rules in AzurermRoleManagementPolicy.
/// Nesting mode: list
/// </summary>
public class AzurermRoleManagementPolicyActivationRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "activation_rules";

    /// <summary>
    /// The time after which the an activation can be valid for
    /// </summary>
    public TerraformValue<string> MaximumDuration
    {
        get => GetArgument<TerraformValue<string>>("maximum_duration") ?? AsReference("maximum_duration");
        set => SetArgument("maximum_duration", value);
    }

    /// <summary>
    /// Whether an approval is required for activation
    /// </summary>
    public TerraformValue<bool> RequireApproval
    {
        get => GetArgument<TerraformValue<bool>>("require_approval") ?? AsReference("require_approval");
        set => SetArgument("require_approval", value);
    }

    /// <summary>
    /// Whether a justification is required during activation
    /// </summary>
    public TerraformValue<bool> RequireJustification
    {
        get => GetArgument<TerraformValue<bool>>("require_justification") ?? AsReference("require_justification");
        set => SetArgument("require_justification", value);
    }

    /// <summary>
    /// Whether multi-factor authentication is required during activation
    /// </summary>
    public TerraformValue<bool> RequireMultifactorAuthentication
    {
        get => GetArgument<TerraformValue<bool>>("require_multifactor_authentication") ?? AsReference("require_multifactor_authentication");
        set => SetArgument("require_multifactor_authentication", value);
    }

    /// <summary>
    /// Whether ticket information is required during activation
    /// </summary>
    public TerraformValue<bool> RequireTicketInfo
    {
        get => GetArgument<TerraformValue<bool>>("require_ticket_info") ?? AsReference("require_ticket_info");
        set => SetArgument("require_ticket_info", value);
    }

    /// <summary>
    /// Whether a conditional access context is required during activation
    /// </summary>
    public TerraformValue<string> RequiredConditionalAccessAuthenticationContext
    {
        get => GetArgument<TerraformValue<string>>("required_conditional_access_authentication_context") ?? AsReference("required_conditional_access_authentication_context");
        set => SetArgument("required_conditional_access_authentication_context", value);
    }

    /// <summary>
    /// ApprovalStage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApprovalStage block(s) allowed")]
    public TerraformList<AzurermRoleManagementPolicyActivationRulesBlockApprovalStageBlock>? ApprovalStage
    {
        get => GetArgument<TerraformList<AzurermRoleManagementPolicyActivationRulesBlockApprovalStageBlock>>("approval_stage");
        set => SetArgument("approval_stage", value);
    }

}

/// <summary>
/// Block type for approval_stage in AzurermRoleManagementPolicyActivationRulesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermRoleManagementPolicyActivationRulesBlockApprovalStageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "approval_stage";

    /// <summary>
    /// PrimaryApprover block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryApprover is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PrimaryApprover block(s) required")]
    public required TerraformSet<AzurermRoleManagementPolicyActivationRulesBlockApprovalStageBlockPrimaryApproverBlock> PrimaryApprover
    {
        get => GetRequiredArgument<TerraformSet<AzurermRoleManagementPolicyActivationRulesBlockApprovalStageBlockPrimaryApproverBlock>>("primary_approver");
        set => SetArgument("primary_approver", value);
    }

}

/// <summary>
/// Block type for primary_approver in AzurermRoleManagementPolicyActivationRulesBlockApprovalStageBlock.
/// Nesting mode: set
/// </summary>
public class AzurermRoleManagementPolicyActivationRulesBlockApprovalStageBlockPrimaryApproverBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "primary_approver";

    /// <summary>
    /// The ID of the object to act as an approver
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectId is required")]
    public required TerraformValue<string> ObjectId
    {
        get => GetRequiredArgument<TerraformValue<string>>("object_id");
        set => SetArgument("object_id", value);
    }

    /// <summary>
    /// The type of object acting as an approver
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for active_assignment_rules in AzurermRoleManagementPolicy.
/// Nesting mode: list
/// </summary>
public class AzurermRoleManagementPolicyActiveAssignmentRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "active_assignment_rules";

    /// <summary>
    /// Must the assignment have an expiry date
    /// </summary>
    public TerraformValue<bool> ExpirationRequired
    {
        get => GetArgument<TerraformValue<bool>>("expiration_required") ?? AsReference("expiration_required");
        set => SetArgument("expiration_required", value);
    }

    /// <summary>
    /// The duration after which assignments expire
    /// </summary>
    public TerraformValue<string> ExpireAfter
    {
        get => GetArgument<TerraformValue<string>>("expire_after") ?? AsReference("expire_after");
        set => SetArgument("expire_after", value);
    }

    /// <summary>
    /// Whether a justification is required to make an assignment
    /// </summary>
    public TerraformValue<bool> RequireJustification
    {
        get => GetArgument<TerraformValue<bool>>("require_justification") ?? AsReference("require_justification");
        set => SetArgument("require_justification", value);
    }

    /// <summary>
    /// Whether multi-factor authentication is required to make an assignment
    /// </summary>
    public TerraformValue<bool> RequireMultifactorAuthentication
    {
        get => GetArgument<TerraformValue<bool>>("require_multifactor_authentication") ?? AsReference("require_multifactor_authentication");
        set => SetArgument("require_multifactor_authentication", value);
    }

    /// <summary>
    /// Whether ticket information is required to make an assignment
    /// </summary>
    public TerraformValue<bool> RequireTicketInfo
    {
        get => GetArgument<TerraformValue<bool>>("require_ticket_info") ?? AsReference("require_ticket_info");
        set => SetArgument("require_ticket_info", value);
    }

}


/// <summary>
/// Block type for eligible_assignment_rules in AzurermRoleManagementPolicy.
/// Nesting mode: list
/// </summary>
public class AzurermRoleManagementPolicyEligibleAssignmentRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "eligible_assignment_rules";

    /// <summary>
    /// Must the assignment have an expiry date
    /// </summary>
    public TerraformValue<bool> ExpirationRequired
    {
        get => GetArgument<TerraformValue<bool>>("expiration_required") ?? AsReference("expiration_required");
        set => SetArgument("expiration_required", value);
    }

    /// <summary>
    /// The duration after which assignments expire
    /// </summary>
    public TerraformValue<string> ExpireAfter
    {
        get => GetArgument<TerraformValue<string>>("expire_after") ?? AsReference("expire_after");
        set => SetArgument("expire_after", value);
    }

}


/// <summary>
/// Block type for notification_rules in AzurermRoleManagementPolicy.
/// Nesting mode: list
/// </summary>
public class AzurermRoleManagementPolicyNotificationRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notification_rules";

    /// <summary>
    /// ActiveAssignments block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveAssignments block(s) allowed")]
    public TerraformList<AzurermRoleManagementPolicyNotificationRulesBlockActiveAssignmentsBlock>? ActiveAssignments
    {
        get => GetArgument<TerraformList<AzurermRoleManagementPolicyNotificationRulesBlockActiveAssignmentsBlock>>("active_assignments");
        set => SetArgument("active_assignments", value);
    }

    /// <summary>
    /// EligibleActivations block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EligibleActivations block(s) allowed")]
    public TerraformList<AzurermRoleManagementPolicyNotificationRulesBlockEligibleActivationsBlock>? EligibleActivations
    {
        get => GetArgument<TerraformList<AzurermRoleManagementPolicyNotificationRulesBlockEligibleActivationsBlock>>("eligible_activations");
        set => SetArgument("eligible_activations", value);
    }

    /// <summary>
    /// EligibleAssignments block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EligibleAssignments block(s) allowed")]
    public TerraformList<AzurermRoleManagementPolicyNotificationRulesBlockEligibleAssignmentsBlock>? EligibleAssignments
    {
        get => GetArgument<TerraformList<AzurermRoleManagementPolicyNotificationRulesBlockEligibleAssignmentsBlock>>("eligible_assignments");
        set => SetArgument("eligible_assignments", value);
    }

}

/// <summary>
/// Block type for active_assignments in AzurermRoleManagementPolicyNotificationRulesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermRoleManagementPolicyNotificationRulesBlockActiveAssignmentsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "active_assignments";

    /// <summary>
    /// AdminNotifications block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdminNotifications block(s) allowed")]
    public TerraformList<AzurermRoleManagementPolicyNotificationRulesBlockActiveAssignmentsBlockAdminNotificationsBlock>? AdminNotifications
    {
        get => GetArgument<TerraformList<AzurermRoleManagementPolicyNotificationRulesBlockActiveAssignmentsBlockAdminNotificationsBlock>>("admin_notifications");
        set => SetArgument("admin_notifications", value);
    }

    /// <summary>
    /// ApproverNotifications block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApproverNotifications block(s) allowed")]
    public TerraformList<AzurermRoleManagementPolicyNotificationRulesBlockActiveAssignmentsBlockApproverNotificationsBlock>? ApproverNotifications
    {
        get => GetArgument<TerraformList<AzurermRoleManagementPolicyNotificationRulesBlockActiveAssignmentsBlockApproverNotificationsBlock>>("approver_notifications");
        set => SetArgument("approver_notifications", value);
    }

    /// <summary>
    /// AssigneeNotifications block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AssigneeNotifications block(s) allowed")]
    public TerraformList<AzurermRoleManagementPolicyNotificationRulesBlockActiveAssignmentsBlockAssigneeNotificationsBlock>? AssigneeNotifications
    {
        get => GetArgument<TerraformList<AzurermRoleManagementPolicyNotificationRulesBlockActiveAssignmentsBlockAssigneeNotificationsBlock>>("assignee_notifications");
        set => SetArgument("assignee_notifications", value);
    }

}

/// <summary>
/// Block type for admin_notifications in AzurermRoleManagementPolicyNotificationRulesBlockActiveAssignmentsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermRoleManagementPolicyNotificationRulesBlockActiveAssignmentsBlockAdminNotificationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "admin_notifications";

    /// <summary>
    /// The additional recipients to notify
    /// </summary>
    public TerraformSet<string> AdditionalRecipients
    {
        get => GetArgument<TerraformSet<string>>("additional_recipients") ?? AsReference("additional_recipients");
        set => SetArgument("additional_recipients", value);
    }

    /// <summary>
    /// Whether the default recipients are notified
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultRecipients is required")]
    public required TerraformValue<bool> DefaultRecipients
    {
        get => GetRequiredArgument<TerraformValue<bool>>("default_recipients");
        set => SetArgument("default_recipients", value);
    }

    /// <summary>
    /// What level of notifications are sent
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationLevel is required")]
    public required TerraformValue<string> NotificationLevel
    {
        get => GetRequiredArgument<TerraformValue<string>>("notification_level");
        set => SetArgument("notification_level", value);
    }

}

/// <summary>
/// Block type for approver_notifications in AzurermRoleManagementPolicyNotificationRulesBlockActiveAssignmentsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermRoleManagementPolicyNotificationRulesBlockActiveAssignmentsBlockApproverNotificationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "approver_notifications";

    /// <summary>
    /// The additional recipients to notify
    /// </summary>
    public TerraformSet<string> AdditionalRecipients
    {
        get => GetArgument<TerraformSet<string>>("additional_recipients") ?? AsReference("additional_recipients");
        set => SetArgument("additional_recipients", value);
    }

    /// <summary>
    /// Whether the default recipients are notified
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultRecipients is required")]
    public required TerraformValue<bool> DefaultRecipients
    {
        get => GetRequiredArgument<TerraformValue<bool>>("default_recipients");
        set => SetArgument("default_recipients", value);
    }

    /// <summary>
    /// What level of notifications are sent
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationLevel is required")]
    public required TerraformValue<string> NotificationLevel
    {
        get => GetRequiredArgument<TerraformValue<string>>("notification_level");
        set => SetArgument("notification_level", value);
    }

}

/// <summary>
/// Block type for assignee_notifications in AzurermRoleManagementPolicyNotificationRulesBlockActiveAssignmentsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermRoleManagementPolicyNotificationRulesBlockActiveAssignmentsBlockAssigneeNotificationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "assignee_notifications";

    /// <summary>
    /// The additional recipients to notify
    /// </summary>
    public TerraformSet<string> AdditionalRecipients
    {
        get => GetArgument<TerraformSet<string>>("additional_recipients") ?? AsReference("additional_recipients");
        set => SetArgument("additional_recipients", value);
    }

    /// <summary>
    /// Whether the default recipients are notified
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultRecipients is required")]
    public required TerraformValue<bool> DefaultRecipients
    {
        get => GetRequiredArgument<TerraformValue<bool>>("default_recipients");
        set => SetArgument("default_recipients", value);
    }

    /// <summary>
    /// What level of notifications are sent
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationLevel is required")]
    public required TerraformValue<string> NotificationLevel
    {
        get => GetRequiredArgument<TerraformValue<string>>("notification_level");
        set => SetArgument("notification_level", value);
    }

}

/// <summary>
/// Block type for eligible_activations in AzurermRoleManagementPolicyNotificationRulesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermRoleManagementPolicyNotificationRulesBlockEligibleActivationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "eligible_activations";

    /// <summary>
    /// AdminNotifications block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdminNotifications block(s) allowed")]
    public TerraformList<AzurermRoleManagementPolicyNotificationRulesBlockEligibleActivationsBlockAdminNotificationsBlock>? AdminNotifications
    {
        get => GetArgument<TerraformList<AzurermRoleManagementPolicyNotificationRulesBlockEligibleActivationsBlockAdminNotificationsBlock>>("admin_notifications");
        set => SetArgument("admin_notifications", value);
    }

    /// <summary>
    /// ApproverNotifications block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApproverNotifications block(s) allowed")]
    public TerraformList<AzurermRoleManagementPolicyNotificationRulesBlockEligibleActivationsBlockApproverNotificationsBlock>? ApproverNotifications
    {
        get => GetArgument<TerraformList<AzurermRoleManagementPolicyNotificationRulesBlockEligibleActivationsBlockApproverNotificationsBlock>>("approver_notifications");
        set => SetArgument("approver_notifications", value);
    }

    /// <summary>
    /// AssigneeNotifications block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AssigneeNotifications block(s) allowed")]
    public TerraformList<AzurermRoleManagementPolicyNotificationRulesBlockEligibleActivationsBlockAssigneeNotificationsBlock>? AssigneeNotifications
    {
        get => GetArgument<TerraformList<AzurermRoleManagementPolicyNotificationRulesBlockEligibleActivationsBlockAssigneeNotificationsBlock>>("assignee_notifications");
        set => SetArgument("assignee_notifications", value);
    }

}

/// <summary>
/// Block type for admin_notifications in AzurermRoleManagementPolicyNotificationRulesBlockEligibleActivationsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermRoleManagementPolicyNotificationRulesBlockEligibleActivationsBlockAdminNotificationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "admin_notifications";

    /// <summary>
    /// The additional recipients to notify
    /// </summary>
    public TerraformSet<string> AdditionalRecipients
    {
        get => GetArgument<TerraformSet<string>>("additional_recipients") ?? AsReference("additional_recipients");
        set => SetArgument("additional_recipients", value);
    }

    /// <summary>
    /// Whether the default recipients are notified
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultRecipients is required")]
    public required TerraformValue<bool> DefaultRecipients
    {
        get => GetRequiredArgument<TerraformValue<bool>>("default_recipients");
        set => SetArgument("default_recipients", value);
    }

    /// <summary>
    /// What level of notifications are sent
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationLevel is required")]
    public required TerraformValue<string> NotificationLevel
    {
        get => GetRequiredArgument<TerraformValue<string>>("notification_level");
        set => SetArgument("notification_level", value);
    }

}

/// <summary>
/// Block type for approver_notifications in AzurermRoleManagementPolicyNotificationRulesBlockEligibleActivationsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermRoleManagementPolicyNotificationRulesBlockEligibleActivationsBlockApproverNotificationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "approver_notifications";

    /// <summary>
    /// The additional recipients to notify
    /// </summary>
    public TerraformSet<string> AdditionalRecipients
    {
        get => GetArgument<TerraformSet<string>>("additional_recipients") ?? AsReference("additional_recipients");
        set => SetArgument("additional_recipients", value);
    }

    /// <summary>
    /// Whether the default recipients are notified
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultRecipients is required")]
    public required TerraformValue<bool> DefaultRecipients
    {
        get => GetRequiredArgument<TerraformValue<bool>>("default_recipients");
        set => SetArgument("default_recipients", value);
    }

    /// <summary>
    /// What level of notifications are sent
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationLevel is required")]
    public required TerraformValue<string> NotificationLevel
    {
        get => GetRequiredArgument<TerraformValue<string>>("notification_level");
        set => SetArgument("notification_level", value);
    }

}

/// <summary>
/// Block type for assignee_notifications in AzurermRoleManagementPolicyNotificationRulesBlockEligibleActivationsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermRoleManagementPolicyNotificationRulesBlockEligibleActivationsBlockAssigneeNotificationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "assignee_notifications";

    /// <summary>
    /// The additional recipients to notify
    /// </summary>
    public TerraformSet<string> AdditionalRecipients
    {
        get => GetArgument<TerraformSet<string>>("additional_recipients") ?? AsReference("additional_recipients");
        set => SetArgument("additional_recipients", value);
    }

    /// <summary>
    /// Whether the default recipients are notified
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultRecipients is required")]
    public required TerraformValue<bool> DefaultRecipients
    {
        get => GetRequiredArgument<TerraformValue<bool>>("default_recipients");
        set => SetArgument("default_recipients", value);
    }

    /// <summary>
    /// What level of notifications are sent
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationLevel is required")]
    public required TerraformValue<string> NotificationLevel
    {
        get => GetRequiredArgument<TerraformValue<string>>("notification_level");
        set => SetArgument("notification_level", value);
    }

}

/// <summary>
/// Block type for eligible_assignments in AzurermRoleManagementPolicyNotificationRulesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermRoleManagementPolicyNotificationRulesBlockEligibleAssignmentsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "eligible_assignments";

    /// <summary>
    /// AdminNotifications block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdminNotifications block(s) allowed")]
    public TerraformList<AzurermRoleManagementPolicyNotificationRulesBlockEligibleAssignmentsBlockAdminNotificationsBlock>? AdminNotifications
    {
        get => GetArgument<TerraformList<AzurermRoleManagementPolicyNotificationRulesBlockEligibleAssignmentsBlockAdminNotificationsBlock>>("admin_notifications");
        set => SetArgument("admin_notifications", value);
    }

    /// <summary>
    /// ApproverNotifications block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApproverNotifications block(s) allowed")]
    public TerraformList<AzurermRoleManagementPolicyNotificationRulesBlockEligibleAssignmentsBlockApproverNotificationsBlock>? ApproverNotifications
    {
        get => GetArgument<TerraformList<AzurermRoleManagementPolicyNotificationRulesBlockEligibleAssignmentsBlockApproverNotificationsBlock>>("approver_notifications");
        set => SetArgument("approver_notifications", value);
    }

    /// <summary>
    /// AssigneeNotifications block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AssigneeNotifications block(s) allowed")]
    public TerraformList<AzurermRoleManagementPolicyNotificationRulesBlockEligibleAssignmentsBlockAssigneeNotificationsBlock>? AssigneeNotifications
    {
        get => GetArgument<TerraformList<AzurermRoleManagementPolicyNotificationRulesBlockEligibleAssignmentsBlockAssigneeNotificationsBlock>>("assignee_notifications");
        set => SetArgument("assignee_notifications", value);
    }

}

/// <summary>
/// Block type for admin_notifications in AzurermRoleManagementPolicyNotificationRulesBlockEligibleAssignmentsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermRoleManagementPolicyNotificationRulesBlockEligibleAssignmentsBlockAdminNotificationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "admin_notifications";

    /// <summary>
    /// The additional recipients to notify
    /// </summary>
    public TerraformSet<string> AdditionalRecipients
    {
        get => GetArgument<TerraformSet<string>>("additional_recipients") ?? AsReference("additional_recipients");
        set => SetArgument("additional_recipients", value);
    }

    /// <summary>
    /// Whether the default recipients are notified
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultRecipients is required")]
    public required TerraformValue<bool> DefaultRecipients
    {
        get => GetRequiredArgument<TerraformValue<bool>>("default_recipients");
        set => SetArgument("default_recipients", value);
    }

    /// <summary>
    /// What level of notifications are sent
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationLevel is required")]
    public required TerraformValue<string> NotificationLevel
    {
        get => GetRequiredArgument<TerraformValue<string>>("notification_level");
        set => SetArgument("notification_level", value);
    }

}

/// <summary>
/// Block type for approver_notifications in AzurermRoleManagementPolicyNotificationRulesBlockEligibleAssignmentsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermRoleManagementPolicyNotificationRulesBlockEligibleAssignmentsBlockApproverNotificationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "approver_notifications";

    /// <summary>
    /// The additional recipients to notify
    /// </summary>
    public TerraformSet<string> AdditionalRecipients
    {
        get => GetArgument<TerraformSet<string>>("additional_recipients") ?? AsReference("additional_recipients");
        set => SetArgument("additional_recipients", value);
    }

    /// <summary>
    /// Whether the default recipients are notified
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultRecipients is required")]
    public required TerraformValue<bool> DefaultRecipients
    {
        get => GetRequiredArgument<TerraformValue<bool>>("default_recipients");
        set => SetArgument("default_recipients", value);
    }

    /// <summary>
    /// What level of notifications are sent
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationLevel is required")]
    public required TerraformValue<string> NotificationLevel
    {
        get => GetRequiredArgument<TerraformValue<string>>("notification_level");
        set => SetArgument("notification_level", value);
    }

}

/// <summary>
/// Block type for assignee_notifications in AzurermRoleManagementPolicyNotificationRulesBlockEligibleAssignmentsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermRoleManagementPolicyNotificationRulesBlockEligibleAssignmentsBlockAssigneeNotificationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "assignee_notifications";

    /// <summary>
    /// The additional recipients to notify
    /// </summary>
    public TerraformSet<string> AdditionalRecipients
    {
        get => GetArgument<TerraformSet<string>>("additional_recipients") ?? AsReference("additional_recipients");
        set => SetArgument("additional_recipients", value);
    }

    /// <summary>
    /// Whether the default recipients are notified
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultRecipients is required")]
    public required TerraformValue<bool> DefaultRecipients
    {
        get => GetRequiredArgument<TerraformValue<bool>>("default_recipients");
        set => SetArgument("default_recipients", value);
    }

    /// <summary>
    /// What level of notifications are sent
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationLevel is required")]
    public required TerraformValue<string> NotificationLevel
    {
        get => GetRequiredArgument<TerraformValue<string>>("notification_level");
        set => SetArgument("notification_level", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermRoleManagementPolicy.
/// Nesting mode: single
/// </summary>
public class AzurermRoleManagementPolicyTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
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
/// Represents a azurerm_role_management_policy Terraform resource.
/// Manages a azurerm_role_management_policy resource.
/// </summary>
public partial class AzurermRoleManagementPolicy(string name) : TerraformResource("azurerm_role_management_policy", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// ID of the Azure Role to which this policy is assigned
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleDefinitionId is required")]
    public required TerraformValue<string> RoleDefinitionId
    {
        get => GetRequiredArgument<TerraformValue<string>>("role_definition_id");
        set => SetArgument("role_definition_id", value);
    }

    /// <summary>
    /// The scope of the role to which this policy will apply
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformValue<string> Scope
    {
        get => GetRequiredArgument<TerraformValue<string>>("scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The Description of the policy
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The name of the policy
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// ActivationRules block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActivationRules block(s) allowed")]
    public TerraformList<AzurermRoleManagementPolicyActivationRulesBlock>? ActivationRules
    {
        get => GetArgument<TerraformList<AzurermRoleManagementPolicyActivationRulesBlock>>("activation_rules");
        set => SetArgument("activation_rules", value);
    }

    /// <summary>
    /// ActiveAssignmentRules block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveAssignmentRules block(s) allowed")]
    public TerraformList<AzurermRoleManagementPolicyActiveAssignmentRulesBlock>? ActiveAssignmentRules
    {
        get => GetArgument<TerraformList<AzurermRoleManagementPolicyActiveAssignmentRulesBlock>>("active_assignment_rules");
        set => SetArgument("active_assignment_rules", value);
    }

    /// <summary>
    /// EligibleAssignmentRules block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EligibleAssignmentRules block(s) allowed")]
    public TerraformList<AzurermRoleManagementPolicyEligibleAssignmentRulesBlock>? EligibleAssignmentRules
    {
        get => GetArgument<TerraformList<AzurermRoleManagementPolicyEligibleAssignmentRulesBlock>>("eligible_assignment_rules");
        set => SetArgument("eligible_assignment_rules", value);
    }

    /// <summary>
    /// NotificationRules block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationRules block(s) allowed")]
    public TerraformList<AzurermRoleManagementPolicyNotificationRulesBlock>? NotificationRules
    {
        get => GetArgument<TerraformList<AzurermRoleManagementPolicyNotificationRulesBlock>>("notification_rules");
        set => SetArgument("notification_rules", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermRoleManagementPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermRoleManagementPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
