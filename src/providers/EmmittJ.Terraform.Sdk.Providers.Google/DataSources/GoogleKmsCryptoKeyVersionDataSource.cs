using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_kms_crypto_key_version.
/// </summary>
public class GoogleKmsCryptoKeyVersionDataSource : TerraformDataSource
{
    public GoogleKmsCryptoKeyVersionDataSource(string name) : base("google_kms_crypto_key_version", name)
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
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Version { get; set; }

    /// <summary>
    /// The algorithm attribute.
    /// </summary>
    [TerraformPropertyName("algorithm")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Algorithm => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "algorithm");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The protection_level attribute.
    /// </summary>
    [TerraformPropertyName("protection_level")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ProtectionLevel => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "protection_level");

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    [TerraformPropertyName("public_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PublicKey => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "public_key");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

}
