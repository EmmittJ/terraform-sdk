using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecs_service.
/// </summary>
public class AwsEcsServiceDataSource : TerraformDataSource
{
    public AwsEcsServiceDataSource(string name) : base("aws_ecs_service", name)
    {
    }

    /// <summary>
    /// The cluster_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterArn is required")]
    [TerraformPropertyName("cluster_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ClusterArn { get; set; }

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
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    [TerraformPropertyName("service_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ServiceName { get; set; }

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
    /// The availability_zone_rebalancing attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone_rebalancing")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AvailabilityZoneRebalancing => new TerraformReference(this, "availability_zone_rebalancing");

    /// <summary>
    /// The desired_count attribute.
    /// </summary>
    [TerraformPropertyName("desired_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DesiredCount => new TerraformReference(this, "desired_count");

    /// <summary>
    /// The launch_type attribute.
    /// </summary>
    [TerraformPropertyName("launch_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LaunchType => new TerraformReference(this, "launch_type");

    /// <summary>
    /// The load_balancer attribute.
    /// </summary>
    [TerraformPropertyName("load_balancer")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> LoadBalancer => new TerraformReference(this, "load_balancer");

    /// <summary>
    /// The scheduling_strategy attribute.
    /// </summary>
    [TerraformPropertyName("scheduling_strategy")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SchedulingStrategy => new TerraformReference(this, "scheduling_strategy");

    /// <summary>
    /// The task_definition attribute.
    /// </summary>
    [TerraformPropertyName("task_definition")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TaskDefinition => new TerraformReference(this, "task_definition");

}
