using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for availability_zone_distribution in .
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupAvailabilityZoneDistributionBlock
{
    /// <summary>
    /// The capacity_distribution_strategy attribute.
    /// </summary>
    [TerraformPropertyName("capacity_distribution_strategy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CapacityDistributionStrategy { get; set; }

}

/// <summary>
/// Block type for capacity_reservation_specification in .
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupCapacityReservationSpecificationBlock
{
    /// <summary>
    /// The capacity_reservation_preference attribute.
    /// </summary>
    [TerraformPropertyName("capacity_reservation_preference")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CapacityReservationPreference { get; set; } = default!;

}

/// <summary>
/// Block type for initial_lifecycle_hook in .
/// Nesting mode: set
/// </summary>
public class AwsAutoscalingGroupInitialLifecycleHookBlock
{
    /// <summary>
    /// The default_result attribute.
    /// </summary>
    [TerraformPropertyName("default_result")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DefaultResult { get; set; } = default!;

    /// <summary>
    /// The heartbeat_timeout attribute.
    /// </summary>
    [TerraformPropertyName("heartbeat_timeout")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? HeartbeatTimeout { get; set; }

    /// <summary>
    /// The lifecycle_transition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LifecycleTransition is required")]
    [TerraformPropertyName("lifecycle_transition")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LifecycleTransition { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The notification_metadata attribute.
    /// </summary>
    [TerraformPropertyName("notification_metadata")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NotificationMetadata { get; set; }

    /// <summary>
    /// The notification_target_arn attribute.
    /// </summary>
    [TerraformPropertyName("notification_target_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NotificationTargetArn { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformPropertyName("role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RoleArn { get; set; }

}

/// <summary>
/// Block type for instance_maintenance_policy in .
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupInstanceMaintenancePolicyBlock
{
    /// <summary>
    /// The max_healthy_percentage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxHealthyPercentage is required")]
    [TerraformPropertyName("max_healthy_percentage")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> MaxHealthyPercentage { get; set; }

    /// <summary>
    /// The min_healthy_percentage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinHealthyPercentage is required")]
    [TerraformPropertyName("min_healthy_percentage")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> MinHealthyPercentage { get; set; }

}

/// <summary>
/// Block type for instance_refresh in .
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupInstanceRefreshBlock
{
    /// <summary>
    /// The strategy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Strategy is required")]
    [TerraformPropertyName("strategy")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Strategy { get; set; }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    [TerraformPropertyName("triggers")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Triggers { get; set; }

}

/// <summary>
/// Block type for launch_template in .
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupLaunchTemplateBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Version { get; set; } = default!;

}

/// <summary>
/// Block type for mixed_instances_policy in .
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupMixedInstancesPolicyBlock
{
}

/// <summary>
/// Block type for tag in .
/// Nesting mode: set
/// </summary>
public class AwsAutoscalingGroupTagBlock
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformPropertyName("key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Key { get; set; }

    /// <summary>
    /// The propagate_at_launch attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PropagateAtLaunch is required")]
    [TerraformPropertyName("propagate_at_launch")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> PropagateAtLaunch { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformPropertyName("value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsAutoscalingGroupTimeoutsBlock
{
    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for traffic_source in .
/// Nesting mode: set
/// </summary>
public class AwsAutoscalingGroupTrafficSourceBlock
{
    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    [TerraformPropertyName("identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Identifier { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Block type for warm_pool in .
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupWarmPoolBlock
{
    /// <summary>
    /// The max_group_prepared_capacity attribute.
    /// </summary>
    [TerraformPropertyName("max_group_prepared_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxGroupPreparedCapacity { get; set; }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    [TerraformPropertyName("min_size")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MinSize { get; set; }

    /// <summary>
    /// The pool_state attribute.
    /// </summary>
    [TerraformPropertyName("pool_state")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PoolState { get; set; }

}

/// <summary>
/// Manages a aws_autoscaling_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAutoscalingGroup : TerraformResource
{
    public AwsAutoscalingGroup(string name) : base("aws_autoscaling_group", name)
    {
    }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformPropertyName("availability_zones")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> AvailabilityZones { get; set; } = default!;

    /// <summary>
    /// The capacity_rebalance attribute.
    /// </summary>
    [TerraformPropertyName("capacity_rebalance")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CapacityRebalance { get; set; }

    /// <summary>
    /// The context attribute.
    /// </summary>
    [TerraformPropertyName("context")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Context { get; set; }

    /// <summary>
    /// The default_cooldown attribute.
    /// </summary>
    [TerraformPropertyName("default_cooldown")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> DefaultCooldown { get; set; } = default!;

    /// <summary>
    /// The default_instance_warmup attribute.
    /// </summary>
    [TerraformPropertyName("default_instance_warmup")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? DefaultInstanceWarmup { get; set; }

    /// <summary>
    /// The desired_capacity attribute.
    /// </summary>
    [TerraformPropertyName("desired_capacity")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> DesiredCapacity { get; set; } = default!;

    /// <summary>
    /// The desired_capacity_type attribute.
    /// </summary>
    [TerraformPropertyName("desired_capacity_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DesiredCapacityType { get; set; }

    /// <summary>
    /// The enabled_metrics attribute.
    /// </summary>
    [TerraformPropertyName("enabled_metrics")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? EnabledMetrics { get; set; }

    /// <summary>
    /// The force_delete attribute.
    /// </summary>
    [TerraformPropertyName("force_delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ForceDelete { get; set; }

    /// <summary>
    /// The force_delete_warm_pool attribute.
    /// </summary>
    [TerraformPropertyName("force_delete_warm_pool")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ForceDeleteWarmPool { get; set; }

    /// <summary>
    /// The health_check_grace_period attribute.
    /// </summary>
    [TerraformPropertyName("health_check_grace_period")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? HealthCheckGracePeriod { get; set; }

    /// <summary>
    /// The health_check_type attribute.
    /// </summary>
    [TerraformPropertyName("health_check_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> HealthCheckType { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The ignore_failed_scaling_activities attribute.
    /// </summary>
    [TerraformPropertyName("ignore_failed_scaling_activities")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IgnoreFailedScalingActivities { get; set; }

    /// <summary>
    /// The launch_configuration attribute.
    /// </summary>
    [TerraformPropertyName("launch_configuration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LaunchConfiguration { get; set; }

    /// <summary>
    /// The load_balancers attribute.
    /// </summary>
    [TerraformPropertyName("load_balancers")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> LoadBalancers { get; set; } = default!;

    /// <summary>
    /// The max_instance_lifetime attribute.
    /// </summary>
    [TerraformPropertyName("max_instance_lifetime")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxInstanceLifetime { get; set; }

    /// <summary>
    /// The max_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxSize is required")]
    [TerraformPropertyName("max_size")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> MaxSize { get; set; }

    /// <summary>
    /// The metrics_granularity attribute.
    /// </summary>
    [TerraformPropertyName("metrics_granularity")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MetricsGranularity { get; set; }

    /// <summary>
    /// The min_elb_capacity attribute.
    /// </summary>
    [TerraformPropertyName("min_elb_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MinElbCapacity { get; set; }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinSize is required")]
    [TerraformPropertyName("min_size")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> MinSize { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NamePrefix { get; set; } = default!;

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    [TerraformPropertyName("placement_group")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PlacementGroup { get; set; }

    /// <summary>
    /// The protect_from_scale_in attribute.
    /// </summary>
    [TerraformPropertyName("protect_from_scale_in")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ProtectFromScaleIn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The service_linked_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("service_linked_role_arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ServiceLinkedRoleArn { get; set; } = default!;

    /// <summary>
    /// The suspended_processes attribute.
    /// </summary>
    [TerraformPropertyName("suspended_processes")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? SuspendedProcesses { get; set; }

    /// <summary>
    /// The target_group_arns attribute.
    /// </summary>
    [TerraformPropertyName("target_group_arns")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> TargetGroupArns { get; set; } = default!;

    /// <summary>
    /// The termination_policies attribute.
    /// </summary>
    [TerraformPropertyName("termination_policies")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? TerminationPolicies { get; set; }

    /// <summary>
    /// The vpc_zone_identifier attribute.
    /// </summary>
    [TerraformPropertyName("vpc_zone_identifier")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> VpcZoneIdentifier { get; set; } = default!;

    /// <summary>
    /// The wait_for_capacity_timeout attribute.
    /// </summary>
    [TerraformPropertyName("wait_for_capacity_timeout")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? WaitForCapacityTimeout { get; set; }

    /// <summary>
    /// The wait_for_elb_capacity attribute.
    /// </summary>
    [TerraformPropertyName("wait_for_elb_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? WaitForElbCapacity { get; set; }

    /// <summary>
    /// Block for availability_zone_distribution.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AvailabilityZoneDistribution block(s) allowed")]
    [TerraformPropertyName("availability_zone_distribution")]
    public TerraformList<TerraformBlock<AwsAutoscalingGroupAvailabilityZoneDistributionBlock>>? AvailabilityZoneDistribution { get; set; }

    /// <summary>
    /// Block for capacity_reservation_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityReservationSpecification block(s) allowed")]
    [TerraformPropertyName("capacity_reservation_specification")]
    public TerraformList<TerraformBlock<AwsAutoscalingGroupCapacityReservationSpecificationBlock>>? CapacityReservationSpecification { get; set; }

    /// <summary>
    /// Block for initial_lifecycle_hook.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("initial_lifecycle_hook")]
    public TerraformSet<TerraformBlock<AwsAutoscalingGroupInitialLifecycleHookBlock>>? InitialLifecycleHook { get; set; }

    /// <summary>
    /// Block for instance_maintenance_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceMaintenancePolicy block(s) allowed")]
    [TerraformPropertyName("instance_maintenance_policy")]
    public TerraformList<TerraformBlock<AwsAutoscalingGroupInstanceMaintenancePolicyBlock>>? InstanceMaintenancePolicy { get; set; }

    /// <summary>
    /// Block for instance_refresh.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceRefresh block(s) allowed")]
    [TerraformPropertyName("instance_refresh")]
    public TerraformList<TerraformBlock<AwsAutoscalingGroupInstanceRefreshBlock>>? InstanceRefresh { get; set; }

    /// <summary>
    /// Block for launch_template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchTemplate block(s) allowed")]
    [TerraformPropertyName("launch_template")]
    public TerraformList<TerraformBlock<AwsAutoscalingGroupLaunchTemplateBlock>>? LaunchTemplate { get; set; }

    /// <summary>
    /// Block for mixed_instances_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MixedInstancesPolicy block(s) allowed")]
    [TerraformPropertyName("mixed_instances_policy")]
    public TerraformList<TerraformBlock<AwsAutoscalingGroupMixedInstancesPolicyBlock>>? MixedInstancesPolicy { get; set; }

    /// <summary>
    /// Block for tag.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("tag")]
    public TerraformSet<TerraformBlock<AwsAutoscalingGroupTagBlock>>? Tag { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsAutoscalingGroupTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for traffic_source.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("traffic_source")]
    public TerraformSet<TerraformBlock<AwsAutoscalingGroupTrafficSourceBlock>>? TrafficSource { get; set; }

    /// <summary>
    /// Block for warm_pool.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WarmPool block(s) allowed")]
    [TerraformPropertyName("warm_pool")]
    public TerraformList<TerraformBlock<AwsAutoscalingGroupWarmPoolBlock>>? WarmPool { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The predicted_capacity attribute.
    /// </summary>
    [TerraformPropertyName("predicted_capacity")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> PredictedCapacity => new TerraformReference(this, "predicted_capacity");

    /// <summary>
    /// The warm_pool_size attribute.
    /// </summary>
    [TerraformPropertyName("warm_pool_size")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> WarmPoolSize => new TerraformReference(this, "warm_pool_size");

}
