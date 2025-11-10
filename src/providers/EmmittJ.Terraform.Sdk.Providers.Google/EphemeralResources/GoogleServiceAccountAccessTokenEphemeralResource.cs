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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("access_token");
        SetOutput("delegates");
        SetOutput("lifetime");
        SetOutput("scopes");
        SetOutput("target_service_account");
    }

    /// <summary>
    /// Delegate chain of approvals needed to perform full impersonation. Specify the fully qualified service account name.  (e.g. `[&#39;projects/-/serviceAccounts/delegate-svc-account@project-id.iam.gserviceaccount.com&#39;]`)
    /// </summary>
    public HashSet<TerraformProperty<string>> Delegates
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("delegates");
        set => SetProperty("delegates", value);
    }

    /// <summary>
    /// Lifetime of the impersonated token (defaults to its max: `3600s`)
    /// </summary>
    public TerraformProperty<string> Lifetime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("lifetime");
        set => SetProperty("lifetime", value);
    }

    /// <summary>
    /// The scopes the new credential should have (e.g. `[&#39;cloud-platform&#39;]`)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    public HashSet<TerraformProperty<string>> Scopes
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("scopes");
        set => SetProperty("scopes", value);
    }

    /// <summary>
    /// The service account to impersonate (e.g. `service_B@your-project-id.iam.gserviceaccount.com`)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetServiceAccount is required")]
    public required TerraformProperty<string> TargetServiceAccount
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_service_account");
        set => SetProperty("target_service_account", value);
    }

    /// <summary>
    /// The `access_token` representing the new generated identity.
    /// </summary>
    public TerraformExpression AccessToken => this["access_token"];

}
