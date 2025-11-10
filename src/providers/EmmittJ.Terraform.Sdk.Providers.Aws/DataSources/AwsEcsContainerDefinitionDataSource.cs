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
    public required TerraformProperty<TerraformProperty<string>> ContainerName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The task_definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskDefinition is required")]
    [TerraformPropertyName("task_definition")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TaskDefinition { get; set; }

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [TerraformPropertyName("cpu")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Cpu => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "cpu");

    /// <summary>
    /// The disable_networking attribute.
    /// </summary>
    [TerraformPropertyName("disable_networking")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DisableNetworking => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "disable_networking");

    /// <summary>
    /// The docker_labels attribute.
    /// </summary>
    [TerraformPropertyName("docker_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> DockerLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "docker_labels");

    /// <summary>
    /// The environment attribute.
    /// </summary>
    [TerraformPropertyName("environment")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Environment => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "environment");

    /// <summary>
    /// The image attribute.
    /// </summary>
    [TerraformPropertyName("image")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Image => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "image");

    /// <summary>
    /// The image_digest attribute.
    /// </summary>
    [TerraformPropertyName("image_digest")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ImageDigest => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "image_digest");

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [TerraformPropertyName("memory")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Memory => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "memory");

    /// <summary>
    /// The memory_reservation attribute.
    /// </summary>
    [TerraformPropertyName("memory_reservation")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MemoryReservation => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "memory_reservation");

}
