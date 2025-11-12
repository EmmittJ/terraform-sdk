using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsEc2TransitGatewayConnectPeerTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_ec2_transit_gateway_connect_peer resource.
/// </summary>
public partial class AwsEc2TransitGatewayConnectPeer : TerraformResource
{
    public AwsEc2TransitGatewayConnectPeer(string name) : base("aws_ec2_transit_gateway_connect_peer", name)
    {
    }

    /// <summary>
    /// The bgp_asn attribute.
    /// </summary>
    [TerraformProperty("bgp_asn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> BgpAsn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The inside_cidr_blocks attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InsideCidrBlocks is required")]
    [TerraformProperty("inside_cidr_blocks")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> InsideCidrBlocks { get; set; }

    /// <summary>
    /// The peer_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerAddress is required")]
    [TerraformProperty("peer_address")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PeerAddress { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The transit_gateway_address attribute.
    /// </summary>
    [TerraformProperty("transit_gateway_address")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TransitGatewayAddress { get; set; }

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayAttachmentId is required")]
    [TerraformProperty("transit_gateway_attachment_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TransitGatewayAttachmentId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsEc2TransitGatewayConnectPeerTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The bgp_peer_address attribute.
    /// </summary>
    [TerraformProperty("bgp_peer_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BgpPeerAddress { get; }

    /// <summary>
    /// The bgp_transit_gateway_addresses attribute.
    /// </summary>
    [TerraformProperty("bgp_transit_gateway_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> BgpTransitGatewayAddresses { get; }

}
