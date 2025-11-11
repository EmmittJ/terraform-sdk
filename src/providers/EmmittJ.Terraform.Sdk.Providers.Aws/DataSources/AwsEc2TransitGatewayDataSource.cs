using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsEc2TransitGatewayDataSourceFilterBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsEc2TransitGatewayDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ec2_transit_gateway.
/// </summary>
public partial class AwsEc2TransitGatewayDataSource : TerraformDataSource
{
    public AwsEc2TransitGatewayDataSource(string name) : base("aws_ec2_transit_gateway", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("filter")]
    public partial TerraformSet<TerraformBlock<AwsEc2TransitGatewayDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsEc2TransitGatewayDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The amazon_side_asn attribute.
    /// </summary>
    [TerraformProperty("amazon_side_asn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> AmazonSideAsn { get; }

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
    /// The auto_accept_shared_attachments attribute.
    /// </summary>
    [TerraformProperty("auto_accept_shared_attachments")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AutoAcceptSharedAttachments { get; }

    /// <summary>
    /// The default_route_table_association attribute.
    /// </summary>
    [TerraformProperty("default_route_table_association")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultRouteTableAssociation { get; }

    /// <summary>
    /// The default_route_table_propagation attribute.
    /// </summary>
    [TerraformProperty("default_route_table_propagation")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultRouteTablePropagation { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The dns_support attribute.
    /// </summary>
    [TerraformProperty("dns_support")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DnsSupport { get; }

    /// <summary>
    /// The multicast_support attribute.
    /// </summary>
    [TerraformProperty("multicast_support")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MulticastSupport { get; }

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

    /// <summary>
    /// The security_group_referencing_support attribute.
    /// </summary>
    [TerraformProperty("security_group_referencing_support")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecurityGroupReferencingSupport { get; }

    /// <summary>
    /// The transit_gateway_cidr_blocks attribute.
    /// </summary>
    [TerraformProperty("transit_gateway_cidr_blocks")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> TransitGatewayCidrBlocks { get; }

    /// <summary>
    /// The vpn_ecmp_support attribute.
    /// </summary>
    [TerraformProperty("vpn_ecmp_support")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VpnEcmpSupport { get; }

}
