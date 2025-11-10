using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for activation_rules in .
/// Nesting mode: list
/// </summary>
public class AzureadGroupRoleManagementPolicyActivationRulesBlock : TerraformBlock
{
    /// <summary>
    /// The time after which the an activation can be valid for
    /// </summary>
    public TerraformProperty<string>? MaximumDuration
    {
        get => GetProperty<TerraformProperty<string>>("maximum_duration");
        set => WithProperty("maximum_duration", value);
    }

    /// <summary>
    /// Whether an approval is required for activation
    /// </summary>
    public TerraformProperty<bool>? RequireApproval
    {
        get => GetProperty<TerraformProperty<bool>>("require_approval");
        set => WithProperty("require_approval", value);
    }

    /// <summary>
    /// Whether a justification is required during activation
    /// </summary>
    public TerraformProperty<bool>? RequireJustification
    {
        get => GetProperty<TerraformProperty<bool>>("require_justification");
        set => WithProperty("require_justification", value);
    }

    /// <summary>
    /// Whether multi-factor authentication is required during activation
    /// </summary>
    public TerraformProperty<bool>? RequireMultifactorAuthentication
    {
        get => GetProperty<TerraformProperty<bool>>("require_multifactor_authentication");
        set => WithProperty("require_multifactor_authentication", value);
    }

    /// <summary>
    /// Whether ticket information is required during activation
    /// </summary>
    public TerraformProperty<bool>? RequireTicketInfo
    {
        get => GetProperty<TerraformProperty<bool>>("require_ticket_info");
        set => WithProperty("require_ticket_info", value);
    }

    /// <summary>
    /// Whether a conditional access context is required during activation
    /// </summary>
    public TerraformProperty<string>? RequiredConditionalAccessAuthenticationContext
    {
        get => GetProperty<TerraformProperty<string>>("required_conditional_access_authentication_context");
        set => WithProperty("required_conditional_access_authentication_context", value);
    }

}

/// <summary>
/// Block type for active_assignment_rules in .
/// Nesting mode: list
/// </summary>
public class AzureadGroupRoleManagementPolicyActiveAssignmentRulesBlock : TerraformBlock
{
    /// <summary>
    /// Must the assignment have an expiry date
    /// </summary>
    public TerraformProperty<bool>? ExpirationRequired
    {
        get => GetProperty<TerraformProperty<bool>>("expiration_required");
        set => WithProperty("expiration_required", value);
    }

    /// <summary>
    /// The duration after which assignments expire
    /// </summary>
    public TerraformProperty<string>? ExpireAfter
    {
        get => GetProperty<TerraformProperty<string>>("expire_after");
        set => WithProperty("expire_after", value);
    }

    /// <summary>
    /// Whether a justification is required to make an assignment
    /// </summary>
    public TerraformProperty<bool>? RequireJustification
    {
        get => GetProperty<TerraformProperty<bool>>("require_justification");
        set => WithProperty("require_justification", value);
    }

    /// <summary>
    /// Whether multi-factor authentication is required to make an assignment
    /// </summary>
    public TerraformProperty<bool>? RequireMultifactorAuthentication
    {
        get => GetProperty<TerraformProperty<bool>>("require_multifactor_authentication");
        set => WithProperty("require_multifactor_authentication", value);
    }

    /// <summary>
    /// Whether ticket information is required to make an assignment
    /// </summary>
    public TerraformProperty<bool>? RequireTicketInfo
    {
        get => GetProperty<TerraformProperty<bool>>("require_ticket_info");
        set => WithProperty("require_ticket_info", value);
    }

}

/// <summary>
/// Block type for eligible_assignment_rules in .
/// Nesting mode: list
/// </summary>
public class AzureadGroupRoleManagementPolicyEligibleAssignmentRulesBlock : TerraformBlock
{
    /// <summary>
    /// Must the assignment have an expiry date
    /// </summary>
    public TerraformProperty<bool>? ExpirationRequired
    {
        get => GetProperty<TerraformProperty<bool>>("expiration_required");
        set => WithProperty("expiration_required", value);
    }

    /// <summary>
    /// The duration after which assignments expire
    /// </summary>
    public TerraformProperty<string>? ExpireAfter
    {
        get => GetProperty<TerraformProperty<string>>("expire_after");
        set => WithProperty("expire_after", value);
    }

}

/// <summary>
/// Block type for notification_rules in .
/// Nesting mode: list
/// </summary>
public class AzureadGroupRoleManagementPolicyNotificationRulesBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadGroupRoleManagementPolicyTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
/// Manages a azuread_group_role_management_policy resource.
/// </summary>
public class AzureadGroupRoleManagementPolicy : TerraformResource
{
    public AzureadGroupRoleManagementPolicy(string name) : base("azuread_group_role_management_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("description");
        this.DeclareOutput("display_name");
    }

    /// <summary>
    /// ID of the group to which this policy is assigned
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupId is required")]
    public required TerraformProperty<string> GroupId
    {
        get => GetProperty<TerraformProperty<string>>("group_id");
        set => this.WithProperty("group_id", value);
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
    /// The ID of the role of this policy to the group
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleId is required")]
    public required TerraformProperty<string> RoleId
    {
        get => GetProperty<TerraformProperty<string>>("role_id");
        set => this.WithProperty("role_id", value);
    }

    /// <summary>
    /// Block for activation_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActivationRules block(s) allowed")]
    public List<AzureadGroupRoleManagementPolicyActivationRulesBlock>? ActivationRules
    {
        get => GetProperty<List<AzureadGroupRoleManagementPolicyActivationRulesBlock>>("activation_rules");
        set => this.WithProperty("activation_rules", value);
    }

    /// <summary>
    /// Block for active_assignment_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveAssignmentRules block(s) allowed")]
    public List<AzureadGroupRoleManagementPolicyActiveAssignmentRulesBlock>? ActiveAssignmentRules
    {
        get => GetProperty<List<AzureadGroupRoleManagementPolicyActiveAssignmentRulesBlock>>("active_assignment_rules");
        set => this.WithProperty("active_assignment_rules", value);
    }

    /// <summary>
    /// Block for eligible_assignment_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EligibleAssignmentRules block(s) allowed")]
    public List<AzureadGroupRoleManagementPolicyEligibleAssignmentRulesBlock>? EligibleAssignmentRules
    {
        get => GetProperty<List<AzureadGroupRoleManagementPolicyEligibleAssignmentRulesBlock>>("eligible_assignment_rules");
        set => this.WithProperty("eligible_assignment_rules", value);
    }

    /// <summary>
    /// Block for notification_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationRules block(s) allowed")]
    public List<AzureadGroupRoleManagementPolicyNotificationRulesBlock>? NotificationRules
    {
        get => GetProperty<List<AzureadGroupRoleManagementPolicyNotificationRulesBlock>>("notification_rules");
        set => this.WithProperty("notification_rules", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadGroupRoleManagementPolicyTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzureadGroupRoleManagementPolicyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Description of the policy
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The display name of the policy
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

}
