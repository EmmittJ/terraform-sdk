using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for additional_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsGuarddutyOrganizationConfigurationFeatureAdditionalConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The auto_enable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoEnable is required")]
    [TerraformProperty("auto_enable")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AutoEnable { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Manages a aws_guardduty_organization_configuration_feature resource.
/// </summary>
public partial class AwsGuarddutyOrganizationConfigurationFeature : TerraformResource
{
    public AwsGuarddutyOrganizationConfigurationFeature(string name) : base("aws_guardduty_organization_configuration_feature", name)
    {
    }

    /// <summary>
    /// The auto_enable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoEnable is required")]
    [TerraformProperty("auto_enable")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AutoEnable { get; set; }

    /// <summary>
    /// The detector_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DetectorId is required")]
    [TerraformProperty("detector_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DetectorId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for additional_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("additional_configuration")]
    public partial TerraformList<TerraformBlock<AwsGuarddutyOrganizationConfigurationFeatureAdditionalConfigurationBlock>>? AdditionalConfiguration { get; set; }

}
