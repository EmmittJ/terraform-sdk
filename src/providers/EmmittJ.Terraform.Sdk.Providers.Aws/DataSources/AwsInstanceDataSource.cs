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
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "values").ResolveNodes(ctx));
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
        get => new TerraformReference<string>(this, "read");
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
        get => new TerraformReference<bool>(this, "get_password_data");
        set => SetArgument("get_password_data", value);
    }

    /// <summary>
    /// The get_user_data attribute.
    /// </summary>
    public TerraformValue<bool>? GetUserData
    {
        get => new TerraformReference<bool>(this, "get_user_data");
        set => SetArgument("get_user_data", value);
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
    /// The instance_id attribute.
    /// </summary>
    public TerraformValue<string>? InstanceId
    {
        get => new TerraformReference<string>(this, "instance_id");
        set => SetArgument("instance_id", value);
    }

    /// <summary>
    /// The instance_tags attribute.
    /// </summary>
    public TerraformMap<string> InstanceTags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "instance_tags").ResolveNodes(ctx));
        set => SetArgument("instance_tags", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The ami attribute.
    /// </summary>
    public TerraformValue<string> Ami
    {
        get => new TerraformReference<string>(this, "ami");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    public TerraformValue<bool> AssociatePublicIpAddress
    {
        get => new TerraformReference<bool>(this, "associate_public_ip_address");
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
    {
        get => new TerraformReference<string>(this, "availability_zone");
    }

    /// <summary>
    /// The credit_specification attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CreditSpecification
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "credit_specification").ResolveNodes(ctx));
    }

    /// <summary>
    /// The disable_api_stop attribute.
    /// </summary>
    public TerraformValue<bool> DisableApiStop
    {
        get => new TerraformReference<bool>(this, "disable_api_stop");
    }

    /// <summary>
    /// The disable_api_termination attribute.
    /// </summary>
    public TerraformValue<bool> DisableApiTermination
    {
        get => new TerraformReference<bool>(this, "disable_api_termination");
    }

    /// <summary>
    /// The ebs_block_device attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> EbsBlockDevice
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "ebs_block_device").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    public TerraformValue<bool> EbsOptimized
    {
        get => new TerraformReference<bool>(this, "ebs_optimized");
    }

    /// <summary>
    /// The enclave_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EnclaveOptions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "enclave_options").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ephemeral_block_device attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EphemeralBlockDevice
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "ephemeral_block_device").ResolveNodes(ctx));
    }

    /// <summary>
    /// The host_id attribute.
    /// </summary>
    public TerraformValue<string> HostId
    {
        get => new TerraformReference<string>(this, "host_id");
    }

    /// <summary>
    /// The host_resource_group_arn attribute.
    /// </summary>
    public TerraformValue<string> HostResourceGroupArn
    {
        get => new TerraformReference<string>(this, "host_resource_group_arn");
    }

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    public TerraformValue<string> IamInstanceProfile
    {
        get => new TerraformReference<string>(this, "iam_instance_profile");
    }

    /// <summary>
    /// The instance_state attribute.
    /// </summary>
    public TerraformValue<string> InstanceState
    {
        get => new TerraformReference<string>(this, "instance_state");
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string> InstanceType
    {
        get => new TerraformReference<string>(this, "instance_type");
    }

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    public TerraformSet<string> Ipv6Addresses
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "ipv6_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    public TerraformValue<string> KeyName
    {
        get => new TerraformReference<string>(this, "key_name");
    }

    /// <summary>
    /// The launch_time attribute.
    /// </summary>
    public TerraformValue<string> LaunchTime
    {
        get => new TerraformReference<string>(this, "launch_time");
    }

    /// <summary>
    /// The maintenance_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MaintenanceOptions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "maintenance_options").ResolveNodes(ctx));
    }

    /// <summary>
    /// The metadata_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MetadataOptions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "metadata_options").ResolveNodes(ctx));
    }

    /// <summary>
    /// The monitoring attribute.
    /// </summary>
    public TerraformValue<bool> Monitoring
    {
        get => new TerraformReference<bool>(this, "monitoring");
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformValue<string> NetworkInterfaceId
    {
        get => new TerraformReference<string>(this, "network_interface_id");
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
    /// The placement_group attribute.
    /// </summary>
    public TerraformValue<string> PlacementGroup
    {
        get => new TerraformReference<string>(this, "placement_group");
    }

    /// <summary>
    /// The placement_group_id attribute.
    /// </summary>
    public TerraformValue<string> PlacementGroupId
    {
        get => new TerraformReference<string>(this, "placement_group_id");
    }

    /// <summary>
    /// The placement_partition_number attribute.
    /// </summary>
    public TerraformValue<double> PlacementPartitionNumber
    {
        get => new TerraformReference<double>(this, "placement_partition_number");
    }

    /// <summary>
    /// The private_dns attribute.
    /// </summary>
    public TerraformValue<string> PrivateDns
    {
        get => new TerraformReference<string>(this, "private_dns");
    }

    /// <summary>
    /// The private_dns_name_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PrivateDnsNameOptions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "private_dns_name_options").ResolveNodes(ctx));
    }

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    public TerraformValue<string> PrivateIp
    {
        get => new TerraformReference<string>(this, "private_ip");
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
    /// The root_block_device attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> RootBlockDevice
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "root_block_device").ResolveNodes(ctx));
    }

    /// <summary>
    /// The secondary_private_ips attribute.
    /// </summary>
    public TerraformSet<string> SecondaryPrivateIps
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "secondary_private_ips").ResolveNodes(ctx));
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroups
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_groups").ResolveNodes(ctx));
    }

    /// <summary>
    /// The source_dest_check attribute.
    /// </summary>
    public TerraformValue<bool> SourceDestCheck
    {
        get => new TerraformReference<bool>(this, "source_dest_check");
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
    }

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    public TerraformValue<string> Tenancy
    {
        get => new TerraformReference<string>(this, "tenancy");
    }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    public TerraformValue<string> UserData
    {
        get => new TerraformReference<string>(this, "user_data");
    }

    /// <summary>
    /// The user_data_base64 attribute.
    /// </summary>
    public TerraformValue<string> UserDataBase64
    {
        get => new TerraformReference<string>(this, "user_data_base64");
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> VpcSecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "vpc_security_group_ids").ResolveNodes(ctx));
    }

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
