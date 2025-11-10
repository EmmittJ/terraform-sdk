using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_workspacesweb_user_access_logging_settings_association resource.
/// </summary>
public class AwsWorkspaceswebUserAccessLoggingSettingsAssociation : TerraformResource
{
    public AwsWorkspaceswebUserAccessLoggingSettingsAssociation(string name) : base("aws_workspacesweb_user_access_logging_settings_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The portal_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortalArn is required")]
    public required TerraformProperty<string> PortalArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("portal_arn");
        set => this.WithProperty("portal_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The user_access_logging_settings_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserAccessLoggingSettingsArn is required")]
    public required TerraformProperty<string> UserAccessLoggingSettingsArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("user_access_logging_settings_arn");
        set => this.WithProperty("user_access_logging_settings_arn", value);
    }

}
