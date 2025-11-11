using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecs_container_definition.
/// </summary>
public partial class AwsEcsContainerDefinitionDataSource : TerraformDataSource
{
    public AwsEcsContainerDefinitionDataSource(string name) : base("aws_ecs_container_definition", name)
    {
    }

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    [TerraformProperty("container_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ContainerName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The task_definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskDefinition is required")]
    [TerraformProperty("task_definition")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TaskDefinition { get; set; }

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [TerraformProperty("cpu")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Cpu { get; }

    /// <summary>
    /// The disable_networking attribute.
    /// </summary>
    [TerraformProperty("disable_networking")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> DisableNetworking { get; }

    /// <summary>
    /// The docker_labels attribute.
    /// </summary>
    [TerraformProperty("docker_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> DockerLabels { get; }

    /// <summary>
    /// The environment attribute.
    /// </summary>
    [TerraformProperty("environment")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Environment { get; }

    /// <summary>
    /// The image attribute.
    /// </summary>
    [TerraformProperty("image")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Image { get; }

    /// <summary>
    /// The image_digest attribute.
    /// </summary>
    [TerraformProperty("image_digest")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ImageDigest { get; }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [TerraformProperty("memory")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Memory { get; }

    /// <summary>
    /// The memory_reservation attribute.
    /// </summary>
    [TerraformProperty("memory_reservation")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MemoryReservation { get; }

}
