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
        set => SetProperty("device_name", value);
    }

    /// <summary>
    /// The no_device attribute.
    /// </summary>
    public TerraformProperty<string>? NoDevice
    {
        set => SetProperty("no_device", value);
    }

    /// <summary>
    /// The virtual_name attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualName
    {
        set => SetProperty("virtual_name", value);
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
        set => SetProperty("capacity_reservation_preference", value);
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
        set => SetProperty("amd_sev_snp", value);
    }

    /// <summary>
    /// The core_count attribute.
    /// </summary>
    public TerraformProperty<double>? CoreCount
    {
        set => SetProperty("core_count", value);
    }

    /// <summary>
    /// The threads_per_core attribute.
    /// </summary>
    public TerraformProperty<double>? ThreadsPerCore
    {
        set => SetProperty("threads_per_core", value);
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
        set => SetProperty("cpu_credits", value);
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
        set => SetProperty("enabled", value);
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
        set => SetProperty("configured", value);
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
        set => SetProperty("arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
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
        set => SetProperty("market_type", value);
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
        set => SetProperty("accelerator_manufacturers", value);
    }

    /// <summary>
    /// The accelerator_names attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AcceleratorNames
    {
        set => SetProperty("accelerator_names", value);
    }

    /// <summary>
    /// The accelerator_types attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AcceleratorTypes
    {
        set => SetProperty("accelerator_types", value);
    }

    /// <summary>
    /// The allowed_instance_types attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AllowedInstanceTypes
    {
        set => SetProperty("allowed_instance_types", value);
    }

    /// <summary>
    /// The bare_metal attribute.
    /// </summary>
    public TerraformProperty<string>? BareMetal
    {
        set => SetProperty("bare_metal", value);
    }

    /// <summary>
    /// The burstable_performance attribute.
    /// </summary>
    public TerraformProperty<string>? BurstablePerformance
    {
        set => SetProperty("burstable_performance", value);
    }

    /// <summary>
    /// The cpu_manufacturers attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? CpuManufacturers
    {
        set => SetProperty("cpu_manufacturers", value);
    }

    /// <summary>
    /// The excluded_instance_types attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ExcludedInstanceTypes
    {
        set => SetProperty("excluded_instance_types", value);
    }

    /// <summary>
    /// The instance_generations attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? InstanceGenerations
    {
        set => SetProperty("instance_generations", value);
    }

    /// <summary>
    /// The local_storage attribute.
    /// </summary>
    public TerraformProperty<string>? LocalStorage
    {
        set => SetProperty("local_storage", value);
    }

    /// <summary>
    /// The local_storage_types attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? LocalStorageTypes
    {
        set => SetProperty("local_storage_types", value);
    }

    /// <summary>
    /// The max_spot_price_as_percentage_of_optimal_on_demand_price attribute.
    /// </summary>
    public TerraformProperty<double>? MaxSpotPriceAsPercentageOfOptimalOnDemandPrice
    {
        set => SetProperty("max_spot_price_as_percentage_of_optimal_on_demand_price", value);
    }

    /// <summary>
    /// The on_demand_max_price_percentage_over_lowest_price attribute.
    /// </summary>
    public TerraformProperty<double>? OnDemandMaxPricePercentageOverLowestPrice
    {
        set => SetProperty("on_demand_max_price_percentage_over_lowest_price", value);
    }

    /// <summary>
    /// The require_hibernate_support attribute.
    /// </summary>
    public TerraformProperty<bool>? RequireHibernateSupport
    {
        set => SetProperty("require_hibernate_support", value);
    }

    /// <summary>
    /// The spot_max_price_percentage_over_lowest_price attribute.
    /// </summary>
    public TerraformProperty<double>? SpotMaxPricePercentageOverLowestPrice
    {
        set => SetProperty("spot_max_price_percentage_over_lowest_price", value);
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
        set => SetProperty("license_configuration_arn", value);
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
        set => SetProperty("auto_recovery", value);
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
        set => SetProperty("http_endpoint", value);
    }

    /// <summary>
    /// The http_protocol_ipv6 attribute.
    /// </summary>
    public TerraformProperty<string>? HttpProtocolIpv6
    {
        set => SetProperty("http_protocol_ipv6", value);
    }

    /// <summary>
    /// The http_put_response_hop_limit attribute.
    /// </summary>
    public TerraformProperty<double>? HttpPutResponseHopLimit
    {
        set => SetProperty("http_put_response_hop_limit", value);
    }

    /// <summary>
    /// The http_tokens attribute.
    /// </summary>
    public TerraformProperty<string>? HttpTokens
    {
        set => SetProperty("http_tokens", value);
    }

    /// <summary>
    /// The instance_metadata_tags attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceMetadataTags
    {
        set => SetProperty("instance_metadata_tags", value);
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
        set => SetProperty("enabled", value);
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
        set => SetProperty("associate_carrier_ip_address", value);
    }

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    public TerraformProperty<string>? AssociatePublicIpAddress
    {
        set => SetProperty("associate_public_ip_address", value);
    }

    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    public TerraformProperty<string>? DeleteOnTermination
    {
        set => SetProperty("delete_on_termination", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The device_index attribute.
    /// </summary>
    public TerraformProperty<double>? DeviceIndex
    {
        set => SetProperty("device_index", value);
    }

    /// <summary>
    /// The interface_type attribute.
    /// </summary>
    public TerraformProperty<string>? InterfaceType
    {
        set => SetProperty("interface_type", value);
    }

    /// <summary>
    /// The ipv4_address_count attribute.
    /// </summary>
    public TerraformProperty<double>? Ipv4AddressCount
    {
        set => SetProperty("ipv4_address_count", value);
    }

    /// <summary>
    /// The ipv4_addresses attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Ipv4Addresses
    {
        set => SetProperty("ipv4_addresses", value);
    }

    /// <summary>
    /// The ipv4_prefix_count attribute.
    /// </summary>
    public TerraformProperty<double>? Ipv4PrefixCount
    {
        set => SetProperty("ipv4_prefix_count", value);
    }

    /// <summary>
    /// The ipv4_prefixes attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Ipv4Prefixes
    {
        set => SetProperty("ipv4_prefixes", value);
    }

    /// <summary>
    /// The ipv6_address_count attribute.
    /// </summary>
    public TerraformProperty<double>? Ipv6AddressCount
    {
        set => SetProperty("ipv6_address_count", value);
    }

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Ipv6Addresses
    {
        set => SetProperty("ipv6_addresses", value);
    }

    /// <summary>
    /// The ipv6_prefix_count attribute.
    /// </summary>
    public TerraformProperty<double>? Ipv6PrefixCount
    {
        set => SetProperty("ipv6_prefix_count", value);
    }

    /// <summary>
    /// The ipv6_prefixes attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Ipv6Prefixes
    {
        set => SetProperty("ipv6_prefixes", value);
    }

    /// <summary>
    /// The network_card_index attribute.
    /// </summary>
    public TerraformProperty<double>? NetworkCardIndex
    {
        set => SetProperty("network_card_index", value);
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkInterfaceId
    {
        set => SetProperty("network_interface_id", value);
    }

    /// <summary>
    /// The primary_ipv6 attribute.
    /// </summary>
    public TerraformProperty<string>? PrimaryIpv6
    {
        set => SetProperty("primary_ipv6", value);
    }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateIpAddress
    {
        set => SetProperty("private_ip_address", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroups
    {
        set => SetProperty("security_groups", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        set => SetProperty("subnet_id", value);
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
        set => SetProperty("affinity", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformProperty<string>? AvailabilityZone
    {
        set => SetProperty("availability_zone", value);
    }

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    public TerraformProperty<string>? GroupId
    {
        set => SetProperty("group_id", value);
    }

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    public TerraformProperty<string>? GroupName
    {
        set => SetProperty("group_name", value);
    }

    /// <summary>
    /// The host_id attribute.
    /// </summary>
    public TerraformProperty<string>? HostId
    {
        set => SetProperty("host_id", value);
    }

    /// <summary>
    /// The host_resource_group_arn attribute.
    /// </summary>
    public TerraformProperty<string>? HostResourceGroupArn
    {
        set => SetProperty("host_resource_group_arn", value);
    }

    /// <summary>
    /// The partition_number attribute.
    /// </summary>
    public TerraformProperty<double>? PartitionNumber
    {
        set => SetProperty("partition_number", value);
    }

    /// <summary>
    /// The spread_domain attribute.
    /// </summary>
    public TerraformProperty<string>? SpreadDomain
    {
        set => SetProperty("spread_domain", value);
    }

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    public TerraformProperty<string>? Tenancy
    {
        set => SetProperty("tenancy", value);
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
        set => SetProperty("enable_resource_name_dns_a_record", value);
    }

    /// <summary>
    /// The enable_resource_name_dns_aaaa_record attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableResourceNameDnsAaaaRecord
    {
        set => SetProperty("enable_resource_name_dns_aaaa_record", value);
    }

    /// <summary>
    /// The hostname_type attribute.
    /// </summary>
    public TerraformProperty<string>? HostnameType
    {
        set => SetProperty("hostname_type", value);
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
        set => SetProperty("resource_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        set => SetProperty("tags", value);
    }

}

/// <summary>
/// Manages a aws_launch_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsLaunchTemplate : TerraformResource
{
    public AwsLaunchTemplate(string name) : base("aws_launch_template", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("latest_version");
        SetOutput("default_version");
        SetOutput("description");
        SetOutput("disable_api_stop");
        SetOutput("disable_api_termination");
        SetOutput("ebs_optimized");
        SetOutput("id");
        SetOutput("image_id");
        SetOutput("instance_initiated_shutdown_behavior");
        SetOutput("instance_type");
        SetOutput("kernel_id");
        SetOutput("key_name");
        SetOutput("name");
        SetOutput("name_prefix");
        SetOutput("ram_disk_id");
        SetOutput("region");
        SetOutput("security_group_names");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("update_default_version");
        SetOutput("user_data");
        SetOutput("vpc_security_group_ids");
    }

    /// <summary>
    /// The default_version attribute.
    /// </summary>
    public TerraformProperty<double> DefaultVersion
    {
        get => GetRequiredOutput<TerraformProperty<double>>("default_version");
        set => SetProperty("default_version", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The disable_api_stop attribute.
    /// </summary>
    public TerraformProperty<bool> DisableApiStop
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disable_api_stop");
        set => SetProperty("disable_api_stop", value);
    }

    /// <summary>
    /// The disable_api_termination attribute.
    /// </summary>
    public TerraformProperty<bool> DisableApiTermination
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disable_api_termination");
        set => SetProperty("disable_api_termination", value);
    }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    public TerraformProperty<string> EbsOptimized
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ebs_optimized");
        set => SetProperty("ebs_optimized", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    public TerraformProperty<string> ImageId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("image_id");
        set => SetProperty("image_id", value);
    }

    /// <summary>
    /// The instance_initiated_shutdown_behavior attribute.
    /// </summary>
    public TerraformProperty<string> InstanceInitiatedShutdownBehavior
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_initiated_shutdown_behavior");
        set => SetProperty("instance_initiated_shutdown_behavior", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformProperty<string> InstanceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_type");
        set => SetProperty("instance_type", value);
    }

    /// <summary>
    /// The kernel_id attribute.
    /// </summary>
    public TerraformProperty<string> KernelId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kernel_id");
        set => SetProperty("kernel_id", value);
    }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    public TerraformProperty<string> KeyName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_name");
        set => SetProperty("key_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string> NamePrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name_prefix");
        set => SetProperty("name_prefix", value);
    }

    /// <summary>
    /// The ram_disk_id attribute.
    /// </summary>
    public TerraformProperty<string> RamDiskId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ram_disk_id");
        set => SetProperty("ram_disk_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The security_group_names attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SecurityGroupNames
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("security_group_names");
        set => SetProperty("security_group_names", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The update_default_version attribute.
    /// </summary>
    public TerraformProperty<bool> UpdateDefaultVersion
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("update_default_version");
        set => SetProperty("update_default_version", value);
    }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    public TerraformProperty<string> UserData
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_data");
        set => SetProperty("user_data", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> VpcSecurityGroupIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("vpc_security_group_ids");
        set => SetProperty("vpc_security_group_ids", value);
    }

    /// <summary>
    /// Block for block_device_mappings.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLaunchTemplateBlockDeviceMappingsBlock>? BlockDeviceMappings
    {
        set => SetProperty("block_device_mappings", value);
    }

    /// <summary>
    /// Block for capacity_reservation_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityReservationSpecification block(s) allowed")]
    public List<AwsLaunchTemplateCapacityReservationSpecificationBlock>? CapacityReservationSpecification
    {
        set => SetProperty("capacity_reservation_specification", value);
    }

    /// <summary>
    /// Block for cpu_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CpuOptions block(s) allowed")]
    public List<AwsLaunchTemplateCpuOptionsBlock>? CpuOptions
    {
        set => SetProperty("cpu_options", value);
    }

    /// <summary>
    /// Block for credit_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CreditSpecification block(s) allowed")]
    public List<AwsLaunchTemplateCreditSpecificationBlock>? CreditSpecification
    {
        set => SetProperty("credit_specification", value);
    }

    /// <summary>
    /// Block for enclave_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnclaveOptions block(s) allowed")]
    public List<AwsLaunchTemplateEnclaveOptionsBlock>? EnclaveOptions
    {
        set => SetProperty("enclave_options", value);
    }

    /// <summary>
    /// Block for hibernation_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HibernationOptions block(s) allowed")]
    public List<AwsLaunchTemplateHibernationOptionsBlock>? HibernationOptions
    {
        set => SetProperty("hibernation_options", value);
    }

    /// <summary>
    /// Block for iam_instance_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IamInstanceProfile block(s) allowed")]
    public List<AwsLaunchTemplateIamInstanceProfileBlock>? IamInstanceProfile
    {
        set => SetProperty("iam_instance_profile", value);
    }

    /// <summary>
    /// Block for instance_market_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceMarketOptions block(s) allowed")]
    public List<AwsLaunchTemplateInstanceMarketOptionsBlock>? InstanceMarketOptions
    {
        set => SetProperty("instance_market_options", value);
    }

    /// <summary>
    /// Block for instance_requirements.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceRequirements block(s) allowed")]
    public List<AwsLaunchTemplateInstanceRequirementsBlock>? InstanceRequirements
    {
        set => SetProperty("instance_requirements", value);
    }

    /// <summary>
    /// Block for license_specification.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsLaunchTemplateLicenseSpecificationBlock>? LicenseSpecification
    {
        set => SetProperty("license_specification", value);
    }

    /// <summary>
    /// Block for maintenance_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceOptions block(s) allowed")]
    public List<AwsLaunchTemplateMaintenanceOptionsBlock>? MaintenanceOptions
    {
        set => SetProperty("maintenance_options", value);
    }

    /// <summary>
    /// Block for metadata_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetadataOptions block(s) allowed")]
    public List<AwsLaunchTemplateMetadataOptionsBlock>? MetadataOptions
    {
        set => SetProperty("metadata_options", value);
    }

    /// <summary>
    /// Block for monitoring.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Monitoring block(s) allowed")]
    public List<AwsLaunchTemplateMonitoringBlock>? Monitoring
    {
        set => SetProperty("monitoring", value);
    }

    /// <summary>
    /// Block for network_interfaces.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLaunchTemplateNetworkInterfacesBlock>? NetworkInterfaces
    {
        set => SetProperty("network_interfaces", value);
    }

    /// <summary>
    /// Block for placement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Placement block(s) allowed")]
    public List<AwsLaunchTemplatePlacementBlock>? Placement
    {
        set => SetProperty("placement", value);
    }

    /// <summary>
    /// Block for private_dns_name_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateDnsNameOptions block(s) allowed")]
    public List<AwsLaunchTemplatePrivateDnsNameOptionsBlock>? PrivateDnsNameOptions
    {
        set => SetProperty("private_dns_name_options", value);
    }

    /// <summary>
    /// Block for tag_specifications.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLaunchTemplateTagSpecificationsBlock>? TagSpecifications
    {
        set => SetProperty("tag_specifications", value);
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
