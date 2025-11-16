using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for activation_rules in .
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
        get => new TerraformReference<string>(this, "maximum_duration");
        set => SetArgument("maximum_duration", value);
    }

    /// <summary>
    /// Whether an approval is required for activation
    /// </summary>
    public TerraformValue<bool> RequireApproval
    {
        get => new TerraformReference<bool>(this, "require_approval");
        set => SetArgument("require_approval", value);
    }

    /// <summary>
    /// Whether a justification is required during activation
    /// </summary>
    public TerraformValue<bool> RequireJustification
    {
        get => new TerraformReference<bool>(this, "require_justification");
        set => SetArgument("require_justification", value);
    }

    /// <summary>
    /// Whether multi-factor authentication is required during activation
    /// </summary>
    public TerraformValue<bool> RequireMultifactorAuthentication
    {
        get => new TerraformReference<bool>(this, "require_multifactor_authentication");
        set => SetArgument("require_multifactor_authentication", value);
    }

    /// <summary>
    /// Whether ticket information is required during activation
    /// </summary>
    public TerraformValue<bool> RequireTicketInfo
    {
        get => new TerraformReference<bool>(this, "require_ticket_info");
        set => SetArgument("require_ticket_info", value);
    }

    /// <summary>
    /// Whether a conditional access context is required during activation
    /// </summary>
    public TerraformValue<string> RequiredConditionalAccessAuthenticationContext
    {
        get => new TerraformReference<string>(this, "required_conditional_access_authentication_context");
        set => SetArgument("required_conditional_access_authentication_context", value);
    }

}

/// <summary>
/// Block type for active_assignment_rules in .
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
        get => new TerraformReference<bool>(this, "expiration_required");
        set => SetArgument("expiration_required", value);
    }

    /// <summary>
    /// The duration after which assignments expire
    /// </summary>
    public TerraformValue<string> ExpireAfter
    {
        get => new TerraformReference<string>(this, "expire_after");
        set => SetArgument("expire_after", value);
    }

    /// <summary>
    /// Whether a justification is required to make an assignment
    /// </summary>
    public TerraformValue<bool> RequireJustification
    {
        get => new TerraformReference<bool>(this, "require_justification");
        set => SetArgument("require_justification", value);
    }

    /// <summary>
    /// Whether multi-factor authentication is required to make an assignment
    /// </summary>
    public TerraformValue<bool> RequireMultifactorAuthentication
    {
        get => new TerraformReference<bool>(this, "require_multifactor_authentication");
        set => SetArgument("require_multifactor_authentication", value);
    }

    /// <summary>
    /// Whether ticket information is required to make an assignment
    /// </summary>
    public TerraformValue<bool> RequireTicketInfo
    {
        get => new TerraformReference<bool>(this, "require_ticket_info");
        set => SetArgument("require_ticket_info", value);
    }

}

/// <summary>
/// Block type for eligible_assignment_rules in .
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
        get => new TerraformReference<bool>(this, "expiration_required");
        set => SetArgument("expiration_required", value);
    }

    /// <summary>
    /// The duration after which assignments expire
    /// </summary>
    public TerraformValue<string> ExpireAfter
    {
        get => new TerraformReference<string>(this, "expire_after");
        set => SetArgument("expire_after", value);
    }

}

/// <summary>
/// Block type for notification_rules in .
/// Nesting mode: list
/// </summary>
public class AzurermRoleManagementPolicyNotificationRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notification_rules";

}

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// ID of the Azure Role to which this policy is assigned
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleDefinitionId is required")]
    public required TerraformValue<string> RoleDefinitionId
    {
        get => new TerraformReference<string>(this, "role_definition_id");
        set => SetArgument("role_definition_id", value);
    }

    /// <summary>
    /// The scope of the role to which this policy will apply
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformValue<string> Scope
    {
        get => new TerraformReference<string>(this, "scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// ActivationRules block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActivationRules block(s) allowed")]
    public AzurermRoleManagementPolicyActivationRulesBlock? ActivationRules
    {
        get => GetArgument<AzurermRoleManagementPolicyActivationRulesBlock>("activation_rules");
        set => SetArgument("activation_rules", value);
    }

    /// <summary>
    /// ActiveAssignmentRules block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveAssignmentRules block(s) allowed")]
    public AzurermRoleManagementPolicyActiveAssignmentRulesBlock? ActiveAssignmentRules
    {
        get => GetArgument<AzurermRoleManagementPolicyActiveAssignmentRulesBlock>("active_assignment_rules");
        set => SetArgument("active_assignment_rules", value);
    }

    /// <summary>
    /// EligibleAssignmentRules block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EligibleAssignmentRules block(s) allowed")]
    public AzurermRoleManagementPolicyEligibleAssignmentRulesBlock? EligibleAssignmentRules
    {
        get => GetArgument<AzurermRoleManagementPolicyEligibleAssignmentRulesBlock>("eligible_assignment_rules");
        set => SetArgument("eligible_assignment_rules", value);
    }

    /// <summary>
    /// NotificationRules block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationRules block(s) allowed")]
    public AzurermRoleManagementPolicyNotificationRulesBlock? NotificationRules
    {
        get => GetArgument<AzurermRoleManagementPolicyNotificationRulesBlock>("notification_rules");
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
