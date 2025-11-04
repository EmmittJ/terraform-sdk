using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_transit_gateway_connect_peer resource.
/// </summary>
public class AwsEc2TransitGatewayConnectPeer : TerraformResource
{
    public AwsEc2TransitGatewayConnectPeer(string name) : base("aws_ec2_transit_gateway_connect_peer", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("bgp_peer_address");
        this.DeclareOutput("bgp_transit_gateway_addresses");
    }

    /// <summary>
    /// The bgp_asn attribute.
    /// </summary>
    public string? BgpAsn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bgp_asn")?.Value;
        set => this.WithProperty("bgp_asn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    public HashSet<string>? InsideCidrBlocks
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("inside_cidr_blocks")?.Value;
        set => this.WithProperty("inside_cidr_blocks", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The transit_gateway_address attribute.
    /// </summary>
    public string? TransitGatewayAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transit_gateway_address")?.Value;
        set => this.WithProperty("transit_gateway_address", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    public string? TransitGatewayAttachmentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transit_gateway_attachment_id")?.Value;
        set => this.WithProperty("transit_gateway_attachment_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The bgp_peer_address attribute.
    /// </summary>
    public TerraformExpression BgpPeerAddress => this["bgp_peer_address"];

    /// <summary>
    /// The bgp_transit_gateway_addresses attribute.
    /// </summary>
    public TerraformExpression BgpTransitGatewayAddresses => this["bgp_transit_gateway_addresses"];

}
