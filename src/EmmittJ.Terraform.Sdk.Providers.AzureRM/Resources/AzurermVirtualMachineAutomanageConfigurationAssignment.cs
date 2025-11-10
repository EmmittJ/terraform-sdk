using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualMachineAutomanageConfigurationAssignmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationId is required")]
    public required TerraformProperty<string> ConfigurationId
    {
        get => GetProperty<TerraformProperty<string>>("configuration_id");
        set => this.WithProperty("configuration_id", value);
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
    /// The virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineId is required")]
    public required TerraformProperty<string> VirtualMachineId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_machine_id");
        set => this.WithProperty("virtual_machine_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualMachineAutomanageConfigurationAssignmentTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermVirtualMachineAutomanageConfigurationAssignmentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
