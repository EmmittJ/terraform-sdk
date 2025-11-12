using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleKmsSecretCiphertextTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a google_kms_secret_ciphertext resource.
/// </summary>
public partial class GoogleKmsSecretCiphertext : TerraformResource
{
    public GoogleKmsSecretCiphertext(string name) : base("google_kms_secret_ciphertext", name)
    {
    }

    /// <summary>
    /// The additional authenticated data used for integrity checks during encryption and decryption.
    /// </summary>
    [TerraformProperty("additional_authenticated_data")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AdditionalAuthenticatedData { get; set; }

    /// <summary>
    /// The full name of the CryptoKey that will be used to encrypt the provided plaintext.
    /// Format: &#39;&#39;projects/{{project}}/locations/{{location}}/keyRings/{{keyRing}}/cryptoKeys/{{cryptoKey}}&#39;&#39;
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
    /// The plaintext to be encrypted.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plaintext is required")]
    [TerraformProperty("plaintext")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Plaintext { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleKmsSecretCiphertextTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Contains the result of encrypting the provided plaintext, encoded in base64.
    /// </summary>
    [TerraformProperty("ciphertext")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Ciphertext { get; }

}
