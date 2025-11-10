using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for additional_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsGuarddutyOrganizationConfigurationFeatureAdditionalConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The auto_enable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoEnable is required")]
    public required TerraformProperty<string> AutoEnable
    {
        set => SetProperty("auto_enable", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

}

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
        SetOutput("auto_enable");
        SetOutput("detector_id");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
    }

    /// <summary>
    /// The auto_enable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoEnable is required")]
    public required TerraformProperty<string> AutoEnable
    {
        get => GetRequiredOutput<TerraformProperty<string>>("auto_enable");
        set => SetProperty("auto_enable", value);
    }

    /// <summary>
    /// The detector_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DetectorId is required")]
    public required TerraformProperty<string> DetectorId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("detector_id");
        set => SetProperty("detector_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// Block for additional_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsGuarddutyOrganizationConfigurationFeatureAdditionalConfigurationBlock>? AdditionalConfiguration
    {
        set => SetProperty("additional_configuration", value);
    }

}
