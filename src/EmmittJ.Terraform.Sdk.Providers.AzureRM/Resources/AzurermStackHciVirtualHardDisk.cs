using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public TerraformLiteralProperty<double>? BlockSizeInBytes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("block_size_in_bytes");
        set => this.WithProperty("block_size_in_bytes", value);
    }

    /// <summary>
    /// The custom_location_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CustomLocationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_location_id");
        set => this.WithProperty("custom_location_id", value);
    }

    /// <summary>
    /// The disk_file_format attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DiskFileFormat
    {
        get => GetProperty<TerraformLiteralProperty<string>>("disk_file_format");
        set => this.WithProperty("disk_file_format", value);
    }

    /// <summary>
    /// The disk_size_in_gb attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? DiskSizeInGb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("disk_size_in_gb");
        set => this.WithProperty("disk_size_in_gb", value);
    }

    /// <summary>
    /// The dynamic_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? DynamicEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("dynamic_enabled");
        set => this.WithProperty("dynamic_enabled", value);
    }

    /// <summary>
    /// The hyperv_generation attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HypervGeneration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hyperv_generation");
        set => this.WithProperty("hyperv_generation", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The logical_sector_in_bytes attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? LogicalSectorInBytes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("logical_sector_in_bytes");
        set => this.WithProperty("logical_sector_in_bytes", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The physical_sector_in_bytes attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? PhysicalSectorInBytes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("physical_sector_in_bytes");
        set => this.WithProperty("physical_sector_in_bytes", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The storage_path_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StoragePathId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_path_id");
        set => this.WithProperty("storage_path_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
