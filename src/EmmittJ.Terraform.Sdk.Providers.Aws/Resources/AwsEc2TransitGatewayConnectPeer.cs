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
    public TerraformProperty<string>? BgpAsn
    {
        get => GetProperty<TerraformProperty<string>>("bgp_asn");
        set => this.WithProperty("bgp_asn", value);
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
    public TerraformProperty<HashSet<string>>? InsideCidrBlocks
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("inside_cidr_blocks");
        set => this.WithProperty("inside_cidr_blocks", value);
    }

    /// <summary>
    /// The peer_address attribute.
    /// </summary>
    public TerraformProperty<string>? PeerAddress
    {
        get => GetProperty<TerraformProperty<string>>("peer_address");
        set => this.WithProperty("peer_address", value);
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
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The transit_gateway_address attribute.
    /// </summary>
    public TerraformProperty<string>? TransitGatewayAddress
    {
        get => GetProperty<TerraformProperty<string>>("transit_gateway_address");
        set => this.WithProperty("transit_gateway_address", value);
    }

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    public TerraformProperty<string>? TransitGatewayAttachmentId
    {
        get => GetProperty<TerraformProperty<string>>("transit_gateway_attachment_id");
        set => this.WithProperty("transit_gateway_attachment_id", value);
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
