using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_efs_mount_target Terraform data source.
/// Retrieves information about a aws_efs_mount_target.
/// </summary>
public partial class AwsEfsMountTargetDataSource(string name) : TerraformDataSource("aws_efs_mount_target", name)
{
    /// <summary>
    /// The access_point_id attribute.
    /// </summary>
    public TerraformValue<string>? AccessPointId
    {
        get => GetArgument<TerraformValue<string>>("access_point_id");
        set => SetArgument("access_point_id", value);
    }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    public TerraformValue<string>? FileSystemId
    {
        get => GetArgument<TerraformValue<string>>("file_system_id");
        set => SetArgument("file_system_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The mount_target_id attribute.
    /// </summary>
    public TerraformValue<string>? MountTargetId
    {
        get => GetArgument<TerraformValue<string>>("mount_target_id");
        set => SetArgument("mount_target_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZoneId
        => AsReference("availability_zone_id");

    /// <summary>
    /// The availability_zone_name attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZoneName
        => AsReference("availability_zone_name");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformValue<string> DnsName
        => AsReference("dns_name");

    /// <summary>
    /// The file_system_arn attribute.
    /// </summary>
    public TerraformValue<string> FileSystemArn
        => AsReference("file_system_arn");

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformValue<string> IpAddress
        => AsReference("ip_address");

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformValue<string> IpAddressType
        => AsReference("ip_address_type");

    /// <summary>
    /// The ipv6_address attribute.
    /// </summary>
    public TerraformValue<string> Ipv6Address
        => AsReference("ipv6_address");

    /// <summary>
    /// The mount_target_dns_name attribute.
    /// </summary>
    public TerraformValue<string> MountTargetDnsName
        => AsReference("mount_target_dns_name");

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformValue<string> NetworkInterfaceId
        => AsReference("network_interface_id");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
        => AsReference("owner_id");

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroups
        => AsReference("security_groups");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string> SubnetId
        => AsReference("subnet_id");

}
