using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsEc2InstanceTypeDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ec2_instance_type.
/// </summary>
public partial class AwsEc2InstanceTypeDataSource : TerraformDataSource
{
    public AwsEc2InstanceTypeDataSource(string name) : base("aws_ec2_instance_type", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    [TerraformProperty("instance_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InstanceType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsEc2InstanceTypeDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The auto_recovery_supported attribute.
    /// </summary>
    [TerraformProperty("auto_recovery_supported")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> AutoRecoverySupported { get; }

    /// <summary>
    /// The bandwidth_weightings attribute.
    /// </summary>
    [TerraformProperty("bandwidth_weightings")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> BandwidthWeightings { get; }

    /// <summary>
    /// The bare_metal attribute.
    /// </summary>
    [TerraformProperty("bare_metal")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> BareMetal { get; }

    /// <summary>
    /// The boot_modes attribute.
    /// </summary>
    [TerraformProperty("boot_modes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> BootModes { get; }

    /// <summary>
    /// The burstable_performance_supported attribute.
    /// </summary>
    [TerraformProperty("burstable_performance_supported")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> BurstablePerformanceSupported { get; }

    /// <summary>
    /// The current_generation attribute.
    /// </summary>
    [TerraformProperty("current_generation")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> CurrentGeneration { get; }

    /// <summary>
    /// The dedicated_hosts_supported attribute.
    /// </summary>
    [TerraformProperty("dedicated_hosts_supported")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> DedicatedHostsSupported { get; }

    /// <summary>
    /// The default_cores attribute.
    /// </summary>
    [TerraformProperty("default_cores")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> DefaultCores { get; }

    /// <summary>
    /// The default_network_card_index attribute.
    /// </summary>
    [TerraformProperty("default_network_card_index")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> DefaultNetworkCardIndex { get; }

    /// <summary>
    /// The default_threads_per_core attribute.
    /// </summary>
    [TerraformProperty("default_threads_per_core")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> DefaultThreadsPerCore { get; }

    /// <summary>
    /// The default_vcpus attribute.
    /// </summary>
    [TerraformProperty("default_vcpus")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> DefaultVcpus { get; }

    /// <summary>
    /// The ebs_encryption_support attribute.
    /// </summary>
    [TerraformProperty("ebs_encryption_support")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EbsEncryptionSupport { get; }

    /// <summary>
    /// The ebs_nvme_support attribute.
    /// </summary>
    [TerraformProperty("ebs_nvme_support")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EbsNvmeSupport { get; }

    /// <summary>
    /// The ebs_optimized_support attribute.
    /// </summary>
    [TerraformProperty("ebs_optimized_support")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EbsOptimizedSupport { get; }

    /// <summary>
    /// The ebs_performance_baseline_bandwidth attribute.
    /// </summary>
    [TerraformProperty("ebs_performance_baseline_bandwidth")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> EbsPerformanceBaselineBandwidth { get; }

    /// <summary>
    /// The ebs_performance_baseline_iops attribute.
    /// </summary>
    [TerraformProperty("ebs_performance_baseline_iops")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> EbsPerformanceBaselineIops { get; }

    /// <summary>
    /// The ebs_performance_baseline_throughput attribute.
    /// </summary>
    [TerraformProperty("ebs_performance_baseline_throughput")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> EbsPerformanceBaselineThroughput { get; }

    /// <summary>
    /// The ebs_performance_maximum_bandwidth attribute.
    /// </summary>
    [TerraformProperty("ebs_performance_maximum_bandwidth")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> EbsPerformanceMaximumBandwidth { get; }

    /// <summary>
    /// The ebs_performance_maximum_iops attribute.
    /// </summary>
    [TerraformProperty("ebs_performance_maximum_iops")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> EbsPerformanceMaximumIops { get; }

    /// <summary>
    /// The ebs_performance_maximum_throughput attribute.
    /// </summary>
    [TerraformProperty("ebs_performance_maximum_throughput")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> EbsPerformanceMaximumThroughput { get; }

    /// <summary>
    /// The efa_maximum_interfaces attribute.
    /// </summary>
    [TerraformProperty("efa_maximum_interfaces")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> EfaMaximumInterfaces { get; }

    /// <summary>
    /// The efa_supported attribute.
    /// </summary>
    [TerraformProperty("efa_supported")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> EfaSupported { get; }

    /// <summary>
    /// The ena_srd_supported attribute.
    /// </summary>
    [TerraformProperty("ena_srd_supported")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> EnaSrdSupported { get; }

    /// <summary>
    /// The ena_support attribute.
    /// </summary>
    [TerraformProperty("ena_support")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EnaSupport { get; }

    /// <summary>
    /// The encryption_in_transit_supported attribute.
    /// </summary>
    [TerraformProperty("encryption_in_transit_supported")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> EncryptionInTransitSupported { get; }

    /// <summary>
    /// The fpgas attribute.
    /// </summary>
    [TerraformProperty("fpgas")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> Fpgas { get; }

    /// <summary>
    /// The free_tier_eligible attribute.
    /// </summary>
    [TerraformProperty("free_tier_eligible")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> FreeTierEligible { get; }

    /// <summary>
    /// The gpus attribute.
    /// </summary>
    [TerraformProperty("gpus")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> Gpus { get; }

    /// <summary>
    /// The hibernation_supported attribute.
    /// </summary>
    [TerraformProperty("hibernation_supported")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> HibernationSupported { get; }

    /// <summary>
    /// The hypervisor attribute.
    /// </summary>
    [TerraformProperty("hypervisor")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Hypervisor { get; }

    /// <summary>
    /// The inference_accelerators attribute.
    /// </summary>
    [TerraformProperty("inference_accelerators")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> InferenceAccelerators { get; }

    /// <summary>
    /// The instance_disks attribute.
    /// </summary>
    [TerraformProperty("instance_disks")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> InstanceDisks { get; }

    /// <summary>
    /// The instance_storage_supported attribute.
    /// </summary>
    [TerraformProperty("instance_storage_supported")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> InstanceStorageSupported { get; }

    /// <summary>
    /// The ipv6_supported attribute.
    /// </summary>
    [TerraformProperty("ipv6_supported")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Ipv6Supported { get; }

    /// <summary>
    /// The maximum_ipv4_addresses_per_interface attribute.
    /// </summary>
    [TerraformProperty("maximum_ipv4_addresses_per_interface")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MaximumIpv4AddressesPerInterface { get; }

    /// <summary>
    /// The maximum_ipv6_addresses_per_interface attribute.
    /// </summary>
    [TerraformProperty("maximum_ipv6_addresses_per_interface")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MaximumIpv6AddressesPerInterface { get; }

    /// <summary>
    /// The maximum_network_cards attribute.
    /// </summary>
    [TerraformProperty("maximum_network_cards")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MaximumNetworkCards { get; }

    /// <summary>
    /// The maximum_network_interfaces attribute.
    /// </summary>
    [TerraformProperty("maximum_network_interfaces")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MaximumNetworkInterfaces { get; }

    /// <summary>
    /// The media_accelerators attribute.
    /// </summary>
    [TerraformProperty("media_accelerators")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> MediaAccelerators { get; }

    /// <summary>
    /// The memory_size attribute.
    /// </summary>
    [TerraformProperty("memory_size")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MemorySize { get; }

    /// <summary>
    /// The network_cards attribute.
    /// </summary>
    [TerraformProperty("network_cards")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> NetworkCards { get; }

    /// <summary>
    /// The network_performance attribute.
    /// </summary>
    [TerraformProperty("network_performance")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NetworkPerformance { get; }

    /// <summary>
    /// The neuron_devices attribute.
    /// </summary>
    [TerraformProperty("neuron_devices")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> NeuronDevices { get; }

    /// <summary>
    /// The nitro_enclaves_support attribute.
    /// </summary>
    [TerraformProperty("nitro_enclaves_support")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NitroEnclavesSupport { get; }

    /// <summary>
    /// The nitro_tpm_support attribute.
    /// </summary>
    [TerraformProperty("nitro_tpm_support")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NitroTpmSupport { get; }

    /// <summary>
    /// The nitro_tpm_supported_versions attribute.
    /// </summary>
    [TerraformProperty("nitro_tpm_supported_versions")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> NitroTpmSupportedVersions { get; }

    /// <summary>
    /// The phc_support attribute.
    /// </summary>
    [TerraformProperty("phc_support")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PhcSupport { get; }

    /// <summary>
    /// The supported_architectures attribute.
    /// </summary>
    [TerraformProperty("supported_architectures")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> SupportedArchitectures { get; }

    /// <summary>
    /// The supported_cpu_features attribute.
    /// </summary>
    [TerraformProperty("supported_cpu_features")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> SupportedCpuFeatures { get; }

    /// <summary>
    /// The supported_placement_strategies attribute.
    /// </summary>
    [TerraformProperty("supported_placement_strategies")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> SupportedPlacementStrategies { get; }

    /// <summary>
    /// The supported_root_device_types attribute.
    /// </summary>
    [TerraformProperty("supported_root_device_types")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> SupportedRootDeviceTypes { get; }

    /// <summary>
    /// The supported_usages_classes attribute.
    /// </summary>
    [TerraformProperty("supported_usages_classes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> SupportedUsagesClasses { get; }

    /// <summary>
    /// The supported_virtualization_types attribute.
    /// </summary>
    [TerraformProperty("supported_virtualization_types")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> SupportedVirtualizationTypes { get; }

    /// <summary>
    /// The sustained_clock_speed attribute.
    /// </summary>
    [TerraformProperty("sustained_clock_speed")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> SustainedClockSpeed { get; }

    /// <summary>
    /// The total_fpga_memory attribute.
    /// </summary>
    [TerraformProperty("total_fpga_memory")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> TotalFpgaMemory { get; }

    /// <summary>
    /// The total_gpu_memory attribute.
    /// </summary>
    [TerraformProperty("total_gpu_memory")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> TotalGpuMemory { get; }

    /// <summary>
    /// The total_inference_memory attribute.
    /// </summary>
    [TerraformProperty("total_inference_memory")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> TotalInferenceMemory { get; }

    /// <summary>
    /// The total_instance_storage attribute.
    /// </summary>
    [TerraformProperty("total_instance_storage")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> TotalInstanceStorage { get; }

    /// <summary>
    /// The total_media_memory attribute.
    /// </summary>
    [TerraformProperty("total_media_memory")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> TotalMediaMemory { get; }

    /// <summary>
    /// The total_neuron_device_memory attribute.
    /// </summary>
    [TerraformProperty("total_neuron_device_memory")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> TotalNeuronDeviceMemory { get; }

    /// <summary>
    /// The valid_cores attribute.
    /// </summary>
    [TerraformProperty("valid_cores")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<double> ValidCores { get; }

    /// <summary>
    /// The valid_threads_per_core attribute.
    /// </summary>
    [TerraformProperty("valid_threads_per_core")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<double> ValidThreadsPerCore { get; }

}
