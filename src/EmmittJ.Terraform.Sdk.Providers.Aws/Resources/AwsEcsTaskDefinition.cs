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
    public TerraformLiteralProperty<string>? ContainerDefinitions
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_definitions");
        set => this.WithProperty("container_definitions", value);
    }

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Cpu
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cpu");
        set => this.WithProperty("cpu", value);
    }

    /// <summary>
    /// The enable_fault_injection attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableFaultInjection
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_fault_injection");
        set => this.WithProperty("enable_fault_injection", value);
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ExecutionRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("execution_role_arn");
        set => this.WithProperty("execution_role_arn", value);
    }

    /// <summary>
    /// The family attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Family
    {
        get => GetProperty<TerraformLiteralProperty<string>>("family");
        set => this.WithProperty("family", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The ipc_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IpcMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ipc_mode");
        set => this.WithProperty("ipc_mode", value);
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Memory
    {
        get => GetProperty<TerraformLiteralProperty<string>>("memory");
        set => this.WithProperty("memory", value);
    }

    /// <summary>
    /// The network_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NetworkMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_mode");
        set => this.WithProperty("network_mode", value);
    }

    /// <summary>
    /// The pid_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PidMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pid_mode");
        set => this.WithProperty("pid_mode", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The requires_compatibilities attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? RequiresCompatibilities
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("requires_compatibilities");
        set => this.WithProperty("requires_compatibilities", value);
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SkipDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("skip_destroy");
        set => this.WithProperty("skip_destroy", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The task_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TaskRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("task_role_arn");
        set => this.WithProperty("task_role_arn", value);
    }

    /// <summary>
    /// The track_latest attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? TrackLatest
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("track_latest");
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
