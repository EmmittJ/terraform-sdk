using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_transit_gateway_policy_table_association resource.
/// </summary>
public class AwsEc2TransitGatewayPolicyTableAssociation : TerraformResource
{
    public AwsEc2TransitGatewayPolicyTableAssociation(string name) : base("aws_ec2_transit_gateway_policy_table_association", name)
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
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayAttachmentId is required")]
    [TerraformPropertyName("transit_gateway_attachment_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TransitGatewayAttachmentId { get; set; }

    /// <summary>
    /// The transit_gateway_policy_table_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayPolicyTableId is required")]
    [TerraformPropertyName("transit_gateway_policy_table_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TransitGatewayPolicyTableId { get; set; }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformPropertyName("resource_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ResourceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "resource_id");

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [TerraformPropertyName("resource_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ResourceType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "resource_type");

}
