using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for data_disk in .
/// Nesting mode: list
/// </summary>
public partial class AzurermImageDataDiskBlock : TerraformBlockBase
{
    /// <summary>
    /// The blob_uri attribute.
    /// </summary>
    [TerraformProperty("blob_uri")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> BlobUri { get; set; }

    /// <summary>
    /// The caching attribute.
    /// </summary>
    [TerraformProperty("caching")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Caching { get; set; }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformProperty("disk_encryption_set_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DiskEncryptionSetId { get; set; }

    /// <summary>
    /// The lun attribute.
    /// </summary>
    [TerraformProperty("lun")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Lun { get; set; }

    /// <summary>
    /// The managed_disk_id attribute.
    /// </summary>
    [TerraformProperty("managed_disk_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ManagedDiskId { get; set; }

    /// <summary>
    /// The size_gb attribute.
    /// </summary>
    [TerraformProperty("size_gb")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> SizeGb { get; set; }

    /// <summary>
    /// The type of storage disk
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageType is required")]
    [TerraformProperty("storage_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StorageType { get; set; }

}

/// <summary>
/// Block type for os_disk in .
/// Nesting mode: list
/// </summary>
public partial class AzurermImageOsDiskBlock : TerraformBlockBase
{
    /// <summary>
    /// The blob_uri attribute.
    /// </summary>
    [TerraformProperty("blob_uri")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> BlobUri { get; set; }

    /// <summary>
    /// The caching attribute.
    /// </summary>
    [TerraformProperty("caching")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Caching { get; set; }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformProperty("disk_encryption_set_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DiskEncryptionSetId { get; set; }

    /// <summary>
    /// The managed_disk_id attribute.
    /// </summary>
    [TerraformProperty("managed_disk_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ManagedDiskId { get; set; }

    /// <summary>
    /// The os_state attribute.
    /// </summary>
    [TerraformProperty("os_state")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? OsState { get; set; }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [TerraformProperty("os_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? OsType { get; set; }

    /// <summary>
    /// The size_gb attribute.
    /// </summary>
    [TerraformProperty("size_gb")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> SizeGb { get; set; }

    /// <summary>
    /// The type of storage disk
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageType is required")]
    [TerraformProperty("storage_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StorageType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermImageTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_image resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermImage : TerraformResource
{
    public AzurermImage(string name) : base("azurerm_image", name)
    {
    }

    /// <summary>
    /// The hyper_v_generation attribute.
    /// </summary>
    [TerraformProperty("hyper_v_generation")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? HyperVGeneration { get; set; }

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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The source_virtual_machine_id attribute.
    /// </summary>
    [TerraformProperty("source_virtual_machine_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SourceVirtualMachineId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The zone_resilient attribute.
    /// </summary>
    [TerraformProperty("zone_resilient")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ZoneResilient { get; set; }

    /// <summary>
    /// Block for data_disk.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("data_disk")]
    public TerraformList<TerraformBlock<AzurermImageDataDiskBlock>>? DataDisk { get; set; }

    /// <summary>
    /// Block for os_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsDisk block(s) allowed")]
    [TerraformProperty("os_disk")]
    public TerraformList<TerraformBlock<AzurermImageOsDiskBlock>>? OsDisk { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermImageTimeoutsBlock>? Timeouts { get; set; }

}
