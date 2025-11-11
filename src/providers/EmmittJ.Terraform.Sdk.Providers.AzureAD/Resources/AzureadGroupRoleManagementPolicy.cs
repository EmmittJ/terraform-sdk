using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for activation_rules in .
/// Nesting mode: list
/// </summary>
public partial class AzureadGroupRoleManagementPolicyActivationRulesBlock : TerraformBlockBase
{
    /// <summary>
    /// The time after which the an activation can be valid for
    /// </summary>
    [TerraformProperty("maximum_duration")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> MaximumDuration { get; set; }

    /// <summary>
    /// Whether an approval is required for activation
    /// </summary>
    [TerraformProperty("require_approval")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> RequireApproval { get; set; }

    /// <summary>
    /// Whether a justification is required during activation
    /// </summary>
    [TerraformProperty("require_justification")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> RequireJustification { get; set; }

    /// <summary>
    /// Whether multi-factor authentication is required during activation
    /// </summary>
    [TerraformProperty("require_multifactor_authentication")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> RequireMultifactorAuthentication { get; set; }

    /// <summary>
    /// Whether ticket information is required during activation
    /// </summary>
    [TerraformProperty("require_ticket_info")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> RequireTicketInfo { get; set; }

    /// <summary>
    /// Whether a conditional access context is required during activation
    /// </summary>
    [TerraformProperty("required_conditional_access_authentication_context")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> RequiredConditionalAccessAuthenticationContext { get; set; }

}

/// <summary>
/// Block type for active_assignment_rules in .
/// Nesting mode: list
/// </summary>
public partial class AzureadGroupRoleManagementPolicyActiveAssignmentRulesBlock : TerraformBlockBase
{
    /// <summary>
    /// Must the assignment have an expiry date
    /// </summary>
    [TerraformProperty("expiration_required")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> ExpirationRequired { get; set; }

    /// <summary>
    /// The duration after which assignments expire
    /// </summary>
    [TerraformProperty("expire_after")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ExpireAfter { get; set; }

    /// <summary>
    /// Whether a justification is required to make an assignment
    /// </summary>
    [TerraformProperty("require_justification")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> RequireJustification { get; set; }

    /// <summary>
    /// Whether multi-factor authentication is required to make an assignment
    /// </summary>
    [TerraformProperty("require_multifactor_authentication")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> RequireMultifactorAuthentication { get; set; }

    /// <summary>
    /// Whether ticket information is required to make an assignment
    /// </summary>
    [TerraformProperty("require_ticket_info")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> RequireTicketInfo { get; set; }

}

/// <summary>
/// Block type for eligible_assignment_rules in .
/// Nesting mode: list
/// </summary>
public partial class AzureadGroupRoleManagementPolicyEligibleAssignmentRulesBlock : TerraformBlockBase
{
    /// <summary>
    /// Must the assignment have an expiry date
    /// </summary>
    [TerraformProperty("expiration_required")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> ExpirationRequired { get; set; }

    /// <summary>
    /// The duration after which assignments expire
    /// </summary>
    [TerraformProperty("expire_after")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ExpireAfter { get; set; }

}

/// <summary>
/// Block type for notification_rules in .
/// Nesting mode: list
/// </summary>
public partial class AzureadGroupRoleManagementPolicyNotificationRulesBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadGroupRoleManagementPolicyTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azuread_group_role_management_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzureadGroupRoleManagementPolicy : TerraformResource
{
    public AzureadGroupRoleManagementPolicy(string name) : base("azuread_group_role_management_policy", name)
    {
    }

    /// <summary>
    /// ID of the group to which this policy is assigned
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupId is required")]
    [TerraformProperty("group_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> GroupId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ID of the role of this policy to the group
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleId is required")]
    [TerraformProperty("role_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RoleId { get; set; }

    /// <summary>
    /// Block for activation_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActivationRules block(s) allowed")]
    [TerraformProperty("activation_rules")]
    public TerraformList<TerraformBlock<AzureadGroupRoleManagementPolicyActivationRulesBlock>>? ActivationRules { get; set; }

    /// <summary>
    /// Block for active_assignment_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveAssignmentRules block(s) allowed")]
    [TerraformProperty("active_assignment_rules")]
    public TerraformList<TerraformBlock<AzureadGroupRoleManagementPolicyActiveAssignmentRulesBlock>>? ActiveAssignmentRules { get; set; }

    /// <summary>
    /// Block for eligible_assignment_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EligibleAssignmentRules block(s) allowed")]
    [TerraformProperty("eligible_assignment_rules")]
    public TerraformList<TerraformBlock<AzureadGroupRoleManagementPolicyEligibleAssignmentRulesBlock>>? EligibleAssignmentRules { get; set; }

    /// <summary>
    /// Block for notification_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationRules block(s) allowed")]
    [TerraformProperty("notification_rules")]
    public TerraformList<TerraformBlock<AzureadGroupRoleManagementPolicyNotificationRulesBlock>>? NotificationRules { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzureadGroupRoleManagementPolicyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Description of the policy
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The display name of the policy
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DisplayName { get; }

}
