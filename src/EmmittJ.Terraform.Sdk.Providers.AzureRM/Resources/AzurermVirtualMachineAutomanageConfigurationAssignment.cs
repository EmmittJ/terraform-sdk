using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_virtual_machine_automanage_configuration_assignment resource.
/// </summary>
public class AzurermVirtualMachineAutomanageConfigurationAssignment : TerraformResource
{
    public AzurermVirtualMachineAutomanageConfigurationAssignment(string name) : base("azurerm_virtual_machine_automanage_configuration_assignment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The configuration_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ConfigurationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("configuration_id");
        set => this.WithProperty("configuration_id", value);
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
    /// The virtual_machine_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VirtualMachineId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_machine_id");
        set => this.WithProperty("virtual_machine_id", value);
    }

}
