using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("exclude_from_latest");
        this.DeclareOutput("location");
        this.DeclareOutput("managed_image_id");
        this.DeclareOutput("os_disk_image_size_gb");
        this.DeclareOutput("os_disk_snapshot_id");
        this.DeclareOutput("target_region");
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The sort_versions_by_semver attribute.
    /// </summary>
    public TerraformProperty<bool>? SortVersionsBySemver
    {
        get => GetProperty<TerraformProperty<bool>>("sort_versions_by_semver");
        set => this.WithProperty("sort_versions_by_semver", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
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
