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
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The quota_code attribute.
    /// </summary>
    public TerraformValue<string> QuotaCode
    {
        get => GetArgument<TerraformValue<string>>("quota_code") ?? CreateReference("quota_code");
        set => SetArgument("quota_code", value);
    }

    /// <summary>
    /// The quota_name attribute.
    /// </summary>
    public TerraformValue<string> QuotaName
    {
        get => GetArgument<TerraformValue<string>>("quota_name") ?? CreateReference("quota_name");
        set => SetArgument("quota_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The service_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceCode is required")]
    public required TerraformValue<string> ServiceCode
    {
        get => GetRequiredArgument<TerraformValue<string>>("service_code");
        set => SetArgument("service_code", value);
    }

    /// <summary>
    /// The adjustable attribute.
    /// </summary>
    public TerraformValue<bool> Adjustable
        => CreateReference("adjustable");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The default_value attribute.
    /// </summary>
    public TerraformValue<double> DefaultValue
        => CreateReference("default_value");

    /// <summary>
    /// The global_quota attribute.
    /// </summary>
    public TerraformValue<bool> GlobalQuota
        => CreateReference("global_quota");

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    public TerraformValue<string> ServiceName
        => CreateReference("service_name");

    /// <summary>
    /// The usage_metric attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> UsageMetric
        => CreateReference("usage_metric");

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<double> Value
        => CreateReference("value");

}
