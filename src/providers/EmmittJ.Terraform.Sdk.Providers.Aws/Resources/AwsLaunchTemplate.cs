using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for block_device_mappings in .
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateBlockDeviceMappingsBlock
{
    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [TerraformPropertyName("device_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DeviceName { get; set; }

    /// <summary>
    /// The no_device attribute.
    /// </summary>
    [TerraformPropertyName("no_device")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NoDevice { get; set; }

    /// <summary>
    /// The virtual_name attribute.
    /// </summary>
    [TerraformPropertyName("virtual_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VirtualName { get; set; }

}

/// <summary>
/// Block type for capacity_reservation_specification in .
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateCapacityReservationSpecificationBlock
{
    /// <summary>
    /// The capacity_reservation_preference attribute.
    /// </summary>
    [TerraformPropertyName("capacity_reservation_preference")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CapacityReservationPreference { get; set; }

}

/// <summary>
/// Block type for cpu_options in .
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateCpuOptionsBlock
{
    /// <summary>
    /// The amd_sev_snp attribute.
    /// </summary>
    [TerraformPropertyName("amd_sev_snp")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AmdSevSnp { get; set; }

    /// <summary>
    /// The core_count attribute.
    /// </summary>
    [TerraformPropertyName("core_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? CoreCount { get; set; }

    /// <summary>
    /// The threads_per_core attribute.
    /// </summary>
    [TerraformPropertyName("threads_per_core")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ThreadsPerCore { get; set; }

}

/// <summary>
/// Block type for credit_specification in .
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateCreditSpecificationBlock
{
    /// <summary>
    /// The cpu_credits attribute.
    /// </summary>
    [TerraformPropertyName("cpu_credits")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CpuCredits { get; set; }

}

/// <summary>
/// Block type for enclave_options in .
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateEnclaveOptionsBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

}

/// <summary>
/// Block type for hibernation_options in .
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateHibernationOptionsBlock
{
    /// <summary>
    /// The configured attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Configured is required")]
    [TerraformPropertyName("configured")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Configured { get; set; }

}

/// <summary>
/// Block type for iam_instance_profile in .
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateIamInstanceProfileBlock
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Arn { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

}

/// <summary>
/// Block type for instance_market_options in .
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateInstanceMarketOptionsBlock
{
    /// <summary>
    /// The market_type attribute.
    /// </summary>
    [TerraformPropertyName("market_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MarketType { get; set; }

}

/// <summary>
/// Block type for instance_requirements in .
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateInstanceRequirementsBlock
{
    /// <summary>
    /// The accelerator_manufacturers attribute.
    /// </summary>
    [TerraformPropertyName("accelerator_manufacturers")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? AcceleratorManufacturers { get; set; }

    /// <summary>
    /// The accelerator_names attribute.
    /// </summary>
    [TerraformPropertyName("accelerator_names")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? AcceleratorNames { get; set; }

    /// <summary>
    /// The accelerator_types attribute.
    /// </summary>
    [TerraformPropertyName("accelerator_types")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? AcceleratorTypes { get; set; }

    /// <summary>
    /// The allowed_instance_types attribute.
    /// </summary>
    [TerraformPropertyName("allowed_instance_types")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? AllowedInstanceTypes { get; set; }

    /// <summary>
    /// The bare_metal attribute.
    /// </summary>
    [TerraformPropertyName("bare_metal")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BareMetal { get; set; }

    /// <summary>
    /// The burstable_performance attribute.
    /// </summary>
    [TerraformPropertyName("burstable_performance")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BurstablePerformance { get; set; }

    /// <summary>
    /// The cpu_manufacturers attribute.
    /// </summary>
    [TerraformPropertyName("cpu_manufacturers")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? CpuManufacturers { get; set; }

    /// <summary>
    /// The excluded_instance_types attribute.
    /// </summary>
    [TerraformPropertyName("excluded_instance_types")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? ExcludedInstanceTypes { get; set; }

    /// <summary>
    /// The instance_generations attribute.
    /// </summary>
    [TerraformPropertyName("instance_generations")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? InstanceGenerations { get; set; }

    /// <summary>
    /// The local_storage attribute.
    /// </summary>
    [TerraformPropertyName("local_storage")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LocalStorage { get; set; }

    /// <summary>
    /// The local_storage_types attribute.
    /// </summary>
    [TerraformPropertyName("local_storage_types")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? LocalStorageTypes { get; set; }

    /// <summary>
    /// The max_spot_price_as_percentage_of_optimal_on_demand_price attribute.
    /// </summary>
    [TerraformPropertyName("max_spot_price_as_percentage_of_optimal_on_demand_price")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxSpotPriceAsPercentageOfOptimalOnDemandPrice { get; set; }

    /// <summary>
    /// The on_demand_max_price_percentage_over_lowest_price attribute.
    /// </summary>
    [TerraformPropertyName("on_demand_max_price_percentage_over_lowest_price")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? OnDemandMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>
    /// The require_hibernate_support attribute.
    /// </summary>
    [TerraformPropertyName("require_hibernate_support")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RequireHibernateSupport { get; set; }

    /// <summary>
    /// The spot_max_price_percentage_over_lowest_price attribute.
    /// </summary>
    [TerraformPropertyName("spot_max_price_percentage_over_lowest_price")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? SpotMaxPricePercentageOverLowestPrice { get; set; }

}

/// <summary>
/// Block type for license_specification in .
/// Nesting mode: set
/// </summary>
public class AwsLaunchTemplateLicenseSpecificationBlock
{
    /// <summary>
    /// The license_configuration_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseConfigurationArn is required")]
    [TerraformPropertyName("license_configuration_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LicenseConfigurationArn { get; set; }

}

/// <summary>
/// Block type for maintenance_options in .
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateMaintenanceOptionsBlock
{
    /// <summary>
    /// The auto_recovery attribute.
    /// </summary>
    [TerraformPropertyName("auto_recovery")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AutoRecovery { get; set; }

}

/// <summary>
/// Block type for metadata_options in .
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateMetadataOptionsBlock
{
    /// <summary>
    /// The http_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("http_endpoint")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> HttpEndpoint { get; set; } = default!;

    /// <summary>
    /// The http_protocol_ipv6 attribute.
    /// </summary>
    [TerraformPropertyName("http_protocol_ipv6")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> HttpProtocolIpv6 { get; set; } = default!;

    /// <summary>
    /// The http_put_response_hop_limit attribute.
    /// </summary>
    [TerraformPropertyName("http_put_response_hop_limit")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> HttpPutResponseHopLimit { get; set; } = default!;

    /// <summary>
    /// The http_tokens attribute.
    /// </summary>
    [TerraformPropertyName("http_tokens")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> HttpTokens { get; set; } = default!;

    /// <summary>
    /// The instance_metadata_tags attribute.
    /// </summary>
    [TerraformPropertyName("instance_metadata_tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> InstanceMetadataTags { get; set; } = default!;

}

/// <summary>
/// Block type for monitoring in .
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateMonitoringBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

}

/// <summary>
/// Block type for network_interfaces in .
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateNetworkInterfacesBlock
{
    /// <summary>
    /// The associate_carrier_ip_address attribute.
    /// </summary>
    [TerraformPropertyName("associate_carrier_ip_address")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AssociateCarrierIpAddress { get; set; }

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    [TerraformPropertyName("associate_public_ip_address")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AssociatePublicIpAddress { get; set; }

    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    [TerraformPropertyName("delete_on_termination")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DeleteOnTermination { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The device_index attribute.
    /// </summary>
    [TerraformPropertyName("device_index")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? DeviceIndex { get; set; }

    /// <summary>
    /// The interface_type attribute.
    /// </summary>
    [TerraformPropertyName("interface_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InterfaceType { get; set; }

    /// <summary>
    /// The ipv4_address_count attribute.
    /// </summary>
    [TerraformPropertyName("ipv4_address_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Ipv4AddressCount { get; set; }

    /// <summary>
    /// The ipv4_addresses attribute.
    /// </summary>
    [TerraformPropertyName("ipv4_addresses")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Ipv4Addresses { get; set; }

    /// <summary>
    /// The ipv4_prefix_count attribute.
    /// </summary>
    [TerraformPropertyName("ipv4_prefix_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Ipv4PrefixCount { get; set; }

    /// <summary>
    /// The ipv4_prefixes attribute.
    /// </summary>
    [TerraformPropertyName("ipv4_prefixes")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Ipv4Prefixes { get; set; }

    /// <summary>
    /// The ipv6_address_count attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_address_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Ipv6AddressCount { get; set; }

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_addresses")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Ipv6Addresses { get; set; }

    /// <summary>
    /// The ipv6_prefix_count attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_prefix_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Ipv6PrefixCount { get; set; }

    /// <summary>
    /// The ipv6_prefixes attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_prefixes")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Ipv6Prefixes { get; set; }

    /// <summary>
    /// The network_card_index attribute.
    /// </summary>
    [TerraformPropertyName("network_card_index")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? NetworkCardIndex { get; set; }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [TerraformPropertyName("network_interface_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NetworkInterfaceId { get; set; }

    /// <summary>
    /// The primary_ipv6 attribute.
    /// </summary>
    [TerraformPropertyName("primary_ipv6")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PrimaryIpv6 { get; set; }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_address")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PrivateIpAddress { get; set; }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformPropertyName("security_groups")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? SecurityGroups { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SubnetId { get; set; }

}

/// <summary>
/// Block type for placement in .
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplatePlacementBlock
{
    /// <summary>
    /// The affinity attribute.
    /// </summary>
    [TerraformPropertyName("affinity")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Affinity { get; set; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AvailabilityZone { get; set; }

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    [TerraformPropertyName("group_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? GroupId { get; set; }

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    [TerraformPropertyName("group_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? GroupName { get; set; }

    /// <summary>
    /// The host_id attribute.
    /// </summary>
    [TerraformPropertyName("host_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HostId { get; set; }

    /// <summary>
    /// The host_resource_group_arn attribute.
    /// </summary>
    [TerraformPropertyName("host_resource_group_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HostResourceGroupArn { get; set; }

    /// <summary>
    /// The partition_number attribute.
    /// </summary>
    [TerraformPropertyName("partition_number")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? PartitionNumber { get; set; }

    /// <summary>
    /// The spread_domain attribute.
    /// </summary>
    [TerraformPropertyName("spread_domain")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SpreadDomain { get; set; }

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    [TerraformPropertyName("tenancy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Tenancy { get; set; }

}

/// <summary>
/// Block type for private_dns_name_options in .
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplatePrivateDnsNameOptionsBlock
{
    /// <summary>
    /// The enable_resource_name_dns_a_record attribute.
    /// </summary>
    [TerraformPropertyName("enable_resource_name_dns_a_record")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableResourceNameDnsARecord { get; set; }

    /// <summary>
    /// The enable_resource_name_dns_aaaa_record attribute.
    /// </summary>
    [TerraformPropertyName("enable_resource_name_dns_aaaa_record")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableResourceNameDnsAaaaRecord { get; set; }

    /// <summary>
    /// The hostname_type attribute.
    /// </summary>
    [TerraformPropertyName("hostname_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HostnameType { get; set; }

}

/// <summary>
/// Block type for tag_specifications in .
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateTagSpecificationsBlock
{
    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [TerraformPropertyName("resource_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ResourceType { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

}

/// <summary>
/// Manages a aws_launch_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsLaunchTemplate : TerraformResource
{
    public AwsLaunchTemplate(string name) : base("aws_launch_template", name)
    {
    }

    /// <summary>
    /// The default_version attribute.
    /// </summary>
    [TerraformPropertyName("default_version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> DefaultVersion { get; set; } = default!;

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The disable_api_stop attribute.
    /// </summary>
    [TerraformPropertyName("disable_api_stop")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DisableApiStop { get; set; }

    /// <summary>
    /// The disable_api_termination attribute.
    /// </summary>
    [TerraformPropertyName("disable_api_termination")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DisableApiTermination { get; set; }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    [TerraformPropertyName("ebs_optimized")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EbsOptimized { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    [TerraformPropertyName("image_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ImageId { get; set; }

    /// <summary>
    /// The instance_initiated_shutdown_behavior attribute.
    /// </summary>
    [TerraformPropertyName("instance_initiated_shutdown_behavior")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InstanceInitiatedShutdownBehavior { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformPropertyName("instance_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InstanceType { get; set; }

    /// <summary>
    /// The kernel_id attribute.
    /// </summary>
    [TerraformPropertyName("kernel_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KernelId { get; set; }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    [TerraformPropertyName("key_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KeyName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NamePrefix { get; set; } = default!;

    /// <summary>
    /// The ram_disk_id attribute.
    /// </summary>
    [TerraformPropertyName("ram_disk_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RamDiskId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The security_group_names attribute.
    /// </summary>
    [TerraformPropertyName("security_group_names")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? SecurityGroupNames { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The update_default_version attribute.
    /// </summary>
    [TerraformPropertyName("update_default_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? UpdateDefaultVersion { get; set; }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    [TerraformPropertyName("user_data")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UserData { get; set; }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("vpc_security_group_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? VpcSecurityGroupIds { get; set; }

    /// <summary>
    /// Block for block_device_mappings.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("block_device_mappings")]
    public TerraformList<TerraformBlock<AwsLaunchTemplateBlockDeviceMappingsBlock>>? BlockDeviceMappings { get; set; }

    /// <summary>
    /// Block for capacity_reservation_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityReservationSpecification block(s) allowed")]
    [TerraformPropertyName("capacity_reservation_specification")]
    public TerraformList<TerraformBlock<AwsLaunchTemplateCapacityReservationSpecificationBlock>>? CapacityReservationSpecification { get; set; }

    /// <summary>
    /// Block for cpu_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CpuOptions block(s) allowed")]
    [TerraformPropertyName("cpu_options")]
    public TerraformList<TerraformBlock<AwsLaunchTemplateCpuOptionsBlock>>? CpuOptions { get; set; }

    /// <summary>
    /// Block for credit_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CreditSpecification block(s) allowed")]
    [TerraformPropertyName("credit_specification")]
    public TerraformList<TerraformBlock<AwsLaunchTemplateCreditSpecificationBlock>>? CreditSpecification { get; set; }

    /// <summary>
    /// Block for enclave_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnclaveOptions block(s) allowed")]
    [TerraformPropertyName("enclave_options")]
    public TerraformList<TerraformBlock<AwsLaunchTemplateEnclaveOptionsBlock>>? EnclaveOptions { get; set; }

    /// <summary>
    /// Block for hibernation_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HibernationOptions block(s) allowed")]
    [TerraformPropertyName("hibernation_options")]
    public TerraformList<TerraformBlock<AwsLaunchTemplateHibernationOptionsBlock>>? HibernationOptions { get; set; }

    /// <summary>
    /// Block for iam_instance_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IamInstanceProfile block(s) allowed")]
    [TerraformPropertyName("iam_instance_profile")]
    public TerraformList<TerraformBlock<AwsLaunchTemplateIamInstanceProfileBlock>>? IamInstanceProfile { get; set; }

    /// <summary>
    /// Block for instance_market_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceMarketOptions block(s) allowed")]
    [TerraformPropertyName("instance_market_options")]
    public TerraformList<TerraformBlock<AwsLaunchTemplateInstanceMarketOptionsBlock>>? InstanceMarketOptions { get; set; }

    /// <summary>
    /// Block for instance_requirements.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceRequirements block(s) allowed")]
    [TerraformPropertyName("instance_requirements")]
    public TerraformList<TerraformBlock<AwsLaunchTemplateInstanceRequirementsBlock>>? InstanceRequirements { get; set; }

    /// <summary>
    /// Block for license_specification.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("license_specification")]
    public TerraformSet<TerraformBlock<AwsLaunchTemplateLicenseSpecificationBlock>>? LicenseSpecification { get; set; }

    /// <summary>
    /// Block for maintenance_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceOptions block(s) allowed")]
    [TerraformPropertyName("maintenance_options")]
    public TerraformList<TerraformBlock<AwsLaunchTemplateMaintenanceOptionsBlock>>? MaintenanceOptions { get; set; }

    /// <summary>
    /// Block for metadata_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetadataOptions block(s) allowed")]
    [TerraformPropertyName("metadata_options")]
    public TerraformList<TerraformBlock<AwsLaunchTemplateMetadataOptionsBlock>>? MetadataOptions { get; set; }

    /// <summary>
    /// Block for monitoring.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Monitoring block(s) allowed")]
    [TerraformPropertyName("monitoring")]
    public TerraformList<TerraformBlock<AwsLaunchTemplateMonitoringBlock>>? Monitoring { get; set; }

    /// <summary>
    /// Block for network_interfaces.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("network_interfaces")]
    public TerraformList<TerraformBlock<AwsLaunchTemplateNetworkInterfacesBlock>>? NetworkInterfaces { get; set; }

    /// <summary>
    /// Block for placement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Placement block(s) allowed")]
    [TerraformPropertyName("placement")]
    public TerraformList<TerraformBlock<AwsLaunchTemplatePlacementBlock>>? Placement { get; set; }

    /// <summary>
    /// Block for private_dns_name_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateDnsNameOptions block(s) allowed")]
    [TerraformPropertyName("private_dns_name_options")]
    public TerraformList<TerraformBlock<AwsLaunchTemplatePrivateDnsNameOptionsBlock>>? PrivateDnsNameOptions { get; set; }

    /// <summary>
    /// Block for tag_specifications.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("tag_specifications")]
    public TerraformList<TerraformBlock<AwsLaunchTemplateTagSpecificationsBlock>>? TagSpecifications { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The latest_version attribute.
    /// </summary>
    [TerraformPropertyName("latest_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> LatestVersion => new TerraformReference(this, "latest_version");

}
