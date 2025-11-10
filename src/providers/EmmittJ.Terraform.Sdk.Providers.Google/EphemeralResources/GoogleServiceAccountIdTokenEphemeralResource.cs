using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_service_account_id_token ephemeral resource (temporary credentials/tokens).
/// Ephemeral resources are used for temporary credentials, tokens, and secrets.
/// </summary>
public class GoogleServiceAccountIdTokenEphemeralResource : TerraformEphemeralResource
{
    public GoogleServiceAccountIdTokenEphemeralResource(string name) : base("google_service_account_id_token", name)
    {
    }

    /// <summary>
    /// Delegate chain of approvals needed to perform full impersonation. Specify the fully qualified service account name.  Used only when using impersonation mode.
    /// </summary>
    [TerraformPropertyName("delegates")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Delegates { get; set; }

    /// <summary>
    /// Include the verified email in the claim. Used only when using impersonation mode.
    /// </summary>
    [TerraformPropertyName("include_email")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeEmail { get; set; }

    /// <summary>
    /// The audience claim for the `id_token`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetAudience is required")]
    [TerraformPropertyName("target_audience")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TargetAudience { get; set; }

    /// <summary>
    /// The email of the service account being impersonated.  Used only when using impersonation mode.
    /// </summary>
    [TerraformPropertyName("target_service_account")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TargetServiceAccount { get; set; }

    /// <summary>
    /// The `id_token` representing the new generated identity.
    /// </summary>
    [TerraformPropertyName("id_token")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IdToken => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id_token");

}
