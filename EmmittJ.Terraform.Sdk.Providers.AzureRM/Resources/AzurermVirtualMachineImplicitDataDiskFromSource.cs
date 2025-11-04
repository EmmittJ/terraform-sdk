using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_virtual_machine_implicit_data_disk_from_source resource.
/// </summary>
public class AzurermVirtualMachineImplicitDataDiskFromSource : TerraformResource
{
    public AzurermVirtualMachineImplicitDataDiskFromSource(string name) : base("azurerm_virtual_machine_implicit_data_disk_from_source", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The caching attribute.
    /// </summary>
    public string? Caching
    {
        get => GetProperty<TerraformLiteralProperty<string>>("caching")?.Value;
        set => this.WithProperty("caching", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    public string? CreateOption
    {
        get => GetProperty<TerraformLiteralProperty<string>>("create_option")?.Value;
        set => this.WithProperty("create_option", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    public double? DiskSizeGb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("disk_size_gb")?.Value;
        set => this.WithProperty("disk_size_gb", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The lun attribute.
    /// </summary>
    public double? Lun
    {
        get => GetProperty<TerraformLiteralProperty<double>>("lun")?.Value;
        set => this.WithProperty("lun", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The source_resource_id attribute.
    /// </summary>
    public string? SourceResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_resource_id")?.Value;
        set => this.WithProperty("source_resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    public string? VirtualMachineId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_machine_id")?.Value;
        set => this.WithProperty("virtual_machine_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    public bool? WriteAcceleratorEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("write_accelerator_enabled")?.Value;
        set => this.WithProperty("write_accelerator_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

}
