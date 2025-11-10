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
        set => SetProperty("disk_encryption_set_id", value);
    }

    /// <summary>
    /// The exclude_from_latest_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ExcludeFromLatestEnabled
    {
        set => SetProperty("exclude_from_latest_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The regional_replica_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegionalReplicaCount is required")]
    public required TerraformProperty<double> RegionalReplicaCount
    {
        set => SetProperty("regional_replica_count", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountType
    {
        set => SetProperty("storage_account_type", value);
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
        SetOutput("blob_uri");
        SetOutput("deletion_of_replicated_locations_enabled");
        SetOutput("end_of_life_date");
        SetOutput("exclude_from_latest");
        SetOutput("gallery_name");
        SetOutput("id");
        SetOutput("image_name");
        SetOutput("location");
        SetOutput("managed_image_id");
        SetOutput("name");
        SetOutput("os_disk_snapshot_id");
        SetOutput("replication_mode");
        SetOutput("resource_group_name");
        SetOutput("storage_account_id");
        SetOutput("tags");
    }

    /// <summary>
    /// The blob_uri attribute.
    /// </summary>
    public TerraformProperty<string> BlobUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("blob_uri");
        set => SetProperty("blob_uri", value);
    }

    /// <summary>
    /// The deletion_of_replicated_locations_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> DeletionOfReplicatedLocationsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("deletion_of_replicated_locations_enabled");
        set => SetProperty("deletion_of_replicated_locations_enabled", value);
    }

    /// <summary>
    /// The end_of_life_date attribute.
    /// </summary>
    public TerraformProperty<string> EndOfLifeDate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("end_of_life_date");
        set => SetProperty("end_of_life_date", value);
    }

    /// <summary>
    /// The exclude_from_latest attribute.
    /// </summary>
    public TerraformProperty<bool> ExcludeFromLatest
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("exclude_from_latest");
        set => SetProperty("exclude_from_latest", value);
    }

    /// <summary>
    /// The gallery_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GalleryName is required")]
    public required TerraformProperty<string> GalleryName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("gallery_name");
        set => SetProperty("gallery_name", value);
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
    /// The image_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageName is required")]
    public required TerraformProperty<string> ImageName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("image_name");
        set => SetProperty("image_name", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The managed_image_id attribute.
    /// </summary>
    public TerraformProperty<string> ManagedImageId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("managed_image_id");
        set => SetProperty("managed_image_id", value);
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
    /// The os_disk_snapshot_id attribute.
    /// </summary>
    public TerraformProperty<string> OsDiskSnapshotId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("os_disk_snapshot_id");
        set => SetProperty("os_disk_snapshot_id", value);
    }

    /// <summary>
    /// The replication_mode attribute.
    /// </summary>
    public TerraformProperty<string> ReplicationMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("replication_mode");
        set => SetProperty("replication_mode", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformProperty<string> StorageAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_account_id");
        set => SetProperty("storage_account_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for target_region.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRegion is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetRegion block(s) required")]
    public List<AzurermSharedImageVersionTargetRegionBlock>? TargetRegion
    {
        set => SetProperty("target_region", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSharedImageVersionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
