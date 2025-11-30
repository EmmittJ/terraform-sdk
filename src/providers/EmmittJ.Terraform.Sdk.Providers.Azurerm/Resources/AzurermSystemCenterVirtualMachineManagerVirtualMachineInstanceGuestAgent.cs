using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgent.
/// Nesting mode: single
/// </summary>
public class AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgentTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_system_center_virtual_machine_manager_virtual_machine_instance_guest_agent Terraform resource.
/// Manages a azurerm_system_center_virtual_machine_manager_virtual_machine_instance_guest_agent resource.
/// </summary>
public partial class AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgent(string name) : TerraformResource("azurerm_system_center_virtual_machine_manager_virtual_machine_instance_guest_agent", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The provisioning_action attribute.
    /// </summary>
    public TerraformValue<string>? ProvisioningAction
    {
        get => new TerraformReference<string>(this, "provisioning_action");
        set => SetArgument("provisioning_action", value);
    }

    /// <summary>
    /// The scoped_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopedResourceId is required")]
    public required TerraformValue<string> ScopedResourceId
    {
        get => new TerraformReference<string>(this, "scoped_resource_id");
        set => SetArgument("scoped_resource_id", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
