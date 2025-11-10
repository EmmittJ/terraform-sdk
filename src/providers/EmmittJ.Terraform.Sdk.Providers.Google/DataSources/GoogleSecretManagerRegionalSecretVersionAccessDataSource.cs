using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_secret_manager_regional_secret_version_access.
/// </summary>
public class GoogleSecretManagerRegionalSecretVersionAccessDataSource : TerraformDataSource
{
    public GoogleSecretManagerRegionalSecretVersionAccessDataSource(string name) : base("google_secret_manager_regional_secret_version_access", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("name");
        SetOutput("secret_data");
        SetOutput("id");
        SetOutput("is_secret_data_base64");
        SetOutput("location");
        SetOutput("project");
        SetOutput("secret");
        SetOutput("version");
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
    /// The is_secret_data_base64 attribute.
    /// </summary>
    public TerraformProperty<bool> IsSecretDataBase64
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("is_secret_data_base64");
        set => SetProperty("is_secret_data_base64", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    public required TerraformProperty<string> Secret
    {
        get => GetRequiredOutput<TerraformProperty<string>>("secret");
        set => SetProperty("secret", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string> Version
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version");
        set => SetProperty("version", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The secret_data attribute.
    /// </summary>
    public TerraformExpression SecretData => this["secret_data"];

}
