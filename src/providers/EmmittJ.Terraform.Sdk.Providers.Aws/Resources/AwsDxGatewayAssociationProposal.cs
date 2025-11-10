using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dx_gateway_association_proposal resource.
/// </summary>
public class AwsDxGatewayAssociationProposal : TerraformResource
{
    public AwsDxGatewayAssociationProposal(string name) : base("aws_dx_gateway_association_proposal", name)
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssociatedGatewayId is required")]
    [TerraformPropertyName("associated_gateway_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AssociatedGatewayId { get; set; }

    /// <summary>
    /// The dx_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DxGatewayId is required")]
    [TerraformPropertyName("dx_gateway_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DxGatewayId { get; set; }

    /// <summary>
    /// The dx_gateway_owner_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DxGatewayOwnerAccountId is required")]
    [TerraformPropertyName("dx_gateway_owner_account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DxGatewayOwnerAccountId { get; set; }

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
    /// The associated_gateway_owner_account_id attribute.
    /// </summary>
    [TerraformPropertyName("associated_gateway_owner_account_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AssociatedGatewayOwnerAccountId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "associated_gateway_owner_account_id");

    /// <summary>
    /// The associated_gateway_type attribute.
    /// </summary>
    [TerraformPropertyName("associated_gateway_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AssociatedGatewayType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "associated_gateway_type");

}
