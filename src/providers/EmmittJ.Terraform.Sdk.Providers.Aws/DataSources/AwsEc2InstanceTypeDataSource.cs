using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEc2InstanceTypeDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a aws_ec2_instance_type.
/// </summary>
public class AwsEc2InstanceTypeDataSource : TerraformDataSource
{
    public AwsEc2InstanceTypeDataSource(string name) : base("aws_ec2_instance_type", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("auto_recovery_supported");
        this.WithOutput("bandwidth_weightings");
        this.WithOutput("bare_metal");
        this.WithOutput("boot_modes");
        this.WithOutput("burstable_performance_supported");
        this.WithOutput("current_generation");
        this.WithOutput("dedicated_hosts_supported");
        this.WithOutput("default_cores");
        this.WithOutput("default_network_card_index");
        this.WithOutput("default_threads_per_core");
        this.WithOutput("default_vcpus");
        this.WithOutput("ebs_encryption_support");
        this.WithOutput("ebs_nvme_support");
        this.WithOutput("ebs_optimized_support");
        this.WithOutput("ebs_performance_baseline_bandwidth");
        this.WithOutput("ebs_performance_baseline_iops");
        this.WithOutput("ebs_performance_baseline_throughput");
        this.WithOutput("ebs_performance_maximum_bandwidth");
        this.WithOutput("ebs_performance_maximum_iops");
        this.WithOutput("ebs_performance_maximum_throughput");
        this.WithOutput("efa_maximum_interfaces");
        this.WithOutput("efa_supported");
        this.WithOutput("ena_srd_supported");
        this.WithOutput("ena_support");
        this.WithOutput("encryption_in_transit_supported");
        this.WithOutput("fpgas");
        this.WithOutput("free_tier_eligible");
        this.WithOutput("gpus");
        this.WithOutput("hibernation_supported");
        this.WithOutput("hypervisor");
        this.WithOutput("inference_accelerators");
        this.WithOutput("instance_disks");
        this.WithOutput("instance_storage_supported");
        this.WithOutput("ipv6_supported");
        this.WithOutput("maximum_ipv4_addresses_per_interface");
        this.WithOutput("maximum_ipv6_addresses_per_interface");
        this.WithOutput("maximum_network_cards");
        this.WithOutput("maximum_network_interfaces");
        this.WithOutput("media_accelerators");
        this.WithOutput("memory_size");
        this.WithOutput("network_cards");
        this.WithOutput("network_performance");
        this.WithOutput("neuron_devices");
        this.WithOutput("nitro_enclaves_support");
        this.WithOutput("nitro_tpm_support");
        this.WithOutput("nitro_tpm_supported_versions");
        this.WithOutput("phc_support");
        this.WithOutput("supported_architectures");
        this.WithOutput("supported_cpu_features");
        this.WithOutput("supported_placement_strategies");
        this.WithOutput("supported_root_device_types");
        this.WithOutput("supported_usages_classes");
        this.WithOutput("supported_virtualization_types");
        this.WithOutput("sustained_clock_speed");
        this.WithOutput("total_fpga_memory");
        this.WithOutput("total_gpu_memory");
        this.WithOutput("total_inference_memory");
        this.WithOutput("total_instance_storage");
        this.WithOutput("total_media_memory");
        this.WithOutput("total_neuron_device_memory");
        this.WithOutput("valid_cores");
        this.WithOutput("valid_threads_per_core");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformProperty<string> InstanceType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("instance_type");
        set => this.WithProperty("instance_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEc2InstanceTypeDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsEc2InstanceTypeDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The auto_recovery_supported attribute.
    /// </summary>
    public TerraformExpression AutoRecoverySupported => this["auto_recovery_supported"];

    /// <summary>
    /// The bandwidth_weightings attribute.
    /// </summary>
    public TerraformExpression BandwidthWeightings => this["bandwidth_weightings"];

    /// <summary>
    /// The bare_metal attribute.
    /// </summary>
    public TerraformExpression BareMetal => this["bare_metal"];

    /// <summary>
    /// The boot_modes attribute.
    /// </summary>
    public TerraformExpression BootModes => this["boot_modes"];

    /// <summary>
    /// The burstable_performance_supported attribute.
    /// </summary>
    public TerraformExpression BurstablePerformanceSupported => this["burstable_performance_supported"];

    /// <summary>
    /// The current_generation attribute.
    /// </summary>
    public TerraformExpression CurrentGeneration => this["current_generation"];

    /// <summary>
    /// The dedicated_hosts_supported attribute.
    /// </summary>
    public TerraformExpression DedicatedHostsSupported => this["dedicated_hosts_supported"];

    /// <summary>
    /// The default_cores attribute.
    /// </summary>
    public TerraformExpression DefaultCores => this["default_cores"];

    /// <summary>
    /// The default_network_card_index attribute.
    /// </summary>
    public TerraformExpression DefaultNetworkCardIndex => this["default_network_card_index"];

    /// <summary>
    /// The default_threads_per_core attribute.
    /// </summary>
    public TerraformExpression DefaultThreadsPerCore => this["default_threads_per_core"];

    /// <summary>
    /// The default_vcpus attribute.
    /// </summary>
    public TerraformExpression DefaultVcpus => this["default_vcpus"];

    /// <summary>
    /// The ebs_encryption_support attribute.
    /// </summary>
    public TerraformExpression EbsEncryptionSupport => this["ebs_encryption_support"];

    /// <summary>
    /// The ebs_nvme_support attribute.
    /// </summary>
    public TerraformExpression EbsNvmeSupport => this["ebs_nvme_support"];

    /// <summary>
    /// The ebs_optimized_support attribute.
    /// </summary>
    public TerraformExpression EbsOptimizedSupport => this["ebs_optimized_support"];

    /// <summary>
    /// The ebs_performance_baseline_bandwidth attribute.
    /// </summary>
    public TerraformExpression EbsPerformanceBaselineBandwidth => this["ebs_performance_baseline_bandwidth"];

    /// <summary>
    /// The ebs_performance_baseline_iops attribute.
    /// </summary>
    public TerraformExpression EbsPerformanceBaselineIops => this["ebs_performance_baseline_iops"];

    /// <summary>
    /// The ebs_performance_baseline_throughput attribute.
    /// </summary>
    public TerraformExpression EbsPerformanceBaselineThroughput => this["ebs_performance_baseline_throughput"];

    /// <summary>
    /// The ebs_performance_maximum_bandwidth attribute.
    /// </summary>
    public TerraformExpression EbsPerformanceMaximumBandwidth => this["ebs_performance_maximum_bandwidth"];

    /// <summary>
    /// The ebs_performance_maximum_iops attribute.
    /// </summary>
    public TerraformExpression EbsPerformanceMaximumIops => this["ebs_performance_maximum_iops"];

    /// <summary>
    /// The ebs_performance_maximum_throughput attribute.
    /// </summary>
    public TerraformExpression EbsPerformanceMaximumThroughput => this["ebs_performance_maximum_throughput"];

    /// <summary>
    /// The efa_maximum_interfaces attribute.
    /// </summary>
    public TerraformExpression EfaMaximumInterfaces => this["efa_maximum_interfaces"];

    /// <summary>
    /// The efa_supported attribute.
    /// </summary>
    public TerraformExpression EfaSupported => this["efa_supported"];

    /// <summary>
    /// The ena_srd_supported attribute.
    /// </summary>
    public TerraformExpression EnaSrdSupported => this["ena_srd_supported"];

    /// <summary>
    /// The ena_support attribute.
    /// </summary>
    public TerraformExpression EnaSupport => this["ena_support"];

    /// <summary>
    /// The encryption_in_transit_supported attribute.
    /// </summary>
    public TerraformExpression EncryptionInTransitSupported => this["encryption_in_transit_supported"];

    /// <summary>
    /// The fpgas attribute.
    /// </summary>
    public TerraformExpression Fpgas => this["fpgas"];

    /// <summary>
    /// The free_tier_eligible attribute.
    /// </summary>
    public TerraformExpression FreeTierEligible => this["free_tier_eligible"];

    /// <summary>
    /// The gpus attribute.
    /// </summary>
    public TerraformExpression Gpus => this["gpus"];

    /// <summary>
    /// The hibernation_supported attribute.
    /// </summary>
    public TerraformExpression HibernationSupported => this["hibernation_supported"];

    /// <summary>
    /// The hypervisor attribute.
    /// </summary>
    public TerraformExpression Hypervisor => this["hypervisor"];

    /// <summary>
    /// The inference_accelerators attribute.
    /// </summary>
    public TerraformExpression InferenceAccelerators => this["inference_accelerators"];

    /// <summary>
    /// The instance_disks attribute.
    /// </summary>
    public TerraformExpression InstanceDisks => this["instance_disks"];

    /// <summary>
    /// The instance_storage_supported attribute.
    /// </summary>
    public TerraformExpression InstanceStorageSupported => this["instance_storage_supported"];

    /// <summary>
    /// The ipv6_supported attribute.
    /// </summary>
    public TerraformExpression Ipv6Supported => this["ipv6_supported"];

    /// <summary>
    /// The maximum_ipv4_addresses_per_interface attribute.
    /// </summary>
    public TerraformExpression MaximumIpv4AddressesPerInterface => this["maximum_ipv4_addresses_per_interface"];

    /// <summary>
    /// The maximum_ipv6_addresses_per_interface attribute.
    /// </summary>
    public TerraformExpression MaximumIpv6AddressesPerInterface => this["maximum_ipv6_addresses_per_interface"];

    /// <summary>
    /// The maximum_network_cards attribute.
    /// </summary>
    public TerraformExpression MaximumNetworkCards => this["maximum_network_cards"];

    /// <summary>
    /// The maximum_network_interfaces attribute.
    /// </summary>
    public TerraformExpression MaximumNetworkInterfaces => this["maximum_network_interfaces"];

    /// <summary>
    /// The media_accelerators attribute.
    /// </summary>
    public TerraformExpression MediaAccelerators => this["media_accelerators"];

    /// <summary>
    /// The memory_size attribute.
    /// </summary>
    public TerraformExpression MemorySize => this["memory_size"];

    /// <summary>
    /// The network_cards attribute.
    /// </summary>
    public TerraformExpression NetworkCards => this["network_cards"];

    /// <summary>
    /// The network_performance attribute.
    /// </summary>
    public TerraformExpression NetworkPerformance => this["network_performance"];

    /// <summary>
    /// The neuron_devices attribute.
    /// </summary>
    public TerraformExpression NeuronDevices => this["neuron_devices"];

    /// <summary>
    /// The nitro_enclaves_support attribute.
    /// </summary>
    public TerraformExpression NitroEnclavesSupport => this["nitro_enclaves_support"];

    /// <summary>
    /// The nitro_tpm_support attribute.
    /// </summary>
    public TerraformExpression NitroTpmSupport => this["nitro_tpm_support"];

    /// <summary>
    /// The nitro_tpm_supported_versions attribute.
    /// </summary>
    public TerraformExpression NitroTpmSupportedVersions => this["nitro_tpm_supported_versions"];

    /// <summary>
    /// The phc_support attribute.
    /// </summary>
    public TerraformExpression PhcSupport => this["phc_support"];

    /// <summary>
    /// The supported_architectures attribute.
    /// </summary>
    public TerraformExpression SupportedArchitectures => this["supported_architectures"];

    /// <summary>
    /// The supported_cpu_features attribute.
    /// </summary>
    public TerraformExpression SupportedCpuFeatures => this["supported_cpu_features"];

    /// <summary>
    /// The supported_placement_strategies attribute.
    /// </summary>
    public TerraformExpression SupportedPlacementStrategies => this["supported_placement_strategies"];

    /// <summary>
    /// The supported_root_device_types attribute.
    /// </summary>
    public TerraformExpression SupportedRootDeviceTypes => this["supported_root_device_types"];

    /// <summary>
    /// The supported_usages_classes attribute.
    /// </summary>
    public TerraformExpression SupportedUsagesClasses => this["supported_usages_classes"];

    /// <summary>
    /// The supported_virtualization_types attribute.
    /// </summary>
    public TerraformExpression SupportedVirtualizationTypes => this["supported_virtualization_types"];

    /// <summary>
    /// The sustained_clock_speed attribute.
    /// </summary>
    public TerraformExpression SustainedClockSpeed => this["sustained_clock_speed"];

    /// <summary>
    /// The total_fpga_memory attribute.
    /// </summary>
    public TerraformExpression TotalFpgaMemory => this["total_fpga_memory"];

    /// <summary>
    /// The total_gpu_memory attribute.
    /// </summary>
    public TerraformExpression TotalGpuMemory => this["total_gpu_memory"];

    /// <summary>
    /// The total_inference_memory attribute.
    /// </summary>
    public TerraformExpression TotalInferenceMemory => this["total_inference_memory"];

    /// <summary>
    /// The total_instance_storage attribute.
    /// </summary>
    public TerraformExpression TotalInstanceStorage => this["total_instance_storage"];

    /// <summary>
    /// The total_media_memory attribute.
    /// </summary>
    public TerraformExpression TotalMediaMemory => this["total_media_memory"];

    /// <summary>
    /// The total_neuron_device_memory attribute.
    /// </summary>
    public TerraformExpression TotalNeuronDeviceMemory => this["total_neuron_device_memory"];

    /// <summary>
    /// The valid_cores attribute.
    /// </summary>
    public TerraformExpression ValidCores => this["valid_cores"];

    /// <summary>
    /// The valid_threads_per_core attribute.
    /// </summary>
    public TerraformExpression ValidThreadsPerCore => this["valid_threads_per_core"];

}
