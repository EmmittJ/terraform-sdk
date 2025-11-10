using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_workspacesweb_data_protection_settings_association resource.
/// </summary>
public class AwsWorkspaceswebDataProtectionSettingsAssociation : TerraformResource
{
    public AwsWorkspaceswebDataProtectionSettingsAssociation(string name) : base("aws_workspacesweb_data_protection_settings_association", name)
    {
    }

    /// <summary>
    /// The data_protection_settings_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataProtectionSettingsArn is required")]
    [TerraformPropertyName("data_protection_settings_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DataProtectionSettingsArn { get; set; }

    /// <summary>
    /// The portal_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortalArn is required")]
    [TerraformPropertyName("portal_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PortalArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

}
