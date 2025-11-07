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
        this.DeclareOutput("jwt");
    }

    /// <summary>
    /// The delegates attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Delegates
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("delegates");
        set => this.WithProperty("delegates", value);
    }

    /// <summary>
    /// Number of seconds until the JWT expires. If set and non-zero an `exp` claim will be added to the payload derived from the current timestamp plus expires_in seconds.
    /// </summary>
    public TerraformProperty<double>? ExpiresIn
    {
        get => GetProperty<TerraformProperty<double>>("expires_in");
        set => this.WithProperty("expires_in", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// A JSON-encoded JWT claims set that will be included in the signed JWT.
    /// </summary>
    public TerraformProperty<string>? Payload
    {
        get => GetProperty<TerraformProperty<string>>("payload");
        set => this.WithProperty("payload", value);
    }

    /// <summary>
    /// The target_service_account attribute.
    /// </summary>
    public TerraformProperty<string>? TargetServiceAccount
    {
        get => GetProperty<TerraformProperty<string>>("target_service_account");
        set => this.WithProperty("target_service_account", value);
    }

    /// <summary>
    /// The jwt attribute.
    /// </summary>
    public TerraformExpression Jwt => this["jwt"];

}
