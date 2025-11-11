using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for capacity_reservation_specification in .
/// Nesting mode: list
/// </summary>
public class AwsSpotInstanceRequestCapacityReservationSpecificationBlock
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
public class AwsSpotInstanceRequestCpuOptionsBlock
{
    /// <summary>
    /// The amd_sev_snp attribute.
    /// </summary>
    [TerraformPropertyName("amd_sev_snp")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AmdSevSnp { get; set; } = default!;

    /// <summary>
    /// The core_count attribute.
    /// </summary>
    [TerraformPropertyName("core_count")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> CoreCount { get; set; } = default!;

    /// <summary>
    /// The threads_per_core attribute.
    /// </summary>
    [TerraformPropertyName("threads_per_core")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> ThreadsPerCore { get; set; } = default!;

}

/// <summary>
/// Block type for credit_specification in .
/// Nesting mode: list
/// </summary>
public class AwsSpotInstanceRequestCreditSpecificationBlock
{
    /// <summary>
    /// The cpu_credits attribute.
    /// </summary>
    [TerraformPropertyName("cpu_credits")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CpuCredits { get; set; }

}

/// <summary>
/// Block type for ebs_block_device in .
/// Nesting mode: set
/// </summary>
public class AwsSpotInstanceRequestEbsBlockDeviceBlock
{
    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    [TerraformPropertyName("delete_on_termination")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DeleteOnTermination { get; set; }

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    [TerraformPropertyName("device_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DeviceName { get; set; }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformPropertyName("encrypted")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> Encrypted { get; set; } = default!;

    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformPropertyName("iops")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> Iops { get; set; } = default!;

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KmsKeyId { get; set; } = default!;

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SnapshotId { get; set; } = default!;

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
    /// The throughput attribute.
    /// </summary>
    [TerraformPropertyName("throughput")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> Throughput { get; set; } = default!;


    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    [TerraformPropertyName("volume_size")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> VolumeSize { get; set; } = default!;

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    [TerraformPropertyName("volume_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> VolumeType { get; set; } = default!;

}

/// <summary>
/// Block type for enclave_options in .
/// Nesting mode: list
/// </summary>
public class AwsSpotInstanceRequestEnclaveOptionsBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> Enabled { get; set; } = default!;

}

/// <summary>
/// Block type for ephemeral_block_device in .
/// Nesting mode: set
/// </summary>
public class AwsSpotInstanceRequestEphemeralBlockDeviceBlock
{
    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    [TerraformPropertyName("device_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DeviceName { get; set; }

    /// <summary>
    /// The no_device attribute.
    /// </summary>
    [TerraformPropertyName("no_device")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? NoDevice { get; set; }

    /// <summary>
    /// The virtual_name attribute.
    /// </summary>
    [TerraformPropertyName("virtual_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VirtualName { get; set; }

}

/// <summary>
/// Block type for launch_template in .
/// Nesting mode: list
/// </summary>
public class AwsSpotInstanceRequestLaunchTemplateBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Version { get; set; }

}

/// <summary>
/// Block type for maintenance_options in .
/// Nesting mode: list
/// </summary>
public class AwsSpotInstanceRequestMaintenanceOptionsBlock
{
    /// <summary>
    /// The auto_recovery attribute.
    /// </summary>
    [TerraformPropertyName("auto_recovery")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AutoRecovery { get; set; } = default!;

}

/// <summary>
/// Block type for metadata_options in .
/// Nesting mode: list
/// </summary>
public class AwsSpotInstanceRequestMetadataOptionsBlock
{
    /// <summary>
    /// The http_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("http_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HttpEndpoint { get; set; }

    /// <summary>
    /// The http_protocol_ipv6 attribute.
    /// </summary>
    [TerraformPropertyName("http_protocol_ipv6")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HttpProtocolIpv6 { get; set; }

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
/// Block type for network_interface in .
/// Nesting mode: set
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsSpotInstanceRequestNetworkInterfaceBlock
{
    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    [TerraformPropertyName("delete_on_termination")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DeleteOnTermination { get; set; }

    /// <summary>
    /// The device_index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceIndex is required")]
    [TerraformPropertyName("device_index")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> DeviceIndex { get; set; }


    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceId is required")]
    [TerraformPropertyName("network_interface_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> NetworkInterfaceId { get; set; }

}

/// <summary>
/// Block type for private_dns_name_options in .
/// Nesting mode: list
/// </summary>
public class AwsSpotInstanceRequestPrivateDnsNameOptionsBlock
{
    /// <summary>
    /// The enable_resource_name_dns_a_record attribute.
    /// </summary>
    [TerraformPropertyName("enable_resource_name_dns_a_record")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EnableResourceNameDnsARecord { get; set; } = default!;

    /// <summary>
    /// The enable_resource_name_dns_aaaa_record attribute.
    /// </summary>
    [TerraformPropertyName("enable_resource_name_dns_aaaa_record")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EnableResourceNameDnsAaaaRecord { get; set; } = default!;

    /// <summary>
    /// The hostname_type attribute.
    /// </summary>
    [TerraformPropertyName("hostname_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> HostnameType { get; set; } = default!;

}

/// <summary>
/// Block type for root_block_device in .
/// Nesting mode: list
/// </summary>
public class AwsSpotInstanceRequestRootBlockDeviceBlock
{
    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    [TerraformPropertyName("delete_on_termination")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DeleteOnTermination { get; set; }


    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformPropertyName("encrypted")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> Encrypted { get; set; } = default!;

    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformPropertyName("iops")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> Iops { get; set; } = default!;

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KmsKeyId { get; set; } = default!;

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
    /// The throughput attribute.
    /// </summary>
    [TerraformPropertyName("throughput")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> Throughput { get; set; } = default!;


    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    [TerraformPropertyName("volume_size")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> VolumeSize { get; set; } = default!;

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    [TerraformPropertyName("volume_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> VolumeType { get; set; } = default!;

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsSpotInstanceRequestTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Manages a aws_spot_instance_request resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSpotInstanceRequest : TerraformResource
{
    public AwsSpotInstanceRequest(string name) : base("aws_spot_instance_request", name)
    {
    }

    /// <summary>
    /// The ami attribute.
    /// </summary>
    [TerraformPropertyName("ami")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Ami { get; set; } = default!;

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    [TerraformPropertyName("associate_public_ip_address")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> AssociatePublicIpAddress { get; set; } = default!;

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AvailabilityZone { get; set; } = default!;

    /// <summary>
    /// The disable_api_stop attribute.
    /// </summary>
    [TerraformPropertyName("disable_api_stop")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> DisableApiStop { get; set; } = default!;

    /// <summary>
    /// The disable_api_termination attribute.
    /// </summary>
    [TerraformPropertyName("disable_api_termination")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> DisableApiTermination { get; set; } = default!;

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    [TerraformPropertyName("ebs_optimized")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EbsOptimized { get; set; } = default!;

    /// <summary>
    /// The enable_primary_ipv6 attribute.
    /// </summary>
    [TerraformPropertyName("enable_primary_ipv6")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EnablePrimaryIpv6 { get; set; } = default!;

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    [TerraformPropertyName("force_destroy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ForceDestroy { get; set; }

    /// <summary>
    /// The get_password_data attribute.
    /// </summary>
    [TerraformPropertyName("get_password_data")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? GetPasswordData { get; set; }

    /// <summary>
    /// The hibernation attribute.
    /// </summary>
    [TerraformPropertyName("hibernation")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Hibernation { get; set; }

    /// <summary>
    /// The host_id attribute.
    /// </summary>
    [TerraformPropertyName("host_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> HostId { get; set; } = default!;

    /// <summary>
    /// The host_resource_group_arn attribute.
    /// </summary>
    [TerraformPropertyName("host_resource_group_arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> HostResourceGroupArn { get; set; } = default!;

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    [TerraformPropertyName("iam_instance_profile")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> IamInstanceProfile { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The instance_initiated_shutdown_behavior attribute.
    /// </summary>
    [TerraformPropertyName("instance_initiated_shutdown_behavior")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> InstanceInitiatedShutdownBehavior { get; set; } = default!;

    /// <summary>
    /// The instance_interruption_behavior attribute.
    /// </summary>
    [TerraformPropertyName("instance_interruption_behavior")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InstanceInterruptionBehavior { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformPropertyName("instance_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> InstanceType { get; set; } = default!;

    /// <summary>
    /// The ipv6_address_count attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_address_count")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> Ipv6AddressCount { get; set; } = default!;

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_addresses")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> Ipv6Addresses { get; set; } = default!;

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    [TerraformPropertyName("key_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KeyName { get; set; } = default!;

    /// <summary>
    /// The launch_group attribute.
    /// </summary>
    [TerraformPropertyName("launch_group")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LaunchGroup { get; set; }

    /// <summary>
    /// The monitoring attribute.
    /// </summary>
    [TerraformPropertyName("monitoring")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> Monitoring { get; set; } = default!;

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    [TerraformPropertyName("placement_group")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PlacementGroup { get; set; } = default!;

    /// <summary>
    /// The placement_group_id attribute.
    /// </summary>
    [TerraformPropertyName("placement_group_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PlacementGroupId { get; set; } = default!;

    /// <summary>
    /// The placement_partition_number attribute.
    /// </summary>
    [TerraformPropertyName("placement_partition_number")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> PlacementPartitionNumber { get; set; } = default!;

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    [TerraformPropertyName("private_ip")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PrivateIp { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The secondary_private_ips attribute.
    /// </summary>
    [TerraformPropertyName("secondary_private_ips")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> SecondaryPrivateIps { get; set; } = default!;

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformPropertyName("security_groups")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> SecurityGroups { get; set; } = default!;

    /// <summary>
    /// The source_dest_check attribute.
    /// </summary>
    [TerraformPropertyName("source_dest_check")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SourceDestCheck { get; set; }

    /// <summary>
    /// The spot_price attribute.
    /// </summary>
    [TerraformPropertyName("spot_price")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SpotPrice { get; set; } = default!;

    /// <summary>
    /// The spot_type attribute.
    /// </summary>
    [TerraformPropertyName("spot_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SpotType { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SubnetId { get; set; } = default!;

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
    /// The tenancy attribute.
    /// </summary>
    [TerraformPropertyName("tenancy")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Tenancy { get; set; } = default!;

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    [TerraformPropertyName("user_data")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UserData { get; set; }

    /// <summary>
    /// The user_data_base64 attribute.
    /// </summary>
    [TerraformPropertyName("user_data_base64")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> UserDataBase64 { get; set; } = default!;

    /// <summary>
    /// The user_data_replace_on_change attribute.
    /// </summary>
    [TerraformPropertyName("user_data_replace_on_change")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? UserDataReplaceOnChange { get; set; }

    /// <summary>
    /// The valid_from attribute.
    /// </summary>
    [TerraformPropertyName("valid_from")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ValidFrom { get; set; } = default!;

    /// <summary>
    /// The valid_until attribute.
    /// </summary>
    [TerraformPropertyName("valid_until")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ValidUntil { get; set; } = default!;

    /// <summary>
    /// The volume_tags attribute.
    /// </summary>
    [TerraformPropertyName("volume_tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? VolumeTags { get; set; }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("vpc_security_group_ids")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> VpcSecurityGroupIds { get; set; } = default!;

    /// <summary>
    /// The wait_for_fulfillment attribute.
    /// </summary>
    [TerraformPropertyName("wait_for_fulfillment")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? WaitForFulfillment { get; set; }

    /// <summary>
    /// Block for capacity_reservation_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityReservationSpecification block(s) allowed")]
    [TerraformPropertyName("capacity_reservation_specification")]
    public TerraformList<TerraformBlock<AwsSpotInstanceRequestCapacityReservationSpecificationBlock>>? CapacityReservationSpecification { get; set; }

    /// <summary>
    /// Block for cpu_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CpuOptions block(s) allowed")]
    [TerraformPropertyName("cpu_options")]
    public TerraformList<TerraformBlock<AwsSpotInstanceRequestCpuOptionsBlock>>? CpuOptions { get; set; }

    /// <summary>
    /// Block for credit_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CreditSpecification block(s) allowed")]
    [TerraformPropertyName("credit_specification")]
    public TerraformList<TerraformBlock<AwsSpotInstanceRequestCreditSpecificationBlock>>? CreditSpecification { get; set; }

    /// <summary>
    /// Block for ebs_block_device.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("ebs_block_device")]
    public TerraformSet<TerraformBlock<AwsSpotInstanceRequestEbsBlockDeviceBlock>>? EbsBlockDevice { get; set; }

    /// <summary>
    /// Block for enclave_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnclaveOptions block(s) allowed")]
    [TerraformPropertyName("enclave_options")]
    public TerraformList<TerraformBlock<AwsSpotInstanceRequestEnclaveOptionsBlock>>? EnclaveOptions { get; set; }

    /// <summary>
    /// Block for ephemeral_block_device.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("ephemeral_block_device")]
    public TerraformSet<TerraformBlock<AwsSpotInstanceRequestEphemeralBlockDeviceBlock>>? EphemeralBlockDevice { get; set; }

    /// <summary>
    /// Block for launch_template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchTemplate block(s) allowed")]
    [TerraformPropertyName("launch_template")]
    public TerraformList<TerraformBlock<AwsSpotInstanceRequestLaunchTemplateBlock>>? LaunchTemplate { get; set; }

    /// <summary>
    /// Block for maintenance_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceOptions block(s) allowed")]
    [TerraformPropertyName("maintenance_options")]
    public TerraformList<TerraformBlock<AwsSpotInstanceRequestMaintenanceOptionsBlock>>? MaintenanceOptions { get; set; }

    /// <summary>
    /// Block for metadata_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetadataOptions block(s) allowed")]
    [TerraformPropertyName("metadata_options")]
    public TerraformList<TerraformBlock<AwsSpotInstanceRequestMetadataOptionsBlock>>? MetadataOptions { get; set; }

    /// <summary>
    /// Block for network_interface.
    /// Nesting mode: set
    /// </summary>
    [Obsolete("This block is deprecated.")]
    [TerraformPropertyName("network_interface")]
    public TerraformSet<TerraformBlock<AwsSpotInstanceRequestNetworkInterfaceBlock>>? NetworkInterface { get; set; }

    /// <summary>
    /// Block for private_dns_name_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateDnsNameOptions block(s) allowed")]
    [TerraformPropertyName("private_dns_name_options")]
    public TerraformList<TerraformBlock<AwsSpotInstanceRequestPrivateDnsNameOptionsBlock>>? PrivateDnsNameOptions { get; set; }

    /// <summary>
    /// Block for root_block_device.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RootBlockDevice block(s) allowed")]
    [TerraformPropertyName("root_block_device")]
    public TerraformList<TerraformBlock<AwsSpotInstanceRequestRootBlockDeviceBlock>>? RootBlockDevice { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsSpotInstanceRequestTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The instance_state attribute.
    /// </summary>
    [TerraformPropertyName("instance_state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InstanceState => new TerraformReference(this, "instance_state");

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    [TerraformPropertyName("outpost_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OutpostArn => new TerraformReference(this, "outpost_arn");

    /// <summary>
    /// The password_data attribute.
    /// </summary>
    [TerraformPropertyName("password_data")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PasswordData => new TerraformReference(this, "password_data");

    /// <summary>
    /// The primary_network_interface attribute.
    /// </summary>
    [TerraformPropertyName("primary_network_interface")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PrimaryNetworkInterface => new TerraformReference(this, "primary_network_interface");

    /// <summary>
    /// The primary_network_interface_id attribute.
    /// </summary>
    [TerraformPropertyName("primary_network_interface_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryNetworkInterfaceId => new TerraformReference(this, "primary_network_interface_id");

    /// <summary>
    /// The private_dns attribute.
    /// </summary>
    [TerraformPropertyName("private_dns")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrivateDns => new TerraformReference(this, "private_dns");

    /// <summary>
    /// The public_dns attribute.
    /// </summary>
    [TerraformPropertyName("public_dns")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PublicDns => new TerraformReference(this, "public_dns");

    /// <summary>
    /// The public_ip attribute.
    /// </summary>
    [TerraformPropertyName("public_ip")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PublicIp => new TerraformReference(this, "public_ip");

    /// <summary>
    /// The spot_bid_status attribute.
    /// </summary>
    [TerraformPropertyName("spot_bid_status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SpotBidStatus => new TerraformReference(this, "spot_bid_status");

    /// <summary>
    /// The spot_instance_id attribute.
    /// </summary>
    [TerraformPropertyName("spot_instance_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SpotInstanceId => new TerraformReference(this, "spot_instance_id");

    /// <summary>
    /// The spot_request_state attribute.
    /// </summary>
    [TerraformPropertyName("spot_request_state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SpotRequestState => new TerraformReference(this, "spot_request_state");

}
