using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for bgp_options in AwsNetworkmanagerConnectPeer.
/// Nesting mode: list
/// </summary>
public class AwsNetworkmanagerConnectPeerBgpOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bgp_options";

    /// <summary>
    /// The peer_asn attribute.
    /// </summary>
    public TerraformValue<double>? PeerAsn
    {
        get => new TerraformReference<double>(this, "peer_asn");
        set => SetArgument("peer_asn", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsNetworkmanagerConnectPeer.
/// Nesting mode: single
/// </summary>
public class AwsNetworkmanagerConnectPeerTimeoutsBlock : TerraformBlock
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
/// Represents a aws_networkmanager_connect_peer Terraform resource.
/// Manages a aws_networkmanager_connect_peer resource.
/// </summary>
public partial class AwsNetworkmanagerConnectPeer(string name) : TerraformResource("aws_networkmanager_connect_peer", name)
{
    /// <summary>
    /// The connect_attachment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectAttachmentId is required")]
    public required TerraformValue<string> ConnectAttachmentId
    {
        get => new TerraformReference<string>(this, "connect_attachment_id");
        set => SetArgument("connect_attachment_id", value);
    }

    /// <summary>
    /// The core_network_address attribute.
    /// </summary>
    public TerraformValue<string>? CoreNetworkAddress
    {
        get => new TerraformReference<string>(this, "core_network_address");
        set => SetArgument("core_network_address", value);
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
    public TerraformList<string>? InsideCidrBlocks
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "inside_cidr_blocks").ResolveNodes(ctx));
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
    /// The subnet_arn attribute.
    /// </summary>
    public TerraformValue<string>? SubnetArn
    {
        get => new TerraformReference<string>(this, "subnet_arn");
        set => SetArgument("subnet_arn", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Configuration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The connect_peer_id attribute.
    /// </summary>
    public TerraformValue<string> ConnectPeerId
    {
        get => new TerraformReference<string>(this, "connect_peer_id");
    }

    /// <summary>
    /// The core_network_id attribute.
    /// </summary>
    public TerraformValue<string> CoreNetworkId
    {
        get => new TerraformReference<string>(this, "core_network_id");
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
    }

    /// <summary>
    /// The edge_location attribute.
    /// </summary>
    public TerraformValue<string> EdgeLocation
    {
        get => new TerraformReference<string>(this, "edge_location");
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// BgpOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BgpOptions block(s) allowed")]
    public TerraformList<AwsNetworkmanagerConnectPeerBgpOptionsBlock>? BgpOptions
    {
        get => GetArgument<TerraformList<AwsNetworkmanagerConnectPeerBgpOptionsBlock>>("bgp_options");
        set => SetArgument("bgp_options", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsNetworkmanagerConnectPeerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsNetworkmanagerConnectPeerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
