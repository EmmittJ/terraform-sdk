using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSharedImageVersionDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermSharedImageVersionDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_shared_image_version Terraform data source.
/// Retrieves information about a azurerm_shared_image_version.
/// </summary>
public partial class AzurermSharedImageVersionDataSource(string name) : TerraformDataSource("azurerm_shared_image_version", name)
{
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The sort_versions_by_semver attribute.
    /// </summary>
    public TerraformValue<bool>? SortVersionsBySemver
    {
        get => GetArgument<TerraformValue<bool>>("sort_versions_by_semver");
        set => SetArgument("sort_versions_by_semver", value);
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
    /// The exclude_from_latest attribute.
    /// </summary>
    public TerraformValue<bool> ExcludeFromLatest
        => AsReference("exclude_from_latest");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The managed_image_id attribute.
    /// </summary>
    public TerraformValue<string> ManagedImageId
        => AsReference("managed_image_id");

    /// <summary>
    /// The os_disk_image_size_gb attribute.
    /// </summary>
    public TerraformValue<double> OsDiskImageSizeGb
        => AsReference("os_disk_image_size_gb");

    /// <summary>
    /// The os_disk_snapshot_id attribute.
    /// </summary>
    public TerraformValue<string> OsDiskSnapshotId
        => AsReference("os_disk_snapshot_id");

    /// <summary>
    /// The target_region attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TargetRegion
        => AsReference("target_region");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSharedImageVersionDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSharedImageVersionDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
