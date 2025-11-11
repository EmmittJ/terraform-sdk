using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEc2InstanceTypeDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ec2_instance_type.
/// </summary>
public class AwsEc2InstanceTypeDataSource : TerraformDataSource
{
    public AwsEc2InstanceTypeDataSource(string name) : base("aws_ec2_instance_type", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    [TerraformPropertyName("instance_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> InstanceType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsEc2InstanceTypeDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The auto_recovery_supported attribute.
    /// </summary>
    [TerraformPropertyName("auto_recovery_supported")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AutoRecoverySupported => new TerraformReference(this, "auto_recovery_supported");

    /// <summary>
    /// The bandwidth_weightings attribute.
    /// </summary>
    [TerraformPropertyName("bandwidth_weightings")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> BandwidthWeightings => new TerraformReference(this, "bandwidth_weightings");

    /// <summary>
    /// The bare_metal attribute.
    /// </summary>
    [TerraformPropertyName("bare_metal")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> BareMetal => new TerraformReference(this, "bare_metal");

    /// <summary>
    /// The boot_modes attribute.
    /// </summary>
    [TerraformPropertyName("boot_modes")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> BootModes => new TerraformReference(this, "boot_modes");

    /// <summary>
    /// The burstable_performance_supported attribute.
    /// </summary>
    [TerraformPropertyName("burstable_performance_supported")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> BurstablePerformanceSupported => new TerraformReference(this, "burstable_performance_supported");

    /// <summary>
    /// The current_generation attribute.
    /// </summary>
    [TerraformPropertyName("current_generation")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> CurrentGeneration => new TerraformReference(this, "current_generation");

    /// <summary>
    /// The dedicated_hosts_supported attribute.
    /// </summary>
    [TerraformPropertyName("dedicated_hosts_supported")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DedicatedHostsSupported => new TerraformReference(this, "dedicated_hosts_supported");

    /// <summary>
    /// The default_cores attribute.
    /// </summary>
    [TerraformPropertyName("default_cores")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DefaultCores => new TerraformReference(this, "default_cores");

    /// <summary>
    /// The default_network_card_index attribute.
    /// </summary>
    [TerraformPropertyName("default_network_card_index")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DefaultNetworkCardIndex => new TerraformReference(this, "default_network_card_index");

    /// <summary>
    /// The default_threads_per_core attribute.
    /// </summary>
    [TerraformPropertyName("default_threads_per_core")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DefaultThreadsPerCore => new TerraformReference(this, "default_threads_per_core");

    /// <summary>
    /// The default_vcpus attribute.
    /// </summary>
    [TerraformPropertyName("default_vcpus")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DefaultVcpus => new TerraformReference(this, "default_vcpus");

    /// <summary>
    /// The ebs_encryption_support attribute.
    /// </summary>
    [TerraformPropertyName("ebs_encryption_support")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EbsEncryptionSupport => new TerraformReference(this, "ebs_encryption_support");

    /// <summary>
    /// The ebs_nvme_support attribute.
    /// </summary>
    [TerraformPropertyName("ebs_nvme_support")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EbsNvmeSupport => new TerraformReference(this, "ebs_nvme_support");

    /// <summary>
    /// The ebs_optimized_support attribute.
    /// </summary>
    [TerraformPropertyName("ebs_optimized_support")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EbsOptimizedSupport => new TerraformReference(this, "ebs_optimized_support");

    /// <summary>
    /// The ebs_performance_baseline_bandwidth attribute.
    /// </summary>
    [TerraformPropertyName("ebs_performance_baseline_bandwidth")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> EbsPerformanceBaselineBandwidth => new TerraformReference(this, "ebs_performance_baseline_bandwidth");

    /// <summary>
    /// The ebs_performance_baseline_iops attribute.
    /// </summary>
    [TerraformPropertyName("ebs_performance_baseline_iops")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> EbsPerformanceBaselineIops => new TerraformReference(this, "ebs_performance_baseline_iops");

    /// <summary>
    /// The ebs_performance_baseline_throughput attribute.
    /// </summary>
    [TerraformPropertyName("ebs_performance_baseline_throughput")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> EbsPerformanceBaselineThroughput => new TerraformReference(this, "ebs_performance_baseline_throughput");

    /// <summary>
    /// The ebs_performance_maximum_bandwidth attribute.
    /// </summary>
    [TerraformPropertyName("ebs_performance_maximum_bandwidth")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> EbsPerformanceMaximumBandwidth => new TerraformReference(this, "ebs_performance_maximum_bandwidth");

    /// <summary>
    /// The ebs_performance_maximum_iops attribute.
    /// </summary>
    [TerraformPropertyName("ebs_performance_maximum_iops")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> EbsPerformanceMaximumIops => new TerraformReference(this, "ebs_performance_maximum_iops");

    /// <summary>
    /// The ebs_performance_maximum_throughput attribute.
    /// </summary>
    [TerraformPropertyName("ebs_performance_maximum_throughput")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> EbsPerformanceMaximumThroughput => new TerraformReference(this, "ebs_performance_maximum_throughput");

    /// <summary>
    /// The efa_maximum_interfaces attribute.
    /// </summary>
    [TerraformPropertyName("efa_maximum_interfaces")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> EfaMaximumInterfaces => new TerraformReference(this, "efa_maximum_interfaces");

    /// <summary>
    /// The efa_supported attribute.
    /// </summary>
    [TerraformPropertyName("efa_supported")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EfaSupported => new TerraformReference(this, "efa_supported");

    /// <summary>
    /// The ena_srd_supported attribute.
    /// </summary>
    [TerraformPropertyName("ena_srd_supported")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnaSrdSupported => new TerraformReference(this, "ena_srd_supported");

    /// <summary>
    /// The ena_support attribute.
    /// </summary>
    [TerraformPropertyName("ena_support")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EnaSupport => new TerraformReference(this, "ena_support");

    /// <summary>
    /// The encryption_in_transit_supported attribute.
    /// </summary>
    [TerraformPropertyName("encryption_in_transit_supported")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EncryptionInTransitSupported => new TerraformReference(this, "encryption_in_transit_supported");

    /// <summary>
    /// The fpgas attribute.
    /// </summary>
    [TerraformPropertyName("fpgas")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> Fpgas => new TerraformReference(this, "fpgas");

    /// <summary>
    /// The free_tier_eligible attribute.
    /// </summary>
    [TerraformPropertyName("free_tier_eligible")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> FreeTierEligible => new TerraformReference(this, "free_tier_eligible");

    /// <summary>
    /// The gpus attribute.
    /// </summary>
    [TerraformPropertyName("gpus")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> Gpus => new TerraformReference(this, "gpus");

    /// <summary>
    /// The hibernation_supported attribute.
    /// </summary>
    [TerraformPropertyName("hibernation_supported")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> HibernationSupported => new TerraformReference(this, "hibernation_supported");

    /// <summary>
    /// The hypervisor attribute.
    /// </summary>
    [TerraformPropertyName("hypervisor")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Hypervisor => new TerraformReference(this, "hypervisor");

    /// <summary>
    /// The inference_accelerators attribute.
    /// </summary>
    [TerraformPropertyName("inference_accelerators")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> InferenceAccelerators => new TerraformReference(this, "inference_accelerators");

    /// <summary>
    /// The instance_disks attribute.
    /// </summary>
    [TerraformPropertyName("instance_disks")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> InstanceDisks => new TerraformReference(this, "instance_disks");

    /// <summary>
    /// The instance_storage_supported attribute.
    /// </summary>
    [TerraformPropertyName("instance_storage_supported")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> InstanceStorageSupported => new TerraformReference(this, "instance_storage_supported");

    /// <summary>
    /// The ipv6_supported attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_supported")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Ipv6Supported => new TerraformReference(this, "ipv6_supported");

    /// <summary>
    /// The maximum_ipv4_addresses_per_interface attribute.
    /// </summary>
    [TerraformPropertyName("maximum_ipv4_addresses_per_interface")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaximumIpv4AddressesPerInterface => new TerraformReference(this, "maximum_ipv4_addresses_per_interface");

    /// <summary>
    /// The maximum_ipv6_addresses_per_interface attribute.
    /// </summary>
    [TerraformPropertyName("maximum_ipv6_addresses_per_interface")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaximumIpv6AddressesPerInterface => new TerraformReference(this, "maximum_ipv6_addresses_per_interface");

    /// <summary>
    /// The maximum_network_cards attribute.
    /// </summary>
    [TerraformPropertyName("maximum_network_cards")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaximumNetworkCards => new TerraformReference(this, "maximum_network_cards");

    /// <summary>
    /// The maximum_network_interfaces attribute.
    /// </summary>
    [TerraformPropertyName("maximum_network_interfaces")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaximumNetworkInterfaces => new TerraformReference(this, "maximum_network_interfaces");

    /// <summary>
    /// The media_accelerators attribute.
    /// </summary>
    [TerraformPropertyName("media_accelerators")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> MediaAccelerators => new TerraformReference(this, "media_accelerators");

    /// <summary>
    /// The memory_size attribute.
    /// </summary>
    [TerraformPropertyName("memory_size")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MemorySize => new TerraformReference(this, "memory_size");

    /// <summary>
    /// The network_cards attribute.
    /// </summary>
    [TerraformPropertyName("network_cards")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> NetworkCards => new TerraformReference(this, "network_cards");

    /// <summary>
    /// The network_performance attribute.
    /// </summary>
    [TerraformPropertyName("network_performance")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NetworkPerformance => new TerraformReference(this, "network_performance");

    /// <summary>
    /// The neuron_devices attribute.
    /// </summary>
    [TerraformPropertyName("neuron_devices")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> NeuronDevices => new TerraformReference(this, "neuron_devices");

    /// <summary>
    /// The nitro_enclaves_support attribute.
    /// </summary>
    [TerraformPropertyName("nitro_enclaves_support")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NitroEnclavesSupport => new TerraformReference(this, "nitro_enclaves_support");

    /// <summary>
    /// The nitro_tpm_support attribute.
    /// </summary>
    [TerraformPropertyName("nitro_tpm_support")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NitroTpmSupport => new TerraformReference(this, "nitro_tpm_support");

    /// <summary>
    /// The nitro_tpm_supported_versions attribute.
    /// </summary>
    [TerraformPropertyName("nitro_tpm_supported_versions")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> NitroTpmSupportedVersions => new TerraformReference(this, "nitro_tpm_supported_versions");

    /// <summary>
    /// The phc_support attribute.
    /// </summary>
    [TerraformPropertyName("phc_support")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PhcSupport => new TerraformReference(this, "phc_support");

    /// <summary>
    /// The supported_architectures attribute.
    /// </summary>
    [TerraformPropertyName("supported_architectures")]
    // Output-only attribute - read-only reference
    public TerraformList<string> SupportedArchitectures => new TerraformReference(this, "supported_architectures");

    /// <summary>
    /// The supported_cpu_features attribute.
    /// </summary>
    [TerraformPropertyName("supported_cpu_features")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> SupportedCpuFeatures => new TerraformReference(this, "supported_cpu_features");

    /// <summary>
    /// The supported_placement_strategies attribute.
    /// </summary>
    [TerraformPropertyName("supported_placement_strategies")]
    // Output-only attribute - read-only reference
    public TerraformList<string> SupportedPlacementStrategies => new TerraformReference(this, "supported_placement_strategies");

    /// <summary>
    /// The supported_root_device_types attribute.
    /// </summary>
    [TerraformPropertyName("supported_root_device_types")]
    // Output-only attribute - read-only reference
    public TerraformList<string> SupportedRootDeviceTypes => new TerraformReference(this, "supported_root_device_types");

    /// <summary>
    /// The supported_usages_classes attribute.
    /// </summary>
    [TerraformPropertyName("supported_usages_classes")]
    // Output-only attribute - read-only reference
    public TerraformList<string> SupportedUsagesClasses => new TerraformReference(this, "supported_usages_classes");

    /// <summary>
    /// The supported_virtualization_types attribute.
    /// </summary>
    [TerraformPropertyName("supported_virtualization_types")]
    // Output-only attribute - read-only reference
    public TerraformList<string> SupportedVirtualizationTypes => new TerraformReference(this, "supported_virtualization_types");

    /// <summary>
    /// The sustained_clock_speed attribute.
    /// </summary>
    [TerraformPropertyName("sustained_clock_speed")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> SustainedClockSpeed => new TerraformReference(this, "sustained_clock_speed");

    /// <summary>
    /// The total_fpga_memory attribute.
    /// </summary>
    [TerraformPropertyName("total_fpga_memory")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> TotalFpgaMemory => new TerraformReference(this, "total_fpga_memory");

    /// <summary>
    /// The total_gpu_memory attribute.
    /// </summary>
    [TerraformPropertyName("total_gpu_memory")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> TotalGpuMemory => new TerraformReference(this, "total_gpu_memory");

    /// <summary>
    /// The total_inference_memory attribute.
    /// </summary>
    [TerraformPropertyName("total_inference_memory")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> TotalInferenceMemory => new TerraformReference(this, "total_inference_memory");

    /// <summary>
    /// The total_instance_storage attribute.
    /// </summary>
    [TerraformPropertyName("total_instance_storage")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> TotalInstanceStorage => new TerraformReference(this, "total_instance_storage");

    /// <summary>
    /// The total_media_memory attribute.
    /// </summary>
    [TerraformPropertyName("total_media_memory")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> TotalMediaMemory => new TerraformReference(this, "total_media_memory");

    /// <summary>
    /// The total_neuron_device_memory attribute.
    /// </summary>
    [TerraformPropertyName("total_neuron_device_memory")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> TotalNeuronDeviceMemory => new TerraformReference(this, "total_neuron_device_memory");

    /// <summary>
    /// The valid_cores attribute.
    /// </summary>
    [TerraformPropertyName("valid_cores")]
    // Output-only attribute - read-only reference
    public TerraformList<double> ValidCores => new TerraformReference(this, "valid_cores");

    /// <summary>
    /// The valid_threads_per_core attribute.
    /// </summary>
    [TerraformPropertyName("valid_threads_per_core")]
    // Output-only attribute - read-only reference
    public TerraformList<double> ValidThreadsPerCore => new TerraformReference(this, "valid_threads_per_core");

}
