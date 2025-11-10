using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for availability_zone_distribution in .
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupAvailabilityZoneDistributionBlock : TerraformBlock
{
    /// <summary>
    /// The capacity_distribution_strategy attribute.
    /// </summary>
    public TerraformProperty<string>? CapacityDistributionStrategy
    {
        get => GetProperty<TerraformProperty<string>>("capacity_distribution_strategy");
        set => WithProperty("capacity_distribution_strategy", value);
    }

}

/// <summary>
/// Block type for capacity_reservation_specification in .
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupCapacityReservationSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// The capacity_reservation_preference attribute.
    /// </summary>
    public TerraformProperty<string>? CapacityReservationPreference
    {
        get => GetProperty<TerraformProperty<string>>("capacity_reservation_preference");
        set => WithProperty("capacity_reservation_preference", value);
    }

}

/// <summary>
/// Block type for initial_lifecycle_hook in .
/// Nesting mode: set
/// </summary>
public class AwsAutoscalingGroupInitialLifecycleHookBlock : TerraformBlock
{
    /// <summary>
    /// The default_result attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultResult
    {
        get => GetProperty<TerraformProperty<string>>("default_result");
        set => WithProperty("default_result", value);
    }

    /// <summary>
    /// The heartbeat_timeout attribute.
    /// </summary>
    public TerraformProperty<double>? HeartbeatTimeout
    {
        get => GetProperty<TerraformProperty<double>>("heartbeat_timeout");
        set => WithProperty("heartbeat_timeout", value);
    }

    /// <summary>
    /// The lifecycle_transition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LifecycleTransition is required")]
    public required TerraformProperty<string> LifecycleTransition
    {
        get => GetProperty<TerraformProperty<string>>("lifecycle_transition");
        set => WithProperty("lifecycle_transition", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The notification_metadata attribute.
    /// </summary>
    public TerraformProperty<string>? NotificationMetadata
    {
        get => GetProperty<TerraformProperty<string>>("notification_metadata");
        set => WithProperty("notification_metadata", value);
    }

    /// <summary>
    /// The notification_target_arn attribute.
    /// </summary>
    public TerraformProperty<string>? NotificationTargetArn
    {
        get => GetProperty<TerraformProperty<string>>("notification_target_arn");
        set => WithProperty("notification_target_arn", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => WithProperty("role_arn", value);
    }

}

/// <summary>
/// Block type for instance_maintenance_policy in .
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupInstanceMaintenancePolicyBlock : TerraformBlock
{
    /// <summary>
    /// The max_healthy_percentage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxHealthyPercentage is required")]
    public required TerraformProperty<double> MaxHealthyPercentage
    {
        get => GetProperty<TerraformProperty<double>>("max_healthy_percentage");
        set => WithProperty("max_healthy_percentage", value);
    }

    /// <summary>
    /// The min_healthy_percentage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinHealthyPercentage is required")]
    public required TerraformProperty<double> MinHealthyPercentage
    {
        get => GetProperty<TerraformProperty<double>>("min_healthy_percentage");
        set => WithProperty("min_healthy_percentage", value);
    }

}

/// <summary>
/// Block type for instance_refresh in .
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupInstanceRefreshBlock : TerraformBlock
{
    /// <summary>
    /// The strategy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Strategy is required")]
    public required TerraformProperty<string> Strategy
    {
        get => GetProperty<TerraformProperty<string>>("strategy");
        set => WithProperty("strategy", value);
    }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Triggers
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("triggers");
        set => WithProperty("triggers", value);
    }

}

/// <summary>
/// Block type for launch_template in .
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupLaunchTemplateBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => WithProperty("version", value);
    }

}

/// <summary>
/// Block type for mixed_instances_policy in .
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupMixedInstancesPolicyBlock : TerraformBlock
{
}

/// <summary>
/// Block type for tag in .
/// Nesting mode: set
/// </summary>
public class AwsAutoscalingGroupTagBlock : TerraformBlock
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<string> Key
    {
        get => GetProperty<TerraformProperty<string>>("key");
        set => WithProperty("key", value);
    }

    /// <summary>
    /// The propagate_at_launch attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PropagateAtLaunch is required")]
    public required TerraformProperty<bool> PropagateAtLaunch
    {
        get => GetProperty<TerraformProperty<bool>>("propagate_at_launch");
        set => WithProperty("propagate_at_launch", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsAutoscalingGroupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for traffic_source in .
/// Nesting mode: set
/// </summary>
public class AwsAutoscalingGroupTrafficSourceBlock : TerraformBlock
{
    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    public required TerraformProperty<string> Identifier
    {
        get => GetProperty<TerraformProperty<string>>("identifier");
        set => WithProperty("identifier", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for warm_pool in .
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupWarmPoolBlock : TerraformBlock
{
    /// <summary>
    /// The max_group_prepared_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? MaxGroupPreparedCapacity
    {
        get => GetProperty<TerraformProperty<double>>("max_group_prepared_capacity");
        set => WithProperty("max_group_prepared_capacity", value);
    }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    public TerraformProperty<double>? MinSize
    {
        get => GetProperty<TerraformProperty<double>>("min_size");
        set => WithProperty("min_size", value);
    }

    /// <summary>
    /// The pool_state attribute.
    /// </summary>
    public TerraformProperty<string>? PoolState
    {
        get => GetProperty<TerraformProperty<string>>("pool_state");
        set => WithProperty("pool_state", value);
    }

}

/// <summary>
/// Manages a aws_autoscaling_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAutoscalingGroup : TerraformResource
{
    public AwsAutoscalingGroup(string name) : base("aws_autoscaling_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("predicted_capacity");
        this.DeclareOutput("warm_pool_size");
    }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AvailabilityZones
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("availability_zones");
        set => this.WithProperty("availability_zones", value);
    }

    /// <summary>
    /// The capacity_rebalance attribute.
    /// </summary>
    public TerraformProperty<bool>? CapacityRebalance
    {
        get => GetProperty<TerraformProperty<bool>>("capacity_rebalance");
        set => this.WithProperty("capacity_rebalance", value);
    }

    /// <summary>
    /// The context attribute.
    /// </summary>
    public TerraformProperty<string>? Context
    {
        get => GetProperty<TerraformProperty<string>>("context");
        set => this.WithProperty("context", value);
    }

    /// <summary>
    /// The default_cooldown attribute.
    /// </summary>
    public TerraformProperty<double>? DefaultCooldown
    {
        get => GetProperty<TerraformProperty<double>>("default_cooldown");
        set => this.WithProperty("default_cooldown", value);
    }

    /// <summary>
    /// The default_instance_warmup attribute.
    /// </summary>
    public TerraformProperty<double>? DefaultInstanceWarmup
    {
        get => GetProperty<TerraformProperty<double>>("default_instance_warmup");
        set => this.WithProperty("default_instance_warmup", value);
    }

    /// <summary>
    /// The desired_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? DesiredCapacity
    {
        get => GetProperty<TerraformProperty<double>>("desired_capacity");
        set => this.WithProperty("desired_capacity", value);
    }

    /// <summary>
    /// The desired_capacity_type attribute.
    /// </summary>
    public TerraformProperty<string>? DesiredCapacityType
    {
        get => GetProperty<TerraformProperty<string>>("desired_capacity_type");
        set => this.WithProperty("desired_capacity_type", value);
    }

    /// <summary>
    /// The enabled_metrics attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? EnabledMetrics
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("enabled_metrics");
        set => this.WithProperty("enabled_metrics", value);
    }

    /// <summary>
    /// The force_delete attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceDelete
    {
        get => GetProperty<TerraformProperty<bool>>("force_delete");
        set => this.WithProperty("force_delete", value);
    }

    /// <summary>
    /// The force_delete_warm_pool attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceDeleteWarmPool
    {
        get => GetProperty<TerraformProperty<bool>>("force_delete_warm_pool");
        set => this.WithProperty("force_delete_warm_pool", value);
    }

    /// <summary>
    /// The health_check_grace_period attribute.
    /// </summary>
    public TerraformProperty<double>? HealthCheckGracePeriod
    {
        get => GetProperty<TerraformProperty<double>>("health_check_grace_period");
        set => this.WithProperty("health_check_grace_period", value);
    }

    /// <summary>
    /// The health_check_type attribute.
    /// </summary>
    public TerraformProperty<string>? HealthCheckType
    {
        get => GetProperty<TerraformProperty<string>>("health_check_type");
        set => this.WithProperty("health_check_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The ignore_failed_scaling_activities attribute.
    /// </summary>
    public TerraformProperty<bool>? IgnoreFailedScalingActivities
    {
        get => GetProperty<TerraformProperty<bool>>("ignore_failed_scaling_activities");
        set => this.WithProperty("ignore_failed_scaling_activities", value);
    }

    /// <summary>
    /// The launch_configuration attribute.
    /// </summary>
    public TerraformProperty<string>? LaunchConfiguration
    {
        get => GetProperty<TerraformProperty<string>>("launch_configuration");
        set => this.WithProperty("launch_configuration", value);
    }

    /// <summary>
    /// The load_balancers attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? LoadBalancers
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("load_balancers");
        set => this.WithProperty("load_balancers", value);
    }

    /// <summary>
    /// The max_instance_lifetime attribute.
    /// </summary>
    public TerraformProperty<double>? MaxInstanceLifetime
    {
        get => GetProperty<TerraformProperty<double>>("max_instance_lifetime");
        set => this.WithProperty("max_instance_lifetime", value);
    }

    /// <summary>
    /// The max_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxSize is required")]
    public required TerraformProperty<double> MaxSize
    {
        get => GetProperty<TerraformProperty<double>>("max_size");
        set => this.WithProperty("max_size", value);
    }

    /// <summary>
    /// The metrics_granularity attribute.
    /// </summary>
    public TerraformProperty<string>? MetricsGranularity
    {
        get => GetProperty<TerraformProperty<string>>("metrics_granularity");
        set => this.WithProperty("metrics_granularity", value);
    }

    /// <summary>
    /// The min_elb_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? MinElbCapacity
    {
        get => GetProperty<TerraformProperty<double>>("min_elb_capacity");
        set => this.WithProperty("min_elb_capacity", value);
    }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinSize is required")]
    public required TerraformProperty<double> MinSize
    {
        get => GetProperty<TerraformProperty<double>>("min_size");
        set => this.WithProperty("min_size", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
    }

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    public TerraformProperty<string>? PlacementGroup
    {
        get => GetProperty<TerraformProperty<string>>("placement_group");
        set => this.WithProperty("placement_group", value);
    }

    /// <summary>
    /// The protect_from_scale_in attribute.
    /// </summary>
    public TerraformProperty<bool>? ProtectFromScaleIn
    {
        get => GetProperty<TerraformProperty<bool>>("protect_from_scale_in");
        set => this.WithProperty("protect_from_scale_in", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The service_linked_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceLinkedRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("service_linked_role_arn");
        set => this.WithProperty("service_linked_role_arn", value);
    }

    /// <summary>
    /// The suspended_processes attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SuspendedProcesses
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("suspended_processes");
        set => this.WithProperty("suspended_processes", value);
    }

    /// <summary>
    /// The target_group_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? TargetGroupArns
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("target_group_arns");
        set => this.WithProperty("target_group_arns", value);
    }

    /// <summary>
    /// The termination_policies attribute.
    /// </summary>
    public List<TerraformProperty<string>>? TerminationPolicies
    {
        get => GetProperty<List<TerraformProperty<string>>>("termination_policies");
        set => this.WithProperty("termination_policies", value);
    }

    /// <summary>
    /// The vpc_zone_identifier attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? VpcZoneIdentifier
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("vpc_zone_identifier");
        set => this.WithProperty("vpc_zone_identifier", value);
    }

    /// <summary>
    /// The wait_for_capacity_timeout attribute.
    /// </summary>
    public TerraformProperty<string>? WaitForCapacityTimeout
    {
        get => GetProperty<TerraformProperty<string>>("wait_for_capacity_timeout");
        set => this.WithProperty("wait_for_capacity_timeout", value);
    }

    /// <summary>
    /// The wait_for_elb_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? WaitForElbCapacity
    {
        get => GetProperty<TerraformProperty<double>>("wait_for_elb_capacity");
        set => this.WithProperty("wait_for_elb_capacity", value);
    }

    /// <summary>
    /// Block for availability_zone_distribution.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AvailabilityZoneDistribution block(s) allowed")]
    public List<AwsAutoscalingGroupAvailabilityZoneDistributionBlock>? AvailabilityZoneDistribution
    {
        get => GetProperty<List<AwsAutoscalingGroupAvailabilityZoneDistributionBlock>>("availability_zone_distribution");
        set => this.WithProperty("availability_zone_distribution", value);
    }

    /// <summary>
    /// Block for capacity_reservation_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityReservationSpecification block(s) allowed")]
    public List<AwsAutoscalingGroupCapacityReservationSpecificationBlock>? CapacityReservationSpecification
    {
        get => GetProperty<List<AwsAutoscalingGroupCapacityReservationSpecificationBlock>>("capacity_reservation_specification");
        set => this.WithProperty("capacity_reservation_specification", value);
    }

    /// <summary>
    /// Block for initial_lifecycle_hook.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsAutoscalingGroupInitialLifecycleHookBlock>? InitialLifecycleHook
    {
        get => GetProperty<HashSet<AwsAutoscalingGroupInitialLifecycleHookBlock>>("initial_lifecycle_hook");
        set => this.WithProperty("initial_lifecycle_hook", value);
    }

    /// <summary>
    /// Block for instance_maintenance_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceMaintenancePolicy block(s) allowed")]
    public List<AwsAutoscalingGroupInstanceMaintenancePolicyBlock>? InstanceMaintenancePolicy
    {
        get => GetProperty<List<AwsAutoscalingGroupInstanceMaintenancePolicyBlock>>("instance_maintenance_policy");
        set => this.WithProperty("instance_maintenance_policy", value);
    }

    /// <summary>
    /// Block for instance_refresh.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceRefresh block(s) allowed")]
    public List<AwsAutoscalingGroupInstanceRefreshBlock>? InstanceRefresh
    {
        get => GetProperty<List<AwsAutoscalingGroupInstanceRefreshBlock>>("instance_refresh");
        set => this.WithProperty("instance_refresh", value);
    }

    /// <summary>
    /// Block for launch_template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchTemplate block(s) allowed")]
    public List<AwsAutoscalingGroupLaunchTemplateBlock>? LaunchTemplate
    {
        get => GetProperty<List<AwsAutoscalingGroupLaunchTemplateBlock>>("launch_template");
        set => this.WithProperty("launch_template", value);
    }

    /// <summary>
    /// Block for mixed_instances_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MixedInstancesPolicy block(s) allowed")]
    public List<AwsAutoscalingGroupMixedInstancesPolicyBlock>? MixedInstancesPolicy
    {
        get => GetProperty<List<AwsAutoscalingGroupMixedInstancesPolicyBlock>>("mixed_instances_policy");
        set => this.WithProperty("mixed_instances_policy", value);
    }

    /// <summary>
    /// Block for tag.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsAutoscalingGroupTagBlock>? Tag
    {
        get => GetProperty<HashSet<AwsAutoscalingGroupTagBlock>>("tag");
        set => this.WithProperty("tag", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsAutoscalingGroupTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsAutoscalingGroupTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for traffic_source.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsAutoscalingGroupTrafficSourceBlock>? TrafficSource
    {
        get => GetProperty<HashSet<AwsAutoscalingGroupTrafficSourceBlock>>("traffic_source");
        set => this.WithProperty("traffic_source", value);
    }

    /// <summary>
    /// Block for warm_pool.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WarmPool block(s) allowed")]
    public List<AwsAutoscalingGroupWarmPoolBlock>? WarmPool
    {
        get => GetProperty<List<AwsAutoscalingGroupWarmPoolBlock>>("warm_pool");
        set => this.WithProperty("warm_pool", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The predicted_capacity attribute.
    /// </summary>
    public TerraformExpression PredictedCapacity => this["predicted_capacity"];

    /// <summary>
    /// The warm_pool_size attribute.
    /// </summary>
    public TerraformExpression WarmPoolSize => this["warm_pool_size"];

}
