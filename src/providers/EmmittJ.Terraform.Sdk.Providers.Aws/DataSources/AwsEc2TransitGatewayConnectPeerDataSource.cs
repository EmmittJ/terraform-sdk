using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsEc2TransitGatewayConnectPeerDataSourceFilterBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEc2TransitGatewayConnectPeerDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ec2_transit_gateway_connect_peer.
/// </summary>
public class AwsEc2TransitGatewayConnectPeerDataSource : TerraformDataSource
{
    public AwsEc2TransitGatewayConnectPeerDataSource(string name) : base("aws_ec2_transit_gateway_connect_peer", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The transit_gateway_connect_peer_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_connect_peer_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TransitGatewayConnectPeerId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "transit_gateway_connect_peer_id");

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsEc2TransitGatewayConnectPeerDataSourceFilterBlock>>? Filter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsEc2TransitGatewayConnectPeerDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The bgp_asn attribute.
    /// </summary>
    [TerraformPropertyName("bgp_asn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BgpAsn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bgp_asn");

    /// <summary>
    /// The bgp_peer_address attribute.
    /// </summary>
    [TerraformPropertyName("bgp_peer_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BgpPeerAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bgp_peer_address");

    /// <summary>
    /// The bgp_transit_gateway_addresses attribute.
    /// </summary>
    [TerraformPropertyName("bgp_transit_gateway_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> BgpTransitGatewayAddresses => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "bgp_transit_gateway_addresses");

    /// <summary>
    /// The inside_cidr_blocks attribute.
    /// </summary>
    [TerraformPropertyName("inside_cidr_blocks")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> InsideCidrBlocks => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "inside_cidr_blocks");

    /// <summary>
    /// The peer_address attribute.
    /// </summary>
    [TerraformPropertyName("peer_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PeerAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "peer_address");

    /// <summary>
    /// The transit_gateway_address attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TransitGatewayAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "transit_gateway_address");

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_attachment_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TransitGatewayAttachmentId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "transit_gateway_attachment_id");

}
