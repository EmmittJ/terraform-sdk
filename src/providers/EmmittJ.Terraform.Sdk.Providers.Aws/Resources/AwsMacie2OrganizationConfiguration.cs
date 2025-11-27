using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_macie2_organization_configuration Terraform resource.
/// Manages a aws_macie2_organization_configuration resource.
/// </summary>
public partial class AwsMacie2OrganizationConfiguration(string name) : TerraformResource("aws_macie2_organization_configuration", name)
{
    /// <summary>
    /// Whether to enable Amazon Macie automatically for accounts that are added to the organization in AWS Organizations
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoEnable is required")]
    public required TerraformValue<bool> AutoEnable
    {
        get => new TerraformReference<bool>(this, "auto_enable");
        set => SetArgument("auto_enable", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

}
