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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The quota_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QuotaCode is required")]
    public required TerraformProperty<string> QuotaCode
    {
        get => GetProperty<TerraformProperty<string>>("quota_code");
        set => this.WithProperty("quota_code", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The service_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceCode is required")]
    public required TerraformProperty<string> ServiceCode
    {
        get => GetProperty<TerraformProperty<string>>("service_code");
        set => this.WithProperty("service_code", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<double> Value
    {
        get => GetProperty<TerraformProperty<double>>("value");
        set => this.WithProperty("value", value);
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
