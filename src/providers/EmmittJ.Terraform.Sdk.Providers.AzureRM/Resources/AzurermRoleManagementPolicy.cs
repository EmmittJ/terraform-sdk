using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for activation_rules in .
/// Nesting mode: list
/// </summary>
public class AzurermRoleManagementPolicyActivationRulesBlock : ITerraformBlock
{
    /// <summary>
    /// The time after which the an activation can be valid for
    /// </summary>
    [TerraformPropertyName("maximum_duration")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MaximumDuration { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "maximum_duration");

    /// <summary>
    /// Whether an approval is required for activation
    /// </summary>
    [TerraformPropertyName("require_approval")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> RequireApproval { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "require_approval");

    /// <summary>
    /// Whether a justification is required during activation
    /// </summary>
    [TerraformPropertyName("require_justification")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> RequireJustification { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "require_justification");

    /// <summary>
    /// Whether multi-factor authentication is required during activation
    /// </summary>
    [TerraformPropertyName("require_multifactor_authentication")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> RequireMultifactorAuthentication { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "require_multifactor_authentication");

    /// <summary>
    /// Whether ticket information is required during activation
    /// </summary>
    [TerraformPropertyName("require_ticket_info")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> RequireTicketInfo { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "require_ticket_info");

    /// <summary>
    /// Whether a conditional access context is required during activation
    /// </summary>
    [TerraformPropertyName("required_conditional_access_authentication_context")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RequiredConditionalAccessAuthenticationContext { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "required_conditional_access_authentication_context");

}

/// <summary>
/// Block type for active_assignment_rules in .
/// Nesting mode: list
/// </summary>
public class AzurermRoleManagementPolicyActiveAssignmentRulesBlock : ITerraformBlock
{
    /// <summary>
    /// Must the assignment have an expiry date
    /// </summary>
    [TerraformPropertyName("expiration_required")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> ExpirationRequired { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "expiration_required");

    /// <summary>
    /// The duration after which assignments expire
    /// </summary>
    [TerraformPropertyName("expire_after")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ExpireAfter { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "expire_after");

    /// <summary>
    /// Whether a justification is required to make an assignment
    /// </summary>
    [TerraformPropertyName("require_justification")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> RequireJustification { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "require_justification");

    /// <summary>
    /// Whether multi-factor authentication is required to make an assignment
    /// </summary>
    [TerraformPropertyName("require_multifactor_authentication")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> RequireMultifactorAuthentication { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "require_multifactor_authentication");

    /// <summary>
    /// Whether ticket information is required to make an assignment
    /// </summary>
    [TerraformPropertyName("require_ticket_info")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> RequireTicketInfo { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "require_ticket_info");

}

/// <summary>
/// Block type for eligible_assignment_rules in .
/// Nesting mode: list
/// </summary>
public class AzurermRoleManagementPolicyEligibleAssignmentRulesBlock : ITerraformBlock
{
    /// <summary>
    /// Must the assignment have an expiry date
    /// </summary>
    [TerraformPropertyName("expiration_required")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> ExpirationRequired { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "expiration_required");

    /// <summary>
    /// The duration after which assignments expire
    /// </summary>
    [TerraformPropertyName("expire_after")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ExpireAfter { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "expire_after");

}

/// <summary>
/// Block type for notification_rules in .
/// Nesting mode: list
/// </summary>
public class AzurermRoleManagementPolicyNotificationRulesBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermRoleManagementPolicyTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_role_management_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermRoleManagementPolicy : TerraformResource
{
    public AzurermRoleManagementPolicy(string name) : base("azurerm_role_management_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// ID of the Azure Role to which this policy is assigned
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleDefinitionId is required")]
    [TerraformPropertyName("role_definition_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleDefinitionId { get; set; }

    /// <summary>
    /// The scope of the role to which this policy will apply
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformPropertyName("scope")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Scope { get; set; }

    /// <summary>
    /// Block for activation_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActivationRules block(s) allowed")]
    [TerraformPropertyName("activation_rules")]
    public TerraformList<TerraformBlock<AzurermRoleManagementPolicyActivationRulesBlock>>? ActivationRules { get; set; } = new();

    /// <summary>
    /// Block for active_assignment_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveAssignmentRules block(s) allowed")]
    [TerraformPropertyName("active_assignment_rules")]
    public TerraformList<TerraformBlock<AzurermRoleManagementPolicyActiveAssignmentRulesBlock>>? ActiveAssignmentRules { get; set; } = new();

    /// <summary>
    /// Block for eligible_assignment_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EligibleAssignmentRules block(s) allowed")]
    [TerraformPropertyName("eligible_assignment_rules")]
    public TerraformList<TerraformBlock<AzurermRoleManagementPolicyEligibleAssignmentRulesBlock>>? EligibleAssignmentRules { get; set; } = new();

    /// <summary>
    /// Block for notification_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationRules block(s) allowed")]
    [TerraformPropertyName("notification_rules")]
    public TerraformList<TerraformBlock<AzurermRoleManagementPolicyNotificationRulesBlock>>? NotificationRules { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermRoleManagementPolicyTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The Description of the policy
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The name of the policy
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

}
