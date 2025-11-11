using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_transit_gateway_route_table resource.
/// </summary>
public partial class AwsEc2TransitGatewayRouteTable : TerraformResource
{
    public AwsEc2TransitGatewayRouteTable(string name) : base("aws_ec2_transit_gateway_route_table", name)
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
    /// The transit_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayId is required")]
    [TerraformProperty("transit_gateway_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TransitGatewayId { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The default_association_route_table attribute.
    /// </summary>
    [TerraformProperty("default_association_route_table")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> DefaultAssociationRouteTable { get; }

    /// <summary>
    /// The default_propagation_route_table attribute.
    /// </summary>
    [TerraformProperty("default_propagation_route_table")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> DefaultPropagationRouteTable { get; }

}
