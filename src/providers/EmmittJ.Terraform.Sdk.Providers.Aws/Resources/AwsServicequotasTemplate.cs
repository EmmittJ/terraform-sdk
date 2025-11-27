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
        get => new TerraformReference<string>(this, "aws_region");
        set => SetArgument("aws_region", value);
    }

    /// <summary>
    /// The quota_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QuotaCode is required")]
    public required TerraformValue<string> QuotaCode
    {
        get => new TerraformReference<string>(this, "quota_code");
        set => SetArgument("quota_code", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The service_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceCode is required")]
    public required TerraformValue<string> ServiceCode
    {
        get => new TerraformReference<string>(this, "service_code");
        set => SetArgument("service_code", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => new TerraformReference<double>(this, "value");
        set => SetArgument("value", value);
    }

    /// <summary>
    /// The global_quota attribute.
    /// </summary>
    public TerraformValue<bool> GlobalQuota
    {
        get => new TerraformReference<bool>(this, "global_quota");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The quota_name attribute.
    /// </summary>
    public TerraformValue<string> QuotaName
    {
        get => new TerraformReference<string>(this, "quota_name");
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    public TerraformValue<string> ServiceName
    {
        get => new TerraformReference<string>(this, "service_name");
    }

    /// <summary>
    /// The unit attribute.
    /// </summary>
    public TerraformValue<string> Unit
    {
        get => new TerraformReference<string>(this, "unit");
    }

}
