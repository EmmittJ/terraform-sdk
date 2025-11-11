using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_appconfig_deployment_strategy resource.
/// </summary>
public partial class AwsAppconfigDeploymentStrategy : TerraformResource
{
    public AwsAppconfigDeploymentStrategy(string name) : base("aws_appconfig_deployment_strategy", name)
    {
    }

    /// <summary>
    /// The deployment_duration_in_minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentDurationInMinutes is required")]
    [TerraformProperty("deployment_duration_in_minutes")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> DeploymentDurationInMinutes { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The final_bake_time_in_minutes attribute.
    /// </summary>
    [TerraformProperty("final_bake_time_in_minutes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? FinalBakeTimeInMinutes { get; set; }

    /// <summary>
    /// The growth_factor attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GrowthFactor is required")]
    [TerraformProperty("growth_factor")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> GrowthFactor { get; set; }

    /// <summary>
    /// The growth_type attribute.
    /// </summary>
    [TerraformProperty("growth_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GrowthType { get; set; }

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
    /// The replicate_to attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicateTo is required")]
    [TerraformProperty("replicate_to")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ReplicateTo { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
