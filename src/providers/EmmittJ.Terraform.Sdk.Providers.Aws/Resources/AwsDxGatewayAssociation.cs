using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDxGatewayAssociationTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_dx_gateway_association resource.
/// </summary>
public class AwsDxGatewayAssociation : TerraformResource
{
    public AwsDxGatewayAssociation(string name) : base("aws_dx_gateway_association", name)
    {
    }

    /// <summary>
    /// The allowed_prefixes attribute.
    /// </summary>
    [TerraformPropertyName("allowed_prefixes")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> AllowedPrefixes { get; set; } = default!;

    /// <summary>
    /// The associated_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("associated_gateway_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AssociatedGatewayId { get; set; } = default!;

    /// <summary>
    /// The associated_gateway_owner_account_id attribute.
    /// </summary>
    [TerraformPropertyName("associated_gateway_owner_account_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AssociatedGatewayOwnerAccountId { get; set; } = default!;

    /// <summary>
    /// The dx_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DxGatewayId is required")]
    [TerraformPropertyName("dx_gateway_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DxGatewayId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The proposal_id attribute.
    /// </summary>
    [TerraformPropertyName("proposal_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ProposalId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsDxGatewayAssociationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The associated_gateway_type attribute.
    /// </summary>
    [TerraformPropertyName("associated_gateway_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AssociatedGatewayType => new TerraformReference(this, "associated_gateway_type");

    /// <summary>
    /// The dx_gateway_association_id attribute.
    /// </summary>
    [TerraformPropertyName("dx_gateway_association_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DxGatewayAssociationId => new TerraformReference(this, "dx_gateway_association_id");

    /// <summary>
    /// The dx_gateway_owner_account_id attribute.
    /// </summary>
    [TerraformPropertyName("dx_gateway_owner_account_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DxGatewayOwnerAccountId => new TerraformReference(this, "dx_gateway_owner_account_id");

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_attachment_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TransitGatewayAttachmentId => new TerraformReference(this, "transit_gateway_attachment_id");

}
