using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for target_region in AzurermSharedImageVersion.
/// Nesting mode: list
/// </summary>
public class AzurermSharedImageVersionTargetRegionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_region";

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformValue<string>? DiskEncryptionSetId
    {
        get => GetArgument<TerraformValue<string>>("disk_encryption_set_id");
        set => SetArgument("disk_encryption_set_id", value);
    }

    /// <summary>
    /// The exclude_from_latest_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ExcludeFromLatestEnabled
    {
        get => GetArgument<TerraformValue<bool>>("exclude_from_latest_enabled");
        set => SetArgument("exclude_from_latest_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The regional_replica_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegionalReplicaCount is required")]
    public required TerraformValue<double> RegionalReplicaCount
    {
        get => GetArgument<TerraformValue<double>>("regional_replica_count");
        set => SetArgument("regional_replica_count", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountType
    {
        get => GetArgument<TerraformValue<string>>("storage_account_type");
        set => SetArgument("storage_account_type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermSharedImageVersion.
/// Nesting mode: single
/// </summary>
public class AzurermSharedImageVersionTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_shared_image_version Terraform resource.
/// Manages a azurerm_shared_image_version resource.
/// </summary>
public partial class AzurermSharedImageVersion(string name) : TerraformResource("azurerm_shared_image_version", name)
{
    /// <summary>
    /// The blob_uri attribute.
    /// </summary>
    public TerraformValue<string>? BlobUri
    {
        get => GetArgument<TerraformValue<string>>("blob_uri");
        set => SetArgument("blob_uri", value);
    }

    /// <summary>
    /// The deletion_of_replicated_locations_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DeletionOfReplicatedLocationsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("deletion_of_replicated_locations_enabled");
        set => SetArgument("deletion_of_replicated_locations_enabled", value);
    }

    /// <summary>
    /// The end_of_life_date attribute.
    /// </summary>
    public TerraformValue<string>? EndOfLifeDate
    {
        get => GetArgument<TerraformValue<string>>("end_of_life_date");
        set => SetArgument("end_of_life_date", value);
    }

    /// <summary>
    /// The exclude_from_latest attribute.
    /// </summary>
    public TerraformValue<bool>? ExcludeFromLatest
    {
        get => GetArgument<TerraformValue<bool>>("exclude_from_latest");
        set => SetArgument("exclude_from_latest", value);
    }

    /// <summary>
    /// The gallery_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GalleryName is required")]
    public required TerraformValue<string> GalleryName
    {
        get => GetArgument<TerraformValue<string>>("gallery_name");
        set => SetArgument("gallery_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageName is required")]
    public required TerraformValue<string> ImageName
    {
        get => GetArgument<TerraformValue<string>>("image_name");
        set => SetArgument("image_name", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The managed_image_id attribute.
    /// </summary>
    public TerraformValue<string>? ManagedImageId
    {
        get => GetArgument<TerraformValue<string>>("managed_image_id");
        set => SetArgument("managed_image_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The os_disk_snapshot_id attribute.
    /// </summary>
    public TerraformValue<string>? OsDiskSnapshotId
    {
        get => GetArgument<TerraformValue<string>>("os_disk_snapshot_id");
        set => SetArgument("os_disk_snapshot_id", value);
    }

    /// <summary>
    /// The replication_mode attribute.
    /// </summary>
    public TerraformValue<string>? ReplicationMode
    {
        get => GetArgument<TerraformValue<string>>("replication_mode");
        set => SetArgument("replication_mode", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountId
    {
        get => GetArgument<TerraformValue<string>>("storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// TargetRegion block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRegion is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetRegion block(s) required")]
    public required TerraformList<AzurermSharedImageVersionTargetRegionBlock> TargetRegion
    {
        get => GetRequiredArgument<TerraformList<AzurermSharedImageVersionTargetRegionBlock>>("target_region");
        set => SetArgument("target_region", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSharedImageVersionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSharedImageVersionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
