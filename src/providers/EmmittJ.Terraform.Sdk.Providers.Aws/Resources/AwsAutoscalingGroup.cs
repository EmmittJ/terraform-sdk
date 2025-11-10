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
        set => SetProperty("capacity_distribution_strategy", value);
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
        set => SetProperty("capacity_reservation_preference", value);
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
        set => SetProperty("default_result", value);
    }

    /// <summary>
    /// The heartbeat_timeout attribute.
    /// </summary>
    public TerraformProperty<double>? HeartbeatTimeout
    {
        set => SetProperty("heartbeat_timeout", value);
    }

    /// <summary>
    /// The lifecycle_transition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LifecycleTransition is required")]
    public required TerraformProperty<string> LifecycleTransition
    {
        set => SetProperty("lifecycle_transition", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The notification_metadata attribute.
    /// </summary>
    public TerraformProperty<string>? NotificationMetadata
    {
        set => SetProperty("notification_metadata", value);
    }

    /// <summary>
    /// The notification_target_arn attribute.
    /// </summary>
    public TerraformProperty<string>? NotificationTargetArn
    {
        set => SetProperty("notification_target_arn", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RoleArn
    {
        set => SetProperty("role_arn", value);
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
        set => SetProperty("max_healthy_percentage", value);
    }

    /// <summary>
    /// The min_healthy_percentage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinHealthyPercentage is required")]
    public required TerraformProperty<double> MinHealthyPercentage
    {
        set => SetProperty("min_healthy_percentage", value);
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
        set => SetProperty("strategy", value);
    }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Triggers
    {
        set => SetProperty("triggers", value);
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
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        set => SetProperty("version", value);
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
        set => SetProperty("key", value);
    }

    /// <summary>
    /// The propagate_at_launch attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PropagateAtLaunch is required")]
    public required TerraformProperty<bool> PropagateAtLaunch
    {
        set => SetProperty("propagate_at_launch", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        set => SetProperty("value", value);
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
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        set => SetProperty("identifier", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("max_group_prepared_capacity", value);
    }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    public TerraformProperty<double>? MinSize
    {
        set => SetProperty("min_size", value);
    }

    /// <summary>
    /// The pool_state attribute.
    /// </summary>
    public TerraformProperty<string>? PoolState
    {
        set => SetProperty("pool_state", value);
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
        SetOutput("arn");
        SetOutput("predicted_capacity");
        SetOutput("warm_pool_size");
        SetOutput("availability_zones");
        SetOutput("capacity_rebalance");
        SetOutput("context");
        SetOutput("default_cooldown");
        SetOutput("default_instance_warmup");
        SetOutput("desired_capacity");
        SetOutput("desired_capacity_type");
        SetOutput("enabled_metrics");
        SetOutput("force_delete");
        SetOutput("force_delete_warm_pool");
        SetOutput("health_check_grace_period");
        SetOutput("health_check_type");
        SetOutput("id");
        SetOutput("ignore_failed_scaling_activities");
        SetOutput("launch_configuration");
        SetOutput("load_balancers");
        SetOutput("max_instance_lifetime");
        SetOutput("max_size");
        SetOutput("metrics_granularity");
        SetOutput("min_elb_capacity");
        SetOutput("min_size");
        SetOutput("name");
        SetOutput("name_prefix");
        SetOutput("placement_group");
        SetOutput("protect_from_scale_in");
        SetOutput("region");
        SetOutput("service_linked_role_arn");
        SetOutput("suspended_processes");
        SetOutput("target_group_arns");
        SetOutput("termination_policies");
        SetOutput("vpc_zone_identifier");
        SetOutput("wait_for_capacity_timeout");
        SetOutput("wait_for_elb_capacity");
    }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> AvailabilityZones
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("availability_zones");
        set => SetProperty("availability_zones", value);
    }

    /// <summary>
    /// The capacity_rebalance attribute.
    /// </summary>
    public TerraformProperty<bool> CapacityRebalance
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("capacity_rebalance");
        set => SetProperty("capacity_rebalance", value);
    }

    /// <summary>
    /// The context attribute.
    /// </summary>
    public TerraformProperty<string> Context
    {
        get => GetRequiredOutput<TerraformProperty<string>>("context");
        set => SetProperty("context", value);
    }

    /// <summary>
    /// The default_cooldown attribute.
    /// </summary>
    public TerraformProperty<double> DefaultCooldown
    {
        get => GetRequiredOutput<TerraformProperty<double>>("default_cooldown");
        set => SetProperty("default_cooldown", value);
    }

    /// <summary>
    /// The default_instance_warmup attribute.
    /// </summary>
    public TerraformProperty<double> DefaultInstanceWarmup
    {
        get => GetRequiredOutput<TerraformProperty<double>>("default_instance_warmup");
        set => SetProperty("default_instance_warmup", value);
    }

    /// <summary>
    /// The desired_capacity attribute.
    /// </summary>
    public TerraformProperty<double> DesiredCapacity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("desired_capacity");
        set => SetProperty("desired_capacity", value);
    }

    /// <summary>
    /// The desired_capacity_type attribute.
    /// </summary>
    public TerraformProperty<string> DesiredCapacityType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("desired_capacity_type");
        set => SetProperty("desired_capacity_type", value);
    }

    /// <summary>
    /// The enabled_metrics attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> EnabledMetrics
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("enabled_metrics");
        set => SetProperty("enabled_metrics", value);
    }

    /// <summary>
    /// The force_delete attribute.
    /// </summary>
    public TerraformProperty<bool> ForceDelete
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("force_delete");
        set => SetProperty("force_delete", value);
    }

    /// <summary>
    /// The force_delete_warm_pool attribute.
    /// </summary>
    public TerraformProperty<bool> ForceDeleteWarmPool
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("force_delete_warm_pool");
        set => SetProperty("force_delete_warm_pool", value);
    }

    /// <summary>
    /// The health_check_grace_period attribute.
    /// </summary>
    public TerraformProperty<double> HealthCheckGracePeriod
    {
        get => GetRequiredOutput<TerraformProperty<double>>("health_check_grace_period");
        set => SetProperty("health_check_grace_period", value);
    }

    /// <summary>
    /// The health_check_type attribute.
    /// </summary>
    public TerraformProperty<string> HealthCheckType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("health_check_type");
        set => SetProperty("health_check_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The ignore_failed_scaling_activities attribute.
    /// </summary>
    public TerraformProperty<bool> IgnoreFailedScalingActivities
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("ignore_failed_scaling_activities");
        set => SetProperty("ignore_failed_scaling_activities", value);
    }

    /// <summary>
    /// The launch_configuration attribute.
    /// </summary>
    public TerraformProperty<string> LaunchConfiguration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("launch_configuration");
        set => SetProperty("launch_configuration", value);
    }

    /// <summary>
    /// The load_balancers attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> LoadBalancers
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("load_balancers");
        set => SetProperty("load_balancers", value);
    }

    /// <summary>
    /// The max_instance_lifetime attribute.
    /// </summary>
    public TerraformProperty<double> MaxInstanceLifetime
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_instance_lifetime");
        set => SetProperty("max_instance_lifetime", value);
    }

    /// <summary>
    /// The max_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxSize is required")]
    public required TerraformProperty<double> MaxSize
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_size");
        set => SetProperty("max_size", value);
    }

    /// <summary>
    /// The metrics_granularity attribute.
    /// </summary>
    public TerraformProperty<string> MetricsGranularity
    {
        get => GetRequiredOutput<TerraformProperty<string>>("metrics_granularity");
        set => SetProperty("metrics_granularity", value);
    }

    /// <summary>
    /// The min_elb_capacity attribute.
    /// </summary>
    public TerraformProperty<double> MinElbCapacity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("min_elb_capacity");
        set => SetProperty("min_elb_capacity", value);
    }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinSize is required")]
    public required TerraformProperty<double> MinSize
    {
        get => GetRequiredOutput<TerraformProperty<double>>("min_size");
        set => SetProperty("min_size", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string> NamePrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name_prefix");
        set => SetProperty("name_prefix", value);
    }

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    public TerraformProperty<string> PlacementGroup
    {
        get => GetRequiredOutput<TerraformProperty<string>>("placement_group");
        set => SetProperty("placement_group", value);
    }

    /// <summary>
    /// The protect_from_scale_in attribute.
    /// </summary>
    public TerraformProperty<bool> ProtectFromScaleIn
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("protect_from_scale_in");
        set => SetProperty("protect_from_scale_in", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The service_linked_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> ServiceLinkedRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_linked_role_arn");
        set => SetProperty("service_linked_role_arn", value);
    }

    /// <summary>
    /// The suspended_processes attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SuspendedProcesses
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("suspended_processes");
        set => SetProperty("suspended_processes", value);
    }

    /// <summary>
    /// The target_group_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> TargetGroupArns
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("target_group_arns");
        set => SetProperty("target_group_arns", value);
    }

    /// <summary>
    /// The termination_policies attribute.
    /// </summary>
    public List<TerraformProperty<string>> TerminationPolicies
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("termination_policies");
        set => SetProperty("termination_policies", value);
    }

    /// <summary>
    /// The vpc_zone_identifier attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> VpcZoneIdentifier
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("vpc_zone_identifier");
        set => SetProperty("vpc_zone_identifier", value);
    }

    /// <summary>
    /// The wait_for_capacity_timeout attribute.
    /// </summary>
    public TerraformProperty<string> WaitForCapacityTimeout
    {
        get => GetRequiredOutput<TerraformProperty<string>>("wait_for_capacity_timeout");
        set => SetProperty("wait_for_capacity_timeout", value);
    }

    /// <summary>
    /// The wait_for_elb_capacity attribute.
    /// </summary>
    public TerraformProperty<double> WaitForElbCapacity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("wait_for_elb_capacity");
        set => SetProperty("wait_for_elb_capacity", value);
    }

    /// <summary>
    /// Block for availability_zone_distribution.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AvailabilityZoneDistribution block(s) allowed")]
    public List<AwsAutoscalingGroupAvailabilityZoneDistributionBlock>? AvailabilityZoneDistribution
    {
        set => SetProperty("availability_zone_distribution", value);
    }

    /// <summary>
    /// Block for capacity_reservation_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityReservationSpecification block(s) allowed")]
    public List<AwsAutoscalingGroupCapacityReservationSpecificationBlock>? CapacityReservationSpecification
    {
        set => SetProperty("capacity_reservation_specification", value);
    }

    /// <summary>
    /// Block for initial_lifecycle_hook.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsAutoscalingGroupInitialLifecycleHookBlock>? InitialLifecycleHook
    {
        set => SetProperty("initial_lifecycle_hook", value);
    }

    /// <summary>
    /// Block for instance_maintenance_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceMaintenancePolicy block(s) allowed")]
    public List<AwsAutoscalingGroupInstanceMaintenancePolicyBlock>? InstanceMaintenancePolicy
    {
        set => SetProperty("instance_maintenance_policy", value);
    }

    /// <summary>
    /// Block for instance_refresh.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceRefresh block(s) allowed")]
    public List<AwsAutoscalingGroupInstanceRefreshBlock>? InstanceRefresh
    {
        set => SetProperty("instance_refresh", value);
    }

    /// <summary>
    /// Block for launch_template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchTemplate block(s) allowed")]
    public List<AwsAutoscalingGroupLaunchTemplateBlock>? LaunchTemplate
    {
        set => SetProperty("launch_template", value);
    }

    /// <summary>
    /// Block for mixed_instances_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MixedInstancesPolicy block(s) allowed")]
    public List<AwsAutoscalingGroupMixedInstancesPolicyBlock>? MixedInstancesPolicy
    {
        set => SetProperty("mixed_instances_policy", value);
    }

    /// <summary>
    /// Block for tag.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsAutoscalingGroupTagBlock>? Tag
    {
        set => SetProperty("tag", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsAutoscalingGroupTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for traffic_source.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsAutoscalingGroupTrafficSourceBlock>? TrafficSource
    {
        set => SetProperty("traffic_source", value);
    }

    /// <summary>
    /// Block for warm_pool.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WarmPool block(s) allowed")]
    public List<AwsAutoscalingGroupWarmPoolBlock>? WarmPool
    {
        set => SetProperty("warm_pool", value);
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
