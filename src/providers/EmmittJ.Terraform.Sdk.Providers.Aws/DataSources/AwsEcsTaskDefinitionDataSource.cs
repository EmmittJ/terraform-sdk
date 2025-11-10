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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The task_definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskDefinition is required")]
    [TerraformPropertyName("task_definition")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TaskDefinition { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The arn_without_revision attribute.
    /// </summary>
    [TerraformPropertyName("arn_without_revision")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ArnWithoutRevision => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn_without_revision");

    /// <summary>
    /// The container_definitions attribute.
    /// </summary>
    [TerraformPropertyName("container_definitions")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ContainerDefinitions => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "container_definitions");

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [TerraformPropertyName("cpu")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Cpu => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cpu");

    /// <summary>
    /// The enable_fault_injection attribute.
    /// </summary>
    [TerraformPropertyName("enable_fault_injection")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableFaultInjection => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_fault_injection");

    /// <summary>
    /// The ephemeral_storage attribute.
    /// </summary>
    [TerraformPropertyName("ephemeral_storage")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EphemeralStorage => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "ephemeral_storage");

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("execution_role_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExecutionRoleArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "execution_role_arn");

    /// <summary>
    /// The family attribute.
    /// </summary>
    [TerraformPropertyName("family")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Family => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "family");

    /// <summary>
    /// The ipc_mode attribute.
    /// </summary>
    [TerraformPropertyName("ipc_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IpcMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ipc_mode");

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [TerraformPropertyName("memory")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Memory => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "memory");

    /// <summary>
    /// The network_mode attribute.
    /// </summary>
    [TerraformPropertyName("network_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NetworkMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_mode");

    /// <summary>
    /// The pid_mode attribute.
    /// </summary>
    [TerraformPropertyName("pid_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PidMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "pid_mode");

    /// <summary>
    /// The placement_constraints attribute.
    /// </summary>
    [TerraformPropertyName("placement_constraints")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> PlacementConstraints => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "placement_constraints");

    /// <summary>
    /// The proxy_configuration attribute.
    /// </summary>
    [TerraformPropertyName("proxy_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ProxyConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "proxy_configuration");

    /// <summary>
    /// The requires_compatibilities attribute.
    /// </summary>
    [TerraformPropertyName("requires_compatibilities")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> RequiresCompatibilities => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "requires_compatibilities");

    /// <summary>
    /// The revision attribute.
    /// </summary>
    [TerraformPropertyName("revision")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Revision => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "revision");

    /// <summary>
    /// The runtime_platform attribute.
    /// </summary>
    [TerraformPropertyName("runtime_platform")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> RuntimePlatform => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "runtime_platform");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The task_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("task_role_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TaskRoleArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "task_role_arn");

    /// <summary>
    /// The volume attribute.
    /// </summary>
    [TerraformPropertyName("volume")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> Volume => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "volume");

}
