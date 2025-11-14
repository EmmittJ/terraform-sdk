using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_shared_image_version.
/// </summary>
public class AzurermSharedImageVersionDataSource : TerraformDataSource
{
    public AzurermSharedImageVersionDataSource(string name) : base("azurerm_shared_image_version", name)
    {
    }

    /// <summary>
    /// The gallery_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GalleryName is required")]
    [TerraformArgument("gallery_name")]
    public required TerraformValue<string> GalleryName
    {
        get => new TerraformReference<string>(this, "gallery_name");
        set => SetArgument("gallery_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageName is required")]
    [TerraformArgument("image_name")]
    public required TerraformValue<string> ImageName
    {
        get => new TerraformReference<string>(this, "image_name");
        set => SetArgument("image_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sort_versions_by_semver attribute.
    /// </summary>
    [TerraformArgument("sort_versions_by_semver")]
    public TerraformValue<bool>? SortVersionsBySemver
    {
        get => new TerraformReference<bool>(this, "sort_versions_by_semver");
        set => SetArgument("sort_versions_by_semver", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSharedImageVersionDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The exclude_from_latest attribute.
    /// </summary>
    [TerraformArgument("exclude_from_latest")]
    public TerraformValue<bool> ExcludeFromLatest
    {
        get => new TerraformReference<bool>(this, "exclude_from_latest");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The managed_image_id attribute.
    /// </summary>
    [TerraformArgument("managed_image_id")]
    public TerraformValue<string> ManagedImageId
    {
        get => new TerraformReference<string>(this, "managed_image_id");
    }

    /// <summary>
    /// The os_disk_image_size_gb attribute.
    /// </summary>
    [TerraformArgument("os_disk_image_size_gb")]
    public TerraformValue<double> OsDiskImageSizeGb
    {
        get => new TerraformReference<double>(this, "os_disk_image_size_gb");
    }

    /// <summary>
    /// The os_disk_snapshot_id attribute.
    /// </summary>
    [TerraformArgument("os_disk_snapshot_id")]
    public TerraformValue<string> OsDiskSnapshotId
    {
        get => new TerraformReference<string>(this, "os_disk_snapshot_id");
    }

    /// <summary>
    /// The target_region attribute.
    /// </summary>
    [TerraformArgument("target_region")]
    public TerraformList<object> TargetRegion
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "target_region").ResolveNodes(ctx));
    }

}
