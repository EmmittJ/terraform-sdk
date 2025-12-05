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
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The blobs_extension_key attribute.
    /// </summary>
    public TerraformValue<string> BlobsExtensionKey
        => CreateReference("blobs_extension_key");

    /// <summary>
    /// The default_function_key attribute.
    /// </summary>
    public TerraformValue<string> DefaultFunctionKey
        => CreateReference("default_function_key");

    /// <summary>
    /// The durabletask_extension_key attribute.
    /// </summary>
    public TerraformValue<string> DurabletaskExtensionKey
        => CreateReference("durabletask_extension_key");

    /// <summary>
    /// The event_grid_extension_config_key attribute.
    /// </summary>
    public TerraformValue<string> EventGridExtensionConfigKey
        => CreateReference("event_grid_extension_config_key");

    /// <summary>
    /// The event_grid_extension_key attribute.
    /// </summary>
    public TerraformValue<string> EventGridExtensionKey
        => CreateReference("event_grid_extension_key");

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    public TerraformValue<string> PrimaryKey
        => CreateReference("primary_key");

    /// <summary>
    /// The signalr_extension_key attribute.
    /// </summary>
    public TerraformValue<string> SignalrExtensionKey
        => CreateReference("signalr_extension_key");

    /// <summary>
    /// The webpubsub_extension_key attribute.
    /// </summary>
    public TerraformValue<string> WebpubsubExtensionKey
        => CreateReference("webpubsub_extension_key");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermFunctionAppHostKeysDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermFunctionAppHostKeysDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
