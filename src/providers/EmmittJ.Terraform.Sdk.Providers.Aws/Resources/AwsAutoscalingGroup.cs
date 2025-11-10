using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for availability_zone_distribution in .
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupAvailabilityZoneDistributionBlock : ITerraformBlock
{
    /// <summary>
    /// The capacity_distribution_strategy attribute.
    /// </summary>
    [TerraformPropertyName("capacity_distribution_strategy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CapacityDistributionStrategy { get; set; }

}

/// <summary>
/// Block type for capacity_reservation_specification in .
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupCapacityReservationSpecificationBlock : ITerraformBlock
{
    /// <summary>
    /// The capacity_reservation_preference attribute.
    /// </summary>
    [TerraformPropertyName("capacity_reservation_preference")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CapacityReservationPreference { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "capacity_reservation_preference");

}

/// <summary>
/// Block type for initial_lifecycle_hook in .
/// Nesting mode: set
/// </summary>
public class AwsAutoscalingGroupInitialLifecycleHookBlock : ITerraformBlock
{
    /// <summary>
    /// The default_result attribute.
    /// </summary>
    [TerraformPropertyName("default_result")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DefaultResult { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "default_result");

    /// <summary>
    /// The heartbeat_timeout attribute.
    /// </summary>
    [TerraformPropertyName("heartbeat_timeout")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? HeartbeatTimeout { get; set; }

    /// <summary>
    /// The lifecycle_transition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LifecycleTransition is required")]
    [TerraformPropertyName("lifecycle_transition")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LifecycleTransition { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The notification_metadata attribute.
    /// </summary>
    [TerraformPropertyName("notification_metadata")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NotificationMetadata { get; set; }

    /// <summary>
    /// The notification_target_arn attribute.
    /// </summary>
    [TerraformPropertyName("notification_target_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NotificationTargetArn { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformPropertyName("role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RoleArn { get; set; }

}

/// <summary>
/// Block type for instance_maintenance_policy in .
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupInstanceMaintenancePolicyBlock : ITerraformBlock
{
    /// <summary>
    /// The max_healthy_percentage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxHealthyPercentage is required")]
    [TerraformPropertyName("max_healthy_percentage")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MaxHealthyPercentage { get; set; }

    /// <summary>
    /// The min_healthy_percentage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinHealthyPercentage is required")]
    [TerraformPropertyName("min_healthy_percentage")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MinHealthyPercentage { get; set; }

}

/// <summary>
/// Block type for instance_refresh in .
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupInstanceRefreshBlock : ITerraformBlock
{
    /// <summary>
    /// The strategy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Strategy is required")]
    [TerraformPropertyName("strategy")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Strategy { get; set; }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    [TerraformPropertyName("triggers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Triggers { get; set; }

}

/// <summary>
/// Block type for launch_template in .
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupLaunchTemplateBlock : ITerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "name");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Version { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "version");

}

/// <summary>
/// Block type for mixed_instances_policy in .
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupMixedInstancesPolicyBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for tag in .
/// Nesting mode: set
/// </summary>
public class AwsAutoscalingGroupTagBlock : ITerraformBlock
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformPropertyName("key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Key { get; set; }

    /// <summary>
    /// The propagate_at_launch attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PropagateAtLaunch is required")]
    [TerraformPropertyName("propagate_at_launch")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> PropagateAtLaunch { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformPropertyName("value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Value { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsAutoscalingGroupTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for traffic_source in .
/// Nesting mode: set
/// </summary>
public class AwsAutoscalingGroupTrafficSourceBlock : ITerraformBlock
{
    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    [TerraformPropertyName("identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Identifier { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Type { get; set; }

}

/// <summary>
/// Block type for warm_pool in .
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupWarmPoolBlock : ITerraformBlock
{
    /// <summary>
    /// The max_group_prepared_capacity attribute.
    /// </summary>
    [TerraformPropertyName("max_group_prepared_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxGroupPreparedCapacity { get; set; }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    [TerraformPropertyName("min_size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MinSize { get; set; }

    /// <summary>
    /// The pool_state attribute.
    /// </summary>
    [TerraformPropertyName("pool_state")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PoolState { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> AvailabilityZones { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "availability_zones");

    /// <summary>
    /// The capacity_rebalance attribute.
    /// </summary>
    [TerraformPropertyName("capacity_rebalance")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CapacityRebalance { get; set; }

    /// <summary>
    /// The context attribute.
    /// </summary>
    [TerraformPropertyName("context")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Context { get; set; }

    /// <summary>
    /// The default_cooldown attribute.
    /// </summary>
    [TerraformPropertyName("default_cooldown")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> DefaultCooldown { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "default_cooldown");

    /// <summary>
    /// The default_instance_warmup attribute.
    /// </summary>
    [TerraformPropertyName("default_instance_warmup")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DefaultInstanceWarmup { get; set; }

    /// <summary>
    /// The desired_capacity attribute.
    /// </summary>
    [TerraformPropertyName("desired_capacity")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> DesiredCapacity { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "desired_capacity");

    /// <summary>
    /// The desired_capacity_type attribute.
    /// </summary>
    [TerraformPropertyName("desired_capacity_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DesiredCapacityType { get; set; }

    /// <summary>
    /// The enabled_metrics attribute.
    /// </summary>
    [TerraformPropertyName("enabled_metrics")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? EnabledMetrics { get; set; }

    /// <summary>
    /// The force_delete attribute.
    /// </summary>
    [TerraformPropertyName("force_delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ForceDelete { get; set; }

    /// <summary>
    /// The force_delete_warm_pool attribute.
    /// </summary>
    [TerraformPropertyName("force_delete_warm_pool")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ForceDeleteWarmPool { get; set; }

    /// <summary>
    /// The health_check_grace_period attribute.
    /// </summary>
    [TerraformPropertyName("health_check_grace_period")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? HealthCheckGracePeriod { get; set; }

    /// <summary>
    /// The health_check_type attribute.
    /// </summary>
    [TerraformPropertyName("health_check_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> HealthCheckType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "health_check_type");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ignore_failed_scaling_activities attribute.
    /// </summary>
    [TerraformPropertyName("ignore_failed_scaling_activities")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IgnoreFailedScalingActivities { get; set; }

    /// <summary>
    /// The launch_configuration attribute.
    /// </summary>
    [TerraformPropertyName("launch_configuration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LaunchConfiguration { get; set; }

    /// <summary>
    /// The load_balancers attribute.
    /// </summary>
    [TerraformPropertyName("load_balancers")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> LoadBalancers { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "load_balancers");

    /// <summary>
    /// The max_instance_lifetime attribute.
    /// </summary>
    [TerraformPropertyName("max_instance_lifetime")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxInstanceLifetime { get; set; }

    /// <summary>
    /// The max_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxSize is required")]
    [TerraformPropertyName("max_size")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MaxSize { get; set; }

    /// <summary>
    /// The metrics_granularity attribute.
    /// </summary>
    [TerraformPropertyName("metrics_granularity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MetricsGranularity { get; set; }

    /// <summary>
    /// The min_elb_capacity attribute.
    /// </summary>
    [TerraformPropertyName("min_elb_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MinElbCapacity { get; set; }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinSize is required")]
    [TerraformPropertyName("min_size")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MinSize { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NamePrefix { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name_prefix");

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    [TerraformPropertyName("placement_group")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PlacementGroup { get; set; }

    /// <summary>
    /// The protect_from_scale_in attribute.
    /// </summary>
    [TerraformPropertyName("protect_from_scale_in")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ProtectFromScaleIn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The service_linked_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("service_linked_role_arn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ServiceLinkedRoleArn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_linked_role_arn");

    /// <summary>
    /// The suspended_processes attribute.
    /// </summary>
    [TerraformPropertyName("suspended_processes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SuspendedProcesses { get; set; }

    /// <summary>
    /// The target_group_arns attribute.
    /// </summary>
    [TerraformPropertyName("target_group_arns")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> TargetGroupArns { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "target_group_arns");

    /// <summary>
    /// The termination_policies attribute.
    /// </summary>
    [TerraformPropertyName("termination_policies")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? TerminationPolicies { get; set; }

    /// <summary>
    /// The vpc_zone_identifier attribute.
    /// </summary>
    [TerraformPropertyName("vpc_zone_identifier")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> VpcZoneIdentifier { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "vpc_zone_identifier");

    /// <summary>
    /// The wait_for_capacity_timeout attribute.
    /// </summary>
    [TerraformPropertyName("wait_for_capacity_timeout")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? WaitForCapacityTimeout { get; set; }

    /// <summary>
    /// The wait_for_elb_capacity attribute.
    /// </summary>
    [TerraformPropertyName("wait_for_elb_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? WaitForElbCapacity { get; set; }

    /// <summary>
    /// Block for availability_zone_distribution.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AvailabilityZoneDistribution block(s) allowed")]
    [TerraformPropertyName("availability_zone_distribution")]
    public TerraformList<TerraformBlock<AwsAutoscalingGroupAvailabilityZoneDistributionBlock>>? AvailabilityZoneDistribution { get; set; } = new();

    /// <summary>
    /// Block for capacity_reservation_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityReservationSpecification block(s) allowed")]
    [TerraformPropertyName("capacity_reservation_specification")]
    public TerraformList<TerraformBlock<AwsAutoscalingGroupCapacityReservationSpecificationBlock>>? CapacityReservationSpecification { get; set; } = new();

    /// <summary>
    /// Block for initial_lifecycle_hook.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("initial_lifecycle_hook")]
    public TerraformSet<TerraformBlock<AwsAutoscalingGroupInitialLifecycleHookBlock>>? InitialLifecycleHook { get; set; } = new();

    /// <summary>
    /// Block for instance_maintenance_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceMaintenancePolicy block(s) allowed")]
    [TerraformPropertyName("instance_maintenance_policy")]
    public TerraformList<TerraformBlock<AwsAutoscalingGroupInstanceMaintenancePolicyBlock>>? InstanceMaintenancePolicy { get; set; } = new();

    /// <summary>
    /// Block for instance_refresh.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceRefresh block(s) allowed")]
    [TerraformPropertyName("instance_refresh")]
    public TerraformList<TerraformBlock<AwsAutoscalingGroupInstanceRefreshBlock>>? InstanceRefresh { get; set; } = new();

    /// <summary>
    /// Block for launch_template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchTemplate block(s) allowed")]
    [TerraformPropertyName("launch_template")]
    public TerraformList<TerraformBlock<AwsAutoscalingGroupLaunchTemplateBlock>>? LaunchTemplate { get; set; } = new();

    /// <summary>
    /// Block for mixed_instances_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MixedInstancesPolicy block(s) allowed")]
    [TerraformPropertyName("mixed_instances_policy")]
    public TerraformList<TerraformBlock<AwsAutoscalingGroupMixedInstancesPolicyBlock>>? MixedInstancesPolicy { get; set; } = new();

    /// <summary>
    /// Block for tag.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("tag")]
    public TerraformSet<TerraformBlock<AwsAutoscalingGroupTagBlock>>? Tag { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsAutoscalingGroupTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for traffic_source.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("traffic_source")]
    public TerraformSet<TerraformBlock<AwsAutoscalingGroupTrafficSourceBlock>>? TrafficSource { get; set; } = new();

    /// <summary>
    /// Block for warm_pool.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WarmPool block(s) allowed")]
    [TerraformPropertyName("warm_pool")]
    public TerraformList<TerraformBlock<AwsAutoscalingGroupWarmPoolBlock>>? WarmPool { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The predicted_capacity attribute.
    /// </summary>
    [TerraformPropertyName("predicted_capacity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> PredictedCapacity => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "predicted_capacity");

    /// <summary>
    /// The warm_pool_size attribute.
    /// </summary>
    [TerraformPropertyName("warm_pool_size")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> WarmPoolSize => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "warm_pool_size");

}
