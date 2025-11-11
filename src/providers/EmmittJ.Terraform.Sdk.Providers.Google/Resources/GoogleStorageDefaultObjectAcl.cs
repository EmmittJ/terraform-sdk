using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_storage_default_object_acl resource.
/// </summary>
public class GoogleStorageDefaultObjectAcl : TerraformResource
{
    public GoogleStorageDefaultObjectAcl(string name) : base("google_storage_default_object_acl", name)
    {
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformPropertyName("bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The role_entity attribute.
    /// </summary>
    [TerraformPropertyName("role_entity")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> RoleEntity { get; set; } = default!;

}
