using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_workspacesweb_data_protection_settings_association Terraform resource.
/// Manages a aws_workspacesweb_data_protection_settings_association resource.
/// </summary>
public partial class AwsWorkspaceswebDataProtectionSettingsAssociation(string name) : TerraformResource("aws_workspacesweb_data_protection_settings_association", name)
{
    /// <summary>
    /// The data_protection_settings_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataProtectionSettingsArn is required")]
    public required TerraformValue<string> DataProtectionSettingsArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("data_protection_settings_arn");
        set => SetArgument("data_protection_settings_arn", value);
    }

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

}
