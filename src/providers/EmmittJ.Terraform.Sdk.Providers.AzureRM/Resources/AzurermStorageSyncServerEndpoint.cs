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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("cloud_tiering_enabled");
        SetOutput("id");
        SetOutput("initial_download_policy");
        SetOutput("local_cache_mode");
        SetOutput("name");
        SetOutput("registered_server_id");
        SetOutput("server_local_path");
        SetOutput("storage_sync_group_id");
        SetOutput("tier_files_older_than_days");
        SetOutput("volume_free_space_percent");
    }

    /// <summary>
    /// The cloud_tiering_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> CloudTieringEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("cloud_tiering_enabled");
        set => SetProperty("cloud_tiering_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The initial_download_policy attribute.
    /// </summary>
    public TerraformProperty<string> InitialDownloadPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("initial_download_policy");
        set => SetProperty("initial_download_policy", value);
    }

    /// <summary>
    /// The local_cache_mode attribute.
    /// </summary>
    public TerraformProperty<string> LocalCacheMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("local_cache_mode");
        set => SetProperty("local_cache_mode", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The registered_server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegisteredServerId is required")]
    public required TerraformProperty<string> RegisteredServerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("registered_server_id");
        set => SetProperty("registered_server_id", value);
    }

    /// <summary>
    /// The server_local_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerLocalPath is required")]
    public required TerraformProperty<string> ServerLocalPath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("server_local_path");
        set => SetProperty("server_local_path", value);
    }

    /// <summary>
    /// The storage_sync_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageSyncGroupId is required")]
    public required TerraformProperty<string> StorageSyncGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_sync_group_id");
        set => SetProperty("storage_sync_group_id", value);
    }

    /// <summary>
    /// The tier_files_older_than_days attribute.
    /// </summary>
    public TerraformProperty<double> TierFilesOlderThanDays
    {
        get => GetRequiredOutput<TerraformProperty<double>>("tier_files_older_than_days");
        set => SetProperty("tier_files_older_than_days", value);
    }

    /// <summary>
    /// The volume_free_space_percent attribute.
    /// </summary>
    public TerraformProperty<double> VolumeFreeSpacePercent
    {
        get => GetRequiredOutput<TerraformProperty<double>>("volume_free_space_percent");
        set => SetProperty("volume_free_space_percent", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStorageSyncServerEndpointTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
