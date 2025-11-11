using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_kms_secret_ciphertext.
/// </summary>
[Obsolete("This data source is deprecated.")]
public partial class GoogleKmsSecretCiphertextDataSource : TerraformDataSource
{
    public GoogleKmsSecretCiphertextDataSource(string name) : base("google_kms_secret_ciphertext", name)
    {
    }

    /// <summary>
    /// The crypto_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CryptoKey is required")]
    [TerraformProperty("crypto_key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CryptoKey { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The plaintext attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plaintext is required")]
    [TerraformProperty("plaintext")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Plaintext { get; set; }

    /// <summary>
    /// The ciphertext attribute.
    /// </summary>
    [TerraformProperty("ciphertext")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Ciphertext { get; }

}
