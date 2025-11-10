using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStaticWebAppDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

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
        SetOutput("api_key");
        SetOutput("app_settings");
        SetOutput("basic_auth");
        SetOutput("configuration_file_changes_enabled");
        SetOutput("default_host_name");
        SetOutput("identity");
        SetOutput("location");
        SetOutput("preview_environments_enabled");
        SetOutput("public_network_access_enabled");
        SetOutput("repository_branch");
        SetOutput("repository_url");
        SetOutput("sku_size");
        SetOutput("sku_tier");
        SetOutput("tags");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStaticWebAppDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
