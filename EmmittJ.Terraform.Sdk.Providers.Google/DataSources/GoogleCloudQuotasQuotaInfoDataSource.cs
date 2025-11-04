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
        this.DeclareOutput("container_type");
        this.DeclareOutput("dimensions");
        this.DeclareOutput("dimensions_infos");
        this.DeclareOutput("is_concurrent");
        this.DeclareOutput("is_fixed");
        this.DeclareOutput("is_precise");
        this.DeclareOutput("metric");
        this.DeclareOutput("metric_display_name");
        this.DeclareOutput("metric_unit");
        this.DeclareOutput("name");
        this.DeclareOutput("quota_display_name");
        this.DeclareOutput("quota_increase_eligibility");
        this.DeclareOutput("refresh_interval");
        this.DeclareOutput("service_request_quota_uri");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The parent attribute.
    /// </summary>
    public string? Parent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent")?.Value;
        set => this.WithProperty("parent", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The quota_id attribute.
    /// </summary>
    public string? QuotaId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("quota_id")?.Value;
        set => this.WithProperty("quota_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service attribute.
    /// </summary>
    public string? Service
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service")?.Value;
        set => this.WithProperty("service", value == null ? null : new TerraformLiteralProperty<string>(value));
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
