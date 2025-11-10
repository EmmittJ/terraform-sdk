using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for fleet_instance_set in .
/// Nesting mode: list
/// </summary>
public class AwsEc2FleetFleetInstanceSetBlock : ITerraformBlock
{
    /// <summary>
    /// The instance_ids attribute.
    /// </summary>
    [TerraformPropertyName("instance_ids")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> InstanceIds { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "instance_ids");

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformPropertyName("instance_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> InstanceType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "instance_type");

    /// <summary>
    /// The lifecycle attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Lifecycle { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "lifecycle");

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [TerraformPropertyName("platform")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Platform { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "platform");

}

/// <summary>
/// Block type for launch_template_config in .
/// Nesting mode: list
/// </summary>
public class AwsEc2FleetLaunchTemplateConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for on_demand_options in .
/// Nesting mode: list
/// </summary>
public class AwsEc2FleetOnDemandOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The allocation_strategy attribute.
    /// </summary>
    [TerraformPropertyName("allocation_strategy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AllocationStrategy { get; set; }

    /// <summary>
    /// The max_total_price attribute.
    /// </summary>
    [TerraformPropertyName("max_total_price")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MaxTotalPrice { get; set; }

    /// <summary>
    /// The min_target_capacity attribute.
    /// </summary>
    [TerraformPropertyName("min_target_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MinTargetCapacity { get; set; }

    /// <summary>
    /// The single_availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("single_availability_zone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SingleAvailabilityZone { get; set; }

    /// <summary>
    /// The single_instance_type attribute.
    /// </summary>
    [TerraformPropertyName("single_instance_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SingleInstanceType { get; set; }

}

/// <summary>
/// Block type for spot_options in .
/// Nesting mode: list
/// </summary>
public class AwsEc2FleetSpotOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The allocation_strategy attribute.
    /// </summary>
    [TerraformPropertyName("allocation_strategy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AllocationStrategy { get; set; }

    /// <summary>
    /// The instance_interruption_behavior attribute.
    /// </summary>
    [TerraformPropertyName("instance_interruption_behavior")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InstanceInterruptionBehavior { get; set; }

    /// <summary>
    /// The instance_pools_to_use_count attribute.
    /// </summary>
    [TerraformPropertyName("instance_pools_to_use_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? InstancePoolsToUseCount { get; set; }

    /// <summary>
    /// The max_total_price attribute.
    /// </summary>
    [TerraformPropertyName("max_total_price")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MaxTotalPrice { get; set; }

    /// <summary>
    /// The min_target_capacity attribute.
    /// </summary>
    [TerraformPropertyName("min_target_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MinTargetCapacity { get; set; }

    /// <summary>
    /// The single_availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("single_availability_zone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SingleAvailabilityZone { get; set; }

    /// <summary>
    /// The single_instance_type attribute.
    /// </summary>
    [TerraformPropertyName("single_instance_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SingleInstanceType { get; set; }

}

/// <summary>
/// Block type for target_capacity_specification in .
/// Nesting mode: list
/// </summary>
public class AwsEc2FleetTargetCapacitySpecificationBlock : ITerraformBlock
{
    /// <summary>
    /// The default_target_capacity_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultTargetCapacityType is required")]
    [TerraformPropertyName("default_target_capacity_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DefaultTargetCapacityType { get; set; }

    /// <summary>
    /// The on_demand_target_capacity attribute.
    /// </summary>
    [TerraformPropertyName("on_demand_target_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? OnDemandTargetCapacity { get; set; }

    /// <summary>
    /// The spot_target_capacity attribute.
    /// </summary>
    [TerraformPropertyName("spot_target_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? SpotTargetCapacity { get; set; }

    /// <summary>
    /// The target_capacity_unit_type attribute.
    /// </summary>
    [TerraformPropertyName("target_capacity_unit_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TargetCapacityUnitType { get; set; }

    /// <summary>
    /// The total_target_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TotalTargetCapacity is required")]
    [TerraformPropertyName("total_target_capacity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> TotalTargetCapacity { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEc2FleetTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

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
/// Manages a aws_ec2_fleet resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEc2Fleet : TerraformResource
{
    public AwsEc2Fleet(string name) : base("aws_ec2_fleet", name)
    {
    }

    /// <summary>
    /// The context attribute.
    /// </summary>
    [TerraformPropertyName("context")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Context { get; set; }

    /// <summary>
    /// The excess_capacity_termination_policy attribute.
    /// </summary>
    [TerraformPropertyName("excess_capacity_termination_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ExcessCapacityTerminationPolicy { get; set; }

    /// <summary>
    /// The fleet_state attribute.
    /// </summary>
    [TerraformPropertyName("fleet_state")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> FleetState { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "fleet_state");

    /// <summary>
    /// The fulfilled_capacity attribute.
    /// </summary>
    [TerraformPropertyName("fulfilled_capacity")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> FulfilledCapacity { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "fulfilled_capacity");

    /// <summary>
    /// The fulfilled_on_demand_capacity attribute.
    /// </summary>
    [TerraformPropertyName("fulfilled_on_demand_capacity")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> FulfilledOnDemandCapacity { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "fulfilled_on_demand_capacity");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The replace_unhealthy_instances attribute.
    /// </summary>
    [TerraformPropertyName("replace_unhealthy_instances")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ReplaceUnhealthyInstances { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The terminate_instances attribute.
    /// </summary>
    [TerraformPropertyName("terminate_instances")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? TerminateInstances { get; set; }

    /// <summary>
    /// The terminate_instances_with_expiration attribute.
    /// </summary>
    [TerraformPropertyName("terminate_instances_with_expiration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? TerminateInstancesWithExpiration { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Type { get; set; }

    /// <summary>
    /// The valid_from attribute.
    /// </summary>
    [TerraformPropertyName("valid_from")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ValidFrom { get; set; }

    /// <summary>
    /// The valid_until attribute.
    /// </summary>
    [TerraformPropertyName("valid_until")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ValidUntil { get; set; }

    /// <summary>
    /// Block for fleet_instance_set.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("fleet_instance_set")]
    public TerraformList<TerraformBlock<AwsEc2FleetFleetInstanceSetBlock>>? FleetInstanceSet { get; set; } = new();

    /// <summary>
    /// Block for launch_template_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LaunchTemplateConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LaunchTemplateConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 LaunchTemplateConfig block(s) allowed")]
    [TerraformPropertyName("launch_template_config")]
    public TerraformList<TerraformBlock<AwsEc2FleetLaunchTemplateConfigBlock>>? LaunchTemplateConfig { get; set; } = new();

    /// <summary>
    /// Block for on_demand_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnDemandOptions block(s) allowed")]
    [TerraformPropertyName("on_demand_options")]
    public TerraformList<TerraformBlock<AwsEc2FleetOnDemandOptionsBlock>>? OnDemandOptions { get; set; } = new();

    /// <summary>
    /// Block for spot_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpotOptions block(s) allowed")]
    [TerraformPropertyName("spot_options")]
    public TerraformList<TerraformBlock<AwsEc2FleetSpotOptionsBlock>>? SpotOptions { get; set; } = new();

    /// <summary>
    /// Block for target_capacity_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetCapacitySpecification is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetCapacitySpecification block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetCapacitySpecification block(s) allowed")]
    [TerraformPropertyName("target_capacity_specification")]
    public TerraformList<TerraformBlock<AwsEc2FleetTargetCapacitySpecificationBlock>>? TargetCapacitySpecification { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsEc2FleetTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
