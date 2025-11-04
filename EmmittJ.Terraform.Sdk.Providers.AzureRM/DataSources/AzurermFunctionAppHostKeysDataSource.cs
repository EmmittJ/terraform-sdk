using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_function_app_host_keys.
/// </summary>
public class AzurermFunctionAppHostKeysDataSource : TerraformDataSource
{
    public AzurermFunctionAppHostKeysDataSource(string name) : base("azurerm_function_app_host_keys", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("blobs_extension_key");
        this.DeclareOutput("default_function_key");
        this.DeclareOutput("durabletask_extension_key");
        this.DeclareOutput("event_grid_extension_config_key");
        this.DeclareOutput("event_grid_extension_key");
        this.DeclareOutput("primary_key");
        this.DeclareOutput("signalr_extension_key");
        this.DeclareOutput("webpubsub_extension_key");
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The blobs_extension_key attribute.
    /// </summary>
    public TerraformExpression BlobsExtensionKey => this["blobs_extension_key"];

    /// <summary>
    /// The default_function_key attribute.
    /// </summary>
    public TerraformExpression DefaultFunctionKey => this["default_function_key"];

    /// <summary>
    /// The durabletask_extension_key attribute.
    /// </summary>
    public TerraformExpression DurabletaskExtensionKey => this["durabletask_extension_key"];

    /// <summary>
    /// The event_grid_extension_config_key attribute.
    /// </summary>
    public TerraformExpression EventGridExtensionConfigKey => this["event_grid_extension_config_key"];

    /// <summary>
    /// The event_grid_extension_key attribute.
    /// </summary>
    public TerraformExpression EventGridExtensionKey => this["event_grid_extension_key"];

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    public TerraformExpression PrimaryKey => this["primary_key"];

    /// <summary>
    /// The signalr_extension_key attribute.
    /// </summary>
    public TerraformExpression SignalrExtensionKey => this["signalr_extension_key"];

    /// <summary>
    /// The webpubsub_extension_key attribute.
    /// </summary>
    public TerraformExpression WebpubsubExtensionKey => this["webpubsub_extension_key"];

}
