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
        get => new TerraformReference<string>(this, "access_point_id");
        set => SetArgument("access_point_id", value);
    }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    public TerraformValue<string> FileSystemId
    {
        get => new TerraformReference<string>(this, "file_system_id");
        set => SetArgument("file_system_id", value);
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
    /// The mount_target_id attribute.
    /// </summary>
    public TerraformValue<string> MountTargetId
    {
        get => new TerraformReference<string>(this, "mount_target_id");
        set => SetArgument("mount_target_id", value);
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
    /// The availability_zone_id attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZoneId
    {
        get => new TerraformReference<string>(this, "availability_zone_id");
    }

    /// <summary>
    /// The availability_zone_name attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZoneName
    {
        get => new TerraformReference<string>(this, "availability_zone_name");
    }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformValue<string> DnsName
    {
        get => new TerraformReference<string>(this, "dns_name");
    }

    /// <summary>
    /// The file_system_arn attribute.
    /// </summary>
    public TerraformValue<string> FileSystemArn
    {
        get => new TerraformReference<string>(this, "file_system_arn");
    }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformValue<string> IpAddress
    {
        get => new TerraformReference<string>(this, "ip_address");
    }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformValue<string> IpAddressType
    {
        get => new TerraformReference<string>(this, "ip_address_type");
    }

    /// <summary>
    /// The ipv6_address attribute.
    /// </summary>
    public TerraformValue<string> Ipv6Address
    {
        get => new TerraformReference<string>(this, "ipv6_address");
    }

    /// <summary>
    /// The mount_target_dns_name attribute.
    /// </summary>
    public TerraformValue<string> MountTargetDnsName
    {
        get => new TerraformReference<string>(this, "mount_target_dns_name");
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformValue<string> NetworkInterfaceId
    {
        get => new TerraformReference<string>(this, "network_interface_id");
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
    {
        get => new TerraformReference<string>(this, "owner_id");
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroups
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_groups").ResolveNodes(ctx));
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
    }

}
