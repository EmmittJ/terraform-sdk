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
    public TerraformProperty<string>? BlobUri
    {
        get => GetProperty<TerraformProperty<string>>("blob_uri");
        set => this.WithProperty("blob_uri", value);
    }

    /// <summary>
    /// The deletion_of_replicated_locations_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DeletionOfReplicatedLocationsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("deletion_of_replicated_locations_enabled");
        set => this.WithProperty("deletion_of_replicated_locations_enabled", value);
    }

    /// <summary>
    /// The end_of_life_date attribute.
    /// </summary>
    public TerraformProperty<string>? EndOfLifeDate
    {
        get => GetProperty<TerraformProperty<string>>("end_of_life_date");
        set => this.WithProperty("end_of_life_date", value);
    }

    /// <summary>
    /// The exclude_from_latest attribute.
    /// </summary>
    public TerraformProperty<bool>? ExcludeFromLatest
    {
        get => GetProperty<TerraformProperty<bool>>("exclude_from_latest");
        set => this.WithProperty("exclude_from_latest", value);
    }

    /// <summary>
    /// The gallery_name attribute.
    /// </summary>
    public TerraformProperty<string>? GalleryName
    {
        get => GetProperty<TerraformProperty<string>>("gallery_name");
        set => this.WithProperty("gallery_name", value);
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
    /// The image_name attribute.
    /// </summary>
    public TerraformProperty<string>? ImageName
    {
        get => GetProperty<TerraformProperty<string>>("image_name");
        set => this.WithProperty("image_name", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The managed_image_id attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedImageId
    {
        get => GetProperty<TerraformProperty<string>>("managed_image_id");
        set => this.WithProperty("managed_image_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The os_disk_snapshot_id attribute.
    /// </summary>
    public TerraformProperty<string>? OsDiskSnapshotId
    {
        get => GetProperty<TerraformProperty<string>>("os_disk_snapshot_id");
        set => this.WithProperty("os_disk_snapshot_id", value);
    }

    /// <summary>
    /// The replication_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ReplicationMode
    {
        get => GetProperty<TerraformProperty<string>>("replication_mode");
        set => this.WithProperty("replication_mode", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountId
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_id");
        set => this.WithProperty("storage_account_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

}
