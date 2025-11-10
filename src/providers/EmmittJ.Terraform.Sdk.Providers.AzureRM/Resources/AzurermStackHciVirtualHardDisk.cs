using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStackHciVirtualHardDiskTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    public TerraformProperty<TerraformProperty<double>>? BlockSizeInBytes { get; set; }

    /// <summary>
    /// The custom_location_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomLocationId is required")]
    [TerraformPropertyName("custom_location_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CustomLocationId { get; set; }

    /// <summary>
    /// The disk_file_format attribute.
    /// </summary>
    [TerraformPropertyName("disk_file_format")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DiskFileFormat { get; set; }

    /// <summary>
    /// The disk_size_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskSizeInGb is required")]
    [TerraformPropertyName("disk_size_in_gb")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> DiskSizeInGb { get; set; }

    /// <summary>
    /// The dynamic_enabled attribute.
    /// </summary>
    [TerraformPropertyName("dynamic_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DynamicEnabled { get; set; }

    /// <summary>
    /// The hyperv_generation attribute.
    /// </summary>
    [TerraformPropertyName("hyperv_generation")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HypervGeneration { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The logical_sector_in_bytes attribute.
    /// </summary>
    [TerraformPropertyName("logical_sector_in_bytes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? LogicalSectorInBytes { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The physical_sector_in_bytes attribute.
    /// </summary>
    [TerraformPropertyName("physical_sector_in_bytes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? PhysicalSectorInBytes { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The storage_path_id attribute.
    /// </summary>
    [TerraformPropertyName("storage_path_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StoragePathId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermStackHciVirtualHardDiskTimeoutsBlock>? Timeouts { get; set; } = new();

}
