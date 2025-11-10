using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_healthcare_dicom_store_iam_policy resource.
/// </summary>
public class GoogleHealthcareDicomStoreIamPolicy : TerraformResource
{
    public GoogleHealthcareDicomStoreIamPolicy(string name) : base("google_healthcare_dicom_store_iam_policy", name)
    {
    }

    /// <summary>
    /// The dicom_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DicomStoreId is required")]
    [TerraformPropertyName("dicom_store_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DicomStoreId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyData is required")]
    [TerraformPropertyName("policy_data")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PolicyData { get; set; }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Etag => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

}
