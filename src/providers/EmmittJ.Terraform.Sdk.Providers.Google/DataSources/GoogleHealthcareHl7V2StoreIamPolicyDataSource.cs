using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_healthcare_hl7_v2_store_iam_policy.
/// </summary>
public partial class GoogleHealthcareHl7V2StoreIamPolicyDataSource : TerraformDataSource
{
    public GoogleHealthcareHl7V2StoreIamPolicyDataSource(string name) : base("google_healthcare_hl7_v2_store_iam_policy", name)
    {
    }

    /// <summary>
    /// The hl7_v2_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hl7V2StoreId is required")]
    [TerraformProperty("hl7_v2_store_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Hl7V2StoreId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    [TerraformProperty("policy_data")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PolicyData { get; }

}
