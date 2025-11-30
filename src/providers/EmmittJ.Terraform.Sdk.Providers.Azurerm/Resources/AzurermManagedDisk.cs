using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for encryption_settings in AzurermManagedDisk.
/// Nesting mode: list
/// </summary>
public class AzurermManagedDiskEncryptionSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_settings";

    /// <summary>
    /// DiskEncryptionKey block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskEncryptionKey is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DiskEncryptionKey block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiskEncryptionKey block(s) allowed")]
    public required TerraformList<AzurermManagedDiskEncryptionSettingsBlockDiskEncryptionKeyBlock> DiskEncryptionKey
    {
        get => GetRequiredArgument<TerraformList<AzurermManagedDiskEncryptionSettingsBlockDiskEncryptionKeyBlock>>("disk_encryption_key");
        set => SetArgument("disk_encryption_key", value);
    }

    /// <summary>
    /// KeyEncryptionKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyEncryptionKey block(s) allowed")]
    public TerraformList<AzurermManagedDiskEncryptionSettingsBlockKeyEncryptionKeyBlock>? KeyEncryptionKey
    {
        get => GetArgument<TerraformList<AzurermManagedDiskEncryptionSettingsBlockKeyEncryptionKeyBlock>>("key_encryption_key");
        set => SetArgument("key_encryption_key", value);
    }

}

/// <summary>
/// Block type for disk_encryption_key in AzurermManagedDiskEncryptionSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermManagedDiskEncryptionSettingsBlockDiskEncryptionKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "disk_encryption_key";

    /// <summary>
    /// The secret_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretUrl is required")]
    public required TerraformValue<string> SecretUrl
    {
        get => new TerraformReference<string>(this, "secret_url");
        set => SetArgument("secret_url", value);
    }

    /// <summary>
    /// The source_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceVaultId is required")]
    public required TerraformValue<string> SourceVaultId
    {
        get => new TerraformReference<string>(this, "source_vault_id");
        set => SetArgument("source_vault_id", value);
    }

}

/// <summary>
/// Block type for key_encryption_key in AzurermManagedDiskEncryptionSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermManagedDiskEncryptionSettingsBlockKeyEncryptionKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "key_encryption_key";

    /// <summary>
    /// The key_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyUrl is required")]
    public required TerraformValue<string> KeyUrl
    {
        get => new TerraformReference<string>(this, "key_url");
        set => SetArgument("key_url", value);
    }

    /// <summary>
    /// The source_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceVaultId is required")]
    public required TerraformValue<string> SourceVaultId
    {
        get => new TerraformReference<string>(this, "source_vault_id");
        set => SetArgument("source_vault_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermManagedDisk.
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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_managed_disk Terraform resource.
/// Manages a azurerm_managed_disk resource.
/// </summary>
public partial class AzurermManagedDisk(string name) : TerraformResource("azurerm_managed_disk", name)
{
    /// <summary>
    /// The create_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreateOption is required")]
    public required TerraformValue<string> CreateOption
    {
        get => new TerraformReference<string>(this, "create_option");
        set => SetArgument("create_option", value);
    }

    /// <summary>
    /// The disk_access_id attribute.
    /// </summary>
    public TerraformValue<string>? DiskAccessId
    {
        get => new TerraformReference<string>(this, "disk_access_id");
        set => SetArgument("disk_access_id", value);
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformValue<string>? DiskEncryptionSetId
    {
        get => new TerraformReference<string>(this, "disk_encryption_set_id");
        set => SetArgument("disk_encryption_set_id", value);
    }

    /// <summary>
    /// The disk_iops_read_only attribute.
    /// </summary>
    public TerraformValue<double> DiskIopsReadOnly
    {
        get => new TerraformReference<double>(this, "disk_iops_read_only");
        set => SetArgument("disk_iops_read_only", value);
    }

    /// <summary>
    /// The disk_iops_read_write attribute.
    /// </summary>
    public TerraformValue<double> DiskIopsReadWrite
    {
        get => new TerraformReference<double>(this, "disk_iops_read_write");
        set => SetArgument("disk_iops_read_write", value);
    }

    /// <summary>
    /// The disk_mbps_read_only attribute.
    /// </summary>
    public TerraformValue<double> DiskMbpsReadOnly
    {
        get => new TerraformReference<double>(this, "disk_mbps_read_only");
        set => SetArgument("disk_mbps_read_only", value);
    }

    /// <summary>
    /// The disk_mbps_read_write attribute.
    /// </summary>
    public TerraformValue<double> DiskMbpsReadWrite
    {
        get => new TerraformReference<double>(this, "disk_mbps_read_write");
        set => SetArgument("disk_mbps_read_write", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    public TerraformValue<double> DiskSizeGb
    {
        get => new TerraformReference<double>(this, "disk_size_gb");
        set => SetArgument("disk_size_gb", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public TerraformValue<string>? EdgeZone
    {
        get => new TerraformReference<string>(this, "edge_zone");
        set => SetArgument("edge_zone", value);
    }

    /// <summary>
    /// The gallery_image_reference_id attribute.
    /// </summary>
    public TerraformValue<string>? GalleryImageReferenceId
    {
        get => new TerraformReference<string>(this, "gallery_image_reference_id");
        set => SetArgument("gallery_image_reference_id", value);
    }

    /// <summary>
    /// The hyper_v_generation attribute.
    /// </summary>
    public TerraformValue<string>? HyperVGeneration
    {
        get => new TerraformReference<string>(this, "hyper_v_generation");
        set => SetArgument("hyper_v_generation", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The image_reference_id attribute.
    /// </summary>
    public TerraformValue<string>? ImageReferenceId
    {
        get => new TerraformReference<string>(this, "image_reference_id");
        set => SetArgument("image_reference_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The logical_sector_size attribute.
    /// </summary>
    public TerraformValue<double> LogicalSectorSize
    {
        get => new TerraformReference<double>(this, "logical_sector_size");
        set => SetArgument("logical_sector_size", value);
    }

    /// <summary>
    /// The max_shares attribute.
    /// </summary>
    public TerraformValue<double> MaxShares
    {
        get => new TerraformReference<double>(this, "max_shares");
        set => SetArgument("max_shares", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The network_access_policy attribute.
    /// </summary>
    public TerraformValue<string>? NetworkAccessPolicy
    {
        get => new TerraformReference<string>(this, "network_access_policy");
        set => SetArgument("network_access_policy", value);
    }

    /// <summary>
    /// The on_demand_bursting_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? OnDemandBurstingEnabled
    {
        get => new TerraformReference<bool>(this, "on_demand_bursting_enabled");
        set => SetArgument("on_demand_bursting_enabled", value);
    }

    /// <summary>
    /// The optimized_frequent_attach_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? OptimizedFrequentAttachEnabled
    {
        get => new TerraformReference<bool>(this, "optimized_frequent_attach_enabled");
        set => SetArgument("optimized_frequent_attach_enabled", value);
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformValue<string>? OsType
    {
        get => new TerraformReference<string>(this, "os_type");
        set => SetArgument("os_type", value);
    }

    /// <summary>
    /// The performance_plus_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PerformancePlusEnabled
    {
        get => new TerraformReference<bool>(this, "performance_plus_enabled");
        set => SetArgument("performance_plus_enabled", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The secure_vm_disk_encryption_set_id attribute.
    /// </summary>
    public TerraformValue<string>? SecureVmDiskEncryptionSetId
    {
        get => new TerraformReference<string>(this, "secure_vm_disk_encryption_set_id");
        set => SetArgument("secure_vm_disk_encryption_set_id", value);
    }

    /// <summary>
    /// The security_type attribute.
    /// </summary>
    public TerraformValue<string>? SecurityType
    {
        get => new TerraformReference<string>(this, "security_type");
        set => SetArgument("security_type", value);
    }

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    public TerraformValue<string>? SourceResourceId
    {
        get => new TerraformReference<string>(this, "source_resource_id");
        set => SetArgument("source_resource_id", value);
    }

    /// <summary>
    /// The source_uri attribute.
    /// </summary>
    public TerraformValue<string> SourceUri
    {
        get => new TerraformReference<string>(this, "source_uri");
        set => SetArgument("source_uri", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountId
    {
        get => new TerraformReference<string>(this, "storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountType is required")]
    public required TerraformValue<string> StorageAccountType
    {
        get => new TerraformReference<string>(this, "storage_account_type");
        set => SetArgument("storage_account_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    public TerraformValue<string> Tier
    {
        get => new TerraformReference<string>(this, "tier");
        set => SetArgument("tier", value);
    }

    /// <summary>
    /// The trusted_launch_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TrustedLaunchEnabled
    {
        get => new TerraformReference<bool>(this, "trusted_launch_enabled");
        set => SetArgument("trusted_launch_enabled", value);
    }

    /// <summary>
    /// The upload_size_bytes attribute.
    /// </summary>
    public TerraformValue<double>? UploadSizeBytes
    {
        get => new TerraformReference<double>(this, "upload_size_bytes");
        set => SetArgument("upload_size_bytes", value);
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformValue<string>? Zone
    {
        get => new TerraformReference<string>(this, "zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// EncryptionSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSettings block(s) allowed")]
    public TerraformList<AzurermManagedDiskEncryptionSettingsBlock>? EncryptionSettings
    {
        get => GetArgument<TerraformList<AzurermManagedDiskEncryptionSettingsBlock>>("encryption_settings");
        set => SetArgument("encryption_settings", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermManagedDiskTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermManagedDiskTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
