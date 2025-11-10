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
        set => SetProperty("instance_ids", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceType
    {
        set => SetProperty("instance_type", value);
    }

    /// <summary>
    /// The lifecycle attribute.
    /// </summary>
    public TerraformProperty<string>? Lifecycle
    {
        set => SetProperty("lifecycle", value);
    }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public TerraformProperty<string>? Platform
    {
        set => SetProperty("platform", value);
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
        set => SetProperty("allocation_strategy", value);
    }

    /// <summary>
    /// The max_total_price attribute.
    /// </summary>
    public TerraformProperty<string>? MaxTotalPrice
    {
        set => SetProperty("max_total_price", value);
    }

    /// <summary>
    /// The min_target_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? MinTargetCapacity
    {
        set => SetProperty("min_target_capacity", value);
    }

    /// <summary>
    /// The single_availability_zone attribute.
    /// </summary>
    public TerraformProperty<bool>? SingleAvailabilityZone
    {
        set => SetProperty("single_availability_zone", value);
    }

    /// <summary>
    /// The single_instance_type attribute.
    /// </summary>
    public TerraformProperty<bool>? SingleInstanceType
    {
        set => SetProperty("single_instance_type", value);
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
        set => SetProperty("allocation_strategy", value);
    }

    /// <summary>
    /// The instance_interruption_behavior attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceInterruptionBehavior
    {
        set => SetProperty("instance_interruption_behavior", value);
    }

    /// <summary>
    /// The instance_pools_to_use_count attribute.
    /// </summary>
    public TerraformProperty<double>? InstancePoolsToUseCount
    {
        set => SetProperty("instance_pools_to_use_count", value);
    }

    /// <summary>
    /// The max_total_price attribute.
    /// </summary>
    public TerraformProperty<string>? MaxTotalPrice
    {
        set => SetProperty("max_total_price", value);
    }

    /// <summary>
    /// The min_target_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? MinTargetCapacity
    {
        set => SetProperty("min_target_capacity", value);
    }

    /// <summary>
    /// The single_availability_zone attribute.
    /// </summary>
    public TerraformProperty<bool>? SingleAvailabilityZone
    {
        set => SetProperty("single_availability_zone", value);
    }

    /// <summary>
    /// The single_instance_type attribute.
    /// </summary>
    public TerraformProperty<bool>? SingleInstanceType
    {
        set => SetProperty("single_instance_type", value);
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
        set => SetProperty("default_target_capacity_type", value);
    }

    /// <summary>
    /// The on_demand_target_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? OnDemandTargetCapacity
    {
        set => SetProperty("on_demand_target_capacity", value);
    }

    /// <summary>
    /// The spot_target_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? SpotTargetCapacity
    {
        set => SetProperty("spot_target_capacity", value);
    }

    /// <summary>
    /// The target_capacity_unit_type attribute.
    /// </summary>
    public TerraformProperty<string>? TargetCapacityUnitType
    {
        set => SetProperty("target_capacity_unit_type", value);
    }

    /// <summary>
    /// The total_target_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TotalTargetCapacity is required")]
    public required TerraformProperty<double> TotalTargetCapacity
    {
        set => SetProperty("total_target_capacity", value);
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
        SetOutput("arn");
        SetOutput("context");
        SetOutput("excess_capacity_termination_policy");
        SetOutput("fleet_state");
        SetOutput("fulfilled_capacity");
        SetOutput("fulfilled_on_demand_capacity");
        SetOutput("id");
        SetOutput("region");
        SetOutput("replace_unhealthy_instances");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("terminate_instances");
        SetOutput("terminate_instances_with_expiration");
        SetOutput("type");
        SetOutput("valid_from");
        SetOutput("valid_until");
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
    /// The fleet_state attribute.
    /// </summary>
    public TerraformProperty<string> FleetState
    {
        get => GetRequiredOutput<TerraformProperty<string>>("fleet_state");
        set => SetProperty("fleet_state", value);
    }

    /// <summary>
    /// The fulfilled_capacity attribute.
    /// </summary>
    public TerraformProperty<double> FulfilledCapacity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("fulfilled_capacity");
        set => SetProperty("fulfilled_capacity", value);
    }

    /// <summary>
    /// The fulfilled_on_demand_capacity attribute.
    /// </summary>
    public TerraformProperty<double> FulfilledOnDemandCapacity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("fulfilled_on_demand_capacity");
        set => SetProperty("fulfilled_on_demand_capacity", value);
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
    /// The terminate_instances attribute.
    /// </summary>
    public TerraformProperty<bool> TerminateInstances
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("terminate_instances");
        set => SetProperty("terminate_instances", value);
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
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
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
    /// Block for fleet_instance_set.
    /// Nesting mode: list
    /// </summary>
    public List<AwsEc2FleetFleetInstanceSetBlock>? FleetInstanceSet
    {
        set => SetProperty("fleet_instance_set", value);
    }

    /// <summary>
    /// Block for launch_template_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LaunchTemplateConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LaunchTemplateConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 LaunchTemplateConfig block(s) allowed")]
    public List<AwsEc2FleetLaunchTemplateConfigBlock>? LaunchTemplateConfig
    {
        set => SetProperty("launch_template_config", value);
    }

    /// <summary>
    /// Block for on_demand_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnDemandOptions block(s) allowed")]
    public List<AwsEc2FleetOnDemandOptionsBlock>? OnDemandOptions
    {
        set => SetProperty("on_demand_options", value);
    }

    /// <summary>
    /// Block for spot_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpotOptions block(s) allowed")]
    public List<AwsEc2FleetSpotOptionsBlock>? SpotOptions
    {
        set => SetProperty("spot_options", value);
    }

    /// <summary>
    /// Block for target_capacity_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetCapacitySpecification is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetCapacitySpecification block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetCapacitySpecification block(s) allowed")]
    public List<AwsEc2FleetTargetCapacitySpecificationBlock>? TargetCapacitySpecification
    {
        set => SetProperty("target_capacity_specification", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEc2FleetTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
