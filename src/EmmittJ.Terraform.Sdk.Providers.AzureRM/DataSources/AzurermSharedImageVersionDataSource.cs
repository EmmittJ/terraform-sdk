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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The sort_versions_by_semver attribute.
    /// </summary>
    public bool? SortVersionsBySemver
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("sort_versions_by_semver")?.Value;
        set => this.WithProperty("sort_versions_by_semver", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
