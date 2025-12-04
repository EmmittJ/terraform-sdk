using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermStorageMoverAgent.
/// Nesting mode: single
/// </summary>
public class AzurermStorageMoverAgentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_storage_mover_agent Terraform resource.
/// Manages a azurerm_storage_mover_agent resource.
/// </summary>
public partial class AzurermStorageMoverAgent(string name) : TerraformResource("azurerm_storage_mover_agent", name)
{
    /// <summary>
    /// The arc_virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArcVirtualMachineId is required")]
    public required TerraformValue<string> ArcVirtualMachineId
    {
        get => GetArgument<TerraformValue<string>>("arc_virtual_machine_id");
        set => SetArgument("arc_virtual_machine_id", value);
    }

    /// <summary>
    /// The arc_virtual_machine_uuid attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArcVirtualMachineUuid is required")]
    public required TerraformValue<string> ArcVirtualMachineUuid
    {
        get => GetArgument<TerraformValue<string>>("arc_virtual_machine_uuid");
        set => SetArgument("arc_virtual_machine_uuid", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The storage_mover_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageMoverId is required")]
    public required TerraformValue<string> StorageMoverId
    {
        get => GetArgument<TerraformValue<string>>("storage_mover_id");
        set => SetArgument("storage_mover_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStorageMoverAgentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStorageMoverAgentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
