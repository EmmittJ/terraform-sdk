using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEc2TransitGatewayTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_ec2_transit_gateway resource.
/// </summary>
public class AwsEc2TransitGateway : TerraformResource
{
    public AwsEc2TransitGateway(string name) : base("aws_ec2_transit_gateway", name)
    {
    }

    /// <summary>
    /// The amazon_side_asn attribute.
    /// </summary>
    [TerraformPropertyName("amazon_side_asn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? AmazonSideAsn { get; set; }

    /// <summary>
    /// The auto_accept_shared_attachments attribute.
    /// </summary>
    [TerraformPropertyName("auto_accept_shared_attachments")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AutoAcceptSharedAttachments { get; set; }

    /// <summary>
    /// The default_route_table_association attribute.
    /// </summary>
    [TerraformPropertyName("default_route_table_association")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DefaultRouteTableAssociation { get; set; }

    /// <summary>
    /// The default_route_table_propagation attribute.
    /// </summary>
    [TerraformPropertyName("default_route_table_propagation")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DefaultRouteTablePropagation { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The dns_support attribute.
    /// </summary>
    [TerraformPropertyName("dns_support")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DnsSupport { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The multicast_support attribute.
    /// </summary>
    [TerraformPropertyName("multicast_support")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MulticastSupport { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The security_group_referencing_support attribute.
    /// </summary>
    [TerraformPropertyName("security_group_referencing_support")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SecurityGroupReferencingSupport { get; set; }

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
    /// The transit_gateway_cidr_blocks attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_cidr_blocks")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? TransitGatewayCidrBlocks { get; set; }

    /// <summary>
    /// The vpn_ecmp_support attribute.
    /// </summary>
    [TerraformPropertyName("vpn_ecmp_support")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VpnEcmpSupport { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsEc2TransitGatewayTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The association_default_route_table_id attribute.
    /// </summary>
    [TerraformPropertyName("association_default_route_table_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AssociationDefaultRouteTableId => new TerraformReference(this, "association_default_route_table_id");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OwnerId => new TerraformReference(this, "owner_id");

    /// <summary>
    /// The propagation_default_route_table_id attribute.
    /// </summary>
    [TerraformPropertyName("propagation_default_route_table_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PropagationDefaultRouteTableId => new TerraformReference(this, "propagation_default_route_table_id");

}
