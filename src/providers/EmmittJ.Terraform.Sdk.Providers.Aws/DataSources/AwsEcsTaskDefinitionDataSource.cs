using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecs_task_definition.
/// </summary>
public class AwsEcsTaskDefinitionDataSource : TerraformDataSource
{
    public AwsEcsTaskDefinitionDataSource(string name) : base("aws_ecs_task_definition", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The task_definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskDefinition is required")]
    [TerraformPropertyName("task_definition")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TaskDefinition { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The arn_without_revision attribute.
    /// </summary>
    [TerraformPropertyName("arn_without_revision")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ArnWithoutRevision => new TerraformReference(this, "arn_without_revision");

    /// <summary>
    /// The container_definitions attribute.
    /// </summary>
    [TerraformPropertyName("container_definitions")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ContainerDefinitions => new TerraformReference(this, "container_definitions");

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [TerraformPropertyName("cpu")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Cpu => new TerraformReference(this, "cpu");

    /// <summary>
    /// The enable_fault_injection attribute.
    /// </summary>
    [TerraformPropertyName("enable_fault_injection")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnableFaultInjection => new TerraformReference(this, "enable_fault_injection");

    /// <summary>
    /// The ephemeral_storage attribute.
    /// </summary>
    [TerraformPropertyName("ephemeral_storage")]
    // Output-only attribute - read-only reference
    public TerraformList<object> EphemeralStorage => new TerraformReference(this, "ephemeral_storage");

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("execution_role_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ExecutionRoleArn => new TerraformReference(this, "execution_role_arn");

    /// <summary>
    /// The family attribute.
    /// </summary>
    [TerraformPropertyName("family")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Family => new TerraformReference(this, "family");

    /// <summary>
    /// The ipc_mode attribute.
    /// </summary>
    [TerraformPropertyName("ipc_mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IpcMode => new TerraformReference(this, "ipc_mode");

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [TerraformPropertyName("memory")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Memory => new TerraformReference(this, "memory");

    /// <summary>
    /// The network_mode attribute.
    /// </summary>
    [TerraformPropertyName("network_mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NetworkMode => new TerraformReference(this, "network_mode");

    /// <summary>
    /// The pid_mode attribute.
    /// </summary>
    [TerraformPropertyName("pid_mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PidMode => new TerraformReference(this, "pid_mode");

    /// <summary>
    /// The placement_constraints attribute.
    /// </summary>
    [TerraformPropertyName("placement_constraints")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> PlacementConstraints => new TerraformReference(this, "placement_constraints");

    /// <summary>
    /// The proxy_configuration attribute.
    /// </summary>
    [TerraformPropertyName("proxy_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ProxyConfiguration => new TerraformReference(this, "proxy_configuration");

    /// <summary>
    /// The requires_compatibilities attribute.
    /// </summary>
    [TerraformPropertyName("requires_compatibilities")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> RequiresCompatibilities => new TerraformReference(this, "requires_compatibilities");

    /// <summary>
    /// The revision attribute.
    /// </summary>
    [TerraformPropertyName("revision")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Revision => new TerraformReference(this, "revision");

    /// <summary>
    /// The runtime_platform attribute.
    /// </summary>
    [TerraformPropertyName("runtime_platform")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RuntimePlatform => new TerraformReference(this, "runtime_platform");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The task_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("task_role_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TaskRoleArn => new TerraformReference(this, "task_role_arn");

    /// <summary>
    /// The volume attribute.
    /// </summary>
    [TerraformPropertyName("volume")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> Volume => new TerraformReference(this, "volume");

}
