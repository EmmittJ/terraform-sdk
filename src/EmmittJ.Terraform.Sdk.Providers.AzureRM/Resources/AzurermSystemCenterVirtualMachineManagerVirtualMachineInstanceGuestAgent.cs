using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    /// The password attribute.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => this.WithProperty("password", value);
    }

    /// <summary>
    /// The provisioning_action attribute.
    /// </summary>
    public TerraformProperty<string>? ProvisioningAction
    {
        get => GetProperty<TerraformProperty<string>>("provisioning_action");
        set => this.WithProperty("provisioning_action", value);
    }

    /// <summary>
    /// The scoped_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? ScopedResourceId
    {
        get => GetProperty<TerraformProperty<string>>("scoped_resource_id");
        set => this.WithProperty("scoped_resource_id", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformProperty<string>? Username
    {
        get => GetProperty<TerraformProperty<string>>("username");
        set => this.WithProperty("username", value);
    }

}
