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
        this.WithOutput("adjustable");
        this.WithOutput("arn");
        this.WithOutput("default_value");
        this.WithOutput("global_quota");
        this.WithOutput("service_name");
        this.WithOutput("usage_metric");
        this.WithOutput("value");
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
    public TerraformProperty<string>? QuotaCode
    {
        get => GetProperty<TerraformProperty<string>>("quota_code");
        set => this.WithProperty("quota_code", value);
    }

    /// <summary>
    /// The quota_name attribute.
    /// </summary>
    public TerraformProperty<string>? QuotaName
    {
        get => GetProperty<TerraformProperty<string>>("quota_name");
        set => this.WithProperty("quota_name", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("service_code");
        set => this.WithProperty("service_code", value);
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
