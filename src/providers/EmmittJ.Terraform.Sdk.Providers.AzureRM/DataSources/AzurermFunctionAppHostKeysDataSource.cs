using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFunctionAppHostKeysDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermFunctionAppHostKeysDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The blobs_extension_key attribute.
    /// </summary>
    [TerraformPropertyName("blobs_extension_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BlobsExtensionKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "blobs_extension_key");

    /// <summary>
    /// The default_function_key attribute.
    /// </summary>
    [TerraformPropertyName("default_function_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultFunctionKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_function_key");

    /// <summary>
    /// The durabletask_extension_key attribute.
    /// </summary>
    [TerraformPropertyName("durabletask_extension_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DurabletaskExtensionKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "durabletask_extension_key");

    /// <summary>
    /// The event_grid_extension_config_key attribute.
    /// </summary>
    [TerraformPropertyName("event_grid_extension_config_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EventGridExtensionConfigKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "event_grid_extension_config_key");

    /// <summary>
    /// The event_grid_extension_key attribute.
    /// </summary>
    [TerraformPropertyName("event_grid_extension_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EventGridExtensionKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "event_grid_extension_key");

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    [TerraformPropertyName("primary_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_key");

    /// <summary>
    /// The signalr_extension_key attribute.
    /// </summary>
    [TerraformPropertyName("signalr_extension_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SignalrExtensionKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "signalr_extension_key");

    /// <summary>
    /// The webpubsub_extension_key attribute.
    /// </summary>
    [TerraformPropertyName("webpubsub_extension_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WebpubsubExtensionKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "webpubsub_extension_key");

}
