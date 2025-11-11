using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_kms_crypto_key_versions.
/// </summary>
public partial class GoogleKmsCryptoKeyVersionsDataSource : TerraformDataSource
{
    public GoogleKmsCryptoKeyVersionsDataSource(string name) : base("google_kms_crypto_key_versions", name)
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
    /// 
    /// 					The filter argument is used to add a filter query parameter that limits which cryptoKeyVersions are retrieved by the data source: ?filter={{filter}}.
    /// 					Example values:
    /// 					
    /// 					* &amp;quot;name:my-cryptokey-version-&amp;quot; will retrieve cryptoKeyVersions that contain &amp;quot;my-key-&amp;quot; anywhere in their name. Note: names take the form projects/{{project}}/locations/{{location}}/keyRings/{{keyRing}}/cryptoKeys/{{cryptoKey}}/cryptoKeyVersions/{{cryptoKeyVersion}}.
    /// 					* &amp;quot;name=projects/my-project/locations/global/keyRings/my-key-ring/cryptoKeys/my-key-1/cryptoKeyVersions/1&amp;quot; will only retrieve a key with that exact name.
    /// 					
    /// 					[See the documentation about using filters](https://cloud.google.com/kms/docs/sorting-and-filtering)
    /// 				
    /// </summary>
    [TerraformProperty("filter")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Filter { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    [TerraformProperty("public_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> PublicKey { get; }

    /// <summary>
    /// A list of all the retrieved cryptoKeyVersions from the provided crypto key
    /// </summary>
    [TerraformProperty("versions")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Versions { get; }

}
