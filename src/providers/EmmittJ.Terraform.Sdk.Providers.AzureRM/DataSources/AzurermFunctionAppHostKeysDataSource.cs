using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFunctionAppHostKeysDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermFunctionAppHostKeysDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The blobs_extension_key attribute.
    /// </summary>
    [TerraformPropertyName("blobs_extension_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BlobsExtensionKey => new TerraformReference(this, "blobs_extension_key");

    /// <summary>
    /// The default_function_key attribute.
    /// </summary>
    [TerraformPropertyName("default_function_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultFunctionKey => new TerraformReference(this, "default_function_key");

    /// <summary>
    /// The durabletask_extension_key attribute.
    /// </summary>
    [TerraformPropertyName("durabletask_extension_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DurabletaskExtensionKey => new TerraformReference(this, "durabletask_extension_key");

    /// <summary>
    /// The event_grid_extension_config_key attribute.
    /// </summary>
    [TerraformPropertyName("event_grid_extension_config_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EventGridExtensionConfigKey => new TerraformReference(this, "event_grid_extension_config_key");

    /// <summary>
    /// The event_grid_extension_key attribute.
    /// </summary>
    [TerraformPropertyName("event_grid_extension_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EventGridExtensionKey => new TerraformReference(this, "event_grid_extension_key");

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    [TerraformPropertyName("primary_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryKey => new TerraformReference(this, "primary_key");

    /// <summary>
    /// The signalr_extension_key attribute.
    /// </summary>
    [TerraformPropertyName("signalr_extension_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SignalrExtensionKey => new TerraformReference(this, "signalr_extension_key");

    /// <summary>
    /// The webpubsub_extension_key attribute.
    /// </summary>
    [TerraformPropertyName("webpubsub_extension_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> WebpubsubExtensionKey => new TerraformReference(this, "webpubsub_extension_key");

}
