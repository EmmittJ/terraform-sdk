using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_workspacesweb_user_access_logging_settings Terraform resource.
/// Manages a aws_workspacesweb_user_access_logging_settings resource.
/// </summary>
public partial class AwsWorkspaceswebUserAccessLoggingSettings(string name) : TerraformResource("aws_workspacesweb_user_access_logging_settings", name)
{
    /// <summary>
    /// The kinesis_stream_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KinesisStreamArn is required")]
    public required TerraformValue<string> KinesisStreamArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("kinesis_stream_arn");
        set => SetArgument("kinesis_stream_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
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
    /// The associated_portal_arns attribute.
    /// </summary>
    public TerraformList<string> AssociatedPortalArns
        => AsReference("associated_portal_arns");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// The user_access_logging_settings_arn attribute.
    /// </summary>
    public TerraformValue<string> UserAccessLoggingSettingsArn
        => AsReference("user_access_logging_settings_arn");

}
