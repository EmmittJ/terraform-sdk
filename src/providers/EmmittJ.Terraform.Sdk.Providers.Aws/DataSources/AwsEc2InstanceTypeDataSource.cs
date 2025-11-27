using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsEc2InstanceTypeDataSource.
/// Nesting mode: single
/// </summary>
public class AwsEc2InstanceTypeDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a aws_ec2_instance_type Terraform data source.
/// Retrieves information about a aws_ec2_instance_type.
/// </summary>
public partial class AwsEc2InstanceTypeDataSource(string name) : TerraformDataSource("aws_ec2_instance_type", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The auto_recovery_supported attribute.
    /// </summary>
    public TerraformValue<bool> AutoRecoverySupported
    {
        get => new TerraformReference<bool>(this, "auto_recovery_supported");
    }

    /// <summary>
    /// The bandwidth_weightings attribute.
    /// </summary>
    public TerraformSet<string> BandwidthWeightings
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "bandwidth_weightings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The bare_metal attribute.
    /// </summary>
    public TerraformValue<bool> BareMetal
    {
        get => new TerraformReference<bool>(this, "bare_metal");
    }

    /// <summary>
    /// The boot_modes attribute.
    /// </summary>
    public TerraformSet<string> BootModes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "boot_modes").ResolveNodes(ctx));
    }

    /// <summary>
    /// The burstable_performance_supported attribute.
    /// </summary>
    public TerraformValue<bool> BurstablePerformanceSupported
    {
        get => new TerraformReference<bool>(this, "burstable_performance_supported");
    }

    /// <summary>
    /// The current_generation attribute.
    /// </summary>
    public TerraformValue<bool> CurrentGeneration
    {
        get => new TerraformReference<bool>(this, "current_generation");
    }

    /// <summary>
    /// The dedicated_hosts_supported attribute.
    /// </summary>
    public TerraformValue<bool> DedicatedHostsSupported
    {
        get => new TerraformReference<bool>(this, "dedicated_hosts_supported");
    }

    /// <summary>
    /// The default_cores attribute.
    /// </summary>
    public TerraformValue<double> DefaultCores
    {
        get => new TerraformReference<double>(this, "default_cores");
    }

    /// <summary>
    /// The default_network_card_index attribute.
    /// </summary>
    public TerraformValue<double> DefaultNetworkCardIndex
    {
        get => new TerraformReference<double>(this, "default_network_card_index");
    }

    /// <summary>
    /// The default_threads_per_core attribute.
    /// </summary>
    public TerraformValue<double> DefaultThreadsPerCore
    {
        get => new TerraformReference<double>(this, "default_threads_per_core");
    }

    /// <summary>
    /// The default_vcpus attribute.
    /// </summary>
    public TerraformValue<double> DefaultVcpus
    {
        get => new TerraformReference<double>(this, "default_vcpus");
    }

    /// <summary>
    /// The ebs_encryption_support attribute.
    /// </summary>
    public TerraformValue<string> EbsEncryptionSupport
    {
        get => new TerraformReference<string>(this, "ebs_encryption_support");
    }

    /// <summary>
    /// The ebs_nvme_support attribute.
    /// </summary>
    public TerraformValue<string> EbsNvmeSupport
    {
        get => new TerraformReference<string>(this, "ebs_nvme_support");
    }

    /// <summary>
    /// The ebs_optimized_support attribute.
    /// </summary>
    public TerraformValue<string> EbsOptimizedSupport
    {
        get => new TerraformReference<string>(this, "ebs_optimized_support");
    }

    /// <summary>
    /// The ebs_performance_baseline_bandwidth attribute.
    /// </summary>
    public TerraformValue<double> EbsPerformanceBaselineBandwidth
    {
        get => new TerraformReference<double>(this, "ebs_performance_baseline_bandwidth");
    }

    /// <summary>
    /// The ebs_performance_baseline_iops attribute.
    /// </summary>
    public TerraformValue<double> EbsPerformanceBaselineIops
    {
        get => new TerraformReference<double>(this, "ebs_performance_baseline_iops");
    }

    /// <summary>
    /// The ebs_performance_baseline_throughput attribute.
    /// </summary>
    public TerraformValue<double> EbsPerformanceBaselineThroughput
    {
        get => new TerraformReference<double>(this, "ebs_performance_baseline_throughput");
    }

    /// <summary>
    /// The ebs_performance_maximum_bandwidth attribute.
    /// </summary>
    public TerraformValue<double> EbsPerformanceMaximumBandwidth
    {
        get => new TerraformReference<double>(this, "ebs_performance_maximum_bandwidth");
    }

    /// <summary>
    /// The ebs_performance_maximum_iops attribute.
    /// </summary>
    public TerraformValue<double> EbsPerformanceMaximumIops
    {
        get => new TerraformReference<double>(this, "ebs_performance_maximum_iops");
    }

    /// <summary>
    /// The ebs_performance_maximum_throughput attribute.
    /// </summary>
    public TerraformValue<double> EbsPerformanceMaximumThroughput
    {
        get => new TerraformReference<double>(this, "ebs_performance_maximum_throughput");
    }

    /// <summary>
    /// The efa_maximum_interfaces attribute.
    /// </summary>
    public TerraformValue<double> EfaMaximumInterfaces
    {
        get => new TerraformReference<double>(this, "efa_maximum_interfaces");
    }

    /// <summary>
    /// The efa_supported attribute.
    /// </summary>
    public TerraformValue<bool> EfaSupported
    {
        get => new TerraformReference<bool>(this, "efa_supported");
    }

    /// <summary>
    /// The ena_srd_supported attribute.
    /// </summary>
    public TerraformValue<bool> EnaSrdSupported
    {
        get => new TerraformReference<bool>(this, "ena_srd_supported");
    }

    /// <summary>
    /// The ena_support attribute.
    /// </summary>
    public TerraformValue<string> EnaSupport
    {
        get => new TerraformReference<string>(this, "ena_support");
    }

    /// <summary>
    /// The encryption_in_transit_supported attribute.
    /// </summary>
    public TerraformValue<bool> EncryptionInTransitSupported
    {
        get => new TerraformReference<bool>(this, "encryption_in_transit_supported");
    }

    /// <summary>
    /// The fpgas attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Fpgas
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "fpgas").ResolveNodes(ctx));
    }

    /// <summary>
    /// The free_tier_eligible attribute.
    /// </summary>
    public TerraformValue<bool> FreeTierEligible
    {
        get => new TerraformReference<bool>(this, "free_tier_eligible");
    }

    /// <summary>
    /// The gpus attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Gpus
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "gpus").ResolveNodes(ctx));
    }

    /// <summary>
    /// The hibernation_supported attribute.
    /// </summary>
    public TerraformValue<bool> HibernationSupported
    {
        get => new TerraformReference<bool>(this, "hibernation_supported");
    }

    /// <summary>
    /// The hypervisor attribute.
    /// </summary>
    public TerraformValue<string> Hypervisor
    {
        get => new TerraformReference<string>(this, "hypervisor");
    }

    /// <summary>
    /// The inference_accelerators attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> InferenceAccelerators
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "inference_accelerators").ResolveNodes(ctx));
    }

    /// <summary>
    /// The instance_disks attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> InstanceDisks
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "instance_disks").ResolveNodes(ctx));
    }

    /// <summary>
    /// The instance_storage_supported attribute.
    /// </summary>
    public TerraformValue<bool> InstanceStorageSupported
    {
        get => new TerraformReference<bool>(this, "instance_storage_supported");
    }

    /// <summary>
    /// The ipv6_supported attribute.
    /// </summary>
    public TerraformValue<bool> Ipv6Supported
    {
        get => new TerraformReference<bool>(this, "ipv6_supported");
    }

    /// <summary>
    /// The maximum_ipv4_addresses_per_interface attribute.
    /// </summary>
    public TerraformValue<double> MaximumIpv4AddressesPerInterface
    {
        get => new TerraformReference<double>(this, "maximum_ipv4_addresses_per_interface");
    }

    /// <summary>
    /// The maximum_ipv6_addresses_per_interface attribute.
    /// </summary>
    public TerraformValue<double> MaximumIpv6AddressesPerInterface
    {
        get => new TerraformReference<double>(this, "maximum_ipv6_addresses_per_interface");
    }

    /// <summary>
    /// The maximum_network_cards attribute.
    /// </summary>
    public TerraformValue<double> MaximumNetworkCards
    {
        get => new TerraformReference<double>(this, "maximum_network_cards");
    }

    /// <summary>
    /// The maximum_network_interfaces attribute.
    /// </summary>
    public TerraformValue<double> MaximumNetworkInterfaces
    {
        get => new TerraformReference<double>(this, "maximum_network_interfaces");
    }

    /// <summary>
    /// The media_accelerators attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> MediaAccelerators
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "media_accelerators").ResolveNodes(ctx));
    }

    /// <summary>
    /// The memory_size attribute.
    /// </summary>
    public TerraformValue<double> MemorySize
    {
        get => new TerraformReference<double>(this, "memory_size");
    }

    /// <summary>
    /// The network_cards attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> NetworkCards
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "network_cards").ResolveNodes(ctx));
    }

    /// <summary>
    /// The network_performance attribute.
    /// </summary>
    public TerraformValue<string> NetworkPerformance
    {
        get => new TerraformReference<string>(this, "network_performance");
    }

    /// <summary>
    /// The neuron_devices attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> NeuronDevices
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "neuron_devices").ResolveNodes(ctx));
    }

    /// <summary>
    /// The nitro_enclaves_support attribute.
    /// </summary>
    public TerraformValue<string> NitroEnclavesSupport
    {
        get => new TerraformReference<string>(this, "nitro_enclaves_support");
    }

    /// <summary>
    /// The nitro_tpm_support attribute.
    /// </summary>
    public TerraformValue<string> NitroTpmSupport
    {
        get => new TerraformReference<string>(this, "nitro_tpm_support");
    }

    /// <summary>
    /// The nitro_tpm_supported_versions attribute.
    /// </summary>
    public TerraformSet<string> NitroTpmSupportedVersions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "nitro_tpm_supported_versions").ResolveNodes(ctx));
    }

    /// <summary>
    /// The phc_support attribute.
    /// </summary>
    public TerraformValue<string> PhcSupport
    {
        get => new TerraformReference<string>(this, "phc_support");
    }

    /// <summary>
    /// The supported_architectures attribute.
    /// </summary>
    public TerraformList<string> SupportedArchitectures
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "supported_architectures").ResolveNodes(ctx));
    }

    /// <summary>
    /// The supported_cpu_features attribute.
    /// </summary>
    public TerraformSet<string> SupportedCpuFeatures
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "supported_cpu_features").ResolveNodes(ctx));
    }

    /// <summary>
    /// The supported_placement_strategies attribute.
    /// </summary>
    public TerraformList<string> SupportedPlacementStrategies
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "supported_placement_strategies").ResolveNodes(ctx));
    }

    /// <summary>
    /// The supported_root_device_types attribute.
    /// </summary>
    public TerraformList<string> SupportedRootDeviceTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "supported_root_device_types").ResolveNodes(ctx));
    }

    /// <summary>
    /// The supported_usages_classes attribute.
    /// </summary>
    public TerraformList<string> SupportedUsagesClasses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "supported_usages_classes").ResolveNodes(ctx));
    }

    /// <summary>
    /// The supported_virtualization_types attribute.
    /// </summary>
    public TerraformList<string> SupportedVirtualizationTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "supported_virtualization_types").ResolveNodes(ctx));
    }

    /// <summary>
    /// The sustained_clock_speed attribute.
    /// </summary>
    public TerraformValue<double> SustainedClockSpeed
    {
        get => new TerraformReference<double>(this, "sustained_clock_speed");
    }

    /// <summary>
    /// The total_fpga_memory attribute.
    /// </summary>
    public TerraformValue<double> TotalFpgaMemory
    {
        get => new TerraformReference<double>(this, "total_fpga_memory");
    }

    /// <summary>
    /// The total_gpu_memory attribute.
    /// </summary>
    public TerraformValue<double> TotalGpuMemory
    {
        get => new TerraformReference<double>(this, "total_gpu_memory");
    }

    /// <summary>
    /// The total_inference_memory attribute.
    /// </summary>
    public TerraformValue<double> TotalInferenceMemory
    {
        get => new TerraformReference<double>(this, "total_inference_memory");
    }

    /// <summary>
    /// The total_instance_storage attribute.
    /// </summary>
    public TerraformValue<double> TotalInstanceStorage
    {
        get => new TerraformReference<double>(this, "total_instance_storage");
    }

    /// <summary>
    /// The total_media_memory attribute.
    /// </summary>
    public TerraformValue<double> TotalMediaMemory
    {
        get => new TerraformReference<double>(this, "total_media_memory");
    }

    /// <summary>
    /// The total_neuron_device_memory attribute.
    /// </summary>
    public TerraformValue<double> TotalNeuronDeviceMemory
    {
        get => new TerraformReference<double>(this, "total_neuron_device_memory");
    }

    /// <summary>
    /// The valid_cores attribute.
    /// </summary>
    public TerraformList<double> ValidCores
    {
        get => TerraformList<double>.Lazy(ctx => new TerraformReference<TerraformList<double>>(this, "valid_cores").ResolveNodes(ctx));
    }

    /// <summary>
    /// The valid_threads_per_core attribute.
    /// </summary>
    public TerraformList<double> ValidThreadsPerCore
    {
        get => TerraformList<double>.Lazy(ctx => new TerraformReference<TerraformList<double>>(this, "valid_threads_per_core").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEc2InstanceTypeDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEc2InstanceTypeDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
