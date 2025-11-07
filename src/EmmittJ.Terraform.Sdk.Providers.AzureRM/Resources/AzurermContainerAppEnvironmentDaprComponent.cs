using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_container_app_environment_dapr_component resource.
/// </summary>
public class AzurermContainerAppEnvironmentDaprComponent : TerraformResource
{
    public AzurermContainerAppEnvironmentDaprComponent(string name) : base("azurerm_container_app_environment_dapr_component", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The Dapr Component Type. For example `state.azure.blobstorage`.
    /// </summary>
    public TerraformProperty<string>? ComponentType
    {
        get => GetProperty<TerraformProperty<string>>("component_type");
        set => this.WithProperty("component_type", value);
    }

    /// <summary>
    /// The Container App Managed Environment ID to configure this Dapr component on.
    /// </summary>
    public TerraformProperty<string>? ContainerAppEnvironmentId
    {
        get => GetProperty<TerraformProperty<string>>("container_app_environment_id");
        set => this.WithProperty("container_app_environment_id", value);
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
    /// Should the Dapr sidecar to continue initialisation if the component fails to load. Defaults to `false`
    /// </summary>
    public TerraformProperty<bool>? IgnoreErrors
    {
        get => GetProperty<TerraformProperty<bool>>("ignore_errors");
        set => this.WithProperty("ignore_errors", value);
    }

    /// <summary>
    /// The component initialisation timeout in ISO8601 format. e.g. `5s`, `2h`, `1m`. Defaults to `5s`.
    /// </summary>
    public TerraformProperty<string>? InitTimeout
    {
        get => GetProperty<TerraformProperty<string>>("init_timeout");
        set => this.WithProperty("init_timeout", value);
    }

    /// <summary>
    /// The name for this Dapr Component.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// A list of scopes to which this component applies. e.g. a Container App&#39;s `dapr.app_id` value.
    /// </summary>
    public TerraformProperty<List<string>>? Scopes
    {
        get => GetProperty<TerraformProperty<List<string>>>("scopes");
        set => this.WithProperty("scopes", value);
    }

    /// <summary>
    /// The version of the component.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

}
