using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEc2TransitGatewayTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    public TerraformProperty<TerraformProperty<double>>? AmazonSideAsn { get; set; }

    /// <summary>
    /// The auto_accept_shared_attachments attribute.
    /// </summary>
    [TerraformPropertyName("auto_accept_shared_attachments")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AutoAcceptSharedAttachments { get; set; }

    /// <summary>
    /// The default_route_table_association attribute.
    /// </summary>
    [TerraformPropertyName("default_route_table_association")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DefaultRouteTableAssociation { get; set; }

    /// <summary>
    /// The default_route_table_propagation attribute.
    /// </summary>
    [TerraformPropertyName("default_route_table_propagation")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DefaultRouteTablePropagation { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The dns_support attribute.
    /// </summary>
    [TerraformPropertyName("dns_support")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DnsSupport { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The multicast_support attribute.
    /// </summary>
    [TerraformPropertyName("multicast_support")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MulticastSupport { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The security_group_referencing_support attribute.
    /// </summary>
    [TerraformPropertyName("security_group_referencing_support")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SecurityGroupReferencingSupport { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The transit_gateway_cidr_blocks attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_cidr_blocks")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? TransitGatewayCidrBlocks { get; set; }

    /// <summary>
    /// The vpn_ecmp_support attribute.
    /// </summary>
    [TerraformPropertyName("vpn_ecmp_support")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VpnEcmpSupport { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsEc2TransitGatewayTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The association_default_route_table_id attribute.
    /// </summary>
    [TerraformPropertyName("association_default_route_table_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AssociationDefaultRouteTableId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "association_default_route_table_id");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OwnerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner_id");

    /// <summary>
    /// The propagation_default_route_table_id attribute.
    /// </summary>
    [TerraformPropertyName("propagation_default_route_table_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PropagationDefaultRouteTableId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "propagation_default_route_table_id");

}
