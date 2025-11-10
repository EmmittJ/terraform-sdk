using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_healthcare_consent_store_iam_policy.
/// </summary>
public class GoogleHealthcareConsentStoreIamPolicyDataSource : TerraformDataSource
{
    public GoogleHealthcareConsentStoreIamPolicyDataSource(string name) : base("google_healthcare_consent_store_iam_policy", name)
    {
    }

    /// <summary>
    /// The consent_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsentStoreId is required")]
    [TerraformPropertyName("consent_store_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ConsentStoreId { get; set; }

    /// <summary>
    /// The dataset attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dataset is required")]
    [TerraformPropertyName("dataset")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Dataset { get; set; }

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
