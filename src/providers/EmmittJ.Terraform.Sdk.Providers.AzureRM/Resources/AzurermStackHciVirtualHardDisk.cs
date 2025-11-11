using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStackHciVirtualHardDiskTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

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
    [TerraformPropertyName("block_size_in_bytes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? BlockSizeInBytes { get; set; }

    /// <summary>
    /// The custom_location_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomLocationId is required")]
    [TerraformPropertyName("custom_location_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CustomLocationId { get; set; }

    /// <summary>
    /// The disk_file_format attribute.
    /// </summary>
    [TerraformPropertyName("disk_file_format")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DiskFileFormat { get; set; }

    /// <summary>
    /// The disk_size_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskSizeInGb is required")]
    [TerraformPropertyName("disk_size_in_gb")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> DiskSizeInGb { get; set; }

    /// <summary>
    /// The dynamic_enabled attribute.
    /// </summary>
    [TerraformPropertyName("dynamic_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DynamicEnabled { get; set; }

    /// <summary>
    /// The hyperv_generation attribute.
    /// </summary>
    [TerraformPropertyName("hyperv_generation")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HypervGeneration { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The logical_sector_in_bytes attribute.
    /// </summary>
    [TerraformPropertyName("logical_sector_in_bytes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? LogicalSectorInBytes { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The physical_sector_in_bytes attribute.
    /// </summary>
    [TerraformPropertyName("physical_sector_in_bytes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? PhysicalSectorInBytes { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The storage_path_id attribute.
    /// </summary>
    [TerraformPropertyName("storage_path_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StoragePathId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermStackHciVirtualHardDiskTimeoutsBlock>? Timeouts { get; set; }

}
