using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_service_account_access_token ephemeral resource (temporary credentials/tokens).
/// Ephemeral resources are used for temporary credentials, tokens, and secrets.
/// </summary>
public class GoogleServiceAccountAccessTokenEphemeralResource : TerraformEphemeralResource
{
    public GoogleServiceAccountAccessTokenEphemeralResource(string name) : base("google_service_account_access_token", name)
    {
    }

    /// <summary>
    /// Delegate chain of approvals needed to perform full impersonation. Specify the fully qualified service account name.  (e.g. `[&#39;projects/-/serviceAccounts/delegate-svc-account@project-id.iam.gserviceaccount.com&#39;]`)
    /// </summary>
    [TerraformPropertyName("delegates")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Delegates { get; set; }

    /// <summary>
    /// Lifetime of the impersonated token (defaults to its max: `3600s`)
    /// </summary>
    [TerraformPropertyName("lifetime")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Lifetime { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "lifetime");

    /// <summary>
    /// The scopes the new credential should have (e.g. `[&#39;cloud-platform&#39;]`)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    [TerraformPropertyName("scopes")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Scopes { get; set; }

    /// <summary>
    /// The service account to impersonate (e.g. `service_B@your-project-id.iam.gserviceaccount.com`)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetServiceAccount is required")]
    [TerraformPropertyName("target_service_account")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TargetServiceAccount { get; set; }

    /// <summary>
    /// The `access_token` representing the new generated identity.
    /// </summary>
    [TerraformPropertyName("access_token")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AccessToken => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "access_token");

}
