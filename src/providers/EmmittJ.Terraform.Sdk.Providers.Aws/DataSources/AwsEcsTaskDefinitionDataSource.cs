using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ecs_task_definition Terraform data source.
/// Retrieves information about a aws_ecs_task_definition.
/// </summary>
public partial class AwsEcsTaskDefinitionDataSource(string name) : TerraformDataSource("aws_ecs_task_definition", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The task_definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskDefinition is required")]
    public required TerraformValue<string> TaskDefinition
    {
        get => GetRequiredArgument<TerraformValue<string>>("task_definition");
        set => SetArgument("task_definition", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The arn_without_revision attribute.
    /// </summary>
    public TerraformValue<string> ArnWithoutRevision
        => CreateReference("arn_without_revision");

    /// <summary>
    /// The container_definitions attribute.
    /// </summary>
    public TerraformValue<string> ContainerDefinitions
        => CreateReference("container_definitions");

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    public TerraformValue<string> Cpu
        => CreateReference("cpu");

    /// <summary>
    /// The enable_fault_injection attribute.
    /// </summary>
    public TerraformValue<bool> EnableFaultInjection
        => CreateReference("enable_fault_injection");

    /// <summary>
    /// The ephemeral_storage attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EphemeralStorage
        => CreateReference("ephemeral_storage");

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    public TerraformValue<string> ExecutionRoleArn
        => CreateReference("execution_role_arn");

    /// <summary>
    /// The family attribute.
    /// </summary>
    public TerraformValue<string> Family
        => CreateReference("family");

    /// <summary>
    /// The ipc_mode attribute.
    /// </summary>
    public TerraformValue<string> IpcMode
        => CreateReference("ipc_mode");

    /// <summary>
    /// The memory attribute.
    /// </summary>
    public TerraformValue<string> Memory
        => CreateReference("memory");

    /// <summary>
    /// The network_mode attribute.
    /// </summary>
    public TerraformValue<string> NetworkMode
        => CreateReference("network_mode");

    /// <summary>
    /// The pid_mode attribute.
    /// </summary>
    public TerraformValue<string> PidMode
        => CreateReference("pid_mode");

    /// <summary>
    /// The placement_constraints attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> PlacementConstraints
        => CreateReference("placement_constraints");

    /// <summary>
    /// The proxy_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ProxyConfiguration
        => CreateReference("proxy_configuration");

    /// <summary>
    /// The requires_compatibilities attribute.
    /// </summary>
    public TerraformSet<string> RequiresCompatibilities
        => CreateReference("requires_compatibilities");

    /// <summary>
    /// The revision attribute.
    /// </summary>
    public TerraformValue<double> Revision
        => CreateReference("revision");

    /// <summary>
    /// The runtime_platform attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RuntimePlatform
        => CreateReference("runtime_platform");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// The task_role_arn attribute.
    /// </summary>
    public TerraformValue<string> TaskRoleArn
        => CreateReference("task_role_arn");

    /// <summary>
    /// The volume attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Volume
        => CreateReference("volume");

}
