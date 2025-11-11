using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_transit_gateway_route resource.
/// </summary>
public partial class AwsEc2TransitGatewayRoute : TerraformResource
{
    public AwsEc2TransitGatewayRoute(string name) : base("aws_ec2_transit_gateway_route", name)
    {
    }

    /// <summary>
    /// The blackhole attribute.
    /// </summary>
    [TerraformProperty("blackhole")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Blackhole { get; set; }

    /// <summary>
    /// The destination_cidr_block attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationCidrBlock is required")]
    [TerraformProperty("destination_cidr_block")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DestinationCidrBlock { get; set; }

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
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    [TerraformProperty("transit_gateway_attachment_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TransitGatewayAttachmentId { get; set; }

    /// <summary>
    /// The transit_gateway_route_table_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayRouteTableId is required")]
    [TerraformProperty("transit_gateway_route_table_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TransitGatewayRouteTableId { get; set; }

}
