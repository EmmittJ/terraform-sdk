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
        set => SetProperty("peer_asn", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_networkmanager_connect_peer resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsNetworkmanagerConnectPeer : TerraformResource
{
    public AwsNetworkmanagerConnectPeer(string name) : base("aws_networkmanager_connect_peer", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("configuration");
        SetOutput("connect_peer_id");
        SetOutput("core_network_id");
        SetOutput("created_at");
        SetOutput("edge_location");
        SetOutput("state");
        SetOutput("connect_attachment_id");
        SetOutput("core_network_address");
        SetOutput("id");
        SetOutput("inside_cidr_blocks");
        SetOutput("peer_address");
        SetOutput("subnet_arn");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The connect_attachment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectAttachmentId is required")]
    public required TerraformProperty<string> ConnectAttachmentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("connect_attachment_id");
        set => SetProperty("connect_attachment_id", value);
    }

    /// <summary>
    /// The core_network_address attribute.
    /// </summary>
    public TerraformProperty<string> CoreNetworkAddress
    {
        get => GetRequiredOutput<TerraformProperty<string>>("core_network_address");
        set => SetProperty("core_network_address", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The inside_cidr_blocks attribute.
    /// </summary>
    public List<TerraformProperty<string>> InsideCidrBlocks
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("inside_cidr_blocks");
        set => SetProperty("inside_cidr_blocks", value);
    }

    /// <summary>
    /// The peer_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerAddress is required")]
    public required TerraformProperty<string> PeerAddress
    {
        get => GetRequiredOutput<TerraformProperty<string>>("peer_address");
        set => SetProperty("peer_address", value);
    }

    /// <summary>
    /// The subnet_arn attribute.
    /// </summary>
    public TerraformProperty<string> SubnetArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subnet_arn");
        set => SetProperty("subnet_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for bgp_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BgpOptions block(s) allowed")]
    public List<AwsNetworkmanagerConnectPeerBgpOptionsBlock>? BgpOptions
    {
        set => SetProperty("bgp_options", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsNetworkmanagerConnectPeerTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
