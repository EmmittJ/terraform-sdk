using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for options in .
/// Nesting mode: list
/// </summary>
public partial class AwsEc2TransitGatewayPeeringAttachmentOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The dynamic_routing attribute.
    /// </summary>
    [TerraformProperty("dynamic_routing")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DynamicRouting { get; set; }

}

/// <summary>
/// Manages a aws_ec2_transit_gateway_peering_attachment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsEc2TransitGatewayPeeringAttachment : TerraformResource
{
    public AwsEc2TransitGatewayPeeringAttachment(string name) : base("aws_ec2_transit_gateway_peering_attachment", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The peer_account_id attribute.
    /// </summary>
    [TerraformProperty("peer_account_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> PeerAccountId { get; set; }

    /// <summary>
    /// The peer_region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerRegion is required")]
    [TerraformProperty("peer_region")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PeerRegion { get; set; }

    /// <summary>
    /// The peer_transit_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerTransitGatewayId is required")]
    [TerraformProperty("peer_transit_gateway_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PeerTransitGatewayId { get; set; }

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
    /// The transit_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayId is required")]
    [TerraformProperty("transit_gateway_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TransitGatewayId { get; set; }

    /// <summary>
    /// Block for options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Options block(s) allowed")]
    [TerraformProperty("options")]
    public TerraformList<TerraformBlock<AwsEc2TransitGatewayPeeringAttachmentOptionsBlock>>? Options { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

}
