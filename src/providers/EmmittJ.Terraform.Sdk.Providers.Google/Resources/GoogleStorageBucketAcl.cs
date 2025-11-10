using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_storage_bucket_acl resource.
/// </summary>
public class GoogleStorageBucketAcl : TerraformResource
{
    public GoogleStorageBucketAcl(string name) : base("google_storage_bucket_acl", name)
    {
    }

    /// <summary>
    /// The name of the bucket it applies to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformPropertyName("bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Bucket { get; set; }

    /// <summary>
    /// Configure this ACL to be the default ACL.
    /// </summary>
    [TerraformPropertyName("default_acl")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DefaultAcl { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The canned GCS ACL to apply. Must be set if role_entity is not.
    /// </summary>
    [TerraformPropertyName("predefined_acl")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PredefinedAcl { get; set; }

    /// <summary>
    /// List of role/entity pairs in the form ROLE:entity. See GCS Bucket ACL documentation  for more details. Must be set if predefined_acl is not.
    /// </summary>
    [TerraformPropertyName("role_entity")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> RoleEntity { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "role_entity");

}
