using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for fleet_instance_set in .
/// Nesting mode: list
/// </summary>
public class AwsEc2FleetFleetInstanceSetBlock : TerraformBlock
{
    /// <summary>
    /// The instance_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>>? InstanceIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("instance_ids");
        set => WithProperty("instance_ids", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceType
    {
        get => GetProperty<TerraformProperty<string>>("instance_type");
        set => WithProperty("instance_type", value);
    }

    /// <summary>
    /// The lifecycle attribute.
    /// </summary>
    public TerraformProperty<string>? Lifecycle
    {
        get => GetProperty<TerraformProperty<string>>("lifecycle");
        set => WithProperty("lifecycle", value);
    }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public TerraformProperty<string>? Platform
    {
        get => GetProperty<TerraformProperty<string>>("platform");
        set => WithProperty("platform", value);
    }

}

/// <summary>
/// Block type for launch_template_config in .
/// Nesting mode: list
/// </summary>
public class AwsEc2FleetLaunchTemplateConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for on_demand_options in .
/// Nesting mode: list
/// </summary>
public class AwsEc2FleetOnDemandOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The allocation_strategy attribute.
    /// </summary>
    public TerraformProperty<string>? AllocationStrategy
    {
        get => GetProperty<TerraformProperty<string>>("allocation_strategy");
        set => WithProperty("allocation_strategy", value);
    }

    /// <summary>
    /// The max_total_price attribute.
    /// </summary>
    public TerraformProperty<string>? MaxTotalPrice
    {
        get => GetProperty<TerraformProperty<string>>("max_total_price");
        set => WithProperty("max_total_price", value);
    }

    /// <summary>
    /// The min_target_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? MinTargetCapacity
    {
        get => GetProperty<TerraformProperty<double>>("min_target_capacity");
        set => WithProperty("min_target_capacity", value);
    }

    /// <summary>
    /// The single_availability_zone attribute.
    /// </summary>
    public TerraformProperty<bool>? SingleAvailabilityZone
    {
        get => GetProperty<TerraformProperty<bool>>("single_availability_zone");
        set => WithProperty("single_availability_zone", value);
    }

    /// <summary>
    /// The single_instance_type attribute.
    /// </summary>
    public TerraformProperty<bool>? SingleInstanceType
    {
        get => GetProperty<TerraformProperty<bool>>("single_instance_type");
        set => WithProperty("single_instance_type", value);
    }

}

/// <summary>
/// Block type for spot_options in .
/// Nesting mode: list
/// </summary>
public class AwsEc2FleetSpotOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The allocation_strategy attribute.
    /// </summary>
    public TerraformProperty<string>? AllocationStrategy
    {
        get => GetProperty<TerraformProperty<string>>("allocation_strategy");
        set => WithProperty("allocation_strategy", value);
    }

    /// <summary>
    /// The instance_interruption_behavior attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceInterruptionBehavior
    {
        get => GetProperty<TerraformProperty<string>>("instance_interruption_behavior");
        set => WithProperty("instance_interruption_behavior", value);
    }

    /// <summary>
    /// The instance_pools_to_use_count attribute.
    /// </summary>
    public TerraformProperty<double>? InstancePoolsToUseCount
    {
        get => GetProperty<TerraformProperty<double>>("instance_pools_to_use_count");
        set => WithProperty("instance_pools_to_use_count", value);
    }

    /// <summary>
    /// The max_total_price attribute.
    /// </summary>
    public TerraformProperty<string>? MaxTotalPrice
    {
        get => GetProperty<TerraformProperty<string>>("max_total_price");
        set => WithProperty("max_total_price", value);
    }

    /// <summary>
    /// The min_target_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? MinTargetCapacity
    {
        get => GetProperty<TerraformProperty<double>>("min_target_capacity");
        set => WithProperty("min_target_capacity", value);
    }

    /// <summary>
    /// The single_availability_zone attribute.
    /// </summary>
    public TerraformProperty<bool>? SingleAvailabilityZone
    {
        get => GetProperty<TerraformProperty<bool>>("single_availability_zone");
        set => WithProperty("single_availability_zone", value);
    }

    /// <summary>
    /// The single_instance_type attribute.
    /// </summary>
    public TerraformProperty<bool>? SingleInstanceType
    {
        get => GetProperty<TerraformProperty<bool>>("single_instance_type");
        set => WithProperty("single_instance_type", value);
    }

}

/// <summary>
/// Block type for target_capacity_specification in .
/// Nesting mode: list
/// </summary>
public class AwsEc2FleetTargetCapacitySpecificationBlock : TerraformBlock
{
    /// <summary>
    /// The default_target_capacity_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultTargetCapacityType is required")]
    public required TerraformProperty<string> DefaultTargetCapacityType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("default_target_capacity_type");
        set => WithProperty("default_target_capacity_type", value);
    }

    /// <summary>
    /// The on_demand_target_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? OnDemandTargetCapacity
    {
        get => GetProperty<TerraformProperty<double>>("on_demand_target_capacity");
        set => WithProperty("on_demand_target_capacity", value);
    }

    /// <summary>
    /// The spot_target_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? SpotTargetCapacity
    {
        get => GetProperty<TerraformProperty<double>>("spot_target_capacity");
        set => WithProperty("spot_target_capacity", value);
    }

    /// <summary>
    /// The target_capacity_unit_type attribute.
    /// </summary>
    public TerraformProperty<string>? TargetCapacityUnitType
    {
        get => GetProperty<TerraformProperty<string>>("target_capacity_unit_type");
        set => WithProperty("target_capacity_unit_type", value);
    }

    /// <summary>
    /// The total_target_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TotalTargetCapacity is required")]
    public required TerraformProperty<double> TotalTargetCapacity
    {
        get => GetRequiredProperty<TerraformProperty<double>>("total_target_capacity");
        set => WithProperty("total_target_capacity", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEc2FleetTimeoutsBlock : TerraformBlock
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
/// Manages a aws_ec2_fleet resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEc2Fleet : TerraformResource
{
    public AwsEc2Fleet(string name) : base("aws_ec2_fleet", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
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
    /// The fleet_state attribute.
    /// </summary>
    public TerraformProperty<string>? FleetState
    {
        get => GetProperty<TerraformProperty<string>>("fleet_state");
        set => this.WithProperty("fleet_state", value);
    }

    /// <summary>
    /// The fulfilled_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? FulfilledCapacity
    {
        get => GetProperty<TerraformProperty<double>>("fulfilled_capacity");
        set => this.WithProperty("fulfilled_capacity", value);
    }

    /// <summary>
    /// The fulfilled_on_demand_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? FulfilledOnDemandCapacity
    {
        get => GetProperty<TerraformProperty<double>>("fulfilled_on_demand_capacity");
        set => this.WithProperty("fulfilled_on_demand_capacity", value);
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
    /// The terminate_instances attribute.
    /// </summary>
    public TerraformProperty<bool>? TerminateInstances
    {
        get => GetProperty<TerraformProperty<bool>>("terminate_instances");
        set => this.WithProperty("terminate_instances", value);
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
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
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
    /// Block for fleet_instance_set.
    /// Nesting mode: list
    /// </summary>
    public List<AwsEc2FleetFleetInstanceSetBlock>? FleetInstanceSet
    {
        get => GetProperty<List<AwsEc2FleetFleetInstanceSetBlock>>("fleet_instance_set");
        set => this.WithProperty("fleet_instance_set", value);
    }

    /// <summary>
    /// Block for launch_template_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LaunchTemplateConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 LaunchTemplateConfig block(s) allowed")]
    public List<AwsEc2FleetLaunchTemplateConfigBlock>? LaunchTemplateConfig
    {
        get => GetProperty<List<AwsEc2FleetLaunchTemplateConfigBlock>>("launch_template_config");
        set => this.WithProperty("launch_template_config", value);
    }

    /// <summary>
    /// Block for on_demand_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnDemandOptions block(s) allowed")]
    public List<AwsEc2FleetOnDemandOptionsBlock>? OnDemandOptions
    {
        get => GetProperty<List<AwsEc2FleetOnDemandOptionsBlock>>("on_demand_options");
        set => this.WithProperty("on_demand_options", value);
    }

    /// <summary>
    /// Block for spot_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpotOptions block(s) allowed")]
    public List<AwsEc2FleetSpotOptionsBlock>? SpotOptions
    {
        get => GetProperty<List<AwsEc2FleetSpotOptionsBlock>>("spot_options");
        set => this.WithProperty("spot_options", value);
    }

    /// <summary>
    /// Block for target_capacity_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetCapacitySpecification block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetCapacitySpecification block(s) allowed")]
    public List<AwsEc2FleetTargetCapacitySpecificationBlock>? TargetCapacitySpecification
    {
        get => GetProperty<List<AwsEc2FleetTargetCapacitySpecificationBlock>>("target_capacity_specification");
        set => this.WithProperty("target_capacity_specification", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEc2FleetTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsEc2FleetTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
