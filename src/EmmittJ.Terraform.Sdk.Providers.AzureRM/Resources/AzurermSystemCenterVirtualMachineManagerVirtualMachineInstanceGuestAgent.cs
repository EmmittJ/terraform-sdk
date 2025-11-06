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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public string? Password
    {
        get => GetProperty<TerraformLiteralProperty<string>>("password")?.Value;
        set => this.WithProperty("password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The provisioning_action attribute.
    /// </summary>
    public string? ProvisioningAction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("provisioning_action")?.Value;
        set => this.WithProperty("provisioning_action", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The scoped_resource_id attribute.
    /// </summary>
    public string? ScopedResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scoped_resource_id")?.Value;
        set => this.WithProperty("scoped_resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public string? Username
    {
        get => GetProperty<TerraformLiteralProperty<string>>("username")?.Value;
        set => this.WithProperty("username", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
