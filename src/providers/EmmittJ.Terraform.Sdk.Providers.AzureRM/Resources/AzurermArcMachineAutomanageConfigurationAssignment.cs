using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "arc_machine_id");
        set => SetArgument("arc_machine_id", value);
    }

    /// <summary>
    /// The configuration_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationId is required")]
    public required TerraformValue<string> ConfigurationId
    {
        get => new TerraformReference<string>(this, "configuration_id");
        set => SetArgument("configuration_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
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
