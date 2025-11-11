using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadGroupRoleManagementPolicyDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_group_role_management_policy.
/// </summary>
public partial class AzureadGroupRoleManagementPolicyDataSource : TerraformDataSource
{
    public AzureadGroupRoleManagementPolicyDataSource(string name) : base("azuread_group_role_management_policy", name)
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzureadGroupRoleManagementPolicyDataSourceTimeoutsBlock>? Timeouts { get; set; }

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
