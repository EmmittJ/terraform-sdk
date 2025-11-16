using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerRegistryTaskScheduleRunNowTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_container_registry_task_schedule_run_now Terraform resource.
/// Manages a azurerm_container_registry_task_schedule_run_now resource.
/// </summary>
public partial class AzurermContainerRegistryTaskScheduleRunNow(string name) : TerraformResource("azurerm_container_registry_task_schedule_run_now", name)
{
    /// <summary>
    /// The container_registry_task_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerRegistryTaskId is required")]
    public required TerraformValue<string> ContainerRegistryTaskId
    {
        get => new TerraformReference<string>(this, "container_registry_task_id");
        set => SetArgument("container_registry_task_id", value);
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
    public AzurermContainerRegistryTaskScheduleRunNowTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermContainerRegistryTaskScheduleRunNowTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
