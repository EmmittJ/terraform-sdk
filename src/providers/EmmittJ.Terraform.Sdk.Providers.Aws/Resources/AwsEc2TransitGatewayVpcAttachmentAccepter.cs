using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_transit_gateway_vpc_attachment_accepter resource.
/// </summary>
public partial class AwsEc2TransitGatewayVpcAttachmentAccepter : TerraformResource
{
    public AwsEc2TransitGatewayVpcAttachmentAccepter(string name) : base("aws_ec2_transit_gateway_vpc_attachment_accepter", name)
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
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayAttachmentId is required")]
    [TerraformProperty("transit_gateway_attachment_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TransitGatewayAttachmentId { get; set; }

    /// <summary>
    /// The transit_gateway_default_route_table_association attribute.
    /// </summary>
    [TerraformProperty("transit_gateway_default_route_table_association")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? TransitGatewayDefaultRouteTableAssociation { get; set; }

    /// <summary>
    /// The transit_gateway_default_route_table_propagation attribute.
    /// </summary>
    [TerraformProperty("transit_gateway_default_route_table_propagation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? TransitGatewayDefaultRouteTablePropagation { get; set; }

    /// <summary>
    /// The appliance_mode_support attribute.
    /// </summary>
    [TerraformProperty("appliance_mode_support")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ApplianceModeSupport { get; }

    /// <summary>
    /// The dns_support attribute.
    /// </summary>
    [TerraformProperty("dns_support")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DnsSupport { get; }

    /// <summary>
    /// The ipv6_support attribute.
    /// </summary>
    [TerraformProperty("ipv6_support")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Ipv6Support { get; }

    /// <summary>
    /// The security_group_referencing_support attribute.
    /// </summary>
    [TerraformProperty("security_group_referencing_support")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecurityGroupReferencingSupport { get; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformProperty("subnet_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> SubnetIds { get; }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [TerraformProperty("transit_gateway_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TransitGatewayId { get; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VpcId { get; }

    /// <summary>
    /// The vpc_owner_id attribute.
    /// </summary>
    [TerraformProperty("vpc_owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VpcOwnerId { get; }

}
