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
    public TerraformLiteralProperty<string>? ConnectAttachmentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connect_attachment_id");
        set => this.WithProperty("connect_attachment_id", value);
    }

    /// <summary>
    /// The core_network_address attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CoreNetworkAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("core_network_address");
        set => this.WithProperty("core_network_address", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The inside_cidr_blocks attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? InsideCidrBlocks
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("inside_cidr_blocks");
        set => this.WithProperty("inside_cidr_blocks", value);
    }

    /// <summary>
    /// The peer_address attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PeerAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("peer_address");
        set => this.WithProperty("peer_address", value);
    }

    /// <summary>
    /// The subnet_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SubnetArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_arn");
        set => this.WithProperty("subnet_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
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
