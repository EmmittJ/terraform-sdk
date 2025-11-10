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
        SetOutput("create_option");
        SetOutput("disk_access_id");
        SetOutput("disk_encryption_set_id");
        SetOutput("disk_iops_read_only");
        SetOutput("disk_iops_read_write");
        SetOutput("disk_mbps_read_only");
        SetOutput("disk_mbps_read_write");
        SetOutput("disk_size_gb");
        SetOutput("edge_zone");
        SetOutput("gallery_image_reference_id");
        SetOutput("hyper_v_generation");
        SetOutput("id");
        SetOutput("image_reference_id");
        SetOutput("location");
        SetOutput("logical_sector_size");
        SetOutput("max_shares");
        SetOutput("name");
        SetOutput("network_access_policy");
        SetOutput("on_demand_bursting_enabled");
        SetOutput("optimized_frequent_attach_enabled");
        SetOutput("os_type");
        SetOutput("performance_plus_enabled");
        SetOutput("public_network_access_enabled");
        SetOutput("resource_group_name");
        SetOutput("secure_vm_disk_encryption_set_id");
        SetOutput("security_type");
        SetOutput("source_resource_id");
        SetOutput("source_uri");
        SetOutput("storage_account_id");
        SetOutput("storage_account_type");
        SetOutput("tags");
        SetOutput("tier");
        SetOutput("trusted_launch_enabled");
        SetOutput("upload_size_bytes");
        SetOutput("zone");
    }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreateOption is required")]
    public required TerraformProperty<string> CreateOption
    {
        get => GetRequiredOutput<TerraformProperty<string>>("create_option");
        set => SetProperty("create_option", value);
    }

    /// <summary>
    /// The disk_access_id attribute.
    /// </summary>
    public TerraformProperty<string> DiskAccessId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("disk_access_id");
        set => SetProperty("disk_access_id", value);
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformProperty<string> DiskEncryptionSetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("disk_encryption_set_id");
        set => SetProperty("disk_encryption_set_id", value);
    }

    /// <summary>
    /// The disk_iops_read_only attribute.
    /// </summary>
    public TerraformProperty<double> DiskIopsReadOnly
    {
        get => GetRequiredOutput<TerraformProperty<double>>("disk_iops_read_only");
        set => SetProperty("disk_iops_read_only", value);
    }

    /// <summary>
    /// The disk_iops_read_write attribute.
    /// </summary>
    public TerraformProperty<double> DiskIopsReadWrite
    {
        get => GetRequiredOutput<TerraformProperty<double>>("disk_iops_read_write");
        set => SetProperty("disk_iops_read_write", value);
    }

    /// <summary>
    /// The disk_mbps_read_only attribute.
    /// </summary>
    public TerraformProperty<double> DiskMbpsReadOnly
    {
        get => GetRequiredOutput<TerraformProperty<double>>("disk_mbps_read_only");
        set => SetProperty("disk_mbps_read_only", value);
    }

    /// <summary>
    /// The disk_mbps_read_write attribute.
    /// </summary>
    public TerraformProperty<double> DiskMbpsReadWrite
    {
        get => GetRequiredOutput<TerraformProperty<double>>("disk_mbps_read_write");
        set => SetProperty("disk_mbps_read_write", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    public TerraformProperty<double> DiskSizeGb
    {
        get => GetRequiredOutput<TerraformProperty<double>>("disk_size_gb");
        set => SetProperty("disk_size_gb", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public TerraformProperty<string> EdgeZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("edge_zone");
        set => SetProperty("edge_zone", value);
    }

    /// <summary>
    /// The gallery_image_reference_id attribute.
    /// </summary>
    public TerraformProperty<string> GalleryImageReferenceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("gallery_image_reference_id");
        set => SetProperty("gallery_image_reference_id", value);
    }

    /// <summary>
    /// The hyper_v_generation attribute.
    /// </summary>
    public TerraformProperty<string> HyperVGeneration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("hyper_v_generation");
        set => SetProperty("hyper_v_generation", value);
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
    /// The image_reference_id attribute.
    /// </summary>
    public TerraformProperty<string> ImageReferenceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("image_reference_id");
        set => SetProperty("image_reference_id", value);
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
    /// The logical_sector_size attribute.
    /// </summary>
    public TerraformProperty<double> LogicalSectorSize
    {
        get => GetRequiredOutput<TerraformProperty<double>>("logical_sector_size");
        set => SetProperty("logical_sector_size", value);
    }

    /// <summary>
    /// The max_shares attribute.
    /// </summary>
    public TerraformProperty<double> MaxShares
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_shares");
        set => SetProperty("max_shares", value);
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
    /// The network_access_policy attribute.
    /// </summary>
    public TerraformProperty<string> NetworkAccessPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_access_policy");
        set => SetProperty("network_access_policy", value);
    }

    /// <summary>
    /// The on_demand_bursting_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> OnDemandBurstingEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("on_demand_bursting_enabled");
        set => SetProperty("on_demand_bursting_enabled", value);
    }

    /// <summary>
    /// The optimized_frequent_attach_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> OptimizedFrequentAttachEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("optimized_frequent_attach_enabled");
        set => SetProperty("optimized_frequent_attach_enabled", value);
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformProperty<string> OsType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("os_type");
        set => SetProperty("os_type", value);
    }

    /// <summary>
    /// The performance_plus_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PerformancePlusEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("performance_plus_enabled");
        set => SetProperty("performance_plus_enabled", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PublicNetworkAccessEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("public_network_access_enabled");
        set => SetProperty("public_network_access_enabled", value);
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
    /// The secure_vm_disk_encryption_set_id attribute.
    /// </summary>
    public TerraformProperty<string> SecureVmDiskEncryptionSetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("secure_vm_disk_encryption_set_id");
        set => SetProperty("secure_vm_disk_encryption_set_id", value);
    }

    /// <summary>
    /// The security_type attribute.
    /// </summary>
    public TerraformProperty<string> SecurityType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("security_type");
        set => SetProperty("security_type", value);
    }

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    public TerraformProperty<string> SourceResourceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_resource_id");
        set => SetProperty("source_resource_id", value);
    }

    /// <summary>
    /// The source_uri attribute.
    /// </summary>
    public TerraformProperty<string> SourceUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_uri");
        set => SetProperty("source_uri", value);
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
    /// The storage_account_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountType is required")]
    public required TerraformProperty<string> StorageAccountType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_account_type");
        set => SetProperty("storage_account_type", value);
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
    /// The tier attribute.
    /// </summary>
    public TerraformProperty<string> Tier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tier");
        set => SetProperty("tier", value);
    }

    /// <summary>
    /// The trusted_launch_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> TrustedLaunchEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("trusted_launch_enabled");
        set => SetProperty("trusted_launch_enabled", value);
    }

    /// <summary>
    /// The upload_size_bytes attribute.
    /// </summary>
    public TerraformProperty<double> UploadSizeBytes
    {
        get => GetRequiredOutput<TerraformProperty<double>>("upload_size_bytes");
        set => SetProperty("upload_size_bytes", value);
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformProperty<string> Zone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("zone");
        set => SetProperty("zone", value);
    }

    /// <summary>
    /// Block for encryption_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSettings block(s) allowed")]
    public List<AzurermManagedDiskEncryptionSettingsBlock>? EncryptionSettings
    {
        set => SetProperty("encryption_settings", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermManagedDiskTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
