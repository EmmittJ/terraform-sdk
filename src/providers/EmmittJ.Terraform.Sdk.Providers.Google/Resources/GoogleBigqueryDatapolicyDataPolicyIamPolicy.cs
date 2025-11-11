using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_bigquery_datapolicy_data_policy_iam_policy resource.
/// </summary>
public partial class GoogleBigqueryDatapolicyDataPolicyIamPolicy : TerraformResource
{
    public GoogleBigqueryDatapolicyDataPolicyIamPolicy(string name) : base("google_bigquery_datapolicy_data_policy_iam_policy", name)
    {
    }

    /// <summary>
    /// The data_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataPolicyId is required")]
    [TerraformProperty("data_policy_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DataPolicyId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyData is required")]
    [TerraformProperty("policy_data")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PolicyData { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Etag { get; }

}
