using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadDirectoryRoleAssignmentTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Manages a azuread_directory_role_assignment resource.
/// </summary>
public partial class AzureadDirectoryRoleAssignment : TerraformResource
{
    public AzureadDirectoryRoleAssignment(string name) : base("azuread_directory_role_assignment", name)
    {
    }

    /// <summary>
    /// Identifier of the app-specific scope when the assignment scope is app-specific
    /// </summary>
    [TerraformProperty("app_scope_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AppScopeId { get; set; }

    /// <summary>
    /// Identifier of the directory object representing the scope of the assignment
    /// </summary>
    [TerraformProperty("directory_scope_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DirectoryScopeId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The object ID of the member principal
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalObjectId is required")]
    [TerraformProperty("principal_object_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PrincipalObjectId { get; set; }

    /// <summary>
    /// The object ID of the directory role for this assignment
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
    public TerraformBlock<AzureadDirectoryRoleAssignmentTimeoutsBlock>? Timeouts { get; set; }

}
