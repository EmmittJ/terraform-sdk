using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public TerraformLiteralProperty<bool>? CloudTieringEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("cloud_tiering_enabled");
        set => this.WithProperty("cloud_tiering_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The initial_download_policy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? InitialDownloadPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("initial_download_policy");
        set => this.WithProperty("initial_download_policy", value);
    }

    /// <summary>
    /// The local_cache_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LocalCacheMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("local_cache_mode");
        set => this.WithProperty("local_cache_mode", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The registered_server_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RegisteredServerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("registered_server_id");
        set => this.WithProperty("registered_server_id", value);
    }

    /// <summary>
    /// The server_local_path attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServerLocalPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_local_path");
        set => this.WithProperty("server_local_path", value);
    }

    /// <summary>
    /// The storage_sync_group_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageSyncGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_sync_group_id");
        set => this.WithProperty("storage_sync_group_id", value);
    }

    /// <summary>
    /// The tier_files_older_than_days attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? TierFilesOlderThanDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("tier_files_older_than_days");
        set => this.WithProperty("tier_files_older_than_days", value);
    }

    /// <summary>
    /// The volume_free_space_percent attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? VolumeFreeSpacePercent
    {
        get => GetProperty<TerraformLiteralProperty<double>>("volume_free_space_percent");
        set => this.WithProperty("volume_free_space_percent", value);
    }

}
