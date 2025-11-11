using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_transit_gateway_peering_attachment_accepter resource.
/// </summary>
public class AwsEc2TransitGatewayPeeringAttachmentAccepter : TerraformResource
{
    public AwsEc2TransitGatewayPeeringAttachmentAccepter(string name) : base("aws_ec2_transit_gateway_peering_attachment_accepter", name)
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
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayAttachmentId is required")]
    [TerraformPropertyName("transit_gateway_attachment_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TransitGatewayAttachmentId { get; set; }

    /// <summary>
    /// The peer_account_id attribute.
    /// </summary>
    [TerraformPropertyName("peer_account_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PeerAccountId => new TerraformReference(this, "peer_account_id");

    /// <summary>
    /// The peer_region attribute.
    /// </summary>
    [TerraformPropertyName("peer_region")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PeerRegion => new TerraformReference(this, "peer_region");

    /// <summary>
    /// The peer_transit_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("peer_transit_gateway_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PeerTransitGatewayId => new TerraformReference(this, "peer_transit_gateway_id");

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TransitGatewayId => new TerraformReference(this, "transit_gateway_id");

}
