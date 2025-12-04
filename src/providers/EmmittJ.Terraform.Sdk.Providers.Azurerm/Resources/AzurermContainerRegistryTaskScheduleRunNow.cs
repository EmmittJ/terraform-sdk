using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermContainerRegistryTaskScheduleRunNow.
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
        get => GetArgument<TerraformValue<string>>("container_registry_task_id");
        set => SetArgument("container_registry_task_id", value);
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
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermContainerRegistryTaskScheduleRunNowTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermContainerRegistryTaskScheduleRunNowTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
