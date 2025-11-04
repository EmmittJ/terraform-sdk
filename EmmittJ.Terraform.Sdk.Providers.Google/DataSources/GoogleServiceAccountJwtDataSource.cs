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
    public HashSet<string>? Delegates
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("delegates")?.Value;
        set => this.WithProperty("delegates", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// Number of seconds until the JWT expires. If set and non-zero an `exp` claim will be added to the payload derived from the current timestamp plus expires_in seconds.
    /// </summary>
    public double? ExpiresIn
    {
        get => GetProperty<TerraformLiteralProperty<double>>("expires_in")?.Value;
        set => this.WithProperty("expires_in", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A JSON-encoded JWT claims set that will be included in the signed JWT.
    /// </summary>
    public string? Payload
    {
        get => GetProperty<TerraformLiteralProperty<string>>("payload")?.Value;
        set => this.WithProperty("payload", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_service_account attribute.
    /// </summary>
    public string? TargetServiceAccount
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_service_account")?.Value;
        set => this.WithProperty("target_service_account", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The jwt attribute.
    /// </summary>
    public TerraformExpression Jwt => this["jwt"];

}
