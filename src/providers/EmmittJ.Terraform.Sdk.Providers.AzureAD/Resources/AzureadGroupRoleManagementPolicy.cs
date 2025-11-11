using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for activation_rules in .
/// Nesting mode: list
/// </summary>
public class AzureadGroupRoleManagementPolicyActivationRulesBlock
{
    /// <summary>
    /// The time after which the an activation can be valid for
    /// </summary>
    [TerraformPropertyName("maximum_duration")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MaximumDuration { get; set; } = default!;

    /// <summary>
    /// Whether an approval is required for activation
    /// </summary>
    [TerraformPropertyName("require_approval")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> RequireApproval { get; set; } = default!;

    /// <summary>
    /// Whether a justification is required during activation
    /// </summary>
    [TerraformPropertyName("require_justification")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> RequireJustification { get; set; } = default!;

    /// <summary>
    /// Whether multi-factor authentication is required during activation
    /// </summary>
    [TerraformPropertyName("require_multifactor_authentication")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> RequireMultifactorAuthentication { get; set; } = default!;

    /// <summary>
    /// Whether ticket information is required during activation
    /// </summary>
    [TerraformPropertyName("require_ticket_info")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> RequireTicketInfo { get; set; } = default!;

    /// <summary>
    /// Whether a conditional access context is required during activation
    /// </summary>
    [TerraformPropertyName("required_conditional_access_authentication_context")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RequiredConditionalAccessAuthenticationContext { get; set; } = default!;

}

/// <summary>
/// Block type for active_assignment_rules in .
/// Nesting mode: list
/// </summary>
public class AzureadGroupRoleManagementPolicyActiveAssignmentRulesBlock
{
    /// <summary>
    /// Must the assignment have an expiry date
    /// </summary>
    [TerraformPropertyName("expiration_required")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> ExpirationRequired { get; set; } = default!;

    /// <summary>
    /// The duration after which assignments expire
    /// </summary>
    [TerraformPropertyName("expire_after")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ExpireAfter { get; set; } = default!;

    /// <summary>
    /// Whether a justification is required to make an assignment
    /// </summary>
    [TerraformPropertyName("require_justification")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> RequireJustification { get; set; } = default!;

    /// <summary>
    /// Whether multi-factor authentication is required to make an assignment
    /// </summary>
    [TerraformPropertyName("require_multifactor_authentication")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> RequireMultifactorAuthentication { get; set; } = default!;

    /// <summary>
    /// Whether ticket information is required to make an assignment
    /// </summary>
    [TerraformPropertyName("require_ticket_info")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> RequireTicketInfo { get; set; } = default!;

}

/// <summary>
/// Block type for eligible_assignment_rules in .
/// Nesting mode: list
/// </summary>
public class AzureadGroupRoleManagementPolicyEligibleAssignmentRulesBlock
{
    /// <summary>
    /// Must the assignment have an expiry date
    /// </summary>
    [TerraformPropertyName("expiration_required")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> ExpirationRequired { get; set; } = default!;

    /// <summary>
    /// The duration after which assignments expire
    /// </summary>
    [TerraformPropertyName("expire_after")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ExpireAfter { get; set; } = default!;

}

/// <summary>
/// Block type for notification_rules in .
/// Nesting mode: list
/// </summary>
public class AzureadGroupRoleManagementPolicyNotificationRulesBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadGroupRoleManagementPolicyTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azuread_group_role_management_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzureadGroupRoleManagementPolicy : TerraformResource
{
    public AzureadGroupRoleManagementPolicy(string name) : base("azuread_group_role_management_policy", name)
    {
    }

    /// <summary>
    /// ID of the group to which this policy is assigned
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupId is required")]
    [TerraformPropertyName("group_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> GroupId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The ID of the role of this policy to the group
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleId is required")]
    [TerraformPropertyName("role_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RoleId { get; set; }

    /// <summary>
    /// Block for activation_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActivationRules block(s) allowed")]
    [TerraformPropertyName("activation_rules")]
    public TerraformList<TerraformBlock<AzureadGroupRoleManagementPolicyActivationRulesBlock>>? ActivationRules { get; set; }

    /// <summary>
    /// Block for active_assignment_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveAssignmentRules block(s) allowed")]
    [TerraformPropertyName("active_assignment_rules")]
    public TerraformList<TerraformBlock<AzureadGroupRoleManagementPolicyActiveAssignmentRulesBlock>>? ActiveAssignmentRules { get; set; }

    /// <summary>
    /// Block for eligible_assignment_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EligibleAssignmentRules block(s) allowed")]
    [TerraformPropertyName("eligible_assignment_rules")]
    public TerraformList<TerraformBlock<AzureadGroupRoleManagementPolicyEligibleAssignmentRulesBlock>>? EligibleAssignmentRules { get; set; }

    /// <summary>
    /// Block for notification_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationRules block(s) allowed")]
    [TerraformPropertyName("notification_rules")]
    public TerraformList<TerraformBlock<AzureadGroupRoleManagementPolicyNotificationRulesBlock>>? NotificationRules { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadGroupRoleManagementPolicyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Description of the policy
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The display name of the policy
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DisplayName => new TerraformReference(this, "display_name");

}
