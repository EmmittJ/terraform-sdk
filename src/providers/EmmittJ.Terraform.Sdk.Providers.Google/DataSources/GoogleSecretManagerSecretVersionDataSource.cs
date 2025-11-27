using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_secret_manager_secret_version Terraform data source.
/// Retrieves information about a google_secret_manager_secret_version.
/// </summary>
public partial class GoogleSecretManagerSecretVersionDataSource(string name) : TerraformDataSource("google_secret_manager_secret_version", name)
{
    /// <summary>
    /// The fetch_secret_data attribute.
    /// </summary>
    public TerraformValue<bool>? FetchSecretData
    {
        get => new TerraformReference<bool>(this, "fetch_secret_data");
        set => SetArgument("fetch_secret_data", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The is_secret_data_base64 attribute.
    /// </summary>
    public TerraformValue<bool>? IsSecretDataBase64
    {
        get => new TerraformReference<bool>(this, "is_secret_data_base64");
        set => SetArgument("is_secret_data_base64", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    public required TerraformValue<string> Secret
    {
        get => new TerraformReference<string>(this, "secret");
        set => SetArgument("secret", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// The destroy_time attribute.
    /// </summary>
    public TerraformValue<string> DestroyTime
    {
        get => new TerraformReference<string>(this, "destroy_time");
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The secret_data attribute.
    /// </summary>
    public TerraformValue<string> SecretData
    {
        get => new TerraformReference<string>(this, "secret_data");
    }

}
