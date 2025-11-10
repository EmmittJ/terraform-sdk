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
        SetOutput("caching");
        SetOutput("create_option");
        SetOutput("id");
        SetOutput("lun");
        SetOutput("managed_disk_id");
        SetOutput("virtual_machine_id");
        SetOutput("write_accelerator_enabled");
    }

    /// <summary>
    /// The caching attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Caching is required")]
    public required TerraformProperty<string> Caching
    {
        get => GetRequiredOutput<TerraformProperty<string>>("caching");
        set => SetProperty("caching", value);
    }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    public TerraformProperty<string> CreateOption
    {
        get => GetRequiredOutput<TerraformProperty<string>>("create_option");
        set => SetProperty("create_option", value);
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
    /// The lun attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lun is required")]
    public required TerraformProperty<double> Lun
    {
        get => GetRequiredOutput<TerraformProperty<double>>("lun");
        set => SetProperty("lun", value);
    }

    /// <summary>
    /// The managed_disk_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedDiskId is required")]
    public required TerraformProperty<string> ManagedDiskId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("managed_disk_id");
        set => SetProperty("managed_disk_id", value);
    }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineId is required")]
    public required TerraformProperty<string> VirtualMachineId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("virtual_machine_id");
        set => SetProperty("virtual_machine_id", value);
    }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> WriteAcceleratorEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("write_accelerator_enabled");
        set => SetProperty("write_accelerator_enabled", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualMachineDataDiskAttachmentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
