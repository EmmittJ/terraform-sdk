using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsEc2TransitGatewayConnectPeer.
/// Nesting mode: single
/// </summary>
public class AwsEc2TransitGatewayConnectPeerTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_ec2_transit_gateway_connect_peer Terraform resource.
/// Manages a aws_ec2_transit_gateway_connect_peer resource.
/// </summary>
public partial class AwsEc2TransitGatewayConnectPeer(string name) : TerraformResource("aws_ec2_transit_gateway_connect_peer", name)
{
    /// <summary>
    /// The bgp_asn attribute.
    /// </summary>
    public TerraformValue<string> BgpAsn
    {
        get => new TerraformReference<string>(this, "bgp_asn");
        set => SetArgument("bgp_asn", value);
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
    /// The inside_cidr_blocks attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InsideCidrBlocks is required")]
    public required TerraformSet<string> InsideCidrBlocks
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "inside_cidr_blocks").ResolveNodes(ctx));
        set => SetArgument("inside_cidr_blocks", value);
    }

    /// <summary>
    /// The peer_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerAddress is required")]
    public required TerraformValue<string> PeerAddress
    {
        get => new TerraformReference<string>(this, "peer_address");
        set => SetArgument("peer_address", value);
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
    /// The transit_gateway_address attribute.
    /// </summary>
    public TerraformValue<string> TransitGatewayAddress
    {
        get => new TerraformReference<string>(this, "transit_gateway_address");
        set => SetArgument("transit_gateway_address", value);
    }

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayAttachmentId is required")]
    public required TerraformValue<string> TransitGatewayAttachmentId
    {
        get => new TerraformReference<string>(this, "transit_gateway_attachment_id");
        set => SetArgument("transit_gateway_attachment_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The bgp_peer_address attribute.
    /// </summary>
    public TerraformValue<string> BgpPeerAddress
    {
        get => new TerraformReference<string>(this, "bgp_peer_address");
    }

    /// <summary>
    /// The bgp_transit_gateway_addresses attribute.
    /// </summary>
    public TerraformSet<string> BgpTransitGatewayAddresses
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "bgp_transit_gateway_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEc2TransitGatewayConnectPeerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEc2TransitGatewayConnectPeerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
