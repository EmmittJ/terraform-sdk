using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_transit_gateway_vpc_attachment resource.
/// </summary>
public class AwsEc2TransitGatewayVpcAttachment : TerraformResource
{
    public AwsEc2TransitGatewayVpcAttachment(string name) : base("aws_ec2_transit_gateway_vpc_attachment", name)
    {
    }

    /// <summary>
    /// The appliance_mode_support attribute.
    /// </summary>
    [TerraformPropertyName("appliance_mode_support")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ApplianceModeSupport { get; set; }

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
    /// The ipv6_support attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_support")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Ipv6Support { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SecurityGroupReferencingSupport { get; set; } = default!;

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformPropertyName("subnet_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> SubnetIds { get; set; }

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
    /// The transit_gateway_default_route_table_association attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_default_route_table_association")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> TransitGatewayDefaultRouteTableAssociation { get; set; } = default!;

    /// <summary>
    /// The transit_gateway_default_route_table_propagation attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_default_route_table_propagation")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> TransitGatewayDefaultRouteTablePropagation { get; set; } = default!;

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayId is required")]
    [TerraformPropertyName("transit_gateway_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TransitGatewayId { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    [TerraformPropertyName("vpc_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> VpcId { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The vpc_owner_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_owner_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VpcOwnerId => new TerraformReference(this, "vpc_owner_id");

}
