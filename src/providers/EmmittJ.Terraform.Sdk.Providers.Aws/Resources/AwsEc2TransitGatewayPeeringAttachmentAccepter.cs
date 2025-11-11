using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_transit_gateway_peering_attachment_accepter resource.
/// </summary>
public partial class AwsEc2TransitGatewayPeeringAttachmentAccepter : TerraformResource
{
    public AwsEc2TransitGatewayPeeringAttachmentAccepter(string name) : base("aws_ec2_transit_gateway_peering_attachment_accepter", name)
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
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayAttachmentId is required")]
    [TerraformProperty("transit_gateway_attachment_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TransitGatewayAttachmentId { get; set; }

    /// <summary>
    /// The peer_account_id attribute.
    /// </summary>
    [TerraformProperty("peer_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PeerAccountId { get; }

    /// <summary>
    /// The peer_region attribute.
    /// </summary>
    [TerraformProperty("peer_region")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PeerRegion { get; }

    /// <summary>
    /// The peer_transit_gateway_id attribute.
    /// </summary>
    [TerraformProperty("peer_transit_gateway_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PeerTransitGatewayId { get; }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [TerraformProperty("transit_gateway_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TransitGatewayId { get; }

}
