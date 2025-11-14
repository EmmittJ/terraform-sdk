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
public class AzurermStorageSyncServerEndpointTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

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
    [TerraformArgument("cloud_tiering_enabled")]
    public TerraformValue<bool>? CloudTieringEnabled
    {
        get => new TerraformReference<bool>(this, "cloud_tiering_enabled");
        set => SetArgument("cloud_tiering_enabled", value);
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
    /// The initial_download_policy attribute.
    /// </summary>
    [TerraformArgument("initial_download_policy")]
    public TerraformValue<string>? InitialDownloadPolicy
    {
        get => new TerraformReference<string>(this, "initial_download_policy");
        set => SetArgument("initial_download_policy", value);
    }

    /// <summary>
    /// The local_cache_mode attribute.
    /// </summary>
    [TerraformArgument("local_cache_mode")]
    public TerraformValue<string>? LocalCacheMode
    {
        get => new TerraformReference<string>(this, "local_cache_mode");
        set => SetArgument("local_cache_mode", value);
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
    /// The registered_server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegisteredServerId is required")]
    [TerraformArgument("registered_server_id")]
    public required TerraformValue<string> RegisteredServerId
    {
        get => new TerraformReference<string>(this, "registered_server_id");
        set => SetArgument("registered_server_id", value);
    }

    /// <summary>
    /// The server_local_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerLocalPath is required")]
    [TerraformArgument("server_local_path")]
    public required TerraformValue<string> ServerLocalPath
    {
        get => new TerraformReference<string>(this, "server_local_path");
        set => SetArgument("server_local_path", value);
    }

    /// <summary>
    /// The storage_sync_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageSyncGroupId is required")]
    [TerraformArgument("storage_sync_group_id")]
    public required TerraformValue<string> StorageSyncGroupId
    {
        get => new TerraformReference<string>(this, "storage_sync_group_id");
        set => SetArgument("storage_sync_group_id", value);
    }

    /// <summary>
    /// The tier_files_older_than_days attribute.
    /// </summary>
    [TerraformArgument("tier_files_older_than_days")]
    public TerraformValue<double>? TierFilesOlderThanDays
    {
        get => new TerraformReference<double>(this, "tier_files_older_than_days");
        set => SetArgument("tier_files_older_than_days", value);
    }

    /// <summary>
    /// The volume_free_space_percent attribute.
    /// </summary>
    [TerraformArgument("volume_free_space_percent")]
    public TerraformValue<double>? VolumeFreeSpacePercent
    {
        get => new TerraformReference<double>(this, "volume_free_space_percent");
        set => SetArgument("volume_free_space_percent", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermStorageSyncServerEndpointTimeoutsBlock Timeouts { get; set; } = new();

}
