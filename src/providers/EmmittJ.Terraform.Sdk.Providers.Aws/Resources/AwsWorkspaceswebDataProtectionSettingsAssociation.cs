using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_workspacesweb_data_protection_settings_association resource.
/// </summary>
public class AwsWorkspaceswebDataProtectionSettingsAssociation : TerraformResource
{
    public AwsWorkspaceswebDataProtectionSettingsAssociation(string name) : base("aws_workspacesweb_data_protection_settings_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("data_protection_settings_arn");
        SetOutput("portal_arn");
        SetOutput("region");
    }

    /// <summary>
    /// The data_protection_settings_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataProtectionSettingsArn is required")]
    public required TerraformProperty<string> DataProtectionSettingsArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_protection_settings_arn");
        set => SetProperty("data_protection_settings_arn", value);
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

}
