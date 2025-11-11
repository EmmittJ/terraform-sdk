using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsInstanceDataSourceFilterBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsInstanceDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_instance.
/// </summary>
public partial class AwsInstanceDataSource : TerraformDataSource
{
    public AwsInstanceDataSource(string name) : base("aws_instance", name)
    {
    }

    /// <summary>
    /// The get_password_data attribute.
    /// </summary>
    [TerraformProperty("get_password_data")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? GetPasswordData { get; set; }

    /// <summary>
    /// The get_user_data attribute.
    /// </summary>
    [TerraformProperty("get_user_data")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? GetUserData { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [TerraformProperty("instance_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? InstanceId { get; set; }

    /// <summary>
    /// The instance_tags attribute.
    /// </summary>
    [TerraformProperty("instance_tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> InstanceTags { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("filter")]
    public TerraformSet<TerraformBlock<AwsInstanceDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsInstanceDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The ami attribute.
    /// </summary>
    [TerraformProperty("ami")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Ami { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    [TerraformProperty("associate_public_ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> AssociatePublicIpAddress { get; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformProperty("availability_zone")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AvailabilityZone { get; }

    /// <summary>
    /// The credit_specification attribute.
    /// </summary>
    [TerraformProperty("credit_specification")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> CreditSpecification { get; }

    /// <summary>
    /// The disable_api_stop attribute.
    /// </summary>
    [TerraformProperty("disable_api_stop")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> DisableApiStop { get; }

    /// <summary>
    /// The disable_api_termination attribute.
    /// </summary>
    [TerraformProperty("disable_api_termination")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> DisableApiTermination { get; }

    /// <summary>
    /// The ebs_block_device attribute.
    /// </summary>
    [TerraformProperty("ebs_block_device")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<object> EbsBlockDevice { get; }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    [TerraformProperty("ebs_optimized")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EbsOptimized { get; }

    /// <summary>
    /// The enclave_options attribute.
    /// </summary>
    [TerraformProperty("enclave_options")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> EnclaveOptions { get; }

    /// <summary>
    /// The ephemeral_block_device attribute.
    /// </summary>
    [TerraformProperty("ephemeral_block_device")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> EphemeralBlockDevice { get; }

    /// <summary>
    /// The host_id attribute.
    /// </summary>
    [TerraformProperty("host_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> HostId { get; }

    /// <summary>
    /// The host_resource_group_arn attribute.
    /// </summary>
    [TerraformProperty("host_resource_group_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> HostResourceGroupArn { get; }

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    [TerraformProperty("iam_instance_profile")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> IamInstanceProfile { get; }

    /// <summary>
    /// The instance_state attribute.
    /// </summary>
    [TerraformProperty("instance_state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> InstanceState { get; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformProperty("instance_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> InstanceType { get; }

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    [TerraformProperty("ipv6_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> Ipv6Addresses { get; }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    [TerraformProperty("key_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KeyName { get; }

    /// <summary>
    /// The launch_time attribute.
    /// </summary>
    [TerraformProperty("launch_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LaunchTime { get; }

    /// <summary>
    /// The maintenance_options attribute.
    /// </summary>
    [TerraformProperty("maintenance_options")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> MaintenanceOptions { get; }

    /// <summary>
    /// The metadata_options attribute.
    /// </summary>
    [TerraformProperty("metadata_options")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> MetadataOptions { get; }

    /// <summary>
    /// The monitoring attribute.
    /// </summary>
    [TerraformProperty("monitoring")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Monitoring { get; }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [TerraformProperty("network_interface_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NetworkInterfaceId { get; }

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
    /// The placement_group attribute.
    /// </summary>
    [TerraformProperty("placement_group")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PlacementGroup { get; }

    /// <summary>
    /// The placement_group_id attribute.
    /// </summary>
    [TerraformProperty("placement_group_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PlacementGroupId { get; }

    /// <summary>
    /// The placement_partition_number attribute.
    /// </summary>
    [TerraformProperty("placement_partition_number")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> PlacementPartitionNumber { get; }

    /// <summary>
    /// The private_dns attribute.
    /// </summary>
    [TerraformProperty("private_dns")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrivateDns { get; }

    /// <summary>
    /// The private_dns_name_options attribute.
    /// </summary>
    [TerraformProperty("private_dns_name_options")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> PrivateDnsNameOptions { get; }

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    [TerraformProperty("private_ip")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrivateIp { get; }

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
    /// The root_block_device attribute.
    /// </summary>
    [TerraformProperty("root_block_device")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<object> RootBlockDevice { get; }

    /// <summary>
    /// The secondary_private_ips attribute.
    /// </summary>
    [TerraformProperty("secondary_private_ips")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> SecondaryPrivateIps { get; }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformProperty("security_groups")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> SecurityGroups { get; }

    /// <summary>
    /// The source_dest_check attribute.
    /// </summary>
    [TerraformProperty("source_dest_check")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> SourceDestCheck { get; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformProperty("subnet_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SubnetId { get; }

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    [TerraformProperty("tenancy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Tenancy { get; }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    [TerraformProperty("user_data")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UserData { get; }

    /// <summary>
    /// The user_data_base64 attribute.
    /// </summary>
    [TerraformProperty("user_data_base64")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UserDataBase64 { get; }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformProperty("vpc_security_group_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> VpcSecurityGroupIds { get; }

}
