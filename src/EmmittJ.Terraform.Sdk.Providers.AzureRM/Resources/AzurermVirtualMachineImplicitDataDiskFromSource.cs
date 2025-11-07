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
    public TerraformLiteralProperty<string>? Caching
    {
        get => GetProperty<TerraformLiteralProperty<string>>("caching");
        set => this.WithProperty("caching", value);
    }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CreateOption
    {
        get => GetProperty<TerraformLiteralProperty<string>>("create_option");
        set => this.WithProperty("create_option", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? DiskSizeGb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("disk_size_gb");
        set => this.WithProperty("disk_size_gb", value);
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
    /// The lun attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Lun
    {
        get => GetProperty<TerraformLiteralProperty<double>>("lun");
        set => this.WithProperty("lun", value);
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
    /// The source_resource_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_resource_id");
        set => this.WithProperty("source_resource_id", value);
    }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VirtualMachineId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_machine_id");
        set => this.WithProperty("virtual_machine_id", value);
    }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? WriteAcceleratorEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("write_accelerator_enabled");
        set => this.WithProperty("write_accelerator_enabled", value);
    }

}
