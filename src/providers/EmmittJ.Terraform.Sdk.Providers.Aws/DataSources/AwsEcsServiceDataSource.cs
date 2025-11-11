using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecs_service.
/// </summary>
public partial class AwsEcsServiceDataSource : TerraformDataSource
{
    public AwsEcsServiceDataSource(string name) : base("aws_ecs_service", name)
    {
    }

    /// <summary>
    /// The cluster_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterArn is required")]
    [TerraformProperty("cluster_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClusterArn { get; set; }

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
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    [TerraformProperty("service_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServiceName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The availability_zone_rebalancing attribute.
    /// </summary>
    [TerraformProperty("availability_zone_rebalancing")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AvailabilityZoneRebalancing { get; }

    /// <summary>
    /// The desired_count attribute.
    /// </summary>
    [TerraformProperty("desired_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> DesiredCount { get; }

    /// <summary>
    /// The launch_type attribute.
    /// </summary>
    [TerraformProperty("launch_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LaunchType { get; }

    /// <summary>
    /// The load_balancer attribute.
    /// </summary>
    [TerraformProperty("load_balancer")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> LoadBalancer { get; }

    /// <summary>
    /// The scheduling_strategy attribute.
    /// </summary>
    [TerraformProperty("scheduling_strategy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SchedulingStrategy { get; }

    /// <summary>
    /// The task_definition attribute.
    /// </summary>
    [TerraformProperty("task_definition")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TaskDefinition { get; }

}
