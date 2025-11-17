using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermFunctionAppHostKeysDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermFunctionAppHostKeysDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_function_app_host_keys Terraform data source.
/// Retrieves information about a azurerm_function_app_host_keys.
/// </summary>
public partial class AzurermFunctionAppHostKeysDataSource(string name) : TerraformDataSource("azurerm_function_app_host_keys", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The blobs_extension_key attribute.
    /// </summary>
    public TerraformValue<string> BlobsExtensionKey
    {
        get => new TerraformReference<string>(this, "blobs_extension_key");
    }

    /// <summary>
    /// The default_function_key attribute.
    /// </summary>
    public TerraformValue<string> DefaultFunctionKey
    {
        get => new TerraformReference<string>(this, "default_function_key");
    }

    /// <summary>
    /// The durabletask_extension_key attribute.
    /// </summary>
    public TerraformValue<string> DurabletaskExtensionKey
    {
        get => new TerraformReference<string>(this, "durabletask_extension_key");
    }

    /// <summary>
    /// The event_grid_extension_config_key attribute.
    /// </summary>
    public TerraformValue<string> EventGridExtensionConfigKey
    {
        get => new TerraformReference<string>(this, "event_grid_extension_config_key");
    }

    /// <summary>
    /// The event_grid_extension_key attribute.
    /// </summary>
    public TerraformValue<string> EventGridExtensionKey
    {
        get => new TerraformReference<string>(this, "event_grid_extension_key");
    }

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    public TerraformValue<string> PrimaryKey
    {
        get => new TerraformReference<string>(this, "primary_key");
    }

    /// <summary>
    /// The signalr_extension_key attribute.
    /// </summary>
    public TerraformValue<string> SignalrExtensionKey
    {
        get => new TerraformReference<string>(this, "signalr_extension_key");
    }

    /// <summary>
    /// The webpubsub_extension_key attribute.
    /// </summary>
    public TerraformValue<string> WebpubsubExtensionKey
    {
        get => new TerraformReference<string>(this, "webpubsub_extension_key");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermFunctionAppHostKeysDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermFunctionAppHostKeysDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
