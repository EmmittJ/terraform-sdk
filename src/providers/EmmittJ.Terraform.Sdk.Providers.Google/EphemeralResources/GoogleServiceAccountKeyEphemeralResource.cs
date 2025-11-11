using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Get an ephemeral service account public key.
/// Ephemeral resources are used for temporary credentials, tokens, and secrets.
/// </summary>
public class GoogleServiceAccountKeyEphemeralResource : TerraformEphemeralResource
{
    public GoogleServiceAccountKeyEphemeralResource(string name) : base("google_service_account_key", name)
    {
    }

    /// <summary>
    /// The name of the service account key. This must have format `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{KEYID}`, where `{ACCOUNT}` is the email address or unique id of the service account.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The output format of the public key requested. TYPE_X509_PEM_FILE is the default output format.
    /// </summary>
    [TerraformPropertyName("public_key_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PublicKeyType { get; set; }

    /// <summary>
    /// The algorithm used to generate the key.
    /// </summary>
    [TerraformPropertyName("key_algorithm")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KeyAlgorithm => new TerraformReference(this, "key_algorithm");

    /// <summary>
    /// The public key, base64 encoded.
    /// </summary>
    [TerraformPropertyName("public_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PublicKey => new TerraformReference(this, "public_key");

}
