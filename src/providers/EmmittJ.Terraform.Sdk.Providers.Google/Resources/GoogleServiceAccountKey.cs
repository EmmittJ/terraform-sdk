using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_service_account_key resource.
/// </summary>
public partial class GoogleServiceAccountKey : TerraformResource
{
    public GoogleServiceAccountKey(string name) : base("google_service_account_key", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Arbitrary map of values that, when changed, will trigger recreation of resource.
    /// </summary>
    [TerraformProperty("keepers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Keepers { get; set; }

    /// <summary>
    /// The algorithm used to generate the key, used only on create. KEY_ALG_RSA_2048 is the default algorithm. Valid values are: &amp;quot;KEY_ALG_RSA_1024&amp;quot;, &amp;quot;KEY_ALG_RSA_2048&amp;quot;.
    /// </summary>
    [TerraformProperty("key_algorithm")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KeyAlgorithm { get; set; }

    /// <summary>
    /// The private_key_type attribute.
    /// </summary>
    [TerraformProperty("private_key_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PrivateKeyType { get; set; }

    /// <summary>
    /// A field that allows clients to upload their own public key. If set, use this public key data to create a service account key for given service account. Please note, the expected format for this field is a base64 encoded X509_PEM.
    /// </summary>
    [TerraformProperty("public_key_data")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PublicKeyData { get; set; }

    /// <summary>
    /// The public_key_type attribute.
    /// </summary>
    [TerraformProperty("public_key_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PublicKeyType { get; set; }

    /// <summary>
    /// The ID of the parent service account of the key. This can be a string in the format {ACCOUNT} or projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}, where {ACCOUNT} is the email address or unique id of the service account. If the {ACCOUNT} syntax is used, the project will be inferred from the provider&#39;s configuration.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccountId is required")]
    [TerraformProperty("service_account_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServiceAccountId { get; set; }

    /// <summary>
    /// The name used for this key pair
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The private key in JSON format, base64 encoded. This is what you normally get as a file when creating service account keys through the CLI or web console. This is only populated when creating a new key.
    /// </summary>
    [TerraformProperty("private_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrivateKey { get; }

    /// <summary>
    /// The public key, base64 encoded
    /// </summary>
    [TerraformProperty("public_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PublicKey { get; }

    /// <summary>
    /// The key can be used after this timestamp. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("valid_after")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ValidAfter { get; }

    /// <summary>
    /// The key can be used before this timestamp. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("valid_before")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ValidBefore { get; }

}
