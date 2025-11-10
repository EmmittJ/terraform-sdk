using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_dx_gateway.
/// </summary>
public class AwsDxGatewayDataSource : TerraformDataSource
{
    public AwsDxGatewayDataSource(string name) : base("aws_dx_gateway", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The amazon_side_asn attribute.
    /// </summary>
    [TerraformPropertyName("amazon_side_asn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AmazonSideAsn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "amazon_side_asn");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_account_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OwnerAccountId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner_account_id");

}
