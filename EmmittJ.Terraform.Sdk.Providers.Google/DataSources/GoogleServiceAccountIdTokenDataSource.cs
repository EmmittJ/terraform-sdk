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
    /// The include_email attribute.
    /// </summary>
    public bool? IncludeEmail
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("include_email")?.Value;
        set => this.WithProperty("include_email", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The target_audience attribute.
    /// </summary>
    public string? TargetAudience
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_audience")?.Value;
        set => this.WithProperty("target_audience", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The id_token attribute.
    /// </summary>
    public TerraformExpression IdToken => this["id_token"];

}
