using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for permissions in .
/// Nesting mode: set
/// </summary>
public class AzureadCustomDirectoryRolePermissionsBlock
{
    /// <summary>
    /// Set of tasks that can be performed on a resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedResourceActions is required")]
    [TerraformPropertyName("allowed_resource_actions")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> AllowedResourceActions { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadCustomDirectoryRoleTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azuread_custom_directory_role resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzureadCustomDirectoryRole : TerraformResource
{
    public AzureadCustomDirectoryRole(string name) : base("azuread_custom_directory_role", name)
    {
    }

    /// <summary>
    /// The description of the custom directory role
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The display name of the custom directory role
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// Indicates whether the role is enabled for assignment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Custom template identifier that is typically used if one needs an identifier to be the same across different directories.
    /// </summary>
    [TerraformPropertyName("template_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> TemplateId { get; set; } = default!;

    /// <summary>
    /// The version of the role definition.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformPropertyName("version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Version { get; set; }

    /// <summary>
    /// Block for permissions.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permissions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Permissions block(s) required")]
    [TerraformPropertyName("permissions")]
    public TerraformSet<TerraformBlock<AzureadCustomDirectoryRolePermissionsBlock>>? Permissions { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadCustomDirectoryRoleTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The object ID of the directory role
    /// </summary>
    [TerraformPropertyName("object_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ObjectId => new TerraformReference(this, "object_id");

}
