using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "dedicated_host_id");
        set => SetArgument("dedicated_host_id", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The maintenance_configuration_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceConfigurationId is required")]
    public required TerraformValue<string> MaintenanceConfigurationId
    {
        get => new TerraformReference<string>(this, "maintenance_configuration_id");
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
