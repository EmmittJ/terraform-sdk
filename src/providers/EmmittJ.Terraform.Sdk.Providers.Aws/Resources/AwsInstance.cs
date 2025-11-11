using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for capacity_reservation_specification in .
/// Nesting mode: list
/// </summary>
public partial class AwsInstanceCapacityReservationSpecificationBlock : TerraformBlockBase
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
public partial class AwsInstanceCpuOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The amd_sev_snp attribute.
    /// </summary>
    [TerraformProperty("amd_sev_snp")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AmdSevSnp { get; set; }

    /// <summary>
    /// The core_count attribute.
    /// </summary>
    [TerraformProperty("core_count")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> CoreCount { get; set; }

    /// <summary>
    /// The threads_per_core attribute.
    /// </summary>
    [TerraformProperty("threads_per_core")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> ThreadsPerCore { get; set; }

}

/// <summary>
/// Block type for credit_specification in .
/// Nesting mode: list
/// </summary>
public partial class AwsInstanceCreditSpecificationBlock : TerraformBlockBase
{
    /// <summary>
    /// The cpu_credits attribute.
    /// </summary>
    [TerraformProperty("cpu_credits")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CpuCredits { get; set; }

}

/// <summary>
/// Block type for ebs_block_device in .
/// Nesting mode: set
/// </summary>
public partial class AwsInstanceEbsBlockDeviceBlock : TerraformBlockBase
{
    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    [TerraformProperty("delete_on_termination")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DeleteOnTermination { get; set; }

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    [TerraformProperty("device_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DeviceName { get; set; }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformProperty("encrypted")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> Encrypted { get; set; }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformProperty("iops")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> Iops { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> KmsKeyId { get; set; }

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    [TerraformProperty("snapshot_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> SnapshotId { get; set; }

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
    /// The throughput attribute.
    /// </summary>
    [TerraformProperty("throughput")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> Throughput { get; set; }


    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    [TerraformProperty("volume_size")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> VolumeSize { get; set; }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    [TerraformProperty("volume_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> VolumeType { get; set; }

}

/// <summary>
/// Block type for enclave_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsInstanceEnclaveOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for ephemeral_block_device in .
/// Nesting mode: set
/// </summary>
public partial class AwsInstanceEphemeralBlockDeviceBlock : TerraformBlockBase
{
    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    [TerraformProperty("device_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DeviceName { get; set; }

    /// <summary>
    /// The no_device attribute.
    /// </summary>
    [TerraformProperty("no_device")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? NoDevice { get; set; }

    /// <summary>
    /// The virtual_name attribute.
    /// </summary>
    [TerraformProperty("virtual_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? VirtualName { get; set; }

}

/// <summary>
/// Block type for instance_market_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsInstanceInstanceMarketOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The market_type attribute.
    /// </summary>
    [TerraformProperty("market_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> MarketType { get; set; }

}

/// <summary>
/// Block type for launch_template in .
/// Nesting mode: list
/// </summary>
public partial class AwsInstanceLaunchTemplateBlock : TerraformBlockBase
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Version { get; set; }

}

/// <summary>
/// Block type for maintenance_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsInstanceMaintenanceOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The auto_recovery attribute.
    /// </summary>
    [TerraformProperty("auto_recovery")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AutoRecovery { get; set; }

}

/// <summary>
/// Block type for metadata_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsInstanceMetadataOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The http_endpoint attribute.
    /// </summary>
    [TerraformProperty("http_endpoint")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? HttpEndpoint { get; set; }

    /// <summary>
    /// The http_protocol_ipv6 attribute.
    /// </summary>
    [TerraformProperty("http_protocol_ipv6")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? HttpProtocolIpv6 { get; set; }

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
/// Block type for network_interface in .
/// Nesting mode: set
/// </summary>
[Obsolete("This block is deprecated.")]
public partial class AwsInstanceNetworkInterfaceBlock : TerraformBlockBase
{
    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    [TerraformProperty("delete_on_termination")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DeleteOnTermination { get; set; }

    /// <summary>
    /// The device_index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceIndex is required")]
    [TerraformProperty("device_index")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> DeviceIndex { get; set; }

    /// <summary>
    /// The network_card_index attribute.
    /// </summary>
    [TerraformProperty("network_card_index")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? NetworkCardIndex { get; set; }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceId is required")]
    [TerraformProperty("network_interface_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> NetworkInterfaceId { get; set; }

}

/// <summary>
/// Block type for primary_network_interface in .
/// Nesting mode: list
/// </summary>
public partial class AwsInstancePrimaryNetworkInterfaceBlock : TerraformBlockBase
{

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceId is required")]
    [TerraformProperty("network_interface_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> NetworkInterfaceId { get; set; }

}

/// <summary>
/// Block type for private_dns_name_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsInstancePrivateDnsNameOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The enable_resource_name_dns_a_record attribute.
    /// </summary>
    [TerraformProperty("enable_resource_name_dns_a_record")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> EnableResourceNameDnsARecord { get; set; }

    /// <summary>
    /// The enable_resource_name_dns_aaaa_record attribute.
    /// </summary>
    [TerraformProperty("enable_resource_name_dns_aaaa_record")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> EnableResourceNameDnsAaaaRecord { get; set; }

    /// <summary>
    /// The hostname_type attribute.
    /// </summary>
    [TerraformProperty("hostname_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> HostnameType { get; set; }

}

/// <summary>
/// Block type for root_block_device in .
/// Nesting mode: list
/// </summary>
public partial class AwsInstanceRootBlockDeviceBlock : TerraformBlockBase
{
    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    [TerraformProperty("delete_on_termination")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DeleteOnTermination { get; set; }


    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformProperty("encrypted")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> Encrypted { get; set; }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformProperty("iops")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> Iops { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> KmsKeyId { get; set; }

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
    /// The throughput attribute.
    /// </summary>
    [TerraformProperty("throughput")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> Throughput { get; set; }


    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    [TerraformProperty("volume_size")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> VolumeSize { get; set; }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    [TerraformProperty("volume_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> VolumeType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsInstanceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsInstance : TerraformResource
{
    public AwsInstance(string name) : base("aws_instance", name)
    {
    }

    /// <summary>
    /// The ami attribute.
    /// </summary>
    [TerraformProperty("ami")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Ami { get; set; }

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    [TerraformProperty("associate_public_ip_address")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> AssociatePublicIpAddress { get; set; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformProperty("availability_zone")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AvailabilityZone { get; set; }

    /// <summary>
    /// The disable_api_stop attribute.
    /// </summary>
    [TerraformProperty("disable_api_stop")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> DisableApiStop { get; set; }

    /// <summary>
    /// The disable_api_termination attribute.
    /// </summary>
    [TerraformProperty("disable_api_termination")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> DisableApiTermination { get; set; }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    [TerraformProperty("ebs_optimized")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> EbsOptimized { get; set; }

    /// <summary>
    /// The enable_primary_ipv6 attribute.
    /// </summary>
    [TerraformProperty("enable_primary_ipv6")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> EnablePrimaryIpv6 { get; set; }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    [TerraformProperty("force_destroy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ForceDestroy { get; set; }

    /// <summary>
    /// The get_password_data attribute.
    /// </summary>
    [TerraformProperty("get_password_data")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? GetPasswordData { get; set; }

    /// <summary>
    /// The hibernation attribute.
    /// </summary>
    [TerraformProperty("hibernation")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Hibernation { get; set; }

    /// <summary>
    /// The host_id attribute.
    /// </summary>
    [TerraformProperty("host_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> HostId { get; set; }

    /// <summary>
    /// The host_resource_group_arn attribute.
    /// </summary>
    [TerraformProperty("host_resource_group_arn")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> HostResourceGroupArn { get; set; }

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    [TerraformProperty("iam_instance_profile")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> IamInstanceProfile { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The instance_initiated_shutdown_behavior attribute.
    /// </summary>
    [TerraformProperty("instance_initiated_shutdown_behavior")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> InstanceInitiatedShutdownBehavior { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformProperty("instance_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> InstanceType { get; set; }

    /// <summary>
    /// The ipv6_address_count attribute.
    /// </summary>
    [TerraformProperty("ipv6_address_count")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> Ipv6AddressCount { get; set; }

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    [TerraformProperty("ipv6_addresses")]
    // Optional+Computed - source generator will implement get/set
    public TerraformList<string> Ipv6Addresses { get; set; }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    [TerraformProperty("key_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> KeyName { get; set; }

    /// <summary>
    /// The monitoring attribute.
    /// </summary>
    [TerraformProperty("monitoring")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> Monitoring { get; set; }

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    [TerraformProperty("placement_group")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> PlacementGroup { get; set; }

    /// <summary>
    /// The placement_group_id attribute.
    /// </summary>
    [TerraformProperty("placement_group_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> PlacementGroupId { get; set; }

    /// <summary>
    /// The placement_partition_number attribute.
    /// </summary>
    [TerraformProperty("placement_partition_number")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> PlacementPartitionNumber { get; set; }

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    [TerraformProperty("private_ip")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> PrivateIp { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The secondary_private_ips attribute.
    /// </summary>
    [TerraformProperty("secondary_private_ips")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<string> SecondaryPrivateIps { get; set; }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformProperty("security_groups")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<string> SecurityGroups { get; set; }

    /// <summary>
    /// The source_dest_check attribute.
    /// </summary>
    [TerraformProperty("source_dest_check")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SourceDestCheck { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformProperty("subnet_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> SubnetId { get; set; }

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
    /// The tenancy attribute.
    /// </summary>
    [TerraformProperty("tenancy")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Tenancy { get; set; }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    [TerraformProperty("user_data")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? UserData { get; set; }

    /// <summary>
    /// The user_data_base64 attribute.
    /// </summary>
    [TerraformProperty("user_data_base64")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> UserDataBase64 { get; set; }

    /// <summary>
    /// The user_data_replace_on_change attribute.
    /// </summary>
    [TerraformProperty("user_data_replace_on_change")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? UserDataReplaceOnChange { get; set; }

    /// <summary>
    /// The volume_tags attribute.
    /// </summary>
    [TerraformProperty("volume_tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? VolumeTags { get; set; }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformProperty("vpc_security_group_ids")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<string> VpcSecurityGroupIds { get; set; }

    /// <summary>
    /// Block for capacity_reservation_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityReservationSpecification block(s) allowed")]
    [TerraformProperty("capacity_reservation_specification")]
    public TerraformList<TerraformBlock<AwsInstanceCapacityReservationSpecificationBlock>>? CapacityReservationSpecification { get; set; }

    /// <summary>
    /// Block for cpu_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CpuOptions block(s) allowed")]
    [TerraformProperty("cpu_options")]
    public TerraformList<TerraformBlock<AwsInstanceCpuOptionsBlock>>? CpuOptions { get; set; }

    /// <summary>
    /// Block for credit_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CreditSpecification block(s) allowed")]
    [TerraformProperty("credit_specification")]
    public TerraformList<TerraformBlock<AwsInstanceCreditSpecificationBlock>>? CreditSpecification { get; set; }

    /// <summary>
    /// Block for ebs_block_device.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("ebs_block_device")]
    public TerraformSet<TerraformBlock<AwsInstanceEbsBlockDeviceBlock>>? EbsBlockDevice { get; set; }

    /// <summary>
    /// Block for enclave_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnclaveOptions block(s) allowed")]
    [TerraformProperty("enclave_options")]
    public TerraformList<TerraformBlock<AwsInstanceEnclaveOptionsBlock>>? EnclaveOptions { get; set; }

    /// <summary>
    /// Block for ephemeral_block_device.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("ephemeral_block_device")]
    public TerraformSet<TerraformBlock<AwsInstanceEphemeralBlockDeviceBlock>>? EphemeralBlockDevice { get; set; }

    /// <summary>
    /// Block for instance_market_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceMarketOptions block(s) allowed")]
    [TerraformProperty("instance_market_options")]
    public TerraformList<TerraformBlock<AwsInstanceInstanceMarketOptionsBlock>>? InstanceMarketOptions { get; set; }

    /// <summary>
    /// Block for launch_template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchTemplate block(s) allowed")]
    [TerraformProperty("launch_template")]
    public TerraformList<TerraformBlock<AwsInstanceLaunchTemplateBlock>>? LaunchTemplate { get; set; }

    /// <summary>
    /// Block for maintenance_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceOptions block(s) allowed")]
    [TerraformProperty("maintenance_options")]
    public TerraformList<TerraformBlock<AwsInstanceMaintenanceOptionsBlock>>? MaintenanceOptions { get; set; }

    /// <summary>
    /// Block for metadata_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetadataOptions block(s) allowed")]
    [TerraformProperty("metadata_options")]
    public TerraformList<TerraformBlock<AwsInstanceMetadataOptionsBlock>>? MetadataOptions { get; set; }

    /// <summary>
    /// Block for network_interface.
    /// Nesting mode: set
    /// </summary>
    [Obsolete("This block is deprecated.")]
    [TerraformProperty("network_interface")]
    public TerraformSet<TerraformBlock<AwsInstanceNetworkInterfaceBlock>>? NetworkInterface { get; set; }

    /// <summary>
    /// Block for primary_network_interface.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrimaryNetworkInterface block(s) allowed")]
    [TerraformProperty("primary_network_interface")]
    public TerraformList<TerraformBlock<AwsInstancePrimaryNetworkInterfaceBlock>>? PrimaryNetworkInterface { get; set; }

    /// <summary>
    /// Block for private_dns_name_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateDnsNameOptions block(s) allowed")]
    [TerraformProperty("private_dns_name_options")]
    public TerraformList<TerraformBlock<AwsInstancePrivateDnsNameOptionsBlock>>? PrivateDnsNameOptions { get; set; }

    /// <summary>
    /// Block for root_block_device.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RootBlockDevice block(s) allowed")]
    [TerraformProperty("root_block_device")]
    public TerraformList<TerraformBlock<AwsInstanceRootBlockDeviceBlock>>? RootBlockDevice { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsInstanceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The instance_lifecycle attribute.
    /// </summary>
    [TerraformProperty("instance_lifecycle")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> InstanceLifecycle { get; }

    /// <summary>
    /// The instance_state attribute.
    /// </summary>
    [TerraformProperty("instance_state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> InstanceState { get; }

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    [TerraformProperty("outpost_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OutpostArn { get; }

    /// <summary>
    /// The password_data attribute.
    /// </summary>
    [TerraformProperty("password_data")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PasswordData { get; }

    /// <summary>
    /// The primary_network_interface_id attribute.
    /// </summary>
    [TerraformProperty("primary_network_interface_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryNetworkInterfaceId { get; }

    /// <summary>
    /// The private_dns attribute.
    /// </summary>
    [TerraformProperty("private_dns")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrivateDns { get; }

    /// <summary>
    /// The public_dns attribute.
    /// </summary>
    [TerraformProperty("public_dns")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PublicDns { get; }

    /// <summary>
    /// The public_ip attribute.
    /// </summary>
    [TerraformProperty("public_ip")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PublicIp { get; }

    /// <summary>
    /// The spot_instance_request_id attribute.
    /// </summary>
    [TerraformProperty("spot_instance_request_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SpotInstanceRequestId { get; }

}
