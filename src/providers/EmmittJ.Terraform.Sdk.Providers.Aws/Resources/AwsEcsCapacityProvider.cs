using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_scaling_group_provider in AwsEcsCapacityProvider.
/// Nesting mode: list
/// </summary>
public class AwsEcsCapacityProviderAutoScalingGroupProviderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto_scaling_group_provider";

    /// <summary>
    /// The auto_scaling_group_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoScalingGroupArn is required")]
    public required TerraformValue<string> AutoScalingGroupArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("auto_scaling_group_arn");
        set => SetArgument("auto_scaling_group_arn", value);
    }

    /// <summary>
    /// The managed_draining attribute.
    /// </summary>
    public TerraformValue<string> ManagedDraining
    {
        get => GetArgument<TerraformValue<string>>("managed_draining") ?? AsReference("managed_draining");
        set => SetArgument("managed_draining", value);
    }

    /// <summary>
    /// The managed_termination_protection attribute.
    /// </summary>
    public TerraformValue<string> ManagedTerminationProtection
    {
        get => GetArgument<TerraformValue<string>>("managed_termination_protection") ?? AsReference("managed_termination_protection");
        set => SetArgument("managed_termination_protection", value);
    }

    /// <summary>
    /// ManagedScaling block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedScaling block(s) allowed")]
    public TerraformList<AwsEcsCapacityProviderAutoScalingGroupProviderBlockManagedScalingBlock>? ManagedScaling
    {
        get => GetArgument<TerraformList<AwsEcsCapacityProviderAutoScalingGroupProviderBlockManagedScalingBlock>>("managed_scaling");
        set => SetArgument("managed_scaling", value);
    }

}

/// <summary>
/// Block type for managed_scaling in AwsEcsCapacityProviderAutoScalingGroupProviderBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcsCapacityProviderAutoScalingGroupProviderBlockManagedScalingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "managed_scaling";

    /// <summary>
    /// The instance_warmup_period attribute.
    /// </summary>
    public TerraformValue<double> InstanceWarmupPeriod
    {
        get => GetArgument<TerraformValue<double>>("instance_warmup_period") ?? AsReference("instance_warmup_period");
        set => SetArgument("instance_warmup_period", value);
    }

    /// <summary>
    /// The maximum_scaling_step_size attribute.
    /// </summary>
    public TerraformValue<double> MaximumScalingStepSize
    {
        get => GetArgument<TerraformValue<double>>("maximum_scaling_step_size") ?? AsReference("maximum_scaling_step_size");
        set => SetArgument("maximum_scaling_step_size", value);
    }

    /// <summary>
    /// The minimum_scaling_step_size attribute.
    /// </summary>
    public TerraformValue<double> MinimumScalingStepSize
    {
        get => GetArgument<TerraformValue<double>>("minimum_scaling_step_size") ?? AsReference("minimum_scaling_step_size");
        set => SetArgument("minimum_scaling_step_size", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => GetArgument<TerraformValue<string>>("status") ?? AsReference("status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The target_capacity attribute.
    /// </summary>
    public TerraformValue<double> TargetCapacity
    {
        get => GetArgument<TerraformValue<double>>("target_capacity") ?? AsReference("target_capacity");
        set => SetArgument("target_capacity", value);
    }

}


/// <summary>
/// Block type for managed_instances_provider in AwsEcsCapacityProvider.
/// Nesting mode: list
/// </summary>
public class AwsEcsCapacityProviderManagedInstancesProviderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "managed_instances_provider";

    /// <summary>
    /// The infrastructure_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InfrastructureRoleArn is required")]
    public required TerraformValue<string> InfrastructureRoleArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("infrastructure_role_arn");
        set => SetArgument("infrastructure_role_arn", value);
    }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    public TerraformValue<string>? PropagateTags
    {
        get => GetArgument<TerraformValue<string>>("propagate_tags");
        set => SetArgument("propagate_tags", value);
    }

    /// <summary>
    /// InstanceLaunchTemplate block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceLaunchTemplate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InstanceLaunchTemplate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceLaunchTemplate block(s) allowed")]
    public required TerraformList<AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlock> InstanceLaunchTemplate
    {
        get => GetRequiredArgument<TerraformList<AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlock>>("instance_launch_template");
        set => SetArgument("instance_launch_template", value);
    }

}

/// <summary>
/// Block type for instance_launch_template in AwsEcsCapacityProviderManagedInstancesProviderBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "instance_launch_template";

    /// <summary>
    /// The ec2_instance_profile_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ec2InstanceProfileArn is required")]
    public required TerraformValue<string> Ec2InstanceProfileArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("ec2_instance_profile_arn");
        set => SetArgument("ec2_instance_profile_arn", value);
    }

    /// <summary>
    /// The monitoring attribute.
    /// </summary>
    public TerraformValue<string>? Monitoring
    {
        get => GetArgument<TerraformValue<string>>("monitoring");
        set => SetArgument("monitoring", value);
    }

    /// <summary>
    /// InstanceRequirements block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceRequirements block(s) allowed")]
    public TerraformList<AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlock>? InstanceRequirements
    {
        get => GetArgument<TerraformList<AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlock>>("instance_requirements");
        set => SetArgument("instance_requirements", value);
    }

    /// <summary>
    /// NetworkConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    public required TerraformList<AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockNetworkConfigurationBlock> NetworkConfiguration
    {
        get => GetRequiredArgument<TerraformList<AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockNetworkConfigurationBlock>>("network_configuration");
        set => SetArgument("network_configuration", value);
    }

    /// <summary>
    /// StorageConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageConfiguration block(s) allowed")]
    public TerraformList<AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockStorageConfigurationBlock>? StorageConfiguration
    {
        get => GetArgument<TerraformList<AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockStorageConfigurationBlock>>("storage_configuration");
        set => SetArgument("storage_configuration", value);
    }

}

/// <summary>
/// Block type for instance_requirements in AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlock : TerraformBlock
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
        get => GetArgument<TerraformSet<string>>("accelerator_manufacturers");
        set => SetArgument("accelerator_manufacturers", value);
    }

    /// <summary>
    /// The accelerator_names attribute.
    /// </summary>
    public TerraformSet<string>? AcceleratorNames
    {
        get => GetArgument<TerraformSet<string>>("accelerator_names");
        set => SetArgument("accelerator_names", value);
    }

    /// <summary>
    /// The accelerator_types attribute.
    /// </summary>
    public TerraformSet<string>? AcceleratorTypes
    {
        get => GetArgument<TerraformSet<string>>("accelerator_types");
        set => SetArgument("accelerator_types", value);
    }

    /// <summary>
    /// The allowed_instance_types attribute.
    /// </summary>
    public TerraformSet<string>? AllowedInstanceTypes
    {
        get => GetArgument<TerraformSet<string>>("allowed_instance_types");
        set => SetArgument("allowed_instance_types", value);
    }

    /// <summary>
    /// The bare_metal attribute.
    /// </summary>
    public TerraformValue<string>? BareMetal
    {
        get => GetArgument<TerraformValue<string>>("bare_metal");
        set => SetArgument("bare_metal", value);
    }

    /// <summary>
    /// The burstable_performance attribute.
    /// </summary>
    public TerraformValue<string>? BurstablePerformance
    {
        get => GetArgument<TerraformValue<string>>("burstable_performance");
        set => SetArgument("burstable_performance", value);
    }

    /// <summary>
    /// The cpu_manufacturers attribute.
    /// </summary>
    public TerraformSet<string>? CpuManufacturers
    {
        get => GetArgument<TerraformSet<string>>("cpu_manufacturers");
        set => SetArgument("cpu_manufacturers", value);
    }

    /// <summary>
    /// The excluded_instance_types attribute.
    /// </summary>
    public TerraformSet<string>? ExcludedInstanceTypes
    {
        get => GetArgument<TerraformSet<string>>("excluded_instance_types");
        set => SetArgument("excluded_instance_types", value);
    }

    /// <summary>
    /// The instance_generations attribute.
    /// </summary>
    public TerraformSet<string>? InstanceGenerations
    {
        get => GetArgument<TerraformSet<string>>("instance_generations");
        set => SetArgument("instance_generations", value);
    }

    /// <summary>
    /// The local_storage attribute.
    /// </summary>
    public TerraformValue<string>? LocalStorage
    {
        get => GetArgument<TerraformValue<string>>("local_storage");
        set => SetArgument("local_storage", value);
    }

    /// <summary>
    /// The local_storage_types attribute.
    /// </summary>
    public TerraformSet<string>? LocalStorageTypes
    {
        get => GetArgument<TerraformSet<string>>("local_storage_types");
        set => SetArgument("local_storage_types", value);
    }

    /// <summary>
    /// The max_spot_price_as_percentage_of_optimal_on_demand_price attribute.
    /// </summary>
    public TerraformValue<double>? MaxSpotPriceAsPercentageOfOptimalOnDemandPrice
    {
        get => GetArgument<TerraformValue<double>>("max_spot_price_as_percentage_of_optimal_on_demand_price");
        set => SetArgument("max_spot_price_as_percentage_of_optimal_on_demand_price", value);
    }

    /// <summary>
    /// The on_demand_max_price_percentage_over_lowest_price attribute.
    /// </summary>
    public TerraformValue<double>? OnDemandMaxPricePercentageOverLowestPrice
    {
        get => GetArgument<TerraformValue<double>>("on_demand_max_price_percentage_over_lowest_price");
        set => SetArgument("on_demand_max_price_percentage_over_lowest_price", value);
    }

    /// <summary>
    /// The require_hibernate_support attribute.
    /// </summary>
    public TerraformValue<bool>? RequireHibernateSupport
    {
        get => GetArgument<TerraformValue<bool>>("require_hibernate_support");
        set => SetArgument("require_hibernate_support", value);
    }

    /// <summary>
    /// The spot_max_price_percentage_over_lowest_price attribute.
    /// </summary>
    public TerraformValue<double>? SpotMaxPricePercentageOverLowestPrice
    {
        get => GetArgument<TerraformValue<double>>("spot_max_price_percentage_over_lowest_price");
        set => SetArgument("spot_max_price_percentage_over_lowest_price", value);
    }

    /// <summary>
    /// AcceleratorCount block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AcceleratorCount block(s) allowed")]
    public TerraformList<AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlockAcceleratorCountBlock>? AcceleratorCount
    {
        get => GetArgument<TerraformList<AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlockAcceleratorCountBlock>>("accelerator_count");
        set => SetArgument("accelerator_count", value);
    }

    /// <summary>
    /// AcceleratorTotalMemoryMib block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AcceleratorTotalMemoryMib block(s) allowed")]
    public TerraformList<AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlockAcceleratorTotalMemoryMibBlock>? AcceleratorTotalMemoryMib
    {
        get => GetArgument<TerraformList<AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlockAcceleratorTotalMemoryMibBlock>>("accelerator_total_memory_mib");
        set => SetArgument("accelerator_total_memory_mib", value);
    }

    /// <summary>
    /// BaselineEbsBandwidthMbps block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BaselineEbsBandwidthMbps block(s) allowed")]
    public TerraformList<AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlockBaselineEbsBandwidthMbpsBlock>? BaselineEbsBandwidthMbps
    {
        get => GetArgument<TerraformList<AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlockBaselineEbsBandwidthMbpsBlock>>("baseline_ebs_bandwidth_mbps");
        set => SetArgument("baseline_ebs_bandwidth_mbps", value);
    }

    /// <summary>
    /// MemoryGibPerVcpu block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MemoryGibPerVcpu block(s) allowed")]
    public TerraformList<AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlockMemoryGibPerVcpuBlock>? MemoryGibPerVcpu
    {
        get => GetArgument<TerraformList<AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlockMemoryGibPerVcpuBlock>>("memory_gib_per_vcpu");
        set => SetArgument("memory_gib_per_vcpu", value);
    }

    /// <summary>
    /// MemoryMib block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemoryMib is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MemoryMib block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MemoryMib block(s) allowed")]
    public required TerraformList<AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlockMemoryMibBlock> MemoryMib
    {
        get => GetRequiredArgument<TerraformList<AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlockMemoryMibBlock>>("memory_mib");
        set => SetArgument("memory_mib", value);
    }

    /// <summary>
    /// NetworkBandwidthGbps block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkBandwidthGbps block(s) allowed")]
    public TerraformList<AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlockNetworkBandwidthGbpsBlock>? NetworkBandwidthGbps
    {
        get => GetArgument<TerraformList<AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlockNetworkBandwidthGbpsBlock>>("network_bandwidth_gbps");
        set => SetArgument("network_bandwidth_gbps", value);
    }

    /// <summary>
    /// NetworkInterfaceCount block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkInterfaceCount block(s) allowed")]
    public TerraformList<AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlockNetworkInterfaceCountBlock>? NetworkInterfaceCount
    {
        get => GetArgument<TerraformList<AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlockNetworkInterfaceCountBlock>>("network_interface_count");
        set => SetArgument("network_interface_count", value);
    }

    /// <summary>
    /// TotalLocalStorageGb block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TotalLocalStorageGb block(s) allowed")]
    public TerraformList<AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlockTotalLocalStorageGbBlock>? TotalLocalStorageGb
    {
        get => GetArgument<TerraformList<AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlockTotalLocalStorageGbBlock>>("total_local_storage_gb");
        set => SetArgument("total_local_storage_gb", value);
    }

    /// <summary>
    /// VcpuCount block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VcpuCount is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VcpuCount block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VcpuCount block(s) allowed")]
    public required TerraformList<AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlockVcpuCountBlock> VcpuCount
    {
        get => GetRequiredArgument<TerraformList<AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlockVcpuCountBlock>>("vcpu_count");
        set => SetArgument("vcpu_count", value);
    }

}

/// <summary>
/// Block type for accelerator_count in AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlockAcceleratorCountBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    public TerraformValue<double>? Min
    {
        get => GetArgument<TerraformValue<double>>("min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for accelerator_total_memory_mib in AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlockAcceleratorTotalMemoryMibBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    public TerraformValue<double>? Min
    {
        get => GetArgument<TerraformValue<double>>("min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for baseline_ebs_bandwidth_mbps in AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlockBaselineEbsBandwidthMbpsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    public TerraformValue<double>? Min
    {
        get => GetArgument<TerraformValue<double>>("min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for memory_gib_per_vcpu in AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlockMemoryGibPerVcpuBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    public TerraformValue<double>? Min
    {
        get => GetArgument<TerraformValue<double>>("min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for memory_mib in AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlockMemoryMibBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Min is required")]
    public required TerraformValue<double> Min
    {
        get => GetRequiredArgument<TerraformValue<double>>("min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for network_bandwidth_gbps in AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlockNetworkBandwidthGbpsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    public TerraformValue<double>? Min
    {
        get => GetArgument<TerraformValue<double>>("min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for network_interface_count in AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlockNetworkInterfaceCountBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    public TerraformValue<double>? Min
    {
        get => GetArgument<TerraformValue<double>>("min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for total_local_storage_gb in AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlockTotalLocalStorageGbBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    public TerraformValue<double>? Min
    {
        get => GetArgument<TerraformValue<double>>("min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for vcpu_count in AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockInstanceRequirementsBlockVcpuCountBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Min is required")]
    public required TerraformValue<double> Min
    {
        get => GetRequiredArgument<TerraformValue<double>>("min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for network_configuration in AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockNetworkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_configuration";

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformSet<string>? SecurityGroups
    {
        get => GetArgument<TerraformSet<string>>("security_groups");
        set => SetArgument("security_groups", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    public required TerraformSet<string> Subnets
    {
        get => GetRequiredArgument<TerraformSet<string>>("subnets");
        set => SetArgument("subnets", value);
    }

}

/// <summary>
/// Block type for storage_configuration in AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcsCapacityProviderManagedInstancesProviderBlockInstanceLaunchTemplateBlockStorageConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_configuration";

    /// <summary>
    /// The storage_size_gib attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageSizeGib is required")]
    public required TerraformValue<double> StorageSizeGib
    {
        get => GetRequiredArgument<TerraformValue<double>>("storage_size_gib");
        set => SetArgument("storage_size_gib", value);
    }

}


/// <summary>
/// Represents a aws_ecs_capacity_provider Terraform resource.
/// Manages a aws_ecs_capacity_provider resource.
/// </summary>
public partial class AwsEcsCapacityProvider(string name) : TerraformResource("aws_ecs_capacity_provider", name)
{
    /// <summary>
    /// The cluster attribute.
    /// </summary>
    public TerraformValue<string>? Cluster
    {
        get => GetArgument<TerraformValue<string>>("cluster");
        set => SetArgument("cluster", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// AutoScalingGroupProvider block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScalingGroupProvider block(s) allowed")]
    public TerraformList<AwsEcsCapacityProviderAutoScalingGroupProviderBlock>? AutoScalingGroupProvider
    {
        get => GetArgument<TerraformList<AwsEcsCapacityProviderAutoScalingGroupProviderBlock>>("auto_scaling_group_provider");
        set => SetArgument("auto_scaling_group_provider", value);
    }

    /// <summary>
    /// ManagedInstancesProvider block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedInstancesProvider block(s) allowed")]
    public TerraformList<AwsEcsCapacityProviderManagedInstancesProviderBlock>? ManagedInstancesProvider
    {
        get => GetArgument<TerraformList<AwsEcsCapacityProviderManagedInstancesProviderBlock>>("managed_instances_provider");
        set => SetArgument("managed_instances_provider", value);
    }

}
