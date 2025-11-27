using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for compute_configuration in AwsCodebuildFleet.
/// Nesting mode: list
/// </summary>
public class AwsCodebuildFleetComputeConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "compute_configuration";

    /// <summary>
    /// The disk attribute.
    /// </summary>
    public TerraformValue<double> Disk
    {
        get => new TerraformReference<double>(this, "disk");
        set => SetArgument("disk", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string> InstanceType
    {
        get => new TerraformReference<string>(this, "instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The machine_type attribute.
    /// </summary>
    public TerraformValue<string> MachineType
    {
        get => new TerraformReference<string>(this, "machine_type");
        set => SetArgument("machine_type", value);
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    public TerraformValue<double> Memory
    {
        get => new TerraformReference<double>(this, "memory");
        set => SetArgument("memory", value);
    }

    /// <summary>
    /// The vcpu attribute.
    /// </summary>
    public TerraformValue<double> Vcpu
    {
        get => new TerraformReference<double>(this, "vcpu");
        set => SetArgument("vcpu", value);
    }

}


/// <summary>
/// Block type for scaling_configuration in AwsCodebuildFleet.
/// Nesting mode: list
/// </summary>
public class AwsCodebuildFleetScalingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scaling_configuration";

    /// <summary>
    /// The desired_capacity attribute.
    /// </summary>
    public TerraformValue<double> DesiredCapacity
    {
        get => new TerraformReference<double>(this, "desired_capacity");
    }

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    public TerraformValue<double>? MaxCapacity
    {
        get => new TerraformReference<double>(this, "max_capacity");
        set => SetArgument("max_capacity", value);
    }

    /// <summary>
    /// The scaling_type attribute.
    /// </summary>
    public TerraformValue<string>? ScalingType
    {
        get => new TerraformReference<string>(this, "scaling_type");
        set => SetArgument("scaling_type", value);
    }

    /// <summary>
    /// TargetTrackingScalingConfigs block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCodebuildFleetScalingConfigurationBlockTargetTrackingScalingConfigsBlock>? TargetTrackingScalingConfigs
    {
        get => GetArgument<TerraformList<AwsCodebuildFleetScalingConfigurationBlockTargetTrackingScalingConfigsBlock>>("target_tracking_scaling_configs");
        set => SetArgument("target_tracking_scaling_configs", value);
    }

}

/// <summary>
/// Block type for target_tracking_scaling_configs in AwsCodebuildFleetScalingConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodebuildFleetScalingConfigurationBlockTargetTrackingScalingConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_tracking_scaling_configs";

    /// <summary>
    /// The metric_type attribute.
    /// </summary>
    public TerraformValue<string>? MetricType
    {
        get => new TerraformReference<string>(this, "metric_type");
        set => SetArgument("metric_type", value);
    }

    /// <summary>
    /// The target_value attribute.
    /// </summary>
    public TerraformValue<double>? TargetValue
    {
        get => new TerraformReference<double>(this, "target_value");
        set => SetArgument("target_value", value);
    }

}


/// <summary>
/// Block type for vpc_config in AwsCodebuildFleet.
/// Nesting mode: list
/// </summary>
public class AwsCodebuildFleetVpcConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_config";

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    public required TerraformSet<string> SecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_group_ids").ResolveNodes(ctx));
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    public required TerraformSet<string> Subnets
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnets").ResolveNodes(ctx));
        set => SetArgument("subnets", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformValue<string> VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
        set => SetArgument("vpc_id", value);
    }

}


/// <summary>
/// Represents a aws_codebuild_fleet Terraform resource.
/// Manages a aws_codebuild_fleet resource.
/// </summary>
public partial class AwsCodebuildFleet(string name) : TerraformResource("aws_codebuild_fleet", name)
{
    /// <summary>
    /// The base_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseCapacity is required")]
    public required TerraformValue<double> BaseCapacity
    {
        get => new TerraformReference<double>(this, "base_capacity");
        set => SetArgument("base_capacity", value);
    }

    /// <summary>
    /// The compute_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeType is required")]
    public required TerraformValue<string> ComputeType
    {
        get => new TerraformReference<string>(this, "compute_type");
        set => SetArgument("compute_type", value);
    }

    /// <summary>
    /// The environment_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvironmentType is required")]
    public required TerraformValue<string> EnvironmentType
    {
        get => new TerraformReference<string>(this, "environment_type");
        set => SetArgument("environment_type", value);
    }

    /// <summary>
    /// The fleet_service_role attribute.
    /// </summary>
    public TerraformValue<string>? FleetServiceRole
    {
        get => new TerraformReference<string>(this, "fleet_service_role");
        set => SetArgument("fleet_service_role", value);
    }

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    public TerraformValue<string>? ImageId
    {
        get => new TerraformReference<string>(this, "image_id");
        set => SetArgument("image_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The overflow_behavior attribute.
    /// </summary>
    public TerraformValue<string> OverflowBehavior
    {
        get => new TerraformReference<string>(this, "overflow_behavior");
        set => SetArgument("overflow_behavior", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The created attribute.
    /// </summary>
    public TerraformValue<string> Created
    {
        get => new TerraformReference<string>(this, "created");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    public TerraformValue<string> LastModified
    {
        get => new TerraformReference<string>(this, "last_modified");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Status
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "status").ResolveNodes(ctx));
    }

    /// <summary>
    /// ComputeConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComputeConfiguration block(s) allowed")]
    public TerraformList<AwsCodebuildFleetComputeConfigurationBlock>? ComputeConfiguration
    {
        get => GetArgument<TerraformList<AwsCodebuildFleetComputeConfigurationBlock>>("compute_configuration");
        set => SetArgument("compute_configuration", value);
    }

    /// <summary>
    /// ScalingConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingConfiguration block(s) allowed")]
    public TerraformList<AwsCodebuildFleetScalingConfigurationBlock>? ScalingConfiguration
    {
        get => GetArgument<TerraformList<AwsCodebuildFleetScalingConfigurationBlock>>("scaling_configuration");
        set => SetArgument("scaling_configuration", value);
    }

    /// <summary>
    /// VpcConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCodebuildFleetVpcConfigBlock>? VpcConfig
    {
        get => GetArgument<TerraformList<AwsCodebuildFleetVpcConfigBlock>>("vpc_config");
        set => SetArgument("vpc_config", value);
    }

}
