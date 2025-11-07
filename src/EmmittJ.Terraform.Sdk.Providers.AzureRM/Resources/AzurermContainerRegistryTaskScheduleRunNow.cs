using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    }

    /// <summary>
    /// The container_registry_task_id attribute.
    /// </summary>
    public TerraformProperty<string>? ContainerRegistryTaskId
    {
        get => GetProperty<TerraformProperty<string>>("container_registry_task_id");
        set => this.WithProperty("container_registry_task_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

}
