using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStackHciVirtualHardDiskTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_stack_hci_virtual_hard_disk resource.
/// </summary>
public class AzurermStackHciVirtualHardDisk : TerraformResource
{
    public AzurermStackHciVirtualHardDisk(string name) : base("azurerm_stack_hci_virtual_hard_disk", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The block_size_in_bytes attribute.
    /// </summary>
    public TerraformProperty<double>? BlockSizeInBytes
    {
        get => GetProperty<TerraformProperty<double>>("block_size_in_bytes");
        set => this.WithProperty("block_size_in_bytes", value);
    }

    /// <summary>
    /// The custom_location_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomLocationId is required")]
    public required TerraformProperty<string> CustomLocationId
    {
        get => GetProperty<TerraformProperty<string>>("custom_location_id");
        set => this.WithProperty("custom_location_id", value);
    }

    /// <summary>
    /// The disk_file_format attribute.
    /// </summary>
    public TerraformProperty<string>? DiskFileFormat
    {
        get => GetProperty<TerraformProperty<string>>("disk_file_format");
        set => this.WithProperty("disk_file_format", value);
    }

    /// <summary>
    /// The disk_size_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskSizeInGb is required")]
    public required TerraformProperty<double> DiskSizeInGb
    {
        get => GetProperty<TerraformProperty<double>>("disk_size_in_gb");
        set => this.WithProperty("disk_size_in_gb", value);
    }

    /// <summary>
    /// The dynamic_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DynamicEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("dynamic_enabled");
        set => this.WithProperty("dynamic_enabled", value);
    }

    /// <summary>
    /// The hyperv_generation attribute.
    /// </summary>
    public TerraformProperty<string>? HypervGeneration
    {
        get => GetProperty<TerraformProperty<string>>("hyperv_generation");
        set => this.WithProperty("hyperv_generation", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The logical_sector_in_bytes attribute.
    /// </summary>
    public TerraformProperty<double>? LogicalSectorInBytes
    {
        get => GetProperty<TerraformProperty<double>>("logical_sector_in_bytes");
        set => this.WithProperty("logical_sector_in_bytes", value);
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
    /// The physical_sector_in_bytes attribute.
    /// </summary>
    public TerraformProperty<double>? PhysicalSectorInBytes
    {
        get => GetProperty<TerraformProperty<double>>("physical_sector_in_bytes");
        set => this.WithProperty("physical_sector_in_bytes", value);
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
    /// The storage_path_id attribute.
    /// </summary>
    public TerraformProperty<string>? StoragePathId
    {
        get => GetProperty<TerraformProperty<string>>("storage_path_id");
        set => this.WithProperty("storage_path_id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStackHciVirtualHardDiskTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermStackHciVirtualHardDiskTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
