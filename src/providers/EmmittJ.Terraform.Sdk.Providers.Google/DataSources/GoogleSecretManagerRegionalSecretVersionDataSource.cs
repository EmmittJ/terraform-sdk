using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_secret_manager_regional_secret_version Terraform data source.
/// Retrieves information about a google_secret_manager_regional_secret_version.
/// </summary>
public partial class GoogleSecretManagerRegionalSecretVersionDataSource(string name) : TerraformDataSource("google_secret_manager_regional_secret_version", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The is_secret_data_base64 attribute.
    /// </summary>
    public TerraformValue<bool>? IsSecretDataBase64
    {
        get => GetArgument<TerraformValue<bool>>("is_secret_data_base64");
        set => SetArgument("is_secret_data_base64", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location") ?? CreateReference("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    public required TerraformValue<string> Secret
    {
        get => GetRequiredArgument<TerraformValue<string>>("secret");
        set => SetArgument("secret", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => GetArgument<TerraformValue<string>>("version") ?? CreateReference("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// The customer_managed_encryption attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CustomerManagedEncryption
        => CreateReference("customer_managed_encryption");

    /// <summary>
    /// The destroy_time attribute.
    /// </summary>
    public TerraformValue<string> DestroyTime
        => CreateReference("destroy_time");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
        => CreateReference("enabled");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// The secret_data attribute.
    /// </summary>
    public TerraformValue<string> SecretData
        => CreateReference("secret_data");

}
