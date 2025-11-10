using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgentTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a azurerm_system_center_virtual_machine_manager_virtual_machine_instance_guest_agent resource.
/// </summary>
public class AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgent : TerraformResource
{
    public AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgent(string name) : base("azurerm_system_center_virtual_machine_manager_virtual_machine_instance_guest_agent", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("password");
        SetOutput("provisioning_action");
        SetOutput("scoped_resource_id");
        SetOutput("username");
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
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformProperty<string> Password
    {
        get => GetRequiredOutput<TerraformProperty<string>>("password");
        set => SetProperty("password", value);
    }

    /// <summary>
    /// The provisioning_action attribute.
    /// </summary>
    public TerraformProperty<string> ProvisioningAction
    {
        get => GetRequiredOutput<TerraformProperty<string>>("provisioning_action");
        set => SetProperty("provisioning_action", value);
    }

    /// <summary>
    /// The scoped_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopedResourceId is required")]
    public required TerraformProperty<string> ScopedResourceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("scoped_resource_id");
        set => SetProperty("scoped_resource_id", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        get => GetRequiredOutput<TerraformProperty<string>>("username");
        set => SetProperty("username", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
