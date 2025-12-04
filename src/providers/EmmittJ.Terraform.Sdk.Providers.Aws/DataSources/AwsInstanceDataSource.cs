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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
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
        get => GetArgument<TerraformMap<string>>("instance_tags") ?? AsReference("instance_tags");
        set => SetArgument("instance_tags", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? AsReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The ami attribute.
    /// </summary>
    public TerraformValue<string> Ami
        => AsReference("ami");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    public TerraformValue<bool> AssociatePublicIpAddress
        => AsReference("associate_public_ip_address");

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
        => AsReference("availability_zone");

    /// <summary>
    /// The credit_specification attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CreditSpecification
        => AsReference("credit_specification");

    /// <summary>
    /// The disable_api_stop attribute.
    /// </summary>
    public TerraformValue<bool> DisableApiStop
        => AsReference("disable_api_stop");

    /// <summary>
    /// The disable_api_termination attribute.
    /// </summary>
    public TerraformValue<bool> DisableApiTermination
        => AsReference("disable_api_termination");

    /// <summary>
    /// The ebs_block_device attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> EbsBlockDevice
        => AsReference("ebs_block_device");

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    public TerraformValue<bool> EbsOptimized
        => AsReference("ebs_optimized");

    /// <summary>
    /// The enclave_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EnclaveOptions
        => AsReference("enclave_options");

    /// <summary>
    /// The ephemeral_block_device attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EphemeralBlockDevice
        => AsReference("ephemeral_block_device");

    /// <summary>
    /// The host_id attribute.
    /// </summary>
    public TerraformValue<string> HostId
        => AsReference("host_id");

    /// <summary>
    /// The host_resource_group_arn attribute.
    /// </summary>
    public TerraformValue<string> HostResourceGroupArn
        => AsReference("host_resource_group_arn");

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    public TerraformValue<string> IamInstanceProfile
        => AsReference("iam_instance_profile");

    /// <summary>
    /// The instance_state attribute.
    /// </summary>
    public TerraformValue<string> InstanceState
        => AsReference("instance_state");

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string> InstanceType
        => AsReference("instance_type");

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    public TerraformSet<string> Ipv6Addresses
        => AsReference("ipv6_addresses");

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    public TerraformValue<string> KeyName
        => AsReference("key_name");

    /// <summary>
    /// The launch_time attribute.
    /// </summary>
    public TerraformValue<string> LaunchTime
        => AsReference("launch_time");

    /// <summary>
    /// The maintenance_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MaintenanceOptions
        => AsReference("maintenance_options");

    /// <summary>
    /// The metadata_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MetadataOptions
        => AsReference("metadata_options");

    /// <summary>
    /// The monitoring attribute.
    /// </summary>
    public TerraformValue<bool> Monitoring
        => AsReference("monitoring");

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformValue<string> NetworkInterfaceId
        => AsReference("network_interface_id");

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformValue<string> OutpostArn
        => AsReference("outpost_arn");

    /// <summary>
    /// The password_data attribute.
    /// </summary>
    public TerraformValue<string> PasswordData
        => AsReference("password_data");

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    public TerraformValue<string> PlacementGroup
        => AsReference("placement_group");

    /// <summary>
    /// The placement_group_id attribute.
    /// </summary>
    public TerraformValue<string> PlacementGroupId
        => AsReference("placement_group_id");

    /// <summary>
    /// The placement_partition_number attribute.
    /// </summary>
    public TerraformValue<double> PlacementPartitionNumber
        => AsReference("placement_partition_number");

    /// <summary>
    /// The private_dns attribute.
    /// </summary>
    public TerraformValue<string> PrivateDns
        => AsReference("private_dns");

    /// <summary>
    /// The private_dns_name_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PrivateDnsNameOptions
        => AsReference("private_dns_name_options");

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    public TerraformValue<string> PrivateIp
        => AsReference("private_ip");

    /// <summary>
    /// The public_dns attribute.
    /// </summary>
    public TerraformValue<string> PublicDns
        => AsReference("public_dns");

    /// <summary>
    /// The public_ip attribute.
    /// </summary>
    public TerraformValue<string> PublicIp
        => AsReference("public_ip");

    /// <summary>
    /// The root_block_device attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> RootBlockDevice
        => AsReference("root_block_device");

    /// <summary>
    /// The secondary_private_ips attribute.
    /// </summary>
    public TerraformSet<string> SecondaryPrivateIps
        => AsReference("secondary_private_ips");

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroups
        => AsReference("security_groups");

    /// <summary>
    /// The source_dest_check attribute.
    /// </summary>
    public TerraformValue<bool> SourceDestCheck
        => AsReference("source_dest_check");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string> SubnetId
        => AsReference("subnet_id");

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    public TerraformValue<string> Tenancy
        => AsReference("tenancy");

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    public TerraformValue<string> UserData
        => AsReference("user_data");

    /// <summary>
    /// The user_data_base64 attribute.
    /// </summary>
    public TerraformValue<string> UserDataBase64
        => AsReference("user_data_base64");

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> VpcSecurityGroupIds
        => AsReference("vpc_security_group_ids");

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
