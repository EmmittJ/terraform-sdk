using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsEip.
/// Nesting mode: single
/// </summary>
public class AwsEipTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_eip Terraform resource.
/// Manages a aws_eip resource.
/// </summary>
public partial class AwsEip(string name) : TerraformResource("aws_eip", name)
{
    /// <summary>
    /// The address attribute.
    /// </summary>
    public TerraformValue<string>? Address
    {
        get => new TerraformReference<string>(this, "address");
        set => SetArgument("address", value);
    }

    /// <summary>
    /// The associate_with_private_ip attribute.
    /// </summary>
    public TerraformValue<string>? AssociateWithPrivateIp
    {
        get => new TerraformReference<string>(this, "associate_with_private_ip");
        set => SetArgument("associate_with_private_ip", value);
    }

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    public TerraformValue<string>? CustomerOwnedIpv4Pool
    {
        get => new TerraformReference<string>(this, "customer_owned_ipv4_pool");
        set => SetArgument("customer_owned_ipv4_pool", value);
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformValue<string> Domain
    {
        get => new TerraformReference<string>(this, "domain");
        set => SetArgument("domain", value);
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
    /// The instance attribute.
    /// </summary>
    public TerraformValue<string> Instance
    {
        get => new TerraformReference<string>(this, "instance");
        set => SetArgument("instance", value);
    }

    /// <summary>
    /// The ipam_pool_id attribute.
    /// </summary>
    public TerraformValue<string> IpamPoolId
    {
        get => new TerraformReference<string>(this, "ipam_pool_id");
        set => SetArgument("ipam_pool_id", value);
    }

    /// <summary>
    /// The network_border_group attribute.
    /// </summary>
    public TerraformValue<string> NetworkBorderGroup
    {
        get => new TerraformReference<string>(this, "network_border_group");
        set => SetArgument("network_border_group", value);
    }

    /// <summary>
    /// The network_interface attribute.
    /// </summary>
    public TerraformValue<string> NetworkInterface
    {
        get => new TerraformReference<string>(this, "network_interface");
        set => SetArgument("network_interface", value);
    }

    /// <summary>
    /// The public_ipv4_pool attribute.
    /// </summary>
    public TerraformValue<string> PublicIpv4Pool
    {
        get => new TerraformReference<string>(this, "public_ipv4_pool");
        set => SetArgument("public_ipv4_pool", value);
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
    /// The allocation_id attribute.
    /// </summary>
    public TerraformValue<string> AllocationId
    {
        get => new TerraformReference<string>(this, "allocation_id");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    public TerraformValue<string> AssociationId
    {
        get => new TerraformReference<string>(this, "association_id");
    }

    /// <summary>
    /// The carrier_ip attribute.
    /// </summary>
    public TerraformValue<string> CarrierIp
    {
        get => new TerraformReference<string>(this, "carrier_ip");
    }

    /// <summary>
    /// The customer_owned_ip attribute.
    /// </summary>
    public TerraformValue<string> CustomerOwnedIp
    {
        get => new TerraformReference<string>(this, "customer_owned_ip");
    }

    /// <summary>
    /// The private_dns attribute.
    /// </summary>
    public TerraformValue<string> PrivateDns
    {
        get => new TerraformReference<string>(this, "private_dns");
    }

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    public TerraformValue<string> PrivateIp
    {
        get => new TerraformReference<string>(this, "private_ip");
    }

    /// <summary>
    /// The ptr_record attribute.
    /// </summary>
    public TerraformValue<string> PtrRecord
    {
        get => new TerraformReference<string>(this, "ptr_record");
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
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEipTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEipTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
