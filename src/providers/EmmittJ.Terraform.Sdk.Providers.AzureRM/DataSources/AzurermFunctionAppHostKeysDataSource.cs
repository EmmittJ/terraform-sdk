using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFunctionAppHostKeysDataSourceTimeoutsBlock : TerraformBlock
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
        SetOutput("blobs_extension_key");
        SetOutput("default_function_key");
        SetOutput("durabletask_extension_key");
        SetOutput("event_grid_extension_config_key");
        SetOutput("event_grid_extension_key");
        SetOutput("primary_key");
        SetOutput("signalr_extension_key");
        SetOutput("webpubsub_extension_key");
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
    public AzurermFunctionAppHostKeysDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
