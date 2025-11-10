using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for encryption_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermManagedDiskEncryptionSettingsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermManagedDiskTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_managed_disk resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreateOption is required")]
    public required TerraformProperty<string> CreateOption
    {
        get => GetProperty<TerraformProperty<string>>("create_option");
        set => this.WithProperty("create_option", value);
    }

    /// <summary>
    /// The disk_access_id attribute.
    /// </summary>
    public TerraformProperty<string>? DiskAccessId
    {
        get => GetProperty<TerraformProperty<string>>("disk_access_id");
        set => this.WithProperty("disk_access_id", value);
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? DiskEncryptionSetId
    {
        get => GetProperty<TerraformProperty<string>>("disk_encryption_set_id");
        set => this.WithProperty("disk_encryption_set_id", value);
    }

    /// <summary>
    /// The disk_iops_read_only attribute.
    /// </summary>
    public TerraformProperty<double>? DiskIopsReadOnly
    {
        get => GetProperty<TerraformProperty<double>>("disk_iops_read_only");
        set => this.WithProperty("disk_iops_read_only", value);
    }

    /// <summary>
    /// The disk_iops_read_write attribute.
    /// </summary>
    public TerraformProperty<double>? DiskIopsReadWrite
    {
        get => GetProperty<TerraformProperty<double>>("disk_iops_read_write");
        set => this.WithProperty("disk_iops_read_write", value);
    }

    /// <summary>
    /// The disk_mbps_read_only attribute.
    /// </summary>
    public TerraformProperty<double>? DiskMbpsReadOnly
    {
        get => GetProperty<TerraformProperty<double>>("disk_mbps_read_only");
        set => this.WithProperty("disk_mbps_read_only", value);
    }

    /// <summary>
    /// The disk_mbps_read_write attribute.
    /// </summary>
    public TerraformProperty<double>? DiskMbpsReadWrite
    {
        get => GetProperty<TerraformProperty<double>>("disk_mbps_read_write");
        set => this.WithProperty("disk_mbps_read_write", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    public TerraformProperty<double>? DiskSizeGb
    {
        get => GetProperty<TerraformProperty<double>>("disk_size_gb");
        set => this.WithProperty("disk_size_gb", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public TerraformProperty<string>? EdgeZone
    {
        get => GetProperty<TerraformProperty<string>>("edge_zone");
        set => this.WithProperty("edge_zone", value);
    }

    /// <summary>
    /// The gallery_image_reference_id attribute.
    /// </summary>
    public TerraformProperty<string>? GalleryImageReferenceId
    {
        get => GetProperty<TerraformProperty<string>>("gallery_image_reference_id");
        set => this.WithProperty("gallery_image_reference_id", value);
    }

    /// <summary>
    /// The hyper_v_generation attribute.
    /// </summary>
    public TerraformProperty<string>? HyperVGeneration
    {
        get => GetProperty<TerraformProperty<string>>("hyper_v_generation");
        set => this.WithProperty("hyper_v_generation", value);
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
    /// The image_reference_id attribute.
    /// </summary>
    public TerraformProperty<string>? ImageReferenceId
    {
        get => GetProperty<TerraformProperty<string>>("image_reference_id");
        set => this.WithProperty("image_reference_id", value);
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
    /// The logical_sector_size attribute.
    /// </summary>
    public TerraformProperty<double>? LogicalSectorSize
    {
        get => GetProperty<TerraformProperty<double>>("logical_sector_size");
        set => this.WithProperty("logical_sector_size", value);
    }

    /// <summary>
    /// The max_shares attribute.
    /// </summary>
    public TerraformProperty<double>? MaxShares
    {
        get => GetProperty<TerraformProperty<double>>("max_shares");
        set => this.WithProperty("max_shares", value);
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
    /// The network_access_policy attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkAccessPolicy
    {
        get => GetProperty<TerraformProperty<string>>("network_access_policy");
        set => this.WithProperty("network_access_policy", value);
    }

    /// <summary>
    /// The on_demand_bursting_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? OnDemandBurstingEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("on_demand_bursting_enabled");
        set => this.WithProperty("on_demand_bursting_enabled", value);
    }

    /// <summary>
    /// The optimized_frequent_attach_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? OptimizedFrequentAttachEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("optimized_frequent_attach_enabled");
        set => this.WithProperty("optimized_frequent_attach_enabled", value);
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformProperty<string>? OsType
    {
        get => GetProperty<TerraformProperty<string>>("os_type");
        set => this.WithProperty("os_type", value);
    }

    /// <summary>
    /// The performance_plus_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PerformancePlusEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("performance_plus_enabled");
        set => this.WithProperty("performance_plus_enabled", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
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
    /// The secure_vm_disk_encryption_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? SecureVmDiskEncryptionSetId
    {
        get => GetProperty<TerraformProperty<string>>("secure_vm_disk_encryption_set_id");
        set => this.WithProperty("secure_vm_disk_encryption_set_id", value);
    }

    /// <summary>
    /// The security_type attribute.
    /// </summary>
    public TerraformProperty<string>? SecurityType
    {
        get => GetProperty<TerraformProperty<string>>("security_type");
        set => this.WithProperty("security_type", value);
    }

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? SourceResourceId
    {
        get => GetProperty<TerraformProperty<string>>("source_resource_id");
        set => this.WithProperty("source_resource_id", value);
    }

    /// <summary>
    /// The source_uri attribute.
    /// </summary>
    public TerraformProperty<string>? SourceUri
    {
        get => GetProperty<TerraformProperty<string>>("source_uri");
        set => this.WithProperty("source_uri", value);
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
    /// The storage_account_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountType is required")]
    public required TerraformProperty<string> StorageAccountType
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_type");
        set => this.WithProperty("storage_account_type", value);
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
    /// The tier attribute.
    /// </summary>
    public TerraformProperty<string>? Tier
    {
        get => GetProperty<TerraformProperty<string>>("tier");
        set => this.WithProperty("tier", value);
    }

    /// <summary>
    /// The trusted_launch_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TrustedLaunchEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("trusted_launch_enabled");
        set => this.WithProperty("trusted_launch_enabled", value);
    }

    /// <summary>
    /// The upload_size_bytes attribute.
    /// </summary>
    public TerraformProperty<double>? UploadSizeBytes
    {
        get => GetProperty<TerraformProperty<double>>("upload_size_bytes");
        set => this.WithProperty("upload_size_bytes", value);
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformProperty<string>? Zone
    {
        get => GetProperty<TerraformProperty<string>>("zone");
        set => this.WithProperty("zone", value);
    }

    /// <summary>
    /// Block for encryption_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSettings block(s) allowed")]
    public List<AzurermManagedDiskEncryptionSettingsBlock>? EncryptionSettings
    {
        get => GetProperty<List<AzurermManagedDiskEncryptionSettingsBlock>>("encryption_settings");
        set => this.WithProperty("encryption_settings", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermManagedDiskTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermManagedDiskTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
