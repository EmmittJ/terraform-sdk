using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermArcMachineAutomanageConfigurationAssignment.
/// Nesting mode: single
/// </summary>
public class AzurermArcMachineAutomanageConfigurationAssignmentTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a azurerm_arc_machine_automanage_configuration_assignment Terraform resource.
/// Manages a azurerm_arc_machine_automanage_configuration_assignment resource.
/// </summary>
public partial class AzurermArcMachineAutomanageConfigurationAssignment(string name) : TerraformResource("azurerm_arc_machine_automanage_configuration_assignment", name)
{
    /// <summary>
    /// The arc_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArcMachineId is required")]
    public required TerraformValue<string> ArcMachineId
    {
        get => GetRequiredArgument<TerraformValue<string>>("arc_machine_id");
        set => SetArgument("arc_machine_id", value);
    }

    /// <summary>
    /// The configuration_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationId is required")]
    public required TerraformValue<string> ConfigurationId
    {
        get => GetRequiredArgument<TerraformValue<string>>("configuration_id");
        set => SetArgument("configuration_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermArcMachineAutomanageConfigurationAssignmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermArcMachineAutomanageConfigurationAssignmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
