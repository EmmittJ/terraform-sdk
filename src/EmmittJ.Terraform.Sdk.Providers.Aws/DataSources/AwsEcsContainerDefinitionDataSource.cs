using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecs_container_definition.
/// </summary>
public class AwsEcsContainerDefinitionDataSource : TerraformDataSource
{
    public AwsEcsContainerDefinitionDataSource(string name) : base("aws_ecs_container_definition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("cpu");
        this.DeclareOutput("disable_networking");
        this.DeclareOutput("docker_labels");
        this.DeclareOutput("environment");
        this.DeclareOutput("image");
        this.DeclareOutput("image_digest");
        this.DeclareOutput("memory");
        this.DeclareOutput("memory_reservation");
    }

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    public required TerraformProperty<string> ContainerName
    {
        get => GetProperty<TerraformProperty<string>>("container_name");
        set => this.WithProperty("container_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The task_definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskDefinition is required")]
    public required TerraformProperty<string> TaskDefinition
    {
        get => GetProperty<TerraformProperty<string>>("task_definition");
        set => this.WithProperty("task_definition", value);
    }

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    public TerraformExpression Cpu => this["cpu"];

    /// <summary>
    /// The disable_networking attribute.
    /// </summary>
    public TerraformExpression DisableNetworking => this["disable_networking"];

    /// <summary>
    /// The docker_labels attribute.
    /// </summary>
    public TerraformExpression DockerLabels => this["docker_labels"];

    /// <summary>
    /// The environment attribute.
    /// </summary>
    public TerraformExpression Environment => this["environment"];

    /// <summary>
    /// The image attribute.
    /// </summary>
    public TerraformExpression Image => this["image"];

    /// <summary>
    /// The image_digest attribute.
    /// </summary>
    public TerraformExpression ImageDigest => this["image_digest"];

    /// <summary>
    /// The memory attribute.
    /// </summary>
    public TerraformExpression Memory => this["memory"];

    /// <summary>
    /// The memory_reservation attribute.
    /// </summary>
    public TerraformExpression MemoryReservation => this["memory_reservation"];

}
