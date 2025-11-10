using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualMachineDataDiskAttachmentTimeoutsBlock : TerraformBlock
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Caching is required")]
    public required TerraformProperty<string> Caching
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lun is required")]
    public required TerraformProperty<double> Lun
    {
        get => GetProperty<TerraformProperty<double>>("lun");
        set => this.WithProperty("lun", value);
    }

    /// <summary>
    /// The managed_disk_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedDiskId is required")]
    public required TerraformProperty<string> ManagedDiskId
    {
        get => GetProperty<TerraformProperty<string>>("managed_disk_id");
        set => this.WithProperty("managed_disk_id", value);
    }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineId is required")]
    public required TerraformProperty<string> VirtualMachineId
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

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualMachineDataDiskAttachmentTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermVirtualMachineDataDiskAttachmentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
