using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsEc2TransitGatewayConnectPeerDataSourceFilterBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsEc2TransitGatewayConnectPeerDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ec2_transit_gateway_connect_peer.
/// </summary>
public partial class AwsEc2TransitGatewayConnectPeerDataSource : TerraformDataSource
{
    public AwsEc2TransitGatewayConnectPeerDataSource(string name) : base("aws_ec2_transit_gateway_connect_peer", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The transit_gateway_connect_peer_id attribute.
    /// </summary>
    [TerraformProperty("transit_gateway_connect_peer_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> TransitGatewayConnectPeerId { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("filter")]
    public TerraformSet<TerraformBlock<AwsEc2TransitGatewayConnectPeerDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsEc2TransitGatewayConnectPeerDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The bgp_asn attribute.
    /// </summary>
    [TerraformProperty("bgp_asn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> BgpAsn { get; }

    /// <summary>
    /// The bgp_peer_address attribute.
    /// </summary>
    [TerraformProperty("bgp_peer_address")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> BgpPeerAddress { get; }

    /// <summary>
    /// The bgp_transit_gateway_addresses attribute.
    /// </summary>
    [TerraformProperty("bgp_transit_gateway_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> BgpTransitGatewayAddresses { get; }

    /// <summary>
    /// The inside_cidr_blocks attribute.
    /// </summary>
    [TerraformProperty("inside_cidr_blocks")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> InsideCidrBlocks { get; }

    /// <summary>
    /// The peer_address attribute.
    /// </summary>
    [TerraformProperty("peer_address")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PeerAddress { get; }

    /// <summary>
    /// The transit_gateway_address attribute.
    /// </summary>
    [TerraformProperty("transit_gateway_address")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TransitGatewayAddress { get; }

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    [TerraformProperty("transit_gateway_attachment_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TransitGatewayAttachmentId { get; }

}
