using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_transit_gateway_vpc_attachment resource.
/// </summary>
public partial class AwsEc2TransitGatewayVpcAttachment : TerraformResource
{
    public AwsEc2TransitGatewayVpcAttachment(string name) : base("aws_ec2_transit_gateway_vpc_attachment", name)
    {
    }

    /// <summary>
    /// The appliance_mode_support attribute.
    /// </summary>
    [TerraformProperty("appliance_mode_support")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ApplianceModeSupport { get; set; }

    /// <summary>
    /// The dns_support attribute.
    /// </summary>
    [TerraformProperty("dns_support")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DnsSupport { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ipv6_support attribute.
    /// </summary>
    [TerraformProperty("ipv6_support")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Ipv6Support { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The security_group_referencing_support attribute.
    /// </summary>
    [TerraformProperty("security_group_referencing_support")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> SecurityGroupReferencingSupport { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformProperty("subnet_ids")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> SubnetIds { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The transit_gateway_default_route_table_association attribute.
    /// </summary>
    [TerraformProperty("transit_gateway_default_route_table_association")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> TransitGatewayDefaultRouteTableAssociation { get; set; }

    /// <summary>
    /// The transit_gateway_default_route_table_propagation attribute.
    /// </summary>
    [TerraformProperty("transit_gateway_default_route_table_propagation")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> TransitGatewayDefaultRouteTablePropagation { get; set; }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayId is required")]
    [TerraformProperty("transit_gateway_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TransitGatewayId { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    [TerraformProperty("vpc_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VpcId { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The vpc_owner_id attribute.
    /// </summary>
    [TerraformProperty("vpc_owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VpcOwnerId { get; }

}
