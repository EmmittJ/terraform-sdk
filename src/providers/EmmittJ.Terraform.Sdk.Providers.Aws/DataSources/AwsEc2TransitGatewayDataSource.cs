using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsEc2TransitGatewayDataSourceFilterBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEc2TransitGatewayDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsEc2TransitGatewayDataSourceFilterBlock>>? Filter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsEc2TransitGatewayDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The amazon_side_asn attribute.
    /// </summary>
    [TerraformPropertyName("amazon_side_asn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> AmazonSideAsn => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "amazon_side_asn");

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
    /// The auto_accept_shared_attachments attribute.
    /// </summary>
    [TerraformPropertyName("auto_accept_shared_attachments")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AutoAcceptSharedAttachments => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "auto_accept_shared_attachments");

    /// <summary>
    /// The default_route_table_association attribute.
    /// </summary>
    [TerraformPropertyName("default_route_table_association")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultRouteTableAssociation => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_route_table_association");

    /// <summary>
    /// The default_route_table_propagation attribute.
    /// </summary>
    [TerraformPropertyName("default_route_table_propagation")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultRouteTablePropagation => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_route_table_propagation");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The dns_support attribute.
    /// </summary>
    [TerraformPropertyName("dns_support")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DnsSupport => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dns_support");

    /// <summary>
    /// The multicast_support attribute.
    /// </summary>
    [TerraformPropertyName("multicast_support")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MulticastSupport => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "multicast_support");

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

    /// <summary>
    /// The security_group_referencing_support attribute.
    /// </summary>
    [TerraformPropertyName("security_group_referencing_support")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecurityGroupReferencingSupport => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "security_group_referencing_support");

    /// <summary>
    /// The transit_gateway_cidr_blocks attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_cidr_blocks")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> TransitGatewayCidrBlocks => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "transit_gateway_cidr_blocks");

    /// <summary>
    /// The vpn_ecmp_support attribute.
    /// </summary>
    [TerraformPropertyName("vpn_ecmp_support")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpnEcmpSupport => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpn_ecmp_support");

}
