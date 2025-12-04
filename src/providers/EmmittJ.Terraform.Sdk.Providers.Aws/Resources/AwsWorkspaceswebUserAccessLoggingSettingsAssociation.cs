using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_workspacesweb_user_access_logging_settings_association Terraform resource.
/// Manages a aws_workspacesweb_user_access_logging_settings_association resource.
/// </summary>
public partial class AwsWorkspaceswebUserAccessLoggingSettingsAssociation(string name) : TerraformResource("aws_workspacesweb_user_access_logging_settings_association", name)
{
    /// <summary>
    /// The portal_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortalArn is required")]
    public required TerraformValue<string> PortalArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("portal_arn");
        set => SetArgument("portal_arn", value);
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
    /// The user_access_logging_settings_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserAccessLoggingSettingsArn is required")]
    public required TerraformValue<string> UserAccessLoggingSettingsArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_access_logging_settings_arn");
        set => SetArgument("user_access_logging_settings_arn", value);
    }

}
