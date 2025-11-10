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
    public required TerraformProperty<TerraformProperty<string>> ClusterName { get; set; }

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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The pending_tasks_count attribute.
    /// </summary>
    [TerraformPropertyName("pending_tasks_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> PendingTasksCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "pending_tasks_count");

    /// <summary>
    /// The registered_container_instances_count attribute.
    /// </summary>
    [TerraformPropertyName("registered_container_instances_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> RegisteredContainerInstancesCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "registered_container_instances_count");

    /// <summary>
    /// The running_tasks_count attribute.
    /// </summary>
    [TerraformPropertyName("running_tasks_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> RunningTasksCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "running_tasks_count");

    /// <summary>
    /// The service_connect_defaults attribute.
    /// </summary>
    [TerraformPropertyName("service_connect_defaults")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ServiceConnectDefaults => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "service_connect_defaults");

    /// <summary>
    /// The setting attribute.
    /// </summary>
    [TerraformPropertyName("setting")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> Setting => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "setting");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

}
