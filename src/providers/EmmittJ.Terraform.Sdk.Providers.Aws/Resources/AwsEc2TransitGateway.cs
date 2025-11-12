using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsEc2TransitGatewayTimeoutsBlock() : TerraformBlock("timeouts")
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_ec2_transit_gateway resource.
/// </summary>
public partial class AwsEc2TransitGateway : TerraformResource
{
    public AwsEc2TransitGateway(string name) : base("aws_ec2_transit_gateway", name)
    {
    }

    /// <summary>
    /// The amazon_side_asn attribute.
    /// </summary>
    [TerraformProperty("amazon_side_asn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AmazonSideAsn { get; set; }

    /// <summary>
    /// The auto_accept_shared_attachments attribute.
    /// </summary>
    [TerraformProperty("auto_accept_shared_attachments")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AutoAcceptSharedAttachments { get; set; }

    /// <summary>
    /// The default_route_table_association attribute.
    /// </summary>
    [TerraformProperty("default_route_table_association")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultRouteTableAssociation { get; set; }

    /// <summary>
    /// The default_route_table_propagation attribute.
    /// </summary>
    [TerraformProperty("default_route_table_propagation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultRouteTablePropagation { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The dns_support attribute.
    /// </summary>
    [TerraformProperty("dns_support")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DnsSupport { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The multicast_support attribute.
    /// </summary>
    [TerraformProperty("multicast_support")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MulticastSupport { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The security_group_referencing_support attribute.
    /// </summary>
    [TerraformProperty("security_group_referencing_support")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SecurityGroupReferencingSupport { get; set; }

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
    /// The transit_gateway_cidr_blocks attribute.
    /// </summary>
    [TerraformProperty("transit_gateway_cidr_blocks")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? TransitGatewayCidrBlocks { get; set; }

    /// <summary>
    /// The vpn_ecmp_support attribute.
    /// </summary>
    [TerraformProperty("vpn_ecmp_support")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VpnEcmpSupport { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsEc2TransitGatewayTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The association_default_route_table_id attribute.
    /// </summary>
    [TerraformProperty("association_default_route_table_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AssociationDefaultRouteTableId { get; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OwnerId { get; }

    /// <summary>
    /// The propagation_default_route_table_id attribute.
    /// </summary>
    [TerraformProperty("propagation_default_route_table_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PropagationDefaultRouteTableId { get; }

}
