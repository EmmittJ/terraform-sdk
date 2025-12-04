using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for data_disk in AzurermImage.
/// Nesting mode: list
/// </summary>
public class AzurermImageDataDiskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_disk";

    /// <summary>
    /// The blob_uri attribute.
    /// </summary>
    public TerraformValue<string>? BlobUri
    {
        get => GetArgument<TerraformValue<string>>("blob_uri");
        set => SetArgument("blob_uri", value);
    }

    /// <summary>
    /// The caching attribute.
    /// </summary>
    public TerraformValue<string>? Caching
    {
        get => GetArgument<TerraformValue<string>>("caching");
        set => SetArgument("caching", value);
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformValue<string>? DiskEncryptionSetId
    {
        get => GetArgument<TerraformValue<string>>("disk_encryption_set_id");
        set => SetArgument("disk_encryption_set_id", value);
    }

    /// <summary>
    /// The lun attribute.
    /// </summary>
    public TerraformValue<double>? Lun
    {
        get => GetArgument<TerraformValue<double>>("lun");
        set => SetArgument("lun", value);
    }

    /// <summary>
    /// The managed_disk_id attribute.
    /// </summary>
    public TerraformValue<string>? ManagedDiskId
    {
        get => GetArgument<TerraformValue<string>>("managed_disk_id");
        set => SetArgument("managed_disk_id", value);
    }

    /// <summary>
    /// The size_gb attribute.
    /// </summary>
    public TerraformValue<double>? SizeGb
    {
        get => GetArgument<TerraformValue<double>>("size_gb");
        set => SetArgument("size_gb", value);
    }

    /// <summary>
    /// The type of storage disk
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageType is required")]
    public required TerraformValue<string> StorageType
    {
        get => GetArgument<TerraformValue<string>>("storage_type");
        set => SetArgument("storage_type", value);
    }

}


/// <summary>
/// Block type for os_disk in AzurermImage.
/// Nesting mode: list
/// </summary>
public class AzurermImageOsDiskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "os_disk";

    /// <summary>
    /// The blob_uri attribute.
    /// </summary>
    public TerraformValue<string>? BlobUri
    {
        get => GetArgument<TerraformValue<string>>("blob_uri");
        set => SetArgument("blob_uri", value);
    }

    /// <summary>
    /// The caching attribute.
    /// </summary>
    public TerraformValue<string>? Caching
    {
        get => GetArgument<TerraformValue<string>>("caching");
        set => SetArgument("caching", value);
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformValue<string>? DiskEncryptionSetId
    {
        get => GetArgument<TerraformValue<string>>("disk_encryption_set_id");
        set => SetArgument("disk_encryption_set_id", value);
    }

    /// <summary>
    /// The managed_disk_id attribute.
    /// </summary>
    public TerraformValue<string>? ManagedDiskId
    {
        get => GetArgument<TerraformValue<string>>("managed_disk_id");
        set => SetArgument("managed_disk_id", value);
    }

    /// <summary>
    /// The os_state attribute.
    /// </summary>
    public TerraformValue<string>? OsState
    {
        get => GetArgument<TerraformValue<string>>("os_state");
        set => SetArgument("os_state", value);
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformValue<string>? OsType
    {
        get => GetArgument<TerraformValue<string>>("os_type");
        set => SetArgument("os_type", value);
    }

    /// <summary>
    /// The size_gb attribute.
    /// </summary>
    public TerraformValue<double>? SizeGb
    {
        get => GetArgument<TerraformValue<double>>("size_gb");
        set => SetArgument("size_gb", value);
    }

    /// <summary>
    /// The type of storage disk
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageType is required")]
    public required TerraformValue<string> StorageType
    {
        get => GetArgument<TerraformValue<string>>("storage_type");
        set => SetArgument("storage_type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermImage.
/// Nesting mode: single
/// </summary>
public class AzurermImageTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_image Terraform resource.
/// Manages a azurerm_image resource.
/// </summary>
public partial class AzurermImage(string name) : TerraformResource("azurerm_image", name)
{
    /// <summary>
    /// The hyper_v_generation attribute.
    /// </summary>
    public TerraformValue<string>? HyperVGeneration
    {
        get => GetArgument<TerraformValue<string>>("hyper_v_generation");
        set => SetArgument("hyper_v_generation", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The source_virtual_machine_id attribute.
    /// </summary>
    public TerraformValue<string>? SourceVirtualMachineId
    {
        get => GetArgument<TerraformValue<string>>("source_virtual_machine_id");
        set => SetArgument("source_virtual_machine_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The zone_resilient attribute.
    /// </summary>
    public TerraformValue<bool>? ZoneResilient
    {
        get => GetArgument<TerraformValue<bool>>("zone_resilient");
        set => SetArgument("zone_resilient", value);
    }

    /// <summary>
    /// DataDisk block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermImageDataDiskBlock>? DataDisk
    {
        get => GetArgument<TerraformList<AzurermImageDataDiskBlock>>("data_disk");
        set => SetArgument("data_disk", value);
    }

    /// <summary>
    /// OsDisk block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsDisk block(s) allowed")]
    public TerraformList<AzurermImageOsDiskBlock>? OsDisk
    {
        get => GetArgument<TerraformList<AzurermImageOsDiskBlock>>("os_disk");
        set => SetArgument("os_disk", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermImageTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermImageTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
