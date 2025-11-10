using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_kms_secret_ciphertext.
/// </summary>
[Obsolete("This data source is deprecated.")]
public class GoogleKmsSecretCiphertextDataSource : TerraformDataSource
{
    public GoogleKmsSecretCiphertextDataSource(string name) : base("google_kms_secret_ciphertext", name)
    {
    }

    /// <summary>
    /// The crypto_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CryptoKey is required")]
    [TerraformPropertyName("crypto_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CryptoKey { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The plaintext attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plaintext is required")]
    [TerraformPropertyName("plaintext")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Plaintext { get; set; }

    /// <summary>
    /// The ciphertext attribute.
    /// </summary>
    [TerraformPropertyName("ciphertext")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Ciphertext => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ciphertext");

}
