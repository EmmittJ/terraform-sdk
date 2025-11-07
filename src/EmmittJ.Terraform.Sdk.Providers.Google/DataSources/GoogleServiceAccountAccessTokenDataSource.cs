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
    public TerraformProperty<HashSet<string>>? Delegates
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("delegates");
        set => this.WithProperty("delegates", value);
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
    /// The lifetime attribute.
    /// </summary>
    public TerraformProperty<string>? Lifetime
    {
        get => GetProperty<TerraformProperty<string>>("lifetime");
        set => this.WithProperty("lifetime", value);
    }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Scopes
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("scopes");
        set => this.WithProperty("scopes", value);
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
    /// The access_token attribute.
    /// </summary>
    public TerraformExpression AccessToken => this["access_token"];

}
