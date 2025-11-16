using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "read");
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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The api_key attribute.
    /// </summary>
    public TerraformValue<string> ApiKey
    {
        get => new TerraformReference<string>(this, "api_key");
    }

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    public TerraformMap<string> AppSettings
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "app_settings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The basic_auth attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> BasicAuth
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "basic_auth").ResolveNodes(ctx));
    }

    /// <summary>
    /// The configuration_file_changes_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ConfigurationFileChangesEnabled
    {
        get => new TerraformReference<bool>(this, "configuration_file_changes_enabled");
    }

    /// <summary>
    /// The default_host_name attribute.
    /// </summary>
    public TerraformValue<string> DefaultHostName
    {
        get => new TerraformReference<string>(this, "default_host_name");
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The preview_environments_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PreviewEnvironmentsEnabled
    {
        get => new TerraformReference<bool>(this, "preview_environments_enabled");
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
    }

    /// <summary>
    /// The repository_branch attribute.
    /// </summary>
    public TerraformValue<string> RepositoryBranch
    {
        get => new TerraformReference<string>(this, "repository_branch");
    }

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    public TerraformValue<string> RepositoryUrl
    {
        get => new TerraformReference<string>(this, "repository_url");
    }

    /// <summary>
    /// The sku_size attribute.
    /// </summary>
    public TerraformValue<string> SkuSize
    {
        get => new TerraformReference<string>(this, "sku_size");
    }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    public TerraformValue<string> SkuTier
    {
        get => new TerraformReference<string>(this, "sku_tier");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStaticWebAppDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStaticWebAppDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
