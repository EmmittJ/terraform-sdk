using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_cloud_quotas_quota_info.
/// </summary>
public class GoogleCloudQuotasQuotaInfoDataSource : TerraformDataSource
{
    public GoogleCloudQuotasQuotaInfoDataSource(string name) : base("google_cloud_quotas_quota_info", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The parent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformPropertyName("parent")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Parent { get; set; }

    /// <summary>
    /// The quota_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QuotaId is required")]
    [TerraformPropertyName("quota_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> QuotaId { get; set; }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformPropertyName("service")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Service { get; set; }

    /// <summary>
    /// The container_type attribute.
    /// </summary>
    [TerraformPropertyName("container_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ContainerType => new TerraformReference(this, "container_type");

    /// <summary>
    /// The dimensions attribute.
    /// </summary>
    [TerraformPropertyName("dimensions")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Dimensions => new TerraformReference(this, "dimensions");

    /// <summary>
    /// The dimensions_infos attribute.
    /// </summary>
    [TerraformPropertyName("dimensions_infos")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DimensionsInfos => new TerraformReference(this, "dimensions_infos");

    /// <summary>
    /// The is_concurrent attribute.
    /// </summary>
    [TerraformPropertyName("is_concurrent")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> IsConcurrent => new TerraformReference(this, "is_concurrent");

    /// <summary>
    /// The is_fixed attribute.
    /// </summary>
    [TerraformPropertyName("is_fixed")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> IsFixed => new TerraformReference(this, "is_fixed");

    /// <summary>
    /// The is_precise attribute.
    /// </summary>
    [TerraformPropertyName("is_precise")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> IsPrecise => new TerraformReference(this, "is_precise");

    /// <summary>
    /// The metric attribute.
    /// </summary>
    [TerraformPropertyName("metric")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Metric => new TerraformReference(this, "metric");

    /// <summary>
    /// The metric_display_name attribute.
    /// </summary>
    [TerraformPropertyName("metric_display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MetricDisplayName => new TerraformReference(this, "metric_display_name");

    /// <summary>
    /// The metric_unit attribute.
    /// </summary>
    [TerraformPropertyName("metric_unit")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MetricUnit => new TerraformReference(this, "metric_unit");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The quota_display_name attribute.
    /// </summary>
    [TerraformPropertyName("quota_display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> QuotaDisplayName => new TerraformReference(this, "quota_display_name");

    /// <summary>
    /// The quota_increase_eligibility attribute.
    /// </summary>
    [TerraformPropertyName("quota_increase_eligibility")]
    // Output-only attribute - read-only reference
    public TerraformList<object> QuotaIncreaseEligibility => new TerraformReference(this, "quota_increase_eligibility");

    /// <summary>
    /// The refresh_interval attribute.
    /// </summary>
    [TerraformPropertyName("refresh_interval")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RefreshInterval => new TerraformReference(this, "refresh_interval");

    /// <summary>
    /// The service_request_quota_uri attribute.
    /// </summary>
    [TerraformPropertyName("service_request_quota_uri")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceRequestQuotaUri => new TerraformReference(this, "service_request_quota_uri");

}
