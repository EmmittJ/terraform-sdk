using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_function_app_host_keys.
/// </summary>
public class AzurermFunctionAppHostKeysDataSource : TerraformDataSource
{
    public AzurermFunctionAppHostKeysDataSource(string name) : base("azurerm_function_app_host_keys", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermFunctionAppHostKeysDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The blobs_extension_key attribute.
    /// </summary>
    [TerraformArgument("blobs_extension_key")]
    public TerraformValue<string> BlobsExtensionKey
    {
        get => new TerraformReference<string>(this, "blobs_extension_key");
    }

    /// <summary>
    /// The default_function_key attribute.
    /// </summary>
    [TerraformArgument("default_function_key")]
    public TerraformValue<string> DefaultFunctionKey
    {
        get => new TerraformReference<string>(this, "default_function_key");
    }

    /// <summary>
    /// The durabletask_extension_key attribute.
    /// </summary>
    [TerraformArgument("durabletask_extension_key")]
    public TerraformValue<string> DurabletaskExtensionKey
    {
        get => new TerraformReference<string>(this, "durabletask_extension_key");
    }

    /// <summary>
    /// The event_grid_extension_config_key attribute.
    /// </summary>
    [TerraformArgument("event_grid_extension_config_key")]
    public TerraformValue<string> EventGridExtensionConfigKey
    {
        get => new TerraformReference<string>(this, "event_grid_extension_config_key");
    }

    /// <summary>
    /// The event_grid_extension_key attribute.
    /// </summary>
    [TerraformArgument("event_grid_extension_key")]
    public TerraformValue<string> EventGridExtensionKey
    {
        get => new TerraformReference<string>(this, "event_grid_extension_key");
    }

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    [TerraformArgument("primary_key")]
    public TerraformValue<string> PrimaryKey
    {
        get => new TerraformReference<string>(this, "primary_key");
    }

    /// <summary>
    /// The signalr_extension_key attribute.
    /// </summary>
    [TerraformArgument("signalr_extension_key")]
    public TerraformValue<string> SignalrExtensionKey
    {
        get => new TerraformReference<string>(this, "signalr_extension_key");
    }

    /// <summary>
    /// The webpubsub_extension_key attribute.
    /// </summary>
    [TerraformArgument("webpubsub_extension_key")]
    public TerraformValue<string> WebpubsubExtensionKey
    {
        get => new TerraformReference<string>(this, "webpubsub_extension_key");
    }

}
