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
        this.DeclareOutput("id_token");
    }

    /// <summary>
    /// Delegate chain of approvals needed to perform full impersonation. Specify the fully qualified service account name.  Used only when using impersonation mode.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Delegates
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("delegates");
        set => this.WithProperty("delegates", value);
    }

    /// <summary>
    /// Include the verified email in the claim. Used only when using impersonation mode.
    /// </summary>
    public TerraformProperty<bool>? IncludeEmail
    {
        get => GetProperty<TerraformProperty<bool>>("include_email");
        set => this.WithProperty("include_email", value);
    }

    /// <summary>
    /// The audience claim for the `id_token`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetAudience is required")]
    public required TerraformProperty<string> TargetAudience
    {
        get => GetRequiredProperty<TerraformProperty<string>>("target_audience");
        set => this.WithProperty("target_audience", value);
    }

    /// <summary>
    /// The email of the service account being impersonated.  Used only when using impersonation mode.
    /// </summary>
    public TerraformProperty<string>? TargetServiceAccount
    {
        get => GetProperty<TerraformProperty<string>>("target_service_account");
        set => this.WithProperty("target_service_account", value);
    }

    /// <summary>
    /// The `id_token` representing the new generated identity.
    /// </summary>
    public TerraformExpression IdToken => this["id_token"];

}
