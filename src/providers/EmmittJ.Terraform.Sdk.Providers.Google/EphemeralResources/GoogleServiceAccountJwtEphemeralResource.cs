using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Produces an arbitrary self-signed JWT for service accounts.
/// Ephemeral resources are used for temporary credentials, tokens, and secrets.
/// </summary>
public class GoogleServiceAccountJwtEphemeralResource : TerraformEphemeralResource
{
    public GoogleServiceAccountJwtEphemeralResource(string name) : base("google_service_account_jwt", name)
    {
    }

    /// <summary>
    /// Delegate chain of approvals needed to perform full impersonation. Specify the fully qualified service account name.
    /// </summary>
    [TerraformPropertyName("delegates")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Delegates { get; set; }

    /// <summary>
    /// Number of seconds until the JWT expires. If set and non-zero an `exp` claim will be added to the payload derived from the current timestamp plus expires_in seconds.
    /// </summary>
    [TerraformPropertyName("expires_in")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ExpiresIn { get; set; }

    /// <summary>
    /// A JSON-encoded JWT claims set that will be included in the signed JWT.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Payload is required")]
    [TerraformPropertyName("payload")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Payload { get; set; }

    /// <summary>
    /// The email of the service account that will sign the JWT.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetServiceAccount is required")]
    [TerraformPropertyName("target_service_account")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TargetServiceAccount { get; set; }

    /// <summary>
    /// The signed JWT containing the JWT Claims Set from the `payload`.
    /// </summary>
    [TerraformPropertyName("jwt")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Jwt => new TerraformReference(this, "jwt");

}
