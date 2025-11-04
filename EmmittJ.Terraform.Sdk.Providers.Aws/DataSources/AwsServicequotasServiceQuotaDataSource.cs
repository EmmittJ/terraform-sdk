using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_servicequotas_service_quota.
/// </summary>
public class AwsServicequotasServiceQuotaDataSource : TerraformDataSource
{
    public AwsServicequotasServiceQuotaDataSource(string name) : base("aws_servicequotas_service_quota", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("adjustable");
        this.DeclareOutput("arn");
        this.DeclareOutput("default_value");
        this.DeclareOutput("global_quota");
        this.DeclareOutput("service_name");
        this.DeclareOutput("usage_metric");
        this.DeclareOutput("value");
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
    /// The quota_code attribute.
    /// </summary>
    public string? QuotaCode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("quota_code")?.Value;
        set => this.WithProperty("quota_code", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The quota_name attribute.
    /// </summary>
    public string? QuotaName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("quota_name")?.Value;
        set => this.WithProperty("quota_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_code attribute.
    /// </summary>
    public string? ServiceCode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_code")?.Value;
        set => this.WithProperty("service_code", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The adjustable attribute.
    /// </summary>
    public TerraformExpression Adjustable => this["adjustable"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The default_value attribute.
    /// </summary>
    public TerraformExpression DefaultValue => this["default_value"];

    /// <summary>
    /// The global_quota attribute.
    /// </summary>
    public TerraformExpression GlobalQuota => this["global_quota"];

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    public TerraformExpression ServiceName => this["service_name"];

    /// <summary>
    /// The usage_metric attribute.
    /// </summary>
    public TerraformExpression UsageMetric => this["usage_metric"];

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformExpression Value => this["value"];

}
