using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_kms_crypto_key_latest_version.
/// </summary>
public class GoogleKmsCryptoKeyLatestVersionDataSource : TerraformDataSource
{
    public GoogleKmsCryptoKeyLatestVersionDataSource(string name) : base("google_kms_crypto_key_latest_version", name)
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
    /// 
    /// 					The filter argument is used to add a filter query parameter that limits which type of cryptoKeyVersion is retrieved as the latest by the data source: ?filter={{filter}}. When no value is provided there is no filtering.
    /// 
    /// 					Example filter values if filtering on state.
    /// 
    /// 					* &amp;quot;state:ENABLED&amp;quot; will retrieve the latest cryptoKeyVersion that has the state &amp;quot;ENABLED&amp;quot;.
    /// 
    /// 					[See the documentation about using filters](https://cloud.google.com/kms/docs/sorting-and-filtering)
    /// 				
    /// </summary>
    [TerraformPropertyName("filter")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Filter { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Version => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "version");

}
