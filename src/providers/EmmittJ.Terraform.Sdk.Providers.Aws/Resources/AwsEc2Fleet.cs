using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for fleet_instance_set in .
/// Nesting mode: list
/// </summary>
public partial class AwsEc2FleetFleetInstanceSetBlock : TerraformBlockBase
{
    /// <summary>
    /// The instance_ids attribute.
    /// </summary>
    [TerraformProperty("instance_ids")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> InstanceIds { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformProperty("instance_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> InstanceType { get; set; }

    /// <summary>
    /// The lifecycle attribute.
    /// </summary>
    [TerraformProperty("lifecycle")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Lifecycle { get; set; }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [TerraformProperty("platform")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Platform { get; set; }

}

/// <summary>
/// Block type for launch_template_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsEc2FleetLaunchTemplateConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for on_demand_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsEc2FleetOnDemandOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The allocation_strategy attribute.
    /// </summary>
    [TerraformProperty("allocation_strategy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AllocationStrategy { get; set; }

    /// <summary>
    /// The max_total_price attribute.
    /// </summary>
    [TerraformProperty("max_total_price")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MaxTotalPrice { get; set; }

    /// <summary>
    /// The min_target_capacity attribute.
    /// </summary>
    [TerraformProperty("min_target_capacity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MinTargetCapacity { get; set; }

    /// <summary>
    /// The single_availability_zone attribute.
    /// </summary>
    [TerraformProperty("single_availability_zone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SingleAvailabilityZone { get; set; }

    /// <summary>
    /// The single_instance_type attribute.
    /// </summary>
    [TerraformProperty("single_instance_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SingleInstanceType { get; set; }

}

/// <summary>
/// Block type for spot_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsEc2FleetSpotOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The allocation_strategy attribute.
    /// </summary>
    [TerraformProperty("allocation_strategy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AllocationStrategy { get; set; }

    /// <summary>
    /// The instance_interruption_behavior attribute.
    /// </summary>
    [TerraformProperty("instance_interruption_behavior")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InstanceInterruptionBehavior { get; set; }

    /// <summary>
    /// The instance_pools_to_use_count attribute.
    /// </summary>
    [TerraformProperty("instance_pools_to_use_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? InstancePoolsToUseCount { get; set; }

    /// <summary>
    /// The max_total_price attribute.
    /// </summary>
    [TerraformProperty("max_total_price")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MaxTotalPrice { get; set; }

    /// <summary>
    /// The min_target_capacity attribute.
    /// </summary>
    [TerraformProperty("min_target_capacity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MinTargetCapacity { get; set; }

    /// <summary>
    /// The single_availability_zone attribute.
    /// </summary>
    [TerraformProperty("single_availability_zone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SingleAvailabilityZone { get; set; }

    /// <summary>
    /// The single_instance_type attribute.
    /// </summary>
    [TerraformProperty("single_instance_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SingleInstanceType { get; set; }

}

/// <summary>
/// Block type for target_capacity_specification in .
/// Nesting mode: list
/// </summary>
public partial class AwsEc2FleetTargetCapacitySpecificationBlock : TerraformBlockBase
{
    /// <summary>
    /// The default_target_capacity_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultTargetCapacityType is required")]
    [TerraformProperty("default_target_capacity_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DefaultTargetCapacityType { get; set; }

    /// <summary>
    /// The on_demand_target_capacity attribute.
    /// </summary>
    [TerraformProperty("on_demand_target_capacity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? OnDemandTargetCapacity { get; set; }

    /// <summary>
    /// The spot_target_capacity attribute.
    /// </summary>
    [TerraformProperty("spot_target_capacity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? SpotTargetCapacity { get; set; }

    /// <summary>
    /// The target_capacity_unit_type attribute.
    /// </summary>
    [TerraformProperty("target_capacity_unit_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetCapacityUnitType { get; set; }

    /// <summary>
    /// The total_target_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TotalTargetCapacity is required")]
    [TerraformProperty("total_target_capacity")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> TotalTargetCapacity { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsEc2FleetTimeoutsBlock : TerraformBlockBase
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
/// Manages a aws_ec2_fleet resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsEc2Fleet : TerraformResource
{
    public AwsEc2Fleet(string name) : base("aws_ec2_fleet", name)
    {
    }

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
    /// The fleet_state attribute.
    /// </summary>
    [TerraformProperty("fleet_state")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> FleetState { get; set; }

    /// <summary>
    /// The fulfilled_capacity attribute.
    /// </summary>
    [TerraformProperty("fulfilled_capacity")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> FulfilledCapacity { get; set; }

    /// <summary>
    /// The fulfilled_on_demand_capacity attribute.
    /// </summary>
    [TerraformProperty("fulfilled_on_demand_capacity")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> FulfilledOnDemandCapacity { get; set; }

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
    /// The replace_unhealthy_instances attribute.
    /// </summary>
    [TerraformProperty("replace_unhealthy_instances")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ReplaceUnhealthyInstances { get; set; }

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
    /// The terminate_instances attribute.
    /// </summary>
    [TerraformProperty("terminate_instances")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? TerminateInstances { get; set; }

    /// <summary>
    /// The terminate_instances_with_expiration attribute.
    /// </summary>
    [TerraformProperty("terminate_instances_with_expiration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? TerminateInstancesWithExpiration { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

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
    /// Block for fleet_instance_set.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("fleet_instance_set")]
    public partial TerraformList<TerraformBlock<AwsEc2FleetFleetInstanceSetBlock>>? FleetInstanceSet { get; set; }

    /// <summary>
    /// Block for launch_template_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LaunchTemplateConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LaunchTemplateConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 LaunchTemplateConfig block(s) allowed")]
    [TerraformProperty("launch_template_config")]
    public partial TerraformList<TerraformBlock<AwsEc2FleetLaunchTemplateConfigBlock>>? LaunchTemplateConfig { get; set; }

    /// <summary>
    /// Block for on_demand_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnDemandOptions block(s) allowed")]
    [TerraformProperty("on_demand_options")]
    public partial TerraformList<TerraformBlock<AwsEc2FleetOnDemandOptionsBlock>>? OnDemandOptions { get; set; }

    /// <summary>
    /// Block for spot_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpotOptions block(s) allowed")]
    [TerraformProperty("spot_options")]
    public partial TerraformList<TerraformBlock<AwsEc2FleetSpotOptionsBlock>>? SpotOptions { get; set; }

    /// <summary>
    /// Block for target_capacity_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetCapacitySpecification is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetCapacitySpecification block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetCapacitySpecification block(s) allowed")]
    [TerraformProperty("target_capacity_specification")]
    public partial TerraformList<TerraformBlock<AwsEc2FleetTargetCapacitySpecificationBlock>>? TargetCapacitySpecification { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsEc2FleetTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
