using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_service_account_id_token.
/// </summary>
public class GoogleServiceAccountIdTokenDataSource : TerraformDataSource
{
    public GoogleServiceAccountIdTokenDataSource(string name) : base("google_service_account_id_token", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id_token");
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
    /// The include_email attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? IncludeEmail
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("include_email");
        set => this.WithProperty("include_email", value);
    }

    /// <summary>
    /// The target_audience attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetAudience
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_audience");
        set => this.WithProperty("target_audience", value);
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
    /// The id_token attribute.
    /// </summary>
    public TerraformExpression IdToken => this["id_token"];

}
