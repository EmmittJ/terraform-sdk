using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_cloud_quotas_quota_info.
/// </summary>
public partial class GoogleCloudQuotasQuotaInfoDataSource : TerraformDataSource
{
    public GoogleCloudQuotasQuotaInfoDataSource(string name) : base("google_cloud_quotas_quota_info", name)
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
    /// The quota_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QuotaId is required")]
    [TerraformProperty("quota_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> QuotaId { get; set; }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformProperty("service")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Service { get; set; }

    /// <summary>
    /// The container_type attribute.
    /// </summary>
    [TerraformProperty("container_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ContainerType { get; }

    /// <summary>
    /// The dimensions attribute.
    /// </summary>
    [TerraformProperty("dimensions")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Dimensions { get; }

    /// <summary>
    /// The dimensions_infos attribute.
    /// </summary>
    [TerraformProperty("dimensions_infos")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> DimensionsInfos { get; }

    /// <summary>
    /// The is_concurrent attribute.
    /// </summary>
    [TerraformProperty("is_concurrent")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> IsConcurrent { get; }

    /// <summary>
    /// The is_fixed attribute.
    /// </summary>
    [TerraformProperty("is_fixed")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> IsFixed { get; }

    /// <summary>
    /// The is_precise attribute.
    /// </summary>
    [TerraformProperty("is_precise")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> IsPrecise { get; }

    /// <summary>
    /// The metric attribute.
    /// </summary>
    [TerraformProperty("metric")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Metric { get; }

    /// <summary>
    /// The metric_display_name attribute.
    /// </summary>
    [TerraformProperty("metric_display_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MetricDisplayName { get; }

    /// <summary>
    /// The metric_unit attribute.
    /// </summary>
    [TerraformProperty("metric_unit")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MetricUnit { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The quota_display_name attribute.
    /// </summary>
    [TerraformProperty("quota_display_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> QuotaDisplayName { get; }

    /// <summary>
    /// The quota_increase_eligibility attribute.
    /// </summary>
    [TerraformProperty("quota_increase_eligibility")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> QuotaIncreaseEligibility { get; }

    /// <summary>
    /// The refresh_interval attribute.
    /// </summary>
    [TerraformProperty("refresh_interval")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RefreshInterval { get; }

    /// <summary>
    /// The service_request_quota_uri attribute.
    /// </summary>
    [TerraformProperty("service_request_quota_uri")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServiceRequestQuotaUri { get; }

}
