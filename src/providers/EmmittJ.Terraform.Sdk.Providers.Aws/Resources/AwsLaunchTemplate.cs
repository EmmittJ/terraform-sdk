using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for block_device_mappings in .
/// Nesting mode: list
/// </summary>
public partial class AwsLaunchTemplateBlockDeviceMappingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [TerraformProperty("device_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DeviceName { get; set; }

    /// <summary>
    /// The no_device attribute.
    /// </summary>
    [TerraformProperty("no_device")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? NoDevice { get; set; }

    /// <summary>
    /// The virtual_name attribute.
    /// </summary>
    [TerraformProperty("virtual_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? VirtualName { get; set; }

}

/// <summary>
/// Block type for capacity_reservation_specification in .
/// Nesting mode: list
/// </summary>
public partial class AwsLaunchTemplateCapacityReservationSpecificationBlock : TerraformBlockBase
{
    /// <summary>
    /// The capacity_reservation_preference attribute.
    /// </summary>
    [TerraformProperty("capacity_reservation_preference")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CapacityReservationPreference { get; set; }

}

/// <summary>
/// Block type for cpu_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsLaunchTemplateCpuOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The amd_sev_snp attribute.
    /// </summary>
    [TerraformProperty("amd_sev_snp")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AmdSevSnp { get; set; }

    /// <summary>
    /// The core_count attribute.
    /// </summary>
    [TerraformProperty("core_count")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? CoreCount { get; set; }

    /// <summary>
    /// The threads_per_core attribute.
    /// </summary>
    [TerraformProperty("threads_per_core")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? ThreadsPerCore { get; set; }

}

/// <summary>
/// Block type for credit_specification in .
/// Nesting mode: list
/// </summary>
public partial class AwsLaunchTemplateCreditSpecificationBlock : TerraformBlockBase
{
    /// <summary>
    /// The cpu_credits attribute.
    /// </summary>
    [TerraformProperty("cpu_credits")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CpuCredits { get; set; }

}

/// <summary>
/// Block type for enclave_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsLaunchTemplateEnclaveOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

}

/// <summary>
/// Block type for hibernation_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsLaunchTemplateHibernationOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The configured attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Configured is required")]
    [TerraformProperty("configured")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Configured { get; set; }

}

/// <summary>
/// Block type for iam_instance_profile in .
/// Nesting mode: list
/// </summary>
public partial class AwsLaunchTemplateIamInstanceProfileBlock : TerraformBlockBase
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Arn { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Name { get; set; }

}

/// <summary>
/// Block type for instance_market_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsLaunchTemplateInstanceMarketOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The market_type attribute.
    /// </summary>
    [TerraformProperty("market_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MarketType { get; set; }

}

/// <summary>
/// Block type for instance_requirements in .
/// Nesting mode: list
/// </summary>
public partial class AwsLaunchTemplateInstanceRequirementsBlock : TerraformBlockBase
{
    /// <summary>
    /// The accelerator_manufacturers attribute.
    /// </summary>
    [TerraformProperty("accelerator_manufacturers")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? AcceleratorManufacturers { get; set; }

    /// <summary>
    /// The accelerator_names attribute.
    /// </summary>
    [TerraformProperty("accelerator_names")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? AcceleratorNames { get; set; }

    /// <summary>
    /// The accelerator_types attribute.
    /// </summary>
    [TerraformProperty("accelerator_types")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? AcceleratorTypes { get; set; }

    /// <summary>
    /// The allowed_instance_types attribute.
    /// </summary>
    [TerraformProperty("allowed_instance_types")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? AllowedInstanceTypes { get; set; }

    /// <summary>
    /// The bare_metal attribute.
    /// </summary>
    [TerraformProperty("bare_metal")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? BareMetal { get; set; }

    /// <summary>
    /// The burstable_performance attribute.
    /// </summary>
    [TerraformProperty("burstable_performance")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? BurstablePerformance { get; set; }

    /// <summary>
    /// The cpu_manufacturers attribute.
    /// </summary>
    [TerraformProperty("cpu_manufacturers")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? CpuManufacturers { get; set; }

    /// <summary>
    /// The excluded_instance_types attribute.
    /// </summary>
    [TerraformProperty("excluded_instance_types")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? ExcludedInstanceTypes { get; set; }

    /// <summary>
    /// The instance_generations attribute.
    /// </summary>
    [TerraformProperty("instance_generations")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? InstanceGenerations { get; set; }

    /// <summary>
    /// The local_storage attribute.
    /// </summary>
    [TerraformProperty("local_storage")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? LocalStorage { get; set; }

    /// <summary>
    /// The local_storage_types attribute.
    /// </summary>
    [TerraformProperty("local_storage_types")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? LocalStorageTypes { get; set; }

    /// <summary>
    /// The max_spot_price_as_percentage_of_optimal_on_demand_price attribute.
    /// </summary>
    [TerraformProperty("max_spot_price_as_percentage_of_optimal_on_demand_price")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxSpotPriceAsPercentageOfOptimalOnDemandPrice { get; set; }

    /// <summary>
    /// The on_demand_max_price_percentage_over_lowest_price attribute.
    /// </summary>
    [TerraformProperty("on_demand_max_price_percentage_over_lowest_price")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? OnDemandMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>
    /// The require_hibernate_support attribute.
    /// </summary>
    [TerraformProperty("require_hibernate_support")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RequireHibernateSupport { get; set; }

    /// <summary>
    /// The spot_max_price_percentage_over_lowest_price attribute.
    /// </summary>
    [TerraformProperty("spot_max_price_percentage_over_lowest_price")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? SpotMaxPricePercentageOverLowestPrice { get; set; }

}

/// <summary>
/// Block type for license_specification in .
/// Nesting mode: set
/// </summary>
public partial class AwsLaunchTemplateLicenseSpecificationBlock : TerraformBlockBase
{
    /// <summary>
    /// The license_configuration_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseConfigurationArn is required")]
    [TerraformProperty("license_configuration_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LicenseConfigurationArn { get; set; }

}

/// <summary>
/// Block type for maintenance_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsLaunchTemplateMaintenanceOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The auto_recovery attribute.
    /// </summary>
    [TerraformProperty("auto_recovery")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AutoRecovery { get; set; }

}

/// <summary>
/// Block type for metadata_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsLaunchTemplateMetadataOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The http_endpoint attribute.
    /// </summary>
    [TerraformProperty("http_endpoint")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> HttpEndpoint { get; set; }

    /// <summary>
    /// The http_protocol_ipv6 attribute.
    /// </summary>
    [TerraformProperty("http_protocol_ipv6")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> HttpProtocolIpv6 { get; set; }

    /// <summary>
    /// The http_put_response_hop_limit attribute.
    /// </summary>
    [TerraformProperty("http_put_response_hop_limit")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> HttpPutResponseHopLimit { get; set; }

    /// <summary>
    /// The http_tokens attribute.
    /// </summary>
    [TerraformProperty("http_tokens")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> HttpTokens { get; set; }

    /// <summary>
    /// The instance_metadata_tags attribute.
    /// </summary>
    [TerraformProperty("instance_metadata_tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> InstanceMetadataTags { get; set; }

}

/// <summary>
/// Block type for monitoring in .
/// Nesting mode: list
/// </summary>
public partial class AwsLaunchTemplateMonitoringBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

}

/// <summary>
/// Block type for network_interfaces in .
/// Nesting mode: list
/// </summary>
public partial class AwsLaunchTemplateNetworkInterfacesBlock : TerraformBlockBase
{
    /// <summary>
    /// The associate_carrier_ip_address attribute.
    /// </summary>
    [TerraformProperty("associate_carrier_ip_address")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AssociateCarrierIpAddress { get; set; }

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    [TerraformProperty("associate_public_ip_address")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AssociatePublicIpAddress { get; set; }

    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    [TerraformProperty("delete_on_termination")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DeleteOnTermination { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The device_index attribute.
    /// </summary>
    [TerraformProperty("device_index")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? DeviceIndex { get; set; }

    /// <summary>
    /// The interface_type attribute.
    /// </summary>
    [TerraformProperty("interface_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? InterfaceType { get; set; }

    /// <summary>
    /// The ipv4_address_count attribute.
    /// </summary>
    [TerraformProperty("ipv4_address_count")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Ipv4AddressCount { get; set; }

    /// <summary>
    /// The ipv4_addresses attribute.
    /// </summary>
    [TerraformProperty("ipv4_addresses")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Ipv4Addresses { get; set; }

    /// <summary>
    /// The ipv4_prefix_count attribute.
    /// </summary>
    [TerraformProperty("ipv4_prefix_count")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Ipv4PrefixCount { get; set; }

    /// <summary>
    /// The ipv4_prefixes attribute.
    /// </summary>
    [TerraformProperty("ipv4_prefixes")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Ipv4Prefixes { get; set; }

    /// <summary>
    /// The ipv6_address_count attribute.
    /// </summary>
    [TerraformProperty("ipv6_address_count")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Ipv6AddressCount { get; set; }

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    [TerraformProperty("ipv6_addresses")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Ipv6Addresses { get; set; }

    /// <summary>
    /// The ipv6_prefix_count attribute.
    /// </summary>
    [TerraformProperty("ipv6_prefix_count")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Ipv6PrefixCount { get; set; }

    /// <summary>
    /// The ipv6_prefixes attribute.
    /// </summary>
    [TerraformProperty("ipv6_prefixes")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Ipv6Prefixes { get; set; }

    /// <summary>
    /// The network_card_index attribute.
    /// </summary>
    [TerraformProperty("network_card_index")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? NetworkCardIndex { get; set; }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [TerraformProperty("network_interface_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? NetworkInterfaceId { get; set; }

    /// <summary>
    /// The primary_ipv6 attribute.
    /// </summary>
    [TerraformProperty("primary_ipv6")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PrimaryIpv6 { get; set; }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [TerraformProperty("private_ip_address")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PrivateIpAddress { get; set; }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformProperty("security_groups")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? SecurityGroups { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformProperty("subnet_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SubnetId { get; set; }

}

/// <summary>
/// Block type for placement in .
/// Nesting mode: list
/// </summary>
public partial class AwsLaunchTemplatePlacementBlock : TerraformBlockBase
{
    /// <summary>
    /// The affinity attribute.
    /// </summary>
    [TerraformProperty("affinity")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Affinity { get; set; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformProperty("availability_zone")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AvailabilityZone { get; set; }

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    [TerraformProperty("group_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? GroupId { get; set; }

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    [TerraformProperty("group_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? GroupName { get; set; }

    /// <summary>
    /// The host_id attribute.
    /// </summary>
    [TerraformProperty("host_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? HostId { get; set; }

    /// <summary>
    /// The host_resource_group_arn attribute.
    /// </summary>
    [TerraformProperty("host_resource_group_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? HostResourceGroupArn { get; set; }

    /// <summary>
    /// The partition_number attribute.
    /// </summary>
    [TerraformProperty("partition_number")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? PartitionNumber { get; set; }

    /// <summary>
    /// The spread_domain attribute.
    /// </summary>
    [TerraformProperty("spread_domain")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SpreadDomain { get; set; }

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    [TerraformProperty("tenancy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Tenancy { get; set; }

}

/// <summary>
/// Block type for private_dns_name_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsLaunchTemplatePrivateDnsNameOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The enable_resource_name_dns_a_record attribute.
    /// </summary>
    [TerraformProperty("enable_resource_name_dns_a_record")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableResourceNameDnsARecord { get; set; }

    /// <summary>
    /// The enable_resource_name_dns_aaaa_record attribute.
    /// </summary>
    [TerraformProperty("enable_resource_name_dns_aaaa_record")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableResourceNameDnsAaaaRecord { get; set; }

    /// <summary>
    /// The hostname_type attribute.
    /// </summary>
    [TerraformProperty("hostname_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? HostnameType { get; set; }

}

/// <summary>
/// Block type for tag_specifications in .
/// Nesting mode: list
/// </summary>
public partial class AwsLaunchTemplateTagSpecificationsBlock : TerraformBlockBase
{
    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [TerraformProperty("resource_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ResourceType { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

}

/// <summary>
/// Manages a aws_launch_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsLaunchTemplate : TerraformResource
{
    public AwsLaunchTemplate(string name) : base("aws_launch_template", name)
    {
    }

    /// <summary>
    /// The default_version attribute.
    /// </summary>
    [TerraformProperty("default_version")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> DefaultVersion { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The disable_api_stop attribute.
    /// </summary>
    [TerraformProperty("disable_api_stop")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DisableApiStop { get; set; }

    /// <summary>
    /// The disable_api_termination attribute.
    /// </summary>
    [TerraformProperty("disable_api_termination")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DisableApiTermination { get; set; }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    [TerraformProperty("ebs_optimized")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EbsOptimized { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    [TerraformProperty("image_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ImageId { get; set; }

    /// <summary>
    /// The instance_initiated_shutdown_behavior attribute.
    /// </summary>
    [TerraformProperty("instance_initiated_shutdown_behavior")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? InstanceInitiatedShutdownBehavior { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformProperty("instance_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? InstanceType { get; set; }

    /// <summary>
    /// The kernel_id attribute.
    /// </summary>
    [TerraformProperty("kernel_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KernelId { get; set; }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    [TerraformProperty("key_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KeyName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformProperty("name_prefix")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> NamePrefix { get; set; }

    /// <summary>
    /// The ram_disk_id attribute.
    /// </summary>
    [TerraformProperty("ram_disk_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RamDiskId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The security_group_names attribute.
    /// </summary>
    [TerraformProperty("security_group_names")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? SecurityGroupNames { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The update_default_version attribute.
    /// </summary>
    [TerraformProperty("update_default_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? UpdateDefaultVersion { get; set; }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    [TerraformProperty("user_data")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? UserData { get; set; }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformProperty("vpc_security_group_ids")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? VpcSecurityGroupIds { get; set; }

    /// <summary>
    /// Block for block_device_mappings.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("block_device_mappings")]
    public TerraformList<TerraformBlock<AwsLaunchTemplateBlockDeviceMappingsBlock>>? BlockDeviceMappings { get; set; }

    /// <summary>
    /// Block for capacity_reservation_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityReservationSpecification block(s) allowed")]
    [TerraformProperty("capacity_reservation_specification")]
    public TerraformList<TerraformBlock<AwsLaunchTemplateCapacityReservationSpecificationBlock>>? CapacityReservationSpecification { get; set; }

    /// <summary>
    /// Block for cpu_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CpuOptions block(s) allowed")]
    [TerraformProperty("cpu_options")]
    public TerraformList<TerraformBlock<AwsLaunchTemplateCpuOptionsBlock>>? CpuOptions { get; set; }

    /// <summary>
    /// Block for credit_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CreditSpecification block(s) allowed")]
    [TerraformProperty("credit_specification")]
    public TerraformList<TerraformBlock<AwsLaunchTemplateCreditSpecificationBlock>>? CreditSpecification { get; set; }

    /// <summary>
    /// Block for enclave_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnclaveOptions block(s) allowed")]
    [TerraformProperty("enclave_options")]
    public TerraformList<TerraformBlock<AwsLaunchTemplateEnclaveOptionsBlock>>? EnclaveOptions { get; set; }

    /// <summary>
    /// Block for hibernation_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HibernationOptions block(s) allowed")]
    [TerraformProperty("hibernation_options")]
    public TerraformList<TerraformBlock<AwsLaunchTemplateHibernationOptionsBlock>>? HibernationOptions { get; set; }

    /// <summary>
    /// Block for iam_instance_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IamInstanceProfile block(s) allowed")]
    [TerraformProperty("iam_instance_profile")]
    public TerraformList<TerraformBlock<AwsLaunchTemplateIamInstanceProfileBlock>>? IamInstanceProfile { get; set; }

    /// <summary>
    /// Block for instance_market_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceMarketOptions block(s) allowed")]
    [TerraformProperty("instance_market_options")]
    public TerraformList<TerraformBlock<AwsLaunchTemplateInstanceMarketOptionsBlock>>? InstanceMarketOptions { get; set; }

    /// <summary>
    /// Block for instance_requirements.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceRequirements block(s) allowed")]
    [TerraformProperty("instance_requirements")]
    public TerraformList<TerraformBlock<AwsLaunchTemplateInstanceRequirementsBlock>>? InstanceRequirements { get; set; }

    /// <summary>
    /// Block for license_specification.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("license_specification")]
    public TerraformSet<TerraformBlock<AwsLaunchTemplateLicenseSpecificationBlock>>? LicenseSpecification { get; set; }

    /// <summary>
    /// Block for maintenance_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceOptions block(s) allowed")]
    [TerraformProperty("maintenance_options")]
    public TerraformList<TerraformBlock<AwsLaunchTemplateMaintenanceOptionsBlock>>? MaintenanceOptions { get; set; }

    /// <summary>
    /// Block for metadata_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetadataOptions block(s) allowed")]
    [TerraformProperty("metadata_options")]
    public TerraformList<TerraformBlock<AwsLaunchTemplateMetadataOptionsBlock>>? MetadataOptions { get; set; }

    /// <summary>
    /// Block for monitoring.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Monitoring block(s) allowed")]
    [TerraformProperty("monitoring")]
    public TerraformList<TerraformBlock<AwsLaunchTemplateMonitoringBlock>>? Monitoring { get; set; }

    /// <summary>
    /// Block for network_interfaces.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("network_interfaces")]
    public TerraformList<TerraformBlock<AwsLaunchTemplateNetworkInterfacesBlock>>? NetworkInterfaces { get; set; }

    /// <summary>
    /// Block for placement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Placement block(s) allowed")]
    [TerraformProperty("placement")]
    public TerraformList<TerraformBlock<AwsLaunchTemplatePlacementBlock>>? Placement { get; set; }

    /// <summary>
    /// Block for private_dns_name_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateDnsNameOptions block(s) allowed")]
    [TerraformProperty("private_dns_name_options")]
    public TerraformList<TerraformBlock<AwsLaunchTemplatePrivateDnsNameOptionsBlock>>? PrivateDnsNameOptions { get; set; }

    /// <summary>
    /// Block for tag_specifications.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("tag_specifications")]
    public TerraformList<TerraformBlock<AwsLaunchTemplateTagSpecificationsBlock>>? TagSpecifications { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The latest_version attribute.
    /// </summary>
    [TerraformProperty("latest_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> LatestVersion { get; }

}
