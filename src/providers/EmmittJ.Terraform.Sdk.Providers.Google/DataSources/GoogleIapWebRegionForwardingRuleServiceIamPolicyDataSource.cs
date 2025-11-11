using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_iap_web_region_forwarding_rule_service_iam_policy.
/// </summary>
public partial class GoogleIapWebRegionForwardingRuleServiceIamPolicyDataSource : TerraformDataSource
{
    public GoogleIapWebRegionForwardingRuleServiceIamPolicyDataSource(string name) : base("google_iap_web_region_forwarding_rule_service_iam_policy", name)
    {
    }

    /// <summary>
    /// The forwarding_rule_region_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ForwardingRuleRegionServiceName is required")]
    [TerraformProperty("forwarding_rule_region_service_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ForwardingRuleRegionServiceName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

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
