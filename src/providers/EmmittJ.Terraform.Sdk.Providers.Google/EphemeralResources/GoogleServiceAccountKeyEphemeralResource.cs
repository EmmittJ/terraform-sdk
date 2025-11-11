using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Get an ephemeral service account public key.
/// Ephemeral resources are used for temporary credentials, tokens, and secrets.
/// </summary>
public partial class GoogleServiceAccountKeyEphemeralResource : TerraformEphemeralResource
{
    public GoogleServiceAccountKeyEphemeralResource(string name) : base("google_service_account_key", name)
    {
    }

    /// <summary>
    /// The name of the service account key. This must have format `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{KEYID}`, where `{ACCOUNT}` is the email address or unique id of the service account.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The output format of the public key requested. TYPE_X509_PEM_FILE is the default output format.
    /// </summary>
    [TerraformProperty("public_key_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PublicKeyType { get; set; }

    /// <summary>
    /// The algorithm used to generate the key.
    /// </summary>
    [TerraformProperty("key_algorithm")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KeyAlgorithm { get; }

    /// <summary>
    /// The public key, base64 encoded.
    /// </summary>
    [TerraformProperty("public_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PublicKey { get; }

}
