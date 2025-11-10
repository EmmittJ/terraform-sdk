using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_macie2_organization_configuration resource.
/// </summary>
public class AwsMacie2OrganizationConfiguration : TerraformResource
{
    public AwsMacie2OrganizationConfiguration(string name) : base("aws_macie2_organization_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// Whether to enable Amazon Macie automatically for accounts that are added to the organization in AWS Organizations
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoEnable is required")]
    public required TerraformProperty<bool> AutoEnable
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("auto_enable");
        set => this.WithProperty("auto_enable", value);
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
