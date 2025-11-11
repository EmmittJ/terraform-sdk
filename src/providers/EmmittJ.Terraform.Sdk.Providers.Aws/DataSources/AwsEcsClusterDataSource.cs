using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecs_cluster.
/// </summary>
public class AwsEcsClusterDataSource : TerraformDataSource
{
    public AwsEcsClusterDataSource(string name) : base("aws_ecs_cluster", name)
    {
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    [TerraformPropertyName("cluster_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ClusterName { get; set; }

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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The pending_tasks_count attribute.
    /// </summary>
    [TerraformPropertyName("pending_tasks_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> PendingTasksCount => new TerraformReference(this, "pending_tasks_count");

    /// <summary>
    /// The registered_container_instances_count attribute.
    /// </summary>
    [TerraformPropertyName("registered_container_instances_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> RegisteredContainerInstancesCount => new TerraformReference(this, "registered_container_instances_count");

    /// <summary>
    /// The running_tasks_count attribute.
    /// </summary>
    [TerraformPropertyName("running_tasks_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> RunningTasksCount => new TerraformReference(this, "running_tasks_count");

    /// <summary>
    /// The service_connect_defaults attribute.
    /// </summary>
    [TerraformPropertyName("service_connect_defaults")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ServiceConnectDefaults => new TerraformReference(this, "service_connect_defaults");

    /// <summary>
    /// The setting attribute.
    /// </summary>
    [TerraformPropertyName("setting")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> Setting => new TerraformReference(this, "setting");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

}
