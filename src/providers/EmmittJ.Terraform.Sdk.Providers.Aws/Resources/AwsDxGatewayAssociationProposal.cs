using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dx_gateway_association_proposal resource.
/// </summary>
public partial class AwsDxGatewayAssociationProposal : TerraformResource
{
    public AwsDxGatewayAssociationProposal(string name) : base("aws_dx_gateway_association_proposal", name)
    {
    }

    /// <summary>
    /// The allowed_prefixes attribute.
    /// </summary>
    [TerraformProperty("allowed_prefixes")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<string> AllowedPrefixes { get; set; }

    /// <summary>
    /// The associated_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssociatedGatewayId is required")]
    [TerraformProperty("associated_gateway_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AssociatedGatewayId { get; set; }

    /// <summary>
    /// The dx_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DxGatewayId is required")]
    [TerraformProperty("dx_gateway_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DxGatewayId { get; set; }

    /// <summary>
    /// The dx_gateway_owner_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DxGatewayOwnerAccountId is required")]
    [TerraformProperty("dx_gateway_owner_account_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DxGatewayOwnerAccountId { get; set; }

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
    /// The associated_gateway_owner_account_id attribute.
    /// </summary>
    [TerraformProperty("associated_gateway_owner_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AssociatedGatewayOwnerAccountId { get; }

    /// <summary>
    /// The associated_gateway_type attribute.
    /// </summary>
    [TerraformProperty("associated_gateway_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AssociatedGatewayType { get; }

}
