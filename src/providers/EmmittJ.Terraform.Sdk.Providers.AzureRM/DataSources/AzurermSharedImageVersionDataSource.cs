using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSharedImageVersionDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_shared_image_version.
/// </summary>
public class AzurermSharedImageVersionDataSource : TerraformDataSource
{
    public AzurermSharedImageVersionDataSource(string name) : base("azurerm_shared_image_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("exclude_from_latest");
        SetOutput("location");
        SetOutput("managed_image_id");
        SetOutput("os_disk_image_size_gb");
        SetOutput("os_disk_snapshot_id");
        SetOutput("target_region");
        SetOutput("gallery_name");
        SetOutput("id");
        SetOutput("image_name");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("sort_versions_by_semver");
        SetOutput("tags");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The sort_versions_by_semver attribute.
    /// </summary>
    public TerraformProperty<bool> SortVersionsBySemver
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("sort_versions_by_semver");
        set => SetProperty("sort_versions_by_semver", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSharedImageVersionDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The exclude_from_latest attribute.
    /// </summary>
    public TerraformExpression ExcludeFromLatest => this["exclude_from_latest"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The managed_image_id attribute.
    /// </summary>
    public TerraformExpression ManagedImageId => this["managed_image_id"];

    /// <summary>
    /// The os_disk_image_size_gb attribute.
    /// </summary>
    public TerraformExpression OsDiskImageSizeGb => this["os_disk_image_size_gb"];

    /// <summary>
    /// The os_disk_snapshot_id attribute.
    /// </summary>
    public TerraformExpression OsDiskSnapshotId => this["os_disk_snapshot_id"];

    /// <summary>
    /// The target_region attribute.
    /// </summary>
    public TerraformExpression TargetRegion => this["target_region"];

}
