using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecs_container_definition.
/// </summary>
public class AwsEcsContainerDefinitionDataSource : TerraformDataSource
{
    public AwsEcsContainerDefinitionDataSource(string name) : base("aws_ecs_container_definition", name)
    {
    }

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    [TerraformPropertyName("container_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ContainerName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The task_definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskDefinition is required")]
    [TerraformPropertyName("task_definition")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TaskDefinition { get; set; }

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [TerraformPropertyName("cpu")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Cpu => new TerraformReference(this, "cpu");

    /// <summary>
    /// The disable_networking attribute.
    /// </summary>
    [TerraformPropertyName("disable_networking")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DisableNetworking => new TerraformReference(this, "disable_networking");

    /// <summary>
    /// The docker_labels attribute.
    /// </summary>
    [TerraformPropertyName("docker_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> DockerLabels => new TerraformReference(this, "docker_labels");

    /// <summary>
    /// The environment attribute.
    /// </summary>
    [TerraformPropertyName("environment")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Environment => new TerraformReference(this, "environment");

    /// <summary>
    /// The image attribute.
    /// </summary>
    [TerraformPropertyName("image")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Image => new TerraformReference(this, "image");

    /// <summary>
    /// The image_digest attribute.
    /// </summary>
    [TerraformPropertyName("image_digest")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ImageDigest => new TerraformReference(this, "image_digest");

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [TerraformPropertyName("memory")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Memory => new TerraformReference(this, "memory");

    /// <summary>
    /// The memory_reservation attribute.
    /// </summary>
    [TerraformPropertyName("memory_reservation")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MemoryReservation => new TerraformReference(this, "memory_reservation");

}
