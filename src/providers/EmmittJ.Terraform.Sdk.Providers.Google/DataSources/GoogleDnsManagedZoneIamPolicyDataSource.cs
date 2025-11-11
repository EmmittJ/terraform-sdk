using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_dns_managed_zone_iam_policy.
/// </summary>
public partial class GoogleDnsManagedZoneIamPolicyDataSource : TerraformDataSource
{
    public GoogleDnsManagedZoneIamPolicyDataSource(string name) : base("google_dns_managed_zone_iam_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The managed_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedZone is required")]
    [TerraformProperty("managed_zone")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ManagedZone { get; set; }

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

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    [TerraformProperty("policy_data")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PolicyData { get; }

}
