using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsDxGatewayAssociationTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_dx_gateway_association resource.
/// </summary>
public partial class AwsDxGatewayAssociation : TerraformResource
{
    public AwsDxGatewayAssociation(string name) : base("aws_dx_gateway_association", name)
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
    [TerraformProperty("associated_gateway_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AssociatedGatewayId { get; set; }

    /// <summary>
    /// The associated_gateway_owner_account_id attribute.
    /// </summary>
    [TerraformProperty("associated_gateway_owner_account_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AssociatedGatewayOwnerAccountId { get; set; }

    /// <summary>
    /// The dx_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DxGatewayId is required")]
    [TerraformProperty("dx_gateway_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DxGatewayId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The proposal_id attribute.
    /// </summary>
    [TerraformProperty("proposal_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ProposalId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsDxGatewayAssociationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The associated_gateway_type attribute.
    /// </summary>
    [TerraformProperty("associated_gateway_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AssociatedGatewayType { get; }

    /// <summary>
    /// The dx_gateway_association_id attribute.
    /// </summary>
    [TerraformProperty("dx_gateway_association_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DxGatewayAssociationId { get; }

    /// <summary>
    /// The dx_gateway_owner_account_id attribute.
    /// </summary>
    [TerraformProperty("dx_gateway_owner_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DxGatewayOwnerAccountId { get; }

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    [TerraformProperty("transit_gateway_attachment_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TransitGatewayAttachmentId { get; }

}
