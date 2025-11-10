using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_kms_crypto_keys.
/// </summary>
public class GoogleKmsCryptoKeysDataSource : TerraformDataSource
{
    public GoogleKmsCryptoKeysDataSource(string name) : base("google_kms_crypto_keys", name)
    {
    }

    /// <summary>
    /// 
    /// 					The filter argument is used to add a filter query parameter that limits which keys are retrieved by the data source: ?filter={{filter}}.
    /// 					Example values:
    /// 					
    /// 					* &amp;quot;name:my-key-&amp;quot; will retrieve keys that contain &amp;quot;my-key-&amp;quot; anywhere in their name. Note: names take the form projects/{{project}}/locations/{{location}}/keyRings/{{keyRing}}/cryptoKeys/{{cryptoKey}}.
    /// 					* &amp;quot;name=projects/my-project/locations/global/keyRings/my-key-ring/cryptoKeys/my-key-1&amp;quot; will only retrieve a key with that exact name.
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
    /// The key ring that the keys belongs to. Format: &#39;projects/{{project}}/locations/{{location}}/keyRings/{{keyRing}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyRing is required")]
    [TerraformPropertyName("key_ring")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KeyRing { get; set; }

    /// <summary>
    /// A list of all the retrieved keys from the provided key ring
    /// </summary>
    [TerraformPropertyName("keys")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Keys => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "keys");

}
