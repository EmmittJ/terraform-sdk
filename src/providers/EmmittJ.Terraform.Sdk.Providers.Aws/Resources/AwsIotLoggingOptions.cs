using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iot_logging_options Terraform resource.
/// Manages a aws_iot_logging_options resource.
/// </summary>
public partial class AwsIotLoggingOptions(string name) : TerraformResource("aws_iot_logging_options", name)
{
    /// <summary>
    /// The default_log_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultLogLevel is required")]
    public required TerraformValue<string> DefaultLogLevel
    {
        get => GetArgument<TerraformValue<string>>("default_log_level");
        set => SetArgument("default_log_level", value);
    }

    /// <summary>
    /// The disable_all_logs attribute.
    /// </summary>
    public TerraformValue<bool>? DisableAllLogs
    {
        get => GetArgument<TerraformValue<bool>>("disable_all_logs");
        set => SetArgument("disable_all_logs", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => GetArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
    }

}
