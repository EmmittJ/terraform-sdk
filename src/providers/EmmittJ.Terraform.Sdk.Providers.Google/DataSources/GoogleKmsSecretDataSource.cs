using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_kms_secret.
/// </summary>
public partial class GoogleKmsSecretDataSource : TerraformDataSource
{
    public GoogleKmsSecretDataSource(string name) : base("google_kms_secret", name)
    {
    }

    /// <summary>
    /// The additional_authenticated_data attribute.
    /// </summary>
    [TerraformProperty("additional_authenticated_data")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AdditionalAuthenticatedData { get; set; }

    /// <summary>
    /// The ciphertext attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ciphertext is required")]
    [TerraformProperty("ciphertext")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Ciphertext { get; set; }

    /// <summary>
    /// The crypto_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CryptoKey is required")]
    [TerraformProperty("crypto_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CryptoKey { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The plaintext attribute.
    /// </summary>
    [TerraformProperty("plaintext")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Plaintext { get; }

}
