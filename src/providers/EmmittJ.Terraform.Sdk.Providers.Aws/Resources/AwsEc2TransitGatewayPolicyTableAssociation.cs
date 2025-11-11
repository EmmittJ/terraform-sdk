using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_transit_gateway_policy_table_association resource.
/// </summary>
public partial class AwsEc2TransitGatewayPolicyTableAssociation : TerraformResource
{
    public AwsEc2TransitGatewayPolicyTableAssociation(string name) : base("aws_ec2_transit_gateway_policy_table_association", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayAttachmentId is required")]
    [TerraformProperty("transit_gateway_attachment_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TransitGatewayAttachmentId { get; set; }

    /// <summary>
    /// The transit_gateway_policy_table_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayPolicyTableId is required")]
    [TerraformProperty("transit_gateway_policy_table_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TransitGatewayPolicyTableId { get; set; }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformProperty("resource_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ResourceId { get; }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [TerraformProperty("resource_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ResourceType { get; }

}
