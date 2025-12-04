using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_servicequotas_template Terraform resource.
/// Manages a aws_servicequotas_template resource.
/// </summary>
public partial class AwsServicequotasTemplate(string name) : TerraformResource("aws_servicequotas_template", name)
{
    /// <summary>
    /// The aws_region attribute.
    /// </summary>
    public TerraformValue<string> AwsRegion
    {
        get => GetArgument<TerraformValue<string>>("aws_region") ?? AsReference("aws_region");
        set => SetArgument("aws_region", value);
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
    /// The region attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
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
    /// The global_quota attribute.
    /// </summary>
    public TerraformValue<bool> GlobalQuota
        => AsReference("global_quota");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The quota_name attribute.
    /// </summary>
    public TerraformValue<string> QuotaName
        => AsReference("quota_name");

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    public TerraformValue<string> ServiceName
        => AsReference("service_name");

    /// <summary>
    /// The unit attribute.
    /// </summary>
    public TerraformValue<string> Unit
        => AsReference("unit");

}
