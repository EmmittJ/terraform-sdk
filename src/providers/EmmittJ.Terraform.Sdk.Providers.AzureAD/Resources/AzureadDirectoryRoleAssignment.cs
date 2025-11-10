using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadDirectoryRoleAssignmentTimeoutsBlock : ITerraformBlock
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

}

/// <summary>
/// Manages a azuread_directory_role_assignment resource.
/// </summary>
public class AzureadDirectoryRoleAssignment : TerraformResource
{
    public AzureadDirectoryRoleAssignment(string name) : base("azuread_directory_role_assignment", name)
    {
    }

    /// <summary>
    /// Identifier of the app-specific scope when the assignment scope is app-specific
    /// </summary>
    [TerraformPropertyName("app_scope_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AppScopeId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "app_scope_id");

    /// <summary>
    /// Identifier of the directory object representing the scope of the assignment
    /// </summary>
    [TerraformPropertyName("directory_scope_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DirectoryScopeId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "directory_scope_id");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The object ID of the member principal
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalObjectId is required")]
    [TerraformPropertyName("principal_object_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PrincipalObjectId { get; set; }

    /// <summary>
    /// The object ID of the directory role for this assignment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleId is required")]
    [TerraformPropertyName("role_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadDirectoryRoleAssignmentTimeoutsBlock>? Timeouts { get; set; } = new();

}
