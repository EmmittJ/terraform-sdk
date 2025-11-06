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
    public double? BlockSizeInBytes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("block_size_in_bytes")?.Value;
        set => this.WithProperty("block_size_in_bytes", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The custom_location_id attribute.
    /// </summary>
    public string? CustomLocationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_location_id")?.Value;
        set => this.WithProperty("custom_location_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The disk_file_format attribute.
    /// </summary>
    public string? DiskFileFormat
    {
        get => GetProperty<TerraformLiteralProperty<string>>("disk_file_format")?.Value;
        set => this.WithProperty("disk_file_format", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The disk_size_in_gb attribute.
    /// </summary>
    public double? DiskSizeInGb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("disk_size_in_gb")?.Value;
        set => this.WithProperty("disk_size_in_gb", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The dynamic_enabled attribute.
    /// </summary>
    public bool? DynamicEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("dynamic_enabled")?.Value;
        set => this.WithProperty("dynamic_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The hyperv_generation attribute.
    /// </summary>
    public string? HypervGeneration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hyperv_generation")?.Value;
        set => this.WithProperty("hyperv_generation", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The logical_sector_in_bytes attribute.
    /// </summary>
    public double? LogicalSectorInBytes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("logical_sector_in_bytes")?.Value;
        set => this.WithProperty("logical_sector_in_bytes", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The physical_sector_in_bytes attribute.
    /// </summary>
    public double? PhysicalSectorInBytes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("physical_sector_in_bytes")?.Value;
        set => this.WithProperty("physical_sector_in_bytes", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_path_id attribute.
    /// </summary>
    public string? StoragePathId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_path_id")?.Value;
        set => this.WithProperty("storage_path_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
