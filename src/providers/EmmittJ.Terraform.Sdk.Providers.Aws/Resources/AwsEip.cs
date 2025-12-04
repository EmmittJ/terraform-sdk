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
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
        get => GetArgument<TerraformValue<string>>("address");
        set => SetArgument("address", value);
    }

    /// <summary>
    /// The associate_with_private_ip attribute.
    /// </summary>
    public TerraformValue<string>? AssociateWithPrivateIp
    {
        get => GetArgument<TerraformValue<string>>("associate_with_private_ip");
        set => SetArgument("associate_with_private_ip", value);
    }

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    public TerraformValue<string>? CustomerOwnedIpv4Pool
    {
        get => GetArgument<TerraformValue<string>>("customer_owned_ipv4_pool");
        set => SetArgument("customer_owned_ipv4_pool", value);
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformValue<string> Domain
    {
        get => GetArgument<TerraformValue<string>>("domain") ?? AsReference("domain");
        set => SetArgument("domain", value);
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
    /// The instance attribute.
    /// </summary>
    public TerraformValue<string> Instance
    {
        get => GetArgument<TerraformValue<string>>("instance") ?? AsReference("instance");
        set => SetArgument("instance", value);
    }

    /// <summary>
    /// The ipam_pool_id attribute.
    /// </summary>
    public TerraformValue<string> IpamPoolId
    {
        get => GetArgument<TerraformValue<string>>("ipam_pool_id") ?? AsReference("ipam_pool_id");
        set => SetArgument("ipam_pool_id", value);
    }

    /// <summary>
    /// The network_border_group attribute.
    /// </summary>
    public TerraformValue<string> NetworkBorderGroup
    {
        get => GetArgument<TerraformValue<string>>("network_border_group") ?? AsReference("network_border_group");
        set => SetArgument("network_border_group", value);
    }

    /// <summary>
    /// The network_interface attribute.
    /// </summary>
    public TerraformValue<string> NetworkInterface
    {
        get => GetArgument<TerraformValue<string>>("network_interface") ?? AsReference("network_interface");
        set => SetArgument("network_interface", value);
    }

    /// <summary>
    /// The public_ipv4_pool attribute.
    /// </summary>
    public TerraformValue<string> PublicIpv4Pool
    {
        get => GetArgument<TerraformValue<string>>("public_ipv4_pool") ?? AsReference("public_ipv4_pool");
        set => SetArgument("public_ipv4_pool", value);
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
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The allocation_id attribute.
    /// </summary>
    public TerraformValue<string> AllocationId
        => AsReference("allocation_id");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    public TerraformValue<string> AssociationId
        => AsReference("association_id");

    /// <summary>
    /// The carrier_ip attribute.
    /// </summary>
    public TerraformValue<string> CarrierIp
        => AsReference("carrier_ip");

    /// <summary>
    /// The customer_owned_ip attribute.
    /// </summary>
    public TerraformValue<string> CustomerOwnedIp
        => AsReference("customer_owned_ip");

    /// <summary>
    /// The private_dns attribute.
    /// </summary>
    public TerraformValue<string> PrivateDns
        => AsReference("private_dns");

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    public TerraformValue<string> PrivateIp
        => AsReference("private_ip");

    /// <summary>
    /// The ptr_record attribute.
    /// </summary>
    public TerraformValue<string> PtrRecord
        => AsReference("ptr_record");

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
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEipTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEipTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
