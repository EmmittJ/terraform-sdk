using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for capacity_reservation_specification in .
/// Nesting mode: list
/// </summary>
public class AwsSpotInstanceRequestCapacityReservationSpecificationBlock : ITerraformBlock
{
    /// <summary>
    /// The capacity_reservation_preference attribute.
    /// </summary>
    [TerraformPropertyName("capacity_reservation_preference")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CapacityReservationPreference { get; set; }

}

/// <summary>
/// Block type for cpu_options in .
/// Nesting mode: list
/// </summary>
public class AwsSpotInstanceRequestCpuOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The amd_sev_snp attribute.
    /// </summary>
    [TerraformPropertyName("amd_sev_snp")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AmdSevSnp { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "amd_sev_snp");

    /// <summary>
    /// The core_count attribute.
    /// </summary>
    [TerraformPropertyName("core_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> CoreCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "core_count");

    /// <summary>
    /// The threads_per_core attribute.
    /// </summary>
    [TerraformPropertyName("threads_per_core")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> ThreadsPerCore { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "threads_per_core");

}

/// <summary>
/// Block type for credit_specification in .
/// Nesting mode: list
/// </summary>
public class AwsSpotInstanceRequestCreditSpecificationBlock : ITerraformBlock
{
    /// <summary>
    /// The cpu_credits attribute.
    /// </summary>
    [TerraformPropertyName("cpu_credits")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CpuCredits { get; set; }

}

/// <summary>
/// Block type for ebs_block_device in .
/// Nesting mode: set
/// </summary>
public class AwsSpotInstanceRequestEbsBlockDeviceBlock : ITerraformBlock
{
    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    [TerraformPropertyName("delete_on_termination")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DeleteOnTermination { get; set; }

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    [TerraformPropertyName("device_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DeviceName { get; set; }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformPropertyName("encrypted")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> Encrypted { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "encrypted");

    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformPropertyName("iops")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Iops { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "iops");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KmsKeyId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "kms_key_id");

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SnapshotId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "snapshot_id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>("", "tags_all");

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    [TerraformPropertyName("throughput")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Throughput { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "throughput");

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    [TerraformPropertyName("volume_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VolumeId => new TerraformReferenceProperty<TerraformProperty<string>>("", "volume_id");

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    [TerraformPropertyName("volume_size")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> VolumeSize { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "volume_size");

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    [TerraformPropertyName("volume_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> VolumeType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "volume_type");

}

/// <summary>
/// Block type for enclave_options in .
/// Nesting mode: list
/// </summary>
public class AwsSpotInstanceRequestEnclaveOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> Enabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "enabled");

}

/// <summary>
/// Block type for ephemeral_block_device in .
/// Nesting mode: set
/// </summary>
public class AwsSpotInstanceRequestEphemeralBlockDeviceBlock : ITerraformBlock
{
    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    [TerraformPropertyName("device_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DeviceName { get; set; }

    /// <summary>
    /// The no_device attribute.
    /// </summary>
    [TerraformPropertyName("no_device")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? NoDevice { get; set; }

    /// <summary>
    /// The virtual_name attribute.
    /// </summary>
    [TerraformPropertyName("virtual_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VirtualName { get; set; }

}

/// <summary>
/// Block type for launch_template in .
/// Nesting mode: list
/// </summary>
public class AwsSpotInstanceRequestLaunchTemplateBlock : ITerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "name");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Version { get; set; }

}

/// <summary>
/// Block type for maintenance_options in .
/// Nesting mode: list
/// </summary>
public class AwsSpotInstanceRequestMaintenanceOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The auto_recovery attribute.
    /// </summary>
    [TerraformPropertyName("auto_recovery")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AutoRecovery { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "auto_recovery");

}

/// <summary>
/// Block type for metadata_options in .
/// Nesting mode: list
/// </summary>
public class AwsSpotInstanceRequestMetadataOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The http_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("http_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HttpEndpoint { get; set; }

    /// <summary>
    /// The http_protocol_ipv6 attribute.
    /// </summary>
    [TerraformPropertyName("http_protocol_ipv6")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HttpProtocolIpv6 { get; set; }

    /// <summary>
    /// The http_put_response_hop_limit attribute.
    /// </summary>
    [TerraformPropertyName("http_put_response_hop_limit")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> HttpPutResponseHopLimit { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "http_put_response_hop_limit");

    /// <summary>
    /// The http_tokens attribute.
    /// </summary>
    [TerraformPropertyName("http_tokens")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> HttpTokens { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "http_tokens");

    /// <summary>
    /// The instance_metadata_tags attribute.
    /// </summary>
    [TerraformPropertyName("instance_metadata_tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> InstanceMetadataTags { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "instance_metadata_tags");

}

/// <summary>
/// Block type for network_interface in .
/// Nesting mode: set
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsSpotInstanceRequestNetworkInterfaceBlock : ITerraformBlock
{
    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    [TerraformPropertyName("delete_on_termination")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DeleteOnTermination { get; set; }

    /// <summary>
    /// The device_index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceIndex is required")]
    [TerraformPropertyName("device_index")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> DeviceIndex { get; set; }

    /// <summary>
    /// The network_card_index attribute.
    /// </summary>
    [TerraformPropertyName("network_card_index")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> NetworkCardIndex => new TerraformReferenceProperty<TerraformProperty<double>>("", "network_card_index");

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceId is required")]
    [TerraformPropertyName("network_interface_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NetworkInterfaceId { get; set; }

}

/// <summary>
/// Block type for private_dns_name_options in .
/// Nesting mode: list
/// </summary>
public class AwsSpotInstanceRequestPrivateDnsNameOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The enable_resource_name_dns_a_record attribute.
    /// </summary>
    [TerraformPropertyName("enable_resource_name_dns_a_record")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> EnableResourceNameDnsARecord { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "enable_resource_name_dns_a_record");

    /// <summary>
    /// The enable_resource_name_dns_aaaa_record attribute.
    /// </summary>
    [TerraformPropertyName("enable_resource_name_dns_aaaa_record")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> EnableResourceNameDnsAaaaRecord { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "enable_resource_name_dns_aaaa_record");

    /// <summary>
    /// The hostname_type attribute.
    /// </summary>
    [TerraformPropertyName("hostname_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> HostnameType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "hostname_type");

}

/// <summary>
/// Block type for root_block_device in .
/// Nesting mode: list
/// </summary>
public class AwsSpotInstanceRequestRootBlockDeviceBlock : ITerraformBlock
{
    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    [TerraformPropertyName("delete_on_termination")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DeleteOnTermination { get; set; }

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [TerraformPropertyName("device_name")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeviceName => new TerraformReferenceProperty<TerraformProperty<string>>("", "device_name");

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformPropertyName("encrypted")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> Encrypted { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "encrypted");

    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformPropertyName("iops")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Iops { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "iops");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KmsKeyId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "kms_key_id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>("", "tags_all");

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    [TerraformPropertyName("throughput")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Throughput { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "throughput");

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    [TerraformPropertyName("volume_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VolumeId => new TerraformReferenceProperty<TerraformProperty<string>>("", "volume_id");

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    [TerraformPropertyName("volume_size")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> VolumeSize { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "volume_size");

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    [TerraformPropertyName("volume_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> VolumeType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "volume_type");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsSpotInstanceRequestTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Ami { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ami");

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    [TerraformPropertyName("associate_public_ip_address")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> AssociatePublicIpAddress { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "associate_public_ip_address");

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AvailabilityZone { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone");

    /// <summary>
    /// The disable_api_stop attribute.
    /// </summary>
    [TerraformPropertyName("disable_api_stop")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> DisableApiStop { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "disable_api_stop");

    /// <summary>
    /// The disable_api_termination attribute.
    /// </summary>
    [TerraformPropertyName("disable_api_termination")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> DisableApiTermination { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "disable_api_termination");

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    [TerraformPropertyName("ebs_optimized")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> EbsOptimized { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "ebs_optimized");

    /// <summary>
    /// The enable_primary_ipv6 attribute.
    /// </summary>
    [TerraformPropertyName("enable_primary_ipv6")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> EnablePrimaryIpv6 { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_primary_ipv6");

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    [TerraformPropertyName("force_destroy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ForceDestroy { get; set; }

    /// <summary>
    /// The get_password_data attribute.
    /// </summary>
    [TerraformPropertyName("get_password_data")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? GetPasswordData { get; set; }

    /// <summary>
    /// The hibernation attribute.
    /// </summary>
    [TerraformPropertyName("hibernation")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Hibernation { get; set; }

    /// <summary>
    /// The host_id attribute.
    /// </summary>
    [TerraformPropertyName("host_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> HostId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "host_id");

    /// <summary>
    /// The host_resource_group_arn attribute.
    /// </summary>
    [TerraformPropertyName("host_resource_group_arn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> HostResourceGroupArn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "host_resource_group_arn");

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    [TerraformPropertyName("iam_instance_profile")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> IamInstanceProfile { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "iam_instance_profile");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The instance_initiated_shutdown_behavior attribute.
    /// </summary>
    [TerraformPropertyName("instance_initiated_shutdown_behavior")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> InstanceInitiatedShutdownBehavior { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "instance_initiated_shutdown_behavior");

    /// <summary>
    /// The instance_interruption_behavior attribute.
    /// </summary>
    [TerraformPropertyName("instance_interruption_behavior")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InstanceInterruptionBehavior { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformPropertyName("instance_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> InstanceType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "instance_type");

    /// <summary>
    /// The ipv6_address_count attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_address_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Ipv6AddressCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "ipv6_address_count");

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_addresses")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> Ipv6Addresses { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "ipv6_addresses");

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    [TerraformPropertyName("key_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KeyName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "key_name");

    /// <summary>
    /// The launch_group attribute.
    /// </summary>
    [TerraformPropertyName("launch_group")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LaunchGroup { get; set; }

    /// <summary>
    /// The monitoring attribute.
    /// </summary>
    [TerraformPropertyName("monitoring")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> Monitoring { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "monitoring");

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    [TerraformPropertyName("placement_group")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PlacementGroup { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "placement_group");

    /// <summary>
    /// The placement_group_id attribute.
    /// </summary>
    [TerraformPropertyName("placement_group_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PlacementGroupId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "placement_group_id");

    /// <summary>
    /// The placement_partition_number attribute.
    /// </summary>
    [TerraformPropertyName("placement_partition_number")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> PlacementPartitionNumber { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "placement_partition_number");

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    [TerraformPropertyName("private_ip")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PrivateIp { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_ip");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The secondary_private_ips attribute.
    /// </summary>
    [TerraformPropertyName("secondary_private_ips")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> SecondaryPrivateIps { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "secondary_private_ips");

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformPropertyName("security_groups")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> SecurityGroups { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "security_groups");

    /// <summary>
    /// The source_dest_check attribute.
    /// </summary>
    [TerraformPropertyName("source_dest_check")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SourceDestCheck { get; set; }

    /// <summary>
    /// The spot_price attribute.
    /// </summary>
    [TerraformPropertyName("spot_price")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SpotPrice { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "spot_price");

    /// <summary>
    /// The spot_type attribute.
    /// </summary>
    [TerraformPropertyName("spot_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SpotType { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SubnetId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "subnet_id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    [TerraformPropertyName("tenancy")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Tenancy { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tenancy");

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    [TerraformPropertyName("user_data")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UserData { get; set; }

    /// <summary>
    /// The user_data_base64 attribute.
    /// </summary>
    [TerraformPropertyName("user_data_base64")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> UserDataBase64 { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "user_data_base64");

    /// <summary>
    /// The user_data_replace_on_change attribute.
    /// </summary>
    [TerraformPropertyName("user_data_replace_on_change")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UserDataReplaceOnChange { get; set; }

    /// <summary>
    /// The valid_from attribute.
    /// </summary>
    [TerraformPropertyName("valid_from")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ValidFrom { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "valid_from");

    /// <summary>
    /// The valid_until attribute.
    /// </summary>
    [TerraformPropertyName("valid_until")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ValidUntil { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "valid_until");

    /// <summary>
    /// The volume_tags attribute.
    /// </summary>
    [TerraformPropertyName("volume_tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? VolumeTags { get; set; }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("vpc_security_group_ids")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> VpcSecurityGroupIds { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "vpc_security_group_ids");

    /// <summary>
    /// The wait_for_fulfillment attribute.
    /// </summary>
    [TerraformPropertyName("wait_for_fulfillment")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? WaitForFulfillment { get; set; }

    /// <summary>
    /// Block for capacity_reservation_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityReservationSpecification block(s) allowed")]
    [TerraformPropertyName("capacity_reservation_specification")]
    public TerraformList<TerraformBlock<AwsSpotInstanceRequestCapacityReservationSpecificationBlock>>? CapacityReservationSpecification { get; set; } = new();

    /// <summary>
    /// Block for cpu_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CpuOptions block(s) allowed")]
    [TerraformPropertyName("cpu_options")]
    public TerraformList<TerraformBlock<AwsSpotInstanceRequestCpuOptionsBlock>>? CpuOptions { get; set; } = new();

    /// <summary>
    /// Block for credit_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CreditSpecification block(s) allowed")]
    [TerraformPropertyName("credit_specification")]
    public TerraformList<TerraformBlock<AwsSpotInstanceRequestCreditSpecificationBlock>>? CreditSpecification { get; set; } = new();

    /// <summary>
    /// Block for ebs_block_device.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("ebs_block_device")]
    public TerraformSet<TerraformBlock<AwsSpotInstanceRequestEbsBlockDeviceBlock>>? EbsBlockDevice { get; set; } = new();

    /// <summary>
    /// Block for enclave_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnclaveOptions block(s) allowed")]
    [TerraformPropertyName("enclave_options")]
    public TerraformList<TerraformBlock<AwsSpotInstanceRequestEnclaveOptionsBlock>>? EnclaveOptions { get; set; } = new();

    /// <summary>
    /// Block for ephemeral_block_device.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("ephemeral_block_device")]
    public TerraformSet<TerraformBlock<AwsSpotInstanceRequestEphemeralBlockDeviceBlock>>? EphemeralBlockDevice { get; set; } = new();

    /// <summary>
    /// Block for launch_template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchTemplate block(s) allowed")]
    [TerraformPropertyName("launch_template")]
    public TerraformList<TerraformBlock<AwsSpotInstanceRequestLaunchTemplateBlock>>? LaunchTemplate { get; set; } = new();

    /// <summary>
    /// Block for maintenance_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceOptions block(s) allowed")]
    [TerraformPropertyName("maintenance_options")]
    public TerraformList<TerraformBlock<AwsSpotInstanceRequestMaintenanceOptionsBlock>>? MaintenanceOptions { get; set; } = new();

    /// <summary>
    /// Block for metadata_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetadataOptions block(s) allowed")]
    [TerraformPropertyName("metadata_options")]
    public TerraformList<TerraformBlock<AwsSpotInstanceRequestMetadataOptionsBlock>>? MetadataOptions { get; set; } = new();

    /// <summary>
    /// Block for network_interface.
    /// Nesting mode: set
    /// </summary>
    [Obsolete("This block is deprecated.")]
    [TerraformPropertyName("network_interface")]
    public TerraformSet<TerraformBlock<AwsSpotInstanceRequestNetworkInterfaceBlock>>? NetworkInterface { get; set; } = new();

    /// <summary>
    /// Block for private_dns_name_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateDnsNameOptions block(s) allowed")]
    [TerraformPropertyName("private_dns_name_options")]
    public TerraformList<TerraformBlock<AwsSpotInstanceRequestPrivateDnsNameOptionsBlock>>? PrivateDnsNameOptions { get; set; } = new();

    /// <summary>
    /// Block for root_block_device.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RootBlockDevice block(s) allowed")]
    [TerraformPropertyName("root_block_device")]
    public TerraformList<TerraformBlock<AwsSpotInstanceRequestRootBlockDeviceBlock>>? RootBlockDevice { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsSpotInstanceRequestTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The instance_state attribute.
    /// </summary>
    [TerraformPropertyName("instance_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InstanceState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "instance_state");

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    [TerraformPropertyName("outpost_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OutpostArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "outpost_arn");

    /// <summary>
    /// The password_data attribute.
    /// </summary>
    [TerraformPropertyName("password_data")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PasswordData => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "password_data");

    /// <summary>
    /// The primary_network_interface attribute.
    /// </summary>
    [TerraformPropertyName("primary_network_interface")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PrimaryNetworkInterface => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "primary_network_interface");

    /// <summary>
    /// The primary_network_interface_id attribute.
    /// </summary>
    [TerraformPropertyName("primary_network_interface_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryNetworkInterfaceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_network_interface_id");

    /// <summary>
    /// The private_dns attribute.
    /// </summary>
    [TerraformPropertyName("private_dns")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivateDns => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_dns");

    /// <summary>
    /// The public_dns attribute.
    /// </summary>
    [TerraformPropertyName("public_dns")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PublicDns => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "public_dns");

    /// <summary>
    /// The public_ip attribute.
    /// </summary>
    [TerraformPropertyName("public_ip")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PublicIp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "public_ip");

    /// <summary>
    /// The spot_bid_status attribute.
    /// </summary>
    [TerraformPropertyName("spot_bid_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SpotBidStatus => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "spot_bid_status");

    /// <summary>
    /// The spot_instance_id attribute.
    /// </summary>
    [TerraformPropertyName("spot_instance_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SpotInstanceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "spot_instance_id");

    /// <summary>
    /// The spot_request_state attribute.
    /// </summary>
    [TerraformPropertyName("spot_request_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SpotRequestState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "spot_request_state");

}
