using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_servicequotas_service_quota Terraform resource.
/// Manages a aws_servicequotas_service_quota resource.
/// </summary>
public partial class AwsServicequotasServiceQuota(string name) : TerraformResource("aws_servicequotas_service_quota", name)
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QuotaCode is required")]
    public required TerraformValue<string> QuotaCode
    {
        get => GetRequiredArgument<TerraformValue<string>>("quota_code");
        set => SetArgument("quota_code", value);
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
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
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
    /// The quota_name attribute.
    /// </summary>
    public TerraformValue<string> QuotaName
        => CreateReference("quota_name");

    /// <summary>
    /// The request_id attribute.
    /// </summary>
    public TerraformValue<string> RequestId
        => CreateReference("request_id");

    /// <summary>
    /// The request_status attribute.
    /// </summary>
    public TerraformValue<string> RequestStatus
        => CreateReference("request_status");

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

}
