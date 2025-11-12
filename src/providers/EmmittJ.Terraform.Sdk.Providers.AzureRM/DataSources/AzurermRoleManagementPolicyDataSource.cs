using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermRoleManagementPolicyDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_role_management_policy.
/// </summary>
public partial class AzurermRoleManagementPolicyDataSource : TerraformDataSource
{
    public AzurermRoleManagementPolicyDataSource(string name) : base("azurerm_role_management_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// ID of the Azure Role to which this policy is assigned
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleDefinitionId is required")]
    [TerraformProperty("role_definition_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleDefinitionId { get; set; }

    /// <summary>
    /// The scope of the role to which this policy will apply
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformProperty("scope")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Scope { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermRoleManagementPolicyDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The activation rules of the policy
    /// </summary>
    [TerraformProperty("activation_rules")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ActivationRules { get; }

    /// <summary>
    /// The rules for active assignment of the policy
    /// </summary>
    [TerraformProperty("active_assignment_rules")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ActiveAssignmentRules { get; }

    /// <summary>
    /// The Description of the policy
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The rules for eligible assignment of the policy
    /// </summary>
    [TerraformProperty("eligible_assignment_rules")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> EligibleAssignmentRules { get; }

    /// <summary>
    /// The name of the policy
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The notification rules of the policy
    /// </summary>
    [TerraformProperty("notification_rules")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> NotificationRules { get; }

}
