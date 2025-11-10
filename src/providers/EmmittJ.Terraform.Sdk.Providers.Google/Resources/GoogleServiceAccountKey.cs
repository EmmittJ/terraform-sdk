using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_service_account_key resource.
/// </summary>
public class GoogleServiceAccountKey : TerraformResource
{
    public GoogleServiceAccountKey(string name) : base("google_service_account_key", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Arbitrary map of values that, when changed, will trigger recreation of resource.
    /// </summary>
    [TerraformPropertyName("keepers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Keepers { get; set; }

    /// <summary>
    /// The algorithm used to generate the key, used only on create. KEY_ALG_RSA_2048 is the default algorithm. Valid values are: &amp;quot;KEY_ALG_RSA_1024&amp;quot;, &amp;quot;KEY_ALG_RSA_2048&amp;quot;.
    /// </summary>
    [TerraformPropertyName("key_algorithm")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KeyAlgorithm { get; set; }

    /// <summary>
    /// The private_key_type attribute.
    /// </summary>
    [TerraformPropertyName("private_key_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PrivateKeyType { get; set; }

    /// <summary>
    /// A field that allows clients to upload their own public key. If set, use this public key data to create a service account key for given service account. Please note, the expected format for this field is a base64 encoded X509_PEM.
    /// </summary>
    [TerraformPropertyName("public_key_data")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PublicKeyData { get; set; }

    /// <summary>
    /// The public_key_type attribute.
    /// </summary>
    [TerraformPropertyName("public_key_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PublicKeyType { get; set; }

    /// <summary>
    /// The ID of the parent service account of the key. This can be a string in the format {ACCOUNT} or projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}, where {ACCOUNT} is the email address or unique id of the service account. If the {ACCOUNT} syntax is used, the project will be inferred from the provider&#39;s configuration.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccountId is required")]
    [TerraformPropertyName("service_account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServiceAccountId { get; set; }

    /// <summary>
    /// The name used for this key pair
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The private key in JSON format, base64 encoded. This is what you normally get as a file when creating service account keys through the CLI or web console. This is only populated when creating a new key.
    /// </summary>
    [TerraformPropertyName("private_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivateKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_key");

    /// <summary>
    /// The public key, base64 encoded
    /// </summary>
    [TerraformPropertyName("public_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PublicKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "public_key");

    /// <summary>
    /// The key can be used after this timestamp. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("valid_after")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ValidAfter => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "valid_after");

    /// <summary>
    /// The key can be used before this timestamp. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("valid_before")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ValidBefore => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "valid_before");

}
