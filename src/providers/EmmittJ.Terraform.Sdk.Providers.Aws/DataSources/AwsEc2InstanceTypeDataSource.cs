using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEc2InstanceTypeDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    [TerraformPropertyName("instance_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InstanceType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsEc2InstanceTypeDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The auto_recovery_supported attribute.
    /// </summary>
    [TerraformPropertyName("auto_recovery_supported")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AutoRecoverySupported => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "auto_recovery_supported");

    /// <summary>
    /// The bandwidth_weightings attribute.
    /// </summary>
    [TerraformPropertyName("bandwidth_weightings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> BandwidthWeightings => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "bandwidth_weightings");

    /// <summary>
    /// The bare_metal attribute.
    /// </summary>
    [TerraformPropertyName("bare_metal")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> BareMetal => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "bare_metal");

    /// <summary>
    /// The boot_modes attribute.
    /// </summary>
    [TerraformPropertyName("boot_modes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> BootModes => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "boot_modes");

    /// <summary>
    /// The burstable_performance_supported attribute.
    /// </summary>
    [TerraformPropertyName("burstable_performance_supported")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> BurstablePerformanceSupported => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "burstable_performance_supported");

    /// <summary>
    /// The current_generation attribute.
    /// </summary>
    [TerraformPropertyName("current_generation")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> CurrentGeneration => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "current_generation");

    /// <summary>
    /// The dedicated_hosts_supported attribute.
    /// </summary>
    [TerraformPropertyName("dedicated_hosts_supported")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DedicatedHostsSupported => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "dedicated_hosts_supported");

    /// <summary>
    /// The default_cores attribute.
    /// </summary>
    [TerraformPropertyName("default_cores")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DefaultCores => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "default_cores");

    /// <summary>
    /// The default_network_card_index attribute.
    /// </summary>
    [TerraformPropertyName("default_network_card_index")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DefaultNetworkCardIndex => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "default_network_card_index");

    /// <summary>
    /// The default_threads_per_core attribute.
    /// </summary>
    [TerraformPropertyName("default_threads_per_core")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DefaultThreadsPerCore => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "default_threads_per_core");

    /// <summary>
    /// The default_vcpus attribute.
    /// </summary>
    [TerraformPropertyName("default_vcpus")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DefaultVcpus => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "default_vcpus");

    /// <summary>
    /// The ebs_encryption_support attribute.
    /// </summary>
    [TerraformPropertyName("ebs_encryption_support")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EbsEncryptionSupport => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ebs_encryption_support");

    /// <summary>
    /// The ebs_nvme_support attribute.
    /// </summary>
    [TerraformPropertyName("ebs_nvme_support")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EbsNvmeSupport => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ebs_nvme_support");

    /// <summary>
    /// The ebs_optimized_support attribute.
    /// </summary>
    [TerraformPropertyName("ebs_optimized_support")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EbsOptimizedSupport => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ebs_optimized_support");

    /// <summary>
    /// The ebs_performance_baseline_bandwidth attribute.
    /// </summary>
    [TerraformPropertyName("ebs_performance_baseline_bandwidth")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> EbsPerformanceBaselineBandwidth => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "ebs_performance_baseline_bandwidth");

    /// <summary>
    /// The ebs_performance_baseline_iops attribute.
    /// </summary>
    [TerraformPropertyName("ebs_performance_baseline_iops")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> EbsPerformanceBaselineIops => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "ebs_performance_baseline_iops");

    /// <summary>
    /// The ebs_performance_baseline_throughput attribute.
    /// </summary>
    [TerraformPropertyName("ebs_performance_baseline_throughput")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> EbsPerformanceBaselineThroughput => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "ebs_performance_baseline_throughput");

    /// <summary>
    /// The ebs_performance_maximum_bandwidth attribute.
    /// </summary>
    [TerraformPropertyName("ebs_performance_maximum_bandwidth")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> EbsPerformanceMaximumBandwidth => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "ebs_performance_maximum_bandwidth");

    /// <summary>
    /// The ebs_performance_maximum_iops attribute.
    /// </summary>
    [TerraformPropertyName("ebs_performance_maximum_iops")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> EbsPerformanceMaximumIops => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "ebs_performance_maximum_iops");

    /// <summary>
    /// The ebs_performance_maximum_throughput attribute.
    /// </summary>
    [TerraformPropertyName("ebs_performance_maximum_throughput")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> EbsPerformanceMaximumThroughput => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "ebs_performance_maximum_throughput");

    /// <summary>
    /// The efa_maximum_interfaces attribute.
    /// </summary>
    [TerraformPropertyName("efa_maximum_interfaces")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> EfaMaximumInterfaces => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "efa_maximum_interfaces");

    /// <summary>
    /// The efa_supported attribute.
    /// </summary>
    [TerraformPropertyName("efa_supported")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EfaSupported => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "efa_supported");

    /// <summary>
    /// The ena_srd_supported attribute.
    /// </summary>
    [TerraformPropertyName("ena_srd_supported")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnaSrdSupported => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "ena_srd_supported");

    /// <summary>
    /// The ena_support attribute.
    /// </summary>
    [TerraformPropertyName("ena_support")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EnaSupport => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ena_support");

    /// <summary>
    /// The encryption_in_transit_supported attribute.
    /// </summary>
    [TerraformPropertyName("encryption_in_transit_supported")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EncryptionInTransitSupported => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "encryption_in_transit_supported");

    /// <summary>
    /// The fpgas attribute.
    /// </summary>
    [TerraformPropertyName("fpgas")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> Fpgas => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "fpgas");

    /// <summary>
    /// The free_tier_eligible attribute.
    /// </summary>
    [TerraformPropertyName("free_tier_eligible")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> FreeTierEligible => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "free_tier_eligible");

    /// <summary>
    /// The gpus attribute.
    /// </summary>
    [TerraformPropertyName("gpus")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> Gpus => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "gpus");

    /// <summary>
    /// The hibernation_supported attribute.
    /// </summary>
    [TerraformPropertyName("hibernation_supported")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> HibernationSupported => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "hibernation_supported");

    /// <summary>
    /// The hypervisor attribute.
    /// </summary>
    [TerraformPropertyName("hypervisor")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Hypervisor => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hypervisor");

    /// <summary>
    /// The inference_accelerators attribute.
    /// </summary>
    [TerraformPropertyName("inference_accelerators")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> InferenceAccelerators => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "inference_accelerators");

    /// <summary>
    /// The instance_disks attribute.
    /// </summary>
    [TerraformPropertyName("instance_disks")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> InstanceDisks => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "instance_disks");

    /// <summary>
    /// The instance_storage_supported attribute.
    /// </summary>
    [TerraformPropertyName("instance_storage_supported")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> InstanceStorageSupported => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "instance_storage_supported");

    /// <summary>
    /// The ipv6_supported attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_supported")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Ipv6Supported => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "ipv6_supported");

    /// <summary>
    /// The maximum_ipv4_addresses_per_interface attribute.
    /// </summary>
    [TerraformPropertyName("maximum_ipv4_addresses_per_interface")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaximumIpv4AddressesPerInterface => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "maximum_ipv4_addresses_per_interface");

    /// <summary>
    /// The maximum_ipv6_addresses_per_interface attribute.
    /// </summary>
    [TerraformPropertyName("maximum_ipv6_addresses_per_interface")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaximumIpv6AddressesPerInterface => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "maximum_ipv6_addresses_per_interface");

    /// <summary>
    /// The maximum_network_cards attribute.
    /// </summary>
    [TerraformPropertyName("maximum_network_cards")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaximumNetworkCards => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "maximum_network_cards");

    /// <summary>
    /// The maximum_network_interfaces attribute.
    /// </summary>
    [TerraformPropertyName("maximum_network_interfaces")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaximumNetworkInterfaces => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "maximum_network_interfaces");

    /// <summary>
    /// The media_accelerators attribute.
    /// </summary>
    [TerraformPropertyName("media_accelerators")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> MediaAccelerators => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "media_accelerators");

    /// <summary>
    /// The memory_size attribute.
    /// </summary>
    [TerraformPropertyName("memory_size")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MemorySize => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "memory_size");

    /// <summary>
    /// The network_cards attribute.
    /// </summary>
    [TerraformPropertyName("network_cards")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> NetworkCards => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "network_cards");

    /// <summary>
    /// The network_performance attribute.
    /// </summary>
    [TerraformPropertyName("network_performance")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NetworkPerformance => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_performance");

    /// <summary>
    /// The neuron_devices attribute.
    /// </summary>
    [TerraformPropertyName("neuron_devices")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> NeuronDevices => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "neuron_devices");

    /// <summary>
    /// The nitro_enclaves_support attribute.
    /// </summary>
    [TerraformPropertyName("nitro_enclaves_support")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NitroEnclavesSupport => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "nitro_enclaves_support");

    /// <summary>
    /// The nitro_tpm_support attribute.
    /// </summary>
    [TerraformPropertyName("nitro_tpm_support")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NitroTpmSupport => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "nitro_tpm_support");

    /// <summary>
    /// The nitro_tpm_supported_versions attribute.
    /// </summary>
    [TerraformPropertyName("nitro_tpm_supported_versions")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> NitroTpmSupportedVersions => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "nitro_tpm_supported_versions");

    /// <summary>
    /// The phc_support attribute.
    /// </summary>
    [TerraformPropertyName("phc_support")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PhcSupport => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "phc_support");

    /// <summary>
    /// The supported_architectures attribute.
    /// </summary>
    [TerraformPropertyName("supported_architectures")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> SupportedArchitectures => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "supported_architectures");

    /// <summary>
    /// The supported_cpu_features attribute.
    /// </summary>
    [TerraformPropertyName("supported_cpu_features")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> SupportedCpuFeatures => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "supported_cpu_features");

    /// <summary>
    /// The supported_placement_strategies attribute.
    /// </summary>
    [TerraformPropertyName("supported_placement_strategies")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> SupportedPlacementStrategies => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "supported_placement_strategies");

    /// <summary>
    /// The supported_root_device_types attribute.
    /// </summary>
    [TerraformPropertyName("supported_root_device_types")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> SupportedRootDeviceTypes => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "supported_root_device_types");

    /// <summary>
    /// The supported_usages_classes attribute.
    /// </summary>
    [TerraformPropertyName("supported_usages_classes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> SupportedUsagesClasses => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "supported_usages_classes");

    /// <summary>
    /// The supported_virtualization_types attribute.
    /// </summary>
    [TerraformPropertyName("supported_virtualization_types")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> SupportedVirtualizationTypes => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "supported_virtualization_types");

    /// <summary>
    /// The sustained_clock_speed attribute.
    /// </summary>
    [TerraformPropertyName("sustained_clock_speed")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> SustainedClockSpeed => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "sustained_clock_speed");

    /// <summary>
    /// The total_fpga_memory attribute.
    /// </summary>
    [TerraformPropertyName("total_fpga_memory")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> TotalFpgaMemory => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "total_fpga_memory");

    /// <summary>
    /// The total_gpu_memory attribute.
    /// </summary>
    [TerraformPropertyName("total_gpu_memory")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> TotalGpuMemory => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "total_gpu_memory");

    /// <summary>
    /// The total_inference_memory attribute.
    /// </summary>
    [TerraformPropertyName("total_inference_memory")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> TotalInferenceMemory => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "total_inference_memory");

    /// <summary>
    /// The total_instance_storage attribute.
    /// </summary>
    [TerraformPropertyName("total_instance_storage")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> TotalInstanceStorage => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "total_instance_storage");

    /// <summary>
    /// The total_media_memory attribute.
    /// </summary>
    [TerraformPropertyName("total_media_memory")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> TotalMediaMemory => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "total_media_memory");

    /// <summary>
    /// The total_neuron_device_memory attribute.
    /// </summary>
    [TerraformPropertyName("total_neuron_device_memory")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> TotalNeuronDeviceMemory => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "total_neuron_device_memory");

    /// <summary>
    /// The valid_cores attribute.
    /// </summary>
    [TerraformPropertyName("valid_cores")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<double>>> ValidCores => new TerraformReferenceProperty<List<TerraformProperty<double>>>(ResourceAddress, "valid_cores");

    /// <summary>
    /// The valid_threads_per_core attribute.
    /// </summary>
    [TerraformPropertyName("valid_threads_per_core")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<double>>> ValidThreadsPerCore => new TerraformReferenceProperty<List<TerraformProperty<double>>>(ResourceAddress, "valid_threads_per_core");

}
