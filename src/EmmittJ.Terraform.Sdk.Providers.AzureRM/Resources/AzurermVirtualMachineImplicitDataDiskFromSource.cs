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
    public TerraformProperty<string>? Caching
    {
        get => GetProperty<TerraformProperty<string>>("caching");
        set => this.WithProperty("caching", value);
    }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    public TerraformProperty<string>? CreateOption
    {
        get => GetProperty<TerraformProperty<string>>("create_option");
        set => this.WithProperty("create_option", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    public TerraformProperty<double>? DiskSizeGb
    {
        get => GetProperty<TerraformProperty<double>>("disk_size_gb");
        set => this.WithProperty("disk_size_gb", value);
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
    /// The lun attribute.
    /// </summary>
    public TerraformProperty<double>? Lun
    {
        get => GetProperty<TerraformProperty<double>>("lun");
        set => this.WithProperty("lun", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? SourceResourceId
    {
        get => GetProperty<TerraformProperty<string>>("source_resource_id");
        set => this.WithProperty("source_resource_id", value);
    }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualMachineId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_machine_id");
        set => this.WithProperty("virtual_machine_id", value);
    }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? WriteAcceleratorEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("write_accelerator_enabled");
        set => this.WithProperty("write_accelerator_enabled", value);
    }

}
