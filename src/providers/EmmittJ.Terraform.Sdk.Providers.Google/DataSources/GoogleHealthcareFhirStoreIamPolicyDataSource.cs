using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_healthcare_fhir_store_iam_policy.
/// </summary>
public partial class GoogleHealthcareFhirStoreIamPolicyDataSource : TerraformDataSource
{
    public GoogleHealthcareFhirStoreIamPolicyDataSource(string name) : base("google_healthcare_fhir_store_iam_policy", name)
    {
    }

    /// <summary>
    /// The fhir_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FhirStoreId is required")]
    [TerraformProperty("fhir_store_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> FhirStoreId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Etag { get; }

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    [TerraformProperty("policy_data")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PolicyData { get; }

}
