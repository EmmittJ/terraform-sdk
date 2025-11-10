using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageSyncServerEndpointTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_storage_sync_server_endpoint resource.
/// </summary>
public class AzurermStorageSyncServerEndpoint : TerraformResource
{
    public AzurermStorageSyncServerEndpoint(string name) : base("azurerm_storage_sync_server_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cloud_tiering_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CloudTieringEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("cloud_tiering_enabled");
        set => this.WithProperty("cloud_tiering_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The initial_download_policy attribute.
    /// </summary>
    public TerraformProperty<string>? InitialDownloadPolicy
    {
        get => GetProperty<TerraformProperty<string>>("initial_download_policy");
        set => this.WithProperty("initial_download_policy", value);
    }

    /// <summary>
    /// The local_cache_mode attribute.
    /// </summary>
    public TerraformProperty<string>? LocalCacheMode
    {
        get => GetProperty<TerraformProperty<string>>("local_cache_mode");
        set => this.WithProperty("local_cache_mode", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The registered_server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegisteredServerId is required")]
    public required TerraformProperty<string> RegisteredServerId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("registered_server_id");
        set => this.WithProperty("registered_server_id", value);
    }

    /// <summary>
    /// The server_local_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerLocalPath is required")]
    public required TerraformProperty<string> ServerLocalPath
    {
        get => GetRequiredProperty<TerraformProperty<string>>("server_local_path");
        set => this.WithProperty("server_local_path", value);
    }

    /// <summary>
    /// The storage_sync_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageSyncGroupId is required")]
    public required TerraformProperty<string> StorageSyncGroupId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("storage_sync_group_id");
        set => this.WithProperty("storage_sync_group_id", value);
    }

    /// <summary>
    /// The tier_files_older_than_days attribute.
    /// </summary>
    public TerraformProperty<double>? TierFilesOlderThanDays
    {
        get => GetProperty<TerraformProperty<double>>("tier_files_older_than_days");
        set => this.WithProperty("tier_files_older_than_days", value);
    }

    /// <summary>
    /// The volume_free_space_percent attribute.
    /// </summary>
    public TerraformProperty<double>? VolumeFreeSpacePercent
    {
        get => GetProperty<TerraformProperty<double>>("volume_free_space_percent");
        set => this.WithProperty("volume_free_space_percent", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStorageSyncServerEndpointTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermStorageSyncServerEndpointTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
