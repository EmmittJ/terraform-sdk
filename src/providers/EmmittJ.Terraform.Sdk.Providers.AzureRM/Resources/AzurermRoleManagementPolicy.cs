using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

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
    [TerraformArgument("maximum_duration")]
    public TerraformValue<string> MaximumDuration
    {
        get => new TerraformReference<string>(this, "maximum_duration");
        set => SetArgument("maximum_duration", value);
    }

    /// <summary>
    /// Whether an approval is required for activation
    /// </summary>
    [TerraformArgument("require_approval")]
    public TerraformValue<bool> RequireApproval
    {
        get => new TerraformReference<bool>(this, "require_approval");
        set => SetArgument("require_approval", value);
    }

    /// <summary>
    /// Whether a justification is required during activation
    /// </summary>
    [TerraformArgument("require_justification")]
    public TerraformValue<bool> RequireJustification
    {
        get => new TerraformReference<bool>(this, "require_justification");
        set => SetArgument("require_justification", value);
    }

    /// <summary>
    /// Whether multi-factor authentication is required during activation
    /// </summary>
    [TerraformArgument("require_multifactor_authentication")]
    public TerraformValue<bool> RequireMultifactorAuthentication
    {
        get => new TerraformReference<bool>(this, "require_multifactor_authentication");
        set => SetArgument("require_multifactor_authentication", value);
    }

    /// <summary>
    /// Whether ticket information is required during activation
    /// </summary>
    [TerraformArgument("require_ticket_info")]
    public TerraformValue<bool> RequireTicketInfo
    {
        get => new TerraformReference<bool>(this, "require_ticket_info");
        set => SetArgument("require_ticket_info", value);
    }

    /// <summary>
    /// Whether a conditional access context is required during activation
    /// </summary>
    [TerraformArgument("required_conditional_access_authentication_context")]
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
    [TerraformArgument("expiration_required")]
    public TerraformValue<bool> ExpirationRequired
    {
        get => new TerraformReference<bool>(this, "expiration_required");
        set => SetArgument("expiration_required", value);
    }

    /// <summary>
    /// The duration after which assignments expire
    /// </summary>
    [TerraformArgument("expire_after")]
    public TerraformValue<string> ExpireAfter
    {
        get => new TerraformReference<string>(this, "expire_after");
        set => SetArgument("expire_after", value);
    }

    /// <summary>
    /// Whether a justification is required to make an assignment
    /// </summary>
    [TerraformArgument("require_justification")]
    public TerraformValue<bool> RequireJustification
    {
        get => new TerraformReference<bool>(this, "require_justification");
        set => SetArgument("require_justification", value);
    }

    /// <summary>
    /// Whether multi-factor authentication is required to make an assignment
    /// </summary>
    [TerraformArgument("require_multifactor_authentication")]
    public TerraformValue<bool> RequireMultifactorAuthentication
    {
        get => new TerraformReference<bool>(this, "require_multifactor_authentication");
        set => SetArgument("require_multifactor_authentication", value);
    }

    /// <summary>
    /// Whether ticket information is required to make an assignment
    /// </summary>
    [TerraformArgument("require_ticket_info")]
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
    [TerraformArgument("expiration_required")]
    public TerraformValue<bool> ExpirationRequired
    {
        get => new TerraformReference<bool>(this, "expiration_required");
        set => SetArgument("expiration_required", value);
    }

    /// <summary>
    /// The duration after which assignments expire
    /// </summary>
    [TerraformArgument("expire_after")]
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
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
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// ID of the Azure Role to which this policy is assigned
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleDefinitionId is required")]
    [TerraformArgument("role_definition_id")]
    public required TerraformValue<string> RoleDefinitionId
    {
        get => new TerraformReference<string>(this, "role_definition_id");
        set => SetArgument("role_definition_id", value);
    }

    /// <summary>
    /// The scope of the role to which this policy will apply
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformArgument("scope")]
    public required TerraformValue<string> Scope
    {
        get => new TerraformReference<string>(this, "scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// Block for activation_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActivationRules block(s) allowed")]
    [TerraformArgument("activation_rules")]
    public TerraformList<AzurermRoleManagementPolicyActivationRulesBlock> ActivationRules { get; set; } = new();

    /// <summary>
    /// Block for active_assignment_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveAssignmentRules block(s) allowed")]
    [TerraformArgument("active_assignment_rules")]
    public TerraformList<AzurermRoleManagementPolicyActiveAssignmentRulesBlock> ActiveAssignmentRules { get; set; } = new();

    /// <summary>
    /// Block for eligible_assignment_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EligibleAssignmentRules block(s) allowed")]
    [TerraformArgument("eligible_assignment_rules")]
    public TerraformList<AzurermRoleManagementPolicyEligibleAssignmentRulesBlock> EligibleAssignmentRules { get; set; } = new();

    /// <summary>
    /// Block for notification_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationRules block(s) allowed")]
    [TerraformArgument("notification_rules")]
    public TerraformList<AzurermRoleManagementPolicyNotificationRulesBlock> NotificationRules { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermRoleManagementPolicyTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The Description of the policy
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The name of the policy
    /// </summary>
    [TerraformArgument("name")]
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

}
