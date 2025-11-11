using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermStackHciVirtualHardDiskTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_stack_hci_virtual_hard_disk resource.
/// </summary>
public partial class AzurermStackHciVirtualHardDisk : TerraformResource
{
    public AzurermStackHciVirtualHardDisk(string name) : base("azurerm_stack_hci_virtual_hard_disk", name)
    {
    }

    /// <summary>
    /// The block_size_in_bytes attribute.
    /// </summary>
    [TerraformProperty("block_size_in_bytes")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? BlockSizeInBytes { get; set; }

    /// <summary>
    /// The custom_location_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomLocationId is required")]
    [TerraformProperty("custom_location_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CustomLocationId { get; set; }

    /// <summary>
    /// The disk_file_format attribute.
    /// </summary>
    [TerraformProperty("disk_file_format")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DiskFileFormat { get; set; }

    /// <summary>
    /// The disk_size_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskSizeInGb is required")]
    [TerraformProperty("disk_size_in_gb")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> DiskSizeInGb { get; set; }

    /// <summary>
    /// The dynamic_enabled attribute.
    /// </summary>
    [TerraformProperty("dynamic_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DynamicEnabled { get; set; }

    /// <summary>
    /// The hyperv_generation attribute.
    /// </summary>
    [TerraformProperty("hyperv_generation")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? HypervGeneration { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The logical_sector_in_bytes attribute.
    /// </summary>
    [TerraformProperty("logical_sector_in_bytes")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? LogicalSectorInBytes { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The physical_sector_in_bytes attribute.
    /// </summary>
    [TerraformProperty("physical_sector_in_bytes")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? PhysicalSectorInBytes { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The storage_path_id attribute.
    /// </summary>
    [TerraformProperty("storage_path_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StoragePathId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermStackHciVirtualHardDiskTimeoutsBlock>? Timeouts { get; set; }

}
