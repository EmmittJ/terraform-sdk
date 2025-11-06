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
    public bool? CloudTieringEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("cloud_tiering_enabled")?.Value;
        set => this.WithProperty("cloud_tiering_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The initial_download_policy attribute.
    /// </summary>
    public string? InitialDownloadPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("initial_download_policy")?.Value;
        set => this.WithProperty("initial_download_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The local_cache_mode attribute.
    /// </summary>
    public string? LocalCacheMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("local_cache_mode")?.Value;
        set => this.WithProperty("local_cache_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The registered_server_id attribute.
    /// </summary>
    public string? RegisteredServerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("registered_server_id")?.Value;
        set => this.WithProperty("registered_server_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The server_local_path attribute.
    /// </summary>
    public string? ServerLocalPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_local_path")?.Value;
        set => this.WithProperty("server_local_path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_sync_group_id attribute.
    /// </summary>
    public string? StorageSyncGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_sync_group_id")?.Value;
        set => this.WithProperty("storage_sync_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tier_files_older_than_days attribute.
    /// </summary>
    public double? TierFilesOlderThanDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("tier_files_older_than_days")?.Value;
        set => this.WithProperty("tier_files_older_than_days", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The volume_free_space_percent attribute.
    /// </summary>
    public double? VolumeFreeSpacePercent
    {
        get => GetProperty<TerraformLiteralProperty<double>>("volume_free_space_percent")?.Value;
        set => this.WithProperty("volume_free_space_percent", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

}
