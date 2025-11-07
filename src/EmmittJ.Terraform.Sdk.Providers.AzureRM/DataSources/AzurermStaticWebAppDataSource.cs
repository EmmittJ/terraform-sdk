using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_static_web_app.
/// </summary>
public class AzurermStaticWebAppDataSource : TerraformDataSource
{
    public AzurermStaticWebAppDataSource(string name) : base("azurerm_static_web_app", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("api_key");
        this.DeclareOutput("app_settings");
        this.DeclareOutput("basic_auth");
        this.DeclareOutput("configuration_file_changes_enabled");
        this.DeclareOutput("default_host_name");
        this.DeclareOutput("identity");
        this.DeclareOutput("location");
        this.DeclareOutput("preview_environments_enabled");
        this.DeclareOutput("public_network_access_enabled");
        this.DeclareOutput("repository_branch");
        this.DeclareOutput("repository_url");
        this.DeclareOutput("sku_size");
        this.DeclareOutput("sku_tier");
        this.DeclareOutput("tags");
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The api_key attribute.
    /// </summary>
    public TerraformExpression ApiKey => this["api_key"];

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    public TerraformExpression AppSettings => this["app_settings"];

    /// <summary>
    /// The basic_auth attribute.
    /// </summary>
    public TerraformExpression BasicAuth => this["basic_auth"];

    /// <summary>
    /// The configuration_file_changes_enabled attribute.
    /// </summary>
    public TerraformExpression ConfigurationFileChangesEnabled => this["configuration_file_changes_enabled"];

    /// <summary>
    /// The default_host_name attribute.
    /// </summary>
    public TerraformExpression DefaultHostName => this["default_host_name"];

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The preview_environments_enabled attribute.
    /// </summary>
    public TerraformExpression PreviewEnvironmentsEnabled => this["preview_environments_enabled"];

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformExpression PublicNetworkAccessEnabled => this["public_network_access_enabled"];

    /// <summary>
    /// The repository_branch attribute.
    /// </summary>
    public TerraformExpression RepositoryBranch => this["repository_branch"];

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    public TerraformExpression RepositoryUrl => this["repository_url"];

    /// <summary>
    /// The sku_size attribute.
    /// </summary>
    public TerraformExpression SkuSize => this["sku_size"];

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    public TerraformExpression SkuTier => this["sku_tier"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
