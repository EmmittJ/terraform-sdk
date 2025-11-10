using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_secret_manager_secret_version.
/// </summary>
public class GoogleSecretManagerSecretVersionDataSource : TerraformDataSource
{
    public GoogleSecretManagerSecretVersionDataSource(string name) : base("google_secret_manager_secret_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("destroy_time");
        SetOutput("enabled");
        SetOutput("name");
        SetOutput("secret_data");
        SetOutput("fetch_secret_data");
        SetOutput("id");
        SetOutput("is_secret_data_base64");
        SetOutput("project");
        SetOutput("secret");
        SetOutput("version");
    }

    /// <summary>
    /// The fetch_secret_data attribute.
    /// </summary>
    public TerraformProperty<bool> FetchSecretData
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("fetch_secret_data");
        set => SetProperty("fetch_secret_data", value);
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
    /// The create_time attribute.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The destroy_time attribute.
    /// </summary>
    public TerraformExpression DestroyTime => this["destroy_time"];

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformExpression Enabled => this["enabled"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The secret_data attribute.
    /// </summary>
    public TerraformExpression SecretData => this["secret_data"];

}
