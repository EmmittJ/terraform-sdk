using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_workspacesweb_user_settings_association Terraform resource.
/// Manages a aws_workspacesweb_user_settings_association resource.
/// </summary>
public partial class AwsWorkspaceswebUserSettingsAssociation(string name) : TerraformResource("aws_workspacesweb_user_settings_association", name)
{
    /// <summary>
    /// The portal_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortalArn is required")]
    public required TerraformValue<string> PortalArn
    {
        get => new TerraformReference<string>(this, "portal_arn");
        set => SetArgument("portal_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The user_settings_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserSettingsArn is required")]
    public required TerraformValue<string> UserSettingsArn
    {
        get => new TerraformReference<string>(this, "user_settings_arn");
        set => SetArgument("user_settings_arn", value);
    }

}
