using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermStaticWebAppDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermStaticWebAppDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_static_web_app Terraform data source.
/// Retrieves information about a azurerm_static_web_app.
/// </summary>
public partial class AzurermStaticWebAppDataSource(string name) : TerraformDataSource("azurerm_static_web_app", name)
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The api_key attribute.
    /// </summary>
    public TerraformValue<string> ApiKey
        => CreateReference("api_key");

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    public TerraformMap<string> AppSettings
        => CreateReference("app_settings");

    /// <summary>
    /// The basic_auth attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> BasicAuth
        => CreateReference("basic_auth");

    /// <summary>
    /// The configuration_file_changes_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ConfigurationFileChangesEnabled
        => CreateReference("configuration_file_changes_enabled");

    /// <summary>
    /// The default_host_name attribute.
    /// </summary>
    public TerraformValue<string> DefaultHostName
        => CreateReference("default_host_name");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => CreateReference("identity");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The preview_environments_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PreviewEnvironmentsEnabled
        => CreateReference("preview_environments_enabled");

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PublicNetworkAccessEnabled
        => CreateReference("public_network_access_enabled");

    /// <summary>
    /// The repository_branch attribute.
    /// </summary>
    public TerraformValue<string> RepositoryBranch
        => CreateReference("repository_branch");

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    public TerraformValue<string> RepositoryUrl
        => CreateReference("repository_url");

    /// <summary>
    /// The sku_size attribute.
    /// </summary>
    public TerraformValue<string> SkuSize
        => CreateReference("sku_size");

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    public TerraformValue<string> SkuTier
        => CreateReference("sku_tier");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStaticWebAppDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStaticWebAppDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
