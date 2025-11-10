using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermRoleManagementPolicyDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermRoleManagementPolicyDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The activation rules of the policy
    /// </summary>
    [TerraformPropertyName("activation_rules")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ActivationRules => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "activation_rules");

    /// <summary>
    /// The rules for active assignment of the policy
    /// </summary>
    [TerraformPropertyName("active_assignment_rules")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ActiveAssignmentRules => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "active_assignment_rules");

    /// <summary>
    /// The Description of the policy
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The rules for eligible assignment of the policy
    /// </summary>
    [TerraformPropertyName("eligible_assignment_rules")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EligibleAssignmentRules => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "eligible_assignment_rules");

    /// <summary>
    /// The name of the policy
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The notification rules of the policy
    /// </summary>
    [TerraformPropertyName("notification_rules")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> NotificationRules => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "notification_rules");

}
