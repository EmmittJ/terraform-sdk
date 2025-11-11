using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for availability_zone_distribution in .
/// Nesting mode: list
/// </summary>
public partial class AwsAutoscalingGroupAvailabilityZoneDistributionBlock : TerraformBlockBase
{
    /// <summary>
    /// The capacity_distribution_strategy attribute.
    /// </summary>
    [TerraformProperty("capacity_distribution_strategy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CapacityDistributionStrategy { get; set; }

}

/// <summary>
/// Block type for capacity_reservation_specification in .
/// Nesting mode: list
/// </summary>
public partial class AwsAutoscalingGroupCapacityReservationSpecificationBlock : TerraformBlockBase
{
    /// <summary>
    /// The capacity_reservation_preference attribute.
    /// </summary>
    [TerraformProperty("capacity_reservation_preference")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> CapacityReservationPreference { get; set; }

}

/// <summary>
/// Block type for initial_lifecycle_hook in .
/// Nesting mode: set
/// </summary>
public partial class AwsAutoscalingGroupInitialLifecycleHookBlock : TerraformBlockBase
{
    /// <summary>
    /// The default_result attribute.
    /// </summary>
    [TerraformProperty("default_result")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DefaultResult { get; set; }

    /// <summary>
    /// The heartbeat_timeout attribute.
    /// </summary>
    [TerraformProperty("heartbeat_timeout")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? HeartbeatTimeout { get; set; }

    /// <summary>
    /// The lifecycle_transition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LifecycleTransition is required")]
    [TerraformProperty("lifecycle_transition")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LifecycleTransition { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The notification_metadata attribute.
    /// </summary>
    [TerraformProperty("notification_metadata")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? NotificationMetadata { get; set; }

    /// <summary>
    /// The notification_target_arn attribute.
    /// </summary>
    [TerraformProperty("notification_target_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? NotificationTargetArn { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformProperty("role_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RoleArn { get; set; }

}

/// <summary>
/// Block type for instance_maintenance_policy in .
/// Nesting mode: list
/// </summary>
public partial class AwsAutoscalingGroupInstanceMaintenancePolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The max_healthy_percentage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxHealthyPercentage is required")]
    [TerraformProperty("max_healthy_percentage")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> MaxHealthyPercentage { get; set; }

    /// <summary>
    /// The min_healthy_percentage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinHealthyPercentage is required")]
    [TerraformProperty("min_healthy_percentage")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> MinHealthyPercentage { get; set; }

}

/// <summary>
/// Block type for instance_refresh in .
/// Nesting mode: list
/// </summary>
public partial class AwsAutoscalingGroupInstanceRefreshBlock : TerraformBlockBase
{
    /// <summary>
    /// The strategy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Strategy is required")]
    [TerraformProperty("strategy")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Strategy { get; set; }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    [TerraformProperty("triggers")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Triggers { get; set; }

}

/// <summary>
/// Block type for launch_template in .
/// Nesting mode: list
/// </summary>
public partial class AwsAutoscalingGroupLaunchTemplateBlock : TerraformBlockBase
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Version { get; set; }

}

/// <summary>
/// Block type for mixed_instances_policy in .
/// Nesting mode: list
/// </summary>
public partial class AwsAutoscalingGroupMixedInstancesPolicyBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for tag in .
/// Nesting mode: set
/// </summary>
public partial class AwsAutoscalingGroupTagBlock : TerraformBlockBase
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformProperty("key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Key { get; set; }

    /// <summary>
    /// The propagate_at_launch attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PropagateAtLaunch is required")]
    [TerraformProperty("propagate_at_launch")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> PropagateAtLaunch { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsAutoscalingGroupTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for traffic_source in .
/// Nesting mode: set
/// </summary>
public partial class AwsAutoscalingGroupTrafficSourceBlock : TerraformBlockBase
{
    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    [TerraformProperty("identifier")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Identifier { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Block type for warm_pool in .
/// Nesting mode: list
/// </summary>
public partial class AwsAutoscalingGroupWarmPoolBlock : TerraformBlockBase
{
    /// <summary>
    /// The max_group_prepared_capacity attribute.
    /// </summary>
    [TerraformProperty("max_group_prepared_capacity")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxGroupPreparedCapacity { get; set; }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    [TerraformProperty("min_size")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MinSize { get; set; }

    /// <summary>
    /// The pool_state attribute.
    /// </summary>
    [TerraformProperty("pool_state")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PoolState { get; set; }

}

/// <summary>
/// Manages a aws_autoscaling_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsAutoscalingGroup : TerraformResource
{
    public AwsAutoscalingGroup(string name) : base("aws_autoscaling_group", name)
    {
    }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformProperty("availability_zones")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<string> AvailabilityZones { get; set; }

    /// <summary>
    /// The capacity_rebalance attribute.
    /// </summary>
    [TerraformProperty("capacity_rebalance")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? CapacityRebalance { get; set; }

    /// <summary>
    /// The context attribute.
    /// </summary>
    [TerraformProperty("context")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Context { get; set; }

    /// <summary>
    /// The default_cooldown attribute.
    /// </summary>
    [TerraformProperty("default_cooldown")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> DefaultCooldown { get; set; }

    /// <summary>
    /// The default_instance_warmup attribute.
    /// </summary>
    [TerraformProperty("default_instance_warmup")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? DefaultInstanceWarmup { get; set; }

    /// <summary>
    /// The desired_capacity attribute.
    /// </summary>
    [TerraformProperty("desired_capacity")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> DesiredCapacity { get; set; }

    /// <summary>
    /// The desired_capacity_type attribute.
    /// </summary>
    [TerraformProperty("desired_capacity_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DesiredCapacityType { get; set; }

    /// <summary>
    /// The enabled_metrics attribute.
    /// </summary>
    [TerraformProperty("enabled_metrics")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? EnabledMetrics { get; set; }

    /// <summary>
    /// The force_delete attribute.
    /// </summary>
    [TerraformProperty("force_delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ForceDelete { get; set; }

    /// <summary>
    /// The force_delete_warm_pool attribute.
    /// </summary>
    [TerraformProperty("force_delete_warm_pool")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ForceDeleteWarmPool { get; set; }

    /// <summary>
    /// The health_check_grace_period attribute.
    /// </summary>
    [TerraformProperty("health_check_grace_period")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? HealthCheckGracePeriod { get; set; }

    /// <summary>
    /// The health_check_type attribute.
    /// </summary>
    [TerraformProperty("health_check_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> HealthCheckType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ignore_failed_scaling_activities attribute.
    /// </summary>
    [TerraformProperty("ignore_failed_scaling_activities")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IgnoreFailedScalingActivities { get; set; }

    /// <summary>
    /// The launch_configuration attribute.
    /// </summary>
    [TerraformProperty("launch_configuration")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? LaunchConfiguration { get; set; }

    /// <summary>
    /// The load_balancers attribute.
    /// </summary>
    [TerraformProperty("load_balancers")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<string> LoadBalancers { get; set; }

    /// <summary>
    /// The max_instance_lifetime attribute.
    /// </summary>
    [TerraformProperty("max_instance_lifetime")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxInstanceLifetime { get; set; }

    /// <summary>
    /// The max_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxSize is required")]
    [TerraformProperty("max_size")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> MaxSize { get; set; }

    /// <summary>
    /// The metrics_granularity attribute.
    /// </summary>
    [TerraformProperty("metrics_granularity")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MetricsGranularity { get; set; }

    /// <summary>
    /// The min_elb_capacity attribute.
    /// </summary>
    [TerraformProperty("min_elb_capacity")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MinElbCapacity { get; set; }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinSize is required")]
    [TerraformProperty("min_size")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> MinSize { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformProperty("name_prefix")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> NamePrefix { get; set; }

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    [TerraformProperty("placement_group")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PlacementGroup { get; set; }

    /// <summary>
    /// The protect_from_scale_in attribute.
    /// </summary>
    [TerraformProperty("protect_from_scale_in")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ProtectFromScaleIn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The service_linked_role_arn attribute.
    /// </summary>
    [TerraformProperty("service_linked_role_arn")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ServiceLinkedRoleArn { get; set; }

    /// <summary>
    /// The suspended_processes attribute.
    /// </summary>
    [TerraformProperty("suspended_processes")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? SuspendedProcesses { get; set; }

    /// <summary>
    /// The target_group_arns attribute.
    /// </summary>
    [TerraformProperty("target_group_arns")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<string> TargetGroupArns { get; set; }

    /// <summary>
    /// The termination_policies attribute.
    /// </summary>
    [TerraformProperty("termination_policies")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? TerminationPolicies { get; set; }

    /// <summary>
    /// The vpc_zone_identifier attribute.
    /// </summary>
    [TerraformProperty("vpc_zone_identifier")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<string> VpcZoneIdentifier { get; set; }

    /// <summary>
    /// The wait_for_capacity_timeout attribute.
    /// </summary>
    [TerraformProperty("wait_for_capacity_timeout")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? WaitForCapacityTimeout { get; set; }

    /// <summary>
    /// The wait_for_elb_capacity attribute.
    /// </summary>
    [TerraformProperty("wait_for_elb_capacity")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? WaitForElbCapacity { get; set; }

    /// <summary>
    /// Block for availability_zone_distribution.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AvailabilityZoneDistribution block(s) allowed")]
    [TerraformProperty("availability_zone_distribution")]
    public TerraformList<TerraformBlock<AwsAutoscalingGroupAvailabilityZoneDistributionBlock>>? AvailabilityZoneDistribution { get; set; }

    /// <summary>
    /// Block for capacity_reservation_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityReservationSpecification block(s) allowed")]
    [TerraformProperty("capacity_reservation_specification")]
    public TerraformList<TerraformBlock<AwsAutoscalingGroupCapacityReservationSpecificationBlock>>? CapacityReservationSpecification { get; set; }

    /// <summary>
    /// Block for initial_lifecycle_hook.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("initial_lifecycle_hook")]
    public TerraformSet<TerraformBlock<AwsAutoscalingGroupInitialLifecycleHookBlock>>? InitialLifecycleHook { get; set; }

    /// <summary>
    /// Block for instance_maintenance_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceMaintenancePolicy block(s) allowed")]
    [TerraformProperty("instance_maintenance_policy")]
    public TerraformList<TerraformBlock<AwsAutoscalingGroupInstanceMaintenancePolicyBlock>>? InstanceMaintenancePolicy { get; set; }

    /// <summary>
    /// Block for instance_refresh.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceRefresh block(s) allowed")]
    [TerraformProperty("instance_refresh")]
    public TerraformList<TerraformBlock<AwsAutoscalingGroupInstanceRefreshBlock>>? InstanceRefresh { get; set; }

    /// <summary>
    /// Block for launch_template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchTemplate block(s) allowed")]
    [TerraformProperty("launch_template")]
    public TerraformList<TerraformBlock<AwsAutoscalingGroupLaunchTemplateBlock>>? LaunchTemplate { get; set; }

    /// <summary>
    /// Block for mixed_instances_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MixedInstancesPolicy block(s) allowed")]
    [TerraformProperty("mixed_instances_policy")]
    public TerraformList<TerraformBlock<AwsAutoscalingGroupMixedInstancesPolicyBlock>>? MixedInstancesPolicy { get; set; }

    /// <summary>
    /// Block for tag.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("tag")]
    public TerraformSet<TerraformBlock<AwsAutoscalingGroupTagBlock>>? Tag { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsAutoscalingGroupTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for traffic_source.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("traffic_source")]
    public TerraformSet<TerraformBlock<AwsAutoscalingGroupTrafficSourceBlock>>? TrafficSource { get; set; }

    /// <summary>
    /// Block for warm_pool.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WarmPool block(s) allowed")]
    [TerraformProperty("warm_pool")]
    public TerraformList<TerraformBlock<AwsAutoscalingGroupWarmPoolBlock>>? WarmPool { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The predicted_capacity attribute.
    /// </summary>
    [TerraformProperty("predicted_capacity")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> PredictedCapacity { get; }

    /// <summary>
    /// The warm_pool_size attribute.
    /// </summary>
    [TerraformProperty("warm_pool_size")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> WarmPoolSize { get; }

}
