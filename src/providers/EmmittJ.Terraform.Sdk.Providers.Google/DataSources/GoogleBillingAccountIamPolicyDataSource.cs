using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_billing_account_iam_policy.
/// </summary>
public partial class GoogleBillingAccountIamPolicyDataSource : TerraformDataSource
{
    public GoogleBillingAccountIamPolicyDataSource(string name) : base("google_billing_account_iam_policy", name)
    {
    }

    /// <summary>
    /// The billing_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BillingAccountId is required")]
    [TerraformProperty("billing_account_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BillingAccountId { get; set; }

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
