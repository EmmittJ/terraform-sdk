using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecs_cluster.
/// </summary>
public partial class AwsEcsClusterDataSource : TerraformDataSource
{
    public AwsEcsClusterDataSource(string name) : base("aws_ecs_cluster", name)
    {
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    [TerraformProperty("cluster_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ClusterName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The pending_tasks_count attribute.
    /// </summary>
    [TerraformProperty("pending_tasks_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> PendingTasksCount { get; }

    /// <summary>
    /// The registered_container_instances_count attribute.
    /// </summary>
    [TerraformProperty("registered_container_instances_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> RegisteredContainerInstancesCount { get; }

    /// <summary>
    /// The running_tasks_count attribute.
    /// </summary>
    [TerraformProperty("running_tasks_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> RunningTasksCount { get; }

    /// <summary>
    /// The service_connect_defaults attribute.
    /// </summary>
    [TerraformProperty("service_connect_defaults")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ServiceConnectDefaults { get; }

    /// <summary>
    /// The setting attribute.
    /// </summary>
    [TerraformProperty("setting")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<object> Setting { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

}
