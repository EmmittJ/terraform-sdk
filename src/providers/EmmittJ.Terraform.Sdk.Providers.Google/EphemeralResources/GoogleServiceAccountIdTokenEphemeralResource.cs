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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id_token");
        SetOutput("delegates");
        SetOutput("include_email");
        SetOutput("target_audience");
        SetOutput("target_service_account");
    }

    /// <summary>
    /// Delegate chain of approvals needed to perform full impersonation. Specify the fully qualified service account name.  Used only when using impersonation mode.
    /// </summary>
    public HashSet<TerraformProperty<string>> Delegates
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("delegates");
        set => SetProperty("delegates", value);
    }

    /// <summary>
    /// Include the verified email in the claim. Used only when using impersonation mode.
    /// </summary>
    public TerraformProperty<bool> IncludeEmail
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("include_email");
        set => SetProperty("include_email", value);
    }

    /// <summary>
    /// The audience claim for the `id_token`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetAudience is required")]
    public required TerraformProperty<string> TargetAudience
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_audience");
        set => SetProperty("target_audience", value);
    }

    /// <summary>
    /// The email of the service account being impersonated.  Used only when using impersonation mode.
    /// </summary>
    public TerraformProperty<string> TargetServiceAccount
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_service_account");
        set => SetProperty("target_service_account", value);
    }

    /// <summary>
    /// The `id_token` representing the new generated identity.
    /// </summary>
    public TerraformExpression IdToken => this["id_token"];

}
