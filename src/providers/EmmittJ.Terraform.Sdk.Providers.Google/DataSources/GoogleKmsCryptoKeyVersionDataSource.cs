using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_kms_crypto_key_version.
/// </summary>
public partial class GoogleKmsCryptoKeyVersionDataSource : TerraformDataSource
{
    public GoogleKmsCryptoKeyVersionDataSource(string name) : base("google_kms_crypto_key_version", name)
    {
    }

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
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Version { get; set; }

    /// <summary>
    /// The algorithm attribute.
    /// </summary>
    [TerraformProperty("algorithm")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Algorithm { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The protection_level attribute.
    /// </summary>
    [TerraformProperty("protection_level")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ProtectionLevel { get; }

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    [TerraformProperty("public_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> PublicKey { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

}
