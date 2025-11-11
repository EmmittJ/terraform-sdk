using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_storage_bucket_acl resource.
/// </summary>
public partial class GoogleStorageBucketAcl : TerraformResource
{
    public GoogleStorageBucketAcl(string name) : base("google_storage_bucket_acl", name)
    {
    }

    /// <summary>
    /// The name of the bucket it applies to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformProperty("bucket")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// Configure this ACL to be the default ACL.
    /// </summary>
    [TerraformProperty("default_acl")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DefaultAcl { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The canned GCS ACL to apply. Must be set if role_entity is not.
    /// </summary>
    [TerraformProperty("predefined_acl")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PredefinedAcl { get; set; }

    /// <summary>
    /// List of role/entity pairs in the form ROLE:entity. See GCS Bucket ACL documentation  for more details. Must be set if predefined_acl is not.
    /// </summary>
    [TerraformProperty("role_entity")]
    // Optional+Computed - source generator will implement get/set
    public TerraformList<string> RoleEntity { get; set; }

}
