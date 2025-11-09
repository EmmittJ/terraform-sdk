using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_container_registry_task resource.
/// </summary>
public class AzurermContainerRegistryTask : TerraformResource
{
    public AzurermContainerRegistryTask(string name) : base("azurerm_container_registry_task", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The agent_pool_name attribute.
    /// </summary>
    public TerraformProperty<string>? AgentPoolName
    {
        get => GetProperty<TerraformProperty<string>>("agent_pool_name");
        set => this.WithProperty("agent_pool_name", value);
    }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    public TerraformProperty<string>? ContainerRegistryId
    {
        get => GetProperty<TerraformProperty<string>>("container_registry_id");
        set => this.WithProperty("container_registry_id", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
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
    /// The is_system_task attribute.
    /// </summary>
    public TerraformProperty<bool>? IsSystemTask
    {
        get => GetProperty<TerraformProperty<bool>>("is_system_task");
        set => this.WithProperty("is_system_task", value);
    }

    /// <summary>
    /// The log_template attribute.
    /// </summary>
    public TerraformProperty<string>? LogTemplate
    {
        get => GetProperty<TerraformProperty<string>>("log_template");
        set => this.WithProperty("log_template", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? TimeoutInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("timeout_in_seconds");
        set => this.WithProperty("timeout_in_seconds", value);
    }

}
