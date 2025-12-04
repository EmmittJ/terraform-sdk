using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsEfsMountTarget.
/// Nesting mode: single
/// </summary>
public class AwsEfsMountTargetTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_efs_mount_target Terraform resource.
/// Manages a aws_efs_mount_target resource.
/// </summary>
public partial class AwsEfsMountTarget(string name) : TerraformResource("aws_efs_mount_target", name)
{
    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileSystemId is required")]
    public required TerraformValue<string> FileSystemId
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
    /// The ip_address attribute.
    /// </summary>
    public TerraformValue<string>? IpAddress
    {
        get => GetArgument<TerraformValue<string>>("ip_address");
        set => SetArgument("ip_address", value);
    }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformValue<string>? IpAddressType
    {
        get => GetArgument<TerraformValue<string>>("ip_address_type");
        set => SetArgument("ip_address_type", value);
    }

    /// <summary>
    /// The ipv6_address attribute.
    /// </summary>
    public TerraformValue<string>? Ipv6Address
    {
        get => GetArgument<TerraformValue<string>>("ipv6_address");
        set => SetArgument("ipv6_address", value);
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
    /// The security_groups attribute.
    /// </summary>
    public TerraformSet<string>? SecurityGroups
    {
        get => GetArgument<TerraformSet<string>>("security_groups");
        set => SetArgument("security_groups", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => GetArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
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
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEfsMountTargetTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEfsMountTargetTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
