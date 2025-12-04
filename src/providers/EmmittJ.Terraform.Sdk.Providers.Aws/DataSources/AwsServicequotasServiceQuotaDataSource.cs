using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_servicequotas_service_quota Terraform data source.
/// Retrieves information about a aws_servicequotas_service_quota.
/// </summary>
public partial class AwsServicequotasServiceQuotaDataSource(string name) : TerraformDataSource("aws_servicequotas_service_quota", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The quota_code attribute.
    /// </summary>
    public TerraformValue<string>? QuotaCode
    {
        get => GetArgument<TerraformValue<string>>("quota_code");
        set => SetArgument("quota_code", value);
    }

    /// <summary>
    /// The quota_name attribute.
    /// </summary>
    public TerraformValue<string>? QuotaName
    {
        get => GetArgument<TerraformValue<string>>("quota_name");
        set => SetArgument("quota_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The service_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceCode is required")]
    public required TerraformValue<string> ServiceCode
    {
        get => GetArgument<TerraformValue<string>>("service_code");
        set => SetArgument("service_code", value);
    }

    /// <summary>
    /// The adjustable attribute.
    /// </summary>
    public TerraformValue<bool> Adjustable
        => AsReference("adjustable");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The default_value attribute.
    /// </summary>
    public TerraformValue<double> DefaultValue
        => AsReference("default_value");

    /// <summary>
    /// The global_quota attribute.
    /// </summary>
    public TerraformValue<bool> GlobalQuota
        => AsReference("global_quota");

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    public TerraformValue<string> ServiceName
        => AsReference("service_name");

    /// <summary>
    /// The usage_metric attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> UsageMetric
        => AsReference("usage_metric");

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<double> Value
        => AsReference("value");

}
