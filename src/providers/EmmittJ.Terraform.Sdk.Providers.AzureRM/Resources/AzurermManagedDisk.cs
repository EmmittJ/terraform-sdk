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
/// Block type for encryption_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermManagedDiskEncryptionSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_settings";

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermManagedDiskTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
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
    }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreateOption is required")]
    [TerraformArgument("create_option")]
    public required TerraformValue<string> CreateOption
    {
        get => new TerraformReference<string>(this, "create_option");
        set => SetArgument("create_option", value);
    }

    /// <summary>
    /// The disk_access_id attribute.
    /// </summary>
    [TerraformArgument("disk_access_id")]
    public TerraformValue<string>? DiskAccessId
    {
        get => new TerraformReference<string>(this, "disk_access_id");
        set => SetArgument("disk_access_id", value);
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformArgument("disk_encryption_set_id")]
    public TerraformValue<string>? DiskEncryptionSetId
    {
        get => new TerraformReference<string>(this, "disk_encryption_set_id");
        set => SetArgument("disk_encryption_set_id", value);
    }

    /// <summary>
    /// The disk_iops_read_only attribute.
    /// </summary>
    [TerraformArgument("disk_iops_read_only")]
    public TerraformValue<double> DiskIopsReadOnly
    {
        get => new TerraformReference<double>(this, "disk_iops_read_only");
        set => SetArgument("disk_iops_read_only", value);
    }

    /// <summary>
    /// The disk_iops_read_write attribute.
    /// </summary>
    [TerraformArgument("disk_iops_read_write")]
    public TerraformValue<double> DiskIopsReadWrite
    {
        get => new TerraformReference<double>(this, "disk_iops_read_write");
        set => SetArgument("disk_iops_read_write", value);
    }

    /// <summary>
    /// The disk_mbps_read_only attribute.
    /// </summary>
    [TerraformArgument("disk_mbps_read_only")]
    public TerraformValue<double> DiskMbpsReadOnly
    {
        get => new TerraformReference<double>(this, "disk_mbps_read_only");
        set => SetArgument("disk_mbps_read_only", value);
    }

    /// <summary>
    /// The disk_mbps_read_write attribute.
    /// </summary>
    [TerraformArgument("disk_mbps_read_write")]
    public TerraformValue<double> DiskMbpsReadWrite
    {
        get => new TerraformReference<double>(this, "disk_mbps_read_write");
        set => SetArgument("disk_mbps_read_write", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [TerraformArgument("disk_size_gb")]
    public TerraformValue<double> DiskSizeGb
    {
        get => new TerraformReference<double>(this, "disk_size_gb");
        set => SetArgument("disk_size_gb", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    [TerraformArgument("edge_zone")]
    public TerraformValue<string>? EdgeZone
    {
        get => new TerraformReference<string>(this, "edge_zone");
        set => SetArgument("edge_zone", value);
    }

    /// <summary>
    /// The gallery_image_reference_id attribute.
    /// </summary>
    [TerraformArgument("gallery_image_reference_id")]
    public TerraformValue<string>? GalleryImageReferenceId
    {
        get => new TerraformReference<string>(this, "gallery_image_reference_id");
        set => SetArgument("gallery_image_reference_id", value);
    }

    /// <summary>
    /// The hyper_v_generation attribute.
    /// </summary>
    [TerraformArgument("hyper_v_generation")]
    public TerraformValue<string>? HyperVGeneration
    {
        get => new TerraformReference<string>(this, "hyper_v_generation");
        set => SetArgument("hyper_v_generation", value);
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
    /// The image_reference_id attribute.
    /// </summary>
    [TerraformArgument("image_reference_id")]
    public TerraformValue<string>? ImageReferenceId
    {
        get => new TerraformReference<string>(this, "image_reference_id");
        set => SetArgument("image_reference_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The logical_sector_size attribute.
    /// </summary>
    [TerraformArgument("logical_sector_size")]
    public TerraformValue<double> LogicalSectorSize
    {
        get => new TerraformReference<double>(this, "logical_sector_size");
        set => SetArgument("logical_sector_size", value);
    }

    /// <summary>
    /// The max_shares attribute.
    /// </summary>
    [TerraformArgument("max_shares")]
    public TerraformValue<double> MaxShares
    {
        get => new TerraformReference<double>(this, "max_shares");
        set => SetArgument("max_shares", value);
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
    /// The network_access_policy attribute.
    /// </summary>
    [TerraformArgument("network_access_policy")]
    public TerraformValue<string>? NetworkAccessPolicy
    {
        get => new TerraformReference<string>(this, "network_access_policy");
        set => SetArgument("network_access_policy", value);
    }

    /// <summary>
    /// The on_demand_bursting_enabled attribute.
    /// </summary>
    [TerraformArgument("on_demand_bursting_enabled")]
    public TerraformValue<bool>? OnDemandBurstingEnabled
    {
        get => new TerraformReference<bool>(this, "on_demand_bursting_enabled");
        set => SetArgument("on_demand_bursting_enabled", value);
    }

    /// <summary>
    /// The optimized_frequent_attach_enabled attribute.
    /// </summary>
    [TerraformArgument("optimized_frequent_attach_enabled")]
    public TerraformValue<bool>? OptimizedFrequentAttachEnabled
    {
        get => new TerraformReference<bool>(this, "optimized_frequent_attach_enabled");
        set => SetArgument("optimized_frequent_attach_enabled", value);
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [TerraformArgument("os_type")]
    public TerraformValue<string>? OsType
    {
        get => new TerraformReference<string>(this, "os_type");
        set => SetArgument("os_type", value);
    }

    /// <summary>
    /// The performance_plus_enabled attribute.
    /// </summary>
    [TerraformArgument("performance_plus_enabled")]
    public TerraformValue<bool>? PerformancePlusEnabled
    {
        get => new TerraformReference<bool>(this, "performance_plus_enabled");
        set => SetArgument("performance_plus_enabled", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformArgument("public_network_access_enabled")]
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
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
    /// The secure_vm_disk_encryption_set_id attribute.
    /// </summary>
    [TerraformArgument("secure_vm_disk_encryption_set_id")]
    public TerraformValue<string>? SecureVmDiskEncryptionSetId
    {
        get => new TerraformReference<string>(this, "secure_vm_disk_encryption_set_id");
        set => SetArgument("secure_vm_disk_encryption_set_id", value);
    }

    /// <summary>
    /// The security_type attribute.
    /// </summary>
    [TerraformArgument("security_type")]
    public TerraformValue<string>? SecurityType
    {
        get => new TerraformReference<string>(this, "security_type");
        set => SetArgument("security_type", value);
    }

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    [TerraformArgument("source_resource_id")]
    public TerraformValue<string>? SourceResourceId
    {
        get => new TerraformReference<string>(this, "source_resource_id");
        set => SetArgument("source_resource_id", value);
    }

    /// <summary>
    /// The source_uri attribute.
    /// </summary>
    [TerraformArgument("source_uri")]
    public TerraformValue<string> SourceUri
    {
        get => new TerraformReference<string>(this, "source_uri");
        set => SetArgument("source_uri", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [TerraformArgument("storage_account_id")]
    public TerraformValue<string>? StorageAccountId
    {
        get => new TerraformReference<string>(this, "storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountType is required")]
    [TerraformArgument("storage_account_type")]
    public required TerraformValue<string> StorageAccountType
    {
        get => new TerraformReference<string>(this, "storage_account_type");
        set => SetArgument("storage_account_type", value);
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
    /// The tier attribute.
    /// </summary>
    [TerraformArgument("tier")]
    public TerraformValue<string> Tier
    {
        get => new TerraformReference<string>(this, "tier");
        set => SetArgument("tier", value);
    }

    /// <summary>
    /// The trusted_launch_enabled attribute.
    /// </summary>
    [TerraformArgument("trusted_launch_enabled")]
    public TerraformValue<bool>? TrustedLaunchEnabled
    {
        get => new TerraformReference<bool>(this, "trusted_launch_enabled");
        set => SetArgument("trusted_launch_enabled", value);
    }

    /// <summary>
    /// The upload_size_bytes attribute.
    /// </summary>
    [TerraformArgument("upload_size_bytes")]
    public TerraformValue<double>? UploadSizeBytes
    {
        get => new TerraformReference<double>(this, "upload_size_bytes");
        set => SetArgument("upload_size_bytes", value);
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    [TerraformArgument("zone")]
    public TerraformValue<string>? Zone
    {
        get => new TerraformReference<string>(this, "zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// Block for encryption_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSettings block(s) allowed")]
    [TerraformArgument("encryption_settings")]
    public TerraformList<AzurermManagedDiskEncryptionSettingsBlock> EncryptionSettings { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermManagedDiskTimeoutsBlock Timeouts { get; set; } = new();

}
