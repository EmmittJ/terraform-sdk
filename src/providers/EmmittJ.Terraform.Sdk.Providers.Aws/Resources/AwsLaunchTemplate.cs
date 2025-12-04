using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for block_device_mappings in AwsLaunchTemplate.
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateBlockDeviceMappingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "block_device_mappings";

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    public TerraformValue<string>? DeviceName
    {
        get => GetArgument<TerraformValue<string>>("device_name");
        set => SetArgument("device_name", value);
    }

    /// <summary>
    /// The no_device attribute.
    /// </summary>
    public TerraformValue<string>? NoDevice
    {
        get => GetArgument<TerraformValue<string>>("no_device");
        set => SetArgument("no_device", value);
    }

    /// <summary>
    /// The virtual_name attribute.
    /// </summary>
    public TerraformValue<string>? VirtualName
    {
        get => GetArgument<TerraformValue<string>>("virtual_name");
        set => SetArgument("virtual_name", value);
    }

    /// <summary>
    /// Ebs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ebs block(s) allowed")]
    public TerraformList<AwsLaunchTemplateBlockDeviceMappingsBlockEbsBlock>? Ebs
    {
        get => GetArgument<TerraformList<AwsLaunchTemplateBlockDeviceMappingsBlockEbsBlock>>("ebs");
        set => SetArgument("ebs", value);
    }

}

/// <summary>
/// Block type for ebs in AwsLaunchTemplateBlockDeviceMappingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateBlockDeviceMappingsBlockEbsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ebs";

    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    public TerraformValue<string>? DeleteOnTermination
    {
        get => GetArgument<TerraformValue<string>>("delete_on_termination");
        set => SetArgument("delete_on_termination", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformValue<string>? Encrypted
    {
        get => GetArgument<TerraformValue<string>>("encrypted");
        set => SetArgument("encrypted", value);
    }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformValue<double>? Iops
    {
        get => GetArgument<TerraformValue<double>>("iops");
        set => SetArgument("iops", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    public TerraformValue<string>? SnapshotId
    {
        get => GetArgument<TerraformValue<string>>("snapshot_id");
        set => SetArgument("snapshot_id", value);
    }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    public TerraformValue<double>? Throughput
    {
        get => GetArgument<TerraformValue<double>>("throughput");
        set => SetArgument("throughput", value);
    }

    /// <summary>
    /// The volume_initialization_rate attribute.
    /// </summary>
    public TerraformValue<double>? VolumeInitializationRate
    {
        get => GetArgument<TerraformValue<double>>("volume_initialization_rate");
        set => SetArgument("volume_initialization_rate", value);
    }

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    public TerraformValue<double>? VolumeSize
    {
        get => GetArgument<TerraformValue<double>>("volume_size");
        set => SetArgument("volume_size", value);
    }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    public TerraformValue<string>? VolumeType
    {
        get => GetArgument<TerraformValue<string>>("volume_type");
        set => SetArgument("volume_type", value);
    }

}


/// <summary>
/// Block type for capacity_reservation_specification in AwsLaunchTemplate.
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateCapacityReservationSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "capacity_reservation_specification";

    /// <summary>
    /// The capacity_reservation_preference attribute.
    /// </summary>
    public TerraformValue<string>? CapacityReservationPreference
    {
        get => GetArgument<TerraformValue<string>>("capacity_reservation_preference");
        set => SetArgument("capacity_reservation_preference", value);
    }

    /// <summary>
    /// CapacityReservationTarget block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityReservationTarget block(s) allowed")]
    public TerraformList<AwsLaunchTemplateCapacityReservationSpecificationBlockCapacityReservationTargetBlock>? CapacityReservationTarget
    {
        get => GetArgument<TerraformList<AwsLaunchTemplateCapacityReservationSpecificationBlockCapacityReservationTargetBlock>>("capacity_reservation_target");
        set => SetArgument("capacity_reservation_target", value);
    }

}

/// <summary>
/// Block type for capacity_reservation_target in AwsLaunchTemplateCapacityReservationSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateCapacityReservationSpecificationBlockCapacityReservationTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "capacity_reservation_target";

    /// <summary>
    /// The capacity_reservation_id attribute.
    /// </summary>
    public TerraformValue<string>? CapacityReservationId
    {
        get => GetArgument<TerraformValue<string>>("capacity_reservation_id");
        set => SetArgument("capacity_reservation_id", value);
    }

    /// <summary>
    /// The capacity_reservation_resource_group_arn attribute.
    /// </summary>
    public TerraformValue<string>? CapacityReservationResourceGroupArn
    {
        get => GetArgument<TerraformValue<string>>("capacity_reservation_resource_group_arn");
        set => SetArgument("capacity_reservation_resource_group_arn", value);
    }

}


/// <summary>
/// Block type for cpu_options in AwsLaunchTemplate.
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateCpuOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cpu_options";

    /// <summary>
    /// The amd_sev_snp attribute.
    /// </summary>
    public TerraformValue<string>? AmdSevSnp
    {
        get => GetArgument<TerraformValue<string>>("amd_sev_snp");
        set => SetArgument("amd_sev_snp", value);
    }

    /// <summary>
    /// The core_count attribute.
    /// </summary>
    public TerraformValue<double>? CoreCount
    {
        get => GetArgument<TerraformValue<double>>("core_count");
        set => SetArgument("core_count", value);
    }

    /// <summary>
    /// The threads_per_core attribute.
    /// </summary>
    public TerraformValue<double>? ThreadsPerCore
    {
        get => GetArgument<TerraformValue<double>>("threads_per_core");
        set => SetArgument("threads_per_core", value);
    }

}


/// <summary>
/// Block type for credit_specification in AwsLaunchTemplate.
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateCreditSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "credit_specification";

    /// <summary>
    /// The cpu_credits attribute.
    /// </summary>
    public TerraformValue<string>? CpuCredits
    {
        get => GetArgument<TerraformValue<string>>("cpu_credits");
        set => SetArgument("cpu_credits", value);
    }

}


/// <summary>
/// Block type for enclave_options in AwsLaunchTemplate.
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateEnclaveOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "enclave_options";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for hibernation_options in AwsLaunchTemplate.
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateHibernationOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hibernation_options";

    /// <summary>
    /// The configured attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Configured is required")]
    public required TerraformValue<bool> Configured
    {
        get => GetArgument<TerraformValue<bool>>("configured");
        set => SetArgument("configured", value);
    }

}


/// <summary>
/// Block type for iam_instance_profile in AwsLaunchTemplate.
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateIamInstanceProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "iam_instance_profile";

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string>? Arn
    {
        get => GetArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for instance_market_options in AwsLaunchTemplate.
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateInstanceMarketOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "instance_market_options";

    /// <summary>
    /// The market_type attribute.
    /// </summary>
    public TerraformValue<string>? MarketType
    {
        get => GetArgument<TerraformValue<string>>("market_type");
        set => SetArgument("market_type", value);
    }

    /// <summary>
    /// SpotOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpotOptions block(s) allowed")]
    public TerraformList<AwsLaunchTemplateInstanceMarketOptionsBlockSpotOptionsBlock>? SpotOptions
    {
        get => GetArgument<TerraformList<AwsLaunchTemplateInstanceMarketOptionsBlockSpotOptionsBlock>>("spot_options");
        set => SetArgument("spot_options", value);
    }

}

/// <summary>
/// Block type for spot_options in AwsLaunchTemplateInstanceMarketOptionsBlock.
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateInstanceMarketOptionsBlockSpotOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spot_options";

    /// <summary>
    /// The block_duration_minutes attribute.
    /// </summary>
    public TerraformValue<double>? BlockDurationMinutes
    {
        get => GetArgument<TerraformValue<double>>("block_duration_minutes");
        set => SetArgument("block_duration_minutes", value);
    }

    /// <summary>
    /// The instance_interruption_behavior attribute.
    /// </summary>
    public TerraformValue<string>? InstanceInterruptionBehavior
    {
        get => GetArgument<TerraformValue<string>>("instance_interruption_behavior");
        set => SetArgument("instance_interruption_behavior", value);
    }

    /// <summary>
    /// The max_price attribute.
    /// </summary>
    public TerraformValue<string>? MaxPrice
    {
        get => GetArgument<TerraformValue<string>>("max_price");
        set => SetArgument("max_price", value);
    }

    /// <summary>
    /// The spot_instance_type attribute.
    /// </summary>
    public TerraformValue<string>? SpotInstanceType
    {
        get => GetArgument<TerraformValue<string>>("spot_instance_type");
        set => SetArgument("spot_instance_type", value);
    }

    /// <summary>
    /// The valid_until attribute.
    /// </summary>
    public TerraformValue<string>? ValidUntil
    {
        get => GetArgument<TerraformValue<string>>("valid_until");
        set => SetArgument("valid_until", value);
    }

}


/// <summary>
/// Block type for instance_requirements in AwsLaunchTemplate.
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateInstanceRequirementsBlock : TerraformBlock
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
    public TerraformList<AwsLaunchTemplateInstanceRequirementsBlockAcceleratorCountBlock>? AcceleratorCount
    {
        get => GetArgument<TerraformList<AwsLaunchTemplateInstanceRequirementsBlockAcceleratorCountBlock>>("accelerator_count");
        set => SetArgument("accelerator_count", value);
    }

    /// <summary>
    /// AcceleratorTotalMemoryMib block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AcceleratorTotalMemoryMib block(s) allowed")]
    public TerraformList<AwsLaunchTemplateInstanceRequirementsBlockAcceleratorTotalMemoryMibBlock>? AcceleratorTotalMemoryMib
    {
        get => GetArgument<TerraformList<AwsLaunchTemplateInstanceRequirementsBlockAcceleratorTotalMemoryMibBlock>>("accelerator_total_memory_mib");
        set => SetArgument("accelerator_total_memory_mib", value);
    }

    /// <summary>
    /// BaselineEbsBandwidthMbps block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BaselineEbsBandwidthMbps block(s) allowed")]
    public TerraformList<AwsLaunchTemplateInstanceRequirementsBlockBaselineEbsBandwidthMbpsBlock>? BaselineEbsBandwidthMbps
    {
        get => GetArgument<TerraformList<AwsLaunchTemplateInstanceRequirementsBlockBaselineEbsBandwidthMbpsBlock>>("baseline_ebs_bandwidth_mbps");
        set => SetArgument("baseline_ebs_bandwidth_mbps", value);
    }

    /// <summary>
    /// MemoryGibPerVcpu block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MemoryGibPerVcpu block(s) allowed")]
    public TerraformList<AwsLaunchTemplateInstanceRequirementsBlockMemoryGibPerVcpuBlock>? MemoryGibPerVcpu
    {
        get => GetArgument<TerraformList<AwsLaunchTemplateInstanceRequirementsBlockMemoryGibPerVcpuBlock>>("memory_gib_per_vcpu");
        set => SetArgument("memory_gib_per_vcpu", value);
    }

    /// <summary>
    /// MemoryMib block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemoryMib is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MemoryMib block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MemoryMib block(s) allowed")]
    public required TerraformList<AwsLaunchTemplateInstanceRequirementsBlockMemoryMibBlock> MemoryMib
    {
        get => GetRequiredArgument<TerraformList<AwsLaunchTemplateInstanceRequirementsBlockMemoryMibBlock>>("memory_mib");
        set => SetArgument("memory_mib", value);
    }

    /// <summary>
    /// NetworkBandwidthGbps block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkBandwidthGbps block(s) allowed")]
    public TerraformList<AwsLaunchTemplateInstanceRequirementsBlockNetworkBandwidthGbpsBlock>? NetworkBandwidthGbps
    {
        get => GetArgument<TerraformList<AwsLaunchTemplateInstanceRequirementsBlockNetworkBandwidthGbpsBlock>>("network_bandwidth_gbps");
        set => SetArgument("network_bandwidth_gbps", value);
    }

    /// <summary>
    /// NetworkInterfaceCount block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkInterfaceCount block(s) allowed")]
    public TerraformList<AwsLaunchTemplateInstanceRequirementsBlockNetworkInterfaceCountBlock>? NetworkInterfaceCount
    {
        get => GetArgument<TerraformList<AwsLaunchTemplateInstanceRequirementsBlockNetworkInterfaceCountBlock>>("network_interface_count");
        set => SetArgument("network_interface_count", value);
    }

    /// <summary>
    /// TotalLocalStorageGb block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TotalLocalStorageGb block(s) allowed")]
    public TerraformList<AwsLaunchTemplateInstanceRequirementsBlockTotalLocalStorageGbBlock>? TotalLocalStorageGb
    {
        get => GetArgument<TerraformList<AwsLaunchTemplateInstanceRequirementsBlockTotalLocalStorageGbBlock>>("total_local_storage_gb");
        set => SetArgument("total_local_storage_gb", value);
    }

    /// <summary>
    /// VcpuCount block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VcpuCount is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VcpuCount block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VcpuCount block(s) allowed")]
    public required TerraformList<AwsLaunchTemplateInstanceRequirementsBlockVcpuCountBlock> VcpuCount
    {
        get => GetRequiredArgument<TerraformList<AwsLaunchTemplateInstanceRequirementsBlockVcpuCountBlock>>("vcpu_count");
        set => SetArgument("vcpu_count", value);
    }

}

/// <summary>
/// Block type for accelerator_count in AwsLaunchTemplateInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateInstanceRequirementsBlockAcceleratorCountBlock : TerraformBlock
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
/// Block type for accelerator_total_memory_mib in AwsLaunchTemplateInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateInstanceRequirementsBlockAcceleratorTotalMemoryMibBlock : TerraformBlock
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
/// Block type for baseline_ebs_bandwidth_mbps in AwsLaunchTemplateInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateInstanceRequirementsBlockBaselineEbsBandwidthMbpsBlock : TerraformBlock
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
/// Block type for memory_gib_per_vcpu in AwsLaunchTemplateInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateInstanceRequirementsBlockMemoryGibPerVcpuBlock : TerraformBlock
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
/// Block type for memory_mib in AwsLaunchTemplateInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateInstanceRequirementsBlockMemoryMibBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for network_bandwidth_gbps in AwsLaunchTemplateInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateInstanceRequirementsBlockNetworkBandwidthGbpsBlock : TerraformBlock
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
/// Block type for network_interface_count in AwsLaunchTemplateInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateInstanceRequirementsBlockNetworkInterfaceCountBlock : TerraformBlock
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
/// Block type for total_local_storage_gb in AwsLaunchTemplateInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateInstanceRequirementsBlockTotalLocalStorageGbBlock : TerraformBlock
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
/// Block type for vcpu_count in AwsLaunchTemplateInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateInstanceRequirementsBlockVcpuCountBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("min");
        set => SetArgument("min", value);
    }

}


/// <summary>
/// Block type for license_specification in AwsLaunchTemplate.
/// Nesting mode: set
/// </summary>
public class AwsLaunchTemplateLicenseSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "license_specification";

    /// <summary>
    /// The license_configuration_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseConfigurationArn is required")]
    public required TerraformValue<string> LicenseConfigurationArn
    {
        get => GetArgument<TerraformValue<string>>("license_configuration_arn");
        set => SetArgument("license_configuration_arn", value);
    }

}


/// <summary>
/// Block type for maintenance_options in AwsLaunchTemplate.
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateMaintenanceOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maintenance_options";

    /// <summary>
    /// The auto_recovery attribute.
    /// </summary>
    public TerraformValue<string>? AutoRecovery
    {
        get => GetArgument<TerraformValue<string>>("auto_recovery");
        set => SetArgument("auto_recovery", value);
    }

}


/// <summary>
/// Block type for metadata_options in AwsLaunchTemplate.
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateMetadataOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metadata_options";

    /// <summary>
    /// The http_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? HttpEndpoint
    {
        get => GetArgument<TerraformValue<string>>("http_endpoint");
        set => SetArgument("http_endpoint", value);
    }

    /// <summary>
    /// The http_protocol_ipv6 attribute.
    /// </summary>
    public TerraformValue<string>? HttpProtocolIpv6
    {
        get => GetArgument<TerraformValue<string>>("http_protocol_ipv6");
        set => SetArgument("http_protocol_ipv6", value);
    }

    /// <summary>
    /// The http_put_response_hop_limit attribute.
    /// </summary>
    public TerraformValue<double>? HttpPutResponseHopLimit
    {
        get => GetArgument<TerraformValue<double>>("http_put_response_hop_limit");
        set => SetArgument("http_put_response_hop_limit", value);
    }

    /// <summary>
    /// The http_tokens attribute.
    /// </summary>
    public TerraformValue<string>? HttpTokens
    {
        get => GetArgument<TerraformValue<string>>("http_tokens");
        set => SetArgument("http_tokens", value);
    }

    /// <summary>
    /// The instance_metadata_tags attribute.
    /// </summary>
    public TerraformValue<string>? InstanceMetadataTags
    {
        get => GetArgument<TerraformValue<string>>("instance_metadata_tags");
        set => SetArgument("instance_metadata_tags", value);
    }

}


/// <summary>
/// Block type for monitoring in AwsLaunchTemplate.
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateMonitoringBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "monitoring";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for network_interfaces in AwsLaunchTemplate.
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateNetworkInterfacesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_interfaces";

    /// <summary>
    /// The associate_carrier_ip_address attribute.
    /// </summary>
    public TerraformValue<string>? AssociateCarrierIpAddress
    {
        get => GetArgument<TerraformValue<string>>("associate_carrier_ip_address");
        set => SetArgument("associate_carrier_ip_address", value);
    }

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    public TerraformValue<string>? AssociatePublicIpAddress
    {
        get => GetArgument<TerraformValue<string>>("associate_public_ip_address");
        set => SetArgument("associate_public_ip_address", value);
    }

    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    public TerraformValue<string>? DeleteOnTermination
    {
        get => GetArgument<TerraformValue<string>>("delete_on_termination");
        set => SetArgument("delete_on_termination", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The device_index attribute.
    /// </summary>
    public TerraformValue<double>? DeviceIndex
    {
        get => GetArgument<TerraformValue<double>>("device_index");
        set => SetArgument("device_index", value);
    }

    /// <summary>
    /// The interface_type attribute.
    /// </summary>
    public TerraformValue<string>? InterfaceType
    {
        get => GetArgument<TerraformValue<string>>("interface_type");
        set => SetArgument("interface_type", value);
    }

    /// <summary>
    /// The ipv4_address_count attribute.
    /// </summary>
    public TerraformValue<double>? Ipv4AddressCount
    {
        get => GetArgument<TerraformValue<double>>("ipv4_address_count");
        set => SetArgument("ipv4_address_count", value);
    }

    /// <summary>
    /// The ipv4_addresses attribute.
    /// </summary>
    public TerraformSet<string>? Ipv4Addresses
    {
        get => GetArgument<TerraformSet<string>>("ipv4_addresses");
        set => SetArgument("ipv4_addresses", value);
    }

    /// <summary>
    /// The ipv4_prefix_count attribute.
    /// </summary>
    public TerraformValue<double>? Ipv4PrefixCount
    {
        get => GetArgument<TerraformValue<double>>("ipv4_prefix_count");
        set => SetArgument("ipv4_prefix_count", value);
    }

    /// <summary>
    /// The ipv4_prefixes attribute.
    /// </summary>
    public TerraformSet<string>? Ipv4Prefixes
    {
        get => GetArgument<TerraformSet<string>>("ipv4_prefixes");
        set => SetArgument("ipv4_prefixes", value);
    }

    /// <summary>
    /// The ipv6_address_count attribute.
    /// </summary>
    public TerraformValue<double>? Ipv6AddressCount
    {
        get => GetArgument<TerraformValue<double>>("ipv6_address_count");
        set => SetArgument("ipv6_address_count", value);
    }

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    public TerraformSet<string>? Ipv6Addresses
    {
        get => GetArgument<TerraformSet<string>>("ipv6_addresses");
        set => SetArgument("ipv6_addresses", value);
    }

    /// <summary>
    /// The ipv6_prefix_count attribute.
    /// </summary>
    public TerraformValue<double>? Ipv6PrefixCount
    {
        get => GetArgument<TerraformValue<double>>("ipv6_prefix_count");
        set => SetArgument("ipv6_prefix_count", value);
    }

    /// <summary>
    /// The ipv6_prefixes attribute.
    /// </summary>
    public TerraformSet<string>? Ipv6Prefixes
    {
        get => GetArgument<TerraformSet<string>>("ipv6_prefixes");
        set => SetArgument("ipv6_prefixes", value);
    }

    /// <summary>
    /// The network_card_index attribute.
    /// </summary>
    public TerraformValue<double>? NetworkCardIndex
    {
        get => GetArgument<TerraformValue<double>>("network_card_index");
        set => SetArgument("network_card_index", value);
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformValue<string>? NetworkInterfaceId
    {
        get => GetArgument<TerraformValue<string>>("network_interface_id");
        set => SetArgument("network_interface_id", value);
    }

    /// <summary>
    /// The primary_ipv6 attribute.
    /// </summary>
    public TerraformValue<string>? PrimaryIpv6
    {
        get => GetArgument<TerraformValue<string>>("primary_ipv6");
        set => SetArgument("primary_ipv6", value);
    }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    public TerraformValue<string>? PrivateIpAddress
    {
        get => GetArgument<TerraformValue<string>>("private_ip_address");
        set => SetArgument("private_ip_address", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformSet<string>? SecurityGroups
    {
        get => GetArgument<TerraformSet<string>>("security_groups");
        set => SetArgument("security_groups", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? SubnetId
    {
        get => GetArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// ConnectionTrackingSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectionTrackingSpecification block(s) allowed")]
    public TerraformList<AwsLaunchTemplateNetworkInterfacesBlockConnectionTrackingSpecificationBlock>? ConnectionTrackingSpecification
    {
        get => GetArgument<TerraformList<AwsLaunchTemplateNetworkInterfacesBlockConnectionTrackingSpecificationBlock>>("connection_tracking_specification");
        set => SetArgument("connection_tracking_specification", value);
    }

    /// <summary>
    /// EnaSrdSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnaSrdSpecification block(s) allowed")]
    public TerraformList<AwsLaunchTemplateNetworkInterfacesBlockEnaSrdSpecificationBlock>? EnaSrdSpecification
    {
        get => GetArgument<TerraformList<AwsLaunchTemplateNetworkInterfacesBlockEnaSrdSpecificationBlock>>("ena_srd_specification");
        set => SetArgument("ena_srd_specification", value);
    }

}

/// <summary>
/// Block type for connection_tracking_specification in AwsLaunchTemplateNetworkInterfacesBlock.
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateNetworkInterfacesBlockConnectionTrackingSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "connection_tracking_specification";

    /// <summary>
    /// The tcp_established_timeout attribute.
    /// </summary>
    public TerraformValue<double>? TcpEstablishedTimeout
    {
        get => GetArgument<TerraformValue<double>>("tcp_established_timeout");
        set => SetArgument("tcp_established_timeout", value);
    }

    /// <summary>
    /// The udp_stream_timeout attribute.
    /// </summary>
    public TerraformValue<double>? UdpStreamTimeout
    {
        get => GetArgument<TerraformValue<double>>("udp_stream_timeout");
        set => SetArgument("udp_stream_timeout", value);
    }

    /// <summary>
    /// The udp_timeout attribute.
    /// </summary>
    public TerraformValue<double>? UdpTimeout
    {
        get => GetArgument<TerraformValue<double>>("udp_timeout");
        set => SetArgument("udp_timeout", value);
    }

}

/// <summary>
/// Block type for ena_srd_specification in AwsLaunchTemplateNetworkInterfacesBlock.
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateNetworkInterfacesBlockEnaSrdSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ena_srd_specification";

    /// <summary>
    /// The ena_srd_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? EnaSrdEnabled
    {
        get => GetArgument<TerraformValue<bool>>("ena_srd_enabled");
        set => SetArgument("ena_srd_enabled", value);
    }

    /// <summary>
    /// EnaSrdUdpSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnaSrdUdpSpecification block(s) allowed")]
    public TerraformList<AwsLaunchTemplateNetworkInterfacesBlockEnaSrdSpecificationBlockEnaSrdUdpSpecificationBlock>? EnaSrdUdpSpecification
    {
        get => GetArgument<TerraformList<AwsLaunchTemplateNetworkInterfacesBlockEnaSrdSpecificationBlockEnaSrdUdpSpecificationBlock>>("ena_srd_udp_specification");
        set => SetArgument("ena_srd_udp_specification", value);
    }

}

/// <summary>
/// Block type for ena_srd_udp_specification in AwsLaunchTemplateNetworkInterfacesBlockEnaSrdSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateNetworkInterfacesBlockEnaSrdSpecificationBlockEnaSrdUdpSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ena_srd_udp_specification";

    /// <summary>
    /// The ena_srd_udp_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? EnaSrdUdpEnabled
    {
        get => GetArgument<TerraformValue<bool>>("ena_srd_udp_enabled");
        set => SetArgument("ena_srd_udp_enabled", value);
    }

}


/// <summary>
/// Block type for placement in AwsLaunchTemplate.
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplatePlacementBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "placement";

    /// <summary>
    /// The affinity attribute.
    /// </summary>
    public TerraformValue<string>? Affinity
    {
        get => GetArgument<TerraformValue<string>>("affinity");
        set => SetArgument("affinity", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string>? AvailabilityZone
    {
        get => GetArgument<TerraformValue<string>>("availability_zone");
        set => SetArgument("availability_zone", value);
    }

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    public TerraformValue<string>? GroupId
    {
        get => GetArgument<TerraformValue<string>>("group_id");
        set => SetArgument("group_id", value);
    }

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    public TerraformValue<string>? GroupName
    {
        get => GetArgument<TerraformValue<string>>("group_name");
        set => SetArgument("group_name", value);
    }

    /// <summary>
    /// The host_id attribute.
    /// </summary>
    public TerraformValue<string>? HostId
    {
        get => GetArgument<TerraformValue<string>>("host_id");
        set => SetArgument("host_id", value);
    }

    /// <summary>
    /// The host_resource_group_arn attribute.
    /// </summary>
    public TerraformValue<string>? HostResourceGroupArn
    {
        get => GetArgument<TerraformValue<string>>("host_resource_group_arn");
        set => SetArgument("host_resource_group_arn", value);
    }

    /// <summary>
    /// The partition_number attribute.
    /// </summary>
    public TerraformValue<double>? PartitionNumber
    {
        get => GetArgument<TerraformValue<double>>("partition_number");
        set => SetArgument("partition_number", value);
    }

    /// <summary>
    /// The spread_domain attribute.
    /// </summary>
    public TerraformValue<string>? SpreadDomain
    {
        get => GetArgument<TerraformValue<string>>("spread_domain");
        set => SetArgument("spread_domain", value);
    }

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    public TerraformValue<string>? Tenancy
    {
        get => GetArgument<TerraformValue<string>>("tenancy");
        set => SetArgument("tenancy", value);
    }

}


/// <summary>
/// Block type for private_dns_name_options in AwsLaunchTemplate.
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplatePrivateDnsNameOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "private_dns_name_options";

    /// <summary>
    /// The enable_resource_name_dns_a_record attribute.
    /// </summary>
    public TerraformValue<bool>? EnableResourceNameDnsARecord
    {
        get => GetArgument<TerraformValue<bool>>("enable_resource_name_dns_a_record");
        set => SetArgument("enable_resource_name_dns_a_record", value);
    }

    /// <summary>
    /// The enable_resource_name_dns_aaaa_record attribute.
    /// </summary>
    public TerraformValue<bool>? EnableResourceNameDnsAaaaRecord
    {
        get => GetArgument<TerraformValue<bool>>("enable_resource_name_dns_aaaa_record");
        set => SetArgument("enable_resource_name_dns_aaaa_record", value);
    }

    /// <summary>
    /// The hostname_type attribute.
    /// </summary>
    public TerraformValue<string>? HostnameType
    {
        get => GetArgument<TerraformValue<string>>("hostname_type");
        set => SetArgument("hostname_type", value);
    }

}


/// <summary>
/// Block type for tag_specifications in AwsLaunchTemplate.
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateTagSpecificationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tag_specifications";

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformValue<string>? ResourceTypeAttribute
    {
        get => GetArgument<TerraformValue<string>>("resource_type");
        set => SetArgument("resource_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

}


/// <summary>
/// Represents a aws_launch_template Terraform resource.
/// Manages a aws_launch_template resource.
/// </summary>
public partial class AwsLaunchTemplate(string name) : TerraformResource("aws_launch_template", name)
{
    /// <summary>
    /// The default_version attribute.
    /// </summary>
    public TerraformValue<double>? DefaultVersion
    {
        get => GetArgument<TerraformValue<double>>("default_version");
        set => SetArgument("default_version", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The disable_api_stop attribute.
    /// </summary>
    public TerraformValue<bool>? DisableApiStop
    {
        get => GetArgument<TerraformValue<bool>>("disable_api_stop");
        set => SetArgument("disable_api_stop", value);
    }

    /// <summary>
    /// The disable_api_termination attribute.
    /// </summary>
    public TerraformValue<bool>? DisableApiTermination
    {
        get => GetArgument<TerraformValue<bool>>("disable_api_termination");
        set => SetArgument("disable_api_termination", value);
    }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    public TerraformValue<string>? EbsOptimized
    {
        get => GetArgument<TerraformValue<string>>("ebs_optimized");
        set => SetArgument("ebs_optimized", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    public TerraformValue<string>? ImageId
    {
        get => GetArgument<TerraformValue<string>>("image_id");
        set => SetArgument("image_id", value);
    }

    /// <summary>
    /// The instance_initiated_shutdown_behavior attribute.
    /// </summary>
    public TerraformValue<string>? InstanceInitiatedShutdownBehavior
    {
        get => GetArgument<TerraformValue<string>>("instance_initiated_shutdown_behavior");
        set => SetArgument("instance_initiated_shutdown_behavior", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string>? InstanceType
    {
        get => GetArgument<TerraformValue<string>>("instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The kernel_id attribute.
    /// </summary>
    public TerraformValue<string>? KernelId
    {
        get => GetArgument<TerraformValue<string>>("kernel_id");
        set => SetArgument("kernel_id", value);
    }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    public TerraformValue<string>? KeyName
    {
        get => GetArgument<TerraformValue<string>>("key_name");
        set => SetArgument("key_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string>? NamePrefix
    {
        get => GetArgument<TerraformValue<string>>("name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The ram_disk_id attribute.
    /// </summary>
    public TerraformValue<string>? RamDiskId
    {
        get => GetArgument<TerraformValue<string>>("ram_disk_id");
        set => SetArgument("ram_disk_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The security_group_names attribute.
    /// </summary>
    public TerraformSet<string>? SecurityGroupNames
    {
        get => GetArgument<TerraformSet<string>>("security_group_names");
        set => SetArgument("security_group_names", value);
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
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The update_default_version attribute.
    /// </summary>
    public TerraformValue<bool>? UpdateDefaultVersion
    {
        get => GetArgument<TerraformValue<bool>>("update_default_version");
        set => SetArgument("update_default_version", value);
    }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    public TerraformValue<string>? UserData
    {
        get => GetArgument<TerraformValue<string>>("user_data");
        set => SetArgument("user_data", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string>? VpcSecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("vpc_security_group_ids");
        set => SetArgument("vpc_security_group_ids", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The latest_version attribute.
    /// </summary>
    public TerraformValue<double> LatestVersion
        => AsReference("latest_version");

    /// <summary>
    /// BlockDeviceMappings block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLaunchTemplateBlockDeviceMappingsBlock>? BlockDeviceMappings
    {
        get => GetArgument<TerraformList<AwsLaunchTemplateBlockDeviceMappingsBlock>>("block_device_mappings");
        set => SetArgument("block_device_mappings", value);
    }

    /// <summary>
    /// CapacityReservationSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityReservationSpecification block(s) allowed")]
    public TerraformList<AwsLaunchTemplateCapacityReservationSpecificationBlock>? CapacityReservationSpecification
    {
        get => GetArgument<TerraformList<AwsLaunchTemplateCapacityReservationSpecificationBlock>>("capacity_reservation_specification");
        set => SetArgument("capacity_reservation_specification", value);
    }

    /// <summary>
    /// CpuOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CpuOptions block(s) allowed")]
    public TerraformList<AwsLaunchTemplateCpuOptionsBlock>? CpuOptions
    {
        get => GetArgument<TerraformList<AwsLaunchTemplateCpuOptionsBlock>>("cpu_options");
        set => SetArgument("cpu_options", value);
    }

    /// <summary>
    /// CreditSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CreditSpecification block(s) allowed")]
    public TerraformList<AwsLaunchTemplateCreditSpecificationBlock>? CreditSpecification
    {
        get => GetArgument<TerraformList<AwsLaunchTemplateCreditSpecificationBlock>>("credit_specification");
        set => SetArgument("credit_specification", value);
    }

    /// <summary>
    /// EnclaveOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnclaveOptions block(s) allowed")]
    public TerraformList<AwsLaunchTemplateEnclaveOptionsBlock>? EnclaveOptions
    {
        get => GetArgument<TerraformList<AwsLaunchTemplateEnclaveOptionsBlock>>("enclave_options");
        set => SetArgument("enclave_options", value);
    }

    /// <summary>
    /// HibernationOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HibernationOptions block(s) allowed")]
    public TerraformList<AwsLaunchTemplateHibernationOptionsBlock>? HibernationOptions
    {
        get => GetArgument<TerraformList<AwsLaunchTemplateHibernationOptionsBlock>>("hibernation_options");
        set => SetArgument("hibernation_options", value);
    }

    /// <summary>
    /// IamInstanceProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IamInstanceProfile block(s) allowed")]
    public TerraformList<AwsLaunchTemplateIamInstanceProfileBlock>? IamInstanceProfile
    {
        get => GetArgument<TerraformList<AwsLaunchTemplateIamInstanceProfileBlock>>("iam_instance_profile");
        set => SetArgument("iam_instance_profile", value);
    }

    /// <summary>
    /// InstanceMarketOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceMarketOptions block(s) allowed")]
    public TerraformList<AwsLaunchTemplateInstanceMarketOptionsBlock>? InstanceMarketOptions
    {
        get => GetArgument<TerraformList<AwsLaunchTemplateInstanceMarketOptionsBlock>>("instance_market_options");
        set => SetArgument("instance_market_options", value);
    }

    /// <summary>
    /// InstanceRequirements block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceRequirements block(s) allowed")]
    public TerraformList<AwsLaunchTemplateInstanceRequirementsBlock>? InstanceRequirements
    {
        get => GetArgument<TerraformList<AwsLaunchTemplateInstanceRequirementsBlock>>("instance_requirements");
        set => SetArgument("instance_requirements", value);
    }

    /// <summary>
    /// LicenseSpecification block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsLaunchTemplateLicenseSpecificationBlock>? LicenseSpecification
    {
        get => GetArgument<TerraformSet<AwsLaunchTemplateLicenseSpecificationBlock>>("license_specification");
        set => SetArgument("license_specification", value);
    }

    /// <summary>
    /// MaintenanceOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceOptions block(s) allowed")]
    public TerraformList<AwsLaunchTemplateMaintenanceOptionsBlock>? MaintenanceOptions
    {
        get => GetArgument<TerraformList<AwsLaunchTemplateMaintenanceOptionsBlock>>("maintenance_options");
        set => SetArgument("maintenance_options", value);
    }

    /// <summary>
    /// MetadataOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetadataOptions block(s) allowed")]
    public TerraformList<AwsLaunchTemplateMetadataOptionsBlock>? MetadataOptions
    {
        get => GetArgument<TerraformList<AwsLaunchTemplateMetadataOptionsBlock>>("metadata_options");
        set => SetArgument("metadata_options", value);
    }

    /// <summary>
    /// Monitoring block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Monitoring block(s) allowed")]
    public TerraformList<AwsLaunchTemplateMonitoringBlock>? Monitoring
    {
        get => GetArgument<TerraformList<AwsLaunchTemplateMonitoringBlock>>("monitoring");
        set => SetArgument("monitoring", value);
    }

    /// <summary>
    /// NetworkInterfaces block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLaunchTemplateNetworkInterfacesBlock>? NetworkInterfaces
    {
        get => GetArgument<TerraformList<AwsLaunchTemplateNetworkInterfacesBlock>>("network_interfaces");
        set => SetArgument("network_interfaces", value);
    }

    /// <summary>
    /// Placement block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Placement block(s) allowed")]
    public TerraformList<AwsLaunchTemplatePlacementBlock>? Placement
    {
        get => GetArgument<TerraformList<AwsLaunchTemplatePlacementBlock>>("placement");
        set => SetArgument("placement", value);
    }

    /// <summary>
    /// PrivateDnsNameOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateDnsNameOptions block(s) allowed")]
    public TerraformList<AwsLaunchTemplatePrivateDnsNameOptionsBlock>? PrivateDnsNameOptions
    {
        get => GetArgument<TerraformList<AwsLaunchTemplatePrivateDnsNameOptionsBlock>>("private_dns_name_options");
        set => SetArgument("private_dns_name_options", value);
    }

    /// <summary>
    /// TagSpecifications block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLaunchTemplateTagSpecificationsBlock>? TagSpecifications
    {
        get => GetArgument<TerraformList<AwsLaunchTemplateTagSpecificationsBlock>>("tag_specifications");
        set => SetArgument("tag_specifications", value);
    }

}
