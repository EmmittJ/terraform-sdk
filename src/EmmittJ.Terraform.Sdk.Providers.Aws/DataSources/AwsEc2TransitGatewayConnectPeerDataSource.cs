using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ec2_transit_gateway_connect_peer.
/// </summary>
public class AwsEc2TransitGatewayConnectPeerDataSource : TerraformDataSource
{
    public AwsEc2TransitGatewayConnectPeerDataSource(string name) : base("aws_ec2_transit_gateway_connect_peer", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("bgp_asn");
        this.DeclareOutput("bgp_peer_address");
        this.DeclareOutput("bgp_transit_gateway_addresses");
        this.DeclareOutput("inside_cidr_blocks");
        this.DeclareOutput("peer_address");
        this.DeclareOutput("transit_gateway_address");
        this.DeclareOutput("transit_gateway_attachment_id");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The transit_gateway_connect_peer_id attribute.
    /// </summary>
    public TerraformProperty<string>? TransitGatewayConnectPeerId
    {
        get => GetProperty<TerraformProperty<string>>("transit_gateway_connect_peer_id");
        set => this.WithProperty("transit_gateway_connect_peer_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The bgp_asn attribute.
    /// </summary>
    public TerraformExpression BgpAsn => this["bgp_asn"];

    /// <summary>
    /// The bgp_peer_address attribute.
    /// </summary>
    public TerraformExpression BgpPeerAddress => this["bgp_peer_address"];

    /// <summary>
    /// The bgp_transit_gateway_addresses attribute.
    /// </summary>
    public TerraformExpression BgpTransitGatewayAddresses => this["bgp_transit_gateway_addresses"];

    /// <summary>
    /// The inside_cidr_blocks attribute.
    /// </summary>
    public TerraformExpression InsideCidrBlocks => this["inside_cidr_blocks"];

    /// <summary>
    /// The peer_address attribute.
    /// </summary>
    public TerraformExpression PeerAddress => this["peer_address"];

    /// <summary>
    /// The transit_gateway_address attribute.
    /// </summary>
    public TerraformExpression TransitGatewayAddress => this["transit_gateway_address"];

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    public TerraformExpression TransitGatewayAttachmentId => this["transit_gateway_attachment_id"];

}
