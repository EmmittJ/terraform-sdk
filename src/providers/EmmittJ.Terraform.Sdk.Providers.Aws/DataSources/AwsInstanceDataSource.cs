using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsInstanceDataSource.
/// Nesting mode: set
/// </summary>
public class AwsInstanceDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => GetRequiredArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsInstanceDataSource.
/// Nesting mode: single
/// </summary>
public class AwsInstanceDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a aws_instance Terraform data source.
/// Retrieves information about a aws_instance.
/// </summary>
public partial class AwsInstanceDataSource(string name) : TerraformDataSource("aws_instance", name)
{
    /// <summary>
    /// The get_password_data attribute.
    /// </summary>
    public TerraformValue<bool>? GetPasswordData
    {
        get => GetArgument<TerraformValue<bool>>("get_password_data");
        set => SetArgument("get_password_data", value);
    }

    /// <summary>
    /// The get_user_data attribute.
    /// </summary>
    public TerraformValue<bool>? GetUserData
    {
        get => GetArgument<TerraformValue<bool>>("get_user_data");
        set => SetArgument("get_user_data", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    public TerraformValue<string>? InstanceId
    {
        get => GetArgument<TerraformValue<string>>("instance_id");
        set => SetArgument("instance_id", value);
    }

    /// <summary>
    /// The instance_tags attribute.
    /// </summary>
    public TerraformMap<string> InstanceTags
    {
        get => GetArgument<TerraformMap<string>>("instance_tags") ?? CreateReference("instance_tags");
        set => SetArgument("instance_tags", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The ami attribute.
    /// </summary>
    public TerraformValue<string> Ami
        => CreateReference("ami");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    public TerraformValue<bool> AssociatePublicIpAddress
        => CreateReference("associate_public_ip_address");

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
        => CreateReference("availability_zone");

    /// <summary>
    /// The credit_specification attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CreditSpecification
        => CreateReference("credit_specification");

    /// <summary>
    /// The disable_api_stop attribute.
    /// </summary>
    public TerraformValue<bool> DisableApiStop
        => CreateReference("disable_api_stop");

    /// <summary>
    /// The disable_api_termination attribute.
    /// </summary>
    public TerraformValue<bool> DisableApiTermination
        => CreateReference("disable_api_termination");

    /// <summary>
    /// The ebs_block_device attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> EbsBlockDevice
        => CreateReference("ebs_block_device");

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    public TerraformValue<bool> EbsOptimized
        => CreateReference("ebs_optimized");

    /// <summary>
    /// The enclave_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EnclaveOptions
        => CreateReference("enclave_options");

    /// <summary>
    /// The ephemeral_block_device attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EphemeralBlockDevice
        => CreateReference("ephemeral_block_device");

    /// <summary>
    /// The host_id attribute.
    /// </summary>
    public TerraformValue<string> HostId
        => CreateReference("host_id");

    /// <summary>
    /// The host_resource_group_arn attribute.
    /// </summary>
    public TerraformValue<string> HostResourceGroupArn
        => CreateReference("host_resource_group_arn");

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    public TerraformValue<string> IamInstanceProfile
        => CreateReference("iam_instance_profile");

    /// <summary>
    /// The instance_state attribute.
    /// </summary>
    public TerraformValue<string> InstanceState
        => CreateReference("instance_state");

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string> InstanceType
        => CreateReference("instance_type");

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    public TerraformSet<string> Ipv6Addresses
        => CreateReference("ipv6_addresses");

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    public TerraformValue<string> KeyName
        => CreateReference("key_name");

    /// <summary>
    /// The launch_time attribute.
    /// </summary>
    public TerraformValue<string> LaunchTime
        => CreateReference("launch_time");

    /// <summary>
    /// The maintenance_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MaintenanceOptions
        => CreateReference("maintenance_options");

    /// <summary>
    /// The metadata_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MetadataOptions
        => CreateReference("metadata_options");

    /// <summary>
    /// The monitoring attribute.
    /// </summary>
    public TerraformValue<bool> Monitoring
        => CreateReference("monitoring");

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformValue<string> NetworkInterfaceId
        => CreateReference("network_interface_id");

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformValue<string> OutpostArn
        => CreateReference("outpost_arn");

    /// <summary>
    /// The password_data attribute.
    /// </summary>
    public TerraformValue<string> PasswordData
        => CreateReference("password_data");

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    public TerraformValue<string> PlacementGroup
        => CreateReference("placement_group");

    /// <summary>
    /// The placement_group_id attribute.
    /// </summary>
    public TerraformValue<string> PlacementGroupId
        => CreateReference("placement_group_id");

    /// <summary>
    /// The placement_partition_number attribute.
    /// </summary>
    public TerraformValue<double> PlacementPartitionNumber
        => CreateReference("placement_partition_number");

    /// <summary>
    /// The private_dns attribute.
    /// </summary>
    public TerraformValue<string> PrivateDns
        => CreateReference("private_dns");

    /// <summary>
    /// The private_dns_name_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PrivateDnsNameOptions
        => CreateReference("private_dns_name_options");

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    public TerraformValue<string> PrivateIp
        => CreateReference("private_ip");

    /// <summary>
    /// The public_dns attribute.
    /// </summary>
    public TerraformValue<string> PublicDns
        => CreateReference("public_dns");

    /// <summary>
    /// The public_ip attribute.
    /// </summary>
    public TerraformValue<string> PublicIp
        => CreateReference("public_ip");

    /// <summary>
    /// The root_block_device attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> RootBlockDevice
        => CreateReference("root_block_device");

    /// <summary>
    /// The secondary_private_ips attribute.
    /// </summary>
    public TerraformSet<string> SecondaryPrivateIps
        => CreateReference("secondary_private_ips");

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroups
        => CreateReference("security_groups");

    /// <summary>
    /// The source_dest_check attribute.
    /// </summary>
    public TerraformValue<bool> SourceDestCheck
        => CreateReference("source_dest_check");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string> SubnetId
        => CreateReference("subnet_id");

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    public TerraformValue<string> Tenancy
        => CreateReference("tenancy");

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    public TerraformValue<string> UserData
        => CreateReference("user_data");

    /// <summary>
    /// The user_data_base64 attribute.
    /// </summary>
    public TerraformValue<string> UserDataBase64
        => CreateReference("user_data_base64");

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> VpcSecurityGroupIds
        => CreateReference("vpc_security_group_ids");

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInstanceDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsInstanceDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsInstanceDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsInstanceDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
