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
/// Block type for basic_auth in .
/// Nesting mode: list
/// </summary>
public class AzurermStaticWebAppBasicAuthBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "basic_auth";

    /// <summary>
    /// The environments attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environments is required")]
    [TerraformArgument("environments")]
    public required TerraformValue<string> Environments
    {
        get => new TerraformReference<string>(this, "environments");
        set => SetArgument("environments", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformArgument("password")]
    public required TerraformValue<string> Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermStaticWebAppIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformArgument("identity_ids")]
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStaticWebAppTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_static_web_app resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermStaticWebApp : TerraformResource
{
    public AzurermStaticWebApp(string name) : base("azurerm_static_web_app", name)
    {
    }

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    [TerraformArgument("app_settings")]
    public TerraformMap<string>? AppSettings
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "app_settings").ResolveNodes(ctx));
        set => SetArgument("app_settings", value);
    }

    /// <summary>
    /// The configuration_file_changes_enabled attribute.
    /// </summary>
    [TerraformArgument("configuration_file_changes_enabled")]
    public TerraformValue<bool>? ConfigurationFileChangesEnabled
    {
        get => new TerraformReference<bool>(this, "configuration_file_changes_enabled");
        set => SetArgument("configuration_file_changes_enabled", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The preview_environments_enabled attribute.
    /// </summary>
    [TerraformArgument("preview_environments_enabled")]
    public TerraformValue<bool>? PreviewEnvironmentsEnabled
    {
        get => new TerraformReference<bool>(this, "preview_environments_enabled");
        set => SetArgument("preview_environments_enabled", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformArgument("public_network_access_enabled")]
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The repository_branch attribute.
    /// </summary>
    [TerraformArgument("repository_branch")]
    public TerraformValue<string>? RepositoryBranch
    {
        get => new TerraformReference<string>(this, "repository_branch");
        set => SetArgument("repository_branch", value);
    }

    /// <summary>
    /// The repository_token attribute.
    /// </summary>
    [TerraformArgument("repository_token")]
    public TerraformValue<string>? RepositoryToken
    {
        get => new TerraformReference<string>(this, "repository_token");
        set => SetArgument("repository_token", value);
    }

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    [TerraformArgument("repository_url")]
    public TerraformValue<string>? RepositoryUrl
    {
        get => new TerraformReference<string>(this, "repository_url");
        set => SetArgument("repository_url", value);
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
    /// The sku_size attribute.
    /// </summary>
    [TerraformArgument("sku_size")]
    public TerraformValue<string>? SkuSize
    {
        get => new TerraformReference<string>(this, "sku_size");
        set => SetArgument("sku_size", value);
    }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    [TerraformArgument("sku_tier")]
    public TerraformValue<string>? SkuTier
    {
        get => new TerraformReference<string>(this, "sku_tier");
        set => SetArgument("sku_tier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for basic_auth.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BasicAuth block(s) allowed")]
    [TerraformArgument("basic_auth")]
    public TerraformList<AzurermStaticWebAppBasicAuthBlock> BasicAuth { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermStaticWebAppIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermStaticWebAppTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The api_key attribute.
    /// </summary>
    [TerraformArgument("api_key")]
    public TerraformValue<string> ApiKey
    {
        get => new TerraformReference<string>(this, "api_key");
    }

    /// <summary>
    /// The default_host_name attribute.
    /// </summary>
    [TerraformArgument("default_host_name")]
    public TerraformValue<string> DefaultHostName
    {
        get => new TerraformReference<string>(this, "default_host_name");
    }

}
