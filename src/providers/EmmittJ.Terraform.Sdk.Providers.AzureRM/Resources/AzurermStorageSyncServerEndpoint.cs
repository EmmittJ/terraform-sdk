using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermStorageSyncServerEndpointTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_storage_sync_server_endpoint resource.
/// </summary>
public partial class AzurermStorageSyncServerEndpoint : TerraformResource
{
    public AzurermStorageSyncServerEndpoint(string name) : base("azurerm_storage_sync_server_endpoint", name)
    {
    }

    /// <summary>
    /// The cloud_tiering_enabled attribute.
    /// </summary>
    [TerraformProperty("cloud_tiering_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CloudTieringEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The initial_download_policy attribute.
    /// </summary>
    [TerraformProperty("initial_download_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InitialDownloadPolicy { get; set; }

    /// <summary>
    /// The local_cache_mode attribute.
    /// </summary>
    [TerraformProperty("local_cache_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LocalCacheMode { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The registered_server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegisteredServerId is required")]
    [TerraformProperty("registered_server_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RegisteredServerId { get; set; }

    /// <summary>
    /// The server_local_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerLocalPath is required")]
    [TerraformProperty("server_local_path")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServerLocalPath { get; set; }

    /// <summary>
    /// The storage_sync_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageSyncGroupId is required")]
    [TerraformProperty("storage_sync_group_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StorageSyncGroupId { get; set; }

    /// <summary>
    /// The tier_files_older_than_days attribute.
    /// </summary>
    [TerraformProperty("tier_files_older_than_days")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TierFilesOlderThanDays { get; set; }

    /// <summary>
    /// The volume_free_space_percent attribute.
    /// </summary>
    [TerraformProperty("volume_free_space_percent")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? VolumeFreeSpacePercent { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermStorageSyncServerEndpointTimeoutsBlock Timeouts { get; set; } = new();

}
