using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerRegistryTaskScheduleRunNowTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Manages a azurerm_container_registry_task_schedule_run_now resource.
/// </summary>
public class AzurermContainerRegistryTaskScheduleRunNow : TerraformResource
{
    public AzurermContainerRegistryTaskScheduleRunNow(string name) : base("azurerm_container_registry_task_schedule_run_now", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("container_registry_task_id");
        SetOutput("id");
    }

    /// <summary>
    /// The container_registry_task_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerRegistryTaskId is required")]
    public required TerraformProperty<string> ContainerRegistryTaskId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("container_registry_task_id");
        set => SetProperty("container_registry_task_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermContainerRegistryTaskScheduleRunNowTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
