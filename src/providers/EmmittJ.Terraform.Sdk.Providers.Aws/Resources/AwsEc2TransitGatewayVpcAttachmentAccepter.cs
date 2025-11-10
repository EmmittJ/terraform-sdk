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
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayAttachmentId is required")]
    [TerraformPropertyName("transit_gateway_attachment_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TransitGatewayAttachmentId { get; set; }

    /// <summary>
    /// The transit_gateway_default_route_table_association attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_default_route_table_association")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? TransitGatewayDefaultRouteTableAssociation { get; set; }

    /// <summary>
    /// The transit_gateway_default_route_table_propagation attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_default_route_table_propagation")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? TransitGatewayDefaultRouteTablePropagation { get; set; }

    /// <summary>
    /// The appliance_mode_support attribute.
    /// </summary>
    [TerraformPropertyName("appliance_mode_support")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ApplianceModeSupport => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "appliance_mode_support");

    /// <summary>
    /// The dns_support attribute.
    /// </summary>
    [TerraformPropertyName("dns_support")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DnsSupport => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dns_support");

    /// <summary>
    /// The ipv6_support attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_support")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Ipv6Support => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ipv6_support");

    /// <summary>
    /// The security_group_referencing_support attribute.
    /// </summary>
    [TerraformPropertyName("security_group_referencing_support")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecurityGroupReferencingSupport => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "security_group_referencing_support");

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> SubnetIds => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "subnet_ids");

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TransitGatewayId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "transit_gateway_id");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_id");

    /// <summary>
    /// The vpc_owner_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_owner_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcOwnerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_owner_id");

}
