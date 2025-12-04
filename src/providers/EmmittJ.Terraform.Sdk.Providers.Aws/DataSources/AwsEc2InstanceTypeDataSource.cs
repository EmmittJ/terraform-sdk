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
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformValue<string> InstanceType
    {
        get => GetRequiredArgument<TerraformValue<string>>("instance_type");
        set => SetArgument("instance_type", value);
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
    /// The auto_recovery_supported attribute.
    /// </summary>
    public TerraformValue<bool> AutoRecoverySupported
        => AsReference("auto_recovery_supported");

    /// <summary>
    /// The bandwidth_weightings attribute.
    /// </summary>
    public TerraformSet<string> BandwidthWeightings
        => AsReference("bandwidth_weightings");

    /// <summary>
    /// The bare_metal attribute.
    /// </summary>
    public TerraformValue<bool> BareMetal
        => AsReference("bare_metal");

    /// <summary>
    /// The boot_modes attribute.
    /// </summary>
    public TerraformSet<string> BootModes
        => AsReference("boot_modes");

    /// <summary>
    /// The burstable_performance_supported attribute.
    /// </summary>
    public TerraformValue<bool> BurstablePerformanceSupported
        => AsReference("burstable_performance_supported");

    /// <summary>
    /// The current_generation attribute.
    /// </summary>
    public TerraformValue<bool> CurrentGeneration
        => AsReference("current_generation");

    /// <summary>
    /// The dedicated_hosts_supported attribute.
    /// </summary>
    public TerraformValue<bool> DedicatedHostsSupported
        => AsReference("dedicated_hosts_supported");

    /// <summary>
    /// The default_cores attribute.
    /// </summary>
    public TerraformValue<double> DefaultCores
        => AsReference("default_cores");

    /// <summary>
    /// The default_network_card_index attribute.
    /// </summary>
    public TerraformValue<double> DefaultNetworkCardIndex
        => AsReference("default_network_card_index");

    /// <summary>
    /// The default_threads_per_core attribute.
    /// </summary>
    public TerraformValue<double> DefaultThreadsPerCore
        => AsReference("default_threads_per_core");

    /// <summary>
    /// The default_vcpus attribute.
    /// </summary>
    public TerraformValue<double> DefaultVcpus
        => AsReference("default_vcpus");

    /// <summary>
    /// The ebs_encryption_support attribute.
    /// </summary>
    public TerraformValue<string> EbsEncryptionSupport
        => AsReference("ebs_encryption_support");

    /// <summary>
    /// The ebs_nvme_support attribute.
    /// </summary>
    public TerraformValue<string> EbsNvmeSupport
        => AsReference("ebs_nvme_support");

    /// <summary>
    /// The ebs_optimized_support attribute.
    /// </summary>
    public TerraformValue<string> EbsOptimizedSupport
        => AsReference("ebs_optimized_support");

    /// <summary>
    /// The ebs_performance_baseline_bandwidth attribute.
    /// </summary>
    public TerraformValue<double> EbsPerformanceBaselineBandwidth
        => AsReference("ebs_performance_baseline_bandwidth");

    /// <summary>
    /// The ebs_performance_baseline_iops attribute.
    /// </summary>
    public TerraformValue<double> EbsPerformanceBaselineIops
        => AsReference("ebs_performance_baseline_iops");

    /// <summary>
    /// The ebs_performance_baseline_throughput attribute.
    /// </summary>
    public TerraformValue<double> EbsPerformanceBaselineThroughput
        => AsReference("ebs_performance_baseline_throughput");

    /// <summary>
    /// The ebs_performance_maximum_bandwidth attribute.
    /// </summary>
    public TerraformValue<double> EbsPerformanceMaximumBandwidth
        => AsReference("ebs_performance_maximum_bandwidth");

    /// <summary>
    /// The ebs_performance_maximum_iops attribute.
    /// </summary>
    public TerraformValue<double> EbsPerformanceMaximumIops
        => AsReference("ebs_performance_maximum_iops");

    /// <summary>
    /// The ebs_performance_maximum_throughput attribute.
    /// </summary>
    public TerraformValue<double> EbsPerformanceMaximumThroughput
        => AsReference("ebs_performance_maximum_throughput");

    /// <summary>
    /// The efa_maximum_interfaces attribute.
    /// </summary>
    public TerraformValue<double> EfaMaximumInterfaces
        => AsReference("efa_maximum_interfaces");

    /// <summary>
    /// The efa_supported attribute.
    /// </summary>
    public TerraformValue<bool> EfaSupported
        => AsReference("efa_supported");

    /// <summary>
    /// The ena_srd_supported attribute.
    /// </summary>
    public TerraformValue<bool> EnaSrdSupported
        => AsReference("ena_srd_supported");

    /// <summary>
    /// The ena_support attribute.
    /// </summary>
    public TerraformValue<string> EnaSupport
        => AsReference("ena_support");

    /// <summary>
    /// The encryption_in_transit_supported attribute.
    /// </summary>
    public TerraformValue<bool> EncryptionInTransitSupported
        => AsReference("encryption_in_transit_supported");

    /// <summary>
    /// The fpgas attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Fpgas
        => AsReference("fpgas");

    /// <summary>
    /// The free_tier_eligible attribute.
    /// </summary>
    public TerraformValue<bool> FreeTierEligible
        => AsReference("free_tier_eligible");

    /// <summary>
    /// The gpus attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Gpus
        => AsReference("gpus");

    /// <summary>
    /// The hibernation_supported attribute.
    /// </summary>
    public TerraformValue<bool> HibernationSupported
        => AsReference("hibernation_supported");

    /// <summary>
    /// The hypervisor attribute.
    /// </summary>
    public TerraformValue<string> Hypervisor
        => AsReference("hypervisor");

    /// <summary>
    /// The inference_accelerators attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> InferenceAccelerators
        => AsReference("inference_accelerators");

    /// <summary>
    /// The instance_disks attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> InstanceDisks
        => AsReference("instance_disks");

    /// <summary>
    /// The instance_storage_supported attribute.
    /// </summary>
    public TerraformValue<bool> InstanceStorageSupported
        => AsReference("instance_storage_supported");

    /// <summary>
    /// The ipv6_supported attribute.
    /// </summary>
    public TerraformValue<bool> Ipv6Supported
        => AsReference("ipv6_supported");

    /// <summary>
    /// The maximum_ipv4_addresses_per_interface attribute.
    /// </summary>
    public TerraformValue<double> MaximumIpv4AddressesPerInterface
        => AsReference("maximum_ipv4_addresses_per_interface");

    /// <summary>
    /// The maximum_ipv6_addresses_per_interface attribute.
    /// </summary>
    public TerraformValue<double> MaximumIpv6AddressesPerInterface
        => AsReference("maximum_ipv6_addresses_per_interface");

    /// <summary>
    /// The maximum_network_cards attribute.
    /// </summary>
    public TerraformValue<double> MaximumNetworkCards
        => AsReference("maximum_network_cards");

    /// <summary>
    /// The maximum_network_interfaces attribute.
    /// </summary>
    public TerraformValue<double> MaximumNetworkInterfaces
        => AsReference("maximum_network_interfaces");

    /// <summary>
    /// The media_accelerators attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> MediaAccelerators
        => AsReference("media_accelerators");

    /// <summary>
    /// The memory_size attribute.
    /// </summary>
    public TerraformValue<double> MemorySize
        => AsReference("memory_size");

    /// <summary>
    /// The network_cards attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> NetworkCards
        => AsReference("network_cards");

    /// <summary>
    /// The network_performance attribute.
    /// </summary>
    public TerraformValue<string> NetworkPerformance
        => AsReference("network_performance");

    /// <summary>
    /// The neuron_devices attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> NeuronDevices
        => AsReference("neuron_devices");

    /// <summary>
    /// The nitro_enclaves_support attribute.
    /// </summary>
    public TerraformValue<string> NitroEnclavesSupport
        => AsReference("nitro_enclaves_support");

    /// <summary>
    /// The nitro_tpm_support attribute.
    /// </summary>
    public TerraformValue<string> NitroTpmSupport
        => AsReference("nitro_tpm_support");

    /// <summary>
    /// The nitro_tpm_supported_versions attribute.
    /// </summary>
    public TerraformSet<string> NitroTpmSupportedVersions
        => AsReference("nitro_tpm_supported_versions");

    /// <summary>
    /// The phc_support attribute.
    /// </summary>
    public TerraformValue<string> PhcSupport
        => AsReference("phc_support");

    /// <summary>
    /// The supported_architectures attribute.
    /// </summary>
    public TerraformList<string> SupportedArchitectures
        => AsReference("supported_architectures");

    /// <summary>
    /// The supported_cpu_features attribute.
    /// </summary>
    public TerraformSet<string> SupportedCpuFeatures
        => AsReference("supported_cpu_features");

    /// <summary>
    /// The supported_placement_strategies attribute.
    /// </summary>
    public TerraformList<string> SupportedPlacementStrategies
        => AsReference("supported_placement_strategies");

    /// <summary>
    /// The supported_root_device_types attribute.
    /// </summary>
    public TerraformList<string> SupportedRootDeviceTypes
        => AsReference("supported_root_device_types");

    /// <summary>
    /// The supported_usages_classes attribute.
    /// </summary>
    public TerraformList<string> SupportedUsagesClasses
        => AsReference("supported_usages_classes");

    /// <summary>
    /// The supported_virtualization_types attribute.
    /// </summary>
    public TerraformList<string> SupportedVirtualizationTypes
        => AsReference("supported_virtualization_types");

    /// <summary>
    /// The sustained_clock_speed attribute.
    /// </summary>
    public TerraformValue<double> SustainedClockSpeed
        => AsReference("sustained_clock_speed");

    /// <summary>
    /// The total_fpga_memory attribute.
    /// </summary>
    public TerraformValue<double> TotalFpgaMemory
        => AsReference("total_fpga_memory");

    /// <summary>
    /// The total_gpu_memory attribute.
    /// </summary>
    public TerraformValue<double> TotalGpuMemory
        => AsReference("total_gpu_memory");

    /// <summary>
    /// The total_inference_memory attribute.
    /// </summary>
    public TerraformValue<double> TotalInferenceMemory
        => AsReference("total_inference_memory");

    /// <summary>
    /// The total_instance_storage attribute.
    /// </summary>
    public TerraformValue<double> TotalInstanceStorage
        => AsReference("total_instance_storage");

    /// <summary>
    /// The total_media_memory attribute.
    /// </summary>
    public TerraformValue<double> TotalMediaMemory
        => AsReference("total_media_memory");

    /// <summary>
    /// The total_neuron_device_memory attribute.
    /// </summary>
    public TerraformValue<double> TotalNeuronDeviceMemory
        => AsReference("total_neuron_device_memory");

    /// <summary>
    /// The valid_cores attribute.
    /// </summary>
    public TerraformList<double> ValidCores
        => AsReference("valid_cores");

    /// <summary>
    /// The valid_threads_per_core attribute.
    /// </summary>
    public TerraformList<double> ValidThreadsPerCore
        => AsReference("valid_threads_per_core");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEc2InstanceTypeDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEc2InstanceTypeDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
