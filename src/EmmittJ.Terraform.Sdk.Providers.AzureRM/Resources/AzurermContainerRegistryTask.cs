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
    public string? AgentPoolName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("agent_pool_name")?.Value;
        set => this.WithProperty("agent_pool_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    public string? ContainerRegistryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_registry_id")?.Value;
        set => this.WithProperty("container_registry_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The is_system_task attribute.
    /// </summary>
    public bool? IsSystemTask
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("is_system_task")?.Value;
        set => this.WithProperty("is_system_task", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The log_template attribute.
    /// </summary>
    public string? LogTemplate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("log_template")?.Value;
        set => this.WithProperty("log_template", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    public double? TimeoutInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("timeout_in_seconds")?.Value;
        set => this.WithProperty("timeout_in_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

}
