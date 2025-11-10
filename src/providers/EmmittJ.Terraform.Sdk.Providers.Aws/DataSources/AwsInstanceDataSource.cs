using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsInstanceDataSourceFilterBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsInstanceDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    public TerraformProperty<TerraformProperty<bool>>? GetPasswordData { get; set; }

    /// <summary>
    /// The get_user_data attribute.
    /// </summary>
    [TerraformPropertyName("get_user_data")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? GetUserData { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [TerraformPropertyName("instance_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InstanceId { get; set; }

    /// <summary>
    /// The instance_tags attribute.
    /// </summary>
    [TerraformPropertyName("instance_tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> InstanceTags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "instance_tags");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsInstanceDataSourceFilterBlock>>? Filter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsInstanceDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The ami attribute.
    /// </summary>
    [TerraformPropertyName("ami")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Ami => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ami");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    [TerraformPropertyName("associate_public_ip_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AssociatePublicIpAddress => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "associate_public_ip_address");

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AvailabilityZone => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone");

    /// <summary>
    /// The credit_specification attribute.
    /// </summary>
    [TerraformPropertyName("credit_specification")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CreditSpecification => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "credit_specification");

    /// <summary>
    /// The disable_api_stop attribute.
    /// </summary>
    [TerraformPropertyName("disable_api_stop")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DisableApiStop => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "disable_api_stop");

    /// <summary>
    /// The disable_api_termination attribute.
    /// </summary>
    [TerraformPropertyName("disable_api_termination")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DisableApiTermination => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "disable_api_termination");

    /// <summary>
    /// The ebs_block_device attribute.
    /// </summary>
    [TerraformPropertyName("ebs_block_device")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> EbsBlockDevice => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "ebs_block_device");

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    [TerraformPropertyName("ebs_optimized")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EbsOptimized => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "ebs_optimized");

    /// <summary>
    /// The enclave_options attribute.
    /// </summary>
    [TerraformPropertyName("enclave_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EnclaveOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "enclave_options");

    /// <summary>
    /// The ephemeral_block_device attribute.
    /// </summary>
    [TerraformPropertyName("ephemeral_block_device")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EphemeralBlockDevice => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "ephemeral_block_device");

    /// <summary>
    /// The host_id attribute.
    /// </summary>
    [TerraformPropertyName("host_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HostId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "host_id");

    /// <summary>
    /// The host_resource_group_arn attribute.
    /// </summary>
    [TerraformPropertyName("host_resource_group_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HostResourceGroupArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "host_resource_group_arn");

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    [TerraformPropertyName("iam_instance_profile")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IamInstanceProfile => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "iam_instance_profile");

    /// <summary>
    /// The instance_state attribute.
    /// </summary>
    [TerraformPropertyName("instance_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InstanceState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "instance_state");

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformPropertyName("instance_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InstanceType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "instance_type");

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> Ipv6Addresses => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "ipv6_addresses");

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    [TerraformPropertyName("key_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KeyName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "key_name");

    /// <summary>
    /// The launch_time attribute.
    /// </summary>
    [TerraformPropertyName("launch_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LaunchTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "launch_time");

    /// <summary>
    /// The maintenance_options attribute.
    /// </summary>
    [TerraformPropertyName("maintenance_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MaintenanceOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "maintenance_options");

    /// <summary>
    /// The metadata_options attribute.
    /// </summary>
    [TerraformPropertyName("metadata_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MetadataOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "metadata_options");

    /// <summary>
    /// The monitoring attribute.
    /// </summary>
    [TerraformPropertyName("monitoring")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Monitoring => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "monitoring");

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [TerraformPropertyName("network_interface_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NetworkInterfaceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_interface_id");

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
    /// The placement_group attribute.
    /// </summary>
    [TerraformPropertyName("placement_group")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PlacementGroup => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "placement_group");

    /// <summary>
    /// The placement_group_id attribute.
    /// </summary>
    [TerraformPropertyName("placement_group_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PlacementGroupId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "placement_group_id");

    /// <summary>
    /// The placement_partition_number attribute.
    /// </summary>
    [TerraformPropertyName("placement_partition_number")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> PlacementPartitionNumber => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "placement_partition_number");

    /// <summary>
    /// The private_dns attribute.
    /// </summary>
    [TerraformPropertyName("private_dns")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivateDns => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_dns");

    /// <summary>
    /// The private_dns_name_options attribute.
    /// </summary>
    [TerraformPropertyName("private_dns_name_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PrivateDnsNameOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "private_dns_name_options");

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    [TerraformPropertyName("private_ip")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivateIp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_ip");

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
    /// The root_block_device attribute.
    /// </summary>
    [TerraformPropertyName("root_block_device")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> RootBlockDevice => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "root_block_device");

    /// <summary>
    /// The secondary_private_ips attribute.
    /// </summary>
    [TerraformPropertyName("secondary_private_ips")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> SecondaryPrivateIps => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "secondary_private_ips");

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformPropertyName("security_groups")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> SecurityGroups => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "security_groups");

    /// <summary>
    /// The source_dest_check attribute.
    /// </summary>
    [TerraformPropertyName("source_dest_check")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> SourceDestCheck => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "source_dest_check");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SubnetId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "subnet_id");

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    [TerraformPropertyName("tenancy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Tenancy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tenancy");

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    [TerraformPropertyName("user_data")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UserData => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "user_data");

    /// <summary>
    /// The user_data_base64 attribute.
    /// </summary>
    [TerraformPropertyName("user_data_base64")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UserDataBase64 => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "user_data_base64");

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("vpc_security_group_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> VpcSecurityGroupIds => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "vpc_security_group_ids");

}
