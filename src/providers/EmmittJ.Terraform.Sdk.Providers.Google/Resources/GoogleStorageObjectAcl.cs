using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_storage_object_acl resource.
/// </summary>
public partial class GoogleStorageObjectAcl : TerraformResource
{
    public GoogleStorageObjectAcl(string name) : base("google_storage_object_acl", name)
    {
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformProperty("bucket")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The object attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Object is required")]
    [TerraformProperty("object")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Object { get; set; }

    /// <summary>
    /// The predefined_acl attribute.
    /// </summary>
    [TerraformProperty("predefined_acl")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PredefinedAcl { get; set; }

    /// <summary>
    /// The role_entity attribute.
    /// </summary>
    [TerraformProperty("role_entity")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> RoleEntity { get; set; }

}
