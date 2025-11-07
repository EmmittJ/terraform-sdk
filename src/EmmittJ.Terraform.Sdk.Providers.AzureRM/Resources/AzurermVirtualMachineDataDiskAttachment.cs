using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_virtual_machine_data_disk_attachment resource.
/// </summary>
public class AzurermVirtualMachineDataDiskAttachment : TerraformResource
{
    public AzurermVirtualMachineDataDiskAttachment(string name) : base("azurerm_virtual_machine_data_disk_attachment", name)
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
    /// The managed_disk_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ManagedDiskId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_disk_id");
        set => this.WithProperty("managed_disk_id", value);
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
