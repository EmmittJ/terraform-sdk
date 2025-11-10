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
        set => SetProperty("environments", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformProperty<string> Password
    {
        set => SetProperty("password", value);
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
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("api_key");
        SetOutput("default_host_name");
        SetOutput("app_settings");
        SetOutput("configuration_file_changes_enabled");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("preview_environments_enabled");
        SetOutput("public_network_access_enabled");
        SetOutput("repository_branch");
        SetOutput("repository_token");
        SetOutput("repository_url");
        SetOutput("resource_group_name");
        SetOutput("sku_size");
        SetOutput("sku_tier");
        SetOutput("tags");
    }

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> AppSettings
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("app_settings");
        set => SetProperty("app_settings", value);
    }

    /// <summary>
    /// The configuration_file_changes_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ConfigurationFileChangesEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("configuration_file_changes_enabled");
        set => SetProperty("configuration_file_changes_enabled", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The preview_environments_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PreviewEnvironmentsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("preview_environments_enabled");
        set => SetProperty("preview_environments_enabled", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PublicNetworkAccessEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("public_network_access_enabled");
        set => SetProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The repository_branch attribute.
    /// </summary>
    public TerraformProperty<string> RepositoryBranch
    {
        get => GetRequiredOutput<TerraformProperty<string>>("repository_branch");
        set => SetProperty("repository_branch", value);
    }

    /// <summary>
    /// The repository_token attribute.
    /// </summary>
    public TerraformProperty<string> RepositoryToken
    {
        get => GetRequiredOutput<TerraformProperty<string>>("repository_token");
        set => SetProperty("repository_token", value);
    }

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    public TerraformProperty<string> RepositoryUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("repository_url");
        set => SetProperty("repository_url", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku_size attribute.
    /// </summary>
    public TerraformProperty<string> SkuSize
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku_size");
        set => SetProperty("sku_size", value);
    }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    public TerraformProperty<string> SkuTier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku_tier");
        set => SetProperty("sku_tier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for basic_auth.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BasicAuth block(s) allowed")]
    public List<AzurermStaticWebAppBasicAuthBlock>? BasicAuth
    {
        set => SetProperty("basic_auth", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermStaticWebAppIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStaticWebAppTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
