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
    /// The managed_disk_id attribute.
    /// </summary>
    public string? ManagedDiskId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_disk_id")?.Value;
        set => this.WithProperty("managed_disk_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
