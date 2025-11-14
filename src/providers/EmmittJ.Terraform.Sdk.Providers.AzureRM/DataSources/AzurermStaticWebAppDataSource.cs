using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_static_web_app.
/// </summary>
public class AzurermStaticWebAppDataSource : TerraformDataSource
{
    public AzurermStaticWebAppDataSource(string name) : base("azurerm_static_web_app", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermStaticWebAppDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The api_key attribute.
    /// </summary>
    [TerraformArgument("api_key")]
    public TerraformValue<string> ApiKey
    {
        get => new TerraformReference<string>(this, "api_key");
    }

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    [TerraformArgument("app_settings")]
    public TerraformMap<string> AppSettings
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "app_settings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The basic_auth attribute.
    /// </summary>
    [TerraformArgument("basic_auth")]
    public TerraformList<object> BasicAuth
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "basic_auth").ResolveNodes(ctx));
    }

    /// <summary>
    /// The configuration_file_changes_enabled attribute.
    /// </summary>
    [TerraformArgument("configuration_file_changes_enabled")]
    public TerraformValue<bool> ConfigurationFileChangesEnabled
    {
        get => new TerraformReference<bool>(this, "configuration_file_changes_enabled");
    }

    /// <summary>
    /// The default_host_name attribute.
    /// </summary>
    [TerraformArgument("default_host_name")]
    public TerraformValue<string> DefaultHostName
    {
        get => new TerraformReference<string>(this, "default_host_name");
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformArgument("identity")]
    public TerraformList<object> Identity
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The preview_environments_enabled attribute.
    /// </summary>
    [TerraformArgument("preview_environments_enabled")]
    public TerraformValue<bool> PreviewEnvironmentsEnabled
    {
        get => new TerraformReference<bool>(this, "preview_environments_enabled");
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformArgument("public_network_access_enabled")]
    public TerraformValue<bool> PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
    }

    /// <summary>
    /// The repository_branch attribute.
    /// </summary>
    [TerraformArgument("repository_branch")]
    public TerraformValue<string> RepositoryBranch
    {
        get => new TerraformReference<string>(this, "repository_branch");
    }

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    [TerraformArgument("repository_url")]
    public TerraformValue<string> RepositoryUrl
    {
        get => new TerraformReference<string>(this, "repository_url");
    }

    /// <summary>
    /// The sku_size attribute.
    /// </summary>
    [TerraformArgument("sku_size")]
    public TerraformValue<string> SkuSize
    {
        get => new TerraformReference<string>(this, "sku_size");
    }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    [TerraformArgument("sku_tier")]
    public TerraformValue<string> SkuTier
    {
        get => new TerraformReference<string>(this, "sku_tier");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

}
