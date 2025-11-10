using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for activation_rules in .
/// Nesting mode: list
/// </summary>
public class AzurermRoleManagementPolicyActivationRulesBlock : TerraformBlock
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
public class AzurermRoleManagementPolicyActiveAssignmentRulesBlock : TerraformBlock
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
public class AzurermRoleManagementPolicyEligibleAssignmentRulesBlock : TerraformBlock
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
public class AzurermRoleManagementPolicyNotificationRulesBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermRoleManagementPolicyTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_role_management_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermRoleManagementPolicy : TerraformResource
{
    public AzurermRoleManagementPolicy(string name) : base("azurerm_role_management_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("description");
        SetOutput("name");
        SetOutput("id");
        SetOutput("role_definition_id");
        SetOutput("scope");
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
    /// ID of the Azure Role to which this policy is assigned
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleDefinitionId is required")]
    public required TerraformProperty<string> RoleDefinitionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_definition_id");
        set => SetProperty("role_definition_id", value);
    }

    /// <summary>
    /// The scope of the role to which this policy will apply
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformProperty<string> Scope
    {
        get => GetRequiredOutput<TerraformProperty<string>>("scope");
        set => SetProperty("scope", value);
    }

    /// <summary>
    /// Block for activation_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActivationRules block(s) allowed")]
    public List<AzurermRoleManagementPolicyActivationRulesBlock>? ActivationRules
    {
        set => SetProperty("activation_rules", value);
    }

    /// <summary>
    /// Block for active_assignment_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveAssignmentRules block(s) allowed")]
    public List<AzurermRoleManagementPolicyActiveAssignmentRulesBlock>? ActiveAssignmentRules
    {
        set => SetProperty("active_assignment_rules", value);
    }

    /// <summary>
    /// Block for eligible_assignment_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EligibleAssignmentRules block(s) allowed")]
    public List<AzurermRoleManagementPolicyEligibleAssignmentRulesBlock>? EligibleAssignmentRules
    {
        set => SetProperty("eligible_assignment_rules", value);
    }

    /// <summary>
    /// Block for notification_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationRules block(s) allowed")]
    public List<AzurermRoleManagementPolicyNotificationRulesBlock>? NotificationRules
    {
        set => SetProperty("notification_rules", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermRoleManagementPolicyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The Description of the policy
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The name of the policy
    /// </summary>
    public TerraformExpression Name => this["name"];

}
