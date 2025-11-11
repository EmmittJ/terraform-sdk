using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_workspacesweb_ip_access_settings_association resource.
/// </summary>
public partial class AwsWorkspaceswebIpAccessSettingsAssociation : TerraformResource
{
    public AwsWorkspaceswebIpAccessSettingsAssociation(string name) : base("aws_workspacesweb_ip_access_settings_association", name)
    {
    }

    /// <summary>
    /// The ip_access_settings_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpAccessSettingsArn is required")]
    [TerraformProperty("ip_access_settings_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IpAccessSettingsArn { get; set; }

    /// <summary>
    /// The portal_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortalArn is required")]
    [TerraformProperty("portal_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PortalArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

}
