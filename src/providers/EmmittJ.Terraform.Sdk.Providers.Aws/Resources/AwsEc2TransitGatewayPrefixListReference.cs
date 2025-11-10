using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_transit_gateway_prefix_list_reference resource.
/// </summary>
public class AwsEc2TransitGatewayPrefixListReference : TerraformResource
{
    public AwsEc2TransitGatewayPrefixListReference(string name) : base("aws_ec2_transit_gateway_prefix_list_reference", name)
    {
    }

    /// <summary>
    /// The blackhole attribute.
    /// </summary>
    [TerraformPropertyName("blackhole")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Blackhole { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The prefix_list_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrefixListId is required")]
    [TerraformPropertyName("prefix_list_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PrefixListId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_attachment_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TransitGatewayAttachmentId { get; set; }

    /// <summary>
    /// The transit_gateway_route_table_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayRouteTableId is required")]
    [TerraformPropertyName("transit_gateway_route_table_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TransitGatewayRouteTableId { get; set; }

    /// <summary>
    /// The prefix_list_owner_id attribute.
    /// </summary>
    [TerraformPropertyName("prefix_list_owner_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrefixListOwnerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "prefix_list_owner_id");

}
