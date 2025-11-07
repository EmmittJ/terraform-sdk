using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_static_web_app resource.
/// </summary>
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
    public TerraformProperty<Dictionary<string, string>>? AppSettings
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("app_settings");
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
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
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
    public TerraformProperty<string>? ResourceGroupName
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
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
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
