using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_autoscaling_group.
/// </summary>
public partial class AwsAutoscalingGroupDataSource : TerraformDataSource
{
    public AwsAutoscalingGroupDataSource(string name) : base("aws_autoscaling_group", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformProperty("availability_zones")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> AvailabilityZones { get; }

    /// <summary>
    /// The default_cooldown attribute.
    /// </summary>
    [TerraformProperty("default_cooldown")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> DefaultCooldown { get; }

    /// <summary>
    /// The desired_capacity attribute.
    /// </summary>
    [TerraformProperty("desired_capacity")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> DesiredCapacity { get; }

    /// <summary>
    /// The desired_capacity_type attribute.
    /// </summary>
    [TerraformProperty("desired_capacity_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DesiredCapacityType { get; }

    /// <summary>
    /// The enabled_metrics attribute.
    /// </summary>
    [TerraformProperty("enabled_metrics")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> EnabledMetrics { get; }

    /// <summary>
    /// The health_check_grace_period attribute.
    /// </summary>
    [TerraformProperty("health_check_grace_period")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> HealthCheckGracePeriod { get; }

    /// <summary>
    /// The health_check_type attribute.
    /// </summary>
    [TerraformProperty("health_check_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> HealthCheckType { get; }

    /// <summary>
    /// The instance_maintenance_policy attribute.
    /// </summary>
    [TerraformProperty("instance_maintenance_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> InstanceMaintenancePolicy { get; }

    /// <summary>
    /// The launch_configuration attribute.
    /// </summary>
    [TerraformProperty("launch_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LaunchConfiguration { get; }

    /// <summary>
    /// The launch_template attribute.
    /// </summary>
    [TerraformProperty("launch_template")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> LaunchTemplate { get; }

    /// <summary>
    /// The load_balancers attribute.
    /// </summary>
    [TerraformProperty("load_balancers")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> LoadBalancers { get; }

    /// <summary>
    /// The max_instance_lifetime attribute.
    /// </summary>
    [TerraformProperty("max_instance_lifetime")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> MaxInstanceLifetime { get; }

    /// <summary>
    /// The max_size attribute.
    /// </summary>
    [TerraformProperty("max_size")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> MaxSize { get; }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    [TerraformProperty("min_size")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> MinSize { get; }

    /// <summary>
    /// The mixed_instances_policy attribute.
    /// </summary>
    [TerraformProperty("mixed_instances_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> MixedInstancesPolicy { get; }

    /// <summary>
    /// The new_instances_protected_from_scale_in attribute.
    /// </summary>
    [TerraformProperty("new_instances_protected_from_scale_in")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> NewInstancesProtectedFromScaleIn { get; }

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    [TerraformProperty("placement_group")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PlacementGroup { get; }

    /// <summary>
    /// The predicted_capacity attribute.
    /// </summary>
    [TerraformProperty("predicted_capacity")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> PredictedCapacity { get; }

    /// <summary>
    /// The service_linked_role_arn attribute.
    /// </summary>
    [TerraformProperty("service_linked_role_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ServiceLinkedRoleArn { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

    /// <summary>
    /// The suspended_processes attribute.
    /// </summary>
    [TerraformProperty("suspended_processes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> SuspendedProcesses { get; }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    [TerraformProperty("tag")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<object> Tag { get; }

    /// <summary>
    /// The target_group_arns attribute.
    /// </summary>
    [TerraformProperty("target_group_arns")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> TargetGroupArns { get; }

    /// <summary>
    /// The termination_policies attribute.
    /// </summary>
    [TerraformProperty("termination_policies")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> TerminationPolicies { get; }

    /// <summary>
    /// The traffic_source attribute.
    /// </summary>
    [TerraformProperty("traffic_source")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<object> TrafficSource { get; }

    /// <summary>
    /// The vpc_zone_identifier attribute.
    /// </summary>
    [TerraformProperty("vpc_zone_identifier")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VpcZoneIdentifier { get; }

    /// <summary>
    /// The warm_pool attribute.
    /// </summary>
    [TerraformProperty("warm_pool")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> WarmPool { get; }

    /// <summary>
    /// The warm_pool_size attribute.
    /// </summary>
    [TerraformProperty("warm_pool_size")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> WarmPoolSize { get; }

}
