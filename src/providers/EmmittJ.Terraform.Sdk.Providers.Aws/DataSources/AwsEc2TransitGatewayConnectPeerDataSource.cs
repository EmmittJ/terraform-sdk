using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsEc2TransitGatewayConnectPeerDataSourceFilterBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEc2TransitGatewayConnectPeerDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The transit_gateway_connect_peer_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_connect_peer_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> TransitGatewayConnectPeerId { get; set; } = default!;

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsEc2TransitGatewayConnectPeerDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsEc2TransitGatewayConnectPeerDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The bgp_asn attribute.
    /// </summary>
    [TerraformPropertyName("bgp_asn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BgpAsn => new TerraformReference(this, "bgp_asn");

    /// <summary>
    /// The bgp_peer_address attribute.
    /// </summary>
    [TerraformPropertyName("bgp_peer_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BgpPeerAddress => new TerraformReference(this, "bgp_peer_address");

    /// <summary>
    /// The bgp_transit_gateway_addresses attribute.
    /// </summary>
    [TerraformPropertyName("bgp_transit_gateway_addresses")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> BgpTransitGatewayAddresses => new TerraformReference(this, "bgp_transit_gateway_addresses");

    /// <summary>
    /// The inside_cidr_blocks attribute.
    /// </summary>
    [TerraformPropertyName("inside_cidr_blocks")]
    // Output-only attribute - read-only reference
    public TerraformList<string> InsideCidrBlocks => new TerraformReference(this, "inside_cidr_blocks");

    /// <summary>
    /// The peer_address attribute.
    /// </summary>
    [TerraformPropertyName("peer_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PeerAddress => new TerraformReference(this, "peer_address");

    /// <summary>
    /// The transit_gateway_address attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TransitGatewayAddress => new TerraformReference(this, "transit_gateway_address");

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_attachment_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TransitGatewayAttachmentId => new TerraformReference(this, "transit_gateway_attachment_id");

}
