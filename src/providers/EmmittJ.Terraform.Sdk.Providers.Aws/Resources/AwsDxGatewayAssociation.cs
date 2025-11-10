using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDxGatewayAssociationTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> AllowedPrefixes { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "allowed_prefixes");

    /// <summary>
    /// The associated_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("associated_gateway_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AssociatedGatewayId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "associated_gateway_id");

    /// <summary>
    /// The associated_gateway_owner_account_id attribute.
    /// </summary>
    [TerraformPropertyName("associated_gateway_owner_account_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AssociatedGatewayOwnerAccountId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "associated_gateway_owner_account_id");

    /// <summary>
    /// The dx_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DxGatewayId is required")]
    [TerraformPropertyName("dx_gateway_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DxGatewayId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The proposal_id attribute.
    /// </summary>
    [TerraformPropertyName("proposal_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ProposalId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsDxGatewayAssociationTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The associated_gateway_type attribute.
    /// </summary>
    [TerraformPropertyName("associated_gateway_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AssociatedGatewayType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "associated_gateway_type");

    /// <summary>
    /// The dx_gateway_association_id attribute.
    /// </summary>
    [TerraformPropertyName("dx_gateway_association_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DxGatewayAssociationId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dx_gateway_association_id");

    /// <summary>
    /// The dx_gateway_owner_account_id attribute.
    /// </summary>
    [TerraformPropertyName("dx_gateway_owner_account_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DxGatewayOwnerAccountId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dx_gateway_owner_account_id");

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_attachment_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TransitGatewayAttachmentId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "transit_gateway_attachment_id");

}
