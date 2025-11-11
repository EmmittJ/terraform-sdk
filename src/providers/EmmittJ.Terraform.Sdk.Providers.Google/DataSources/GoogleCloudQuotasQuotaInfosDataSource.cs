using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_cloud_quotas_quota_infos.
/// </summary>
public partial class GoogleCloudQuotasQuotaInfosDataSource : TerraformDataSource
{
    public GoogleCloudQuotasQuotaInfosDataSource(string name) : base("google_cloud_quotas_quota_infos", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The parent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformProperty("parent")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Parent { get; set; }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformProperty("service")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Service { get; set; }

    /// <summary>
    /// The quota_infos attribute.
    /// </summary>
    [TerraformProperty("quota_infos")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> QuotaInfos { get; }

}
