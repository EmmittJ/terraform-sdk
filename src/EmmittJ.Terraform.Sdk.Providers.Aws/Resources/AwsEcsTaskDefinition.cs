using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ecs_task_definition resource.
/// </summary>
public class AwsEcsTaskDefinition : TerraformResource
{
    public AwsEcsTaskDefinition(string name) : base("aws_ecs_task_definition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("arn_without_revision");
        this.DeclareOutput("revision");
    }

    /// <summary>
    /// The container_definitions attribute.
    /// </summary>
    public TerraformProperty<string>? ContainerDefinitions
    {
        get => GetProperty<TerraformProperty<string>>("container_definitions");
        set => this.WithProperty("container_definitions", value);
    }

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    public TerraformProperty<string>? Cpu
    {
        get => GetProperty<TerraformProperty<string>>("cpu");
        set => this.WithProperty("cpu", value);
    }

    /// <summary>
    /// The enable_fault_injection attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableFaultInjection
    {
        get => GetProperty<TerraformProperty<bool>>("enable_fault_injection");
        set => this.WithProperty("enable_fault_injection", value);
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ExecutionRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("execution_role_arn");
        set => this.WithProperty("execution_role_arn", value);
    }

    /// <summary>
    /// The family attribute.
    /// </summary>
    public TerraformProperty<string>? Family
    {
        get => GetProperty<TerraformProperty<string>>("family");
        set => this.WithProperty("family", value);
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
    /// The ipc_mode attribute.
    /// </summary>
    public TerraformProperty<string>? IpcMode
    {
        get => GetProperty<TerraformProperty<string>>("ipc_mode");
        set => this.WithProperty("ipc_mode", value);
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    public TerraformProperty<string>? Memory
    {
        get => GetProperty<TerraformProperty<string>>("memory");
        set => this.WithProperty("memory", value);
    }

    /// <summary>
    /// The network_mode attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkMode
    {
        get => GetProperty<TerraformProperty<string>>("network_mode");
        set => this.WithProperty("network_mode", value);
    }

    /// <summary>
    /// The pid_mode attribute.
    /// </summary>
    public TerraformProperty<string>? PidMode
    {
        get => GetProperty<TerraformProperty<string>>("pid_mode");
        set => this.WithProperty("pid_mode", value);
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
    /// The requires_compatibilities attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? RequiresCompatibilities
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("requires_compatibilities");
        set => this.WithProperty("requires_compatibilities", value);
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public TerraformProperty<bool>? SkipDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("skip_destroy");
        set => this.WithProperty("skip_destroy", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The task_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? TaskRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("task_role_arn");
        set => this.WithProperty("task_role_arn", value);
    }

    /// <summary>
    /// The track_latest attribute.
    /// </summary>
    public TerraformProperty<bool>? TrackLatest
    {
        get => GetProperty<TerraformProperty<bool>>("track_latest");
        set => this.WithProperty("track_latest", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The arn_without_revision attribute.
    /// </summary>
    public TerraformExpression ArnWithoutRevision => this["arn_without_revision"];

    /// <summary>
    /// The revision attribute.
    /// </summary>
    public TerraformExpression Revision => this["revision"];

}
