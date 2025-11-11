using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermContainerAppEnvironmentStorageTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_container_app_environment_storage resource.
/// </summary>
public partial class AzurermContainerAppEnvironmentStorage : TerraformResource
{
    public AzurermContainerAppEnvironmentStorage(string name) : base("azurerm_container_app_environment_storage", name)
    {
    }

    /// <summary>
    /// The Storage Account Access Key.
    /// </summary>
    [TerraformProperty("access_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AccessKey { get; set; }

    /// <summary>
    /// The access mode to connect this storage to the Container App. Possible values include `ReadOnly` and `ReadWrite`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessMode is required")]
    [TerraformProperty("access_mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AccessMode { get; set; }

    /// <summary>
    /// The Azure Storage Account in which the Share to be used is located.
    /// </summary>
    [TerraformProperty("account_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AccountName { get; set; }

    /// <summary>
    /// The ID of the Container App Environment to which this storage belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerAppEnvironmentId is required")]
    [TerraformProperty("container_app_environment_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ContainerAppEnvironmentId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name for this Storage.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The nfs_server_url attribute.
    /// </summary>
    [TerraformProperty("nfs_server_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NfsServerUrl { get; set; }

    /// <summary>
    /// The name of the Azure Storage Share to use.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareName is required")]
    [TerraformProperty("share_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ShareName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermContainerAppEnvironmentStorageTimeoutsBlock>? Timeouts { get; set; }

}
