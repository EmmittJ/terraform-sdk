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
public class AzurermVirtualMachineRestorePointTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a azurerm_virtual_machine_restore_point resource.
/// </summary>
public class AzurermVirtualMachineRestorePoint : TerraformResource
{
    public AzurermVirtualMachineRestorePoint(string name) : base("azurerm_virtual_machine_restore_point", name)
    {
    }

    /// <summary>
    /// The crash_consistency_mode_enabled attribute.
    /// </summary>
    [TerraformArgument("crash_consistency_mode_enabled")]
    public TerraformValue<bool>? CrashConsistencyModeEnabled
    {
        get => new TerraformReference<bool>(this, "crash_consistency_mode_enabled");
        set => SetArgument("crash_consistency_mode_enabled", value);
    }

    /// <summary>
    /// The excluded_disks attribute.
    /// </summary>
    [TerraformArgument("excluded_disks")]
    public TerraformSet<string>? ExcludedDisks
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "excluded_disks").ResolveNodes(ctx));
        set => SetArgument("excluded_disks", value);
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
    /// The virtual_machine_restore_point_collection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineRestorePointCollectionId is required")]
    [TerraformArgument("virtual_machine_restore_point_collection_id")]
    public required TerraformValue<string> VirtualMachineRestorePointCollectionId
    {
        get => new TerraformReference<string>(this, "virtual_machine_restore_point_collection_id");
        set => SetArgument("virtual_machine_restore_point_collection_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermVirtualMachineRestorePointTimeoutsBlock Timeouts { get; set; } = new();

}
