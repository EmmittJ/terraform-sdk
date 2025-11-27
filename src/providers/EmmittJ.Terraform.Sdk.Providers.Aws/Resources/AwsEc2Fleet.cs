using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for fleet_instance_set in AwsEc2Fleet.
/// Nesting mode: list
/// </summary>
public class AwsEc2FleetFleetInstanceSetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fleet_instance_set";

    /// <summary>
    /// The instance_ids attribute.
    /// </summary>
    public TerraformList<string> InstanceIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "instance_ids").ResolveNodes(ctx));
        set => SetArgument("instance_ids", value);
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
    /// The lifecycle attribute.
    /// </summary>
    public TerraformValue<string> LifecycleAttribute
    {
        get => new TerraformReference<string>(this, "lifecycle");
        set => SetArgument("lifecycle", value);
    }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public TerraformValue<string> Platform
    {
        get => new TerraformReference<string>(this, "platform");
        set => SetArgument("platform", value);
    }

}


/// <summary>
/// Block type for launch_template_config in AwsEc2Fleet.
/// Nesting mode: list
/// </summary>
public class AwsEc2FleetLaunchTemplateConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "launch_template_config";

    /// <summary>
    /// LaunchTemplateSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchTemplateSpecification block(s) allowed")]
    public TerraformList<AwsEc2FleetLaunchTemplateConfigBlockLaunchTemplateSpecificationBlock>? LaunchTemplateSpecification
    {
        get => GetArgument<TerraformList<AwsEc2FleetLaunchTemplateConfigBlockLaunchTemplateSpecificationBlock>>("launch_template_specification");
        set => SetArgument("launch_template_specification", value);
    }

    /// <summary>
    /// OverrideAttribute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(300, ErrorMessage = "Maximum 300 OverrideAttribute block(s) allowed")]
    public TerraformList<AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlock>? OverrideAttribute
    {
        get => GetArgument<TerraformList<AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlock>>("override");
        set => SetArgument("override", value);
    }

}

/// <summary>
/// Block type for launch_template_specification in AwsEc2FleetLaunchTemplateConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsEc2FleetLaunchTemplateConfigBlockLaunchTemplateSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "launch_template_specification";

    /// <summary>
    /// The launch_template_id attribute.
    /// </summary>
    public TerraformValue<string>? LaunchTemplateId
    {
        get => new TerraformReference<string>(this, "launch_template_id");
        set => SetArgument("launch_template_id", value);
    }

    /// <summary>
    /// The launch_template_name attribute.
    /// </summary>
    public TerraformValue<string>? LaunchTemplateName
    {
        get => new TerraformReference<string>(this, "launch_template_name");
        set => SetArgument("launch_template_name", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for override in AwsEc2FleetLaunchTemplateConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "override";

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string>? AvailabilityZone
    {
        get => new TerraformReference<string>(this, "availability_zone");
        set => SetArgument("availability_zone", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string>? InstanceType
    {
        get => new TerraformReference<string>(this, "instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The max_price attribute.
    /// </summary>
    public TerraformValue<string>? MaxPrice
    {
        get => new TerraformReference<string>(this, "max_price");
        set => SetArgument("max_price", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformValue<double>? Priority
    {
        get => new TerraformReference<double>(this, "priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
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
    /// InstanceRequirements block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceRequirements block(s) allowed")]
    public TerraformList<AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlock>? InstanceRequirements
    {
        get => GetArgument<TerraformList<AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlock>>("instance_requirements");
        set => SetArgument("instance_requirements", value);
    }

}

/// <summary>
/// Block type for instance_requirements in AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlock.
/// Nesting mode: list
/// </summary>
public class AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "instance_requirements";

    /// <summary>
    /// The accelerator_manufacturers attribute.
    /// </summary>
    public TerraformSet<string>? AcceleratorManufacturers
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "accelerator_manufacturers").ResolveNodes(ctx));
        set => SetArgument("accelerator_manufacturers", value);
    }

    /// <summary>
    /// The accelerator_names attribute.
    /// </summary>
    public TerraformSet<string>? AcceleratorNames
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "accelerator_names").ResolveNodes(ctx));
        set => SetArgument("accelerator_names", value);
    }

    /// <summary>
    /// The accelerator_types attribute.
    /// </summary>
    public TerraformSet<string>? AcceleratorTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "accelerator_types").ResolveNodes(ctx));
        set => SetArgument("accelerator_types", value);
    }

    /// <summary>
    /// The allowed_instance_types attribute.
    /// </summary>
    public TerraformSet<string>? AllowedInstanceTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_instance_types").ResolveNodes(ctx));
        set => SetArgument("allowed_instance_types", value);
    }

    /// <summary>
    /// The bare_metal attribute.
    /// </summary>
    public TerraformValue<string>? BareMetal
    {
        get => new TerraformReference<string>(this, "bare_metal");
        set => SetArgument("bare_metal", value);
    }

    /// <summary>
    /// The burstable_performance attribute.
    /// </summary>
    public TerraformValue<string>? BurstablePerformance
    {
        get => new TerraformReference<string>(this, "burstable_performance");
        set => SetArgument("burstable_performance", value);
    }

    /// <summary>
    /// The cpu_manufacturers attribute.
    /// </summary>
    public TerraformSet<string>? CpuManufacturers
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "cpu_manufacturers").ResolveNodes(ctx));
        set => SetArgument("cpu_manufacturers", value);
    }

    /// <summary>
    /// The excluded_instance_types attribute.
    /// </summary>
    public TerraformSet<string>? ExcludedInstanceTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "excluded_instance_types").ResolveNodes(ctx));
        set => SetArgument("excluded_instance_types", value);
    }

    /// <summary>
    /// The instance_generations attribute.
    /// </summary>
    public TerraformSet<string>? InstanceGenerations
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "instance_generations").ResolveNodes(ctx));
        set => SetArgument("instance_generations", value);
    }

    /// <summary>
    /// The local_storage attribute.
    /// </summary>
    public TerraformValue<string>? LocalStorage
    {
        get => new TerraformReference<string>(this, "local_storage");
        set => SetArgument("local_storage", value);
    }

    /// <summary>
    /// The local_storage_types attribute.
    /// </summary>
    public TerraformSet<string>? LocalStorageTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "local_storage_types").ResolveNodes(ctx));
        set => SetArgument("local_storage_types", value);
    }

    /// <summary>
    /// The max_spot_price_as_percentage_of_optimal_on_demand_price attribute.
    /// </summary>
    public TerraformValue<double>? MaxSpotPriceAsPercentageOfOptimalOnDemandPrice
    {
        get => new TerraformReference<double>(this, "max_spot_price_as_percentage_of_optimal_on_demand_price");
        set => SetArgument("max_spot_price_as_percentage_of_optimal_on_demand_price", value);
    }

    /// <summary>
    /// The on_demand_max_price_percentage_over_lowest_price attribute.
    /// </summary>
    public TerraformValue<double>? OnDemandMaxPricePercentageOverLowestPrice
    {
        get => new TerraformReference<double>(this, "on_demand_max_price_percentage_over_lowest_price");
        set => SetArgument("on_demand_max_price_percentage_over_lowest_price", value);
    }

    /// <summary>
    /// The require_hibernate_support attribute.
    /// </summary>
    public TerraformValue<bool>? RequireHibernateSupport
    {
        get => new TerraformReference<bool>(this, "require_hibernate_support");
        set => SetArgument("require_hibernate_support", value);
    }

    /// <summary>
    /// The spot_max_price_percentage_over_lowest_price attribute.
    /// </summary>
    public TerraformValue<double>? SpotMaxPricePercentageOverLowestPrice
    {
        get => new TerraformReference<double>(this, "spot_max_price_percentage_over_lowest_price");
        set => SetArgument("spot_max_price_percentage_over_lowest_price", value);
    }

    /// <summary>
    /// AcceleratorCount block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AcceleratorCount block(s) allowed")]
    public TerraformList<AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlockAcceleratorCountBlock>? AcceleratorCount
    {
        get => GetArgument<TerraformList<AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlockAcceleratorCountBlock>>("accelerator_count");
        set => SetArgument("accelerator_count", value);
    }

    /// <summary>
    /// AcceleratorTotalMemoryMib block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AcceleratorTotalMemoryMib block(s) allowed")]
    public TerraformList<AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlockAcceleratorTotalMemoryMibBlock>? AcceleratorTotalMemoryMib
    {
        get => GetArgument<TerraformList<AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlockAcceleratorTotalMemoryMibBlock>>("accelerator_total_memory_mib");
        set => SetArgument("accelerator_total_memory_mib", value);
    }

    /// <summary>
    /// BaselineEbsBandwidthMbps block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BaselineEbsBandwidthMbps block(s) allowed")]
    public TerraformList<AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlockBaselineEbsBandwidthMbpsBlock>? BaselineEbsBandwidthMbps
    {
        get => GetArgument<TerraformList<AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlockBaselineEbsBandwidthMbpsBlock>>("baseline_ebs_bandwidth_mbps");
        set => SetArgument("baseline_ebs_bandwidth_mbps", value);
    }

    /// <summary>
    /// MemoryGibPerVcpu block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MemoryGibPerVcpu block(s) allowed")]
    public TerraformList<AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlockMemoryGibPerVcpuBlock>? MemoryGibPerVcpu
    {
        get => GetArgument<TerraformList<AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlockMemoryGibPerVcpuBlock>>("memory_gib_per_vcpu");
        set => SetArgument("memory_gib_per_vcpu", value);
    }

    /// <summary>
    /// MemoryMib block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemoryMib is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MemoryMib block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MemoryMib block(s) allowed")]
    public required TerraformList<AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlockMemoryMibBlock> MemoryMib
    {
        get => GetRequiredArgument<TerraformList<AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlockMemoryMibBlock>>("memory_mib");
        set => SetArgument("memory_mib", value);
    }

    /// <summary>
    /// NetworkBandwidthGbps block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkBandwidthGbps block(s) allowed")]
    public TerraformList<AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlockNetworkBandwidthGbpsBlock>? NetworkBandwidthGbps
    {
        get => GetArgument<TerraformList<AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlockNetworkBandwidthGbpsBlock>>("network_bandwidth_gbps");
        set => SetArgument("network_bandwidth_gbps", value);
    }

    /// <summary>
    /// NetworkInterfaceCount block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkInterfaceCount block(s) allowed")]
    public TerraformList<AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlockNetworkInterfaceCountBlock>? NetworkInterfaceCount
    {
        get => GetArgument<TerraformList<AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlockNetworkInterfaceCountBlock>>("network_interface_count");
        set => SetArgument("network_interface_count", value);
    }

    /// <summary>
    /// TotalLocalStorageGb block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TotalLocalStorageGb block(s) allowed")]
    public TerraformList<AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlockTotalLocalStorageGbBlock>? TotalLocalStorageGb
    {
        get => GetArgument<TerraformList<AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlockTotalLocalStorageGbBlock>>("total_local_storage_gb");
        set => SetArgument("total_local_storage_gb", value);
    }

    /// <summary>
    /// VcpuCount block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VcpuCount is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VcpuCount block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VcpuCount block(s) allowed")]
    public required TerraformList<AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlockVcpuCountBlock> VcpuCount
    {
        get => GetRequiredArgument<TerraformList<AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlockVcpuCountBlock>>("vcpu_count");
        set => SetArgument("vcpu_count", value);
    }

}

/// <summary>
/// Block type for accelerator_count in AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlockAcceleratorCountBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "accelerator_count";

    /// <summary>
    /// The max attribute.
    /// </summary>
    public TerraformValue<double>? Max
    {
        get => new TerraformReference<double>(this, "max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    public TerraformValue<double>? Min
    {
        get => new TerraformReference<double>(this, "min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for accelerator_total_memory_mib in AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlockAcceleratorTotalMemoryMibBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "accelerator_total_memory_mib";

    /// <summary>
    /// The max attribute.
    /// </summary>
    public TerraformValue<double>? Max
    {
        get => new TerraformReference<double>(this, "max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    public TerraformValue<double>? Min
    {
        get => new TerraformReference<double>(this, "min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for baseline_ebs_bandwidth_mbps in AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlockBaselineEbsBandwidthMbpsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "baseline_ebs_bandwidth_mbps";

    /// <summary>
    /// The max attribute.
    /// </summary>
    public TerraformValue<double>? Max
    {
        get => new TerraformReference<double>(this, "max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    public TerraformValue<double>? Min
    {
        get => new TerraformReference<double>(this, "min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for memory_gib_per_vcpu in AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlockMemoryGibPerVcpuBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "memory_gib_per_vcpu";

    /// <summary>
    /// The max attribute.
    /// </summary>
    public TerraformValue<double>? Max
    {
        get => new TerraformReference<double>(this, "max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    public TerraformValue<double>? Min
    {
        get => new TerraformReference<double>(this, "min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for memory_mib in AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlockMemoryMibBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "memory_mib";

    /// <summary>
    /// The max attribute.
    /// </summary>
    public TerraformValue<double>? Max
    {
        get => new TerraformReference<double>(this, "max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Min is required")]
    public required TerraformValue<double> Min
    {
        get => new TerraformReference<double>(this, "min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for network_bandwidth_gbps in AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlockNetworkBandwidthGbpsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_bandwidth_gbps";

    /// <summary>
    /// The max attribute.
    /// </summary>
    public TerraformValue<double>? Max
    {
        get => new TerraformReference<double>(this, "max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    public TerraformValue<double>? Min
    {
        get => new TerraformReference<double>(this, "min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for network_interface_count in AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlockNetworkInterfaceCountBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_interface_count";

    /// <summary>
    /// The max attribute.
    /// </summary>
    public TerraformValue<double>? Max
    {
        get => new TerraformReference<double>(this, "max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    public TerraformValue<double>? Min
    {
        get => new TerraformReference<double>(this, "min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for total_local_storage_gb in AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlockTotalLocalStorageGbBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "total_local_storage_gb";

    /// <summary>
    /// The max attribute.
    /// </summary>
    public TerraformValue<double>? Max
    {
        get => new TerraformReference<double>(this, "max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    public TerraformValue<double>? Min
    {
        get => new TerraformReference<double>(this, "min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for vcpu_count in AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsEc2FleetLaunchTemplateConfigBlockOverrideAttributeBlockInstanceRequirementsBlockVcpuCountBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vcpu_count";

    /// <summary>
    /// The max attribute.
    /// </summary>
    public TerraformValue<double>? Max
    {
        get => new TerraformReference<double>(this, "max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Min is required")]
    public required TerraformValue<double> Min
    {
        get => new TerraformReference<double>(this, "min");
        set => SetArgument("min", value);
    }

}


/// <summary>
/// Block type for on_demand_options in AwsEc2Fleet.
/// Nesting mode: list
/// </summary>
public class AwsEc2FleetOnDemandOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "on_demand_options";

    /// <summary>
    /// The allocation_strategy attribute.
    /// </summary>
    public TerraformValue<string>? AllocationStrategy
    {
        get => new TerraformReference<string>(this, "allocation_strategy");
        set => SetArgument("allocation_strategy", value);
    }

    /// <summary>
    /// The max_total_price attribute.
    /// </summary>
    public TerraformValue<string>? MaxTotalPrice
    {
        get => new TerraformReference<string>(this, "max_total_price");
        set => SetArgument("max_total_price", value);
    }

    /// <summary>
    /// The min_target_capacity attribute.
    /// </summary>
    public TerraformValue<double>? MinTargetCapacity
    {
        get => new TerraformReference<double>(this, "min_target_capacity");
        set => SetArgument("min_target_capacity", value);
    }

    /// <summary>
    /// The single_availability_zone attribute.
    /// </summary>
    public TerraformValue<bool>? SingleAvailabilityZone
    {
        get => new TerraformReference<bool>(this, "single_availability_zone");
        set => SetArgument("single_availability_zone", value);
    }

    /// <summary>
    /// The single_instance_type attribute.
    /// </summary>
    public TerraformValue<bool>? SingleInstanceType
    {
        get => new TerraformReference<bool>(this, "single_instance_type");
        set => SetArgument("single_instance_type", value);
    }

    /// <summary>
    /// CapacityReservationOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityReservationOptions block(s) allowed")]
    public TerraformList<AwsEc2FleetOnDemandOptionsBlockCapacityReservationOptionsBlock>? CapacityReservationOptions
    {
        get => GetArgument<TerraformList<AwsEc2FleetOnDemandOptionsBlockCapacityReservationOptionsBlock>>("capacity_reservation_options");
        set => SetArgument("capacity_reservation_options", value);
    }

}

/// <summary>
/// Block type for capacity_reservation_options in AwsEc2FleetOnDemandOptionsBlock.
/// Nesting mode: list
/// </summary>
public class AwsEc2FleetOnDemandOptionsBlockCapacityReservationOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "capacity_reservation_options";

    /// <summary>
    /// The usage_strategy attribute.
    /// </summary>
    public TerraformValue<string>? UsageStrategy
    {
        get => new TerraformReference<string>(this, "usage_strategy");
        set => SetArgument("usage_strategy", value);
    }

}


/// <summary>
/// Block type for spot_options in AwsEc2Fleet.
/// Nesting mode: list
/// </summary>
public class AwsEc2FleetSpotOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spot_options";

    /// <summary>
    /// The allocation_strategy attribute.
    /// </summary>
    public TerraformValue<string>? AllocationStrategy
    {
        get => new TerraformReference<string>(this, "allocation_strategy");
        set => SetArgument("allocation_strategy", value);
    }

    /// <summary>
    /// The instance_interruption_behavior attribute.
    /// </summary>
    public TerraformValue<string>? InstanceInterruptionBehavior
    {
        get => new TerraformReference<string>(this, "instance_interruption_behavior");
        set => SetArgument("instance_interruption_behavior", value);
    }

    /// <summary>
    /// The instance_pools_to_use_count attribute.
    /// </summary>
    public TerraformValue<double>? InstancePoolsToUseCount
    {
        get => new TerraformReference<double>(this, "instance_pools_to_use_count");
        set => SetArgument("instance_pools_to_use_count", value);
    }

    /// <summary>
    /// The max_total_price attribute.
    /// </summary>
    public TerraformValue<string>? MaxTotalPrice
    {
        get => new TerraformReference<string>(this, "max_total_price");
        set => SetArgument("max_total_price", value);
    }

    /// <summary>
    /// The min_target_capacity attribute.
    /// </summary>
    public TerraformValue<double>? MinTargetCapacity
    {
        get => new TerraformReference<double>(this, "min_target_capacity");
        set => SetArgument("min_target_capacity", value);
    }

    /// <summary>
    /// The single_availability_zone attribute.
    /// </summary>
    public TerraformValue<bool>? SingleAvailabilityZone
    {
        get => new TerraformReference<bool>(this, "single_availability_zone");
        set => SetArgument("single_availability_zone", value);
    }

    /// <summary>
    /// The single_instance_type attribute.
    /// </summary>
    public TerraformValue<bool>? SingleInstanceType
    {
        get => new TerraformReference<bool>(this, "single_instance_type");
        set => SetArgument("single_instance_type", value);
    }

    /// <summary>
    /// MaintenanceStrategies block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceStrategies block(s) allowed")]
    public TerraformList<AwsEc2FleetSpotOptionsBlockMaintenanceStrategiesBlock>? MaintenanceStrategies
    {
        get => GetArgument<TerraformList<AwsEc2FleetSpotOptionsBlockMaintenanceStrategiesBlock>>("maintenance_strategies");
        set => SetArgument("maintenance_strategies", value);
    }

}

/// <summary>
/// Block type for maintenance_strategies in AwsEc2FleetSpotOptionsBlock.
/// Nesting mode: list
/// </summary>
public class AwsEc2FleetSpotOptionsBlockMaintenanceStrategiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maintenance_strategies";

    /// <summary>
    /// CapacityRebalance block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityRebalance block(s) allowed")]
    public TerraformList<AwsEc2FleetSpotOptionsBlockMaintenanceStrategiesBlockCapacityRebalanceBlock>? CapacityRebalance
    {
        get => GetArgument<TerraformList<AwsEc2FleetSpotOptionsBlockMaintenanceStrategiesBlockCapacityRebalanceBlock>>("capacity_rebalance");
        set => SetArgument("capacity_rebalance", value);
    }

}

/// <summary>
/// Block type for capacity_rebalance in AwsEc2FleetSpotOptionsBlockMaintenanceStrategiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsEc2FleetSpotOptionsBlockMaintenanceStrategiesBlockCapacityRebalanceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "capacity_rebalance";

    /// <summary>
    /// The replacement_strategy attribute.
    /// </summary>
    public TerraformValue<string>? ReplacementStrategy
    {
        get => new TerraformReference<string>(this, "replacement_strategy");
        set => SetArgument("replacement_strategy", value);
    }

    /// <summary>
    /// The termination_delay attribute.
    /// </summary>
    public TerraformValue<double>? TerminationDelay
    {
        get => new TerraformReference<double>(this, "termination_delay");
        set => SetArgument("termination_delay", value);
    }

}


/// <summary>
/// Block type for target_capacity_specification in AwsEc2Fleet.
/// Nesting mode: list
/// </summary>
public class AwsEc2FleetTargetCapacitySpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_capacity_specification";

    /// <summary>
    /// The default_target_capacity_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultTargetCapacityType is required")]
    public required TerraformValue<string> DefaultTargetCapacityType
    {
        get => new TerraformReference<string>(this, "default_target_capacity_type");
        set => SetArgument("default_target_capacity_type", value);
    }

    /// <summary>
    /// The on_demand_target_capacity attribute.
    /// </summary>
    public TerraformValue<double>? OnDemandTargetCapacity
    {
        get => new TerraformReference<double>(this, "on_demand_target_capacity");
        set => SetArgument("on_demand_target_capacity", value);
    }

    /// <summary>
    /// The spot_target_capacity attribute.
    /// </summary>
    public TerraformValue<double>? SpotTargetCapacity
    {
        get => new TerraformReference<double>(this, "spot_target_capacity");
        set => SetArgument("spot_target_capacity", value);
    }

    /// <summary>
    /// The target_capacity_unit_type attribute.
    /// </summary>
    public TerraformValue<string>? TargetCapacityUnitType
    {
        get => new TerraformReference<string>(this, "target_capacity_unit_type");
        set => SetArgument("target_capacity_unit_type", value);
    }

    /// <summary>
    /// The total_target_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TotalTargetCapacity is required")]
    public required TerraformValue<double> TotalTargetCapacity
    {
        get => new TerraformReference<double>(this, "total_target_capacity");
        set => SetArgument("total_target_capacity", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsEc2Fleet.
/// Nesting mode: single
/// </summary>
public class AwsEc2FleetTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_ec2_fleet Terraform resource.
/// Manages a aws_ec2_fleet resource.
/// </summary>
public partial class AwsEc2Fleet(string name) : TerraformResource("aws_ec2_fleet", name)
{
    /// <summary>
    /// The context attribute.
    /// </summary>
    public TerraformValue<string>? Context
    {
        get => new TerraformReference<string>(this, "context");
        set => SetArgument("context", value);
    }

    /// <summary>
    /// The excess_capacity_termination_policy attribute.
    /// </summary>
    public TerraformValue<string>? ExcessCapacityTerminationPolicy
    {
        get => new TerraformReference<string>(this, "excess_capacity_termination_policy");
        set => SetArgument("excess_capacity_termination_policy", value);
    }

    /// <summary>
    /// The fleet_state attribute.
    /// </summary>
    public TerraformValue<string> FleetState
    {
        get => new TerraformReference<string>(this, "fleet_state");
        set => SetArgument("fleet_state", value);
    }

    /// <summary>
    /// The fulfilled_capacity attribute.
    /// </summary>
    public TerraformValue<double> FulfilledCapacity
    {
        get => new TerraformReference<double>(this, "fulfilled_capacity");
        set => SetArgument("fulfilled_capacity", value);
    }

    /// <summary>
    /// The fulfilled_on_demand_capacity attribute.
    /// </summary>
    public TerraformValue<double> FulfilledOnDemandCapacity
    {
        get => new TerraformReference<double>(this, "fulfilled_on_demand_capacity");
        set => SetArgument("fulfilled_on_demand_capacity", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The replace_unhealthy_instances attribute.
    /// </summary>
    public TerraformValue<bool>? ReplaceUnhealthyInstances
    {
        get => new TerraformReference<bool>(this, "replace_unhealthy_instances");
        set => SetArgument("replace_unhealthy_instances", value);
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
    /// The terminate_instances attribute.
    /// </summary>
    public TerraformValue<bool>? TerminateInstances
    {
        get => new TerraformReference<bool>(this, "terminate_instances");
        set => SetArgument("terminate_instances", value);
    }

    /// <summary>
    /// The terminate_instances_with_expiration attribute.
    /// </summary>
    public TerraformValue<bool>? TerminateInstancesWithExpiration
    {
        get => new TerraformReference<bool>(this, "terminate_instances_with_expiration");
        set => SetArgument("terminate_instances_with_expiration", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The valid_from attribute.
    /// </summary>
    public TerraformValue<string>? ValidFrom
    {
        get => new TerraformReference<string>(this, "valid_from");
        set => SetArgument("valid_from", value);
    }

    /// <summary>
    /// The valid_until attribute.
    /// </summary>
    public TerraformValue<string>? ValidUntil
    {
        get => new TerraformReference<string>(this, "valid_until");
        set => SetArgument("valid_until", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// FleetInstanceSet block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsEc2FleetFleetInstanceSetBlock>? FleetInstanceSet
    {
        get => GetArgument<TerraformList<AwsEc2FleetFleetInstanceSetBlock>>("fleet_instance_set");
        set => SetArgument("fleet_instance_set", value);
    }

    /// <summary>
    /// LaunchTemplateConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LaunchTemplateConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LaunchTemplateConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 LaunchTemplateConfig block(s) allowed")]
    public required TerraformList<AwsEc2FleetLaunchTemplateConfigBlock> LaunchTemplateConfig
    {
        get => GetRequiredArgument<TerraformList<AwsEc2FleetLaunchTemplateConfigBlock>>("launch_template_config");
        set => SetArgument("launch_template_config", value);
    }

    /// <summary>
    /// OnDemandOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnDemandOptions block(s) allowed")]
    public TerraformList<AwsEc2FleetOnDemandOptionsBlock>? OnDemandOptions
    {
        get => GetArgument<TerraformList<AwsEc2FleetOnDemandOptionsBlock>>("on_demand_options");
        set => SetArgument("on_demand_options", value);
    }

    /// <summary>
    /// SpotOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpotOptions block(s) allowed")]
    public TerraformList<AwsEc2FleetSpotOptionsBlock>? SpotOptions
    {
        get => GetArgument<TerraformList<AwsEc2FleetSpotOptionsBlock>>("spot_options");
        set => SetArgument("spot_options", value);
    }

    /// <summary>
    /// TargetCapacitySpecification block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetCapacitySpecification is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetCapacitySpecification block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetCapacitySpecification block(s) allowed")]
    public required TerraformList<AwsEc2FleetTargetCapacitySpecificationBlock> TargetCapacitySpecification
    {
        get => GetRequiredArgument<TerraformList<AwsEc2FleetTargetCapacitySpecificationBlock>>("target_capacity_specification");
        set => SetArgument("target_capacity_specification", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEc2FleetTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEc2FleetTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
