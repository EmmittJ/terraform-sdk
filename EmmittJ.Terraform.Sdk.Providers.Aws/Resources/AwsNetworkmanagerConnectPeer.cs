using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public string? ConnectAttachmentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connect_attachment_id")?.Value;
        set => this.WithProperty("connect_attachment_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The core_network_address attribute.
    /// </summary>
    public string? CoreNetworkAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("core_network_address")?.Value;
        set => this.WithProperty("core_network_address", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The inside_cidr_blocks attribute.
    /// </summary>
    public List<string>? InsideCidrBlocks
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("inside_cidr_blocks")?.Value;
        set => this.WithProperty("inside_cidr_blocks", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The peer_address attribute.
    /// </summary>
    public string? PeerAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("peer_address")?.Value;
        set => this.WithProperty("peer_address", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subnet_arn attribute.
    /// </summary>
    public string? SubnetArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_arn")?.Value;
        set => this.WithProperty("subnet_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
