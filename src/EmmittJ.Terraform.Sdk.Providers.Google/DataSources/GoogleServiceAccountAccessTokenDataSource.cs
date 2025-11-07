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
    public TerraformLiteralProperty<HashSet<string>>? Delegates
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("delegates");
        set => this.WithProperty("delegates", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The lifetime attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Lifetime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lifetime");
        set => this.WithProperty("lifetime", value);
    }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Scopes
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("scopes");
        set => this.WithProperty("scopes", value);
    }

    /// <summary>
    /// The target_service_account attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetServiceAccount
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_service_account");
        set => this.WithProperty("target_service_account", value);
    }

    /// <summary>
    /// The access_token attribute.
    /// </summary>
    public TerraformExpression AccessToken => this["access_token"];

}
