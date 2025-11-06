using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_managed_disk resource.
/// </summary>
public class AzurermManagedDisk : TerraformResource
{
    public AzurermManagedDisk(string name) : base("azurerm_managed_disk", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    public string? CreateOption
    {
        get => GetProperty<TerraformLiteralProperty<string>>("create_option")?.Value;
        set => this.WithProperty("create_option", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The disk_access_id attribute.
    /// </summary>
    public string? DiskAccessId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("disk_access_id")?.Value;
        set => this.WithProperty("disk_access_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public string? DiskEncryptionSetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("disk_encryption_set_id")?.Value;
        set => this.WithProperty("disk_encryption_set_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The disk_iops_read_only attribute.
    /// </summary>
    public double? DiskIopsReadOnly
    {
        get => GetProperty<TerraformLiteralProperty<double>>("disk_iops_read_only")?.Value;
        set => this.WithProperty("disk_iops_read_only", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The disk_iops_read_write attribute.
    /// </summary>
    public double? DiskIopsReadWrite
    {
        get => GetProperty<TerraformLiteralProperty<double>>("disk_iops_read_write")?.Value;
        set => this.WithProperty("disk_iops_read_write", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The disk_mbps_read_only attribute.
    /// </summary>
    public double? DiskMbpsReadOnly
    {
        get => GetProperty<TerraformLiteralProperty<double>>("disk_mbps_read_only")?.Value;
        set => this.WithProperty("disk_mbps_read_only", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The disk_mbps_read_write attribute.
    /// </summary>
    public double? DiskMbpsReadWrite
    {
        get => GetProperty<TerraformLiteralProperty<double>>("disk_mbps_read_write")?.Value;
        set => this.WithProperty("disk_mbps_read_write", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    public double? DiskSizeGb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("disk_size_gb")?.Value;
        set => this.WithProperty("disk_size_gb", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public string? EdgeZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("edge_zone")?.Value;
        set => this.WithProperty("edge_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The gallery_image_reference_id attribute.
    /// </summary>
    public string? GalleryImageReferenceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gallery_image_reference_id")?.Value;
        set => this.WithProperty("gallery_image_reference_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The hyper_v_generation attribute.
    /// </summary>
    public string? HyperVGeneration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hyper_v_generation")?.Value;
        set => this.WithProperty("hyper_v_generation", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The image_reference_id attribute.
    /// </summary>
    public string? ImageReferenceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("image_reference_id")?.Value;
        set => this.WithProperty("image_reference_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The logical_sector_size attribute.
    /// </summary>
    public double? LogicalSectorSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("logical_sector_size")?.Value;
        set => this.WithProperty("logical_sector_size", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The max_shares attribute.
    /// </summary>
    public double? MaxShares
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_shares")?.Value;
        set => this.WithProperty("max_shares", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The network_access_policy attribute.
    /// </summary>
    public string? NetworkAccessPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_access_policy")?.Value;
        set => this.WithProperty("network_access_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The on_demand_bursting_enabled attribute.
    /// </summary>
    public bool? OnDemandBurstingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("on_demand_bursting_enabled")?.Value;
        set => this.WithProperty("on_demand_bursting_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The optimized_frequent_attach_enabled attribute.
    /// </summary>
    public bool? OptimizedFrequentAttachEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("optimized_frequent_attach_enabled")?.Value;
        set => this.WithProperty("optimized_frequent_attach_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public string? OsType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("os_type")?.Value;
        set => this.WithProperty("os_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The performance_plus_enabled attribute.
    /// </summary>
    public bool? PerformancePlusEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("performance_plus_enabled")?.Value;
        set => this.WithProperty("performance_plus_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public bool? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("public_network_access_enabled")?.Value;
        set => this.WithProperty("public_network_access_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The secure_vm_disk_encryption_set_id attribute.
    /// </summary>
    public string? SecureVmDiskEncryptionSetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secure_vm_disk_encryption_set_id")?.Value;
        set => this.WithProperty("secure_vm_disk_encryption_set_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The security_type attribute.
    /// </summary>
    public string? SecurityType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_type")?.Value;
        set => this.WithProperty("security_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    public string? SourceResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_resource_id")?.Value;
        set => this.WithProperty("source_resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_uri attribute.
    /// </summary>
    public string? SourceUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_uri")?.Value;
        set => this.WithProperty("source_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The storage_account_type attribute.
    /// </summary>
    public string? StorageAccountType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_type")?.Value;
        set => this.WithProperty("storage_account_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tier attribute.
    /// </summary>
    public string? Tier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tier")?.Value;
        set => this.WithProperty("tier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The trusted_launch_enabled attribute.
    /// </summary>
    public bool? TrustedLaunchEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("trusted_launch_enabled")?.Value;
        set => this.WithProperty("trusted_launch_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The upload_size_bytes attribute.
    /// </summary>
    public double? UploadSizeBytes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("upload_size_bytes")?.Value;
        set => this.WithProperty("upload_size_bytes", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public string? Zone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("zone")?.Value;
        set => this.WithProperty("zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
