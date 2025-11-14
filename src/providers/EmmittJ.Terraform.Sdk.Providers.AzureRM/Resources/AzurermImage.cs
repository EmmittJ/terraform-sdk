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
/// Block type for data_disk in .
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
    [TerraformArgument("blob_uri")]
    public TerraformValue<string> BlobUri
    {
        get => new TerraformReference<string>(this, "blob_uri");
        set => SetArgument("blob_uri", value);
    }

    /// <summary>
    /// The caching attribute.
    /// </summary>
    [TerraformArgument("caching")]
    public TerraformValue<string>? Caching
    {
        get => new TerraformReference<string>(this, "caching");
        set => SetArgument("caching", value);
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
    /// The lun attribute.
    /// </summary>
    [TerraformArgument("lun")]
    public TerraformValue<double>? Lun
    {
        get => new TerraformReference<double>(this, "lun");
        set => SetArgument("lun", value);
    }

    /// <summary>
    /// The managed_disk_id attribute.
    /// </summary>
    [TerraformArgument("managed_disk_id")]
    public TerraformValue<string>? ManagedDiskId
    {
        get => new TerraformReference<string>(this, "managed_disk_id");
        set => SetArgument("managed_disk_id", value);
    }

    /// <summary>
    /// The size_gb attribute.
    /// </summary>
    [TerraformArgument("size_gb")]
    public TerraformValue<double> SizeGb
    {
        get => new TerraformReference<double>(this, "size_gb");
        set => SetArgument("size_gb", value);
    }

    /// <summary>
    /// The type of storage disk
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageType is required")]
    [TerraformArgument("storage_type")]
    public required TerraformValue<string> StorageType
    {
        get => new TerraformReference<string>(this, "storage_type");
        set => SetArgument("storage_type", value);
    }

}

/// <summary>
/// Block type for os_disk in .
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
    [TerraformArgument("blob_uri")]
    public TerraformValue<string> BlobUri
    {
        get => new TerraformReference<string>(this, "blob_uri");
        set => SetArgument("blob_uri", value);
    }

    /// <summary>
    /// The caching attribute.
    /// </summary>
    [TerraformArgument("caching")]
    public TerraformValue<string>? Caching
    {
        get => new TerraformReference<string>(this, "caching");
        set => SetArgument("caching", value);
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
    /// The managed_disk_id attribute.
    /// </summary>
    [TerraformArgument("managed_disk_id")]
    public TerraformValue<string> ManagedDiskId
    {
        get => new TerraformReference<string>(this, "managed_disk_id");
        set => SetArgument("managed_disk_id", value);
    }

    /// <summary>
    /// The os_state attribute.
    /// </summary>
    [TerraformArgument("os_state")]
    public TerraformValue<string>? OsState
    {
        get => new TerraformReference<string>(this, "os_state");
        set => SetArgument("os_state", value);
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
    /// The size_gb attribute.
    /// </summary>
    [TerraformArgument("size_gb")]
    public TerraformValue<double> SizeGb
    {
        get => new TerraformReference<double>(this, "size_gb");
        set => SetArgument("size_gb", value);
    }

    /// <summary>
    /// The type of storage disk
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageType is required")]
    [TerraformArgument("storage_type")]
    public required TerraformValue<string> StorageType
    {
        get => new TerraformReference<string>(this, "storage_type");
        set => SetArgument("storage_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
/// Manages a azurerm_image resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermImage : TerraformResource
{
    public AzurermImage(string name) : base("azurerm_image", name)
    {
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
    /// The source_virtual_machine_id attribute.
    /// </summary>
    [TerraformArgument("source_virtual_machine_id")]
    public TerraformValue<string>? SourceVirtualMachineId
    {
        get => new TerraformReference<string>(this, "source_virtual_machine_id");
        set => SetArgument("source_virtual_machine_id", value);
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
    /// The zone_resilient attribute.
    /// </summary>
    [TerraformArgument("zone_resilient")]
    public TerraformValue<bool>? ZoneResilient
    {
        get => new TerraformReference<bool>(this, "zone_resilient");
        set => SetArgument("zone_resilient", value);
    }

    /// <summary>
    /// Block for data_disk.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("data_disk")]
    public TerraformList<AzurermImageDataDiskBlock> DataDisk { get; set; } = new();

    /// <summary>
    /// Block for os_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsDisk block(s) allowed")]
    [TerraformArgument("os_disk")]
    public TerraformList<AzurermImageOsDiskBlock> OsDisk { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermImageTimeoutsBlock Timeouts { get; set; } = new();

}
