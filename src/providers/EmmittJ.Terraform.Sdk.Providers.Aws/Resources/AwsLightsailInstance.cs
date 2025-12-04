using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for add_on in AwsLightsailInstance.
/// Nesting mode: list
/// </summary>
public class AwsLightsailInstanceAddOnBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "add_on";

    /// <summary>
    /// The snapshot_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotTime is required")]
    public required TerraformValue<string> SnapshotTime
    {
        get => GetArgument<TerraformValue<string>>("snapshot_time");
        set => SetArgument("snapshot_time", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    public required TerraformValue<string> Status
    {
        get => GetArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Represents a aws_lightsail_instance Terraform resource.
/// Manages a aws_lightsail_instance resource.
/// </summary>
public partial class AwsLightsailInstance(string name) : TerraformResource("aws_lightsail_instance", name)
{
    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AvailabilityZone is required")]
    public required TerraformValue<string> AvailabilityZone
    {
        get => GetArgument<TerraformValue<string>>("availability_zone");
        set => SetArgument("availability_zone", value);
    }

    /// <summary>
    /// The blueprint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BlueprintId is required")]
    public required TerraformValue<string> BlueprintId
    {
        get => GetArgument<TerraformValue<string>>("blueprint_id");
        set => SetArgument("blueprint_id", value);
    }

    /// <summary>
    /// The bundle_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BundleId is required")]
    public required TerraformValue<string> BundleId
    {
        get => GetArgument<TerraformValue<string>>("bundle_id");
        set => SetArgument("bundle_id", value);
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
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformValue<string>? IpAddressType
    {
        get => GetArgument<TerraformValue<string>>("ip_address_type");
        set => SetArgument("ip_address_type", value);
    }

    /// <summary>
    /// The key_pair_name attribute.
    /// </summary>
    public TerraformValue<string>? KeyPairName
    {
        get => GetArgument<TerraformValue<string>>("key_pair_name");
        set => SetArgument("key_pair_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    public TerraformValue<string>? UserData
    {
        get => GetArgument<TerraformValue<string>>("user_data");
        set => SetArgument("user_data", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The cpu_count attribute.
    /// </summary>
    public TerraformValue<double> CpuCount
        => AsReference("cpu_count");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => AsReference("created_at");

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    public TerraformList<string> Ipv6Addresses
        => AsReference("ipv6_addresses");

    /// <summary>
    /// The is_static_ip attribute.
    /// </summary>
    public TerraformValue<bool> IsStaticIp
        => AsReference("is_static_ip");

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    public TerraformValue<string> PrivateIpAddress
        => AsReference("private_ip_address");

    /// <summary>
    /// The public_ip_address attribute.
    /// </summary>
    public TerraformValue<string> PublicIpAddress
        => AsReference("public_ip_address");

    /// <summary>
    /// The ram_size attribute.
    /// </summary>
    public TerraformValue<double> RamSize
        => AsReference("ram_size");

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformValue<string> Username
        => AsReference("username");

    /// <summary>
    /// AddOn block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AddOn block(s) allowed")]
    public TerraformList<AwsLightsailInstanceAddOnBlock>? AddOn
    {
        get => GetArgument<TerraformList<AwsLightsailInstanceAddOnBlock>>("add_on");
        set => SetArgument("add_on", value);
    }

}
