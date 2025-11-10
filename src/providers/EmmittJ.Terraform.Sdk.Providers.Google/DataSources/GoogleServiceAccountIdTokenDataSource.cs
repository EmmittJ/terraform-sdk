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
        SetOutput("id_token");
        SetOutput("delegates");
        SetOutput("id");
        SetOutput("include_email");
        SetOutput("target_audience");
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
    /// The include_email attribute.
    /// </summary>
    public TerraformProperty<bool> IncludeEmail
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("include_email");
        set => SetProperty("include_email", value);
    }

    /// <summary>
    /// The target_audience attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetAudience is required")]
    public required TerraformProperty<string> TargetAudience
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_audience");
        set => SetProperty("target_audience", value);
    }

    /// <summary>
    /// The target_service_account attribute.
    /// </summary>
    public TerraformProperty<string> TargetServiceAccount
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_service_account");
        set => SetProperty("target_service_account", value);
    }

    /// <summary>
    /// The id_token attribute.
    /// </summary>
    public TerraformExpression IdToken => this["id_token"];

}
