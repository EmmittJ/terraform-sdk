using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for capacity_reservation_specification in .
/// Nesting mode: list
/// </summary>
public partial class AwsSpotInstanceRequestCapacityReservationSpecificationBlock() : TerraformBlock("capacity_reservation_specification")
{
    /// <summary>
    /// The capacity_reservation_preference attribute.
    /// </summary>
    [TerraformProperty("capacity_reservation_preference")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CapacityReservationPreference { get; set; }

}

/// <summary>
/// Block type for cpu_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsSpotInstanceRequestCpuOptionsBlock() : TerraformBlock("cpu_options")
{
    /// <summary>
    /// The amd_sev_snp attribute.
    /// </summary>
    [TerraformProperty("amd_sev_snp")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AmdSevSnp { get; set; }

    /// <summary>
    /// The core_count attribute.
    /// </summary>
    [TerraformProperty("core_count")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> CoreCount { get; set; }

    /// <summary>
    /// The threads_per_core attribute.
    /// </summary>
    [TerraformProperty("threads_per_core")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> ThreadsPerCore { get; set; }

}

/// <summary>
/// Block type for credit_specification in .
/// Nesting mode: list
/// </summary>
public partial class AwsSpotInstanceRequestCreditSpecificationBlock() : TerraformBlock("credit_specification")
{
    /// <summary>
    /// The cpu_credits attribute.
    /// </summary>
    [TerraformProperty("cpu_credits")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CpuCredits { get; set; }

}

/// <summary>
/// Block type for ebs_block_device in .
/// Nesting mode: set
/// </summary>
public partial class AwsSpotInstanceRequestEbsBlockDeviceBlock() : TerraformBlock("ebs_block_device")
{
    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    [TerraformProperty("delete_on_termination")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeleteOnTermination { get; set; }

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    [TerraformProperty("device_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DeviceName { get; set; }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformProperty("encrypted")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> Encrypted { get; set; }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformProperty("iops")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Iops { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KmsKeyId { get; set; }

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    [TerraformProperty("snapshot_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SnapshotId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    [TerraformProperty("throughput")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Throughput { get; set; }


    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    [TerraformProperty("volume_size")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> VolumeSize { get; set; }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    [TerraformProperty("volume_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> VolumeType { get; set; }

}

/// <summary>
/// Block type for enclave_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsSpotInstanceRequestEnclaveOptionsBlock() : TerraformBlock("enclave_options")
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for ephemeral_block_device in .
/// Nesting mode: set
/// </summary>
public partial class AwsSpotInstanceRequestEphemeralBlockDeviceBlock() : TerraformBlock("ephemeral_block_device")
{
    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    [TerraformProperty("device_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DeviceName { get; set; }

    /// <summary>
    /// The no_device attribute.
    /// </summary>
    [TerraformProperty("no_device")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? NoDevice { get; set; }

    /// <summary>
    /// The virtual_name attribute.
    /// </summary>
    [TerraformProperty("virtual_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VirtualName { get; set; }

}

/// <summary>
/// Block type for launch_template in .
/// Nesting mode: list
/// </summary>
public partial class AwsSpotInstanceRequestLaunchTemplateBlock() : TerraformBlock("launch_template")
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Version { get; set; }

}

/// <summary>
/// Block type for maintenance_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsSpotInstanceRequestMaintenanceOptionsBlock() : TerraformBlock("maintenance_options")
{
    /// <summary>
    /// The auto_recovery attribute.
    /// </summary>
    [TerraformProperty("auto_recovery")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AutoRecovery { get; set; }

}

/// <summary>
/// Block type for metadata_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsSpotInstanceRequestMetadataOptionsBlock() : TerraformBlock("metadata_options")
{
    /// <summary>
    /// The http_endpoint attribute.
    /// </summary>
    [TerraformProperty("http_endpoint")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HttpEndpoint { get; set; }

    /// <summary>
    /// The http_protocol_ipv6 attribute.
    /// </summary>
    [TerraformProperty("http_protocol_ipv6")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HttpProtocolIpv6 { get; set; }

    /// <summary>
    /// The http_put_response_hop_limit attribute.
    /// </summary>
    [TerraformProperty("http_put_response_hop_limit")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> HttpPutResponseHopLimit { get; set; }

    /// <summary>
    /// The http_tokens attribute.
    /// </summary>
    [TerraformProperty("http_tokens")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> HttpTokens { get; set; }

    /// <summary>
    /// The instance_metadata_tags attribute.
    /// </summary>
    [TerraformProperty("instance_metadata_tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> InstanceMetadataTags { get; set; }

}

/// <summary>
/// Block type for network_interface in .
/// Nesting mode: set
/// </summary>
[Obsolete("This block is deprecated.")]
public partial class AwsSpotInstanceRequestNetworkInterfaceBlock() : TerraformBlock("network_interface")
{
    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    [TerraformProperty("delete_on_termination")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeleteOnTermination { get; set; }

    /// <summary>
    /// The device_index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceIndex is required")]
    [TerraformProperty("device_index")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> DeviceIndex { get; set; }


    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceId is required")]
    [TerraformProperty("network_interface_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NetworkInterfaceId { get; set; }

}

/// <summary>
/// Block type for private_dns_name_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsSpotInstanceRequestPrivateDnsNameOptionsBlock() : TerraformBlock("private_dns_name_options")
{
    /// <summary>
    /// The enable_resource_name_dns_a_record attribute.
    /// </summary>
    [TerraformProperty("enable_resource_name_dns_a_record")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> EnableResourceNameDnsARecord { get; set; }

    /// <summary>
    /// The enable_resource_name_dns_aaaa_record attribute.
    /// </summary>
    [TerraformProperty("enable_resource_name_dns_aaaa_record")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> EnableResourceNameDnsAaaaRecord { get; set; }

    /// <summary>
    /// The hostname_type attribute.
    /// </summary>
    [TerraformProperty("hostname_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> HostnameType { get; set; }

}

/// <summary>
/// Block type for root_block_device in .
/// Nesting mode: list
/// </summary>
public partial class AwsSpotInstanceRequestRootBlockDeviceBlock() : TerraformBlock("root_block_device")
{
    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    [TerraformProperty("delete_on_termination")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeleteOnTermination { get; set; }


    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformProperty("encrypted")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> Encrypted { get; set; }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformProperty("iops")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Iops { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KmsKeyId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    [TerraformProperty("throughput")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Throughput { get; set; }


    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    [TerraformProperty("volume_size")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> VolumeSize { get; set; }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    [TerraformProperty("volume_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> VolumeType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsSpotInstanceRequestTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Manages a aws_spot_instance_request resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSpotInstanceRequest : TerraformResource
{
    public AwsSpotInstanceRequest(string name) : base("aws_spot_instance_request", name)
    {
    }

    /// <summary>
    /// The ami attribute.
    /// </summary>
    [TerraformProperty("ami")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Ami { get; set; }

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    [TerraformProperty("associate_public_ip_address")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> AssociatePublicIpAddress { get; set; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformProperty("availability_zone")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AvailabilityZone { get; set; }

    /// <summary>
    /// The disable_api_stop attribute.
    /// </summary>
    [TerraformProperty("disable_api_stop")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> DisableApiStop { get; set; }

    /// <summary>
    /// The disable_api_termination attribute.
    /// </summary>
    [TerraformProperty("disable_api_termination")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> DisableApiTermination { get; set; }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    [TerraformProperty("ebs_optimized")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> EbsOptimized { get; set; }

    /// <summary>
    /// The enable_primary_ipv6 attribute.
    /// </summary>
    [TerraformProperty("enable_primary_ipv6")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> EnablePrimaryIpv6 { get; set; }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    [TerraformProperty("force_destroy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ForceDestroy { get; set; }

    /// <summary>
    /// The get_password_data attribute.
    /// </summary>
    [TerraformProperty("get_password_data")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? GetPasswordData { get; set; }

    /// <summary>
    /// The hibernation attribute.
    /// </summary>
    [TerraformProperty("hibernation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Hibernation { get; set; }

    /// <summary>
    /// The host_id attribute.
    /// </summary>
    [TerraformProperty("host_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> HostId { get; set; }

    /// <summary>
    /// The host_resource_group_arn attribute.
    /// </summary>
    [TerraformProperty("host_resource_group_arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> HostResourceGroupArn { get; set; }

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    [TerraformProperty("iam_instance_profile")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> IamInstanceProfile { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The instance_initiated_shutdown_behavior attribute.
    /// </summary>
    [TerraformProperty("instance_initiated_shutdown_behavior")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> InstanceInitiatedShutdownBehavior { get; set; }

    /// <summary>
    /// The instance_interruption_behavior attribute.
    /// </summary>
    [TerraformProperty("instance_interruption_behavior")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InstanceInterruptionBehavior { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformProperty("instance_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> InstanceType { get; set; }

    /// <summary>
    /// The ipv6_address_count attribute.
    /// </summary>
    [TerraformProperty("ipv6_address_count")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Ipv6AddressCount { get; set; }

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    [TerraformProperty("ipv6_addresses")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> Ipv6Addresses { get; set; }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    [TerraformProperty("key_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KeyName { get; set; }

    /// <summary>
    /// The launch_group attribute.
    /// </summary>
    [TerraformProperty("launch_group")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LaunchGroup { get; set; }

    /// <summary>
    /// The monitoring attribute.
    /// </summary>
    [TerraformProperty("monitoring")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> Monitoring { get; set; }

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    [TerraformProperty("placement_group")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PlacementGroup { get; set; }

    /// <summary>
    /// The placement_group_id attribute.
    /// </summary>
    [TerraformProperty("placement_group_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PlacementGroupId { get; set; }

    /// <summary>
    /// The placement_partition_number attribute.
    /// </summary>
    [TerraformProperty("placement_partition_number")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> PlacementPartitionNumber { get; set; }

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    [TerraformProperty("private_ip")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PrivateIp { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The secondary_private_ips attribute.
    /// </summary>
    [TerraformProperty("secondary_private_ips")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> SecondaryPrivateIps { get; set; }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformProperty("security_groups")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> SecurityGroups { get; set; }

    /// <summary>
    /// The source_dest_check attribute.
    /// </summary>
    [TerraformProperty("source_dest_check")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SourceDestCheck { get; set; }

    /// <summary>
    /// The spot_price attribute.
    /// </summary>
    [TerraformProperty("spot_price")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SpotPrice { get; set; }

    /// <summary>
    /// The spot_type attribute.
    /// </summary>
    [TerraformProperty("spot_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SpotType { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformProperty("subnet_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SubnetId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    [TerraformProperty("tenancy")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Tenancy { get; set; }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    [TerraformProperty("user_data")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserData { get; set; }

    /// <summary>
    /// The user_data_base64 attribute.
    /// </summary>
    [TerraformProperty("user_data_base64")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> UserDataBase64 { get; set; }

    /// <summary>
    /// The user_data_replace_on_change attribute.
    /// </summary>
    [TerraformProperty("user_data_replace_on_change")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UserDataReplaceOnChange { get; set; }

    /// <summary>
    /// The valid_from attribute.
    /// </summary>
    [TerraformProperty("valid_from")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ValidFrom { get; set; }

    /// <summary>
    /// The valid_until attribute.
    /// </summary>
    [TerraformProperty("valid_until")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ValidUntil { get; set; }

    /// <summary>
    /// The volume_tags attribute.
    /// </summary>
    [TerraformProperty("volume_tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? VolumeTags { get; set; }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformProperty("vpc_security_group_ids")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> VpcSecurityGroupIds { get; set; }

    /// <summary>
    /// The wait_for_fulfillment attribute.
    /// </summary>
    [TerraformProperty("wait_for_fulfillment")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? WaitForFulfillment { get; set; }

    /// <summary>
    /// Block for capacity_reservation_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityReservationSpecification block(s) allowed")]
    [TerraformProperty("capacity_reservation_specification")]
    public TerraformList<AwsSpotInstanceRequestCapacityReservationSpecificationBlock> CapacityReservationSpecification { get; set; } = new();

    /// <summary>
    /// Block for cpu_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CpuOptions block(s) allowed")]
    [TerraformProperty("cpu_options")]
    public TerraformList<AwsSpotInstanceRequestCpuOptionsBlock> CpuOptions { get; set; } = new();

    /// <summary>
    /// Block for credit_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CreditSpecification block(s) allowed")]
    [TerraformProperty("credit_specification")]
    public TerraformList<AwsSpotInstanceRequestCreditSpecificationBlock> CreditSpecification { get; set; } = new();

    /// <summary>
    /// Block for ebs_block_device.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("ebs_block_device")]
    public TerraformSet<AwsSpotInstanceRequestEbsBlockDeviceBlock> EbsBlockDevice { get; set; } = new();

    /// <summary>
    /// Block for enclave_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnclaveOptions block(s) allowed")]
    [TerraformProperty("enclave_options")]
    public TerraformList<AwsSpotInstanceRequestEnclaveOptionsBlock> EnclaveOptions { get; set; } = new();

    /// <summary>
    /// Block for ephemeral_block_device.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("ephemeral_block_device")]
    public TerraformSet<AwsSpotInstanceRequestEphemeralBlockDeviceBlock> EphemeralBlockDevice { get; set; } = new();

    /// <summary>
    /// Block for launch_template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchTemplate block(s) allowed")]
    [TerraformProperty("launch_template")]
    public TerraformList<AwsSpotInstanceRequestLaunchTemplateBlock> LaunchTemplate { get; set; } = new();

    /// <summary>
    /// Block for maintenance_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceOptions block(s) allowed")]
    [TerraformProperty("maintenance_options")]
    public TerraformList<AwsSpotInstanceRequestMaintenanceOptionsBlock> MaintenanceOptions { get; set; } = new();

    /// <summary>
    /// Block for metadata_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetadataOptions block(s) allowed")]
    [TerraformProperty("metadata_options")]
    public TerraformList<AwsSpotInstanceRequestMetadataOptionsBlock> MetadataOptions { get; set; } = new();

    /// <summary>
    /// Block for network_interface.
    /// Nesting mode: set
    /// </summary>
    [Obsolete("This block is deprecated.")]
    [TerraformProperty("network_interface")]
    public TerraformSet<AwsSpotInstanceRequestNetworkInterfaceBlock> NetworkInterface { get; set; } = new();

    /// <summary>
    /// Block for private_dns_name_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateDnsNameOptions block(s) allowed")]
    [TerraformProperty("private_dns_name_options")]
    public TerraformList<AwsSpotInstanceRequestPrivateDnsNameOptionsBlock> PrivateDnsNameOptions { get; set; } = new();

    /// <summary>
    /// Block for root_block_device.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RootBlockDevice block(s) allowed")]
    [TerraformProperty("root_block_device")]
    public TerraformList<AwsSpotInstanceRequestRootBlockDeviceBlock> RootBlockDevice { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsSpotInstanceRequestTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The instance_state attribute.
    /// </summary>
    [TerraformProperty("instance_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> InstanceState { get; }

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    [TerraformProperty("outpost_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OutpostArn { get; }

    /// <summary>
    /// The password_data attribute.
    /// </summary>
    [TerraformProperty("password_data")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PasswordData { get; }

    /// <summary>
    /// The primary_network_interface attribute.
    /// </summary>
    [TerraformProperty("primary_network_interface")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> PrimaryNetworkInterface { get; }

    /// <summary>
    /// The primary_network_interface_id attribute.
    /// </summary>
    [TerraformProperty("primary_network_interface_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryNetworkInterfaceId { get; }

    /// <summary>
    /// The private_dns attribute.
    /// </summary>
    [TerraformProperty("private_dns")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrivateDns { get; }

    /// <summary>
    /// The public_dns attribute.
    /// </summary>
    [TerraformProperty("public_dns")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PublicDns { get; }

    /// <summary>
    /// The public_ip attribute.
    /// </summary>
    [TerraformProperty("public_ip")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PublicIp { get; }

    /// <summary>
    /// The spot_bid_status attribute.
    /// </summary>
    [TerraformProperty("spot_bid_status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SpotBidStatus { get; }

    /// <summary>
    /// The spot_instance_id attribute.
    /// </summary>
    [TerraformProperty("spot_instance_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SpotInstanceId { get; }

    /// <summary>
    /// The spot_request_state attribute.
    /// </summary>
    [TerraformProperty("spot_request_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SpotRequestState { get; }

}
