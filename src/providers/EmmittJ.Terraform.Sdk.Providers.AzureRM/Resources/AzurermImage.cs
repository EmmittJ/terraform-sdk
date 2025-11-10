using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for data_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermImageDataDiskBlock : ITerraformBlock
{
    /// <summary>
    /// The blob_uri attribute.
    /// </summary>
    [TerraformPropertyName("blob_uri")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> BlobUri { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "blob_uri");

    /// <summary>
    /// The caching attribute.
    /// </summary>
    [TerraformPropertyName("caching")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Caching { get; set; }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformPropertyName("disk_encryption_set_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DiskEncryptionSetId { get; set; }

    /// <summary>
    /// The lun attribute.
    /// </summary>
    [TerraformPropertyName("lun")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Lun { get; set; }

    /// <summary>
    /// The managed_disk_id attribute.
    /// </summary>
    [TerraformPropertyName("managed_disk_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ManagedDiskId { get; set; }

    /// <summary>
    /// The size_gb attribute.
    /// </summary>
    [TerraformPropertyName("size_gb")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> SizeGb { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "size_gb");

    /// <summary>
    /// The type of storage disk
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageType is required")]
    [TerraformPropertyName("storage_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageType { get; set; }

}

/// <summary>
/// Block type for os_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermImageOsDiskBlock : ITerraformBlock
{
    /// <summary>
    /// The blob_uri attribute.
    /// </summary>
    [TerraformPropertyName("blob_uri")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> BlobUri { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "blob_uri");

    /// <summary>
    /// The caching attribute.
    /// </summary>
    [TerraformPropertyName("caching")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Caching { get; set; }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformPropertyName("disk_encryption_set_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DiskEncryptionSetId { get; set; }

    /// <summary>
    /// The managed_disk_id attribute.
    /// </summary>
    [TerraformPropertyName("managed_disk_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ManagedDiskId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "managed_disk_id");

    /// <summary>
    /// The os_state attribute.
    /// </summary>
    [TerraformPropertyName("os_state")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OsState { get; set; }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [TerraformPropertyName("os_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OsType { get; set; }

    /// <summary>
    /// The size_gb attribute.
    /// </summary>
    [TerraformPropertyName("size_gb")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> SizeGb { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "size_gb");

    /// <summary>
    /// The type of storage disk
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageType is required")]
    [TerraformPropertyName("storage_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermImageTimeoutsBlock : ITerraformBlock
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
    [TerraformPropertyName("hyper_v_generation")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HyperVGeneration { get; set; }

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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The source_virtual_machine_id attribute.
    /// </summary>
    [TerraformPropertyName("source_virtual_machine_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceVirtualMachineId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The zone_resilient attribute.
    /// </summary>
    [TerraformPropertyName("zone_resilient")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ZoneResilient { get; set; }

    /// <summary>
    /// Block for data_disk.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("data_disk")]
    public TerraformList<TerraformBlock<AzurermImageDataDiskBlock>>? DataDisk { get; set; } = new();

    /// <summary>
    /// Block for os_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsDisk block(s) allowed")]
    [TerraformPropertyName("os_disk")]
    public TerraformList<TerraformBlock<AzurermImageOsDiskBlock>>? OsDisk { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermImageTimeoutsBlock>? Timeouts { get; set; } = new();

}
