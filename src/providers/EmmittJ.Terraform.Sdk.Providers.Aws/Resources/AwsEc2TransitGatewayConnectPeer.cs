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
/// Represents a aws_ec2_transit_gateway_connect_peer Terraform resource.
/// Manages a aws_ec2_transit_gateway_connect_peer resource.
/// </summary>
public partial class AwsEc2TransitGatewayConnectPeer(string name) : TerraformResource("aws_ec2_transit_gateway_connect_peer", name)
{
    /// <summary>
    /// The bgp_asn attribute.
    /// </summary>
    public TerraformValue<string>? BgpAsn
    {
        get => GetArgument<TerraformValue<string>>("bgp_asn");
        set => SetArgument("bgp_asn", value);
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
    /// The inside_cidr_blocks attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InsideCidrBlocks is required")]
    public required TerraformSet<string> InsideCidrBlocks
    {
        get => GetArgument<TerraformSet<string>>("inside_cidr_blocks");
        set => SetArgument("inside_cidr_blocks", value);
    }

    /// <summary>
    /// The peer_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerAddress is required")]
    public required TerraformValue<string> PeerAddress
    {
        get => GetArgument<TerraformValue<string>>("peer_address");
        set => SetArgument("peer_address", value);
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
    /// The transit_gateway_address attribute.
    /// </summary>
    public TerraformValue<string>? TransitGatewayAddress
    {
        get => GetArgument<TerraformValue<string>>("transit_gateway_address");
        set => SetArgument("transit_gateway_address", value);
    }

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayAttachmentId is required")]
    public required TerraformValue<string> TransitGatewayAttachmentId
    {
        get => GetArgument<TerraformValue<string>>("transit_gateway_attachment_id");
        set => SetArgument("transit_gateway_attachment_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The bgp_peer_address attribute.
    /// </summary>
    public TerraformValue<string> BgpPeerAddress
        => AsReference("bgp_peer_address");

    /// <summary>
    /// The bgp_transit_gateway_addresses attribute.
    /// </summary>
    public TerraformSet<string> BgpTransitGatewayAddresses
        => AsReference("bgp_transit_gateway_addresses");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEc2TransitGatewayConnectPeerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEc2TransitGatewayConnectPeerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
