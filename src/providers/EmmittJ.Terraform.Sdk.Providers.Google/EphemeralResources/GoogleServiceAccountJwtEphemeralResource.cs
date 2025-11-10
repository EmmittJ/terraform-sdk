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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("jwt");
        SetOutput("delegates");
        SetOutput("expires_in");
        SetOutput("payload");
        SetOutput("target_service_account");
    }

    /// <summary>
    /// Delegate chain of approvals needed to perform full impersonation. Specify the fully qualified service account name.
    /// </summary>
    public HashSet<TerraformProperty<string>> Delegates
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("delegates");
        set => SetProperty("delegates", value);
    }

    /// <summary>
    /// Number of seconds until the JWT expires. If set and non-zero an `exp` claim will be added to the payload derived from the current timestamp plus expires_in seconds.
    /// </summary>
    public TerraformProperty<double> ExpiresIn
    {
        get => GetRequiredOutput<TerraformProperty<double>>("expires_in");
        set => SetProperty("expires_in", value);
    }

    /// <summary>
    /// A JSON-encoded JWT claims set that will be included in the signed JWT.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Payload is required")]
    public required TerraformProperty<string> Payload
    {
        get => GetRequiredOutput<TerraformProperty<string>>("payload");
        set => SetProperty("payload", value);
    }

    /// <summary>
    /// The email of the service account that will sign the JWT.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetServiceAccount is required")]
    public required TerraformProperty<string> TargetServiceAccount
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_service_account");
        set => SetProperty("target_service_account", value);
    }

    /// <summary>
    /// The signed JWT containing the JWT Claims Set from the `payload`.
    /// </summary>
    public TerraformExpression Jwt => this["jwt"];

}
