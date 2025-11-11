using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_datazone_environment_blueprint_configuration resource.
/// </summary>
public partial class AwsDatazoneEnvironmentBlueprintConfiguration : TerraformResource
{
    public AwsDatazoneEnvironmentBlueprintConfiguration(string name) : base("aws_datazone_environment_blueprint_configuration", name)
    {
    }

    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainId is required")]
    [TerraformProperty("domain_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DomainId { get; set; }

    /// <summary>
    /// The enabled_regions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnabledRegions is required")]
    [TerraformProperty("enabled_regions")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? EnabledRegions { get; set; }

    /// <summary>
    /// The environment_blueprint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvironmentBlueprintId is required")]
    [TerraformProperty("environment_blueprint_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EnvironmentBlueprintId { get; set; }

    /// <summary>
    /// The manage_access_role_arn attribute.
    /// </summary>
    [TerraformProperty("manage_access_role_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ManageAccessRoleArn { get; set; }

    /// <summary>
    /// The provisioning_role_arn attribute.
    /// </summary>
    [TerraformProperty("provisioning_role_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ProvisioningRoleArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The regional_parameters attribute.
    /// </summary>
    [TerraformProperty("regional_parameters")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<TerraformMap<string>>? RegionalParameters { get; set; }

}
