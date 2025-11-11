using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_kms_secret.
/// </summary>
public class GoogleKmsSecretDataSource : TerraformDataSource
{
    public GoogleKmsSecretDataSource(string name) : base("google_kms_secret", name)
    {
    }

    /// <summary>
    /// The additional_authenticated_data attribute.
    /// </summary>
    [TerraformPropertyName("additional_authenticated_data")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AdditionalAuthenticatedData { get; set; }

    /// <summary>
    /// The ciphertext attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ciphertext is required")]
    [TerraformPropertyName("ciphertext")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Ciphertext { get; set; }

    /// <summary>
    /// The crypto_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CryptoKey is required")]
    [TerraformPropertyName("crypto_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CryptoKey { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The plaintext attribute.
    /// </summary>
    [TerraformPropertyName("plaintext")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Plaintext => new TerraformReference(this, "plaintext");

}
