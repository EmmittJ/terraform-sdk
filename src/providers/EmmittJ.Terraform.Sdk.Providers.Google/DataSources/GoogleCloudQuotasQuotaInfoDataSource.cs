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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The parent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformValue<string> Parent
    {
        get => GetRequiredArgument<TerraformValue<string>>("parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// The quota_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QuotaId is required")]
    public required TerraformValue<string> QuotaId
    {
        get => GetRequiredArgument<TerraformValue<string>>("quota_id");
        set => SetArgument("quota_id", value);
    }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => GetRequiredArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

    /// <summary>
    /// The container_type attribute.
    /// </summary>
    public TerraformValue<string> ContainerType
        => CreateReference("container_type");

    /// <summary>
    /// The dimensions attribute.
    /// </summary>
    public TerraformList<string> Dimensions
        => CreateReference("dimensions");

    /// <summary>
    /// The dimensions_infos attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DimensionsInfos
        => CreateReference("dimensions_infos");

    /// <summary>
    /// The is_concurrent attribute.
    /// </summary>
    public TerraformValue<bool> IsConcurrent
        => CreateReference("is_concurrent");

    /// <summary>
    /// The is_fixed attribute.
    /// </summary>
    public TerraformValue<bool> IsFixed
        => CreateReference("is_fixed");

    /// <summary>
    /// The is_precise attribute.
    /// </summary>
    public TerraformValue<bool> IsPrecise
        => CreateReference("is_precise");

    /// <summary>
    /// The metric attribute.
    /// </summary>
    public TerraformValue<string> Metric
        => CreateReference("metric");

    /// <summary>
    /// The metric_display_name attribute.
    /// </summary>
    public TerraformValue<string> MetricDisplayName
        => CreateReference("metric_display_name");

    /// <summary>
    /// The metric_unit attribute.
    /// </summary>
    public TerraformValue<string> MetricUnit
        => CreateReference("metric_unit");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// The quota_display_name attribute.
    /// </summary>
    public TerraformValue<string> QuotaDisplayName
        => CreateReference("quota_display_name");

    /// <summary>
    /// The quota_increase_eligibility attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> QuotaIncreaseEligibility
        => CreateReference("quota_increase_eligibility");

    /// <summary>
    /// The refresh_interval attribute.
    /// </summary>
    public TerraformValue<string> RefreshInterval
        => CreateReference("refresh_interval");

    /// <summary>
    /// The service_request_quota_uri attribute.
    /// </summary>
    public TerraformValue<string> ServiceRequestQuotaUri
        => CreateReference("service_request_quota_uri");

}
