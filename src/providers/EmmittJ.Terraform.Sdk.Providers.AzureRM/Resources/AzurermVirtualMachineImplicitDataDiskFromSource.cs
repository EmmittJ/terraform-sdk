using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualMachineImplicitDataDiskFromSourceTimeoutsBlock : TerraformBlock
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
        SetOutput("caching");
        SetOutput("create_option");
        SetOutput("disk_size_gb");
        SetOutput("id");
        SetOutput("lun");
        SetOutput("name");
        SetOutput("source_resource_id");
        SetOutput("virtual_machine_id");
        SetOutput("write_accelerator_enabled");
    }

    /// <summary>
    /// The caching attribute.
    /// </summary>
    public TerraformProperty<string> Caching
    {
        get => GetRequiredOutput<TerraformProperty<string>>("caching");
        set => SetProperty("caching", value);
    }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreateOption is required")]
    public required TerraformProperty<string> CreateOption
    {
        get => GetRequiredOutput<TerraformProperty<string>>("create_option");
        set => SetProperty("create_option", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskSizeGb is required")]
    public required TerraformProperty<double> DiskSizeGb
    {
        get => GetRequiredOutput<TerraformProperty<double>>("disk_size_gb");
        set => SetProperty("disk_size_gb", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceResourceId is required")]
    public required TerraformProperty<string> SourceResourceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_resource_id");
        set => SetProperty("source_resource_id", value);
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
    public AzurermVirtualMachineImplicitDataDiskFromSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
