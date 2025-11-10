using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_saml_provider.
/// </summary>
public class AwsIamSamlProviderDataSource : TerraformDataSource
{
    public AwsIamSamlProviderDataSource(string name) : base("aws_iam_saml_provider", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformPropertyName("arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Arn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The create_date attribute.
    /// </summary>
    [TerraformPropertyName("create_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_date");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The saml_metadata_document attribute.
    /// </summary>
    [TerraformPropertyName("saml_metadata_document")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SamlMetadataDocument => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "saml_metadata_document");

    /// <summary>
    /// The valid_until attribute.
    /// </summary>
    [TerraformPropertyName("valid_until")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ValidUntil => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "valid_until");

}
