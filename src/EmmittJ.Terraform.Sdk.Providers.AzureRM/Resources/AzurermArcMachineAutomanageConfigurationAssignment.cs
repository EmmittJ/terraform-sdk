using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public TerraformLiteralProperty<string>? ArcMachineId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("arc_machine_id");
        set => this.WithProperty("arc_machine_id", value);
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

}
