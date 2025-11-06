using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_service_account_access_token.
/// </summary>
public class GoogleServiceAccountAccessTokenDataSource : TerraformDataSource
{
    public GoogleServiceAccountAccessTokenDataSource(string name) : base("google_service_account_access_token", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("access_token");
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
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The lifetime attribute.
    /// </summary>
    public string? Lifetime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lifetime")?.Value;
        set => this.WithProperty("lifetime", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    public HashSet<string>? Scopes
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("scopes")?.Value;
        set => this.WithProperty("scopes", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The access_token attribute.
    /// </summary>
    public TerraformExpression AccessToken => this["access_token"];

}
