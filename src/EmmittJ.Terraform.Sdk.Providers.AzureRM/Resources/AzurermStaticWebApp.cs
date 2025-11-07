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
    public TerraformLiteralProperty<Dictionary<string, string>>? AppSettings
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("app_settings");
        set => this.WithProperty("app_settings", value);
    }

    /// <summary>
    /// The configuration_file_changes_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ConfigurationFileChangesEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("configuration_file_changes_enabled");
        set => this.WithProperty("configuration_file_changes_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The preview_environments_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? PreviewEnvironmentsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("preview_environments_enabled");
        set => this.WithProperty("preview_environments_enabled", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The repository_branch attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RepositoryBranch
    {
        get => GetProperty<TerraformLiteralProperty<string>>("repository_branch");
        set => this.WithProperty("repository_branch", value);
    }

    /// <summary>
    /// The repository_token attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RepositoryToken
    {
        get => GetProperty<TerraformLiteralProperty<string>>("repository_token");
        set => this.WithProperty("repository_token", value);
    }

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RepositoryUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("repository_url");
        set => this.WithProperty("repository_url", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku_size attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SkuSize
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku_size");
        set => this.WithProperty("sku_size", value);
    }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SkuTier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku_tier");
        set => this.WithProperty("sku_tier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
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
