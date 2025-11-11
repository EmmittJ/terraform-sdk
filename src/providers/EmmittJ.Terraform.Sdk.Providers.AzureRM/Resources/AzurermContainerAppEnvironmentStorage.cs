using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerAppEnvironmentStorageTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_container_app_environment_storage resource.
/// </summary>
public class AzurermContainerAppEnvironmentStorage : TerraformResource
{
    public AzurermContainerAppEnvironmentStorage(string name) : base("azurerm_container_app_environment_storage", name)
    {
    }

    /// <summary>
    /// The Storage Account Access Key.
    /// </summary>
    [TerraformPropertyName("access_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AccessKey { get; set; }

    /// <summary>
    /// The access mode to connect this storage to the Container App. Possible values include `ReadOnly` and `ReadWrite`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessMode is required")]
    [TerraformPropertyName("access_mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AccessMode { get; set; }

    /// <summary>
    /// The Azure Storage Account in which the Share to be used is located.
    /// </summary>
    [TerraformPropertyName("account_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AccountName { get; set; }

    /// <summary>
    /// The ID of the Container App Environment to which this storage belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerAppEnvironmentId is required")]
    [TerraformPropertyName("container_app_environment_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ContainerAppEnvironmentId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name for this Storage.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The nfs_server_url attribute.
    /// </summary>
    [TerraformPropertyName("nfs_server_url")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NfsServerUrl { get; set; }

    /// <summary>
    /// The name of the Azure Storage Share to use.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareName is required")]
    [TerraformPropertyName("share_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ShareName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermContainerAppEnvironmentStorageTimeoutsBlock>? Timeouts { get; set; }

}
