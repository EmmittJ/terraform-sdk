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
        set => SetProperty("maximum_duration", value);
    }

    /// <summary>
    /// Whether an approval is required for activation
    /// </summary>
    public TerraformProperty<bool>? RequireApproval
    {
        set => SetProperty("require_approval", value);
    }

    /// <summary>
    /// Whether a justification is required during activation
    /// </summary>
    public TerraformProperty<bool>? RequireJustification
    {
        set => SetProperty("require_justification", value);
    }

    /// <summary>
    /// Whether multi-factor authentication is required during activation
    /// </summary>
    public TerraformProperty<bool>? RequireMultifactorAuthentication
    {
        set => SetProperty("require_multifactor_authentication", value);
    }

    /// <summary>
    /// Whether ticket information is required during activation
    /// </summary>
    public TerraformProperty<bool>? RequireTicketInfo
    {
        set => SetProperty("require_ticket_info", value);
    }

    /// <summary>
    /// Whether a conditional access context is required during activation
    /// </summary>
    public TerraformProperty<string>? RequiredConditionalAccessAuthenticationContext
    {
        set => SetProperty("required_conditional_access_authentication_context", value);
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
        set => SetProperty("expiration_required", value);
    }

    /// <summary>
    /// The duration after which assignments expire
    /// </summary>
    public TerraformProperty<string>? ExpireAfter
    {
        set => SetProperty("expire_after", value);
    }

    /// <summary>
    /// Whether a justification is required to make an assignment
    /// </summary>
    public TerraformProperty<bool>? RequireJustification
    {
        set => SetProperty("require_justification", value);
    }

    /// <summary>
    /// Whether multi-factor authentication is required to make an assignment
    /// </summary>
    public TerraformProperty<bool>? RequireMultifactorAuthentication
    {
        set => SetProperty("require_multifactor_authentication", value);
    }

    /// <summary>
    /// Whether ticket information is required to make an assignment
    /// </summary>
    public TerraformProperty<bool>? RequireTicketInfo
    {
        set => SetProperty("require_ticket_info", value);
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
        set => SetProperty("expiration_required", value);
    }

    /// <summary>
    /// The duration after which assignments expire
    /// </summary>
    public TerraformProperty<string>? ExpireAfter
    {
        set => SetProperty("expire_after", value);
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
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
/// Manages a azuread_group_role_management_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzureadGroupRoleManagementPolicy : TerraformResource
{
    public AzureadGroupRoleManagementPolicy(string name) : base("azuread_group_role_management_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("group_id");
        SetOutput("id");
        SetOutput("role_id");
    }

    /// <summary>
    /// ID of the group to which this policy is assigned
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupId is required")]
    public required TerraformProperty<string> GroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("group_id");
        set => SetProperty("group_id", value);
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
    /// The ID of the role of this policy to the group
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleId is required")]
    public required TerraformProperty<string> RoleId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_id");
        set => SetProperty("role_id", value);
    }

    /// <summary>
    /// Block for activation_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActivationRules block(s) allowed")]
    public List<AzureadGroupRoleManagementPolicyActivationRulesBlock>? ActivationRules
    {
        set => SetProperty("activation_rules", value);
    }

    /// <summary>
    /// Block for active_assignment_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveAssignmentRules block(s) allowed")]
    public List<AzureadGroupRoleManagementPolicyActiveAssignmentRulesBlock>? ActiveAssignmentRules
    {
        set => SetProperty("active_assignment_rules", value);
    }

    /// <summary>
    /// Block for eligible_assignment_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EligibleAssignmentRules block(s) allowed")]
    public List<AzureadGroupRoleManagementPolicyEligibleAssignmentRulesBlock>? EligibleAssignmentRules
    {
        set => SetProperty("eligible_assignment_rules", value);
    }

    /// <summary>
    /// Block for notification_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationRules block(s) allowed")]
    public List<AzureadGroupRoleManagementPolicyNotificationRulesBlock>? NotificationRules
    {
        set => SetProperty("notification_rules", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadGroupRoleManagementPolicyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
