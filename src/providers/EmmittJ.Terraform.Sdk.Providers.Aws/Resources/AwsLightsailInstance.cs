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
        get => new TerraformReference<string>(this, "snapshot_time");
        set => SetArgument("snapshot_time", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    public required TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
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
        get => new TerraformReference<string>(this, "availability_zone");
        set => SetArgument("availability_zone", value);
    }

    /// <summary>
    /// The blueprint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BlueprintId is required")]
    public required TerraformValue<string> BlueprintId
    {
        get => new TerraformReference<string>(this, "blueprint_id");
        set => SetArgument("blueprint_id", value);
    }

    /// <summary>
    /// The bundle_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BundleId is required")]
    public required TerraformValue<string> BundleId
    {
        get => new TerraformReference<string>(this, "bundle_id");
        set => SetArgument("bundle_id", value);
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
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformValue<string>? IpAddressType
    {
        get => new TerraformReference<string>(this, "ip_address_type");
        set => SetArgument("ip_address_type", value);
    }

    /// <summary>
    /// The key_pair_name attribute.
    /// </summary>
    public TerraformValue<string>? KeyPairName
    {
        get => new TerraformReference<string>(this, "key_pair_name");
        set => SetArgument("key_pair_name", value);
    }

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
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    public TerraformValue<string>? UserData
    {
        get => new TerraformReference<string>(this, "user_data");
        set => SetArgument("user_data", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The cpu_count attribute.
    /// </summary>
    public TerraformValue<double> CpuCount
    {
        get => new TerraformReference<double>(this, "cpu_count");
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
    }

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    public TerraformList<string> Ipv6Addresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ipv6_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The is_static_ip attribute.
    /// </summary>
    public TerraformValue<bool> IsStaticIp
    {
        get => new TerraformReference<bool>(this, "is_static_ip");
    }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    public TerraformValue<string> PrivateIpAddress
    {
        get => new TerraformReference<string>(this, "private_ip_address");
    }

    /// <summary>
    /// The public_ip_address attribute.
    /// </summary>
    public TerraformValue<string> PublicIpAddress
    {
        get => new TerraformReference<string>(this, "public_ip_address");
    }

    /// <summary>
    /// The ram_size attribute.
    /// </summary>
    public TerraformValue<double> RamSize
    {
        get => new TerraformReference<double>(this, "ram_size");
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformValue<string> Username
    {
        get => new TerraformReference<string>(this, "username");
    }

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
