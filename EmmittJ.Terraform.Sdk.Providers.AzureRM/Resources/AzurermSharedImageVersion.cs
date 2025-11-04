using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_shared_image_version resource.
/// </summary>
public class AzurermSharedImageVersion : TerraformResource
{
    public AzurermSharedImageVersion(string name) : base("azurerm_shared_image_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The blob_uri attribute.
    /// </summary>
    public string? BlobUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("blob_uri")?.Value;
        set => this.WithProperty("blob_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The deletion_of_replicated_locations_enabled attribute.
    /// </summary>
    public bool? DeletionOfReplicatedLocationsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("deletion_of_replicated_locations_enabled")?.Value;
        set => this.WithProperty("deletion_of_replicated_locations_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The end_of_life_date attribute.
    /// </summary>
    public string? EndOfLifeDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("end_of_life_date")?.Value;
        set => this.WithProperty("end_of_life_date", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The exclude_from_latest attribute.
    /// </summary>
    public bool? ExcludeFromLatest
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("exclude_from_latest")?.Value;
        set => this.WithProperty("exclude_from_latest", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The gallery_name attribute.
    /// </summary>
    public string? GalleryName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gallery_name")?.Value;
        set => this.WithProperty("gallery_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The image_name attribute.
    /// </summary>
    public string? ImageName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("image_name")?.Value;
        set => this.WithProperty("image_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The managed_image_id attribute.
    /// </summary>
    public string? ManagedImageId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_image_id")?.Value;
        set => this.WithProperty("managed_image_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The os_disk_snapshot_id attribute.
    /// </summary>
    public string? OsDiskSnapshotId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("os_disk_snapshot_id")?.Value;
        set => this.WithProperty("os_disk_snapshot_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The replication_mode attribute.
    /// </summary>
    public string? ReplicationMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("replication_mode")?.Value;
        set => this.WithProperty("replication_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public string? StorageAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_id")?.Value;
        set => this.WithProperty("storage_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
