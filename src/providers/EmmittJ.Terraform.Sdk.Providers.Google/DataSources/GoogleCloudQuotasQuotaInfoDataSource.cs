using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_cloud_quotas_quota_info Terraform data source.
/// Retrieves information about a google_cloud_quotas_quota_info.
/// </summary>
public partial class GoogleCloudQuotasQuotaInfoDataSource(string name) : TerraformDataSource("google_cloud_quotas_quota_info", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The parent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformValue<string> Parent
    {
        get => new TerraformReference<string>(this, "parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// The quota_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QuotaId is required")]
    public required TerraformValue<string> QuotaId
    {
        get => new TerraformReference<string>(this, "quota_id");
        set => SetArgument("quota_id", value);
    }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => new TerraformReference<string>(this, "service");
        set => SetArgument("service", value);
    }

    /// <summary>
    /// The container_type attribute.
    /// </summary>
    public TerraformValue<string> ContainerType
    {
        get => new TerraformReference<string>(this, "container_type");
    }

    /// <summary>
    /// The dimensions attribute.
    /// </summary>
    public TerraformList<string> Dimensions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "dimensions").ResolveNodes(ctx));
    }

    /// <summary>
    /// The dimensions_infos attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DimensionsInfos
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "dimensions_infos").ResolveNodes(ctx));
    }

    /// <summary>
    /// The is_concurrent attribute.
    /// </summary>
    public TerraformValue<bool> IsConcurrent
    {
        get => new TerraformReference<bool>(this, "is_concurrent");
    }

    /// <summary>
    /// The is_fixed attribute.
    /// </summary>
    public TerraformValue<bool> IsFixed
    {
        get => new TerraformReference<bool>(this, "is_fixed");
    }

    /// <summary>
    /// The is_precise attribute.
    /// </summary>
    public TerraformValue<bool> IsPrecise
    {
        get => new TerraformReference<bool>(this, "is_precise");
    }

    /// <summary>
    /// The metric attribute.
    /// </summary>
    public TerraformValue<string> Metric
    {
        get => new TerraformReference<string>(this, "metric");
    }

    /// <summary>
    /// The metric_display_name attribute.
    /// </summary>
    public TerraformValue<string> MetricDisplayName
    {
        get => new TerraformReference<string>(this, "metric_display_name");
    }

    /// <summary>
    /// The metric_unit attribute.
    /// </summary>
    public TerraformValue<string> MetricUnit
    {
        get => new TerraformReference<string>(this, "metric_unit");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The quota_display_name attribute.
    /// </summary>
    public TerraformValue<string> QuotaDisplayName
    {
        get => new TerraformReference<string>(this, "quota_display_name");
    }

    /// <summary>
    /// The quota_increase_eligibility attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> QuotaIncreaseEligibility
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "quota_increase_eligibility").ResolveNodes(ctx));
    }

    /// <summary>
    /// The refresh_interval attribute.
    /// </summary>
    public TerraformValue<string> RefreshInterval
    {
        get => new TerraformReference<string>(this, "refresh_interval");
    }

    /// <summary>
    /// The service_request_quota_uri attribute.
    /// </summary>
    public TerraformValue<string> ServiceRequestQuotaUri
    {
        get => new TerraformReference<string>(this, "service_request_quota_uri");
    }

}
