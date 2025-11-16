using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_storage_sync_server_endpoint Terraform resource.
/// Manages a azurerm_storage_sync_server_endpoint resource.
/// </summary>
public partial class AzurermStorageSyncServerEndpoint(string name) : TerraformResource("azurerm_storage_sync_server_endpoint", name)
{
    /// <summary>
    /// The cloud_tiering_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? CloudTieringEnabled
    {
        get => new TerraformReference<bool>(this, "cloud_tiering_enabled");
        set => SetArgument("cloud_tiering_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The initial_download_policy attribute.
    /// </summary>
    public TerraformValue<string>? InitialDownloadPolicy
    {
        get => new TerraformReference<string>(this, "initial_download_policy");
        set => SetArgument("initial_download_policy", value);
    }

    /// <summary>
    /// The local_cache_mode attribute.
    /// </summary>
    public TerraformValue<string>? LocalCacheMode
    {
        get => new TerraformReference<string>(this, "local_cache_mode");
        set => SetArgument("local_cache_mode", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The registered_server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegisteredServerId is required")]
    public required TerraformValue<string> RegisteredServerId
    {
        get => new TerraformReference<string>(this, "registered_server_id");
        set => SetArgument("registered_server_id", value);
    }

    /// <summary>
    /// The server_local_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerLocalPath is required")]
    public required TerraformValue<string> ServerLocalPath
    {
        get => new TerraformReference<string>(this, "server_local_path");
        set => SetArgument("server_local_path", value);
    }

    /// <summary>
    /// The storage_sync_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageSyncGroupId is required")]
    public required TerraformValue<string> StorageSyncGroupId
    {
        get => new TerraformReference<string>(this, "storage_sync_group_id");
        set => SetArgument("storage_sync_group_id", value);
    }

    /// <summary>
    /// The tier_files_older_than_days attribute.
    /// </summary>
    public TerraformValue<double>? TierFilesOlderThanDays
    {
        get => new TerraformReference<double>(this, "tier_files_older_than_days");
        set => SetArgument("tier_files_older_than_days", value);
    }

    /// <summary>
    /// The volume_free_space_percent attribute.
    /// </summary>
    public TerraformValue<double>? VolumeFreeSpacePercent
    {
        get => new TerraformReference<double>(this, "volume_free_space_percent");
        set => SetArgument("volume_free_space_percent", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStorageSyncServerEndpointTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStorageSyncServerEndpointTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
