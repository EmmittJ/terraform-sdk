using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for data_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermImageDataDiskBlock : TerraformBlock
{
    /// <summary>
    /// The blob_uri attribute.
    /// </summary>
    public TerraformProperty<string>? BlobUri
    {
        get => GetProperty<TerraformProperty<string>>("blob_uri");
        set => WithProperty("blob_uri", value);
    }

    /// <summary>
    /// The caching attribute.
    /// </summary>
    public TerraformProperty<string>? Caching
    {
        get => GetProperty<TerraformProperty<string>>("caching");
        set => WithProperty("caching", value);
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? DiskEncryptionSetId
    {
        get => GetProperty<TerraformProperty<string>>("disk_encryption_set_id");
        set => WithProperty("disk_encryption_set_id", value);
    }

    /// <summary>
    /// The lun attribute.
    /// </summary>
    public TerraformProperty<double>? Lun
    {
        get => GetProperty<TerraformProperty<double>>("lun");
        set => WithProperty("lun", value);
    }

    /// <summary>
    /// The managed_disk_id attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedDiskId
    {
        get => GetProperty<TerraformProperty<string>>("managed_disk_id");
        set => WithProperty("managed_disk_id", value);
    }

    /// <summary>
    /// The size_gb attribute.
    /// </summary>
    public TerraformProperty<double>? SizeGb
    {
        get => GetProperty<TerraformProperty<double>>("size_gb");
        set => WithProperty("size_gb", value);
    }

    /// <summary>
    /// The type of storage disk
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageType is required")]
    public required TerraformProperty<string> StorageType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("storage_type");
        set => WithProperty("storage_type", value);
    }

}

/// <summary>
/// Block type for os_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermImageOsDiskBlock : TerraformBlock
{
    /// <summary>
    /// The blob_uri attribute.
    /// </summary>
    public TerraformProperty<string>? BlobUri
    {
        get => GetProperty<TerraformProperty<string>>("blob_uri");
        set => WithProperty("blob_uri", value);
    }

    /// <summary>
    /// The caching attribute.
    /// </summary>
    public TerraformProperty<string>? Caching
    {
        get => GetProperty<TerraformProperty<string>>("caching");
        set => WithProperty("caching", value);
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? DiskEncryptionSetId
    {
        get => GetProperty<TerraformProperty<string>>("disk_encryption_set_id");
        set => WithProperty("disk_encryption_set_id", value);
    }

    /// <summary>
    /// The managed_disk_id attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedDiskId
    {
        get => GetProperty<TerraformProperty<string>>("managed_disk_id");
        set => WithProperty("managed_disk_id", value);
    }

    /// <summary>
    /// The os_state attribute.
    /// </summary>
    public TerraformProperty<string>? OsState
    {
        get => GetProperty<TerraformProperty<string>>("os_state");
        set => WithProperty("os_state", value);
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformProperty<string>? OsType
    {
        get => GetProperty<TerraformProperty<string>>("os_type");
        set => WithProperty("os_type", value);
    }

    /// <summary>
    /// The size_gb attribute.
    /// </summary>
    public TerraformProperty<double>? SizeGb
    {
        get => GetProperty<TerraformProperty<double>>("size_gb");
        set => WithProperty("size_gb", value);
    }

    /// <summary>
    /// The type of storage disk
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageType is required")]
    public required TerraformProperty<string> StorageType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("storage_type");
        set => WithProperty("storage_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermImageTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_image resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermImage : TerraformResource
{
    public AzurermImage(string name) : base("azurerm_image", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The hyper_v_generation attribute.
    /// </summary>
    public TerraformProperty<string>? HyperVGeneration
    {
        get => GetProperty<TerraformProperty<string>>("hyper_v_generation");
        set => this.WithProperty("hyper_v_generation", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The source_virtual_machine_id attribute.
    /// </summary>
    public TerraformProperty<string>? SourceVirtualMachineId
    {
        get => GetProperty<TerraformProperty<string>>("source_virtual_machine_id");
        set => this.WithProperty("source_virtual_machine_id", value);
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
    /// The zone_resilient attribute.
    /// </summary>
    public TerraformProperty<bool>? ZoneResilient
    {
        get => GetProperty<TerraformProperty<bool>>("zone_resilient");
        set => this.WithProperty("zone_resilient", value);
    }

    /// <summary>
    /// Block for data_disk.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermImageDataDiskBlock>? DataDisk
    {
        get => GetProperty<List<AzurermImageDataDiskBlock>>("data_disk");
        set => this.WithProperty("data_disk", value);
    }

    /// <summary>
    /// Block for os_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsDisk block(s) allowed")]
    public List<AzurermImageOsDiskBlock>? OsDisk
    {
        get => GetProperty<List<AzurermImageOsDiskBlock>>("os_disk");
        set => this.WithProperty("os_disk", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermImageTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermImageTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
