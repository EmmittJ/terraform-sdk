using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for basic_auth in .
/// Nesting mode: list
/// </summary>
public class AzurermStaticWebAppBasicAuthBlock : TerraformBlock
{
    /// <summary>
    /// The environments attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environments is required")]
    public required TerraformProperty<string> Environments
    {
        get => GetProperty<TerraformProperty<string>>("environments");
        set => WithProperty("environments", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformProperty<string> Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => WithProperty("password", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermStaticWebAppIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStaticWebAppTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("api_key");
        this.DeclareOutput("default_host_name");
    }

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? AppSettings
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("app_settings");
        set => this.WithProperty("app_settings", value);
    }

    /// <summary>
    /// The configuration_file_changes_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ConfigurationFileChangesEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("configuration_file_changes_enabled");
        set => this.WithProperty("configuration_file_changes_enabled", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The preview_environments_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PreviewEnvironmentsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("preview_environments_enabled");
        set => this.WithProperty("preview_environments_enabled", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The repository_branch attribute.
    /// </summary>
    public TerraformProperty<string>? RepositoryBranch
    {
        get => GetProperty<TerraformProperty<string>>("repository_branch");
        set => this.WithProperty("repository_branch", value);
    }

    /// <summary>
    /// The repository_token attribute.
    /// </summary>
    public TerraformProperty<string>? RepositoryToken
    {
        get => GetProperty<TerraformProperty<string>>("repository_token");
        set => this.WithProperty("repository_token", value);
    }

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    public TerraformProperty<string>? RepositoryUrl
    {
        get => GetProperty<TerraformProperty<string>>("repository_url");
        set => this.WithProperty("repository_url", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku_size attribute.
    /// </summary>
    public TerraformProperty<string>? SkuSize
    {
        get => GetProperty<TerraformProperty<string>>("sku_size");
        set => this.WithProperty("sku_size", value);
    }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    public TerraformProperty<string>? SkuTier
    {
        get => GetProperty<TerraformProperty<string>>("sku_tier");
        set => this.WithProperty("sku_tier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for basic_auth.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BasicAuth block(s) allowed")]
    public List<AzurermStaticWebAppBasicAuthBlock>? BasicAuth
    {
        get => GetProperty<List<AzurermStaticWebAppBasicAuthBlock>>("basic_auth");
        set => this.WithProperty("basic_auth", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermStaticWebAppIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermStaticWebAppIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStaticWebAppTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermStaticWebAppTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The api_key attribute.
    /// </summary>
    public TerraformExpression ApiKey => this["api_key"];

    /// <summary>
    /// The default_host_name attribute.
    /// </summary>
    public TerraformExpression DefaultHostName => this["default_host_name"];

}
