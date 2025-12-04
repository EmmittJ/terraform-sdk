using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ecs_container_definition Terraform data source.
/// Retrieves information about a aws_ecs_container_definition.
/// </summary>
public partial class AwsEcsContainerDefinitionDataSource(string name) : TerraformDataSource("aws_ecs_container_definition", name)
{
    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    public required TerraformValue<string> ContainerName
    {
        get => GetArgument<TerraformValue<string>>("container_name");
        set => SetArgument("container_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The task_definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskDefinition is required")]
    public required TerraformValue<string> TaskDefinition
    {
        get => GetArgument<TerraformValue<string>>("task_definition");
        set => SetArgument("task_definition", value);
    }

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    public TerraformValue<double> Cpu
        => AsReference("cpu");

    /// <summary>
    /// The disable_networking attribute.
    /// </summary>
    public TerraformValue<bool> DisableNetworking
        => AsReference("disable_networking");

    /// <summary>
    /// The docker_labels attribute.
    /// </summary>
    public TerraformMap<string> DockerLabels
        => AsReference("docker_labels");

    /// <summary>
    /// The environment attribute.
    /// </summary>
    public TerraformMap<string> Environment
        => AsReference("environment");

    /// <summary>
    /// The image attribute.
    /// </summary>
    public TerraformValue<string> Image
        => AsReference("image");

    /// <summary>
    /// The image_digest attribute.
    /// </summary>
    public TerraformValue<string> ImageDigest
        => AsReference("image_digest");

    /// <summary>
    /// The memory attribute.
    /// </summary>
    public TerraformValue<double> Memory
        => AsReference("memory");

    /// <summary>
    /// The memory_reservation attribute.
    /// </summary>
    public TerraformValue<double> MemoryReservation
        => AsReference("memory_reservation");

}
