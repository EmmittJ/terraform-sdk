using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for availability_zone_distribution in AwsAutoscalingGroup.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupAvailabilityZoneDistributionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "availability_zone_distribution";

    /// <summary>
    /// The capacity_distribution_strategy attribute.
    /// </summary>
    public TerraformValue<string>? CapacityDistributionStrategy
    {
        get => GetArgument<TerraformValue<string>>("capacity_distribution_strategy");
        set => SetArgument("capacity_distribution_strategy", value);
    }

}


/// <summary>
/// Block type for capacity_reservation_specification in AwsAutoscalingGroup.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupCapacityReservationSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "capacity_reservation_specification";

    /// <summary>
    /// The capacity_reservation_preference attribute.
    /// </summary>
    public TerraformValue<string> CapacityReservationPreference
    {
        get => GetArgument<TerraformValue<string>>("capacity_reservation_preference") ?? CreateReference("capacity_reservation_preference");
        set => SetArgument("capacity_reservation_preference", value);
    }

    /// <summary>
    /// CapacityReservationTarget block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityReservationTarget block(s) allowed")]
    public TerraformList<AwsAutoscalingGroupCapacityReservationSpecificationBlockCapacityReservationTargetBlock>? CapacityReservationTarget
    {
        get => GetArgument<TerraformList<AwsAutoscalingGroupCapacityReservationSpecificationBlockCapacityReservationTargetBlock>>("capacity_reservation_target");
        set => SetArgument("capacity_reservation_target", value);
    }

}

/// <summary>
/// Block type for capacity_reservation_target in AwsAutoscalingGroupCapacityReservationSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupCapacityReservationSpecificationBlockCapacityReservationTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "capacity_reservation_target";

    /// <summary>
    /// The capacity_reservation_ids attribute.
    /// </summary>
    public TerraformList<string>? CapacityReservationIds
    {
        get => GetArgument<TerraformList<string>>("capacity_reservation_ids");
        set => SetArgument("capacity_reservation_ids", value);
    }

    /// <summary>
    /// The capacity_reservation_resource_group_arns attribute.
    /// </summary>
    public TerraformList<string>? CapacityReservationResourceGroupArns
    {
        get => GetArgument<TerraformList<string>>("capacity_reservation_resource_group_arns");
        set => SetArgument("capacity_reservation_resource_group_arns", value);
    }

}


/// <summary>
/// Block type for initial_lifecycle_hook in AwsAutoscalingGroup.
/// Nesting mode: set
/// </summary>
public class AwsAutoscalingGroupInitialLifecycleHookBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "initial_lifecycle_hook";

    /// <summary>
    /// The default_result attribute.
    /// </summary>
    public TerraformValue<string> DefaultResult
    {
        get => GetArgument<TerraformValue<string>>("default_result") ?? CreateReference("default_result");
        set => SetArgument("default_result", value);
    }

    /// <summary>
    /// The heartbeat_timeout attribute.
    /// </summary>
    public TerraformValue<double>? HeartbeatTimeout
    {
        get => GetArgument<TerraformValue<double>>("heartbeat_timeout");
        set => SetArgument("heartbeat_timeout", value);
    }

    /// <summary>
    /// The lifecycle_transition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LifecycleTransition is required")]
    public required TerraformValue<string> LifecycleTransition
    {
        get => GetRequiredArgument<TerraformValue<string>>("lifecycle_transition");
        set => SetArgument("lifecycle_transition", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The notification_metadata attribute.
    /// </summary>
    public TerraformValue<string>? NotificationMetadata
    {
        get => GetArgument<TerraformValue<string>>("notification_metadata");
        set => SetArgument("notification_metadata", value);
    }

    /// <summary>
    /// The notification_target_arn attribute.
    /// </summary>
    public TerraformValue<string>? NotificationTargetArn
    {
        get => GetArgument<TerraformValue<string>>("notification_target_arn");
        set => SetArgument("notification_target_arn", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string>? RoleArn
    {
        get => GetArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
    }

}


/// <summary>
/// Block type for instance_maintenance_policy in AwsAutoscalingGroup.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupInstanceMaintenancePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "instance_maintenance_policy";

    /// <summary>
    /// The max_healthy_percentage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxHealthyPercentage is required")]
    public required TerraformValue<double> MaxHealthyPercentage
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_healthy_percentage");
        set => SetArgument("max_healthy_percentage", value);
    }

    /// <summary>
    /// The min_healthy_percentage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinHealthyPercentage is required")]
    public required TerraformValue<double> MinHealthyPercentage
    {
        get => GetRequiredArgument<TerraformValue<double>>("min_healthy_percentage");
        set => SetArgument("min_healthy_percentage", value);
    }

}


/// <summary>
/// Block type for instance_refresh in AwsAutoscalingGroup.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupInstanceRefreshBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "instance_refresh";

    /// <summary>
    /// The strategy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Strategy is required")]
    public required TerraformValue<string> Strategy
    {
        get => GetRequiredArgument<TerraformValue<string>>("strategy");
        set => SetArgument("strategy", value);
    }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    public TerraformSet<string>? Triggers
    {
        get => GetArgument<TerraformSet<string>>("triggers");
        set => SetArgument("triggers", value);
    }

    /// <summary>
    /// Preferences block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Preferences block(s) allowed")]
    public TerraformList<AwsAutoscalingGroupInstanceRefreshBlockPreferencesBlock>? Preferences
    {
        get => GetArgument<TerraformList<AwsAutoscalingGroupInstanceRefreshBlockPreferencesBlock>>("preferences");
        set => SetArgument("preferences", value);
    }

}

/// <summary>
/// Block type for preferences in AwsAutoscalingGroupInstanceRefreshBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupInstanceRefreshBlockPreferencesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "preferences";

    /// <summary>
    /// The auto_rollback attribute.
    /// </summary>
    public TerraformValue<bool>? AutoRollback
    {
        get => GetArgument<TerraformValue<bool>>("auto_rollback");
        set => SetArgument("auto_rollback", value);
    }

    /// <summary>
    /// The checkpoint_delay attribute.
    /// </summary>
    public TerraformValue<string>? CheckpointDelay
    {
        get => GetArgument<TerraformValue<string>>("checkpoint_delay");
        set => SetArgument("checkpoint_delay", value);
    }

    /// <summary>
    /// The checkpoint_percentages attribute.
    /// </summary>
    public TerraformList<double>? CheckpointPercentages
    {
        get => GetArgument<TerraformList<double>>("checkpoint_percentages");
        set => SetArgument("checkpoint_percentages", value);
    }

    /// <summary>
    /// The instance_warmup attribute.
    /// </summary>
    public TerraformValue<string>? InstanceWarmup
    {
        get => GetArgument<TerraformValue<string>>("instance_warmup");
        set => SetArgument("instance_warmup", value);
    }

    /// <summary>
    /// The max_healthy_percentage attribute.
    /// </summary>
    public TerraformValue<double>? MaxHealthyPercentage
    {
        get => GetArgument<TerraformValue<double>>("max_healthy_percentage");
        set => SetArgument("max_healthy_percentage", value);
    }

    /// <summary>
    /// The min_healthy_percentage attribute.
    /// </summary>
    public TerraformValue<double>? MinHealthyPercentage
    {
        get => GetArgument<TerraformValue<double>>("min_healthy_percentage");
        set => SetArgument("min_healthy_percentage", value);
    }

    /// <summary>
    /// The scale_in_protected_instances attribute.
    /// </summary>
    public TerraformValue<string>? ScaleInProtectedInstances
    {
        get => GetArgument<TerraformValue<string>>("scale_in_protected_instances");
        set => SetArgument("scale_in_protected_instances", value);
    }

    /// <summary>
    /// The skip_matching attribute.
    /// </summary>
    public TerraformValue<bool>? SkipMatching
    {
        get => GetArgument<TerraformValue<bool>>("skip_matching");
        set => SetArgument("skip_matching", value);
    }

    /// <summary>
    /// The standby_instances attribute.
    /// </summary>
    public TerraformValue<string>? StandbyInstances
    {
        get => GetArgument<TerraformValue<string>>("standby_instances");
        set => SetArgument("standby_instances", value);
    }

    /// <summary>
    /// AlarmSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AlarmSpecification block(s) allowed")]
    public TerraformList<AwsAutoscalingGroupInstanceRefreshBlockPreferencesBlockAlarmSpecificationBlock>? AlarmSpecification
    {
        get => GetArgument<TerraformList<AwsAutoscalingGroupInstanceRefreshBlockPreferencesBlockAlarmSpecificationBlock>>("alarm_specification");
        set => SetArgument("alarm_specification", value);
    }

}

/// <summary>
/// Block type for alarm_specification in AwsAutoscalingGroupInstanceRefreshBlockPreferencesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupInstanceRefreshBlockPreferencesBlockAlarmSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "alarm_specification";

    /// <summary>
    /// The alarms attribute.
    /// </summary>
    public TerraformList<string>? Alarms
    {
        get => GetArgument<TerraformList<string>>("alarms");
        set => SetArgument("alarms", value);
    }

}


/// <summary>
/// Block type for launch_template in AwsAutoscalingGroup.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupLaunchTemplateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "launch_template";

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? CreateReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => GetArgument<TerraformValue<string>>("version") ?? CreateReference("version");
        set => SetArgument("version", value);
    }

}


/// <summary>
/// Block type for mixed_instances_policy in AwsAutoscalingGroup.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupMixedInstancesPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mixed_instances_policy";

    /// <summary>
    /// InstancesDistribution block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstancesDistribution block(s) allowed")]
    public TerraformList<AwsAutoscalingGroupMixedInstancesPolicyBlockInstancesDistributionBlock>? InstancesDistribution
    {
        get => GetArgument<TerraformList<AwsAutoscalingGroupMixedInstancesPolicyBlockInstancesDistributionBlock>>("instances_distribution");
        set => SetArgument("instances_distribution", value);
    }

    /// <summary>
    /// LaunchTemplate block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LaunchTemplate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LaunchTemplate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchTemplate block(s) allowed")]
    public required TerraformList<AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlock> LaunchTemplate
    {
        get => GetRequiredArgument<TerraformList<AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlock>>("launch_template");
        set => SetArgument("launch_template", value);
    }

}

/// <summary>
/// Block type for instances_distribution in AwsAutoscalingGroupMixedInstancesPolicyBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupMixedInstancesPolicyBlockInstancesDistributionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "instances_distribution";

    /// <summary>
    /// The on_demand_allocation_strategy attribute.
    /// </summary>
    public TerraformValue<string> OnDemandAllocationStrategy
    {
        get => GetArgument<TerraformValue<string>>("on_demand_allocation_strategy") ?? CreateReference("on_demand_allocation_strategy");
        set => SetArgument("on_demand_allocation_strategy", value);
    }

    /// <summary>
    /// The on_demand_base_capacity attribute.
    /// </summary>
    public TerraformValue<double> OnDemandBaseCapacity
    {
        get => GetArgument<TerraformValue<double>>("on_demand_base_capacity") ?? CreateReference("on_demand_base_capacity");
        set => SetArgument("on_demand_base_capacity", value);
    }

    /// <summary>
    /// The on_demand_percentage_above_base_capacity attribute.
    /// </summary>
    public TerraformValue<double> OnDemandPercentageAboveBaseCapacity
    {
        get => GetArgument<TerraformValue<double>>("on_demand_percentage_above_base_capacity") ?? CreateReference("on_demand_percentage_above_base_capacity");
        set => SetArgument("on_demand_percentage_above_base_capacity", value);
    }

    /// <summary>
    /// The spot_allocation_strategy attribute.
    /// </summary>
    public TerraformValue<string> SpotAllocationStrategy
    {
        get => GetArgument<TerraformValue<string>>("spot_allocation_strategy") ?? CreateReference("spot_allocation_strategy");
        set => SetArgument("spot_allocation_strategy", value);
    }

    /// <summary>
    /// The spot_instance_pools attribute.
    /// </summary>
    public TerraformValue<double> SpotInstancePools
    {
        get => GetArgument<TerraformValue<double>>("spot_instance_pools") ?? CreateReference("spot_instance_pools");
        set => SetArgument("spot_instance_pools", value);
    }

    /// <summary>
    /// The spot_max_price attribute.
    /// </summary>
    public TerraformValue<string>? SpotMaxPrice
    {
        get => GetArgument<TerraformValue<string>>("spot_max_price");
        set => SetArgument("spot_max_price", value);
    }

}

/// <summary>
/// Block type for launch_template in AwsAutoscalingGroupMixedInstancesPolicyBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "launch_template";

    /// <summary>
    /// LaunchTemplateSpecification block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LaunchTemplateSpecification is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LaunchTemplateSpecification block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchTemplateSpecification block(s) allowed")]
    public required TerraformList<AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockLaunchTemplateSpecificationBlock> LaunchTemplateSpecification
    {
        get => GetRequiredArgument<TerraformList<AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockLaunchTemplateSpecificationBlock>>("launch_template_specification");
        set => SetArgument("launch_template_specification", value);
    }

    /// <summary>
    /// OverrideAttribute block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlock>? OverrideAttribute
    {
        get => GetArgument<TerraformList<AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlock>>("override");
        set => SetArgument("override", value);
    }

}

/// <summary>
/// Block type for launch_template_specification in AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockLaunchTemplateSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "launch_template_specification";

    /// <summary>
    /// The launch_template_id attribute.
    /// </summary>
    public TerraformValue<string> LaunchTemplateId
    {
        get => GetArgument<TerraformValue<string>>("launch_template_id") ?? CreateReference("launch_template_id");
        set => SetArgument("launch_template_id", value);
    }

    /// <summary>
    /// The launch_template_name attribute.
    /// </summary>
    public TerraformValue<string> LaunchTemplateName
    {
        get => GetArgument<TerraformValue<string>>("launch_template_name") ?? CreateReference("launch_template_name");
        set => SetArgument("launch_template_name", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => GetArgument<TerraformValue<string>>("version") ?? CreateReference("version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for override in AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "override";

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string>? InstanceType
    {
        get => GetArgument<TerraformValue<string>>("instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The weighted_capacity attribute.
    /// </summary>
    public TerraformValue<string>? WeightedCapacity
    {
        get => GetArgument<TerraformValue<string>>("weighted_capacity");
        set => SetArgument("weighted_capacity", value);
    }

    /// <summary>
    /// InstanceRequirements block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceRequirements block(s) allowed")]
    public TerraformList<AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlock>? InstanceRequirements
    {
        get => GetArgument<TerraformList<AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlock>>("instance_requirements");
        set => SetArgument("instance_requirements", value);
    }

    /// <summary>
    /// LaunchTemplateSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchTemplateSpecification block(s) allowed")]
    public TerraformList<AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockLaunchTemplateSpecificationBlock>? LaunchTemplateSpecification
    {
        get => GetArgument<TerraformList<AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockLaunchTemplateSpecificationBlock>>("launch_template_specification");
        set => SetArgument("launch_template_specification", value);
    }

}

/// <summary>
/// Block type for instance_requirements in AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "instance_requirements";

    /// <summary>
    /// The accelerator_manufacturers attribute.
    /// </summary>
    public TerraformSet<string>? AcceleratorManufacturers
    {
        get => GetArgument<TerraformSet<string>>("accelerator_manufacturers");
        set => SetArgument("accelerator_manufacturers", value);
    }

    /// <summary>
    /// The accelerator_names attribute.
    /// </summary>
    public TerraformSet<string>? AcceleratorNames
    {
        get => GetArgument<TerraformSet<string>>("accelerator_names");
        set => SetArgument("accelerator_names", value);
    }

    /// <summary>
    /// The accelerator_types attribute.
    /// </summary>
    public TerraformSet<string>? AcceleratorTypes
    {
        get => GetArgument<TerraformSet<string>>("accelerator_types");
        set => SetArgument("accelerator_types", value);
    }

    /// <summary>
    /// The allowed_instance_types attribute.
    /// </summary>
    public TerraformSet<string>? AllowedInstanceTypes
    {
        get => GetArgument<TerraformSet<string>>("allowed_instance_types");
        set => SetArgument("allowed_instance_types", value);
    }

    /// <summary>
    /// The bare_metal attribute.
    /// </summary>
    public TerraformValue<string>? BareMetal
    {
        get => GetArgument<TerraformValue<string>>("bare_metal");
        set => SetArgument("bare_metal", value);
    }

    /// <summary>
    /// The burstable_performance attribute.
    /// </summary>
    public TerraformValue<string>? BurstablePerformance
    {
        get => GetArgument<TerraformValue<string>>("burstable_performance");
        set => SetArgument("burstable_performance", value);
    }

    /// <summary>
    /// The cpu_manufacturers attribute.
    /// </summary>
    public TerraformSet<string>? CpuManufacturers
    {
        get => GetArgument<TerraformSet<string>>("cpu_manufacturers");
        set => SetArgument("cpu_manufacturers", value);
    }

    /// <summary>
    /// The excluded_instance_types attribute.
    /// </summary>
    public TerraformSet<string>? ExcludedInstanceTypes
    {
        get => GetArgument<TerraformSet<string>>("excluded_instance_types");
        set => SetArgument("excluded_instance_types", value);
    }

    /// <summary>
    /// The instance_generations attribute.
    /// </summary>
    public TerraformSet<string>? InstanceGenerations
    {
        get => GetArgument<TerraformSet<string>>("instance_generations");
        set => SetArgument("instance_generations", value);
    }

    /// <summary>
    /// The local_storage attribute.
    /// </summary>
    public TerraformValue<string>? LocalStorage
    {
        get => GetArgument<TerraformValue<string>>("local_storage");
        set => SetArgument("local_storage", value);
    }

    /// <summary>
    /// The local_storage_types attribute.
    /// </summary>
    public TerraformSet<string>? LocalStorageTypes
    {
        get => GetArgument<TerraformSet<string>>("local_storage_types");
        set => SetArgument("local_storage_types", value);
    }

    /// <summary>
    /// The max_spot_price_as_percentage_of_optimal_on_demand_price attribute.
    /// </summary>
    public TerraformValue<double>? MaxSpotPriceAsPercentageOfOptimalOnDemandPrice
    {
        get => GetArgument<TerraformValue<double>>("max_spot_price_as_percentage_of_optimal_on_demand_price");
        set => SetArgument("max_spot_price_as_percentage_of_optimal_on_demand_price", value);
    }

    /// <summary>
    /// The on_demand_max_price_percentage_over_lowest_price attribute.
    /// </summary>
    public TerraformValue<double>? OnDemandMaxPricePercentageOverLowestPrice
    {
        get => GetArgument<TerraformValue<double>>("on_demand_max_price_percentage_over_lowest_price");
        set => SetArgument("on_demand_max_price_percentage_over_lowest_price", value);
    }

    /// <summary>
    /// The require_hibernate_support attribute.
    /// </summary>
    public TerraformValue<bool>? RequireHibernateSupport
    {
        get => GetArgument<TerraformValue<bool>>("require_hibernate_support");
        set => SetArgument("require_hibernate_support", value);
    }

    /// <summary>
    /// The spot_max_price_percentage_over_lowest_price attribute.
    /// </summary>
    public TerraformValue<double>? SpotMaxPricePercentageOverLowestPrice
    {
        get => GetArgument<TerraformValue<double>>("spot_max_price_percentage_over_lowest_price");
        set => SetArgument("spot_max_price_percentage_over_lowest_price", value);
    }

    /// <summary>
    /// AcceleratorCount block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AcceleratorCount block(s) allowed")]
    public TerraformList<AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlockAcceleratorCountBlock>? AcceleratorCount
    {
        get => GetArgument<TerraformList<AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlockAcceleratorCountBlock>>("accelerator_count");
        set => SetArgument("accelerator_count", value);
    }

    /// <summary>
    /// AcceleratorTotalMemoryMib block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AcceleratorTotalMemoryMib block(s) allowed")]
    public TerraformList<AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlockAcceleratorTotalMemoryMibBlock>? AcceleratorTotalMemoryMib
    {
        get => GetArgument<TerraformList<AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlockAcceleratorTotalMemoryMibBlock>>("accelerator_total_memory_mib");
        set => SetArgument("accelerator_total_memory_mib", value);
    }

    /// <summary>
    /// BaselineEbsBandwidthMbps block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BaselineEbsBandwidthMbps block(s) allowed")]
    public TerraformList<AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlockBaselineEbsBandwidthMbpsBlock>? BaselineEbsBandwidthMbps
    {
        get => GetArgument<TerraformList<AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlockBaselineEbsBandwidthMbpsBlock>>("baseline_ebs_bandwidth_mbps");
        set => SetArgument("baseline_ebs_bandwidth_mbps", value);
    }

    /// <summary>
    /// MemoryGibPerVcpu block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MemoryGibPerVcpu block(s) allowed")]
    public TerraformList<AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlockMemoryGibPerVcpuBlock>? MemoryGibPerVcpu
    {
        get => GetArgument<TerraformList<AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlockMemoryGibPerVcpuBlock>>("memory_gib_per_vcpu");
        set => SetArgument("memory_gib_per_vcpu", value);
    }

    /// <summary>
    /// MemoryMib block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MemoryMib block(s) allowed")]
    public TerraformList<AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlockMemoryMibBlock>? MemoryMib
    {
        get => GetArgument<TerraformList<AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlockMemoryMibBlock>>("memory_mib");
        set => SetArgument("memory_mib", value);
    }

    /// <summary>
    /// NetworkBandwidthGbps block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkBandwidthGbps block(s) allowed")]
    public TerraformList<AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlockNetworkBandwidthGbpsBlock>? NetworkBandwidthGbps
    {
        get => GetArgument<TerraformList<AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlockNetworkBandwidthGbpsBlock>>("network_bandwidth_gbps");
        set => SetArgument("network_bandwidth_gbps", value);
    }

    /// <summary>
    /// NetworkInterfaceCount block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkInterfaceCount block(s) allowed")]
    public TerraformList<AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlockNetworkInterfaceCountBlock>? NetworkInterfaceCount
    {
        get => GetArgument<TerraformList<AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlockNetworkInterfaceCountBlock>>("network_interface_count");
        set => SetArgument("network_interface_count", value);
    }

    /// <summary>
    /// TotalLocalStorageGb block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TotalLocalStorageGb block(s) allowed")]
    public TerraformList<AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlockTotalLocalStorageGbBlock>? TotalLocalStorageGb
    {
        get => GetArgument<TerraformList<AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlockTotalLocalStorageGbBlock>>("total_local_storage_gb");
        set => SetArgument("total_local_storage_gb", value);
    }

    /// <summary>
    /// VcpuCount block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VcpuCount block(s) allowed")]
    public TerraformList<AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlockVcpuCountBlock>? VcpuCount
    {
        get => GetArgument<TerraformList<AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlockVcpuCountBlock>>("vcpu_count");
        set => SetArgument("vcpu_count", value);
    }

}

/// <summary>
/// Block type for accelerator_count in AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlockAcceleratorCountBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "accelerator_count";

    /// <summary>
    /// The max attribute.
    /// </summary>
    public TerraformValue<double>? Max
    {
        get => GetArgument<TerraformValue<double>>("max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    public TerraformValue<double>? Min
    {
        get => GetArgument<TerraformValue<double>>("min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for accelerator_total_memory_mib in AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlockAcceleratorTotalMemoryMibBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "accelerator_total_memory_mib";

    /// <summary>
    /// The max attribute.
    /// </summary>
    public TerraformValue<double>? Max
    {
        get => GetArgument<TerraformValue<double>>("max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    public TerraformValue<double>? Min
    {
        get => GetArgument<TerraformValue<double>>("min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for baseline_ebs_bandwidth_mbps in AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlockBaselineEbsBandwidthMbpsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "baseline_ebs_bandwidth_mbps";

    /// <summary>
    /// The max attribute.
    /// </summary>
    public TerraformValue<double>? Max
    {
        get => GetArgument<TerraformValue<double>>("max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    public TerraformValue<double>? Min
    {
        get => GetArgument<TerraformValue<double>>("min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for memory_gib_per_vcpu in AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlockMemoryGibPerVcpuBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "memory_gib_per_vcpu";

    /// <summary>
    /// The max attribute.
    /// </summary>
    public TerraformValue<double>? Max
    {
        get => GetArgument<TerraformValue<double>>("max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    public TerraformValue<double>? Min
    {
        get => GetArgument<TerraformValue<double>>("min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for memory_mib in AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlockMemoryMibBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "memory_mib";

    /// <summary>
    /// The max attribute.
    /// </summary>
    public TerraformValue<double>? Max
    {
        get => GetArgument<TerraformValue<double>>("max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    public TerraformValue<double>? Min
    {
        get => GetArgument<TerraformValue<double>>("min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for network_bandwidth_gbps in AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlockNetworkBandwidthGbpsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_bandwidth_gbps";

    /// <summary>
    /// The max attribute.
    /// </summary>
    public TerraformValue<double>? Max
    {
        get => GetArgument<TerraformValue<double>>("max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    public TerraformValue<double>? Min
    {
        get => GetArgument<TerraformValue<double>>("min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for network_interface_count in AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlockNetworkInterfaceCountBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_interface_count";

    /// <summary>
    /// The max attribute.
    /// </summary>
    public TerraformValue<double>? Max
    {
        get => GetArgument<TerraformValue<double>>("max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    public TerraformValue<double>? Min
    {
        get => GetArgument<TerraformValue<double>>("min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for total_local_storage_gb in AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlockTotalLocalStorageGbBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "total_local_storage_gb";

    /// <summary>
    /// The max attribute.
    /// </summary>
    public TerraformValue<double>? Max
    {
        get => GetArgument<TerraformValue<double>>("max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    public TerraformValue<double>? Min
    {
        get => GetArgument<TerraformValue<double>>("min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for vcpu_count in AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockInstanceRequirementsBlockVcpuCountBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vcpu_count";

    /// <summary>
    /// The max attribute.
    /// </summary>
    public TerraformValue<double>? Max
    {
        get => GetArgument<TerraformValue<double>>("max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    public TerraformValue<double>? Min
    {
        get => GetArgument<TerraformValue<double>>("min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for launch_template_specification in AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupMixedInstancesPolicyBlockLaunchTemplateBlockOverrideAttributeBlockLaunchTemplateSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "launch_template_specification";

    /// <summary>
    /// The launch_template_id attribute.
    /// </summary>
    public TerraformValue<string> LaunchTemplateId
    {
        get => GetArgument<TerraformValue<string>>("launch_template_id") ?? CreateReference("launch_template_id");
        set => SetArgument("launch_template_id", value);
    }

    /// <summary>
    /// The launch_template_name attribute.
    /// </summary>
    public TerraformValue<string> LaunchTemplateName
    {
        get => GetArgument<TerraformValue<string>>("launch_template_name") ?? CreateReference("launch_template_name");
        set => SetArgument("launch_template_name", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => GetArgument<TerraformValue<string>>("version") ?? CreateReference("version");
        set => SetArgument("version", value);
    }

}


/// <summary>
/// Block type for tag in AwsAutoscalingGroup.
/// Nesting mode: set
/// </summary>
public class AwsAutoscalingGroupTagBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tag";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The propagate_at_launch attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PropagateAtLaunch is required")]
    public required TerraformValue<bool> PropagateAtLaunch
    {
        get => GetRequiredArgument<TerraformValue<bool>>("propagate_at_launch");
        set => SetArgument("propagate_at_launch", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsAutoscalingGroup.
/// Nesting mode: single
/// </summary>
public class AwsAutoscalingGroupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for traffic_source in AwsAutoscalingGroup.
/// Nesting mode: set
/// </summary>
public class AwsAutoscalingGroupTrafficSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "traffic_source";

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    public required TerraformValue<string> Identifier
    {
        get => GetRequiredArgument<TerraformValue<string>>("identifier");
        set => SetArgument("identifier", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for warm_pool in AwsAutoscalingGroup.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupWarmPoolBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "warm_pool";

    /// <summary>
    /// The max_group_prepared_capacity attribute.
    /// </summary>
    public TerraformValue<double>? MaxGroupPreparedCapacity
    {
        get => GetArgument<TerraformValue<double>>("max_group_prepared_capacity");
        set => SetArgument("max_group_prepared_capacity", value);
    }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    public TerraformValue<double>? MinSize
    {
        get => GetArgument<TerraformValue<double>>("min_size");
        set => SetArgument("min_size", value);
    }

    /// <summary>
    /// The pool_state attribute.
    /// </summary>
    public TerraformValue<string>? PoolState
    {
        get => GetArgument<TerraformValue<string>>("pool_state");
        set => SetArgument("pool_state", value);
    }

    /// <summary>
    /// InstanceReusePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceReusePolicy block(s) allowed")]
    public TerraformList<AwsAutoscalingGroupWarmPoolBlockInstanceReusePolicyBlock>? InstanceReusePolicy
    {
        get => GetArgument<TerraformList<AwsAutoscalingGroupWarmPoolBlockInstanceReusePolicyBlock>>("instance_reuse_policy");
        set => SetArgument("instance_reuse_policy", value);
    }

}

/// <summary>
/// Block type for instance_reuse_policy in AwsAutoscalingGroupWarmPoolBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupWarmPoolBlockInstanceReusePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "instance_reuse_policy";

    /// <summary>
    /// The reuse_on_scale_in attribute.
    /// </summary>
    public TerraformValue<bool>? ReuseOnScaleIn
    {
        get => GetArgument<TerraformValue<bool>>("reuse_on_scale_in");
        set => SetArgument("reuse_on_scale_in", value);
    }

}


/// <summary>
/// Represents a aws_autoscaling_group Terraform resource.
/// Manages a aws_autoscaling_group resource.
/// </summary>
public partial class AwsAutoscalingGroup(string name) : TerraformResource("aws_autoscaling_group", name)
{
    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public TerraformSet<string> AvailabilityZones
    {
        get => GetArgument<TerraformSet<string>>("availability_zones") ?? CreateReference("availability_zones");
        set => SetArgument("availability_zones", value);
    }

    /// <summary>
    /// The capacity_rebalance attribute.
    /// </summary>
    public TerraformValue<bool>? CapacityRebalance
    {
        get => GetArgument<TerraformValue<bool>>("capacity_rebalance");
        set => SetArgument("capacity_rebalance", value);
    }

    /// <summary>
    /// The context attribute.
    /// </summary>
    public TerraformValue<string>? Context
    {
        get => GetArgument<TerraformValue<string>>("context");
        set => SetArgument("context", value);
    }

    /// <summary>
    /// The default_cooldown attribute.
    /// </summary>
    public TerraformValue<double> DefaultCooldown
    {
        get => GetArgument<TerraformValue<double>>("default_cooldown") ?? CreateReference("default_cooldown");
        set => SetArgument("default_cooldown", value);
    }

    /// <summary>
    /// The default_instance_warmup attribute.
    /// </summary>
    public TerraformValue<double>? DefaultInstanceWarmup
    {
        get => GetArgument<TerraformValue<double>>("default_instance_warmup");
        set => SetArgument("default_instance_warmup", value);
    }

    /// <summary>
    /// The desired_capacity attribute.
    /// </summary>
    public TerraformValue<double> DesiredCapacity
    {
        get => GetArgument<TerraformValue<double>>("desired_capacity") ?? CreateReference("desired_capacity");
        set => SetArgument("desired_capacity", value);
    }

    /// <summary>
    /// The desired_capacity_type attribute.
    /// </summary>
    public TerraformValue<string>? DesiredCapacityType
    {
        get => GetArgument<TerraformValue<string>>("desired_capacity_type");
        set => SetArgument("desired_capacity_type", value);
    }

    /// <summary>
    /// The enabled_metrics attribute.
    /// </summary>
    public TerraformSet<string>? EnabledMetrics
    {
        get => GetArgument<TerraformSet<string>>("enabled_metrics");
        set => SetArgument("enabled_metrics", value);
    }

    /// <summary>
    /// The force_delete attribute.
    /// </summary>
    public TerraformValue<bool>? ForceDelete
    {
        get => GetArgument<TerraformValue<bool>>("force_delete");
        set => SetArgument("force_delete", value);
    }

    /// <summary>
    /// The force_delete_warm_pool attribute.
    /// </summary>
    public TerraformValue<bool>? ForceDeleteWarmPool
    {
        get => GetArgument<TerraformValue<bool>>("force_delete_warm_pool");
        set => SetArgument("force_delete_warm_pool", value);
    }

    /// <summary>
    /// The health_check_grace_period attribute.
    /// </summary>
    public TerraformValue<double>? HealthCheckGracePeriod
    {
        get => GetArgument<TerraformValue<double>>("health_check_grace_period");
        set => SetArgument("health_check_grace_period", value);
    }

    /// <summary>
    /// The health_check_type attribute.
    /// </summary>
    public TerraformValue<string> HealthCheckType
    {
        get => GetArgument<TerraformValue<string>>("health_check_type") ?? CreateReference("health_check_type");
        set => SetArgument("health_check_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ignore_failed_scaling_activities attribute.
    /// </summary>
    public TerraformValue<bool>? IgnoreFailedScalingActivities
    {
        get => GetArgument<TerraformValue<bool>>("ignore_failed_scaling_activities");
        set => SetArgument("ignore_failed_scaling_activities", value);
    }

    /// <summary>
    /// The launch_configuration attribute.
    /// </summary>
    public TerraformValue<string>? LaunchConfiguration
    {
        get => GetArgument<TerraformValue<string>>("launch_configuration");
        set => SetArgument("launch_configuration", value);
    }

    /// <summary>
    /// The load_balancers attribute.
    /// </summary>
    public TerraformSet<string> LoadBalancers
    {
        get => GetArgument<TerraformSet<string>>("load_balancers") ?? CreateReference("load_balancers");
        set => SetArgument("load_balancers", value);
    }

    /// <summary>
    /// The max_instance_lifetime attribute.
    /// </summary>
    public TerraformValue<double>? MaxInstanceLifetime
    {
        get => GetArgument<TerraformValue<double>>("max_instance_lifetime");
        set => SetArgument("max_instance_lifetime", value);
    }

    /// <summary>
    /// The max_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxSize is required")]
    public required TerraformValue<double> MaxSize
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_size");
        set => SetArgument("max_size", value);
    }

    /// <summary>
    /// The metrics_granularity attribute.
    /// </summary>
    public TerraformValue<string>? MetricsGranularity
    {
        get => GetArgument<TerraformValue<string>>("metrics_granularity");
        set => SetArgument("metrics_granularity", value);
    }

    /// <summary>
    /// The min_elb_capacity attribute.
    /// </summary>
    public TerraformValue<double>? MinElbCapacity
    {
        get => GetArgument<TerraformValue<double>>("min_elb_capacity");
        set => SetArgument("min_elb_capacity", value);
    }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinSize is required")]
    public required TerraformValue<double> MinSize
    {
        get => GetRequiredArgument<TerraformValue<double>>("min_size");
        set => SetArgument("min_size", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? CreateReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string> NamePrefix
    {
        get => GetArgument<TerraformValue<string>>("name_prefix") ?? CreateReference("name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    public TerraformValue<string>? PlacementGroup
    {
        get => GetArgument<TerraformValue<string>>("placement_group");
        set => SetArgument("placement_group", value);
    }

    /// <summary>
    /// The protect_from_scale_in attribute.
    /// </summary>
    public TerraformValue<bool>? ProtectFromScaleIn
    {
        get => GetArgument<TerraformValue<bool>>("protect_from_scale_in");
        set => SetArgument("protect_from_scale_in", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The service_linked_role_arn attribute.
    /// </summary>
    public TerraformValue<string> ServiceLinkedRoleArn
    {
        get => GetArgument<TerraformValue<string>>("service_linked_role_arn") ?? CreateReference("service_linked_role_arn");
        set => SetArgument("service_linked_role_arn", value);
    }

    /// <summary>
    /// The suspended_processes attribute.
    /// </summary>
    public TerraformSet<string>? SuspendedProcesses
    {
        get => GetArgument<TerraformSet<string>>("suspended_processes");
        set => SetArgument("suspended_processes", value);
    }

    /// <summary>
    /// The target_group_arns attribute.
    /// </summary>
    public TerraformSet<string> TargetGroupArns
    {
        get => GetArgument<TerraformSet<string>>("target_group_arns") ?? CreateReference("target_group_arns");
        set => SetArgument("target_group_arns", value);
    }

    /// <summary>
    /// The termination_policies attribute.
    /// </summary>
    public TerraformList<string>? TerminationPolicies
    {
        get => GetArgument<TerraformList<string>>("termination_policies");
        set => SetArgument("termination_policies", value);
    }

    /// <summary>
    /// The vpc_zone_identifier attribute.
    /// </summary>
    public TerraformSet<string> VpcZoneIdentifier
    {
        get => GetArgument<TerraformSet<string>>("vpc_zone_identifier") ?? CreateReference("vpc_zone_identifier");
        set => SetArgument("vpc_zone_identifier", value);
    }

    /// <summary>
    /// The wait_for_capacity_timeout attribute.
    /// </summary>
    public TerraformValue<string>? WaitForCapacityTimeout
    {
        get => GetArgument<TerraformValue<string>>("wait_for_capacity_timeout");
        set => SetArgument("wait_for_capacity_timeout", value);
    }

    /// <summary>
    /// The wait_for_elb_capacity attribute.
    /// </summary>
    public TerraformValue<double>? WaitForElbCapacity
    {
        get => GetArgument<TerraformValue<double>>("wait_for_elb_capacity");
        set => SetArgument("wait_for_elb_capacity", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The predicted_capacity attribute.
    /// </summary>
    public TerraformValue<double> PredictedCapacity
        => CreateReference("predicted_capacity");

    /// <summary>
    /// The warm_pool_size attribute.
    /// </summary>
    public TerraformValue<double> WarmPoolSize
        => CreateReference("warm_pool_size");

    /// <summary>
    /// AvailabilityZoneDistribution block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AvailabilityZoneDistribution block(s) allowed")]
    public TerraformList<AwsAutoscalingGroupAvailabilityZoneDistributionBlock>? AvailabilityZoneDistribution
    {
        get => GetArgument<TerraformList<AwsAutoscalingGroupAvailabilityZoneDistributionBlock>>("availability_zone_distribution");
        set => SetArgument("availability_zone_distribution", value);
    }

    /// <summary>
    /// CapacityReservationSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityReservationSpecification block(s) allowed")]
    public TerraformList<AwsAutoscalingGroupCapacityReservationSpecificationBlock>? CapacityReservationSpecification
    {
        get => GetArgument<TerraformList<AwsAutoscalingGroupCapacityReservationSpecificationBlock>>("capacity_reservation_specification");
        set => SetArgument("capacity_reservation_specification", value);
    }

    /// <summary>
    /// InitialLifecycleHook block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAutoscalingGroupInitialLifecycleHookBlock>? InitialLifecycleHook
    {
        get => GetArgument<TerraformSet<AwsAutoscalingGroupInitialLifecycleHookBlock>>("initial_lifecycle_hook");
        set => SetArgument("initial_lifecycle_hook", value);
    }

    /// <summary>
    /// InstanceMaintenancePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceMaintenancePolicy block(s) allowed")]
    public TerraformList<AwsAutoscalingGroupInstanceMaintenancePolicyBlock>? InstanceMaintenancePolicy
    {
        get => GetArgument<TerraformList<AwsAutoscalingGroupInstanceMaintenancePolicyBlock>>("instance_maintenance_policy");
        set => SetArgument("instance_maintenance_policy", value);
    }

    /// <summary>
    /// InstanceRefresh block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceRefresh block(s) allowed")]
    public TerraformList<AwsAutoscalingGroupInstanceRefreshBlock>? InstanceRefresh
    {
        get => GetArgument<TerraformList<AwsAutoscalingGroupInstanceRefreshBlock>>("instance_refresh");
        set => SetArgument("instance_refresh", value);
    }

    /// <summary>
    /// LaunchTemplate block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchTemplate block(s) allowed")]
    public TerraformList<AwsAutoscalingGroupLaunchTemplateBlock>? LaunchTemplate
    {
        get => GetArgument<TerraformList<AwsAutoscalingGroupLaunchTemplateBlock>>("launch_template");
        set => SetArgument("launch_template", value);
    }

    /// <summary>
    /// MixedInstancesPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MixedInstancesPolicy block(s) allowed")]
    public TerraformList<AwsAutoscalingGroupMixedInstancesPolicyBlock>? MixedInstancesPolicy
    {
        get => GetArgument<TerraformList<AwsAutoscalingGroupMixedInstancesPolicyBlock>>("mixed_instances_policy");
        set => SetArgument("mixed_instances_policy", value);
    }

    /// <summary>
    /// Tag block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAutoscalingGroupTagBlock>? Tag
    {
        get => GetArgument<TerraformSet<AwsAutoscalingGroupTagBlock>>("tag");
        set => SetArgument("tag", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsAutoscalingGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsAutoscalingGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// TrafficSource block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAutoscalingGroupTrafficSourceBlock>? TrafficSource
    {
        get => GetArgument<TerraformSet<AwsAutoscalingGroupTrafficSourceBlock>>("traffic_source");
        set => SetArgument("traffic_source", value);
    }

    /// <summary>
    /// WarmPool block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WarmPool block(s) allowed")]
    public TerraformList<AwsAutoscalingGroupWarmPoolBlock>? WarmPool
    {
        get => GetArgument<TerraformList<AwsAutoscalingGroupWarmPoolBlock>>("warm_pool");
        set => SetArgument("warm_pool", value);
    }

}
