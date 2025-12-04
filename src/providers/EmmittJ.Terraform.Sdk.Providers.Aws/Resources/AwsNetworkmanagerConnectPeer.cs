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
        get => GetArgument<TerraformValue<double>>("peer_asn");
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
        get => GetArgument<TerraformValue<string>>("connect_attachment_id");
        set => SetArgument("connect_attachment_id", value);
    }

    /// <summary>
    /// The core_network_address attribute.
    /// </summary>
    public TerraformValue<string>? CoreNetworkAddress
    {
        get => GetArgument<TerraformValue<string>>("core_network_address");
        set => SetArgument("core_network_address", value);
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
    public TerraformList<string>? InsideCidrBlocks
    {
        get => GetArgument<TerraformList<string>>("inside_cidr_blocks");
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
    /// The subnet_arn attribute.
    /// </summary>
    public TerraformValue<string>? SubnetArn
    {
        get => GetArgument<TerraformValue<string>>("subnet_arn");
        set => SetArgument("subnet_arn", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Configuration
        => AsReference("configuration");

    /// <summary>
    /// The connect_peer_id attribute.
    /// </summary>
    public TerraformValue<string> ConnectPeerId
        => AsReference("connect_peer_id");

    /// <summary>
    /// The core_network_id attribute.
    /// </summary>
    public TerraformValue<string> CoreNetworkId
        => AsReference("core_network_id");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => AsReference("created_at");

    /// <summary>
    /// The edge_location attribute.
    /// </summary>
    public TerraformValue<string> EdgeLocation
        => AsReference("edge_location");

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

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
