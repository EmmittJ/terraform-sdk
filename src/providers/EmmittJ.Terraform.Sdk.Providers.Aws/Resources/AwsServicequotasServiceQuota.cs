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
        SetOutput("adjustable");
        SetOutput("arn");
        SetOutput("default_value");
        SetOutput("quota_name");
        SetOutput("request_id");
        SetOutput("request_status");
        SetOutput("service_name");
        SetOutput("usage_metric");
        SetOutput("id");
        SetOutput("quota_code");
        SetOutput("region");
        SetOutput("service_code");
        SetOutput("value");
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
    /// The quota_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QuotaCode is required")]
    public required TerraformProperty<string> QuotaCode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("quota_code");
        set => SetProperty("quota_code", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The service_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceCode is required")]
    public required TerraformProperty<string> ServiceCode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_code");
        set => SetProperty("service_code", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<double> Value
    {
        get => GetRequiredOutput<TerraformProperty<double>>("value");
        set => SetProperty("value", value);
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
