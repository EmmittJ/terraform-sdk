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
        SetOutput("block_size_in_bytes");
        SetOutput("custom_location_id");
        SetOutput("disk_file_format");
        SetOutput("disk_size_in_gb");
        SetOutput("dynamic_enabled");
        SetOutput("hyperv_generation");
        SetOutput("id");
        SetOutput("location");
        SetOutput("logical_sector_in_bytes");
        SetOutput("name");
        SetOutput("physical_sector_in_bytes");
        SetOutput("resource_group_name");
        SetOutput("storage_path_id");
        SetOutput("tags");
    }

    /// <summary>
    /// The block_size_in_bytes attribute.
    /// </summary>
    public TerraformProperty<double> BlockSizeInBytes
    {
        get => GetRequiredOutput<TerraformProperty<double>>("block_size_in_bytes");
        set => SetProperty("block_size_in_bytes", value);
    }

    /// <summary>
    /// The custom_location_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomLocationId is required")]
    public required TerraformProperty<string> CustomLocationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("custom_location_id");
        set => SetProperty("custom_location_id", value);
    }

    /// <summary>
    /// The disk_file_format attribute.
    /// </summary>
    public TerraformProperty<string> DiskFileFormat
    {
        get => GetRequiredOutput<TerraformProperty<string>>("disk_file_format");
        set => SetProperty("disk_file_format", value);
    }

    /// <summary>
    /// The disk_size_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskSizeInGb is required")]
    public required TerraformProperty<double> DiskSizeInGb
    {
        get => GetRequiredOutput<TerraformProperty<double>>("disk_size_in_gb");
        set => SetProperty("disk_size_in_gb", value);
    }

    /// <summary>
    /// The dynamic_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> DynamicEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("dynamic_enabled");
        set => SetProperty("dynamic_enabled", value);
    }

    /// <summary>
    /// The hyperv_generation attribute.
    /// </summary>
    public TerraformProperty<string> HypervGeneration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("hyperv_generation");
        set => SetProperty("hyperv_generation", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The logical_sector_in_bytes attribute.
    /// </summary>
    public TerraformProperty<double> LogicalSectorInBytes
    {
        get => GetRequiredOutput<TerraformProperty<double>>("logical_sector_in_bytes");
        set => SetProperty("logical_sector_in_bytes", value);
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
    /// The physical_sector_in_bytes attribute.
    /// </summary>
    public TerraformProperty<double> PhysicalSectorInBytes
    {
        get => GetRequiredOutput<TerraformProperty<double>>("physical_sector_in_bytes");
        set => SetProperty("physical_sector_in_bytes", value);
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
    /// The storage_path_id attribute.
    /// </summary>
    public TerraformProperty<string> StoragePathId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_path_id");
        set => SetProperty("storage_path_id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStackHciVirtualHardDiskTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
