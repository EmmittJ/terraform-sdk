using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_transit_gateway_vpc_attachment_accepter resource.
/// </summary>
public class AwsEc2TransitGatewayVpcAttachmentAccepter : TerraformResource
{
    public AwsEc2TransitGatewayVpcAttachmentAccepter(string name) : base("aws_ec2_transit_gateway_vpc_attachment_accepter", name)
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
    /// The transit_gateway_default_route_table_association attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_default_route_table_association")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? TransitGatewayDefaultRouteTableAssociation { get; set; }

    /// <summary>
    /// The transit_gateway_default_route_table_propagation attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_default_route_table_propagation")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? TransitGatewayDefaultRouteTablePropagation { get; set; }

    /// <summary>
    /// The appliance_mode_support attribute.
    /// </summary>
    [TerraformPropertyName("appliance_mode_support")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ApplianceModeSupport => new TerraformReference(this, "appliance_mode_support");

    /// <summary>
    /// The dns_support attribute.
    /// </summary>
    [TerraformPropertyName("dns_support")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DnsSupport => new TerraformReference(this, "dns_support");

    /// <summary>
    /// The ipv6_support attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_support")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Ipv6Support => new TerraformReference(this, "ipv6_support");

    /// <summary>
    /// The security_group_referencing_support attribute.
    /// </summary>
    [TerraformPropertyName("security_group_referencing_support")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecurityGroupReferencingSupport => new TerraformReference(this, "security_group_referencing_support");

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> SubnetIds => new TerraformReference(this, "subnet_ids");

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TransitGatewayId => new TerraformReference(this, "transit_gateway_id");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VpcId => new TerraformReference(this, "vpc_id");

    /// <summary>
    /// The vpc_owner_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_owner_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VpcOwnerId => new TerraformReference(this, "vpc_owner_id");

}
