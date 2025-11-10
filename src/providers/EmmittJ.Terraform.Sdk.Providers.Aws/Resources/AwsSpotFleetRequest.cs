using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for launch_specification in .
/// Nesting mode: set
/// </summary>
public class AwsSpotFleetRequestLaunchSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// The ami attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ami is required")]
    public required TerraformProperty<string> Ami
    {
        get => GetRequiredProperty<TerraformProperty<string>>("ami");
        set => WithProperty("ami", value);
    }

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    public TerraformProperty<bool>? AssociatePublicIpAddress
    {
        get => GetProperty<TerraformProperty<bool>>("associate_public_ip_address");
        set => WithProperty("associate_public_ip_address", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformProperty<string>? AvailabilityZone
    {
        get => GetProperty<TerraformProperty<string>>("availability_zone");
        set => WithProperty("availability_zone", value);
    }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    public TerraformProperty<bool>? EbsOptimized
    {
        get => GetProperty<TerraformProperty<bool>>("ebs_optimized");
        set => WithProperty("ebs_optimized", value);
    }

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    public TerraformProperty<string>? IamInstanceProfile
    {
        get => GetProperty<TerraformProperty<string>>("iam_instance_profile");
        set => WithProperty("iam_instance_profile", value);
    }

    /// <summary>
    /// The iam_instance_profile_arn attribute.
    /// </summary>
    public TerraformProperty<string>? IamInstanceProfileArn
    {
        get => GetProperty<TerraformProperty<string>>("iam_instance_profile_arn");
        set => WithProperty("iam_instance_profile_arn", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformProperty<string> InstanceType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("instance_type");
        set => WithProperty("instance_type", value);
    }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    public TerraformProperty<string>? KeyName
    {
        get => GetProperty<TerraformProperty<string>>("key_name");
        set => WithProperty("key_name", value);
    }

    /// <summary>
    /// The monitoring attribute.
    /// </summary>
    public TerraformProperty<bool>? Monitoring
    {
        get => GetProperty<TerraformProperty<bool>>("monitoring");
        set => WithProperty("monitoring", value);
    }

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    public TerraformProperty<string>? PlacementGroup
    {
        get => GetProperty<TerraformProperty<string>>("placement_group");
        set => WithProperty("placement_group", value);
    }

    /// <summary>
    /// The placement_tenancy attribute.
    /// </summary>
    public TerraformProperty<string>? PlacementTenancy
    {
        get => GetProperty<TerraformProperty<string>>("placement_tenancy");
        set => WithProperty("placement_tenancy", value);
    }

    /// <summary>
    /// The spot_price attribute.
    /// </summary>
    public TerraformProperty<string>? SpotPrice
    {
        get => GetProperty<TerraformProperty<string>>("spot_price");
        set => WithProperty("spot_price", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => WithProperty("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => WithProperty("tags", value);
    }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    public TerraformProperty<string>? UserData
    {
        get => GetProperty<TerraformProperty<string>>("user_data");
        set => WithProperty("user_data", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? VpcSecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("vpc_security_group_ids");
        set => WithProperty("vpc_security_group_ids", value);
    }

    /// <summary>
    /// The weighted_capacity attribute.
    /// </summary>
    public TerraformProperty<string>? WeightedCapacity
    {
        get => GetProperty<TerraformProperty<string>>("weighted_capacity");
        set => WithProperty("weighted_capacity", value);
    }

}

/// <summary>
/// Block type for launch_template_config in .
/// Nesting mode: set
/// </summary>
public class AwsSpotFleetRequestLaunchTemplateConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for spot_maintenance_strategies in .
/// Nesting mode: list
/// </summary>
public class AwsSpotFleetRequestSpotMaintenanceStrategiesBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsSpotFleetRequestTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

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
/// Manages a aws_spot_fleet_request resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSpotFleetRequest : TerraformResource
{
    public AwsSpotFleetRequest(string name) : base("aws_spot_fleet_request", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("client_token");
        this.WithOutput("spot_request_state");
    }

    /// <summary>
    /// The allocation_strategy attribute.
    /// </summary>
    public TerraformProperty<string>? AllocationStrategy
    {
        get => GetProperty<TerraformProperty<string>>("allocation_strategy");
        set => this.WithProperty("allocation_strategy", value);
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
    /// The excess_capacity_termination_policy attribute.
    /// </summary>
    public TerraformProperty<string>? ExcessCapacityTerminationPolicy
    {
        get => GetProperty<TerraformProperty<string>>("excess_capacity_termination_policy");
        set => this.WithProperty("excess_capacity_termination_policy", value);
    }

    /// <summary>
    /// The fleet_type attribute.
    /// </summary>
    public TerraformProperty<string>? FleetType
    {
        get => GetProperty<TerraformProperty<string>>("fleet_type");
        set => this.WithProperty("fleet_type", value);
    }

    /// <summary>
    /// The iam_fleet_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamFleetRole is required")]
    public required TerraformProperty<string> IamFleetRole
    {
        get => GetRequiredProperty<TerraformProperty<string>>("iam_fleet_role");
        set => this.WithProperty("iam_fleet_role", value);
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
    /// The instance_interruption_behaviour attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceInterruptionBehaviour
    {
        get => GetProperty<TerraformProperty<string>>("instance_interruption_behaviour");
        set => this.WithProperty("instance_interruption_behaviour", value);
    }

    /// <summary>
    /// The instance_pools_to_use_count attribute.
    /// </summary>
    public TerraformProperty<double>? InstancePoolsToUseCount
    {
        get => GetProperty<TerraformProperty<double>>("instance_pools_to_use_count");
        set => this.WithProperty("instance_pools_to_use_count", value);
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
    /// The on_demand_allocation_strategy attribute.
    /// </summary>
    public TerraformProperty<string>? OnDemandAllocationStrategy
    {
        get => GetProperty<TerraformProperty<string>>("on_demand_allocation_strategy");
        set => this.WithProperty("on_demand_allocation_strategy", value);
    }

    /// <summary>
    /// The on_demand_max_total_price attribute.
    /// </summary>
    public TerraformProperty<string>? OnDemandMaxTotalPrice
    {
        get => GetProperty<TerraformProperty<string>>("on_demand_max_total_price");
        set => this.WithProperty("on_demand_max_total_price", value);
    }

    /// <summary>
    /// The on_demand_target_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? OnDemandTargetCapacity
    {
        get => GetProperty<TerraformProperty<double>>("on_demand_target_capacity");
        set => this.WithProperty("on_demand_target_capacity", value);
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
    /// The replace_unhealthy_instances attribute.
    /// </summary>
    public TerraformProperty<bool>? ReplaceUnhealthyInstances
    {
        get => GetProperty<TerraformProperty<bool>>("replace_unhealthy_instances");
        set => this.WithProperty("replace_unhealthy_instances", value);
    }

    /// <summary>
    /// The spot_price attribute.
    /// </summary>
    public TerraformProperty<string>? SpotPrice
    {
        get => GetProperty<TerraformProperty<string>>("spot_price");
        set => this.WithProperty("spot_price", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The target_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetCapacity is required")]
    public required TerraformProperty<double> TargetCapacity
    {
        get => GetRequiredProperty<TerraformProperty<double>>("target_capacity");
        set => this.WithProperty("target_capacity", value);
    }

    /// <summary>
    /// The target_capacity_unit_type attribute.
    /// </summary>
    public TerraformProperty<string>? TargetCapacityUnitType
    {
        get => GetProperty<TerraformProperty<string>>("target_capacity_unit_type");
        set => this.WithProperty("target_capacity_unit_type", value);
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
    /// The terminate_instances_on_delete attribute.
    /// </summary>
    public TerraformProperty<string>? TerminateInstancesOnDelete
    {
        get => GetProperty<TerraformProperty<string>>("terminate_instances_on_delete");
        set => this.WithProperty("terminate_instances_on_delete", value);
    }

    /// <summary>
    /// The terminate_instances_with_expiration attribute.
    /// </summary>
    public TerraformProperty<bool>? TerminateInstancesWithExpiration
    {
        get => GetProperty<TerraformProperty<bool>>("terminate_instances_with_expiration");
        set => this.WithProperty("terminate_instances_with_expiration", value);
    }

    /// <summary>
    /// The valid_from attribute.
    /// </summary>
    public TerraformProperty<string>? ValidFrom
    {
        get => GetProperty<TerraformProperty<string>>("valid_from");
        set => this.WithProperty("valid_from", value);
    }

    /// <summary>
    /// The valid_until attribute.
    /// </summary>
    public TerraformProperty<string>? ValidUntil
    {
        get => GetProperty<TerraformProperty<string>>("valid_until");
        set => this.WithProperty("valid_until", value);
    }

    /// <summary>
    /// The wait_for_fulfillment attribute.
    /// </summary>
    public TerraformProperty<bool>? WaitForFulfillment
    {
        get => GetProperty<TerraformProperty<bool>>("wait_for_fulfillment");
        set => this.WithProperty("wait_for_fulfillment", value);
    }

    /// <summary>
    /// Block for launch_specification.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsSpotFleetRequestLaunchSpecificationBlock>? LaunchSpecification
    {
        get => GetProperty<HashSet<AwsSpotFleetRequestLaunchSpecificationBlock>>("launch_specification");
        set => this.WithProperty("launch_specification", value);
    }

    /// <summary>
    /// Block for launch_template_config.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsSpotFleetRequestLaunchTemplateConfigBlock>? LaunchTemplateConfig
    {
        get => GetProperty<HashSet<AwsSpotFleetRequestLaunchTemplateConfigBlock>>("launch_template_config");
        set => this.WithProperty("launch_template_config", value);
    }

    /// <summary>
    /// Block for spot_maintenance_strategies.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpotMaintenanceStrategies block(s) allowed")]
    public List<AwsSpotFleetRequestSpotMaintenanceStrategiesBlock>? SpotMaintenanceStrategies
    {
        get => GetProperty<List<AwsSpotFleetRequestSpotMaintenanceStrategiesBlock>>("spot_maintenance_strategies");
        set => this.WithProperty("spot_maintenance_strategies", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsSpotFleetRequestTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsSpotFleetRequestTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The client_token attribute.
    /// </summary>
    public TerraformExpression ClientToken => this["client_token"];

    /// <summary>
    /// The spot_request_state attribute.
    /// </summary>
    public TerraformExpression SpotRequestState => this["spot_request_state"];

}
