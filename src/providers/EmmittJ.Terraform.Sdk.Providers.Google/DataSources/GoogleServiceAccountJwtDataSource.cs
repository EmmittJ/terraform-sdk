using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_service_account_jwt.
/// </summary>
public class GoogleServiceAccountJwtDataSource : TerraformDataSource
{
    public GoogleServiceAccountJwtDataSource(string name) : base("google_service_account_jwt", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("jwt");
        SetOutput("delegates");
        SetOutput("expires_in");
        SetOutput("id");
        SetOutput("payload");
        SetOutput("target_service_account");
    }

    /// <summary>
    /// The delegates attribute.
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
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
    /// The target_service_account attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetServiceAccount is required")]
    public required TerraformProperty<string> TargetServiceAccount
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_service_account");
        set => SetProperty("target_service_account", value);
    }

    /// <summary>
    /// The jwt attribute.
    /// </summary>
    public TerraformExpression Jwt => this["jwt"];

}
