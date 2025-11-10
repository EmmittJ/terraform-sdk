using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for launch_specification in .
/// Nesting mode: set
/// </summary>
public class AwsSpotFleetRequestLaunchSpecificationBlock : ITerraformBlock
{
    /// <summary>
    /// The ami attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ami is required")]
    [TerraformPropertyName("ami")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Ami { get; set; }

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    [TerraformPropertyName("associate_public_ip_address")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AssociatePublicIpAddress { get; set; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AvailabilityZone { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "availability_zone");

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    [TerraformPropertyName("ebs_optimized")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EbsOptimized { get; set; }

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    [TerraformPropertyName("iam_instance_profile")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IamInstanceProfile { get; set; }

    /// <summary>
    /// The iam_instance_profile_arn attribute.
    /// </summary>
    [TerraformPropertyName("iam_instance_profile_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IamInstanceProfileArn { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    [TerraformPropertyName("instance_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InstanceType { get; set; }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    [TerraformPropertyName("key_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KeyName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "key_name");

    /// <summary>
    /// The monitoring attribute.
    /// </summary>
    [TerraformPropertyName("monitoring")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Monitoring { get; set; }

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    [TerraformPropertyName("placement_group")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PlacementGroup { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "placement_group");

    /// <summary>
    /// The placement_tenancy attribute.
    /// </summary>
    [TerraformPropertyName("placement_tenancy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PlacementTenancy { get; set; }

    /// <summary>
    /// The spot_price attribute.
    /// </summary>
    [TerraformPropertyName("spot_price")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SpotPrice { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SubnetId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "subnet_id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    [TerraformPropertyName("user_data")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UserData { get; set; }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("vpc_security_group_ids")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> VpcSecurityGroupIds { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>("", "vpc_security_group_ids");

    /// <summary>
    /// The weighted_capacity attribute.
    /// </summary>
    [TerraformPropertyName("weighted_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? WeightedCapacity { get; set; }

}

/// <summary>
/// Block type for launch_template_config in .
/// Nesting mode: set
/// </summary>
public class AwsSpotFleetRequestLaunchTemplateConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for spot_maintenance_strategies in .
/// Nesting mode: list
/// </summary>
public class AwsSpotFleetRequestSpotMaintenanceStrategiesBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsSpotFleetRequestTimeoutsBlock : ITerraformBlock
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
/// Manages a aws_spot_fleet_request resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSpotFleetRequest : TerraformResource
{
    public AwsSpotFleetRequest(string name) : base("aws_spot_fleet_request", name)
    {
    }

    /// <summary>
    /// The allocation_strategy attribute.
    /// </summary>
    [TerraformPropertyName("allocation_strategy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AllocationStrategy { get; set; }

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
    /// The fleet_type attribute.
    /// </summary>
    [TerraformPropertyName("fleet_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FleetType { get; set; }

    /// <summary>
    /// The iam_fleet_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamFleetRole is required")]
    [TerraformPropertyName("iam_fleet_role")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> IamFleetRole { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The instance_interruption_behaviour attribute.
    /// </summary>
    [TerraformPropertyName("instance_interruption_behaviour")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InstanceInterruptionBehaviour { get; set; }

    /// <summary>
    /// The instance_pools_to_use_count attribute.
    /// </summary>
    [TerraformPropertyName("instance_pools_to_use_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? InstancePoolsToUseCount { get; set; }

    /// <summary>
    /// The load_balancers attribute.
    /// </summary>
    [TerraformPropertyName("load_balancers")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> LoadBalancers { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "load_balancers");

    /// <summary>
    /// The on_demand_allocation_strategy attribute.
    /// </summary>
    [TerraformPropertyName("on_demand_allocation_strategy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OnDemandAllocationStrategy { get; set; }

    /// <summary>
    /// The on_demand_max_total_price attribute.
    /// </summary>
    [TerraformPropertyName("on_demand_max_total_price")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OnDemandMaxTotalPrice { get; set; }

    /// <summary>
    /// The on_demand_target_capacity attribute.
    /// </summary>
    [TerraformPropertyName("on_demand_target_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? OnDemandTargetCapacity { get; set; }

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
    /// The spot_price attribute.
    /// </summary>
    [TerraformPropertyName("spot_price")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SpotPrice { get; set; }

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
    /// The target_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetCapacity is required")]
    [TerraformPropertyName("target_capacity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> TargetCapacity { get; set; }

    /// <summary>
    /// The target_capacity_unit_type attribute.
    /// </summary>
    [TerraformPropertyName("target_capacity_unit_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TargetCapacityUnitType { get; set; }

    /// <summary>
    /// The target_group_arns attribute.
    /// </summary>
    [TerraformPropertyName("target_group_arns")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> TargetGroupArns { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "target_group_arns");

    /// <summary>
    /// The terminate_instances_on_delete attribute.
    /// </summary>
    [TerraformPropertyName("terminate_instances_on_delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TerminateInstancesOnDelete { get; set; }

    /// <summary>
    /// The terminate_instances_with_expiration attribute.
    /// </summary>
    [TerraformPropertyName("terminate_instances_with_expiration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? TerminateInstancesWithExpiration { get; set; }

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
    /// The wait_for_fulfillment attribute.
    /// </summary>
    [TerraformPropertyName("wait_for_fulfillment")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? WaitForFulfillment { get; set; }

    /// <summary>
    /// Block for launch_specification.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("launch_specification")]
    public TerraformSet<TerraformBlock<AwsSpotFleetRequestLaunchSpecificationBlock>>? LaunchSpecification { get; set; } = new();

    /// <summary>
    /// Block for launch_template_config.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("launch_template_config")]
    public TerraformSet<TerraformBlock<AwsSpotFleetRequestLaunchTemplateConfigBlock>>? LaunchTemplateConfig { get; set; } = new();

    /// <summary>
    /// Block for spot_maintenance_strategies.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpotMaintenanceStrategies block(s) allowed")]
    [TerraformPropertyName("spot_maintenance_strategies")]
    public TerraformList<TerraformBlock<AwsSpotFleetRequestSpotMaintenanceStrategiesBlock>>? SpotMaintenanceStrategies { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsSpotFleetRequestTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The client_token attribute.
    /// </summary>
    [TerraformPropertyName("client_token")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClientToken => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "client_token");

    /// <summary>
    /// The spot_request_state attribute.
    /// </summary>
    [TerraformPropertyName("spot_request_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SpotRequestState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "spot_request_state");

}
