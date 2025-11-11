using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermFunctionAppHostKeysDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_function_app_host_keys.
/// </summary>
public partial class AzurermFunctionAppHostKeysDataSource : TerraformDataSource
{
    public AzurermFunctionAppHostKeysDataSource(string name) : base("azurerm_function_app_host_keys", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermFunctionAppHostKeysDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The blobs_extension_key attribute.
    /// </summary>
    [TerraformProperty("blobs_extension_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BlobsExtensionKey { get; }

    /// <summary>
    /// The default_function_key attribute.
    /// </summary>
    [TerraformProperty("default_function_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultFunctionKey { get; }

    /// <summary>
    /// The durabletask_extension_key attribute.
    /// </summary>
    [TerraformProperty("durabletask_extension_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DurabletaskExtensionKey { get; }

    /// <summary>
    /// The event_grid_extension_config_key attribute.
    /// </summary>
    [TerraformProperty("event_grid_extension_config_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EventGridExtensionConfigKey { get; }

    /// <summary>
    /// The event_grid_extension_key attribute.
    /// </summary>
    [TerraformProperty("event_grid_extension_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EventGridExtensionKey { get; }

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    [TerraformProperty("primary_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryKey { get; }

    /// <summary>
    /// The signalr_extension_key attribute.
    /// </summary>
    [TerraformProperty("signalr_extension_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SignalrExtensionKey { get; }

    /// <summary>
    /// The webpubsub_extension_key attribute.
    /// </summary>
    [TerraformProperty("webpubsub_extension_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> WebpubsubExtensionKey { get; }

}
