using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for activation_rules in AzureadGroupRoleManagementPolicy.
/// Nesting mode: list
/// </summary>
public class AzureadGroupRoleManagementPolicyActivationRulesBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("maximum_duration") ?? CreateReference("maximum_duration");
        set => SetArgument("maximum_duration", value);
    }

    /// <summary>
    /// Whether an approval is required for activation
    /// </summary>
    public TerraformValue<bool> RequireApproval
    {
        get => GetArgument<TerraformValue<bool>>("require_approval") ?? CreateReference("require_approval");
        set => SetArgument("require_approval", value);
    }

    /// <summary>
    /// Whether a justification is required during activation
    /// </summary>
    public TerraformValue<bool> RequireJustification
    {
        get => GetArgument<TerraformValue<bool>>("require_justification") ?? CreateReference("require_justification");
        set => SetArgument("require_justification", value);
    }

    /// <summary>
    /// Whether multi-factor authentication is required during activation
    /// </summary>
    public TerraformValue<bool> RequireMultifactorAuthentication
    {
        get => GetArgument<TerraformValue<bool>>("require_multifactor_authentication") ?? CreateReference("require_multifactor_authentication");
        set => SetArgument("require_multifactor_authentication", value);
    }

    /// <summary>
    /// Whether ticket information is required during activation
    /// </summary>
    public TerraformValue<bool> RequireTicketInfo
    {
        get => GetArgument<TerraformValue<bool>>("require_ticket_info") ?? CreateReference("require_ticket_info");
        set => SetArgument("require_ticket_info", value);
    }

    /// <summary>
    /// Whether a conditional access context is required during activation
    /// </summary>
    public TerraformValue<string> RequiredConditionalAccessAuthenticationContext
    {
        get => GetArgument<TerraformValue<string>>("required_conditional_access_authentication_context") ?? CreateReference("required_conditional_access_authentication_context");
        set => SetArgument("required_conditional_access_authentication_context", value);
    }

    /// <summary>
    /// ApprovalStage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApprovalStage block(s) allowed")]
    public TerraformList<AzureadGroupRoleManagementPolicyActivationRulesBlockApprovalStageBlock>? ApprovalStage
    {
        get => GetArgument<TerraformList<AzureadGroupRoleManagementPolicyActivationRulesBlockApprovalStageBlock>>("approval_stage");
        set => SetArgument("approval_stage", value);
    }

}

/// <summary>
/// Block type for approval_stage in AzureadGroupRoleManagementPolicyActivationRulesBlock.
/// Nesting mode: list
/// </summary>
public class AzureadGroupRoleManagementPolicyActivationRulesBlockApprovalStageBlock : TerraformBlock
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
    public required TerraformSet<AzureadGroupRoleManagementPolicyActivationRulesBlockApprovalStageBlockPrimaryApproverBlock> PrimaryApprover
    {
        get => GetRequiredArgument<TerraformSet<AzureadGroupRoleManagementPolicyActivationRulesBlockApprovalStageBlockPrimaryApproverBlock>>("primary_approver");
        set => SetArgument("primary_approver", value);
    }

}

/// <summary>
/// Block type for primary_approver in AzureadGroupRoleManagementPolicyActivationRulesBlockApprovalStageBlock.
/// Nesting mode: set
/// </summary>
public class AzureadGroupRoleManagementPolicyActivationRulesBlockApprovalStageBlockPrimaryApproverBlock : TerraformBlock
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
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for active_assignment_rules in AzureadGroupRoleManagementPolicy.
/// Nesting mode: list
/// </summary>
public class AzureadGroupRoleManagementPolicyActiveAssignmentRulesBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<bool>>("expiration_required") ?? CreateReference("expiration_required");
        set => SetArgument("expiration_required", value);
    }

    /// <summary>
    /// The duration after which assignments expire
    /// </summary>
    public TerraformValue<string> ExpireAfter
    {
        get => GetArgument<TerraformValue<string>>("expire_after") ?? CreateReference("expire_after");
        set => SetArgument("expire_after", value);
    }

    /// <summary>
    /// Whether a justification is required to make an assignment
    /// </summary>
    public TerraformValue<bool> RequireJustification
    {
        get => GetArgument<TerraformValue<bool>>("require_justification") ?? CreateReference("require_justification");
        set => SetArgument("require_justification", value);
    }

    /// <summary>
    /// Whether multi-factor authentication is required to make an assignment
    /// </summary>
    public TerraformValue<bool> RequireMultifactorAuthentication
    {
        get => GetArgument<TerraformValue<bool>>("require_multifactor_authentication") ?? CreateReference("require_multifactor_authentication");
        set => SetArgument("require_multifactor_authentication", value);
    }

    /// <summary>
    /// Whether ticket information is required to make an assignment
    /// </summary>
    public TerraformValue<bool> RequireTicketInfo
    {
        get => GetArgument<TerraformValue<bool>>("require_ticket_info") ?? CreateReference("require_ticket_info");
        set => SetArgument("require_ticket_info", value);
    }

}


/// <summary>
/// Block type for eligible_assignment_rules in AzureadGroupRoleManagementPolicy.
/// Nesting mode: list
/// </summary>
public class AzureadGroupRoleManagementPolicyEligibleAssignmentRulesBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<bool>>("expiration_required") ?? CreateReference("expiration_required");
        set => SetArgument("expiration_required", value);
    }

    /// <summary>
    /// The duration after which assignments expire
    /// </summary>
    public TerraformValue<string> ExpireAfter
    {
        get => GetArgument<TerraformValue<string>>("expire_after") ?? CreateReference("expire_after");
        set => SetArgument("expire_after", value);
    }

}


/// <summary>
/// Block type for notification_rules in AzureadGroupRoleManagementPolicy.
/// Nesting mode: list
/// </summary>
public class AzureadGroupRoleManagementPolicyNotificationRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notification_rules";

    /// <summary>
    /// ActiveAssignments block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveAssignments block(s) allowed")]
    public TerraformList<AzureadGroupRoleManagementPolicyNotificationRulesBlockActiveAssignmentsBlock>? ActiveAssignments
    {
        get => GetArgument<TerraformList<AzureadGroupRoleManagementPolicyNotificationRulesBlockActiveAssignmentsBlock>>("active_assignments");
        set => SetArgument("active_assignments", value);
    }

    /// <summary>
    /// EligibleActivations block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EligibleActivations block(s) allowed")]
    public TerraformList<AzureadGroupRoleManagementPolicyNotificationRulesBlockEligibleActivationsBlock>? EligibleActivations
    {
        get => GetArgument<TerraformList<AzureadGroupRoleManagementPolicyNotificationRulesBlockEligibleActivationsBlock>>("eligible_activations");
        set => SetArgument("eligible_activations", value);
    }

    /// <summary>
    /// EligibleAssignments block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EligibleAssignments block(s) allowed")]
    public TerraformList<AzureadGroupRoleManagementPolicyNotificationRulesBlockEligibleAssignmentsBlock>? EligibleAssignments
    {
        get => GetArgument<TerraformList<AzureadGroupRoleManagementPolicyNotificationRulesBlockEligibleAssignmentsBlock>>("eligible_assignments");
        set => SetArgument("eligible_assignments", value);
    }

}

/// <summary>
/// Block type for active_assignments in AzureadGroupRoleManagementPolicyNotificationRulesBlock.
/// Nesting mode: list
/// </summary>
public class AzureadGroupRoleManagementPolicyNotificationRulesBlockActiveAssignmentsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "active_assignments";

    /// <summary>
    /// AdminNotifications block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdminNotifications block(s) allowed")]
    public TerraformList<AzureadGroupRoleManagementPolicyNotificationRulesBlockActiveAssignmentsBlockAdminNotificationsBlock>? AdminNotifications
    {
        get => GetArgument<TerraformList<AzureadGroupRoleManagementPolicyNotificationRulesBlockActiveAssignmentsBlockAdminNotificationsBlock>>("admin_notifications");
        set => SetArgument("admin_notifications", value);
    }

    /// <summary>
    /// ApproverNotifications block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApproverNotifications block(s) allowed")]
    public TerraformList<AzureadGroupRoleManagementPolicyNotificationRulesBlockActiveAssignmentsBlockApproverNotificationsBlock>? ApproverNotifications
    {
        get => GetArgument<TerraformList<AzureadGroupRoleManagementPolicyNotificationRulesBlockActiveAssignmentsBlockApproverNotificationsBlock>>("approver_notifications");
        set => SetArgument("approver_notifications", value);
    }

    /// <summary>
    /// AssigneeNotifications block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AssigneeNotifications block(s) allowed")]
    public TerraformList<AzureadGroupRoleManagementPolicyNotificationRulesBlockActiveAssignmentsBlockAssigneeNotificationsBlock>? AssigneeNotifications
    {
        get => GetArgument<TerraformList<AzureadGroupRoleManagementPolicyNotificationRulesBlockActiveAssignmentsBlockAssigneeNotificationsBlock>>("assignee_notifications");
        set => SetArgument("assignee_notifications", value);
    }

}

/// <summary>
/// Block type for admin_notifications in AzureadGroupRoleManagementPolicyNotificationRulesBlockActiveAssignmentsBlock.
/// Nesting mode: list
/// </summary>
public class AzureadGroupRoleManagementPolicyNotificationRulesBlockActiveAssignmentsBlockAdminNotificationsBlock : TerraformBlock
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
        get => GetArgument<TerraformSet<string>>("additional_recipients") ?? CreateReference("additional_recipients");
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
/// Block type for approver_notifications in AzureadGroupRoleManagementPolicyNotificationRulesBlockActiveAssignmentsBlock.
/// Nesting mode: list
/// </summary>
public class AzureadGroupRoleManagementPolicyNotificationRulesBlockActiveAssignmentsBlockApproverNotificationsBlock : TerraformBlock
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
        get => GetArgument<TerraformSet<string>>("additional_recipients") ?? CreateReference("additional_recipients");
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
/// Block type for assignee_notifications in AzureadGroupRoleManagementPolicyNotificationRulesBlockActiveAssignmentsBlock.
/// Nesting mode: list
/// </summary>
public class AzureadGroupRoleManagementPolicyNotificationRulesBlockActiveAssignmentsBlockAssigneeNotificationsBlock : TerraformBlock
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
        get => GetArgument<TerraformSet<string>>("additional_recipients") ?? CreateReference("additional_recipients");
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
/// Block type for eligible_activations in AzureadGroupRoleManagementPolicyNotificationRulesBlock.
/// Nesting mode: list
/// </summary>
public class AzureadGroupRoleManagementPolicyNotificationRulesBlockEligibleActivationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "eligible_activations";

    /// <summary>
    /// AdminNotifications block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdminNotifications block(s) allowed")]
    public TerraformList<AzureadGroupRoleManagementPolicyNotificationRulesBlockEligibleActivationsBlockAdminNotificationsBlock>? AdminNotifications
    {
        get => GetArgument<TerraformList<AzureadGroupRoleManagementPolicyNotificationRulesBlockEligibleActivationsBlockAdminNotificationsBlock>>("admin_notifications");
        set => SetArgument("admin_notifications", value);
    }

    /// <summary>
    /// ApproverNotifications block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApproverNotifications block(s) allowed")]
    public TerraformList<AzureadGroupRoleManagementPolicyNotificationRulesBlockEligibleActivationsBlockApproverNotificationsBlock>? ApproverNotifications
    {
        get => GetArgument<TerraformList<AzureadGroupRoleManagementPolicyNotificationRulesBlockEligibleActivationsBlockApproverNotificationsBlock>>("approver_notifications");
        set => SetArgument("approver_notifications", value);
    }

    /// <summary>
    /// AssigneeNotifications block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AssigneeNotifications block(s) allowed")]
    public TerraformList<AzureadGroupRoleManagementPolicyNotificationRulesBlockEligibleActivationsBlockAssigneeNotificationsBlock>? AssigneeNotifications
    {
        get => GetArgument<TerraformList<AzureadGroupRoleManagementPolicyNotificationRulesBlockEligibleActivationsBlockAssigneeNotificationsBlock>>("assignee_notifications");
        set => SetArgument("assignee_notifications", value);
    }

}

/// <summary>
/// Block type for admin_notifications in AzureadGroupRoleManagementPolicyNotificationRulesBlockEligibleActivationsBlock.
/// Nesting mode: list
/// </summary>
public class AzureadGroupRoleManagementPolicyNotificationRulesBlockEligibleActivationsBlockAdminNotificationsBlock : TerraformBlock
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
        get => GetArgument<TerraformSet<string>>("additional_recipients") ?? CreateReference("additional_recipients");
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
/// Block type for approver_notifications in AzureadGroupRoleManagementPolicyNotificationRulesBlockEligibleActivationsBlock.
/// Nesting mode: list
/// </summary>
public class AzureadGroupRoleManagementPolicyNotificationRulesBlockEligibleActivationsBlockApproverNotificationsBlock : TerraformBlock
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
        get => GetArgument<TerraformSet<string>>("additional_recipients") ?? CreateReference("additional_recipients");
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
/// Block type for assignee_notifications in AzureadGroupRoleManagementPolicyNotificationRulesBlockEligibleActivationsBlock.
/// Nesting mode: list
/// </summary>
public class AzureadGroupRoleManagementPolicyNotificationRulesBlockEligibleActivationsBlockAssigneeNotificationsBlock : TerraformBlock
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
        get => GetArgument<TerraformSet<string>>("additional_recipients") ?? CreateReference("additional_recipients");
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
/// Block type for eligible_assignments in AzureadGroupRoleManagementPolicyNotificationRulesBlock.
/// Nesting mode: list
/// </summary>
public class AzureadGroupRoleManagementPolicyNotificationRulesBlockEligibleAssignmentsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "eligible_assignments";

    /// <summary>
    /// AdminNotifications block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdminNotifications block(s) allowed")]
    public TerraformList<AzureadGroupRoleManagementPolicyNotificationRulesBlockEligibleAssignmentsBlockAdminNotificationsBlock>? AdminNotifications
    {
        get => GetArgument<TerraformList<AzureadGroupRoleManagementPolicyNotificationRulesBlockEligibleAssignmentsBlockAdminNotificationsBlock>>("admin_notifications");
        set => SetArgument("admin_notifications", value);
    }

    /// <summary>
    /// ApproverNotifications block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApproverNotifications block(s) allowed")]
    public TerraformList<AzureadGroupRoleManagementPolicyNotificationRulesBlockEligibleAssignmentsBlockApproverNotificationsBlock>? ApproverNotifications
    {
        get => GetArgument<TerraformList<AzureadGroupRoleManagementPolicyNotificationRulesBlockEligibleAssignmentsBlockApproverNotificationsBlock>>("approver_notifications");
        set => SetArgument("approver_notifications", value);
    }

    /// <summary>
    /// AssigneeNotifications block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AssigneeNotifications block(s) allowed")]
    public TerraformList<AzureadGroupRoleManagementPolicyNotificationRulesBlockEligibleAssignmentsBlockAssigneeNotificationsBlock>? AssigneeNotifications
    {
        get => GetArgument<TerraformList<AzureadGroupRoleManagementPolicyNotificationRulesBlockEligibleAssignmentsBlockAssigneeNotificationsBlock>>("assignee_notifications");
        set => SetArgument("assignee_notifications", value);
    }

}

/// <summary>
/// Block type for admin_notifications in AzureadGroupRoleManagementPolicyNotificationRulesBlockEligibleAssignmentsBlock.
/// Nesting mode: list
/// </summary>
public class AzureadGroupRoleManagementPolicyNotificationRulesBlockEligibleAssignmentsBlockAdminNotificationsBlock : TerraformBlock
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
        get => GetArgument<TerraformSet<string>>("additional_recipients") ?? CreateReference("additional_recipients");
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
/// Block type for approver_notifications in AzureadGroupRoleManagementPolicyNotificationRulesBlockEligibleAssignmentsBlock.
/// Nesting mode: list
/// </summary>
public class AzureadGroupRoleManagementPolicyNotificationRulesBlockEligibleAssignmentsBlockApproverNotificationsBlock : TerraformBlock
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
        get => GetArgument<TerraformSet<string>>("additional_recipients") ?? CreateReference("additional_recipients");
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
/// Block type for assignee_notifications in AzureadGroupRoleManagementPolicyNotificationRulesBlockEligibleAssignmentsBlock.
/// Nesting mode: list
/// </summary>
public class AzureadGroupRoleManagementPolicyNotificationRulesBlockEligibleAssignmentsBlockAssigneeNotificationsBlock : TerraformBlock
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
        get => GetArgument<TerraformSet<string>>("additional_recipients") ?? CreateReference("additional_recipients");
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
/// Block type for timeouts in AzureadGroupRoleManagementPolicy.
/// Nesting mode: single
/// </summary>
public class AzureadGroupRoleManagementPolicyTimeoutsBlock : TerraformBlock
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
/// Represents a azuread_group_role_management_policy Terraform resource.
/// Manages a azuread_group_role_management_policy resource.
/// </summary>
public partial class AzureadGroupRoleManagementPolicy(string name) : TerraformResource("azuread_group_role_management_policy", name)
{
    /// <summary>
    /// ID of the group to which this policy is assigned
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupId is required")]
    public required TerraformValue<string> GroupId
    {
        get => GetRequiredArgument<TerraformValue<string>>("group_id");
        set => SetArgument("group_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ID of the role of this policy to the group
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleId is required")]
    public required TerraformValue<string> RoleId
    {
        get => GetRequiredArgument<TerraformValue<string>>("role_id");
        set => SetArgument("role_id", value);
    }

    /// <summary>
    /// Description of the policy
    /// </summary>
    public TerraformValue<string> Description
        => CreateReference("description");

    /// <summary>
    /// The display name of the policy
    /// </summary>
    public TerraformValue<string> DisplayName
        => CreateReference("display_name");

    /// <summary>
    /// ActivationRules block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActivationRules block(s) allowed")]
    public TerraformList<AzureadGroupRoleManagementPolicyActivationRulesBlock>? ActivationRules
    {
        get => GetArgument<TerraformList<AzureadGroupRoleManagementPolicyActivationRulesBlock>>("activation_rules");
        set => SetArgument("activation_rules", value);
    }

    /// <summary>
    /// ActiveAssignmentRules block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveAssignmentRules block(s) allowed")]
    public TerraformList<AzureadGroupRoleManagementPolicyActiveAssignmentRulesBlock>? ActiveAssignmentRules
    {
        get => GetArgument<TerraformList<AzureadGroupRoleManagementPolicyActiveAssignmentRulesBlock>>("active_assignment_rules");
        set => SetArgument("active_assignment_rules", value);
    }

    /// <summary>
    /// EligibleAssignmentRules block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EligibleAssignmentRules block(s) allowed")]
    public TerraformList<AzureadGroupRoleManagementPolicyEligibleAssignmentRulesBlock>? EligibleAssignmentRules
    {
        get => GetArgument<TerraformList<AzureadGroupRoleManagementPolicyEligibleAssignmentRulesBlock>>("eligible_assignment_rules");
        set => SetArgument("eligible_assignment_rules", value);
    }

    /// <summary>
    /// NotificationRules block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationRules block(s) allowed")]
    public TerraformList<AzureadGroupRoleManagementPolicyNotificationRulesBlock>? NotificationRules
    {
        get => GetArgument<TerraformList<AzureadGroupRoleManagementPolicyNotificationRulesBlock>>("notification_rules");
        set => SetArgument("notification_rules", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadGroupRoleManagementPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadGroupRoleManagementPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
