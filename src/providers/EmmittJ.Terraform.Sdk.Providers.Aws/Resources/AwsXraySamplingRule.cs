using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_xray_sampling_rule Terraform resource.
/// Manages a aws_xray_sampling_rule resource.
/// </summary>
public partial class AwsXraySamplingRule(string name) : TerraformResource("aws_xray_sampling_rule", name)
{
    /// <summary>
    /// The attributes attribute.
    /// </summary>
    public TerraformMap<string>? Attributes
    {
        get => GetArgument<TerraformMap<string>>("attributes");
        set => SetArgument("attributes", value);
    }

    /// <summary>
    /// The fixed_rate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FixedRate is required")]
    public required TerraformValue<double> FixedRate
    {
        get => GetArgument<TerraformValue<double>>("fixed_rate");
        set => SetArgument("fixed_rate", value);
    }

    /// <summary>
    /// The host attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    public required TerraformValue<string> Host
    {
        get => GetArgument<TerraformValue<string>>("host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The http_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpMethod is required")]
    public required TerraformValue<string> HttpMethod
    {
        get => GetArgument<TerraformValue<string>>("http_method");
        set => SetArgument("http_method", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => GetArgument<TerraformValue<double>>("priority");
        set => SetArgument("priority", value);
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
    /// The reservoir_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReservoirSize is required")]
    public required TerraformValue<double> ReservoirSize
    {
        get => GetArgument<TerraformValue<double>>("reservoir_size");
        set => SetArgument("reservoir_size", value);
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    public required TerraformValue<string> ResourceArn
    {
        get => GetArgument<TerraformValue<string>>("resource_arn");
        set => SetArgument("resource_arn", value);
    }

    /// <summary>
    /// The rule_name attribute.
    /// </summary>
    public TerraformValue<string>? RuleName
    {
        get => GetArgument<TerraformValue<string>>("rule_name");
        set => SetArgument("rule_name", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    public required TerraformValue<string> ServiceName
    {
        get => GetArgument<TerraformValue<string>>("service_name");
        set => SetArgument("service_name", value);
    }

    /// <summary>
    /// The service_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceType is required")]
    public required TerraformValue<string> ServiceType
    {
        get => GetArgument<TerraformValue<string>>("service_type");
        set => SetArgument("service_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The url_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UrlPath is required")]
    public required TerraformValue<string> UrlPath
    {
        get => GetArgument<TerraformValue<string>>("url_path");
        set => SetArgument("url_path", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<double> Version
    {
        get => GetArgument<TerraformValue<double>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

}
