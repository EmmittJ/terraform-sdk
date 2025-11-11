using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsEc2TransitGatewayDataSourceFilterBlock
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
public class AwsEc2TransitGatewayDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ec2_transit_gateway.
/// </summary>
public class AwsEc2TransitGatewayDataSource : TerraformDataSource
{
    public AwsEc2TransitGatewayDataSource(string name) : base("aws_ec2_transit_gateway", name)
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
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsEc2TransitGatewayDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsEc2TransitGatewayDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The amazon_side_asn attribute.
    /// </summary>
    [TerraformPropertyName("amazon_side_asn")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AmazonSideAsn => new TerraformReference(this, "amazon_side_asn");

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
    /// The auto_accept_shared_attachments attribute.
    /// </summary>
    [TerraformPropertyName("auto_accept_shared_attachments")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AutoAcceptSharedAttachments => new TerraformReference(this, "auto_accept_shared_attachments");

    /// <summary>
    /// The default_route_table_association attribute.
    /// </summary>
    [TerraformPropertyName("default_route_table_association")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultRouteTableAssociation => new TerraformReference(this, "default_route_table_association");

    /// <summary>
    /// The default_route_table_propagation attribute.
    /// </summary>
    [TerraformPropertyName("default_route_table_propagation")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultRouteTablePropagation => new TerraformReference(this, "default_route_table_propagation");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The dns_support attribute.
    /// </summary>
    [TerraformPropertyName("dns_support")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DnsSupport => new TerraformReference(this, "dns_support");

    /// <summary>
    /// The multicast_support attribute.
    /// </summary>
    [TerraformPropertyName("multicast_support")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MulticastSupport => new TerraformReference(this, "multicast_support");

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

    /// <summary>
    /// The security_group_referencing_support attribute.
    /// </summary>
    [TerraformPropertyName("security_group_referencing_support")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecurityGroupReferencingSupport => new TerraformReference(this, "security_group_referencing_support");

    /// <summary>
    /// The transit_gateway_cidr_blocks attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_cidr_blocks")]
    // Output-only attribute - read-only reference
    public TerraformList<string> TransitGatewayCidrBlocks => new TerraformReference(this, "transit_gateway_cidr_blocks");

    /// <summary>
    /// The vpn_ecmp_support attribute.
    /// </summary>
    [TerraformPropertyName("vpn_ecmp_support")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VpnEcmpSupport => new TerraformReference(this, "vpn_ecmp_support");

}
