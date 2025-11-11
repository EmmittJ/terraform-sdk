using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for launch_specification in .
/// Nesting mode: set
/// </summary>
public partial class AwsSpotFleetRequestLaunchSpecificationBlock : TerraformBlockBase
{
    /// <summary>
    /// The ami attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ami is required")]
    [TerraformProperty("ami")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Ami { get; set; }

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    [TerraformProperty("associate_public_ip_address")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AssociatePublicIpAddress { get; set; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformProperty("availability_zone")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AvailabilityZone { get; set; }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    [TerraformProperty("ebs_optimized")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EbsOptimized { get; set; }

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    [TerraformProperty("iam_instance_profile")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IamInstanceProfile { get; set; }

    /// <summary>
    /// The iam_instance_profile_arn attribute.
    /// </summary>
    [TerraformProperty("iam_instance_profile_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IamInstanceProfileArn { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    [TerraformProperty("instance_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InstanceType { get; set; }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    [TerraformProperty("key_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KeyName { get; set; }

    /// <summary>
    /// The monitoring attribute.
    /// </summary>
    [TerraformProperty("monitoring")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Monitoring { get; set; }

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    [TerraformProperty("placement_group")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PlacementGroup { get; set; }

    /// <summary>
    /// The placement_tenancy attribute.
    /// </summary>
    [TerraformProperty("placement_tenancy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PlacementTenancy { get; set; }

    /// <summary>
    /// The spot_price attribute.
    /// </summary>
    [TerraformProperty("spot_price")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SpotPrice { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformProperty("subnet_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SubnetId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    [TerraformProperty("user_data")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserData { get; set; }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformProperty("vpc_security_group_ids")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> VpcSecurityGroupIds { get; set; }

    /// <summary>
    /// The weighted_capacity attribute.
    /// </summary>
    [TerraformProperty("weighted_capacity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? WeightedCapacity { get; set; }

}

/// <summary>
/// Block type for launch_template_config in .
/// Nesting mode: set
/// </summary>
public partial class AwsSpotFleetRequestLaunchTemplateConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for spot_maintenance_strategies in .
/// Nesting mode: list
/// </summary>
public partial class AwsSpotFleetRequestSpotMaintenanceStrategiesBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsSpotFleetRequestTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_spot_fleet_request resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSpotFleetRequest : TerraformResource
{
    public AwsSpotFleetRequest(string name) : base("aws_spot_fleet_request", name)
    {
    }

    /// <summary>
    /// The allocation_strategy attribute.
    /// </summary>
    [TerraformProperty("allocation_strategy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AllocationStrategy { get; set; }

    /// <summary>
    /// The context attribute.
    /// </summary>
    [TerraformProperty("context")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Context { get; set; }

    /// <summary>
    /// The excess_capacity_termination_policy attribute.
    /// </summary>
    [TerraformProperty("excess_capacity_termination_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExcessCapacityTerminationPolicy { get; set; }

    /// <summary>
    /// The fleet_type attribute.
    /// </summary>
    [TerraformProperty("fleet_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FleetType { get; set; }

    /// <summary>
    /// The iam_fleet_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamFleetRole is required")]
    [TerraformProperty("iam_fleet_role")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IamFleetRole { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The instance_interruption_behaviour attribute.
    /// </summary>
    [TerraformProperty("instance_interruption_behaviour")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InstanceInterruptionBehaviour { get; set; }

    /// <summary>
    /// The instance_pools_to_use_count attribute.
    /// </summary>
    [TerraformProperty("instance_pools_to_use_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? InstancePoolsToUseCount { get; set; }

    /// <summary>
    /// The load_balancers attribute.
    /// </summary>
    [TerraformProperty("load_balancers")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> LoadBalancers { get; set; }

    /// <summary>
    /// The on_demand_allocation_strategy attribute.
    /// </summary>
    [TerraformProperty("on_demand_allocation_strategy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OnDemandAllocationStrategy { get; set; }

    /// <summary>
    /// The on_demand_max_total_price attribute.
    /// </summary>
    [TerraformProperty("on_demand_max_total_price")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OnDemandMaxTotalPrice { get; set; }

    /// <summary>
    /// The on_demand_target_capacity attribute.
    /// </summary>
    [TerraformProperty("on_demand_target_capacity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? OnDemandTargetCapacity { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The replace_unhealthy_instances attribute.
    /// </summary>
    [TerraformProperty("replace_unhealthy_instances")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ReplaceUnhealthyInstances { get; set; }

    /// <summary>
    /// The spot_price attribute.
    /// </summary>
    [TerraformProperty("spot_price")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SpotPrice { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The target_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetCapacity is required")]
    [TerraformProperty("target_capacity")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> TargetCapacity { get; set; }

    /// <summary>
    /// The target_capacity_unit_type attribute.
    /// </summary>
    [TerraformProperty("target_capacity_unit_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetCapacityUnitType { get; set; }

    /// <summary>
    /// The target_group_arns attribute.
    /// </summary>
    [TerraformProperty("target_group_arns")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> TargetGroupArns { get; set; }

    /// <summary>
    /// The terminate_instances_on_delete attribute.
    /// </summary>
    [TerraformProperty("terminate_instances_on_delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TerminateInstancesOnDelete { get; set; }

    /// <summary>
    /// The terminate_instances_with_expiration attribute.
    /// </summary>
    [TerraformProperty("terminate_instances_with_expiration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? TerminateInstancesWithExpiration { get; set; }

    /// <summary>
    /// The valid_from attribute.
    /// </summary>
    [TerraformProperty("valid_from")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ValidFrom { get; set; }

    /// <summary>
    /// The valid_until attribute.
    /// </summary>
    [TerraformProperty("valid_until")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ValidUntil { get; set; }

    /// <summary>
    /// The wait_for_fulfillment attribute.
    /// </summary>
    [TerraformProperty("wait_for_fulfillment")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? WaitForFulfillment { get; set; }

    /// <summary>
    /// Block for launch_specification.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("launch_specification")]
    public partial TerraformSet<TerraformBlock<AwsSpotFleetRequestLaunchSpecificationBlock>>? LaunchSpecification { get; set; }

    /// <summary>
    /// Block for launch_template_config.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("launch_template_config")]
    public partial TerraformSet<TerraformBlock<AwsSpotFleetRequestLaunchTemplateConfigBlock>>? LaunchTemplateConfig { get; set; }

    /// <summary>
    /// Block for spot_maintenance_strategies.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpotMaintenanceStrategies block(s) allowed")]
    [TerraformProperty("spot_maintenance_strategies")]
    public partial TerraformList<TerraformBlock<AwsSpotFleetRequestSpotMaintenanceStrategiesBlock>>? SpotMaintenanceStrategies { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsSpotFleetRequestTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The client_token attribute.
    /// </summary>
    [TerraformProperty("client_token")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ClientToken { get; }

    /// <summary>
    /// The spot_request_state attribute.
    /// </summary>
    [TerraformProperty("spot_request_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SpotRequestState { get; }

}
