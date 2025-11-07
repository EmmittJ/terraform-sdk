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
    public TerraformLiteralProperty<string>? CreateOption
    {
        get => GetProperty<TerraformLiteralProperty<string>>("create_option");
        set => this.WithProperty("create_option", value);
    }

    /// <summary>
    /// The disk_access_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DiskAccessId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("disk_access_id");
        set => this.WithProperty("disk_access_id", value);
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DiskEncryptionSetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("disk_encryption_set_id");
        set => this.WithProperty("disk_encryption_set_id", value);
    }

    /// <summary>
    /// The disk_iops_read_only attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? DiskIopsReadOnly
    {
        get => GetProperty<TerraformLiteralProperty<double>>("disk_iops_read_only");
        set => this.WithProperty("disk_iops_read_only", value);
    }

    /// <summary>
    /// The disk_iops_read_write attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? DiskIopsReadWrite
    {
        get => GetProperty<TerraformLiteralProperty<double>>("disk_iops_read_write");
        set => this.WithProperty("disk_iops_read_write", value);
    }

    /// <summary>
    /// The disk_mbps_read_only attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? DiskMbpsReadOnly
    {
        get => GetProperty<TerraformLiteralProperty<double>>("disk_mbps_read_only");
        set => this.WithProperty("disk_mbps_read_only", value);
    }

    /// <summary>
    /// The disk_mbps_read_write attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? DiskMbpsReadWrite
    {
        get => GetProperty<TerraformLiteralProperty<double>>("disk_mbps_read_write");
        set => this.WithProperty("disk_mbps_read_write", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? DiskSizeGb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("disk_size_gb");
        set => this.WithProperty("disk_size_gb", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EdgeZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("edge_zone");
        set => this.WithProperty("edge_zone", value);
    }

    /// <summary>
    /// The gallery_image_reference_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GalleryImageReferenceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gallery_image_reference_id");
        set => this.WithProperty("gallery_image_reference_id", value);
    }

    /// <summary>
    /// The hyper_v_generation attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HyperVGeneration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hyper_v_generation");
        set => this.WithProperty("hyper_v_generation", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The image_reference_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ImageReferenceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("image_reference_id");
        set => this.WithProperty("image_reference_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The logical_sector_size attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? LogicalSectorSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("logical_sector_size");
        set => this.WithProperty("logical_sector_size", value);
    }

    /// <summary>
    /// The max_shares attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MaxShares
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_shares");
        set => this.WithProperty("max_shares", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The network_access_policy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NetworkAccessPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_access_policy");
        set => this.WithProperty("network_access_policy", value);
    }

    /// <summary>
    /// The on_demand_bursting_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? OnDemandBurstingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("on_demand_bursting_enabled");
        set => this.WithProperty("on_demand_bursting_enabled", value);
    }

    /// <summary>
    /// The optimized_frequent_attach_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? OptimizedFrequentAttachEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("optimized_frequent_attach_enabled");
        set => this.WithProperty("optimized_frequent_attach_enabled", value);
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OsType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("os_type");
        set => this.WithProperty("os_type", value);
    }

    /// <summary>
    /// The performance_plus_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? PerformancePlusEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("performance_plus_enabled");
        set => this.WithProperty("performance_plus_enabled", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The secure_vm_disk_encryption_set_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SecureVmDiskEncryptionSetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secure_vm_disk_encryption_set_id");
        set => this.WithProperty("secure_vm_disk_encryption_set_id", value);
    }

    /// <summary>
    /// The security_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SecurityType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_type");
        set => this.WithProperty("security_type", value);
    }

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_resource_id");
        set => this.WithProperty("source_resource_id", value);
    }

    /// <summary>
    /// The source_uri attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_uri");
        set => this.WithProperty("source_uri", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_id");
        set => this.WithProperty("storage_account_id", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageAccountType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_type");
        set => this.WithProperty("storage_account_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Tier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tier");
        set => this.WithProperty("tier", value);
    }

    /// <summary>
    /// The trusted_launch_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? TrustedLaunchEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("trusted_launch_enabled");
        set => this.WithProperty("trusted_launch_enabled", value);
    }

    /// <summary>
    /// The upload_size_bytes attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? UploadSizeBytes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("upload_size_bytes");
        set => this.WithProperty("upload_size_bytes", value);
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Zone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("zone");
        set => this.WithProperty("zone", value);
    }

}
