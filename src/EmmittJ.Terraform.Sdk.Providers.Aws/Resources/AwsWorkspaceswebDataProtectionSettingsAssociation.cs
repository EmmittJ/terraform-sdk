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
    }

    /// <summary>
    /// The data_protection_settings_arn attribute.
    /// </summary>
    public TerraformProperty<string>? DataProtectionSettingsArn
    {
        get => GetProperty<TerraformProperty<string>>("data_protection_settings_arn");
        set => this.WithProperty("data_protection_settings_arn", value);
    }

    /// <summary>
    /// The portal_arn attribute.
    /// </summary>
    public TerraformProperty<string>? PortalArn
    {
        get => GetProperty<TerraformProperty<string>>("portal_arn");
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

}
