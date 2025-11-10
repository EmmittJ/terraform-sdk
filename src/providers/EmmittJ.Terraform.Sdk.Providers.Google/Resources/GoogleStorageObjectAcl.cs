using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_storage_object_acl resource.
/// </summary>
public class GoogleStorageObjectAcl : TerraformResource
{
    public GoogleStorageObjectAcl(string name) : base("google_storage_object_acl", name)
    {
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformPropertyName("bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Bucket { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The object attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Object is required")]
    [TerraformPropertyName("object")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Object { get; set; }

    /// <summary>
    /// The predefined_acl attribute.
    /// </summary>
    [TerraformPropertyName("predefined_acl")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PredefinedAcl { get; set; }

    /// <summary>
    /// The role_entity attribute.
    /// </summary>
    [TerraformPropertyName("role_entity")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> RoleEntity { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "role_entity");

}
