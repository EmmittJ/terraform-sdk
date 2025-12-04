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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
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
        => AsReference("container_type");

    /// <summary>
    /// The dimensions attribute.
    /// </summary>
    public TerraformList<string> Dimensions
        => AsReference("dimensions");

    /// <summary>
    /// The dimensions_infos attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DimensionsInfos
        => AsReference("dimensions_infos");

    /// <summary>
    /// The is_concurrent attribute.
    /// </summary>
    public TerraformValue<bool> IsConcurrent
        => AsReference("is_concurrent");

    /// <summary>
    /// The is_fixed attribute.
    /// </summary>
    public TerraformValue<bool> IsFixed
        => AsReference("is_fixed");

    /// <summary>
    /// The is_precise attribute.
    /// </summary>
    public TerraformValue<bool> IsPrecise
        => AsReference("is_precise");

    /// <summary>
    /// The metric attribute.
    /// </summary>
    public TerraformValue<string> Metric
        => AsReference("metric");

    /// <summary>
    /// The metric_display_name attribute.
    /// </summary>
    public TerraformValue<string> MetricDisplayName
        => AsReference("metric_display_name");

    /// <summary>
    /// The metric_unit attribute.
    /// </summary>
    public TerraformValue<string> MetricUnit
        => AsReference("metric_unit");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The quota_display_name attribute.
    /// </summary>
    public TerraformValue<string> QuotaDisplayName
        => AsReference("quota_display_name");

    /// <summary>
    /// The quota_increase_eligibility attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> QuotaIncreaseEligibility
        => AsReference("quota_increase_eligibility");

    /// <summary>
    /// The refresh_interval attribute.
    /// </summary>
    public TerraformValue<string> RefreshInterval
        => AsReference("refresh_interval");

    /// <summary>
    /// The service_request_quota_uri attribute.
    /// </summary>
    public TerraformValue<string> ServiceRequestQuotaUri
        => AsReference("service_request_quota_uri");

}
