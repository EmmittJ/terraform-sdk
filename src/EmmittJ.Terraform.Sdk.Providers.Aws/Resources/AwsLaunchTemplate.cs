using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for block_device_mappings in .
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateBlockDeviceMappingsBlock : TerraformBlock
{
    /// <summary>
    /// The device_name attribute.
    /// </summary>
    public TerraformProperty<string>? DeviceName
    {
        get => GetProperty<TerraformProperty<string>>("device_name");
        set => WithProperty("device_name", value);
    }

    /// <summary>
    /// The no_device attribute.
    /// </summary>
    public TerraformProperty<string>? NoDevice
    {
        get => GetProperty<TerraformProperty<string>>("no_device");
        set => WithProperty("no_device", value);
    }

    /// <summary>
    /// The virtual_name attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualName
    {
        get => GetProperty<TerraformProperty<string>>("virtual_name");
        set => WithProperty("virtual_name", value);
    }

}

/// <summary>
/// Block type for capacity_reservation_specification in .
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateCapacityReservationSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// The capacity_reservation_preference attribute.
    /// </summary>
    public TerraformProperty<string>? CapacityReservationPreference
    {
        get => GetProperty<TerraformProperty<string>>("capacity_reservation_preference");
        set => WithProperty("capacity_reservation_preference", value);
    }

}

/// <summary>
/// Block type for cpu_options in .
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateCpuOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The amd_sev_snp attribute.
    /// </summary>
    public TerraformProperty<string>? AmdSevSnp
    {
        get => GetProperty<TerraformProperty<string>>("amd_sev_snp");
        set => WithProperty("amd_sev_snp", value);
    }

    /// <summary>
    /// The core_count attribute.
    /// </summary>
    public TerraformProperty<double>? CoreCount
    {
        get => GetProperty<TerraformProperty<double>>("core_count");
        set => WithProperty("core_count", value);
    }

    /// <summary>
    /// The threads_per_core attribute.
    /// </summary>
    public TerraformProperty<double>? ThreadsPerCore
    {
        get => GetProperty<TerraformProperty<double>>("threads_per_core");
        set => WithProperty("threads_per_core", value);
    }

}

/// <summary>
/// Block type for credit_specification in .
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateCreditSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// The cpu_credits attribute.
    /// </summary>
    public TerraformProperty<string>? CpuCredits
    {
        get => GetProperty<TerraformProperty<string>>("cpu_credits");
        set => WithProperty("cpu_credits", value);
    }

}

/// <summary>
/// Block type for enclave_options in .
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateEnclaveOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

}

/// <summary>
/// Block type for hibernation_options in .
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateHibernationOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The configured attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Configured is required")]
    public required TerraformProperty<bool> Configured
    {
        get => GetProperty<TerraformProperty<bool>>("configured");
        set => WithProperty("configured", value);
    }

}

/// <summary>
/// Block type for iam_instance_profile in .
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateIamInstanceProfileBlock : TerraformBlock
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformProperty<string>? Arn
    {
        get => GetProperty<TerraformProperty<string>>("arn");
        set => WithProperty("arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

/// <summary>
/// Block type for instance_market_options in .
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateInstanceMarketOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The market_type attribute.
    /// </summary>
    public TerraformProperty<string>? MarketType
    {
        get => GetProperty<TerraformProperty<string>>("market_type");
        set => WithProperty("market_type", value);
    }

}

/// <summary>
/// Block type for instance_requirements in .
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateInstanceRequirementsBlock : TerraformBlock
{
    /// <summary>
    /// The accelerator_manufacturers attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AcceleratorManufacturers
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("accelerator_manufacturers");
        set => WithProperty("accelerator_manufacturers", value);
    }

    /// <summary>
    /// The accelerator_names attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AcceleratorNames
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("accelerator_names");
        set => WithProperty("accelerator_names", value);
    }

    /// <summary>
    /// The accelerator_types attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AcceleratorTypes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("accelerator_types");
        set => WithProperty("accelerator_types", value);
    }

    /// <summary>
    /// The allowed_instance_types attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AllowedInstanceTypes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("allowed_instance_types");
        set => WithProperty("allowed_instance_types", value);
    }

    /// <summary>
    /// The bare_metal attribute.
    /// </summary>
    public TerraformProperty<string>? BareMetal
    {
        get => GetProperty<TerraformProperty<string>>("bare_metal");
        set => WithProperty("bare_metal", value);
    }

    /// <summary>
    /// The burstable_performance attribute.
    /// </summary>
    public TerraformProperty<string>? BurstablePerformance
    {
        get => GetProperty<TerraformProperty<string>>("burstable_performance");
        set => WithProperty("burstable_performance", value);
    }

    /// <summary>
    /// The cpu_manufacturers attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? CpuManufacturers
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("cpu_manufacturers");
        set => WithProperty("cpu_manufacturers", value);
    }

    /// <summary>
    /// The excluded_instance_types attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ExcludedInstanceTypes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("excluded_instance_types");
        set => WithProperty("excluded_instance_types", value);
    }

    /// <summary>
    /// The instance_generations attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? InstanceGenerations
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("instance_generations");
        set => WithProperty("instance_generations", value);
    }

    /// <summary>
    /// The local_storage attribute.
    /// </summary>
    public TerraformProperty<string>? LocalStorage
    {
        get => GetProperty<TerraformProperty<string>>("local_storage");
        set => WithProperty("local_storage", value);
    }

    /// <summary>
    /// The local_storage_types attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? LocalStorageTypes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("local_storage_types");
        set => WithProperty("local_storage_types", value);
    }

    /// <summary>
    /// The max_spot_price_as_percentage_of_optimal_on_demand_price attribute.
    /// </summary>
    public TerraformProperty<double>? MaxSpotPriceAsPercentageOfOptimalOnDemandPrice
    {
        get => GetProperty<TerraformProperty<double>>("max_spot_price_as_percentage_of_optimal_on_demand_price");
        set => WithProperty("max_spot_price_as_percentage_of_optimal_on_demand_price", value);
    }

    /// <summary>
    /// The on_demand_max_price_percentage_over_lowest_price attribute.
    /// </summary>
    public TerraformProperty<double>? OnDemandMaxPricePercentageOverLowestPrice
    {
        get => GetProperty<TerraformProperty<double>>("on_demand_max_price_percentage_over_lowest_price");
        set => WithProperty("on_demand_max_price_percentage_over_lowest_price", value);
    }

    /// <summary>
    /// The require_hibernate_support attribute.
    /// </summary>
    public TerraformProperty<bool>? RequireHibernateSupport
    {
        get => GetProperty<TerraformProperty<bool>>("require_hibernate_support");
        set => WithProperty("require_hibernate_support", value);
    }

    /// <summary>
    /// The spot_max_price_percentage_over_lowest_price attribute.
    /// </summary>
    public TerraformProperty<double>? SpotMaxPricePercentageOverLowestPrice
    {
        get => GetProperty<TerraformProperty<double>>("spot_max_price_percentage_over_lowest_price");
        set => WithProperty("spot_max_price_percentage_over_lowest_price", value);
    }

}

/// <summary>
/// Block type for license_specification in .
/// Nesting mode: set
/// </summary>
public class AwsLaunchTemplateLicenseSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// The license_configuration_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseConfigurationArn is required")]
    public required TerraformProperty<string> LicenseConfigurationArn
    {
        get => GetProperty<TerraformProperty<string>>("license_configuration_arn");
        set => WithProperty("license_configuration_arn", value);
    }

}

/// <summary>
/// Block type for maintenance_options in .
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateMaintenanceOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The auto_recovery attribute.
    /// </summary>
    public TerraformProperty<string>? AutoRecovery
    {
        get => GetProperty<TerraformProperty<string>>("auto_recovery");
        set => WithProperty("auto_recovery", value);
    }

}

/// <summary>
/// Block type for metadata_options in .
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateMetadataOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The http_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? HttpEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("http_endpoint");
        set => WithProperty("http_endpoint", value);
    }

    /// <summary>
    /// The http_protocol_ipv6 attribute.
    /// </summary>
    public TerraformProperty<string>? HttpProtocolIpv6
    {
        get => GetProperty<TerraformProperty<string>>("http_protocol_ipv6");
        set => WithProperty("http_protocol_ipv6", value);
    }

    /// <summary>
    /// The http_put_response_hop_limit attribute.
    /// </summary>
    public TerraformProperty<double>? HttpPutResponseHopLimit
    {
        get => GetProperty<TerraformProperty<double>>("http_put_response_hop_limit");
        set => WithProperty("http_put_response_hop_limit", value);
    }

    /// <summary>
    /// The http_tokens attribute.
    /// </summary>
    public TerraformProperty<string>? HttpTokens
    {
        get => GetProperty<TerraformProperty<string>>("http_tokens");
        set => WithProperty("http_tokens", value);
    }

    /// <summary>
    /// The instance_metadata_tags attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceMetadataTags
    {
        get => GetProperty<TerraformProperty<string>>("instance_metadata_tags");
        set => WithProperty("instance_metadata_tags", value);
    }

}

/// <summary>
/// Block type for monitoring in .
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateMonitoringBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

}

/// <summary>
/// Block type for network_interfaces in .
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateNetworkInterfacesBlock : TerraformBlock
{
    /// <summary>
    /// The associate_carrier_ip_address attribute.
    /// </summary>
    public TerraformProperty<string>? AssociateCarrierIpAddress
    {
        get => GetProperty<TerraformProperty<string>>("associate_carrier_ip_address");
        set => WithProperty("associate_carrier_ip_address", value);
    }

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    public TerraformProperty<string>? AssociatePublicIpAddress
    {
        get => GetProperty<TerraformProperty<string>>("associate_public_ip_address");
        set => WithProperty("associate_public_ip_address", value);
    }

    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    public TerraformProperty<string>? DeleteOnTermination
    {
        get => GetProperty<TerraformProperty<string>>("delete_on_termination");
        set => WithProperty("delete_on_termination", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The device_index attribute.
    /// </summary>
    public TerraformProperty<double>? DeviceIndex
    {
        get => GetProperty<TerraformProperty<double>>("device_index");
        set => WithProperty("device_index", value);
    }

    /// <summary>
    /// The interface_type attribute.
    /// </summary>
    public TerraformProperty<string>? InterfaceType
    {
        get => GetProperty<TerraformProperty<string>>("interface_type");
        set => WithProperty("interface_type", value);
    }

    /// <summary>
    /// The ipv4_address_count attribute.
    /// </summary>
    public TerraformProperty<double>? Ipv4AddressCount
    {
        get => GetProperty<TerraformProperty<double>>("ipv4_address_count");
        set => WithProperty("ipv4_address_count", value);
    }

    /// <summary>
    /// The ipv4_addresses attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Ipv4Addresses
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("ipv4_addresses");
        set => WithProperty("ipv4_addresses", value);
    }

    /// <summary>
    /// The ipv4_prefix_count attribute.
    /// </summary>
    public TerraformProperty<double>? Ipv4PrefixCount
    {
        get => GetProperty<TerraformProperty<double>>("ipv4_prefix_count");
        set => WithProperty("ipv4_prefix_count", value);
    }

    /// <summary>
    /// The ipv4_prefixes attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Ipv4Prefixes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("ipv4_prefixes");
        set => WithProperty("ipv4_prefixes", value);
    }

    /// <summary>
    /// The ipv6_address_count attribute.
    /// </summary>
    public TerraformProperty<double>? Ipv6AddressCount
    {
        get => GetProperty<TerraformProperty<double>>("ipv6_address_count");
        set => WithProperty("ipv6_address_count", value);
    }

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Ipv6Addresses
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("ipv6_addresses");
        set => WithProperty("ipv6_addresses", value);
    }

    /// <summary>
    /// The ipv6_prefix_count attribute.
    /// </summary>
    public TerraformProperty<double>? Ipv6PrefixCount
    {
        get => GetProperty<TerraformProperty<double>>("ipv6_prefix_count");
        set => WithProperty("ipv6_prefix_count", value);
    }

    /// <summary>
    /// The ipv6_prefixes attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Ipv6Prefixes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("ipv6_prefixes");
        set => WithProperty("ipv6_prefixes", value);
    }

    /// <summary>
    /// The network_card_index attribute.
    /// </summary>
    public TerraformProperty<double>? NetworkCardIndex
    {
        get => GetProperty<TerraformProperty<double>>("network_card_index");
        set => WithProperty("network_card_index", value);
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkInterfaceId
    {
        get => GetProperty<TerraformProperty<string>>("network_interface_id");
        set => WithProperty("network_interface_id", value);
    }

    /// <summary>
    /// The primary_ipv6 attribute.
    /// </summary>
    public TerraformProperty<string>? PrimaryIpv6
    {
        get => GetProperty<TerraformProperty<string>>("primary_ipv6");
        set => WithProperty("primary_ipv6", value);
    }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateIpAddress
    {
        get => GetProperty<TerraformProperty<string>>("private_ip_address");
        set => WithProperty("private_ip_address", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroups
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_groups");
        set => WithProperty("security_groups", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => WithProperty("subnet_id", value);
    }

}

/// <summary>
/// Block type for placement in .
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplatePlacementBlock : TerraformBlock
{
    /// <summary>
    /// The affinity attribute.
    /// </summary>
    public TerraformProperty<string>? Affinity
    {
        get => GetProperty<TerraformProperty<string>>("affinity");
        set => WithProperty("affinity", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformProperty<string>? AvailabilityZone
    {
        get => GetProperty<TerraformProperty<string>>("availability_zone");
        set => WithProperty("availability_zone", value);
    }

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    public TerraformProperty<string>? GroupId
    {
        get => GetProperty<TerraformProperty<string>>("group_id");
        set => WithProperty("group_id", value);
    }

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    public TerraformProperty<string>? GroupName
    {
        get => GetProperty<TerraformProperty<string>>("group_name");
        set => WithProperty("group_name", value);
    }

    /// <summary>
    /// The host_id attribute.
    /// </summary>
    public TerraformProperty<string>? HostId
    {
        get => GetProperty<TerraformProperty<string>>("host_id");
        set => WithProperty("host_id", value);
    }

    /// <summary>
    /// The host_resource_group_arn attribute.
    /// </summary>
    public TerraformProperty<string>? HostResourceGroupArn
    {
        get => GetProperty<TerraformProperty<string>>("host_resource_group_arn");
        set => WithProperty("host_resource_group_arn", value);
    }

    /// <summary>
    /// The partition_number attribute.
    /// </summary>
    public TerraformProperty<double>? PartitionNumber
    {
        get => GetProperty<TerraformProperty<double>>("partition_number");
        set => WithProperty("partition_number", value);
    }

    /// <summary>
    /// The spread_domain attribute.
    /// </summary>
    public TerraformProperty<string>? SpreadDomain
    {
        get => GetProperty<TerraformProperty<string>>("spread_domain");
        set => WithProperty("spread_domain", value);
    }

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    public TerraformProperty<string>? Tenancy
    {
        get => GetProperty<TerraformProperty<string>>("tenancy");
        set => WithProperty("tenancy", value);
    }

}

/// <summary>
/// Block type for private_dns_name_options in .
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplatePrivateDnsNameOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The enable_resource_name_dns_a_record attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableResourceNameDnsARecord
    {
        get => GetProperty<TerraformProperty<bool>>("enable_resource_name_dns_a_record");
        set => WithProperty("enable_resource_name_dns_a_record", value);
    }

    /// <summary>
    /// The enable_resource_name_dns_aaaa_record attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableResourceNameDnsAaaaRecord
    {
        get => GetProperty<TerraformProperty<bool>>("enable_resource_name_dns_aaaa_record");
        set => WithProperty("enable_resource_name_dns_aaaa_record", value);
    }

    /// <summary>
    /// The hostname_type attribute.
    /// </summary>
    public TerraformProperty<string>? HostnameType
    {
        get => GetProperty<TerraformProperty<string>>("hostname_type");
        set => WithProperty("hostname_type", value);
    }

}

/// <summary>
/// Block type for tag_specifications in .
/// Nesting mode: list
/// </summary>
public class AwsLaunchTemplateTagSpecificationsBlock : TerraformBlock
{
    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceType
    {
        get => GetProperty<TerraformProperty<string>>("resource_type");
        set => WithProperty("resource_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => WithProperty("tags", value);
    }

}

/// <summary>
/// Manages a aws_launch_template resource.
/// </summary>
public class AwsLaunchTemplate : TerraformResource
{
    public AwsLaunchTemplate(string name) : base("aws_launch_template", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("latest_version");
    }

    /// <summary>
    /// The default_version attribute.
    /// </summary>
    public TerraformProperty<double>? DefaultVersion
    {
        get => GetProperty<TerraformProperty<double>>("default_version");
        set => this.WithProperty("default_version", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The disable_api_stop attribute.
    /// </summary>
    public TerraformProperty<bool>? DisableApiStop
    {
        get => GetProperty<TerraformProperty<bool>>("disable_api_stop");
        set => this.WithProperty("disable_api_stop", value);
    }

    /// <summary>
    /// The disable_api_termination attribute.
    /// </summary>
    public TerraformProperty<bool>? DisableApiTermination
    {
        get => GetProperty<TerraformProperty<bool>>("disable_api_termination");
        set => this.WithProperty("disable_api_termination", value);
    }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    public TerraformProperty<string>? EbsOptimized
    {
        get => GetProperty<TerraformProperty<string>>("ebs_optimized");
        set => this.WithProperty("ebs_optimized", value);
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
    /// The image_id attribute.
    /// </summary>
    public TerraformProperty<string>? ImageId
    {
        get => GetProperty<TerraformProperty<string>>("image_id");
        set => this.WithProperty("image_id", value);
    }

    /// <summary>
    /// The instance_initiated_shutdown_behavior attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceInitiatedShutdownBehavior
    {
        get => GetProperty<TerraformProperty<string>>("instance_initiated_shutdown_behavior");
        set => this.WithProperty("instance_initiated_shutdown_behavior", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceType
    {
        get => GetProperty<TerraformProperty<string>>("instance_type");
        set => this.WithProperty("instance_type", value);
    }

    /// <summary>
    /// The kernel_id attribute.
    /// </summary>
    public TerraformProperty<string>? KernelId
    {
        get => GetProperty<TerraformProperty<string>>("kernel_id");
        set => this.WithProperty("kernel_id", value);
    }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    public TerraformProperty<string>? KeyName
    {
        get => GetProperty<TerraformProperty<string>>("key_name");
        set => this.WithProperty("key_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
    }

    /// <summary>
    /// The ram_disk_id attribute.
    /// </summary>
    public TerraformProperty<string>? RamDiskId
    {
        get => GetProperty<TerraformProperty<string>>("ram_disk_id");
        set => this.WithProperty("ram_disk_id", value);
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
    /// The security_group_names attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroupNames
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_group_names");
        set => this.WithProperty("security_group_names", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The update_default_version attribute.
    /// </summary>
    public TerraformProperty<bool>? UpdateDefaultVersion
    {
        get => GetProperty<TerraformProperty<bool>>("update_default_version");
        set => this.WithProperty("update_default_version", value);
    }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    public TerraformProperty<string>? UserData
    {
        get => GetProperty<TerraformProperty<string>>("user_data");
        set => this.WithProperty("user_data", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? VpcSecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("vpc_security_group_ids");
        set => this.WithProperty("vpc_security_group_ids", value);
    }

    /// <summary>
    /// Block for block_device_mappings.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLaunchTemplateBlockDeviceMappingsBlock>? BlockDeviceMappings
    {
        get => GetProperty<List<AwsLaunchTemplateBlockDeviceMappingsBlock>>("block_device_mappings");
        set => this.WithProperty("block_device_mappings", value);
    }

    /// <summary>
    /// Block for capacity_reservation_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityReservationSpecification block(s) allowed")]
    public List<AwsLaunchTemplateCapacityReservationSpecificationBlock>? CapacityReservationSpecification
    {
        get => GetProperty<List<AwsLaunchTemplateCapacityReservationSpecificationBlock>>("capacity_reservation_specification");
        set => this.WithProperty("capacity_reservation_specification", value);
    }

    /// <summary>
    /// Block for cpu_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CpuOptions block(s) allowed")]
    public List<AwsLaunchTemplateCpuOptionsBlock>? CpuOptions
    {
        get => GetProperty<List<AwsLaunchTemplateCpuOptionsBlock>>("cpu_options");
        set => this.WithProperty("cpu_options", value);
    }

    /// <summary>
    /// Block for credit_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CreditSpecification block(s) allowed")]
    public List<AwsLaunchTemplateCreditSpecificationBlock>? CreditSpecification
    {
        get => GetProperty<List<AwsLaunchTemplateCreditSpecificationBlock>>("credit_specification");
        set => this.WithProperty("credit_specification", value);
    }

    /// <summary>
    /// Block for enclave_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnclaveOptions block(s) allowed")]
    public List<AwsLaunchTemplateEnclaveOptionsBlock>? EnclaveOptions
    {
        get => GetProperty<List<AwsLaunchTemplateEnclaveOptionsBlock>>("enclave_options");
        set => this.WithProperty("enclave_options", value);
    }

    /// <summary>
    /// Block for hibernation_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HibernationOptions block(s) allowed")]
    public List<AwsLaunchTemplateHibernationOptionsBlock>? HibernationOptions
    {
        get => GetProperty<List<AwsLaunchTemplateHibernationOptionsBlock>>("hibernation_options");
        set => this.WithProperty("hibernation_options", value);
    }

    /// <summary>
    /// Block for iam_instance_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IamInstanceProfile block(s) allowed")]
    public List<AwsLaunchTemplateIamInstanceProfileBlock>? IamInstanceProfile
    {
        get => GetProperty<List<AwsLaunchTemplateIamInstanceProfileBlock>>("iam_instance_profile");
        set => this.WithProperty("iam_instance_profile", value);
    }

    /// <summary>
    /// Block for instance_market_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceMarketOptions block(s) allowed")]
    public List<AwsLaunchTemplateInstanceMarketOptionsBlock>? InstanceMarketOptions
    {
        get => GetProperty<List<AwsLaunchTemplateInstanceMarketOptionsBlock>>("instance_market_options");
        set => this.WithProperty("instance_market_options", value);
    }

    /// <summary>
    /// Block for instance_requirements.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceRequirements block(s) allowed")]
    public List<AwsLaunchTemplateInstanceRequirementsBlock>? InstanceRequirements
    {
        get => GetProperty<List<AwsLaunchTemplateInstanceRequirementsBlock>>("instance_requirements");
        set => this.WithProperty("instance_requirements", value);
    }

    /// <summary>
    /// Block for license_specification.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsLaunchTemplateLicenseSpecificationBlock>? LicenseSpecification
    {
        get => GetProperty<HashSet<AwsLaunchTemplateLicenseSpecificationBlock>>("license_specification");
        set => this.WithProperty("license_specification", value);
    }

    /// <summary>
    /// Block for maintenance_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceOptions block(s) allowed")]
    public List<AwsLaunchTemplateMaintenanceOptionsBlock>? MaintenanceOptions
    {
        get => GetProperty<List<AwsLaunchTemplateMaintenanceOptionsBlock>>("maintenance_options");
        set => this.WithProperty("maintenance_options", value);
    }

    /// <summary>
    /// Block for metadata_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetadataOptions block(s) allowed")]
    public List<AwsLaunchTemplateMetadataOptionsBlock>? MetadataOptions
    {
        get => GetProperty<List<AwsLaunchTemplateMetadataOptionsBlock>>("metadata_options");
        set => this.WithProperty("metadata_options", value);
    }

    /// <summary>
    /// Block for monitoring.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Monitoring block(s) allowed")]
    public List<AwsLaunchTemplateMonitoringBlock>? Monitoring
    {
        get => GetProperty<List<AwsLaunchTemplateMonitoringBlock>>("monitoring");
        set => this.WithProperty("monitoring", value);
    }

    /// <summary>
    /// Block for network_interfaces.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLaunchTemplateNetworkInterfacesBlock>? NetworkInterfaces
    {
        get => GetProperty<List<AwsLaunchTemplateNetworkInterfacesBlock>>("network_interfaces");
        set => this.WithProperty("network_interfaces", value);
    }

    /// <summary>
    /// Block for placement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Placement block(s) allowed")]
    public List<AwsLaunchTemplatePlacementBlock>? Placement
    {
        get => GetProperty<List<AwsLaunchTemplatePlacementBlock>>("placement");
        set => this.WithProperty("placement", value);
    }

    /// <summary>
    /// Block for private_dns_name_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateDnsNameOptions block(s) allowed")]
    public List<AwsLaunchTemplatePrivateDnsNameOptionsBlock>? PrivateDnsNameOptions
    {
        get => GetProperty<List<AwsLaunchTemplatePrivateDnsNameOptionsBlock>>("private_dns_name_options");
        set => this.WithProperty("private_dns_name_options", value);
    }

    /// <summary>
    /// Block for tag_specifications.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLaunchTemplateTagSpecificationsBlock>? TagSpecifications
    {
        get => GetProperty<List<AwsLaunchTemplateTagSpecificationsBlock>>("tag_specifications");
        set => this.WithProperty("tag_specifications", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The latest_version attribute.
    /// </summary>
    public TerraformExpression LatestVersion => this["latest_version"];

}
