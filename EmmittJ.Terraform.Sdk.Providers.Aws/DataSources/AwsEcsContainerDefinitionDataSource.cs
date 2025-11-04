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
    public string? ContainerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_name")?.Value;
        set => this.WithProperty("container_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The task_definition attribute.
    /// </summary>
    public string? TaskDefinition
    {
        get => GetProperty<TerraformLiteralProperty<string>>("task_definition")?.Value;
        set => this.WithProperty("task_definition", value == null ? null : new TerraformLiteralProperty<string>(value));
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
