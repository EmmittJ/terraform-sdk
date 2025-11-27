using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for instance_type_configs in AwsEmrInstanceFleet.
/// Nesting mode: set
/// </summary>
public class AwsEmrInstanceFleetInstanceTypeConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "instance_type_configs";

    /// <summary>
    /// The bid_price attribute.
    /// </summary>
    public TerraformValue<string>? BidPrice
    {
        get => new TerraformReference<string>(this, "bid_price");
        set => SetArgument("bid_price", value);
    }

    /// <summary>
    /// The bid_price_as_percentage_of_on_demand_price attribute.
    /// </summary>
    public TerraformValue<double>? BidPriceAsPercentageOfOnDemandPrice
    {
        get => new TerraformReference<double>(this, "bid_price_as_percentage_of_on_demand_price");
        set => SetArgument("bid_price_as_percentage_of_on_demand_price", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformValue<string> InstanceType
    {
        get => new TerraformReference<string>(this, "instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The weighted_capacity attribute.
    /// </summary>
    public TerraformValue<double>? WeightedCapacity
    {
        get => new TerraformReference<double>(this, "weighted_capacity");
        set => SetArgument("weighted_capacity", value);
    }

    /// <summary>
    /// Configurations block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEmrInstanceFleetInstanceTypeConfigsBlockConfigurationsBlock>? Configurations
    {
        get => GetArgument<TerraformSet<AwsEmrInstanceFleetInstanceTypeConfigsBlockConfigurationsBlock>>("configurations");
        set => SetArgument("configurations", value);
    }

    /// <summary>
    /// EbsConfig block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEmrInstanceFleetInstanceTypeConfigsBlockEbsConfigBlock>? EbsConfig
    {
        get => GetArgument<TerraformSet<AwsEmrInstanceFleetInstanceTypeConfigsBlockEbsConfigBlock>>("ebs_config");
        set => SetArgument("ebs_config", value);
    }

}

/// <summary>
/// Block type for configurations in AwsEmrInstanceFleetInstanceTypeConfigsBlock.
/// Nesting mode: set
/// </summary>
public class AwsEmrInstanceFleetInstanceTypeConfigsBlockConfigurationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "configurations";

    /// <summary>
    /// The classification attribute.
    /// </summary>
    public TerraformValue<string>? Classification
    {
        get => new TerraformReference<string>(this, "classification");
        set => SetArgument("classification", value);
    }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    public TerraformMap<string>? Properties
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "properties").ResolveNodes(ctx));
        set => SetArgument("properties", value);
    }

}

/// <summary>
/// Block type for ebs_config in AwsEmrInstanceFleetInstanceTypeConfigsBlock.
/// Nesting mode: set
/// </summary>
public class AwsEmrInstanceFleetInstanceTypeConfigsBlockEbsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ebs_config";

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformValue<double>? Iops
    {
        get => new TerraformReference<double>(this, "iops");
        set => SetArgument("iops", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    public required TerraformValue<double> Size
    {
        get => new TerraformReference<double>(this, "size");
        set => SetArgument("size", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The volumes_per_instance attribute.
    /// </summary>
    public TerraformValue<double>? VolumesPerInstance
    {
        get => new TerraformReference<double>(this, "volumes_per_instance");
        set => SetArgument("volumes_per_instance", value);
    }

}


/// <summary>
/// Block type for launch_specifications in AwsEmrInstanceFleet.
/// Nesting mode: list
/// </summary>
public class AwsEmrInstanceFleetLaunchSpecificationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "launch_specifications";

    /// <summary>
    /// OnDemandSpecification block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsEmrInstanceFleetLaunchSpecificationsBlockOnDemandSpecificationBlock>? OnDemandSpecification
    {
        get => GetArgument<TerraformList<AwsEmrInstanceFleetLaunchSpecificationsBlockOnDemandSpecificationBlock>>("on_demand_specification");
        set => SetArgument("on_demand_specification", value);
    }

    /// <summary>
    /// SpotSpecification block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsEmrInstanceFleetLaunchSpecificationsBlockSpotSpecificationBlock>? SpotSpecification
    {
        get => GetArgument<TerraformList<AwsEmrInstanceFleetLaunchSpecificationsBlockSpotSpecificationBlock>>("spot_specification");
        set => SetArgument("spot_specification", value);
    }

}

/// <summary>
/// Block type for on_demand_specification in AwsEmrInstanceFleetLaunchSpecificationsBlock.
/// Nesting mode: list
/// </summary>
public class AwsEmrInstanceFleetLaunchSpecificationsBlockOnDemandSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "on_demand_specification";

    /// <summary>
    /// The allocation_strategy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllocationStrategy is required")]
    public required TerraformValue<string> AllocationStrategy
    {
        get => new TerraformReference<string>(this, "allocation_strategy");
        set => SetArgument("allocation_strategy", value);
    }

}

/// <summary>
/// Block type for spot_specification in AwsEmrInstanceFleetLaunchSpecificationsBlock.
/// Nesting mode: list
/// </summary>
public class AwsEmrInstanceFleetLaunchSpecificationsBlockSpotSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spot_specification";

    /// <summary>
    /// The allocation_strategy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllocationStrategy is required")]
    public required TerraformValue<string> AllocationStrategy
    {
        get => new TerraformReference<string>(this, "allocation_strategy");
        set => SetArgument("allocation_strategy", value);
    }

    /// <summary>
    /// The block_duration_minutes attribute.
    /// </summary>
    public TerraformValue<double>? BlockDurationMinutes
    {
        get => new TerraformReference<double>(this, "block_duration_minutes");
        set => SetArgument("block_duration_minutes", value);
    }

    /// <summary>
    /// The timeout_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeoutAction is required")]
    public required TerraformValue<string> TimeoutAction
    {
        get => new TerraformReference<string>(this, "timeout_action");
        set => SetArgument("timeout_action", value);
    }

    /// <summary>
    /// The timeout_duration_minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeoutDurationMinutes is required")]
    public required TerraformValue<double> TimeoutDurationMinutes
    {
        get => new TerraformReference<double>(this, "timeout_duration_minutes");
        set => SetArgument("timeout_duration_minutes", value);
    }

}


/// <summary>
/// Represents a aws_emr_instance_fleet Terraform resource.
/// Manages a aws_emr_instance_fleet resource.
/// </summary>
public partial class AwsEmrInstanceFleet(string name) : TerraformResource("aws_emr_instance_fleet", name)
{
    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformValue<string> ClusterId
    {
        get => new TerraformReference<string>(this, "cluster_id");
        set => SetArgument("cluster_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The target_on_demand_capacity attribute.
    /// </summary>
    public TerraformValue<double>? TargetOnDemandCapacity
    {
        get => new TerraformReference<double>(this, "target_on_demand_capacity");
        set => SetArgument("target_on_demand_capacity", value);
    }

    /// <summary>
    /// The target_spot_capacity attribute.
    /// </summary>
    public TerraformValue<double>? TargetSpotCapacity
    {
        get => new TerraformReference<double>(this, "target_spot_capacity");
        set => SetArgument("target_spot_capacity", value);
    }

    /// <summary>
    /// The provisioned_on_demand_capacity attribute.
    /// </summary>
    public TerraformValue<double> ProvisionedOnDemandCapacity
    {
        get => new TerraformReference<double>(this, "provisioned_on_demand_capacity");
    }

    /// <summary>
    /// The provisioned_spot_capacity attribute.
    /// </summary>
    public TerraformValue<double> ProvisionedSpotCapacity
    {
        get => new TerraformReference<double>(this, "provisioned_spot_capacity");
    }

    /// <summary>
    /// InstanceTypeConfigs block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEmrInstanceFleetInstanceTypeConfigsBlock>? InstanceTypeConfigs
    {
        get => GetArgument<TerraformSet<AwsEmrInstanceFleetInstanceTypeConfigsBlock>>("instance_type_configs");
        set => SetArgument("instance_type_configs", value);
    }

    /// <summary>
    /// LaunchSpecifications block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchSpecifications block(s) allowed")]
    public TerraformList<AwsEmrInstanceFleetLaunchSpecificationsBlock>? LaunchSpecifications
    {
        get => GetArgument<TerraformList<AwsEmrInstanceFleetLaunchSpecificationsBlock>>("launch_specifications");
        set => SetArgument("launch_specifications", value);
    }

}
