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
        set => SetProperty("capacity_reservation_preference", value);
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
public class AwsInstanceCreditSpecificationBlock : TerraformBlock
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
        set => SetProperty("delete_on_termination", value);
    }

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    public required TerraformProperty<string> DeviceName
    {
        set => SetProperty("device_name", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformProperty<bool>? Encrypted
    {
        set => SetProperty("encrypted", value);
    }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformProperty<double>? Iops
    {
        set => SetProperty("iops", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        set => SetProperty("kms_key_id", value);
    }

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    public TerraformProperty<string>? SnapshotId
    {
        set => SetProperty("snapshot_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    public TerraformProperty<double>? Throughput
    {
        set => SetProperty("throughput", value);
    }

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    public TerraformProperty<string>? VolumeId
    {
        set => SetProperty("volume_id", value);
    }

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    public TerraformProperty<double>? VolumeSize
    {
        set => SetProperty("volume_size", value);
    }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    public TerraformProperty<string>? VolumeType
    {
        set => SetProperty("volume_type", value);
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
        set => SetProperty("enabled", value);
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
        set => SetProperty("device_name", value);
    }

    /// <summary>
    /// The no_device attribute.
    /// </summary>
    public TerraformProperty<bool>? NoDevice
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
        set => SetProperty("market_type", value);
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
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        set => SetProperty("version", value);
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
        set => SetProperty("auto_recovery", value);
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
/// Block type for network_interface in .
/// Nesting mode: set
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsInstanceNetworkInterfaceBlock : TerraformBlock
{
    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    public TerraformProperty<bool>? DeleteOnTermination
    {
        set => SetProperty("delete_on_termination", value);
    }

    /// <summary>
    /// The device_index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceIndex is required")]
    public required TerraformProperty<double> DeviceIndex
    {
        set => SetProperty("device_index", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceId is required")]
    public required TerraformProperty<string> NetworkInterfaceId
    {
        set => SetProperty("network_interface_id", value);
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
        set => SetProperty("delete_on_termination", value);
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceId is required")]
    public required TerraformProperty<string> NetworkInterfaceId
    {
        set => SetProperty("network_interface_id", value);
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
        set => SetProperty("delete_on_termination", value);
    }

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    public TerraformProperty<string>? DeviceName
    {
        set => SetProperty("device_name", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformProperty<bool>? Encrypted
    {
        set => SetProperty("encrypted", value);
    }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformProperty<double>? Iops
    {
        set => SetProperty("iops", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        set => SetProperty("kms_key_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    public TerraformProperty<double>? Throughput
    {
        set => SetProperty("throughput", value);
    }

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    public TerraformProperty<string>? VolumeId
    {
        set => SetProperty("volume_id", value);
    }

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    public TerraformProperty<double>? VolumeSize
    {
        set => SetProperty("volume_size", value);
    }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    public TerraformProperty<string>? VolumeType
    {
        set => SetProperty("volume_type", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsInstance : TerraformResource
{
    public AwsInstance(string name) : base("aws_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("instance_lifecycle");
        SetOutput("instance_state");
        SetOutput("outpost_arn");
        SetOutput("password_data");
        SetOutput("primary_network_interface_id");
        SetOutput("private_dns");
        SetOutput("public_dns");
        SetOutput("public_ip");
        SetOutput("spot_instance_request_id");
        SetOutput("ami");
        SetOutput("associate_public_ip_address");
        SetOutput("availability_zone");
        SetOutput("disable_api_stop");
        SetOutput("disable_api_termination");
        SetOutput("ebs_optimized");
        SetOutput("enable_primary_ipv6");
        SetOutput("force_destroy");
        SetOutput("get_password_data");
        SetOutput("hibernation");
        SetOutput("host_id");
        SetOutput("host_resource_group_arn");
        SetOutput("iam_instance_profile");
        SetOutput("id");
        SetOutput("instance_initiated_shutdown_behavior");
        SetOutput("instance_type");
        SetOutput("ipv6_address_count");
        SetOutput("ipv6_addresses");
        SetOutput("key_name");
        SetOutput("monitoring");
        SetOutput("placement_group");
        SetOutput("placement_group_id");
        SetOutput("placement_partition_number");
        SetOutput("private_ip");
        SetOutput("region");
        SetOutput("secondary_private_ips");
        SetOutput("security_groups");
        SetOutput("source_dest_check");
        SetOutput("subnet_id");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("tenancy");
        SetOutput("user_data");
        SetOutput("user_data_base64");
        SetOutput("user_data_replace_on_change");
        SetOutput("volume_tags");
        SetOutput("vpc_security_group_ids");
    }

    /// <summary>
    /// The ami attribute.
    /// </summary>
    public TerraformProperty<string> Ami
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ami");
        set => SetProperty("ami", value);
    }

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    public TerraformProperty<bool> AssociatePublicIpAddress
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("associate_public_ip_address");
        set => SetProperty("associate_public_ip_address", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformProperty<string> AvailabilityZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("availability_zone");
        set => SetProperty("availability_zone", value);
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
    public TerraformProperty<bool> EbsOptimized
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("ebs_optimized");
        set => SetProperty("ebs_optimized", value);
    }

    /// <summary>
    /// The enable_primary_ipv6 attribute.
    /// </summary>
    public TerraformProperty<bool> EnablePrimaryIpv6
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_primary_ipv6");
        set => SetProperty("enable_primary_ipv6", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformProperty<bool> ForceDestroy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("force_destroy");
        set => SetProperty("force_destroy", value);
    }

    /// <summary>
    /// The get_password_data attribute.
    /// </summary>
    public TerraformProperty<bool> GetPasswordData
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("get_password_data");
        set => SetProperty("get_password_data", value);
    }

    /// <summary>
    /// The hibernation attribute.
    /// </summary>
    public TerraformProperty<bool> Hibernation
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("hibernation");
        set => SetProperty("hibernation", value);
    }

    /// <summary>
    /// The host_id attribute.
    /// </summary>
    public TerraformProperty<string> HostId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("host_id");
        set => SetProperty("host_id", value);
    }

    /// <summary>
    /// The host_resource_group_arn attribute.
    /// </summary>
    public TerraformProperty<string> HostResourceGroupArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("host_resource_group_arn");
        set => SetProperty("host_resource_group_arn", value);
    }

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    public TerraformProperty<string> IamInstanceProfile
    {
        get => GetRequiredOutput<TerraformProperty<string>>("iam_instance_profile");
        set => SetProperty("iam_instance_profile", value);
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
    /// The ipv6_address_count attribute.
    /// </summary>
    public TerraformProperty<double> Ipv6AddressCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("ipv6_address_count");
        set => SetProperty("ipv6_address_count", value);
    }

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    public List<TerraformProperty<string>> Ipv6Addresses
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("ipv6_addresses");
        set => SetProperty("ipv6_addresses", value);
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
    /// The monitoring attribute.
    /// </summary>
    public TerraformProperty<bool> Monitoring
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("monitoring");
        set => SetProperty("monitoring", value);
    }

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    public TerraformProperty<string> PlacementGroup
    {
        get => GetRequiredOutput<TerraformProperty<string>>("placement_group");
        set => SetProperty("placement_group", value);
    }

    /// <summary>
    /// The placement_group_id attribute.
    /// </summary>
    public TerraformProperty<string> PlacementGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("placement_group_id");
        set => SetProperty("placement_group_id", value);
    }

    /// <summary>
    /// The placement_partition_number attribute.
    /// </summary>
    public TerraformProperty<double> PlacementPartitionNumber
    {
        get => GetRequiredOutput<TerraformProperty<double>>("placement_partition_number");
        set => SetProperty("placement_partition_number", value);
    }

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    public TerraformProperty<string> PrivateIp
    {
        get => GetRequiredOutput<TerraformProperty<string>>("private_ip");
        set => SetProperty("private_ip", value);
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
    /// The secondary_private_ips attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SecondaryPrivateIps
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("secondary_private_ips");
        set => SetProperty("secondary_private_ips", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SecurityGroups
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("security_groups");
        set => SetProperty("security_groups", value);
    }

    /// <summary>
    /// The source_dest_check attribute.
    /// </summary>
    public TerraformProperty<bool> SourceDestCheck
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("source_dest_check");
        set => SetProperty("source_dest_check", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string> SubnetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subnet_id");
        set => SetProperty("subnet_id", value);
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
    /// The tenancy attribute.
    /// </summary>
    public TerraformProperty<string> Tenancy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tenancy");
        set => SetProperty("tenancy", value);
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
    /// The user_data_base64 attribute.
    /// </summary>
    public TerraformProperty<string> UserDataBase64
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_data_base64");
        set => SetProperty("user_data_base64", value);
    }

    /// <summary>
    /// The user_data_replace_on_change attribute.
    /// </summary>
    public TerraformProperty<bool> UserDataReplaceOnChange
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("user_data_replace_on_change");
        set => SetProperty("user_data_replace_on_change", value);
    }

    /// <summary>
    /// The volume_tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> VolumeTags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("volume_tags");
        set => SetProperty("volume_tags", value);
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
    /// Block for capacity_reservation_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityReservationSpecification block(s) allowed")]
    public List<AwsInstanceCapacityReservationSpecificationBlock>? CapacityReservationSpecification
    {
        set => SetProperty("capacity_reservation_specification", value);
    }

    /// <summary>
    /// Block for cpu_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CpuOptions block(s) allowed")]
    public List<AwsInstanceCpuOptionsBlock>? CpuOptions
    {
        set => SetProperty("cpu_options", value);
    }

    /// <summary>
    /// Block for credit_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CreditSpecification block(s) allowed")]
    public List<AwsInstanceCreditSpecificationBlock>? CreditSpecification
    {
        set => SetProperty("credit_specification", value);
    }

    /// <summary>
    /// Block for ebs_block_device.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsInstanceEbsBlockDeviceBlock>? EbsBlockDevice
    {
        set => SetProperty("ebs_block_device", value);
    }

    /// <summary>
    /// Block for enclave_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnclaveOptions block(s) allowed")]
    public List<AwsInstanceEnclaveOptionsBlock>? EnclaveOptions
    {
        set => SetProperty("enclave_options", value);
    }

    /// <summary>
    /// Block for ephemeral_block_device.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsInstanceEphemeralBlockDeviceBlock>? EphemeralBlockDevice
    {
        set => SetProperty("ephemeral_block_device", value);
    }

    /// <summary>
    /// Block for instance_market_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceMarketOptions block(s) allowed")]
    public List<AwsInstanceInstanceMarketOptionsBlock>? InstanceMarketOptions
    {
        set => SetProperty("instance_market_options", value);
    }

    /// <summary>
    /// Block for launch_template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchTemplate block(s) allowed")]
    public List<AwsInstanceLaunchTemplateBlock>? LaunchTemplate
    {
        set => SetProperty("launch_template", value);
    }

    /// <summary>
    /// Block for maintenance_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceOptions block(s) allowed")]
    public List<AwsInstanceMaintenanceOptionsBlock>? MaintenanceOptions
    {
        set => SetProperty("maintenance_options", value);
    }

    /// <summary>
    /// Block for metadata_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetadataOptions block(s) allowed")]
    public List<AwsInstanceMetadataOptionsBlock>? MetadataOptions
    {
        set => SetProperty("metadata_options", value);
    }

    /// <summary>
    /// Block for network_interface.
    /// Nesting mode: set
    /// </summary>
    [Obsolete("This block is deprecated.")]
    public HashSet<AwsInstanceNetworkInterfaceBlock>? NetworkInterface
    {
        set => SetProperty("network_interface", value);
    }

    /// <summary>
    /// Block for primary_network_interface.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrimaryNetworkInterface block(s) allowed")]
    public List<AwsInstancePrimaryNetworkInterfaceBlock>? PrimaryNetworkInterface
    {
        set => SetProperty("primary_network_interface", value);
    }

    /// <summary>
    /// Block for private_dns_name_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateDnsNameOptions block(s) allowed")]
    public List<AwsInstancePrivateDnsNameOptionsBlock>? PrivateDnsNameOptions
    {
        set => SetProperty("private_dns_name_options", value);
    }

    /// <summary>
    /// Block for root_block_device.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RootBlockDevice block(s) allowed")]
    public List<AwsInstanceRootBlockDeviceBlock>? RootBlockDevice
    {
        set => SetProperty("root_block_device", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsInstanceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
