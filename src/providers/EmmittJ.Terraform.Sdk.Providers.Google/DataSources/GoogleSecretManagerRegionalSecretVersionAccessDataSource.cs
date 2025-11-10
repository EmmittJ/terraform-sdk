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
        this.WithOutput("name");
        this.WithOutput("secret_data");
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
    /// The is_secret_data_base64 attribute.
    /// </summary>
    public TerraformProperty<bool>? IsSecretDataBase64
    {
        get => GetProperty<TerraformProperty<bool>>("is_secret_data_base64");
        set => this.WithProperty("is_secret_data_base64", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    public required TerraformProperty<string> Secret
    {
        get => GetRequiredProperty<TerraformProperty<string>>("secret");
        set => this.WithProperty("secret", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
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
