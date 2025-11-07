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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Password
    {
        get => GetProperty<TerraformLiteralProperty<string>>("password");
        set => this.WithProperty("password", value);
    }

    /// <summary>
    /// The provisioning_action attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ProvisioningAction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("provisioning_action");
        set => this.WithProperty("provisioning_action", value);
    }

    /// <summary>
    /// The scoped_resource_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ScopedResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scoped_resource_id");
        set => this.WithProperty("scoped_resource_id", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Username
    {
        get => GetProperty<TerraformLiteralProperty<string>>("username");
        set => this.WithProperty("username", value);
    }

}
