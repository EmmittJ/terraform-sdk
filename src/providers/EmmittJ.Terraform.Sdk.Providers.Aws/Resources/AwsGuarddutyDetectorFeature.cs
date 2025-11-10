using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for additional_configuration in .
/// Nesting mode: set
/// </summary>
public class AwsGuarddutyDetectorFeatureAdditionalConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    public required TerraformProperty<string> Status
    {
        set => SetProperty("status", value);
    }

}

/// <summary>
/// Manages a aws_guardduty_detector_feature resource.
/// </summary>
public class AwsGuarddutyDetectorFeature : TerraformResource
{
    public AwsGuarddutyDetectorFeature(string name) : base("aws_guardduty_detector_feature", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("detector_id");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("status");
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
    /// The status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    public required TerraformProperty<string> Status
    {
        get => GetRequiredOutput<TerraformProperty<string>>("status");
        set => SetProperty("status", value);
    }

    /// <summary>
    /// Block for additional_configuration.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsGuarddutyDetectorFeatureAdditionalConfigurationBlock>? AdditionalConfiguration
    {
        set => SetProperty("additional_configuration", value);
    }

}
