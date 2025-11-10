using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for capacity_reservation_specification in .
/// Nesting mode: list
/// </summary>
public class AwsInstanceCapacityReservationSpecificationBlock : TerraformBlock
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
public class AwsInstanceCpuOptionsBlock : TerraformBlock
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
public class AwsInstanceCreditSpecificationBlock : TerraformBlock
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
/// Block type for ebs_block_device in .
/// Nesting mode: set
/// </summary>
public class AwsInstanceEbsBlockDeviceBlock : TerraformBlock
{
    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    public TerraformProperty<bool>? DeleteOnTermination
    {
        get => GetProperty<TerraformProperty<bool>>("delete_on_termination");
        set => WithProperty("delete_on_termination", value);
    }

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    public required TerraformProperty<string> DeviceName
    {
        get => GetProperty<TerraformProperty<string>>("device_name");
        set => WithProperty("device_name", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformProperty<bool>? Encrypted
    {
        get => GetProperty<TerraformProperty<bool>>("encrypted");
        set => WithProperty("encrypted", value);
    }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformProperty<double>? Iops
    {
        get => GetProperty<TerraformProperty<double>>("iops");
        set => WithProperty("iops", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    public TerraformProperty<string>? SnapshotId
    {
        get => GetProperty<TerraformProperty<string>>("snapshot_id");
        set => WithProperty("snapshot_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => WithProperty("tags_all", value);
    }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    public TerraformProperty<double>? Throughput
    {
        get => GetProperty<TerraformProperty<double>>("throughput");
        set => WithProperty("throughput", value);
    }

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    public TerraformProperty<string>? VolumeId
    {
        get => GetProperty<TerraformProperty<string>>("volume_id");
        set => WithProperty("volume_id", value);
    }

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    public TerraformProperty<double>? VolumeSize
    {
        get => GetProperty<TerraformProperty<double>>("volume_size");
        set => WithProperty("volume_size", value);
    }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    public TerraformProperty<string>? VolumeType
    {
        get => GetProperty<TerraformProperty<string>>("volume_type");
        set => WithProperty("volume_type", value);
    }

}

/// <summary>
/// Block type for enclave_options in .
/// Nesting mode: list
/// </summary>
public class AwsInstanceEnclaveOptionsBlock : TerraformBlock
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
/// Block type for ephemeral_block_device in .
/// Nesting mode: set
/// </summary>
public class AwsInstanceEphemeralBlockDeviceBlock : TerraformBlock
{
    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    public required TerraformProperty<string> DeviceName
    {
        get => GetProperty<TerraformProperty<string>>("device_name");
        set => WithProperty("device_name", value);
    }

    /// <summary>
    /// The no_device attribute.
    /// </summary>
    public TerraformProperty<bool>? NoDevice
    {
        get => GetProperty<TerraformProperty<bool>>("no_device");
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
/// Block type for instance_market_options in .
/// Nesting mode: list
/// </summary>
public class AwsInstanceInstanceMarketOptionsBlock : TerraformBlock
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
/// Block type for launch_template in .
/// Nesting mode: list
/// </summary>
public class AwsInstanceLaunchTemplateBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => WithProperty("version", value);
    }

}

/// <summary>
/// Block type for maintenance_options in .
/// Nesting mode: list
/// </summary>
public class AwsInstanceMaintenanceOptionsBlock : TerraformBlock
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
public class AwsInstanceMetadataOptionsBlock : TerraformBlock
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
/// Block type for network_interface in .
/// Nesting mode: set
/// </summary>
public class AwsInstanceNetworkInterfaceBlock : TerraformBlock
{
    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    public TerraformProperty<bool>? DeleteOnTermination
    {
        get => GetProperty<TerraformProperty<bool>>("delete_on_termination");
        set => WithProperty("delete_on_termination", value);
    }

    /// <summary>
    /// The device_index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceIndex is required")]
    public required TerraformProperty<double> DeviceIndex
    {
        get => GetProperty<TerraformProperty<double>>("device_index");
        set => WithProperty("device_index", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceId is required")]
    public required TerraformProperty<string> NetworkInterfaceId
    {
        get => GetProperty<TerraformProperty<string>>("network_interface_id");
        set => WithProperty("network_interface_id", value);
    }

}

/// <summary>
/// Block type for primary_network_interface in .
/// Nesting mode: list
/// </summary>
public class AwsInstancePrimaryNetworkInterfaceBlock : TerraformBlock
{
    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    public TerraformProperty<bool>? DeleteOnTermination
    {
        get => GetProperty<TerraformProperty<bool>>("delete_on_termination");
        set => WithProperty("delete_on_termination", value);
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceId is required")]
    public required TerraformProperty<string> NetworkInterfaceId
    {
        get => GetProperty<TerraformProperty<string>>("network_interface_id");
        set => WithProperty("network_interface_id", value);
    }

}

/// <summary>
/// Block type for private_dns_name_options in .
/// Nesting mode: list
/// </summary>
public class AwsInstancePrivateDnsNameOptionsBlock : TerraformBlock
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
/// Block type for root_block_device in .
/// Nesting mode: list
/// </summary>
public class AwsInstanceRootBlockDeviceBlock : TerraformBlock
{
    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    public TerraformProperty<bool>? DeleteOnTermination
    {
        get => GetProperty<TerraformProperty<bool>>("delete_on_termination");
        set => WithProperty("delete_on_termination", value);
    }

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    public TerraformProperty<string>? DeviceName
    {
        get => GetProperty<TerraformProperty<string>>("device_name");
        set => WithProperty("device_name", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformProperty<bool>? Encrypted
    {
        get => GetProperty<TerraformProperty<bool>>("encrypted");
        set => WithProperty("encrypted", value);
    }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformProperty<double>? Iops
    {
        get => GetProperty<TerraformProperty<double>>("iops");
        set => WithProperty("iops", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => WithProperty("tags_all", value);
    }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    public TerraformProperty<double>? Throughput
    {
        get => GetProperty<TerraformProperty<double>>("throughput");
        set => WithProperty("throughput", value);
    }

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    public TerraformProperty<string>? VolumeId
    {
        get => GetProperty<TerraformProperty<string>>("volume_id");
        set => WithProperty("volume_id", value);
    }

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    public TerraformProperty<double>? VolumeSize
    {
        get => GetProperty<TerraformProperty<double>>("volume_size");
        set => WithProperty("volume_size", value);
    }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    public TerraformProperty<string>? VolumeType
    {
        get => GetProperty<TerraformProperty<string>>("volume_type");
        set => WithProperty("volume_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsInstanceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_instance resource.
/// </summary>
public class AwsInstance : TerraformResource
{
    public AwsInstance(string name) : base("aws_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("instance_lifecycle");
        this.DeclareOutput("instance_state");
        this.DeclareOutput("outpost_arn");
        this.DeclareOutput("password_data");
        this.DeclareOutput("primary_network_interface_id");
        this.DeclareOutput("private_dns");
        this.DeclareOutput("public_dns");
        this.DeclareOutput("public_ip");
        this.DeclareOutput("spot_instance_request_id");
    }

    /// <summary>
    /// The ami attribute.
    /// </summary>
    public TerraformProperty<string>? Ami
    {
        get => GetProperty<TerraformProperty<string>>("ami");
        set => this.WithProperty("ami", value);
    }

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    public TerraformProperty<bool>? AssociatePublicIpAddress
    {
        get => GetProperty<TerraformProperty<bool>>("associate_public_ip_address");
        set => this.WithProperty("associate_public_ip_address", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformProperty<string>? AvailabilityZone
    {
        get => GetProperty<TerraformProperty<string>>("availability_zone");
        set => this.WithProperty("availability_zone", value);
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
    public TerraformProperty<bool>? EbsOptimized
    {
        get => GetProperty<TerraformProperty<bool>>("ebs_optimized");
        set => this.WithProperty("ebs_optimized", value);
    }

    /// <summary>
    /// The enable_primary_ipv6 attribute.
    /// </summary>
    public TerraformProperty<bool>? EnablePrimaryIpv6
    {
        get => GetProperty<TerraformProperty<bool>>("enable_primary_ipv6");
        set => this.WithProperty("enable_primary_ipv6", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("force_destroy");
        set => this.WithProperty("force_destroy", value);
    }

    /// <summary>
    /// The get_password_data attribute.
    /// </summary>
    public TerraformProperty<bool>? GetPasswordData
    {
        get => GetProperty<TerraformProperty<bool>>("get_password_data");
        set => this.WithProperty("get_password_data", value);
    }

    /// <summary>
    /// The hibernation attribute.
    /// </summary>
    public TerraformProperty<bool>? Hibernation
    {
        get => GetProperty<TerraformProperty<bool>>("hibernation");
        set => this.WithProperty("hibernation", value);
    }

    /// <summary>
    /// The host_id attribute.
    /// </summary>
    public TerraformProperty<string>? HostId
    {
        get => GetProperty<TerraformProperty<string>>("host_id");
        set => this.WithProperty("host_id", value);
    }

    /// <summary>
    /// The host_resource_group_arn attribute.
    /// </summary>
    public TerraformProperty<string>? HostResourceGroupArn
    {
        get => GetProperty<TerraformProperty<string>>("host_resource_group_arn");
        set => this.WithProperty("host_resource_group_arn", value);
    }

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    public TerraformProperty<string>? IamInstanceProfile
    {
        get => GetProperty<TerraformProperty<string>>("iam_instance_profile");
        set => this.WithProperty("iam_instance_profile", value);
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
    /// The ipv6_address_count attribute.
    /// </summary>
    public TerraformProperty<double>? Ipv6AddressCount
    {
        get => GetProperty<TerraformProperty<double>>("ipv6_address_count");
        set => this.WithProperty("ipv6_address_count", value);
    }

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Ipv6Addresses
    {
        get => GetProperty<List<TerraformProperty<string>>>("ipv6_addresses");
        set => this.WithProperty("ipv6_addresses", value);
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
    /// The monitoring attribute.
    /// </summary>
    public TerraformProperty<bool>? Monitoring
    {
        get => GetProperty<TerraformProperty<bool>>("monitoring");
        set => this.WithProperty("monitoring", value);
    }

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    public TerraformProperty<string>? PlacementGroup
    {
        get => GetProperty<TerraformProperty<string>>("placement_group");
        set => this.WithProperty("placement_group", value);
    }

    /// <summary>
    /// The placement_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? PlacementGroupId
    {
        get => GetProperty<TerraformProperty<string>>("placement_group_id");
        set => this.WithProperty("placement_group_id", value);
    }

    /// <summary>
    /// The placement_partition_number attribute.
    /// </summary>
    public TerraformProperty<double>? PlacementPartitionNumber
    {
        get => GetProperty<TerraformProperty<double>>("placement_partition_number");
        set => this.WithProperty("placement_partition_number", value);
    }

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateIp
    {
        get => GetProperty<TerraformProperty<string>>("private_ip");
        set => this.WithProperty("private_ip", value);
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
    /// The secondary_private_ips attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecondaryPrivateIps
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("secondary_private_ips");
        set => this.WithProperty("secondary_private_ips", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroups
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_groups");
        set => this.WithProperty("security_groups", value);
    }

    /// <summary>
    /// The source_dest_check attribute.
    /// </summary>
    public TerraformProperty<bool>? SourceDestCheck
    {
        get => GetProperty<TerraformProperty<bool>>("source_dest_check");
        set => this.WithProperty("source_dest_check", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
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
    /// The tenancy attribute.
    /// </summary>
    public TerraformProperty<string>? Tenancy
    {
        get => GetProperty<TerraformProperty<string>>("tenancy");
        set => this.WithProperty("tenancy", value);
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
    /// The user_data_base64 attribute.
    /// </summary>
    public TerraformProperty<string>? UserDataBase64
    {
        get => GetProperty<TerraformProperty<string>>("user_data_base64");
        set => this.WithProperty("user_data_base64", value);
    }

    /// <summary>
    /// The user_data_replace_on_change attribute.
    /// </summary>
    public TerraformProperty<bool>? UserDataReplaceOnChange
    {
        get => GetProperty<TerraformProperty<bool>>("user_data_replace_on_change");
        set => this.WithProperty("user_data_replace_on_change", value);
    }

    /// <summary>
    /// The volume_tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? VolumeTags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("volume_tags");
        set => this.WithProperty("volume_tags", value);
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
    /// Block for capacity_reservation_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityReservationSpecification block(s) allowed")]
    public List<AwsInstanceCapacityReservationSpecificationBlock>? CapacityReservationSpecification
    {
        get => GetProperty<List<AwsInstanceCapacityReservationSpecificationBlock>>("capacity_reservation_specification");
        set => this.WithProperty("capacity_reservation_specification", value);
    }

    /// <summary>
    /// Block for cpu_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CpuOptions block(s) allowed")]
    public List<AwsInstanceCpuOptionsBlock>? CpuOptions
    {
        get => GetProperty<List<AwsInstanceCpuOptionsBlock>>("cpu_options");
        set => this.WithProperty("cpu_options", value);
    }

    /// <summary>
    /// Block for credit_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CreditSpecification block(s) allowed")]
    public List<AwsInstanceCreditSpecificationBlock>? CreditSpecification
    {
        get => GetProperty<List<AwsInstanceCreditSpecificationBlock>>("credit_specification");
        set => this.WithProperty("credit_specification", value);
    }

    /// <summary>
    /// Block for ebs_block_device.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsInstanceEbsBlockDeviceBlock>? EbsBlockDevice
    {
        get => GetProperty<HashSet<AwsInstanceEbsBlockDeviceBlock>>("ebs_block_device");
        set => this.WithProperty("ebs_block_device", value);
    }

    /// <summary>
    /// Block for enclave_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnclaveOptions block(s) allowed")]
    public List<AwsInstanceEnclaveOptionsBlock>? EnclaveOptions
    {
        get => GetProperty<List<AwsInstanceEnclaveOptionsBlock>>("enclave_options");
        set => this.WithProperty("enclave_options", value);
    }

    /// <summary>
    /// Block for ephemeral_block_device.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsInstanceEphemeralBlockDeviceBlock>? EphemeralBlockDevice
    {
        get => GetProperty<HashSet<AwsInstanceEphemeralBlockDeviceBlock>>("ephemeral_block_device");
        set => this.WithProperty("ephemeral_block_device", value);
    }

    /// <summary>
    /// Block for instance_market_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceMarketOptions block(s) allowed")]
    public List<AwsInstanceInstanceMarketOptionsBlock>? InstanceMarketOptions
    {
        get => GetProperty<List<AwsInstanceInstanceMarketOptionsBlock>>("instance_market_options");
        set => this.WithProperty("instance_market_options", value);
    }

    /// <summary>
    /// Block for launch_template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchTemplate block(s) allowed")]
    public List<AwsInstanceLaunchTemplateBlock>? LaunchTemplate
    {
        get => GetProperty<List<AwsInstanceLaunchTemplateBlock>>("launch_template");
        set => this.WithProperty("launch_template", value);
    }

    /// <summary>
    /// Block for maintenance_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceOptions block(s) allowed")]
    public List<AwsInstanceMaintenanceOptionsBlock>? MaintenanceOptions
    {
        get => GetProperty<List<AwsInstanceMaintenanceOptionsBlock>>("maintenance_options");
        set => this.WithProperty("maintenance_options", value);
    }

    /// <summary>
    /// Block for metadata_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetadataOptions block(s) allowed")]
    public List<AwsInstanceMetadataOptionsBlock>? MetadataOptions
    {
        get => GetProperty<List<AwsInstanceMetadataOptionsBlock>>("metadata_options");
        set => this.WithProperty("metadata_options", value);
    }

    /// <summary>
    /// Block for network_interface.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsInstanceNetworkInterfaceBlock>? NetworkInterface
    {
        get => GetProperty<HashSet<AwsInstanceNetworkInterfaceBlock>>("network_interface");
        set => this.WithProperty("network_interface", value);
    }

    /// <summary>
    /// Block for primary_network_interface.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrimaryNetworkInterface block(s) allowed")]
    public List<AwsInstancePrimaryNetworkInterfaceBlock>? PrimaryNetworkInterface
    {
        get => GetProperty<List<AwsInstancePrimaryNetworkInterfaceBlock>>("primary_network_interface");
        set => this.WithProperty("primary_network_interface", value);
    }

    /// <summary>
    /// Block for private_dns_name_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateDnsNameOptions block(s) allowed")]
    public List<AwsInstancePrivateDnsNameOptionsBlock>? PrivateDnsNameOptions
    {
        get => GetProperty<List<AwsInstancePrivateDnsNameOptionsBlock>>("private_dns_name_options");
        set => this.WithProperty("private_dns_name_options", value);
    }

    /// <summary>
    /// Block for root_block_device.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RootBlockDevice block(s) allowed")]
    public List<AwsInstanceRootBlockDeviceBlock>? RootBlockDevice
    {
        get => GetProperty<List<AwsInstanceRootBlockDeviceBlock>>("root_block_device");
        set => this.WithProperty("root_block_device", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsInstanceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsInstanceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The instance_lifecycle attribute.
    /// </summary>
    public TerraformExpression InstanceLifecycle => this["instance_lifecycle"];

    /// <summary>
    /// The instance_state attribute.
    /// </summary>
    public TerraformExpression InstanceState => this["instance_state"];

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformExpression OutpostArn => this["outpost_arn"];

    /// <summary>
    /// The password_data attribute.
    /// </summary>
    public TerraformExpression PasswordData => this["password_data"];

    /// <summary>
    /// The primary_network_interface_id attribute.
    /// </summary>
    public TerraformExpression PrimaryNetworkInterfaceId => this["primary_network_interface_id"];

    /// <summary>
    /// The private_dns attribute.
    /// </summary>
    public TerraformExpression PrivateDns => this["private_dns"];

    /// <summary>
    /// The public_dns attribute.
    /// </summary>
    public TerraformExpression PublicDns => this["public_dns"];

    /// <summary>
    /// The public_ip attribute.
    /// </summary>
    public TerraformExpression PublicIp => this["public_ip"];

    /// <summary>
    /// The spot_instance_request_id attribute.
    /// </summary>
    public TerraformExpression SpotInstanceRequestId => this["spot_instance_request_id"];

}
