using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_workspacesweb_session_logger_association Terraform resource.
/// Manages a aws_workspacesweb_session_logger_association resource.
/// </summary>
public partial class AwsWorkspaceswebSessionLoggerAssociation(string name) : TerraformResource("aws_workspacesweb_session_logger_association", name)
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
    /// The session_logger_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SessionLoggerArn is required")]
    public required TerraformValue<string> SessionLoggerArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("session_logger_arn");
        set => SetArgument("session_logger_arn", value);
    }

}
