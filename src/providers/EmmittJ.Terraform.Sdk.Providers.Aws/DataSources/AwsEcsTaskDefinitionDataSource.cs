using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecs_task_definition.
/// </summary>
public class AwsEcsTaskDefinitionDataSource : TerraformDataSource
{
    public AwsEcsTaskDefinitionDataSource(string name) : base("aws_ecs_task_definition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("arn_without_revision");
        this.DeclareOutput("container_definitions");
        this.DeclareOutput("cpu");
        this.DeclareOutput("enable_fault_injection");
        this.DeclareOutput("ephemeral_storage");
        this.DeclareOutput("execution_role_arn");
        this.DeclareOutput("family");
        this.DeclareOutput("ipc_mode");
        this.DeclareOutput("memory");
        this.DeclareOutput("network_mode");
        this.DeclareOutput("pid_mode");
        this.DeclareOutput("placement_constraints");
        this.DeclareOutput("proxy_configuration");
        this.DeclareOutput("requires_compatibilities");
        this.DeclareOutput("revision");
        this.DeclareOutput("runtime_platform");
        this.DeclareOutput("status");
        this.DeclareOutput("task_role_arn");
        this.DeclareOutput("volume");
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
        get => GetRequiredProperty<TerraformProperty<string>>("task_definition");
        set => this.WithProperty("task_definition", value);
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
    /// The container_definitions attribute.
    /// </summary>
    public TerraformExpression ContainerDefinitions => this["container_definitions"];

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    public TerraformExpression Cpu => this["cpu"];

    /// <summary>
    /// The enable_fault_injection attribute.
    /// </summary>
    public TerraformExpression EnableFaultInjection => this["enable_fault_injection"];

    /// <summary>
    /// The ephemeral_storage attribute.
    /// </summary>
    public TerraformExpression EphemeralStorage => this["ephemeral_storage"];

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    public TerraformExpression ExecutionRoleArn => this["execution_role_arn"];

    /// <summary>
    /// The family attribute.
    /// </summary>
    public TerraformExpression Family => this["family"];

    /// <summary>
    /// The ipc_mode attribute.
    /// </summary>
    public TerraformExpression IpcMode => this["ipc_mode"];

    /// <summary>
    /// The memory attribute.
    /// </summary>
    public TerraformExpression Memory => this["memory"];

    /// <summary>
    /// The network_mode attribute.
    /// </summary>
    public TerraformExpression NetworkMode => this["network_mode"];

    /// <summary>
    /// The pid_mode attribute.
    /// </summary>
    public TerraformExpression PidMode => this["pid_mode"];

    /// <summary>
    /// The placement_constraints attribute.
    /// </summary>
    public TerraformExpression PlacementConstraints => this["placement_constraints"];

    /// <summary>
    /// The proxy_configuration attribute.
    /// </summary>
    public TerraformExpression ProxyConfiguration => this["proxy_configuration"];

    /// <summary>
    /// The requires_compatibilities attribute.
    /// </summary>
    public TerraformExpression RequiresCompatibilities => this["requires_compatibilities"];

    /// <summary>
    /// The revision attribute.
    /// </summary>
    public TerraformExpression Revision => this["revision"];

    /// <summary>
    /// The runtime_platform attribute.
    /// </summary>
    public TerraformExpression RuntimePlatform => this["runtime_platform"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The task_role_arn attribute.
    /// </summary>
    public TerraformExpression TaskRoleArn => this["task_role_arn"];

    /// <summary>
    /// The volume attribute.
    /// </summary>
    public TerraformExpression Volume => this["volume"];

}
