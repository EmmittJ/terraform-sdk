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
        set => SetProperty("ami", value);
    }

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    public TerraformProperty<bool>? AssociatePublicIpAddress
    {
        set => SetProperty("associate_public_ip_address", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformProperty<string>? AvailabilityZone
    {
        set => SetProperty("availability_zone", value);
    }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    public TerraformProperty<bool>? EbsOptimized
    {
        set => SetProperty("ebs_optimized", value);
    }

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    public TerraformProperty<string>? IamInstanceProfile
    {
        set => SetProperty("iam_instance_profile", value);
    }

    /// <summary>
    /// The iam_instance_profile_arn attribute.
    /// </summary>
    public TerraformProperty<string>? IamInstanceProfileArn
    {
        set => SetProperty("iam_instance_profile_arn", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformProperty<string> InstanceType
    {
        set => SetProperty("instance_type", value);
    }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    public TerraformProperty<string>? KeyName
    {
        set => SetProperty("key_name", value);
    }

    /// <summary>
    /// The monitoring attribute.
    /// </summary>
    public TerraformProperty<bool>? Monitoring
    {
        set => SetProperty("monitoring", value);
    }

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    public TerraformProperty<string>? PlacementGroup
    {
        set => SetProperty("placement_group", value);
    }

    /// <summary>
    /// The placement_tenancy attribute.
    /// </summary>
    public TerraformProperty<string>? PlacementTenancy
    {
        set => SetProperty("placement_tenancy", value);
    }

    /// <summary>
    /// The spot_price attribute.
    /// </summary>
    public TerraformProperty<string>? SpotPrice
    {
        set => SetProperty("spot_price", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        set => SetProperty("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    public TerraformProperty<string>? UserData
    {
        set => SetProperty("user_data", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? VpcSecurityGroupIds
    {
        set => SetProperty("vpc_security_group_ids", value);
    }

    /// <summary>
    /// The weighted_capacity attribute.
    /// </summary>
    public TerraformProperty<string>? WeightedCapacity
    {
        set => SetProperty("weighted_capacity", value);
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
        set => SetProperty("create", value);
    }

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
        SetOutput("client_token");
        SetOutput("spot_request_state");
        SetOutput("allocation_strategy");
        SetOutput("context");
        SetOutput("excess_capacity_termination_policy");
        SetOutput("fleet_type");
        SetOutput("iam_fleet_role");
        SetOutput("id");
        SetOutput("instance_interruption_behaviour");
        SetOutput("instance_pools_to_use_count");
        SetOutput("load_balancers");
        SetOutput("on_demand_allocation_strategy");
        SetOutput("on_demand_max_total_price");
        SetOutput("on_demand_target_capacity");
        SetOutput("region");
        SetOutput("replace_unhealthy_instances");
        SetOutput("spot_price");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("target_capacity");
        SetOutput("target_capacity_unit_type");
        SetOutput("target_group_arns");
        SetOutput("terminate_instances_on_delete");
        SetOutput("terminate_instances_with_expiration");
        SetOutput("valid_from");
        SetOutput("valid_until");
        SetOutput("wait_for_fulfillment");
    }

    /// <summary>
    /// The allocation_strategy attribute.
    /// </summary>
    public TerraformProperty<string> AllocationStrategy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("allocation_strategy");
        set => SetProperty("allocation_strategy", value);
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
    /// The excess_capacity_termination_policy attribute.
    /// </summary>
    public TerraformProperty<string> ExcessCapacityTerminationPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("excess_capacity_termination_policy");
        set => SetProperty("excess_capacity_termination_policy", value);
    }

    /// <summary>
    /// The fleet_type attribute.
    /// </summary>
    public TerraformProperty<string> FleetType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("fleet_type");
        set => SetProperty("fleet_type", value);
    }

    /// <summary>
    /// The iam_fleet_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamFleetRole is required")]
    public required TerraformProperty<string> IamFleetRole
    {
        get => GetRequiredOutput<TerraformProperty<string>>("iam_fleet_role");
        set => SetProperty("iam_fleet_role", value);
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
    /// The instance_interruption_behaviour attribute.
    /// </summary>
    public TerraformProperty<string> InstanceInterruptionBehaviour
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_interruption_behaviour");
        set => SetProperty("instance_interruption_behaviour", value);
    }

    /// <summary>
    /// The instance_pools_to_use_count attribute.
    /// </summary>
    public TerraformProperty<double> InstancePoolsToUseCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("instance_pools_to_use_count");
        set => SetProperty("instance_pools_to_use_count", value);
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
    /// The on_demand_allocation_strategy attribute.
    /// </summary>
    public TerraformProperty<string> OnDemandAllocationStrategy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("on_demand_allocation_strategy");
        set => SetProperty("on_demand_allocation_strategy", value);
    }

    /// <summary>
    /// The on_demand_max_total_price attribute.
    /// </summary>
    public TerraformProperty<string> OnDemandMaxTotalPrice
    {
        get => GetRequiredOutput<TerraformProperty<string>>("on_demand_max_total_price");
        set => SetProperty("on_demand_max_total_price", value);
    }

    /// <summary>
    /// The on_demand_target_capacity attribute.
    /// </summary>
    public TerraformProperty<double> OnDemandTargetCapacity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("on_demand_target_capacity");
        set => SetProperty("on_demand_target_capacity", value);
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
    /// The replace_unhealthy_instances attribute.
    /// </summary>
    public TerraformProperty<bool> ReplaceUnhealthyInstances
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("replace_unhealthy_instances");
        set => SetProperty("replace_unhealthy_instances", value);
    }

    /// <summary>
    /// The spot_price attribute.
    /// </summary>
    public TerraformProperty<string> SpotPrice
    {
        get => GetRequiredOutput<TerraformProperty<string>>("spot_price");
        set => SetProperty("spot_price", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The target_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetCapacity is required")]
    public required TerraformProperty<double> TargetCapacity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("target_capacity");
        set => SetProperty("target_capacity", value);
    }

    /// <summary>
    /// The target_capacity_unit_type attribute.
    /// </summary>
    public TerraformProperty<string> TargetCapacityUnitType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_capacity_unit_type");
        set => SetProperty("target_capacity_unit_type", value);
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
    /// The terminate_instances_on_delete attribute.
    /// </summary>
    public TerraformProperty<string> TerminateInstancesOnDelete
    {
        get => GetRequiredOutput<TerraformProperty<string>>("terminate_instances_on_delete");
        set => SetProperty("terminate_instances_on_delete", value);
    }

    /// <summary>
    /// The terminate_instances_with_expiration attribute.
    /// </summary>
    public TerraformProperty<bool> TerminateInstancesWithExpiration
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("terminate_instances_with_expiration");
        set => SetProperty("terminate_instances_with_expiration", value);
    }

    /// <summary>
    /// The valid_from attribute.
    /// </summary>
    public TerraformProperty<string> ValidFrom
    {
        get => GetRequiredOutput<TerraformProperty<string>>("valid_from");
        set => SetProperty("valid_from", value);
    }

    /// <summary>
    /// The valid_until attribute.
    /// </summary>
    public TerraformProperty<string> ValidUntil
    {
        get => GetRequiredOutput<TerraformProperty<string>>("valid_until");
        set => SetProperty("valid_until", value);
    }

    /// <summary>
    /// The wait_for_fulfillment attribute.
    /// </summary>
    public TerraformProperty<bool> WaitForFulfillment
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("wait_for_fulfillment");
        set => SetProperty("wait_for_fulfillment", value);
    }

    /// <summary>
    /// Block for launch_specification.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsSpotFleetRequestLaunchSpecificationBlock>? LaunchSpecification
    {
        set => SetProperty("launch_specification", value);
    }

    /// <summary>
    /// Block for launch_template_config.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsSpotFleetRequestLaunchTemplateConfigBlock>? LaunchTemplateConfig
    {
        set => SetProperty("launch_template_config", value);
    }

    /// <summary>
    /// Block for spot_maintenance_strategies.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpotMaintenanceStrategies block(s) allowed")]
    public List<AwsSpotFleetRequestSpotMaintenanceStrategiesBlock>? SpotMaintenanceStrategies
    {
        set => SetProperty("spot_maintenance_strategies", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsSpotFleetRequestTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
