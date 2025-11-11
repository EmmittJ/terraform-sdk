using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_local_gateway_route resource.
/// </summary>
public partial class AwsEc2LocalGatewayRoute : TerraformResource
{
    public AwsEc2LocalGatewayRoute(string name) : base("aws_ec2_local_gateway_route", name)
    {
    }

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
    /// The local_gateway_route_table_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalGatewayRouteTableId is required")]
    [TerraformProperty("local_gateway_route_table_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LocalGatewayRouteTableId { get; set; }

    /// <summary>
    /// The local_gateway_virtual_interface_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalGatewayVirtualInterfaceGroupId is required")]
    [TerraformProperty("local_gateway_virtual_interface_group_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LocalGatewayVirtualInterfaceGroupId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

}
