using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for additional_notification_targets in GooglePrivilegedAccessManagerEntitlement.
/// Nesting mode: list
/// </summary>
public class GooglePrivilegedAccessManagerEntitlementAdditionalNotificationTargetsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "additional_notification_targets";

    /// <summary>
    /// Optional. Additional email addresses to be notified when a principal(requester) is granted access.
    /// </summary>
    public TerraformSet<string>? AdminEmailRecipients
    {
        get => GetArgument<TerraformSet<string>>("admin_email_recipients");
        set => SetArgument("admin_email_recipients", value);
    }

    /// <summary>
    /// Optional. Additional email address to be notified about an eligible entitlement.
    /// </summary>
    public TerraformSet<string>? RequesterEmailRecipients
    {
        get => GetArgument<TerraformSet<string>>("requester_email_recipients");
        set => SetArgument("requester_email_recipients", value);
    }

}


/// <summary>
/// Block type for approval_workflow in GooglePrivilegedAccessManagerEntitlement.
/// Nesting mode: list
/// </summary>
public class GooglePrivilegedAccessManagerEntitlementApprovalWorkflowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "approval_workflow";

    /// <summary>
    /// ManualApprovals block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManualApprovals is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ManualApprovals block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManualApprovals block(s) allowed")]
    public required TerraformList<GooglePrivilegedAccessManagerEntitlementApprovalWorkflowBlockManualApprovalsBlock> ManualApprovals
    {
        get => GetRequiredArgument<TerraformList<GooglePrivilegedAccessManagerEntitlementApprovalWorkflowBlockManualApprovalsBlock>>("manual_approvals");
        set => SetArgument("manual_approvals", value);
    }

}

/// <summary>
/// Block type for manual_approvals in GooglePrivilegedAccessManagerEntitlementApprovalWorkflowBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivilegedAccessManagerEntitlementApprovalWorkflowBlockManualApprovalsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "manual_approvals";

    /// <summary>
    /// Optional. Do the approvers need to provide a justification for their actions?
    /// </summary>
    public TerraformValue<bool>? RequireApproverJustification
    {
        get => GetArgument<TerraformValue<bool>>("require_approver_justification");
        set => SetArgument("require_approver_justification", value);
    }

    /// <summary>
    /// Steps block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Steps is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Steps block(s) required")]
    public required TerraformList<GooglePrivilegedAccessManagerEntitlementApprovalWorkflowBlockManualApprovalsBlockStepsBlock> Steps
    {
        get => GetRequiredArgument<TerraformList<GooglePrivilegedAccessManagerEntitlementApprovalWorkflowBlockManualApprovalsBlockStepsBlock>>("steps");
        set => SetArgument("steps", value);
    }

}

/// <summary>
/// Block type for steps in GooglePrivilegedAccessManagerEntitlementApprovalWorkflowBlockManualApprovalsBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivilegedAccessManagerEntitlementApprovalWorkflowBlockManualApprovalsBlockStepsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "steps";

    /// <summary>
    /// How many users from the above list need to approve.
    /// If there are not enough distinct users in the list above then the workflow
    /// will indefinitely block. Should always be greater than 0. Currently 1 is the only
    /// supported value.
    /// </summary>
    public TerraformValue<double>? ApprovalsNeeded
    {
        get => GetArgument<TerraformValue<double>>("approvals_needed");
        set => SetArgument("approvals_needed", value);
    }

    /// <summary>
    /// Optional. Additional email addresses to be notified when a grant is pending approval.
    /// </summary>
    public TerraformSet<string>? ApproverEmailRecipients
    {
        get => GetArgument<TerraformSet<string>>("approver_email_recipients");
        set => SetArgument("approver_email_recipients", value);
    }

    /// <summary>
    /// Approvers block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Approvers is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Approvers block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Approvers block(s) allowed")]
    public required TerraformList<GooglePrivilegedAccessManagerEntitlementApprovalWorkflowBlockManualApprovalsBlockStepsBlockApproversBlock> Approvers
    {
        get => GetRequiredArgument<TerraformList<GooglePrivilegedAccessManagerEntitlementApprovalWorkflowBlockManualApprovalsBlockStepsBlockApproversBlock>>("approvers");
        set => SetArgument("approvers", value);
    }

}

/// <summary>
/// Block type for approvers in GooglePrivilegedAccessManagerEntitlementApprovalWorkflowBlockManualApprovalsBlockStepsBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivilegedAccessManagerEntitlementApprovalWorkflowBlockManualApprovalsBlockStepsBlockApproversBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "approvers";

    /// <summary>
    /// Users who are being allowed for the operation. Each entry should be a valid v1 IAM Principal Identifier. Format for these is documented at: https://cloud.google.com/iam/docs/principal-identifiers#v1
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principals is required")]
    public required TerraformSet<string> Principals
    {
        get => GetRequiredArgument<TerraformSet<string>>("principals");
        set => SetArgument("principals", value);
    }

}


/// <summary>
/// Block type for eligible_users in GooglePrivilegedAccessManagerEntitlement.
/// Nesting mode: list
/// </summary>
public class GooglePrivilegedAccessManagerEntitlementEligibleUsersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "eligible_users";

    /// <summary>
    /// Users who are being allowed for the operation. Each entry should be a valid v1 IAM Principal Identifier. Format for these is documented at &amp;quot;https://cloud.google.com/iam/docs/principal-identifiers#v1&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principals is required")]
    public required TerraformSet<string> Principals
    {
        get => GetRequiredArgument<TerraformSet<string>>("principals");
        set => SetArgument("principals", value);
    }

}


/// <summary>
/// Block type for privileged_access in GooglePrivilegedAccessManagerEntitlement.
/// Nesting mode: list
/// </summary>
public class GooglePrivilegedAccessManagerEntitlementPrivilegedAccessBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "privileged_access";

    /// <summary>
    /// GcpIamAccess block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GcpIamAccess is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GcpIamAccess block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcpIamAccess block(s) allowed")]
    public required TerraformList<GooglePrivilegedAccessManagerEntitlementPrivilegedAccessBlockGcpIamAccessBlock> GcpIamAccess
    {
        get => GetRequiredArgument<TerraformList<GooglePrivilegedAccessManagerEntitlementPrivilegedAccessBlockGcpIamAccessBlock>>("gcp_iam_access");
        set => SetArgument("gcp_iam_access", value);
    }

}

/// <summary>
/// Block type for gcp_iam_access in GooglePrivilegedAccessManagerEntitlementPrivilegedAccessBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivilegedAccessManagerEntitlementPrivilegedAccessBlockGcpIamAccessBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcp_iam_access";

    /// <summary>
    /// Name of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resource is required")]
    public required TerraformValue<string> Resource
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource");
        set => SetArgument("resource", value);
    }

    /// <summary>
    /// The type of this resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypeAttribute is required")]
    public required TerraformValue<string> ResourceTypeAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_type");
        set => SetArgument("resource_type", value);
    }

    /// <summary>
    /// RoleBindings block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleBindings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RoleBindings block(s) required")]
    public required TerraformList<GooglePrivilegedAccessManagerEntitlementPrivilegedAccessBlockGcpIamAccessBlockRoleBindingsBlock> RoleBindings
    {
        get => GetRequiredArgument<TerraformList<GooglePrivilegedAccessManagerEntitlementPrivilegedAccessBlockGcpIamAccessBlockRoleBindingsBlock>>("role_bindings");
        set => SetArgument("role_bindings", value);
    }

}

/// <summary>
/// Block type for role_bindings in GooglePrivilegedAccessManagerEntitlementPrivilegedAccessBlockGcpIamAccessBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivilegedAccessManagerEntitlementPrivilegedAccessBlockGcpIamAccessBlockRoleBindingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "role_bindings";

    /// <summary>
    /// The expression field of the IAM condition to be associated with the role. If specified, a user with an active grant for this entitlement would be able to access the resource only if this condition evaluates to true for their request.
    /// https://cloud.google.com/iam/docs/conditions-overview#attributes.
    /// </summary>
    public TerraformValue<string>? ConditionExpression
    {
        get => GetArgument<TerraformValue<string>>("condition_expression");
        set => SetArgument("condition_expression", value);
    }

    /// <summary>
    /// IAM role to be granted. https://cloud.google.com/iam/docs/roles-overview.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    public required TerraformValue<string> Role
    {
        get => GetRequiredArgument<TerraformValue<string>>("role");
        set => SetArgument("role", value);
    }

}


/// <summary>
/// Block type for requester_justification_config in GooglePrivilegedAccessManagerEntitlement.
/// Nesting mode: list
/// </summary>
public class GooglePrivilegedAccessManagerEntitlementRequesterJustificationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "requester_justification_config";

    /// <summary>
    /// NotMandatory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotMandatory block(s) allowed")]
    public TerraformList<GooglePrivilegedAccessManagerEntitlementRequesterJustificationConfigBlockNotMandatoryBlock>? NotMandatory
    {
        get => GetArgument<TerraformList<GooglePrivilegedAccessManagerEntitlementRequesterJustificationConfigBlockNotMandatoryBlock>>("not_mandatory");
        set => SetArgument("not_mandatory", value);
    }

    /// <summary>
    /// Unstructured block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Unstructured block(s) allowed")]
    public TerraformList<GooglePrivilegedAccessManagerEntitlementRequesterJustificationConfigBlockUnstructuredBlock>? Unstructured
    {
        get => GetArgument<TerraformList<GooglePrivilegedAccessManagerEntitlementRequesterJustificationConfigBlockUnstructuredBlock>>("unstructured");
        set => SetArgument("unstructured", value);
    }

}

/// <summary>
/// Block type for not_mandatory in GooglePrivilegedAccessManagerEntitlementRequesterJustificationConfigBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivilegedAccessManagerEntitlementRequesterJustificationConfigBlockNotMandatoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "not_mandatory";

}

/// <summary>
/// Block type for unstructured in GooglePrivilegedAccessManagerEntitlementRequesterJustificationConfigBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivilegedAccessManagerEntitlementRequesterJustificationConfigBlockUnstructuredBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "unstructured";

}


/// <summary>
/// Block type for timeouts in GooglePrivilegedAccessManagerEntitlement.
/// Nesting mode: single
/// </summary>
public class GooglePrivilegedAccessManagerEntitlementTimeoutsBlock : TerraformBlock
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
/// Represents a google_privileged_access_manager_entitlement Terraform resource.
/// Manages a google_privileged_access_manager_entitlement resource.
/// </summary>
public partial class GooglePrivilegedAccessManagerEntitlement(string name) : TerraformResource("google_privileged_access_manager_entitlement", name)
{
    /// <summary>
    /// The ID to use for this Entitlement. This will become the last part of the resource name.
    /// This value should be 4-63 characters, and valid characters are &amp;quot;[a-z]&amp;quot;, &amp;quot;[0-9]&amp;quot;, and &amp;quot;-&amp;quot;. The first character should be from [a-z].
    /// This value should be unique among all other Entitlements under the specified &#39;parent&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntitlementId is required")]
    public required TerraformValue<string> EntitlementId
    {
        get => GetRequiredArgument<TerraformValue<string>>("entitlement_id");
        set => SetArgument("entitlement_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The region of the Entitlement resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The maximum amount of time for which access would be granted for a request.
    /// A requester can choose to ask for access for less than this duration but never more.
    /// Format: calculate the time in seconds and concatenate it with &#39;s&#39; i.e. 2 hours = &amp;quot;7200s&amp;quot;, 45 minutes = &amp;quot;2700s&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxRequestDuration is required")]
    public required TerraformValue<string> MaxRequestDuration
    {
        get => GetRequiredArgument<TerraformValue<string>>("max_request_duration");
        set => SetArgument("max_request_duration", value);
    }

    /// <summary>
    /// Format: projects/{project-id|project-number} or organizations/{organization-number} or folders/{folder-number}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformValue<string> Parent
    {
        get => GetRequiredArgument<TerraformValue<string>>("parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// Output only. Create time stamp. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// For Resource freshness validation (https://google.aip.dev/154)
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// Output Only. The entitlement&#39;s name follows a hierarchical structure, comprising the organization, folder, or project, alongside the region and a unique entitlement ID.
    /// Formats: organizations/{organization-number}/locations/{region}/entitlements/{entitlement-id}, folders/{folder-number}/locations/{region}/entitlements/{entitlement-id}, and projects/{project-id|project-number}/locations/{region}/entitlements/{entitlement-id}.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Output only. The current state of the Entitlement.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// Output only. Update time stamp. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// AdditionalNotificationTargets block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdditionalNotificationTargets block(s) allowed")]
    public TerraformList<GooglePrivilegedAccessManagerEntitlementAdditionalNotificationTargetsBlock>? AdditionalNotificationTargets
    {
        get => GetArgument<TerraformList<GooglePrivilegedAccessManagerEntitlementAdditionalNotificationTargetsBlock>>("additional_notification_targets");
        set => SetArgument("additional_notification_targets", value);
    }

    /// <summary>
    /// ApprovalWorkflow block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApprovalWorkflow block(s) allowed")]
    public TerraformList<GooglePrivilegedAccessManagerEntitlementApprovalWorkflowBlock>? ApprovalWorkflow
    {
        get => GetArgument<TerraformList<GooglePrivilegedAccessManagerEntitlementApprovalWorkflowBlock>>("approval_workflow");
        set => SetArgument("approval_workflow", value);
    }

    /// <summary>
    /// EligibleUsers block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EligibleUsers is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EligibleUsers block(s) required")]
    public required TerraformList<GooglePrivilegedAccessManagerEntitlementEligibleUsersBlock> EligibleUsers
    {
        get => GetRequiredArgument<TerraformList<GooglePrivilegedAccessManagerEntitlementEligibleUsersBlock>>("eligible_users");
        set => SetArgument("eligible_users", value);
    }

    /// <summary>
    /// PrivilegedAccess block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivilegedAccess is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PrivilegedAccess block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivilegedAccess block(s) allowed")]
    public required TerraformList<GooglePrivilegedAccessManagerEntitlementPrivilegedAccessBlock> PrivilegedAccess
    {
        get => GetRequiredArgument<TerraformList<GooglePrivilegedAccessManagerEntitlementPrivilegedAccessBlock>>("privileged_access");
        set => SetArgument("privileged_access", value);
    }

    /// <summary>
    /// RequesterJustificationConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RequesterJustificationConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RequesterJustificationConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RequesterJustificationConfig block(s) allowed")]
    public required TerraformList<GooglePrivilegedAccessManagerEntitlementRequesterJustificationConfigBlock> RequesterJustificationConfig
    {
        get => GetRequiredArgument<TerraformList<GooglePrivilegedAccessManagerEntitlementRequesterJustificationConfigBlock>>("requester_justification_config");
        set => SetArgument("requester_justification_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GooglePrivilegedAccessManagerEntitlementTimeoutsBlock? Timeouts
    {
        get => GetArgument<GooglePrivilegedAccessManagerEntitlementTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
