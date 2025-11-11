using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_service_account_id_token ephemeral resource (temporary credentials/tokens).
/// Ephemeral resources are used for temporary credentials, tokens, and secrets.
/// </summary>
public partial class GoogleServiceAccountIdTokenEphemeralResource : TerraformEphemeralResource
{
    public GoogleServiceAccountIdTokenEphemeralResource(string name) : base("google_service_account_id_token", name)
    {
    }

    /// <summary>
    /// Delegate chain of approvals needed to perform full impersonation. Specify the fully qualified service account name.  Used only when using impersonation mode.
    /// </summary>
    [TerraformProperty("delegates")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Delegates { get; set; }

    /// <summary>
    /// Include the verified email in the claim. Used only when using impersonation mode.
    /// </summary>
    [TerraformProperty("include_email")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IncludeEmail { get; set; }

    /// <summary>
    /// The audience claim for the `id_token`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetAudience is required")]
    [TerraformProperty("target_audience")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TargetAudience { get; set; }

    /// <summary>
    /// The email of the service account being impersonated.  Used only when using impersonation mode.
    /// </summary>
    [TerraformProperty("target_service_account")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TargetServiceAccount { get; set; }

    /// <summary>
    /// The `id_token` representing the new generated identity.
    /// </summary>
    [TerraformProperty("id_token")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> IdToken { get; }

}
