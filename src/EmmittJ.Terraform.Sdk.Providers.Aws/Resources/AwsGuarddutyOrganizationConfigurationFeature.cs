using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_guardduty_organization_configuration_feature resource.
/// </summary>
public class AwsGuarddutyOrganizationConfigurationFeature : TerraformResource
{
    public AwsGuarddutyOrganizationConfigurationFeature(string name) : base("aws_guardduty_organization_configuration_feature", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The auto_enable attribute.
    /// </summary>
    public TerraformProperty<string>? AutoEnable
    {
        get => GetProperty<TerraformProperty<string>>("auto_enable");
        set => this.WithProperty("auto_enable", value);
    }

    /// <summary>
    /// The detector_id attribute.
    /// </summary>
    public TerraformProperty<string>? DetectorId
    {
        get => GetProperty<TerraformProperty<string>>("detector_id");
        set => this.WithProperty("detector_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
