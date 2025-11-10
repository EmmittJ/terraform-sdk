using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadAppRoleAssignmentTimeoutsBlock : ITerraformBlock
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
    public required TerraformProperty<TerraformProperty<string>> AppRoleId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The object ID of the user, group or service principal to be assigned this app role
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalObjectId is required")]
    [TerraformPropertyName("principal_object_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PrincipalObjectId { get; set; }

    /// <summary>
    /// The object ID of the service principal representing the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceObjectId is required")]
    [TerraformPropertyName("resource_object_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceObjectId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadAppRoleAssignmentTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The display name of the principal to which the app role is assigned
    /// </summary>
    [TerraformPropertyName("principal_display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrincipalDisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "principal_display_name");

    /// <summary>
    /// The object type of the principal to which the app role is assigned
    /// </summary>
    [TerraformPropertyName("principal_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrincipalType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "principal_type");

    /// <summary>
    /// The display name of the application representing the resource
    /// </summary>
    [TerraformPropertyName("resource_display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ResourceDisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "resource_display_name");

}
