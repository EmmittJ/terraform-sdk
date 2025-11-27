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
        get => new TerraformReference<string>(this, "container_name");
        set => SetArgument("container_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The task_definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskDefinition is required")]
    public required TerraformValue<string> TaskDefinition
    {
        get => new TerraformReference<string>(this, "task_definition");
        set => SetArgument("task_definition", value);
    }

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    public TerraformValue<double> Cpu
    {
        get => new TerraformReference<double>(this, "cpu");
    }

    /// <summary>
    /// The disable_networking attribute.
    /// </summary>
    public TerraformValue<bool> DisableNetworking
    {
        get => new TerraformReference<bool>(this, "disable_networking");
    }

    /// <summary>
    /// The docker_labels attribute.
    /// </summary>
    public TerraformMap<string> DockerLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "docker_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The environment attribute.
    /// </summary>
    public TerraformMap<string> Environment
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "environment").ResolveNodes(ctx));
    }

    /// <summary>
    /// The image attribute.
    /// </summary>
    public TerraformValue<string> Image
    {
        get => new TerraformReference<string>(this, "image");
    }

    /// <summary>
    /// The image_digest attribute.
    /// </summary>
    public TerraformValue<string> ImageDigest
    {
        get => new TerraformReference<string>(this, "image_digest");
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    public TerraformValue<double> Memory
    {
        get => new TerraformReference<double>(this, "memory");
    }

    /// <summary>
    /// The memory_reservation attribute.
    /// </summary>
    public TerraformValue<double> MemoryReservation
    {
        get => new TerraformReference<double>(this, "memory_reservation");
    }

}
