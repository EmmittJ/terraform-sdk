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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStackHciVirtualHardDiskTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_stack_hci_virtual_hard_disk resource.
/// </summary>
public class AzurermStackHciVirtualHardDisk : TerraformResource
{
    public AzurermStackHciVirtualHardDisk(string name) : base("azurerm_stack_hci_virtual_hard_disk", name)
    {
    }

    /// <summary>
    /// The block_size_in_bytes attribute.
    /// </summary>
    [TerraformArgument("block_size_in_bytes")]
    public TerraformValue<double>? BlockSizeInBytes
    {
        get => new TerraformReference<double>(this, "block_size_in_bytes");
        set => SetArgument("block_size_in_bytes", value);
    }

    /// <summary>
    /// The custom_location_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomLocationId is required")]
    [TerraformArgument("custom_location_id")]
    public required TerraformValue<string> CustomLocationId
    {
        get => new TerraformReference<string>(this, "custom_location_id");
        set => SetArgument("custom_location_id", value);
    }

    /// <summary>
    /// The disk_file_format attribute.
    /// </summary>
    [TerraformArgument("disk_file_format")]
    public TerraformValue<string>? DiskFileFormat
    {
        get => new TerraformReference<string>(this, "disk_file_format");
        set => SetArgument("disk_file_format", value);
    }

    /// <summary>
    /// The disk_size_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskSizeInGb is required")]
    [TerraformArgument("disk_size_in_gb")]
    public required TerraformValue<double> DiskSizeInGb
    {
        get => new TerraformReference<double>(this, "disk_size_in_gb");
        set => SetArgument("disk_size_in_gb", value);
    }

    /// <summary>
    /// The dynamic_enabled attribute.
    /// </summary>
    [TerraformArgument("dynamic_enabled")]
    public TerraformValue<bool>? DynamicEnabled
    {
        get => new TerraformReference<bool>(this, "dynamic_enabled");
        set => SetArgument("dynamic_enabled", value);
    }

    /// <summary>
    /// The hyperv_generation attribute.
    /// </summary>
    [TerraformArgument("hyperv_generation")]
    public TerraformValue<string>? HypervGeneration
    {
        get => new TerraformReference<string>(this, "hyperv_generation");
        set => SetArgument("hyperv_generation", value);
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
    /// The logical_sector_in_bytes attribute.
    /// </summary>
    [TerraformArgument("logical_sector_in_bytes")]
    public TerraformValue<double>? LogicalSectorInBytes
    {
        get => new TerraformReference<double>(this, "logical_sector_in_bytes");
        set => SetArgument("logical_sector_in_bytes", value);
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
    /// The physical_sector_in_bytes attribute.
    /// </summary>
    [TerraformArgument("physical_sector_in_bytes")]
    public TerraformValue<double>? PhysicalSectorInBytes
    {
        get => new TerraformReference<double>(this, "physical_sector_in_bytes");
        set => SetArgument("physical_sector_in_bytes", value);
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
    /// The storage_path_id attribute.
    /// </summary>
    [TerraformArgument("storage_path_id")]
    public TerraformValue<string>? StoragePathId
    {
        get => new TerraformReference<string>(this, "storage_path_id");
        set => SetArgument("storage_path_id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermStackHciVirtualHardDiskTimeoutsBlock Timeouts { get; set; } = new();

}
