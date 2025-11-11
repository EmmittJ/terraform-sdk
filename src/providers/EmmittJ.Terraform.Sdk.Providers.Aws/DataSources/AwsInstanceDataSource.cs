using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsInstanceDataSourceFilterBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsInstanceDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_instance.
/// </summary>
public class AwsInstanceDataSource : TerraformDataSource
{
    public AwsInstanceDataSource(string name) : base("aws_instance", name)
    {
    }

    /// <summary>
    /// The get_password_data attribute.
    /// </summary>
    [TerraformPropertyName("get_password_data")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? GetPasswordData { get; set; }

    /// <summary>
    /// The get_user_data attribute.
    /// </summary>
    [TerraformPropertyName("get_user_data")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? GetUserData { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [TerraformPropertyName("instance_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InstanceId { get; set; }

    /// <summary>
    /// The instance_tags attribute.
    /// </summary>
    [TerraformPropertyName("instance_tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> InstanceTags { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsInstanceDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsInstanceDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The ami attribute.
    /// </summary>
    [TerraformPropertyName("ami")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Ami => new TerraformReference(this, "ami");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    [TerraformPropertyName("associate_public_ip_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AssociatePublicIpAddress => new TerraformReference(this, "associate_public_ip_address");

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AvailabilityZone => new TerraformReference(this, "availability_zone");

    /// <summary>
    /// The credit_specification attribute.
    /// </summary>
    [TerraformPropertyName("credit_specification")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CreditSpecification => new TerraformReference(this, "credit_specification");

    /// <summary>
    /// The disable_api_stop attribute.
    /// </summary>
    [TerraformPropertyName("disable_api_stop")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DisableApiStop => new TerraformReference(this, "disable_api_stop");

    /// <summary>
    /// The disable_api_termination attribute.
    /// </summary>
    [TerraformPropertyName("disable_api_termination")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DisableApiTermination => new TerraformReference(this, "disable_api_termination");

    /// <summary>
    /// The ebs_block_device attribute.
    /// </summary>
    [TerraformPropertyName("ebs_block_device")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> EbsBlockDevice => new TerraformReference(this, "ebs_block_device");

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    [TerraformPropertyName("ebs_optimized")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EbsOptimized => new TerraformReference(this, "ebs_optimized");

    /// <summary>
    /// The enclave_options attribute.
    /// </summary>
    [TerraformPropertyName("enclave_options")]
    // Output-only attribute - read-only reference
    public TerraformList<object> EnclaveOptions => new TerraformReference(this, "enclave_options");

    /// <summary>
    /// The ephemeral_block_device attribute.
    /// </summary>
    [TerraformPropertyName("ephemeral_block_device")]
    // Output-only attribute - read-only reference
    public TerraformList<object> EphemeralBlockDevice => new TerraformReference(this, "ephemeral_block_device");

    /// <summary>
    /// The host_id attribute.
    /// </summary>
    [TerraformPropertyName("host_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HostId => new TerraformReference(this, "host_id");

    /// <summary>
    /// The host_resource_group_arn attribute.
    /// </summary>
    [TerraformPropertyName("host_resource_group_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HostResourceGroupArn => new TerraformReference(this, "host_resource_group_arn");

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    [TerraformPropertyName("iam_instance_profile")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IamInstanceProfile => new TerraformReference(this, "iam_instance_profile");

    /// <summary>
    /// The instance_state attribute.
    /// </summary>
    [TerraformPropertyName("instance_state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InstanceState => new TerraformReference(this, "instance_state");

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformPropertyName("instance_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InstanceType => new TerraformReference(this, "instance_type");

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_addresses")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> Ipv6Addresses => new TerraformReference(this, "ipv6_addresses");

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    [TerraformPropertyName("key_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KeyName => new TerraformReference(this, "key_name");

    /// <summary>
    /// The launch_time attribute.
    /// </summary>
    [TerraformPropertyName("launch_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LaunchTime => new TerraformReference(this, "launch_time");

    /// <summary>
    /// The maintenance_options attribute.
    /// </summary>
    [TerraformPropertyName("maintenance_options")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MaintenanceOptions => new TerraformReference(this, "maintenance_options");

    /// <summary>
    /// The metadata_options attribute.
    /// </summary>
    [TerraformPropertyName("metadata_options")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MetadataOptions => new TerraformReference(this, "metadata_options");

    /// <summary>
    /// The monitoring attribute.
    /// </summary>
    [TerraformPropertyName("monitoring")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Monitoring => new TerraformReference(this, "monitoring");

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [TerraformPropertyName("network_interface_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NetworkInterfaceId => new TerraformReference(this, "network_interface_id");

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
    /// The placement_group attribute.
    /// </summary>
    [TerraformPropertyName("placement_group")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PlacementGroup => new TerraformReference(this, "placement_group");

    /// <summary>
    /// The placement_group_id attribute.
    /// </summary>
    [TerraformPropertyName("placement_group_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PlacementGroupId => new TerraformReference(this, "placement_group_id");

    /// <summary>
    /// The placement_partition_number attribute.
    /// </summary>
    [TerraformPropertyName("placement_partition_number")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> PlacementPartitionNumber => new TerraformReference(this, "placement_partition_number");

    /// <summary>
    /// The private_dns attribute.
    /// </summary>
    [TerraformPropertyName("private_dns")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrivateDns => new TerraformReference(this, "private_dns");

    /// <summary>
    /// The private_dns_name_options attribute.
    /// </summary>
    [TerraformPropertyName("private_dns_name_options")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PrivateDnsNameOptions => new TerraformReference(this, "private_dns_name_options");

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    [TerraformPropertyName("private_ip")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrivateIp => new TerraformReference(this, "private_ip");

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
    /// The root_block_device attribute.
    /// </summary>
    [TerraformPropertyName("root_block_device")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> RootBlockDevice => new TerraformReference(this, "root_block_device");

    /// <summary>
    /// The secondary_private_ips attribute.
    /// </summary>
    [TerraformPropertyName("secondary_private_ips")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> SecondaryPrivateIps => new TerraformReference(this, "secondary_private_ips");

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformPropertyName("security_groups")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> SecurityGroups => new TerraformReference(this, "security_groups");

    /// <summary>
    /// The source_dest_check attribute.
    /// </summary>
    [TerraformPropertyName("source_dest_check")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> SourceDestCheck => new TerraformReference(this, "source_dest_check");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SubnetId => new TerraformReference(this, "subnet_id");

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    [TerraformPropertyName("tenancy")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Tenancy => new TerraformReference(this, "tenancy");

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    [TerraformPropertyName("user_data")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UserData => new TerraformReference(this, "user_data");

    /// <summary>
    /// The user_data_base64 attribute.
    /// </summary>
    [TerraformPropertyName("user_data_base64")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UserDataBase64 => new TerraformReference(this, "user_data_base64");

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("vpc_security_group_ids")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> VpcSecurityGroupIds => new TerraformReference(this, "vpc_security_group_ids");

}
