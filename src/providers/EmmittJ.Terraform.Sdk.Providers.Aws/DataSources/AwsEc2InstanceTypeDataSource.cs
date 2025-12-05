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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
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
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The auto_recovery_supported attribute.
    /// </summary>
    public TerraformValue<bool> AutoRecoverySupported
        => CreateReference("auto_recovery_supported");

    /// <summary>
    /// The bandwidth_weightings attribute.
    /// </summary>
    public TerraformSet<string> BandwidthWeightings
        => CreateReference("bandwidth_weightings");

    /// <summary>
    /// The bare_metal attribute.
    /// </summary>
    public TerraformValue<bool> BareMetal
        => CreateReference("bare_metal");

    /// <summary>
    /// The boot_modes attribute.
    /// </summary>
    public TerraformSet<string> BootModes
        => CreateReference("boot_modes");

    /// <summary>
    /// The burstable_performance_supported attribute.
    /// </summary>
    public TerraformValue<bool> BurstablePerformanceSupported
        => CreateReference("burstable_performance_supported");

    /// <summary>
    /// The current_generation attribute.
    /// </summary>
    public TerraformValue<bool> CurrentGeneration
        => CreateReference("current_generation");

    /// <summary>
    /// The dedicated_hosts_supported attribute.
    /// </summary>
    public TerraformValue<bool> DedicatedHostsSupported
        => CreateReference("dedicated_hosts_supported");

    /// <summary>
    /// The default_cores attribute.
    /// </summary>
    public TerraformValue<double> DefaultCores
        => CreateReference("default_cores");

    /// <summary>
    /// The default_network_card_index attribute.
    /// </summary>
    public TerraformValue<double> DefaultNetworkCardIndex
        => CreateReference("default_network_card_index");

    /// <summary>
    /// The default_threads_per_core attribute.
    /// </summary>
    public TerraformValue<double> DefaultThreadsPerCore
        => CreateReference("default_threads_per_core");

    /// <summary>
    /// The default_vcpus attribute.
    /// </summary>
    public TerraformValue<double> DefaultVcpus
        => CreateReference("default_vcpus");

    /// <summary>
    /// The ebs_encryption_support attribute.
    /// </summary>
    public TerraformValue<string> EbsEncryptionSupport
        => CreateReference("ebs_encryption_support");

    /// <summary>
    /// The ebs_nvme_support attribute.
    /// </summary>
    public TerraformValue<string> EbsNvmeSupport
        => CreateReference("ebs_nvme_support");

    /// <summary>
    /// The ebs_optimized_support attribute.
    /// </summary>
    public TerraformValue<string> EbsOptimizedSupport
        => CreateReference("ebs_optimized_support");

    /// <summary>
    /// The ebs_performance_baseline_bandwidth attribute.
    /// </summary>
    public TerraformValue<double> EbsPerformanceBaselineBandwidth
        => CreateReference("ebs_performance_baseline_bandwidth");

    /// <summary>
    /// The ebs_performance_baseline_iops attribute.
    /// </summary>
    public TerraformValue<double> EbsPerformanceBaselineIops
        => CreateReference("ebs_performance_baseline_iops");

    /// <summary>
    /// The ebs_performance_baseline_throughput attribute.
    /// </summary>
    public TerraformValue<double> EbsPerformanceBaselineThroughput
        => CreateReference("ebs_performance_baseline_throughput");

    /// <summary>
    /// The ebs_performance_maximum_bandwidth attribute.
    /// </summary>
    public TerraformValue<double> EbsPerformanceMaximumBandwidth
        => CreateReference("ebs_performance_maximum_bandwidth");

    /// <summary>
    /// The ebs_performance_maximum_iops attribute.
    /// </summary>
    public TerraformValue<double> EbsPerformanceMaximumIops
        => CreateReference("ebs_performance_maximum_iops");

    /// <summary>
    /// The ebs_performance_maximum_throughput attribute.
    /// </summary>
    public TerraformValue<double> EbsPerformanceMaximumThroughput
        => CreateReference("ebs_performance_maximum_throughput");

    /// <summary>
    /// The efa_maximum_interfaces attribute.
    /// </summary>
    public TerraformValue<double> EfaMaximumInterfaces
        => CreateReference("efa_maximum_interfaces");

    /// <summary>
    /// The efa_supported attribute.
    /// </summary>
    public TerraformValue<bool> EfaSupported
        => CreateReference("efa_supported");

    /// <summary>
    /// The ena_srd_supported attribute.
    /// </summary>
    public TerraformValue<bool> EnaSrdSupported
        => CreateReference("ena_srd_supported");

    /// <summary>
    /// The ena_support attribute.
    /// </summary>
    public TerraformValue<string> EnaSupport
        => CreateReference("ena_support");

    /// <summary>
    /// The encryption_in_transit_supported attribute.
    /// </summary>
    public TerraformValue<bool> EncryptionInTransitSupported
        => CreateReference("encryption_in_transit_supported");

    /// <summary>
    /// The fpgas attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Fpgas
        => CreateReference("fpgas");

    /// <summary>
    /// The free_tier_eligible attribute.
    /// </summary>
    public TerraformValue<bool> FreeTierEligible
        => CreateReference("free_tier_eligible");

    /// <summary>
    /// The gpus attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Gpus
        => CreateReference("gpus");

    /// <summary>
    /// The hibernation_supported attribute.
    /// </summary>
    public TerraformValue<bool> HibernationSupported
        => CreateReference("hibernation_supported");

    /// <summary>
    /// The hypervisor attribute.
    /// </summary>
    public TerraformValue<string> Hypervisor
        => CreateReference("hypervisor");

    /// <summary>
    /// The inference_accelerators attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> InferenceAccelerators
        => CreateReference("inference_accelerators");

    /// <summary>
    /// The instance_disks attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> InstanceDisks
        => CreateReference("instance_disks");

    /// <summary>
    /// The instance_storage_supported attribute.
    /// </summary>
    public TerraformValue<bool> InstanceStorageSupported
        => CreateReference("instance_storage_supported");

    /// <summary>
    /// The ipv6_supported attribute.
    /// </summary>
    public TerraformValue<bool> Ipv6Supported
        => CreateReference("ipv6_supported");

    /// <summary>
    /// The maximum_ipv4_addresses_per_interface attribute.
    /// </summary>
    public TerraformValue<double> MaximumIpv4AddressesPerInterface
        => CreateReference("maximum_ipv4_addresses_per_interface");

    /// <summary>
    /// The maximum_ipv6_addresses_per_interface attribute.
    /// </summary>
    public TerraformValue<double> MaximumIpv6AddressesPerInterface
        => CreateReference("maximum_ipv6_addresses_per_interface");

    /// <summary>
    /// The maximum_network_cards attribute.
    /// </summary>
    public TerraformValue<double> MaximumNetworkCards
        => CreateReference("maximum_network_cards");

    /// <summary>
    /// The maximum_network_interfaces attribute.
    /// </summary>
    public TerraformValue<double> MaximumNetworkInterfaces
        => CreateReference("maximum_network_interfaces");

    /// <summary>
    /// The media_accelerators attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> MediaAccelerators
        => CreateReference("media_accelerators");

    /// <summary>
    /// The memory_size attribute.
    /// </summary>
    public TerraformValue<double> MemorySize
        => CreateReference("memory_size");

    /// <summary>
    /// The network_cards attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> NetworkCards
        => CreateReference("network_cards");

    /// <summary>
    /// The network_performance attribute.
    /// </summary>
    public TerraformValue<string> NetworkPerformance
        => CreateReference("network_performance");

    /// <summary>
    /// The neuron_devices attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> NeuronDevices
        => CreateReference("neuron_devices");

    /// <summary>
    /// The nitro_enclaves_support attribute.
    /// </summary>
    public TerraformValue<string> NitroEnclavesSupport
        => CreateReference("nitro_enclaves_support");

    /// <summary>
    /// The nitro_tpm_support attribute.
    /// </summary>
    public TerraformValue<string> NitroTpmSupport
        => CreateReference("nitro_tpm_support");

    /// <summary>
    /// The nitro_tpm_supported_versions attribute.
    /// </summary>
    public TerraformSet<string> NitroTpmSupportedVersions
        => CreateReference("nitro_tpm_supported_versions");

    /// <summary>
    /// The phc_support attribute.
    /// </summary>
    public TerraformValue<string> PhcSupport
        => CreateReference("phc_support");

    /// <summary>
    /// The supported_architectures attribute.
    /// </summary>
    public TerraformList<string> SupportedArchitectures
        => CreateReference("supported_architectures");

    /// <summary>
    /// The supported_cpu_features attribute.
    /// </summary>
    public TerraformSet<string> SupportedCpuFeatures
        => CreateReference("supported_cpu_features");

    /// <summary>
    /// The supported_placement_strategies attribute.
    /// </summary>
    public TerraformList<string> SupportedPlacementStrategies
        => CreateReference("supported_placement_strategies");

    /// <summary>
    /// The supported_root_device_types attribute.
    /// </summary>
    public TerraformList<string> SupportedRootDeviceTypes
        => CreateReference("supported_root_device_types");

    /// <summary>
    /// The supported_usages_classes attribute.
    /// </summary>
    public TerraformList<string> SupportedUsagesClasses
        => CreateReference("supported_usages_classes");

    /// <summary>
    /// The supported_virtualization_types attribute.
    /// </summary>
    public TerraformList<string> SupportedVirtualizationTypes
        => CreateReference("supported_virtualization_types");

    /// <summary>
    /// The sustained_clock_speed attribute.
    /// </summary>
    public TerraformValue<double> SustainedClockSpeed
        => CreateReference("sustained_clock_speed");

    /// <summary>
    /// The total_fpga_memory attribute.
    /// </summary>
    public TerraformValue<double> TotalFpgaMemory
        => CreateReference("total_fpga_memory");

    /// <summary>
    /// The total_gpu_memory attribute.
    /// </summary>
    public TerraformValue<double> TotalGpuMemory
        => CreateReference("total_gpu_memory");

    /// <summary>
    /// The total_inference_memory attribute.
    /// </summary>
    public TerraformValue<double> TotalInferenceMemory
        => CreateReference("total_inference_memory");

    /// <summary>
    /// The total_instance_storage attribute.
    /// </summary>
    public TerraformValue<double> TotalInstanceStorage
        => CreateReference("total_instance_storage");

    /// <summary>
    /// The total_media_memory attribute.
    /// </summary>
    public TerraformValue<double> TotalMediaMemory
        => CreateReference("total_media_memory");

    /// <summary>
    /// The total_neuron_device_memory attribute.
    /// </summary>
    public TerraformValue<double> TotalNeuronDeviceMemory
        => CreateReference("total_neuron_device_memory");

    /// <summary>
    /// The valid_cores attribute.
    /// </summary>
    public TerraformList<double> ValidCores
        => CreateReference("valid_cores");

    /// <summary>
    /// The valid_threads_per_core attribute.
    /// </summary>
    public TerraformList<double> ValidThreadsPerCore
        => CreateReference("valid_threads_per_core");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEc2InstanceTypeDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEc2InstanceTypeDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
