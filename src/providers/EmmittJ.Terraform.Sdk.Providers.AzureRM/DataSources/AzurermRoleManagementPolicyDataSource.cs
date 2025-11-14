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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermRoleManagementPolicyDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_role_management_policy.
/// </summary>
public class AzurermRoleManagementPolicyDataSource : TerraformDataSource
{
    public AzurermRoleManagementPolicyDataSource(string name) : base("azurerm_role_management_policy", name)
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermRoleManagementPolicyDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The activation rules of the policy
    /// </summary>
    [TerraformArgument("activation_rules")]
    public TerraformList<object> ActivationRules
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "activation_rules").ResolveNodes(ctx));
    }

    /// <summary>
    /// The rules for active assignment of the policy
    /// </summary>
    [TerraformArgument("active_assignment_rules")]
    public TerraformList<object> ActiveAssignmentRules
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "active_assignment_rules").ResolveNodes(ctx));
    }

    /// <summary>
    /// The Description of the policy
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The rules for eligible assignment of the policy
    /// </summary>
    [TerraformArgument("eligible_assignment_rules")]
    public TerraformList<object> EligibleAssignmentRules
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "eligible_assignment_rules").ResolveNodes(ctx));
    }

    /// <summary>
    /// The name of the policy
    /// </summary>
    [TerraformArgument("name")]
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The notification rules of the policy
    /// </summary>
    [TerraformArgument("notification_rules")]
    public TerraformList<object> NotificationRules
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "notification_rules").ResolveNodes(ctx));
    }

}
