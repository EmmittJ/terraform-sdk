using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_cloud_quotas_quota_info.
/// </summary>
public class GoogleCloudQuotasQuotaInfoDataSource : TerraformDataSource
{
    public GoogleCloudQuotasQuotaInfoDataSource(string name) : base("google_cloud_quotas_quota_info", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("container_type");
        SetOutput("dimensions");
        SetOutput("dimensions_infos");
        SetOutput("is_concurrent");
        SetOutput("is_fixed");
        SetOutput("is_precise");
        SetOutput("metric");
        SetOutput("metric_display_name");
        SetOutput("metric_unit");
        SetOutput("name");
        SetOutput("quota_display_name");
        SetOutput("quota_increase_eligibility");
        SetOutput("refresh_interval");
        SetOutput("service_request_quota_uri");
        SetOutput("id");
        SetOutput("parent");
        SetOutput("quota_id");
        SetOutput("service");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The parent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent");
        set => SetProperty("parent", value);
    }

    /// <summary>
    /// The quota_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QuotaId is required")]
    public required TerraformProperty<string> QuotaId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("quota_id");
        set => SetProperty("quota_id", value);
    }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformProperty<string> Service
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service");
        set => SetProperty("service", value);
    }

    /// <summary>
    /// The container_type attribute.
    /// </summary>
    public TerraformExpression ContainerType => this["container_type"];

    /// <summary>
    /// The dimensions attribute.
    /// </summary>
    public TerraformExpression Dimensions => this["dimensions"];

    /// <summary>
    /// The dimensions_infos attribute.
    /// </summary>
    public TerraformExpression DimensionsInfos => this["dimensions_infos"];

    /// <summary>
    /// The is_concurrent attribute.
    /// </summary>
    public TerraformExpression IsConcurrent => this["is_concurrent"];

    /// <summary>
    /// The is_fixed attribute.
    /// </summary>
    public TerraformExpression IsFixed => this["is_fixed"];

    /// <summary>
    /// The is_precise attribute.
    /// </summary>
    public TerraformExpression IsPrecise => this["is_precise"];

    /// <summary>
    /// The metric attribute.
    /// </summary>
    public TerraformExpression Metric => this["metric"];

    /// <summary>
    /// The metric_display_name attribute.
    /// </summary>
    public TerraformExpression MetricDisplayName => this["metric_display_name"];

    /// <summary>
    /// The metric_unit attribute.
    /// </summary>
    public TerraformExpression MetricUnit => this["metric_unit"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The quota_display_name attribute.
    /// </summary>
    public TerraformExpression QuotaDisplayName => this["quota_display_name"];

    /// <summary>
    /// The quota_increase_eligibility attribute.
    /// </summary>
    public TerraformExpression QuotaIncreaseEligibility => this["quota_increase_eligibility"];

    /// <summary>
    /// The refresh_interval attribute.
    /// </summary>
    public TerraformExpression RefreshInterval => this["refresh_interval"];

    /// <summary>
    /// The service_request_quota_uri attribute.
    /// </summary>
    public TerraformExpression ServiceRequestQuotaUri => this["service_request_quota_uri"];

}
