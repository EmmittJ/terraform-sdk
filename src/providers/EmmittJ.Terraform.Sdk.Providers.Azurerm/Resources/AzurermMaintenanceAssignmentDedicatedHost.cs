using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermMaintenanceAssignmentDedicatedHost.
/// Nesting mode: single
/// </summary>
public class AzurermMaintenanceAssignmentDedicatedHostTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_maintenance_assignment_dedicated_host Terraform resource.
/// Manages a azurerm_maintenance_assignment_dedicated_host resource.
/// </summary>
public partial class AzurermMaintenanceAssignmentDedicatedHost(string name) : TerraformResource("azurerm_maintenance_assignment_dedicated_host", name)
{
    /// <summary>
    /// The dedicated_host_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DedicatedHostId is required")]
    public required TerraformValue<string> DedicatedHostId
    {
        get => GetArgument<TerraformValue<string>>("dedicated_host_id");
        set => SetArgument("dedicated_host_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The maintenance_configuration_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceConfigurationId is required")]
    public required TerraformValue<string> MaintenanceConfigurationId
    {
        get => GetArgument<TerraformValue<string>>("maintenance_configuration_id");
        set => SetArgument("maintenance_configuration_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMaintenanceAssignmentDedicatedHostTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMaintenanceAssignmentDedicatedHostTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
