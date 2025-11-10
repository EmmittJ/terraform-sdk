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
        SetOutput("access_token");
        SetOutput("delegates");
        SetOutput("id");
        SetOutput("lifetime");
        SetOutput("scopes");
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The lifetime attribute.
    /// </summary>
    public TerraformProperty<string> Lifetime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("lifetime");
        set => SetProperty("lifetime", value);
    }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    public HashSet<TerraformProperty<string>> Scopes
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("scopes");
        set => SetProperty("scopes", value);
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
    /// The access_token attribute.
    /// </summary>
    public TerraformExpression AccessToken => this["access_token"];

}
