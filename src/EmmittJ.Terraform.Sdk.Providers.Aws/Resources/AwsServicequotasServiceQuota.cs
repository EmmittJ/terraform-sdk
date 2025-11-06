using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_servicequotas_service_quota resource.
/// </summary>
public class AwsServicequotasServiceQuota : TerraformResource
{
    public AwsServicequotasServiceQuota(string name) : base("aws_servicequotas_service_quota", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("adjustable");
        this.DeclareOutput("arn");
        this.DeclareOutput("default_value");
        this.DeclareOutput("quota_name");
        this.DeclareOutput("request_id");
        this.DeclareOutput("request_status");
        this.DeclareOutput("service_name");
        this.DeclareOutput("usage_metric");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The value attribute.
    /// </summary>
    public double? Value
    {
        get => GetProperty<TerraformLiteralProperty<double>>("value")?.Value;
        set => this.WithProperty("value", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The quota_name attribute.
    /// </summary>
    public TerraformExpression QuotaName => this["quota_name"];

    /// <summary>
    /// The request_id attribute.
    /// </summary>
    public TerraformExpression RequestId => this["request_id"];

    /// <summary>
    /// The request_status attribute.
    /// </summary>
    public TerraformExpression RequestStatus => this["request_status"];

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    public TerraformExpression ServiceName => this["service_name"];

    /// <summary>
    /// The usage_metric attribute.
    /// </summary>
    public TerraformExpression UsageMetric => this["usage_metric"];

}
