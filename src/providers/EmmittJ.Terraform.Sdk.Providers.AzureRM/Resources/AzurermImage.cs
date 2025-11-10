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
        set => SetProperty("blob_uri", value);
    }

    /// <summary>
    /// The caching attribute.
    /// </summary>
    public TerraformProperty<string>? Caching
    {
        set => SetProperty("caching", value);
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? DiskEncryptionSetId
    {
        set => SetProperty("disk_encryption_set_id", value);
    }

    /// <summary>
    /// The lun attribute.
    /// </summary>
    public TerraformProperty<double>? Lun
    {
        set => SetProperty("lun", value);
    }

    /// <summary>
    /// The managed_disk_id attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedDiskId
    {
        set => SetProperty("managed_disk_id", value);
    }

    /// <summary>
    /// The size_gb attribute.
    /// </summary>
    public TerraformProperty<double>? SizeGb
    {
        set => SetProperty("size_gb", value);
    }

    /// <summary>
    /// The type of storage disk
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageType is required")]
    public required TerraformProperty<string> StorageType
    {
        set => SetProperty("storage_type", value);
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
        set => SetProperty("blob_uri", value);
    }

    /// <summary>
    /// The caching attribute.
    /// </summary>
    public TerraformProperty<string>? Caching
    {
        set => SetProperty("caching", value);
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? DiskEncryptionSetId
    {
        set => SetProperty("disk_encryption_set_id", value);
    }

    /// <summary>
    /// The managed_disk_id attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedDiskId
    {
        set => SetProperty("managed_disk_id", value);
    }

    /// <summary>
    /// The os_state attribute.
    /// </summary>
    public TerraformProperty<string>? OsState
    {
        set => SetProperty("os_state", value);
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformProperty<string>? OsType
    {
        set => SetProperty("os_type", value);
    }

    /// <summary>
    /// The size_gb attribute.
    /// </summary>
    public TerraformProperty<double>? SizeGb
    {
        set => SetProperty("size_gb", value);
    }

    /// <summary>
    /// The type of storage disk
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageType is required")]
    public required TerraformProperty<string> StorageType
    {
        set => SetProperty("storage_type", value);
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
        SetOutput("hyper_v_generation");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("source_virtual_machine_id");
        SetOutput("tags");
        SetOutput("zone_resilient");
    }

    /// <summary>
    /// The hyper_v_generation attribute.
    /// </summary>
    public TerraformProperty<string> HyperVGeneration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("hyper_v_generation");
        set => SetProperty("hyper_v_generation", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The source_virtual_machine_id attribute.
    /// </summary>
    public TerraformProperty<string> SourceVirtualMachineId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_virtual_machine_id");
        set => SetProperty("source_virtual_machine_id", value);
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
    /// The zone_resilient attribute.
    /// </summary>
    public TerraformProperty<bool> ZoneResilient
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("zone_resilient");
        set => SetProperty("zone_resilient", value);
    }

    /// <summary>
    /// Block for data_disk.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermImageDataDiskBlock>? DataDisk
    {
        set => SetProperty("data_disk", value);
    }

    /// <summary>
    /// Block for os_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsDisk block(s) allowed")]
    public List<AzurermImageOsDiskBlock>? OsDisk
    {
        set => SetProperty("os_disk", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermImageTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
