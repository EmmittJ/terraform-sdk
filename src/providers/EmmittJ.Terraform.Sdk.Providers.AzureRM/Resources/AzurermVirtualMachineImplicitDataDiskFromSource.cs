using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualMachineImplicitDataDiskFromSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_virtual_machine_implicit_data_disk_from_source resource.
/// </summary>
public class AzurermVirtualMachineImplicitDataDiskFromSource : TerraformResource
{
    public AzurermVirtualMachineImplicitDataDiskFromSource(string name) : base("azurerm_virtual_machine_implicit_data_disk_from_source", name)
    {
    }

    /// <summary>
    /// The caching attribute.
    /// </summary>
    [TerraformArgument("caching")]
    public TerraformValue<string>? Caching
    {
        get => new TerraformReference<string>(this, "caching");
        set => SetArgument("caching", value);
    }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreateOption is required")]
    [TerraformArgument("create_option")]
    public required TerraformValue<string> CreateOption
    {
        get => new TerraformReference<string>(this, "create_option");
        set => SetArgument("create_option", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskSizeGb is required")]
    [TerraformArgument("disk_size_gb")]
    public required TerraformValue<double> DiskSizeGb
    {
        get => new TerraformReference<double>(this, "disk_size_gb");
        set => SetArgument("disk_size_gb", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The lun attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lun is required")]
    [TerraformArgument("lun")]
    public required TerraformValue<double> Lun
    {
        get => new TerraformReference<double>(this, "lun");
        set => SetArgument("lun", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceResourceId is required")]
    [TerraformArgument("source_resource_id")]
    public required TerraformValue<string> SourceResourceId
    {
        get => new TerraformReference<string>(this, "source_resource_id");
        set => SetArgument("source_resource_id", value);
    }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineId is required")]
    [TerraformArgument("virtual_machine_id")]
    public required TerraformValue<string> VirtualMachineId
    {
        get => new TerraformReference<string>(this, "virtual_machine_id");
        set => SetArgument("virtual_machine_id", value);
    }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    [TerraformArgument("write_accelerator_enabled")]
    public TerraformValue<bool>? WriteAcceleratorEnabled
    {
        get => new TerraformReference<bool>(this, "write_accelerator_enabled");
        set => SetArgument("write_accelerator_enabled", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermVirtualMachineImplicitDataDiskFromSourceTimeoutsBlock Timeouts { get; set; } = new();

}
