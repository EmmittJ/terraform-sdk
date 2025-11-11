using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermRoleAssignmentsDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_role_assignments.
/// </summary>
public partial class AzurermRoleAssignmentsDataSource : TerraformDataSource
{
    public AzurermRoleAssignmentsDataSource(string name) : base("azurerm_role_assignments", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The limit_at_scope attribute.
    /// </summary>
    [TerraformProperty("limit_at_scope")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? LimitAtScope { get; set; }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [TerraformProperty("principal_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PrincipalId { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformProperty("scope")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Scope { get; set; }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformProperty("tenant_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TenantId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermRoleAssignmentsDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The role_assignments attribute.
    /// </summary>
    [TerraformProperty("role_assignments")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> RoleAssignments { get; }

}
