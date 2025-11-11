using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageSyncServerEndpointTimeoutsBlock
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
/// Manages a azurerm_storage_sync_server_endpoint resource.
/// </summary>
public class AzurermStorageSyncServerEndpoint : TerraformResource
{
    public AzurermStorageSyncServerEndpoint(string name) : base("azurerm_storage_sync_server_endpoint", name)
    {
    }

    /// <summary>
    /// The cloud_tiering_enabled attribute.
    /// </summary>
    [TerraformPropertyName("cloud_tiering_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CloudTieringEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The initial_download_policy attribute.
    /// </summary>
    [TerraformPropertyName("initial_download_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InitialDownloadPolicy { get; set; }

    /// <summary>
    /// The local_cache_mode attribute.
    /// </summary>
    [TerraformPropertyName("local_cache_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LocalCacheMode { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The registered_server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegisteredServerId is required")]
    [TerraformPropertyName("registered_server_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RegisteredServerId { get; set; }

    /// <summary>
    /// The server_local_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerLocalPath is required")]
    [TerraformPropertyName("server_local_path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ServerLocalPath { get; set; }

    /// <summary>
    /// The storage_sync_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageSyncGroupId is required")]
    [TerraformPropertyName("storage_sync_group_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StorageSyncGroupId { get; set; }

    /// <summary>
    /// The tier_files_older_than_days attribute.
    /// </summary>
    [TerraformPropertyName("tier_files_older_than_days")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TierFilesOlderThanDays { get; set; }

    /// <summary>
    /// The volume_free_space_percent attribute.
    /// </summary>
    [TerraformPropertyName("volume_free_space_percent")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? VolumeFreeSpacePercent { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermStorageSyncServerEndpointTimeoutsBlock>? Timeouts { get; set; }

}
