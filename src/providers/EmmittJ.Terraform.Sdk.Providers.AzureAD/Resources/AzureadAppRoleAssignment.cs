using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadAppRoleAssignmentTimeoutsBlock
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

}

/// <summary>
/// Manages a azuread_app_role_assignment resource.
/// </summary>
public class AzureadAppRoleAssignment : TerraformResource
{
    public AzureadAppRoleAssignment(string name) : base("azuread_app_role_assignment", name)
    {
    }

    /// <summary>
    /// The ID of the app role to be assigned
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppRoleId is required")]
    [TerraformPropertyName("app_role_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AppRoleId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The object ID of the user, group or service principal to be assigned this app role
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalObjectId is required")]
    [TerraformPropertyName("principal_object_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PrincipalObjectId { get; set; }

    /// <summary>
    /// The object ID of the service principal representing the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceObjectId is required")]
    [TerraformPropertyName("resource_object_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceObjectId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadAppRoleAssignmentTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The display name of the principal to which the app role is assigned
    /// </summary>
    [TerraformPropertyName("principal_display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrincipalDisplayName => new TerraformReference(this, "principal_display_name");

    /// <summary>
    /// The object type of the principal to which the app role is assigned
    /// </summary>
    [TerraformPropertyName("principal_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrincipalType => new TerraformReference(this, "principal_type");

    /// <summary>
    /// The display name of the application representing the resource
    /// </summary>
    [TerraformPropertyName("resource_display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ResourceDisplayName => new TerraformReference(this, "resource_display_name");

}
