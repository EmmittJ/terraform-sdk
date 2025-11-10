using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermArcMachineAutomanageConfigurationAssignmentTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_arc_machine_automanage_configuration_assignment resource.
/// </summary>
public class AzurermArcMachineAutomanageConfigurationAssignment : TerraformResource
{
    public AzurermArcMachineAutomanageConfigurationAssignment(string name) : base("azurerm_arc_machine_automanage_configuration_assignment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The arc_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArcMachineId is required")]
    public required TerraformProperty<string> ArcMachineId
    {
        get => GetProperty<TerraformProperty<string>>("arc_machine_id");
        set => this.WithProperty("arc_machine_id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermArcMachineAutomanageConfigurationAssignmentTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermArcMachineAutomanageConfigurationAssignmentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
