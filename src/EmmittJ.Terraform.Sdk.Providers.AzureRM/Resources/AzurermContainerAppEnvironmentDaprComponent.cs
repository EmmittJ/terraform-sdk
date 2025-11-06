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
    public string? ComponentType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("component_type")?.Value;
        set => this.WithProperty("component_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Container App Managed Environment ID to configure this Dapr component on.
    /// </summary>
    public string? ContainerAppEnvironmentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_app_environment_id")?.Value;
        set => this.WithProperty("container_app_environment_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Should the Dapr sidecar to continue initialisation if the component fails to load. Defaults to `false`
    /// </summary>
    public bool? IgnoreErrors
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ignore_errors")?.Value;
        set => this.WithProperty("ignore_errors", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The component initialisation timeout in ISO8601 format. e.g. `5s`, `2h`, `1m`. Defaults to `5s`.
    /// </summary>
    public string? InitTimeout
    {
        get => GetProperty<TerraformLiteralProperty<string>>("init_timeout")?.Value;
        set => this.WithProperty("init_timeout", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name for this Dapr Component.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A list of scopes to which this component applies. e.g. a Container App&#39;s `dapr.app_id` value.
    /// </summary>
    public List<string>? Scopes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("scopes")?.Value;
        set => this.WithProperty("scopes", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The version of the component.
    /// </summary>
    public string? Version
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version")?.Value;
        set => this.WithProperty("version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
