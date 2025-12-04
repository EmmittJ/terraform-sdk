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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
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
        => AsReference("api_key");

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    public TerraformMap<string> AppSettings
        => AsReference("app_settings");

    /// <summary>
    /// The basic_auth attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> BasicAuth
        => AsReference("basic_auth");

    /// <summary>
    /// The configuration_file_changes_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ConfigurationFileChangesEnabled
        => AsReference("configuration_file_changes_enabled");

    /// <summary>
    /// The default_host_name attribute.
    /// </summary>
    public TerraformValue<string> DefaultHostName
        => AsReference("default_host_name");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => AsReference("identity");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The preview_environments_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PreviewEnvironmentsEnabled
        => AsReference("preview_environments_enabled");

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PublicNetworkAccessEnabled
        => AsReference("public_network_access_enabled");

    /// <summary>
    /// The repository_branch attribute.
    /// </summary>
    public TerraformValue<string> RepositoryBranch
        => AsReference("repository_branch");

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    public TerraformValue<string> RepositoryUrl
        => AsReference("repository_url");

    /// <summary>
    /// The sku_size attribute.
    /// </summary>
    public TerraformValue<string> SkuSize
        => AsReference("sku_size");

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    public TerraformValue<string> SkuTier
        => AsReference("sku_tier");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStaticWebAppDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStaticWebAppDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
