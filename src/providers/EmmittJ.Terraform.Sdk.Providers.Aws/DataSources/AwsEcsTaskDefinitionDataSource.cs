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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The arn_without_revision attribute.
    /// </summary>
    public TerraformValue<string> ArnWithoutRevision
    {
        get => new TerraformReference<string>(this, "arn_without_revision");
    }

    /// <summary>
    /// The container_definitions attribute.
    /// </summary>
    public TerraformValue<string> ContainerDefinitions
    {
        get => new TerraformReference<string>(this, "container_definitions");
    }

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    public TerraformValue<string> Cpu
    {
        get => new TerraformReference<string>(this, "cpu");
    }

    /// <summary>
    /// The enable_fault_injection attribute.
    /// </summary>
    public TerraformValue<bool> EnableFaultInjection
    {
        get => new TerraformReference<bool>(this, "enable_fault_injection");
    }

    /// <summary>
    /// The ephemeral_storage attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EphemeralStorage
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "ephemeral_storage").ResolveNodes(ctx));
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    public TerraformValue<string> ExecutionRoleArn
    {
        get => new TerraformReference<string>(this, "execution_role_arn");
    }

    /// <summary>
    /// The family attribute.
    /// </summary>
    public TerraformValue<string> Family
    {
        get => new TerraformReference<string>(this, "family");
    }

    /// <summary>
    /// The ipc_mode attribute.
    /// </summary>
    public TerraformValue<string> IpcMode
    {
        get => new TerraformReference<string>(this, "ipc_mode");
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    public TerraformValue<string> Memory
    {
        get => new TerraformReference<string>(this, "memory");
    }

    /// <summary>
    /// The network_mode attribute.
    /// </summary>
    public TerraformValue<string> NetworkMode
    {
        get => new TerraformReference<string>(this, "network_mode");
    }

    /// <summary>
    /// The pid_mode attribute.
    /// </summary>
    public TerraformValue<string> PidMode
    {
        get => new TerraformReference<string>(this, "pid_mode");
    }

    /// <summary>
    /// The placement_constraints attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> PlacementConstraints
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "placement_constraints").ResolveNodes(ctx));
    }

    /// <summary>
    /// The proxy_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ProxyConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "proxy_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The requires_compatibilities attribute.
    /// </summary>
    public TerraformSet<string> RequiresCompatibilities
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "requires_compatibilities").ResolveNodes(ctx));
    }

    /// <summary>
    /// The revision attribute.
    /// </summary>
    public TerraformValue<double> Revision
    {
        get => new TerraformReference<double>(this, "revision");
    }

    /// <summary>
    /// The runtime_platform attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RuntimePlatform
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "runtime_platform").ResolveNodes(ctx));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The task_role_arn attribute.
    /// </summary>
    public TerraformValue<string> TaskRoleArn
    {
        get => new TerraformReference<string>(this, "task_role_arn");
    }

    /// <summary>
    /// The volume attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Volume
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "volume").ResolveNodes(ctx));
    }

}
