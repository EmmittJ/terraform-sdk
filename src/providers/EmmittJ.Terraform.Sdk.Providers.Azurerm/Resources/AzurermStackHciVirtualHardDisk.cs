using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermStackHciVirtualHardDisk.
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
/// Represents a azurerm_stack_hci_virtual_hard_disk Terraform resource.
/// Manages a azurerm_stack_hci_virtual_hard_disk resource.
/// </summary>
public partial class AzurermStackHciVirtualHardDisk(string name) : TerraformResource("azurerm_stack_hci_virtual_hard_disk", name)
{
    /// <summary>
    /// The block_size_in_bytes attribute.
    /// </summary>
    public TerraformValue<double>? BlockSizeInBytes
    {
        get => GetArgument<TerraformValue<double>>("block_size_in_bytes");
        set => SetArgument("block_size_in_bytes", value);
    }

    /// <summary>
    /// The custom_location_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomLocationId is required")]
    public required TerraformValue<string> CustomLocationId
    {
        get => GetRequiredArgument<TerraformValue<string>>("custom_location_id");
        set => SetArgument("custom_location_id", value);
    }

    /// <summary>
    /// The disk_file_format attribute.
    /// </summary>
    public TerraformValue<string>? DiskFileFormat
    {
        get => GetArgument<TerraformValue<string>>("disk_file_format");
        set => SetArgument("disk_file_format", value);
    }

    /// <summary>
    /// The disk_size_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskSizeInGb is required")]
    public required TerraformValue<double> DiskSizeInGb
    {
        get => GetRequiredArgument<TerraformValue<double>>("disk_size_in_gb");
        set => SetArgument("disk_size_in_gb", value);
    }

    /// <summary>
    /// The dynamic_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DynamicEnabled
    {
        get => GetArgument<TerraformValue<bool>>("dynamic_enabled");
        set => SetArgument("dynamic_enabled", value);
    }

    /// <summary>
    /// The hyperv_generation attribute.
    /// </summary>
    public TerraformValue<string>? HypervGeneration
    {
        get => GetArgument<TerraformValue<string>>("hyperv_generation");
        set => SetArgument("hyperv_generation", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The logical_sector_in_bytes attribute.
    /// </summary>
    public TerraformValue<double>? LogicalSectorInBytes
    {
        get => GetArgument<TerraformValue<double>>("logical_sector_in_bytes");
        set => SetArgument("logical_sector_in_bytes", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The physical_sector_in_bytes attribute.
    /// </summary>
    public TerraformValue<double>? PhysicalSectorInBytes
    {
        get => GetArgument<TerraformValue<double>>("physical_sector_in_bytes");
        set => SetArgument("physical_sector_in_bytes", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The storage_path_id attribute.
    /// </summary>
    public TerraformValue<string>? StoragePathId
    {
        get => GetArgument<TerraformValue<string>>("storage_path_id");
        set => SetArgument("storage_path_id", value);
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
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStackHciVirtualHardDiskTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStackHciVirtualHardDiskTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
