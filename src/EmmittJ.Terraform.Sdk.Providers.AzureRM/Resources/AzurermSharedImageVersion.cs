using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for target_region in .
/// Nesting mode: list
/// </summary>
public class AzurermSharedImageVersionTargetRegionBlock : TerraformBlock
{
    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? DiskEncryptionSetId
    {
        get => GetProperty<TerraformProperty<string>>("disk_encryption_set_id");
        set => WithProperty("disk_encryption_set_id", value);
    }

    /// <summary>
    /// The exclude_from_latest_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ExcludeFromLatestEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("exclude_from_latest_enabled");
        set => WithProperty("exclude_from_latest_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The regional_replica_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegionalReplicaCount is required")]
    public required TerraformProperty<double> RegionalReplicaCount
    {
        get => GetProperty<TerraformProperty<double>>("regional_replica_count");
        set => WithProperty("regional_replica_count", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountType
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_type");
        set => WithProperty("storage_account_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSharedImageVersionTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_shared_image_version resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GalleryName is required")]
    public required TerraformProperty<string> GalleryName
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageName is required")]
    public required TerraformProperty<string> ImageName
    {
        get => GetProperty<TerraformProperty<string>>("image_name");
        set => this.WithProperty("image_name", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
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
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for target_region.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetRegion block(s) required")]
    public List<AzurermSharedImageVersionTargetRegionBlock>? TargetRegion
    {
        get => GetProperty<List<AzurermSharedImageVersionTargetRegionBlock>>("target_region");
        set => this.WithProperty("target_region", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSharedImageVersionTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSharedImageVersionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
