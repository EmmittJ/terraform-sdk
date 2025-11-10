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
        SetOutput("portal_arn");
        SetOutput("region");
        SetOutput("user_access_logging_settings_arn");
    }

    /// <summary>
    /// The portal_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortalArn is required")]
    public required TerraformProperty<string> PortalArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("portal_arn");
        set => SetProperty("portal_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The user_access_logging_settings_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserAccessLoggingSettingsArn is required")]
    public required TerraformProperty<string> UserAccessLoggingSettingsArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_access_logging_settings_arn");
        set => SetProperty("user_access_logging_settings_arn", value);
    }

}
