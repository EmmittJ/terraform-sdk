using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for capacity_reservation_specification in AwsSpotInstanceRequest.
/// Nesting mode: list
/// </summary>
public class AwsSpotInstanceRequestCapacityReservationSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "capacity_reservation_specification";

    /// <summary>
    /// The capacity_reservation_preference attribute.
    /// </summary>
    public TerraformValue<string>? CapacityReservationPreference
    {
        get => new TerraformReference<string>(this, "capacity_reservation_preference");
        set => SetArgument("capacity_reservation_preference", value);
    }

    /// <summary>
    /// CapacityReservationTarget block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityReservationTarget block(s) allowed")]
    public TerraformList<AwsSpotInstanceRequestCapacityReservationSpecificationBlockCapacityReservationTargetBlock>? CapacityReservationTarget
    {
        get => GetArgument<TerraformList<AwsSpotInstanceRequestCapacityReservationSpecificationBlockCapacityReservationTargetBlock>>("capacity_reservation_target");
        set => SetArgument("capacity_reservation_target", value);
    }

}

/// <summary>
/// Block type for capacity_reservation_target in AwsSpotInstanceRequestCapacityReservationSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsSpotInstanceRequestCapacityReservationSpecificationBlockCapacityReservationTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "capacity_reservation_target";

    /// <summary>
    /// The capacity_reservation_id attribute.
    /// </summary>
    public TerraformValue<string>? CapacityReservationId
    {
        get => new TerraformReference<string>(this, "capacity_reservation_id");
        set => SetArgument("capacity_reservation_id", value);
    }

    /// <summary>
    /// The capacity_reservation_resource_group_arn attribute.
    /// </summary>
    public TerraformValue<string>? CapacityReservationResourceGroupArn
    {
        get => new TerraformReference<string>(this, "capacity_reservation_resource_group_arn");
        set => SetArgument("capacity_reservation_resource_group_arn", value);
    }

}


/// <summary>
/// Block type for cpu_options in AwsSpotInstanceRequest.
/// Nesting mode: list
/// </summary>
public class AwsSpotInstanceRequestCpuOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cpu_options";

    /// <summary>
    /// The amd_sev_snp attribute.
    /// </summary>
    public TerraformValue<string> AmdSevSnp
    {
        get => new TerraformReference<string>(this, "amd_sev_snp");
        set => SetArgument("amd_sev_snp", value);
    }

    /// <summary>
    /// The core_count attribute.
    /// </summary>
    public TerraformValue<double> CoreCount
    {
        get => new TerraformReference<double>(this, "core_count");
        set => SetArgument("core_count", value);
    }

    /// <summary>
    /// The threads_per_core attribute.
    /// </summary>
    public TerraformValue<double> ThreadsPerCore
    {
        get => new TerraformReference<double>(this, "threads_per_core");
        set => SetArgument("threads_per_core", value);
    }

}


/// <summary>
/// Block type for credit_specification in AwsSpotInstanceRequest.
/// Nesting mode: list
/// </summary>
public class AwsSpotInstanceRequestCreditSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "credit_specification";

    /// <summary>
    /// The cpu_credits attribute.
    /// </summary>
    public TerraformValue<string>? CpuCredits
    {
        get => new TerraformReference<string>(this, "cpu_credits");
        set => SetArgument("cpu_credits", value);
    }

}


/// <summary>
/// Block type for ebs_block_device in AwsSpotInstanceRequest.
/// Nesting mode: set
/// </summary>
public class AwsSpotInstanceRequestEbsBlockDeviceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ebs_block_device";

    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    public TerraformValue<bool>? DeleteOnTermination
    {
        get => new TerraformReference<bool>(this, "delete_on_termination");
        set => SetArgument("delete_on_termination", value);
    }

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    public required TerraformValue<string> DeviceName
    {
        get => new TerraformReference<string>(this, "device_name");
        set => SetArgument("device_name", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformValue<bool> Encrypted
    {
        get => new TerraformReference<bool>(this, "encrypted");
        set => SetArgument("encrypted", value);
    }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformValue<double> Iops
    {
        get => new TerraformReference<double>(this, "iops");
        set => SetArgument("iops", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    public TerraformValue<string> SnapshotId
    {
        get => new TerraformReference<string>(this, "snapshot_id");
        set => SetArgument("snapshot_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    public TerraformValue<double> Throughput
    {
        get => new TerraformReference<double>(this, "throughput");
        set => SetArgument("throughput", value);
    }

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    public TerraformValue<string> VolumeId
    {
        get => new TerraformReference<string>(this, "volume_id");
    }

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    public TerraformValue<double> VolumeSize
    {
        get => new TerraformReference<double>(this, "volume_size");
        set => SetArgument("volume_size", value);
    }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    public TerraformValue<string> VolumeType
    {
        get => new TerraformReference<string>(this, "volume_type");
        set => SetArgument("volume_type", value);
    }

}


/// <summary>
/// Block type for enclave_options in AwsSpotInstanceRequest.
/// Nesting mode: list
/// </summary>
public class AwsSpotInstanceRequestEnclaveOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "enclave_options";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for ephemeral_block_device in AwsSpotInstanceRequest.
/// Nesting mode: set
/// </summary>
public class AwsSpotInstanceRequestEphemeralBlockDeviceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ephemeral_block_device";

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    public required TerraformValue<string> DeviceName
    {
        get => new TerraformReference<string>(this, "device_name");
        set => SetArgument("device_name", value);
    }

    /// <summary>
    /// The no_device attribute.
    /// </summary>
    public TerraformValue<bool>? NoDevice
    {
        get => new TerraformReference<bool>(this, "no_device");
        set => SetArgument("no_device", value);
    }

    /// <summary>
    /// The virtual_name attribute.
    /// </summary>
    public TerraformValue<string>? VirtualName
    {
        get => new TerraformReference<string>(this, "virtual_name");
        set => SetArgument("virtual_name", value);
    }

}


/// <summary>
/// Block type for launch_template in AwsSpotInstanceRequest.
/// Nesting mode: list
/// </summary>
public class AwsSpotInstanceRequestLaunchTemplateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "launch_template";

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

}


/// <summary>
/// Block type for maintenance_options in AwsSpotInstanceRequest.
/// Nesting mode: list
/// </summary>
public class AwsSpotInstanceRequestMaintenanceOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maintenance_options";

    /// <summary>
    /// The auto_recovery attribute.
    /// </summary>
    public TerraformValue<string> AutoRecovery
    {
        get => new TerraformReference<string>(this, "auto_recovery");
        set => SetArgument("auto_recovery", value);
    }

}


/// <summary>
/// Block type for metadata_options in AwsSpotInstanceRequest.
/// Nesting mode: list
/// </summary>
public class AwsSpotInstanceRequestMetadataOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metadata_options";

    /// <summary>
    /// The http_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? HttpEndpoint
    {
        get => new TerraformReference<string>(this, "http_endpoint");
        set => SetArgument("http_endpoint", value);
    }

    /// <summary>
    /// The http_protocol_ipv6 attribute.
    /// </summary>
    public TerraformValue<string>? HttpProtocolIpv6
    {
        get => new TerraformReference<string>(this, "http_protocol_ipv6");
        set => SetArgument("http_protocol_ipv6", value);
    }

    /// <summary>
    /// The http_put_response_hop_limit attribute.
    /// </summary>
    public TerraformValue<double> HttpPutResponseHopLimit
    {
        get => new TerraformReference<double>(this, "http_put_response_hop_limit");
        set => SetArgument("http_put_response_hop_limit", value);
    }

    /// <summary>
    /// The http_tokens attribute.
    /// </summary>
    public TerraformValue<string> HttpTokens
    {
        get => new TerraformReference<string>(this, "http_tokens");
        set => SetArgument("http_tokens", value);
    }

    /// <summary>
    /// The instance_metadata_tags attribute.
    /// </summary>
    public TerraformValue<string> InstanceMetadataTags
    {
        get => new TerraformReference<string>(this, "instance_metadata_tags");
        set => SetArgument("instance_metadata_tags", value);
    }

}


/// <summary>
/// Block type for network_interface in AwsSpotInstanceRequest.
/// Nesting mode: set
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsSpotInstanceRequestNetworkInterfaceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_interface";

    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    public TerraformValue<bool>? DeleteOnTermination
    {
        get => new TerraformReference<bool>(this, "delete_on_termination");
        set => SetArgument("delete_on_termination", value);
    }

    /// <summary>
    /// The device_index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceIndex is required")]
    public required TerraformValue<double> DeviceIndex
    {
        get => new TerraformReference<double>(this, "device_index");
        set => SetArgument("device_index", value);
    }

    /// <summary>
    /// The network_card_index attribute.
    /// </summary>
    public TerraformValue<double> NetworkCardIndex
    {
        get => new TerraformReference<double>(this, "network_card_index");
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceId is required")]
    public required TerraformValue<string> NetworkInterfaceId
    {
        get => new TerraformReference<string>(this, "network_interface_id");
        set => SetArgument("network_interface_id", value);
    }

}


/// <summary>
/// Block type for private_dns_name_options in AwsSpotInstanceRequest.
/// Nesting mode: list
/// </summary>
public class AwsSpotInstanceRequestPrivateDnsNameOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "private_dns_name_options";

    /// <summary>
    /// The enable_resource_name_dns_a_record attribute.
    /// </summary>
    public TerraformValue<bool> EnableResourceNameDnsARecord
    {
        get => new TerraformReference<bool>(this, "enable_resource_name_dns_a_record");
        set => SetArgument("enable_resource_name_dns_a_record", value);
    }

    /// <summary>
    /// The enable_resource_name_dns_aaaa_record attribute.
    /// </summary>
    public TerraformValue<bool> EnableResourceNameDnsAaaaRecord
    {
        get => new TerraformReference<bool>(this, "enable_resource_name_dns_aaaa_record");
        set => SetArgument("enable_resource_name_dns_aaaa_record", value);
    }

    /// <summary>
    /// The hostname_type attribute.
    /// </summary>
    public TerraformValue<string> HostnameType
    {
        get => new TerraformReference<string>(this, "hostname_type");
        set => SetArgument("hostname_type", value);
    }

}


/// <summary>
/// Block type for root_block_device in AwsSpotInstanceRequest.
/// Nesting mode: list
/// </summary>
public class AwsSpotInstanceRequestRootBlockDeviceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "root_block_device";

    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    public TerraformValue<bool>? DeleteOnTermination
    {
        get => new TerraformReference<bool>(this, "delete_on_termination");
        set => SetArgument("delete_on_termination", value);
    }

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    public TerraformValue<string> DeviceName
    {
        get => new TerraformReference<string>(this, "device_name");
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformValue<bool> Encrypted
    {
        get => new TerraformReference<bool>(this, "encrypted");
        set => SetArgument("encrypted", value);
    }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformValue<double> Iops
    {
        get => new TerraformReference<double>(this, "iops");
        set => SetArgument("iops", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    public TerraformValue<double> Throughput
    {
        get => new TerraformReference<double>(this, "throughput");
        set => SetArgument("throughput", value);
    }

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    public TerraformValue<string> VolumeId
    {
        get => new TerraformReference<string>(this, "volume_id");
    }

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    public TerraformValue<double> VolumeSize
    {
        get => new TerraformReference<double>(this, "volume_size");
        set => SetArgument("volume_size", value);
    }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    public TerraformValue<string> VolumeType
    {
        get => new TerraformReference<string>(this, "volume_type");
        set => SetArgument("volume_type", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsSpotInstanceRequest.
/// Nesting mode: single
/// </summary>
public class AwsSpotInstanceRequestTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a aws_spot_instance_request Terraform resource.
/// Manages a aws_spot_instance_request resource.
/// </summary>
public partial class AwsSpotInstanceRequest(string name) : TerraformResource("aws_spot_instance_request", name)
{
    /// <summary>
    /// The ami attribute.
    /// </summary>
    public TerraformValue<string> Ami
    {
        get => new TerraformReference<string>(this, "ami");
        set => SetArgument("ami", value);
    }

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    public TerraformValue<bool> AssociatePublicIpAddress
    {
        get => new TerraformReference<bool>(this, "associate_public_ip_address");
        set => SetArgument("associate_public_ip_address", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
    {
        get => new TerraformReference<string>(this, "availability_zone");
        set => SetArgument("availability_zone", value);
    }

    /// <summary>
    /// The disable_api_stop attribute.
    /// </summary>
    public TerraformValue<bool> DisableApiStop
    {
        get => new TerraformReference<bool>(this, "disable_api_stop");
        set => SetArgument("disable_api_stop", value);
    }

    /// <summary>
    /// The disable_api_termination attribute.
    /// </summary>
    public TerraformValue<bool> DisableApiTermination
    {
        get => new TerraformReference<bool>(this, "disable_api_termination");
        set => SetArgument("disable_api_termination", value);
    }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    public TerraformValue<bool> EbsOptimized
    {
        get => new TerraformReference<bool>(this, "ebs_optimized");
        set => SetArgument("ebs_optimized", value);
    }

    /// <summary>
    /// The enable_primary_ipv6 attribute.
    /// </summary>
    public TerraformValue<bool> EnablePrimaryIpv6
    {
        get => new TerraformReference<bool>(this, "enable_primary_ipv6");
        set => SetArgument("enable_primary_ipv6", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? ForceDestroy
    {
        get => new TerraformReference<bool>(this, "force_destroy");
        set => SetArgument("force_destroy", value);
    }

    /// <summary>
    /// The get_password_data attribute.
    /// </summary>
    public TerraformValue<bool>? GetPasswordData
    {
        get => new TerraformReference<bool>(this, "get_password_data");
        set => SetArgument("get_password_data", value);
    }

    /// <summary>
    /// The hibernation attribute.
    /// </summary>
    public TerraformValue<bool>? Hibernation
    {
        get => new TerraformReference<bool>(this, "hibernation");
        set => SetArgument("hibernation", value);
    }

    /// <summary>
    /// The host_id attribute.
    /// </summary>
    public TerraformValue<string> HostId
    {
        get => new TerraformReference<string>(this, "host_id");
        set => SetArgument("host_id", value);
    }

    /// <summary>
    /// The host_resource_group_arn attribute.
    /// </summary>
    public TerraformValue<string> HostResourceGroupArn
    {
        get => new TerraformReference<string>(this, "host_resource_group_arn");
        set => SetArgument("host_resource_group_arn", value);
    }

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    public TerraformValue<string> IamInstanceProfile
    {
        get => new TerraformReference<string>(this, "iam_instance_profile");
        set => SetArgument("iam_instance_profile", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_initiated_shutdown_behavior attribute.
    /// </summary>
    public TerraformValue<string> InstanceInitiatedShutdownBehavior
    {
        get => new TerraformReference<string>(this, "instance_initiated_shutdown_behavior");
        set => SetArgument("instance_initiated_shutdown_behavior", value);
    }

    /// <summary>
    /// The instance_interruption_behavior attribute.
    /// </summary>
    public TerraformValue<string>? InstanceInterruptionBehavior
    {
        get => new TerraformReference<string>(this, "instance_interruption_behavior");
        set => SetArgument("instance_interruption_behavior", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string> InstanceType
    {
        get => new TerraformReference<string>(this, "instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The ipv6_address_count attribute.
    /// </summary>
    public TerraformValue<double> Ipv6AddressCount
    {
        get => new TerraformReference<double>(this, "ipv6_address_count");
        set => SetArgument("ipv6_address_count", value);
    }

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    public TerraformList<string> Ipv6Addresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ipv6_addresses").ResolveNodes(ctx));
        set => SetArgument("ipv6_addresses", value);
    }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    public TerraformValue<string> KeyName
    {
        get => new TerraformReference<string>(this, "key_name");
        set => SetArgument("key_name", value);
    }

    /// <summary>
    /// The launch_group attribute.
    /// </summary>
    public TerraformValue<string>? LaunchGroup
    {
        get => new TerraformReference<string>(this, "launch_group");
        set => SetArgument("launch_group", value);
    }

    /// <summary>
    /// The monitoring attribute.
    /// </summary>
    public TerraformValue<bool> Monitoring
    {
        get => new TerraformReference<bool>(this, "monitoring");
        set => SetArgument("monitoring", value);
    }

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    public TerraformValue<string> PlacementGroup
    {
        get => new TerraformReference<string>(this, "placement_group");
        set => SetArgument("placement_group", value);
    }

    /// <summary>
    /// The placement_group_id attribute.
    /// </summary>
    public TerraformValue<string> PlacementGroupId
    {
        get => new TerraformReference<string>(this, "placement_group_id");
        set => SetArgument("placement_group_id", value);
    }

    /// <summary>
    /// The placement_partition_number attribute.
    /// </summary>
    public TerraformValue<double> PlacementPartitionNumber
    {
        get => new TerraformReference<double>(this, "placement_partition_number");
        set => SetArgument("placement_partition_number", value);
    }

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    public TerraformValue<string> PrivateIp
    {
        get => new TerraformReference<string>(this, "private_ip");
        set => SetArgument("private_ip", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The secondary_private_ips attribute.
    /// </summary>
    public TerraformSet<string> SecondaryPrivateIps
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "secondary_private_ips").ResolveNodes(ctx));
        set => SetArgument("secondary_private_ips", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroups
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_groups").ResolveNodes(ctx));
        set => SetArgument("security_groups", value);
    }

    /// <summary>
    /// The source_dest_check attribute.
    /// </summary>
    public TerraformValue<bool>? SourceDestCheck
    {
        get => new TerraformReference<bool>(this, "source_dest_check");
        set => SetArgument("source_dest_check", value);
    }

    /// <summary>
    /// The spot_price attribute.
    /// </summary>
    public TerraformValue<string> SpotPrice
    {
        get => new TerraformReference<string>(this, "spot_price");
        set => SetArgument("spot_price", value);
    }

    /// <summary>
    /// The spot_type attribute.
    /// </summary>
    public TerraformValue<string>? SpotType
    {
        get => new TerraformReference<string>(this, "spot_type");
        set => SetArgument("spot_type", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    public TerraformValue<string> Tenancy
    {
        get => new TerraformReference<string>(this, "tenancy");
        set => SetArgument("tenancy", value);
    }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    public TerraformValue<string>? UserData
    {
        get => new TerraformReference<string>(this, "user_data");
        set => SetArgument("user_data", value);
    }

    /// <summary>
    /// The user_data_base64 attribute.
    /// </summary>
    public TerraformValue<string> UserDataBase64
    {
        get => new TerraformReference<string>(this, "user_data_base64");
        set => SetArgument("user_data_base64", value);
    }

    /// <summary>
    /// The user_data_replace_on_change attribute.
    /// </summary>
    public TerraformValue<bool>? UserDataReplaceOnChange
    {
        get => new TerraformReference<bool>(this, "user_data_replace_on_change");
        set => SetArgument("user_data_replace_on_change", value);
    }

    /// <summary>
    /// The valid_from attribute.
    /// </summary>
    public TerraformValue<string> ValidFrom
    {
        get => new TerraformReference<string>(this, "valid_from");
        set => SetArgument("valid_from", value);
    }

    /// <summary>
    /// The valid_until attribute.
    /// </summary>
    public TerraformValue<string> ValidUntil
    {
        get => new TerraformReference<string>(this, "valid_until");
        set => SetArgument("valid_until", value);
    }

    /// <summary>
    /// The volume_tags attribute.
    /// </summary>
    public TerraformMap<string>? VolumeTags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "volume_tags").ResolveNodes(ctx));
        set => SetArgument("volume_tags", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> VpcSecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "vpc_security_group_ids").ResolveNodes(ctx));
        set => SetArgument("vpc_security_group_ids", value);
    }

    /// <summary>
    /// The wait_for_fulfillment attribute.
    /// </summary>
    public TerraformValue<bool>? WaitForFulfillment
    {
        get => new TerraformReference<bool>(this, "wait_for_fulfillment");
        set => SetArgument("wait_for_fulfillment", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The instance_state attribute.
    /// </summary>
    public TerraformValue<string> InstanceState
    {
        get => new TerraformReference<string>(this, "instance_state");
    }

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformValue<string> OutpostArn
    {
        get => new TerraformReference<string>(this, "outpost_arn");
    }

    /// <summary>
    /// The password_data attribute.
    /// </summary>
    public TerraformValue<string> PasswordData
    {
        get => new TerraformReference<string>(this, "password_data");
    }

    /// <summary>
    /// The primary_network_interface attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PrimaryNetworkInterface
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "primary_network_interface").ResolveNodes(ctx));
    }

    /// <summary>
    /// The primary_network_interface_id attribute.
    /// </summary>
    public TerraformValue<string> PrimaryNetworkInterfaceId
    {
        get => new TerraformReference<string>(this, "primary_network_interface_id");
    }

    /// <summary>
    /// The private_dns attribute.
    /// </summary>
    public TerraformValue<string> PrivateDns
    {
        get => new TerraformReference<string>(this, "private_dns");
    }

    /// <summary>
    /// The public_dns attribute.
    /// </summary>
    public TerraformValue<string> PublicDns
    {
        get => new TerraformReference<string>(this, "public_dns");
    }

    /// <summary>
    /// The public_ip attribute.
    /// </summary>
    public TerraformValue<string> PublicIp
    {
        get => new TerraformReference<string>(this, "public_ip");
    }

    /// <summary>
    /// The spot_bid_status attribute.
    /// </summary>
    public TerraformValue<string> SpotBidStatus
    {
        get => new TerraformReference<string>(this, "spot_bid_status");
    }

    /// <summary>
    /// The spot_instance_id attribute.
    /// </summary>
    public TerraformValue<string> SpotInstanceId
    {
        get => new TerraformReference<string>(this, "spot_instance_id");
    }

    /// <summary>
    /// The spot_request_state attribute.
    /// </summary>
    public TerraformValue<string> SpotRequestState
    {
        get => new TerraformReference<string>(this, "spot_request_state");
    }

    /// <summary>
    /// CapacityReservationSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityReservationSpecification block(s) allowed")]
    public TerraformList<AwsSpotInstanceRequestCapacityReservationSpecificationBlock>? CapacityReservationSpecification
    {
        get => GetArgument<TerraformList<AwsSpotInstanceRequestCapacityReservationSpecificationBlock>>("capacity_reservation_specification");
        set => SetArgument("capacity_reservation_specification", value);
    }

    /// <summary>
    /// CpuOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CpuOptions block(s) allowed")]
    public TerraformList<AwsSpotInstanceRequestCpuOptionsBlock>? CpuOptions
    {
        get => GetArgument<TerraformList<AwsSpotInstanceRequestCpuOptionsBlock>>("cpu_options");
        set => SetArgument("cpu_options", value);
    }

    /// <summary>
    /// CreditSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CreditSpecification block(s) allowed")]
    public TerraformList<AwsSpotInstanceRequestCreditSpecificationBlock>? CreditSpecification
    {
        get => GetArgument<TerraformList<AwsSpotInstanceRequestCreditSpecificationBlock>>("credit_specification");
        set => SetArgument("credit_specification", value);
    }

    /// <summary>
    /// EbsBlockDevice block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSpotInstanceRequestEbsBlockDeviceBlock>? EbsBlockDevice
    {
        get => GetArgument<TerraformSet<AwsSpotInstanceRequestEbsBlockDeviceBlock>>("ebs_block_device");
        set => SetArgument("ebs_block_device", value);
    }

    /// <summary>
    /// EnclaveOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnclaveOptions block(s) allowed")]
    public TerraformList<AwsSpotInstanceRequestEnclaveOptionsBlock>? EnclaveOptions
    {
        get => GetArgument<TerraformList<AwsSpotInstanceRequestEnclaveOptionsBlock>>("enclave_options");
        set => SetArgument("enclave_options", value);
    }

    /// <summary>
    /// EphemeralBlockDevice block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSpotInstanceRequestEphemeralBlockDeviceBlock>? EphemeralBlockDevice
    {
        get => GetArgument<TerraformSet<AwsSpotInstanceRequestEphemeralBlockDeviceBlock>>("ephemeral_block_device");
        set => SetArgument("ephemeral_block_device", value);
    }

    /// <summary>
    /// LaunchTemplate block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchTemplate block(s) allowed")]
    public TerraformList<AwsSpotInstanceRequestLaunchTemplateBlock>? LaunchTemplate
    {
        get => GetArgument<TerraformList<AwsSpotInstanceRequestLaunchTemplateBlock>>("launch_template");
        set => SetArgument("launch_template", value);
    }

    /// <summary>
    /// MaintenanceOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceOptions block(s) allowed")]
    public TerraformList<AwsSpotInstanceRequestMaintenanceOptionsBlock>? MaintenanceOptions
    {
        get => GetArgument<TerraformList<AwsSpotInstanceRequestMaintenanceOptionsBlock>>("maintenance_options");
        set => SetArgument("maintenance_options", value);
    }

    /// <summary>
    /// MetadataOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetadataOptions block(s) allowed")]
    public TerraformList<AwsSpotInstanceRequestMetadataOptionsBlock>? MetadataOptions
    {
        get => GetArgument<TerraformList<AwsSpotInstanceRequestMetadataOptionsBlock>>("metadata_options");
        set => SetArgument("metadata_options", value);
    }

    /// <summary>
    /// NetworkInterface block (nesting mode: set).
    /// </summary>
    [Obsolete("This block is deprecated.")]
    public TerraformSet<AwsSpotInstanceRequestNetworkInterfaceBlock>? NetworkInterface
    {
        get => GetArgument<TerraformSet<AwsSpotInstanceRequestNetworkInterfaceBlock>>("network_interface");
        set => SetArgument("network_interface", value);
    }

    /// <summary>
    /// PrivateDnsNameOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateDnsNameOptions block(s) allowed")]
    public TerraformList<AwsSpotInstanceRequestPrivateDnsNameOptionsBlock>? PrivateDnsNameOptions
    {
        get => GetArgument<TerraformList<AwsSpotInstanceRequestPrivateDnsNameOptionsBlock>>("private_dns_name_options");
        set => SetArgument("private_dns_name_options", value);
    }

    /// <summary>
    /// RootBlockDevice block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RootBlockDevice block(s) allowed")]
    public TerraformList<AwsSpotInstanceRequestRootBlockDeviceBlock>? RootBlockDevice
    {
        get => GetArgument<TerraformList<AwsSpotInstanceRequestRootBlockDeviceBlock>>("root_block_device");
        set => SetArgument("root_block_device", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsSpotInstanceRequestTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsSpotInstanceRequestTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
