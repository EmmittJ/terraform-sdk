using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_folder_iam_policy.
/// </summary>
public class GoogleFolderIamPolicyDataSource : TerraformDataSource
{
    public GoogleFolderIamPolicyDataSource(string name) : base("google_folder_iam_policy", name)
    {
    }

    /// <summary>
    /// The folder attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Folder is required")]
    [TerraformPropertyName("folder")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Folder { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Etag => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    [TerraformPropertyName("policy_data")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PolicyData => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "policy_data");

}
