using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_service_account_access_token ephemeral resource (temporary credentials/tokens).
/// Ephemeral resources are used for temporary credentials, tokens, and secrets.
/// </summary>
public partial class GoogleServiceAccountAccessTokenEphemeralResource : TerraformEphemeralResource
{
    public GoogleServiceAccountAccessTokenEphemeralResource(string name) : base("google_service_account_access_token", name)
    {
    }

    /// <summary>
    /// Delegate chain of approvals needed to perform full impersonation. Specify the fully qualified service account name.  (e.g. `[&#39;projects/-/serviceAccounts/delegate-svc-account@project-id.iam.gserviceaccount.com&#39;]`)
    /// </summary>
    [TerraformProperty("delegates")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Delegates { get; set; }

    /// <summary>
    /// Lifetime of the impersonated token (defaults to its max: `3600s`)
    /// </summary>
    [TerraformProperty("lifetime")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Lifetime { get; set; }

    /// <summary>
    /// The scopes the new credential should have (e.g. `[&#39;cloud-platform&#39;]`)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    [TerraformProperty("scopes")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Scopes { get; set; }

    /// <summary>
    /// The service account to impersonate (e.g. `service_B@your-project-id.iam.gserviceaccount.com`)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetServiceAccount is required")]
    [TerraformProperty("target_service_account")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetServiceAccount { get; set; }

    /// <summary>
    /// The `access_token` representing the new generated identity.
    /// </summary>
    [TerraformProperty("access_token")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AccessToken { get; }

}
