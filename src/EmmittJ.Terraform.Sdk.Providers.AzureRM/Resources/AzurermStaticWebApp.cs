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
    public Dictionary<string, string>? AppSettings
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("app_settings")?.Value;
        set => this.WithProperty("app_settings", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The configuration_file_changes_enabled attribute.
    /// </summary>
    public bool? ConfigurationFileChangesEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("configuration_file_changes_enabled")?.Value;
        set => this.WithProperty("configuration_file_changes_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The preview_environments_enabled attribute.
    /// </summary>
    public bool? PreviewEnvironmentsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("preview_environments_enabled")?.Value;
        set => this.WithProperty("preview_environments_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public bool? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("public_network_access_enabled")?.Value;
        set => this.WithProperty("public_network_access_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The repository_branch attribute.
    /// </summary>
    public string? RepositoryBranch
    {
        get => GetProperty<TerraformLiteralProperty<string>>("repository_branch")?.Value;
        set => this.WithProperty("repository_branch", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The repository_token attribute.
    /// </summary>
    public string? RepositoryToken
    {
        get => GetProperty<TerraformLiteralProperty<string>>("repository_token")?.Value;
        set => this.WithProperty("repository_token", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    public string? RepositoryUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("repository_url")?.Value;
        set => this.WithProperty("repository_url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sku_size attribute.
    /// </summary>
    public string? SkuSize
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku_size")?.Value;
        set => this.WithProperty("sku_size", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    public string? SkuTier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku_tier")?.Value;
        set => this.WithProperty("sku_tier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
