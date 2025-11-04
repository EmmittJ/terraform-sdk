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
    public string? ContainerDefinitions
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_definitions")?.Value;
        set => this.WithProperty("container_definitions", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    public string? Cpu
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cpu")?.Value;
        set => this.WithProperty("cpu", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enable_fault_injection attribute.
    /// </summary>
    public bool? EnableFaultInjection
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_fault_injection")?.Value;
        set => this.WithProperty("enable_fault_injection", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    public string? ExecutionRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("execution_role_arn")?.Value;
        set => this.WithProperty("execution_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The family attribute.
    /// </summary>
    public string? Family
    {
        get => GetProperty<TerraformLiteralProperty<string>>("family")?.Value;
        set => this.WithProperty("family", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The ipc_mode attribute.
    /// </summary>
    public string? IpcMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ipc_mode")?.Value;
        set => this.WithProperty("ipc_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    public string? Memory
    {
        get => GetProperty<TerraformLiteralProperty<string>>("memory")?.Value;
        set => this.WithProperty("memory", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The network_mode attribute.
    /// </summary>
    public string? NetworkMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_mode")?.Value;
        set => this.WithProperty("network_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The pid_mode attribute.
    /// </summary>
    public string? PidMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pid_mode")?.Value;
        set => this.WithProperty("pid_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The requires_compatibilities attribute.
    /// </summary>
    public HashSet<string>? RequiresCompatibilities
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("requires_compatibilities")?.Value;
        set => this.WithProperty("requires_compatibilities", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public bool? SkipDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("skip_destroy")?.Value;
        set => this.WithProperty("skip_destroy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The task_role_arn attribute.
    /// </summary>
    public string? TaskRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("task_role_arn")?.Value;
        set => this.WithProperty("task_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The track_latest attribute.
    /// </summary>
    public bool? TrackLatest
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("track_latest")?.Value;
        set => this.WithProperty("track_latest", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
