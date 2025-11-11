using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecs_task_definition.
/// </summary>
public partial class AwsEcsTaskDefinitionDataSource : TerraformDataSource
{
    public AwsEcsTaskDefinitionDataSource(string name) : base("aws_ecs_task_definition", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The task_definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskDefinition is required")]
    [TerraformProperty("task_definition")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TaskDefinition { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The arn_without_revision attribute.
    /// </summary>
    [TerraformProperty("arn_without_revision")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ArnWithoutRevision { get; }

    /// <summary>
    /// The container_definitions attribute.
    /// </summary>
    [TerraformProperty("container_definitions")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ContainerDefinitions { get; }

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [TerraformProperty("cpu")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Cpu { get; }

    /// <summary>
    /// The enable_fault_injection attribute.
    /// </summary>
    [TerraformProperty("enable_fault_injection")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> EnableFaultInjection { get; }

    /// <summary>
    /// The ephemeral_storage attribute.
    /// </summary>
    [TerraformProperty("ephemeral_storage")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> EphemeralStorage { get; }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [TerraformProperty("execution_role_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ExecutionRoleArn { get; }

    /// <summary>
    /// The family attribute.
    /// </summary>
    [TerraformProperty("family")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Family { get; }

    /// <summary>
    /// The ipc_mode attribute.
    /// </summary>
    [TerraformProperty("ipc_mode")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IpcMode { get; }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [TerraformProperty("memory")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Memory { get; }

    /// <summary>
    /// The network_mode attribute.
    /// </summary>
    [TerraformProperty("network_mode")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NetworkMode { get; }

    /// <summary>
    /// The pid_mode attribute.
    /// </summary>
    [TerraformProperty("pid_mode")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PidMode { get; }

    /// <summary>
    /// The placement_constraints attribute.
    /// </summary>
    [TerraformProperty("placement_constraints")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> PlacementConstraints { get; }

    /// <summary>
    /// The proxy_configuration attribute.
    /// </summary>
    [TerraformProperty("proxy_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ProxyConfiguration { get; }

    /// <summary>
    /// The requires_compatibilities attribute.
    /// </summary>
    [TerraformProperty("requires_compatibilities")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> RequiresCompatibilities { get; }

    /// <summary>
    /// The revision attribute.
    /// </summary>
    [TerraformProperty("revision")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Revision { get; }

    /// <summary>
    /// The runtime_platform attribute.
    /// </summary>
    [TerraformProperty("runtime_platform")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> RuntimePlatform { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// The task_role_arn attribute.
    /// </summary>
    [TerraformProperty("task_role_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TaskRoleArn { get; }

    /// <summary>
    /// The volume attribute.
    /// </summary>
    [TerraformProperty("volume")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> Volume { get; }

}
