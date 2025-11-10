using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for bgp_options in .
/// Nesting mode: list
/// </summary>
public class AwsNetworkmanagerConnectPeerBgpOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The peer_asn attribute.
    /// </summary>
    public TerraformProperty<double>? PeerAsn
    {
        get => GetProperty<TerraformProperty<double>>("peer_asn");
        set => WithProperty("peer_asn", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsNetworkmanagerConnectPeerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_networkmanager_connect_peer resource.
/// </summary>
public class AwsNetworkmanagerConnectPeer : TerraformResource
{
    public AwsNetworkmanagerConnectPeer(string name) : base("aws_networkmanager_connect_peer", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("configuration");
        this.DeclareOutput("connect_peer_id");
        this.DeclareOutput("core_network_id");
        this.DeclareOutput("created_at");
        this.DeclareOutput("edge_location");
        this.DeclareOutput("state");
    }

    /// <summary>
    /// The connect_attachment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectAttachmentId is required")]
    public required TerraformProperty<string> ConnectAttachmentId
    {
        get => GetProperty<TerraformProperty<string>>("connect_attachment_id");
        set => this.WithProperty("connect_attachment_id", value);
    }

    /// <summary>
    /// The core_network_address attribute.
    /// </summary>
    public TerraformProperty<string>? CoreNetworkAddress
    {
        get => GetProperty<TerraformProperty<string>>("core_network_address");
        set => this.WithProperty("core_network_address", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The inside_cidr_blocks attribute.
    /// </summary>
    public List<TerraformProperty<string>>? InsideCidrBlocks
    {
        get => GetProperty<List<TerraformProperty<string>>>("inside_cidr_blocks");
        set => this.WithProperty("inside_cidr_blocks", value);
    }

    /// <summary>
    /// The peer_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerAddress is required")]
    public required TerraformProperty<string> PeerAddress
    {
        get => GetProperty<TerraformProperty<string>>("peer_address");
        set => this.WithProperty("peer_address", value);
    }

    /// <summary>
    /// The subnet_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetArn
    {
        get => GetProperty<TerraformProperty<string>>("subnet_arn");
        set => this.WithProperty("subnet_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for bgp_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BgpOptions block(s) allowed")]
    public List<AwsNetworkmanagerConnectPeerBgpOptionsBlock>? BgpOptions
    {
        get => GetProperty<List<AwsNetworkmanagerConnectPeerBgpOptionsBlock>>("bgp_options");
        set => this.WithProperty("bgp_options", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsNetworkmanagerConnectPeerTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsNetworkmanagerConnectPeerTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    public TerraformExpression Configuration => this["configuration"];

    /// <summary>
    /// The connect_peer_id attribute.
    /// </summary>
    public TerraformExpression ConnectPeerId => this["connect_peer_id"];

    /// <summary>
    /// The core_network_id attribute.
    /// </summary>
    public TerraformExpression CoreNetworkId => this["core_network_id"];

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The edge_location attribute.
    /// </summary>
    public TerraformExpression EdgeLocation => this["edge_location"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

}
