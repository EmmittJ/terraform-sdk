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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The parent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformPropertyName("parent")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Parent { get; set; }

    /// <summary>
    /// The quota_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QuotaId is required")]
    [TerraformPropertyName("quota_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> QuotaId { get; set; }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformPropertyName("service")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Service { get; set; }

    /// <summary>
    /// The container_type attribute.
    /// </summary>
    [TerraformPropertyName("container_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ContainerType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "container_type");

    /// <summary>
    /// The dimensions attribute.
    /// </summary>
    [TerraformPropertyName("dimensions")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Dimensions => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "dimensions");

    /// <summary>
    /// The dimensions_infos attribute.
    /// </summary>
    [TerraformPropertyName("dimensions_infos")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DimensionsInfos => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "dimensions_infos");

    /// <summary>
    /// The is_concurrent attribute.
    /// </summary>
    [TerraformPropertyName("is_concurrent")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> IsConcurrent => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "is_concurrent");

    /// <summary>
    /// The is_fixed attribute.
    /// </summary>
    [TerraformPropertyName("is_fixed")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> IsFixed => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "is_fixed");

    /// <summary>
    /// The is_precise attribute.
    /// </summary>
    [TerraformPropertyName("is_precise")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> IsPrecise => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "is_precise");

    /// <summary>
    /// The metric attribute.
    /// </summary>
    [TerraformPropertyName("metric")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Metric => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "metric");

    /// <summary>
    /// The metric_display_name attribute.
    /// </summary>
    [TerraformPropertyName("metric_display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MetricDisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "metric_display_name");

    /// <summary>
    /// The metric_unit attribute.
    /// </summary>
    [TerraformPropertyName("metric_unit")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MetricUnit => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "metric_unit");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The quota_display_name attribute.
    /// </summary>
    [TerraformPropertyName("quota_display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> QuotaDisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "quota_display_name");

    /// <summary>
    /// The quota_increase_eligibility attribute.
    /// </summary>
    [TerraformPropertyName("quota_increase_eligibility")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> QuotaIncreaseEligibility => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "quota_increase_eligibility");

    /// <summary>
    /// The refresh_interval attribute.
    /// </summary>
    [TerraformPropertyName("refresh_interval")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RefreshInterval => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "refresh_interval");

    /// <summary>
    /// The service_request_quota_uri attribute.
    /// </summary>
    [TerraformPropertyName("service_request_quota_uri")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServiceRequestQuotaUri => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_request_quota_uri");

}
