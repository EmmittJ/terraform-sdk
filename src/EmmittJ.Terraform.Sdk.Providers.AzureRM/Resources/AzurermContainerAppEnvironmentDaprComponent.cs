using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for metadata in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppEnvironmentDaprComponentMetadataBlock : TerraformBlock
{
    /// <summary>
    /// The name of the Metadata configuration item.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The name of a secret specified in the `secrets` block that contains the value for this metadata configuration item.
    /// </summary>
    public TerraformProperty<string>? SecretName
    {
        get => GetProperty<TerraformProperty<string>>("secret_name");
        set => WithProperty("secret_name", value);
    }

    /// <summary>
    /// The value for this metadata configuration item.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for secret in .
/// Nesting mode: set
/// </summary>
public class AzurermContainerAppEnvironmentDaprComponentSecretBlock : TerraformBlock
{
    /// <summary>
    /// The identity to use for accessing key vault reference.
    /// </summary>
    public TerraformProperty<string>? Identity
    {
        get => GetProperty<TerraformProperty<string>>("identity");
        set => WithProperty("identity", value);
    }

    /// <summary>
    /// The Key Vault Secret ID. Could be either one of `id` or `versionless_id`.
    /// </summary>
    public TerraformProperty<string>? KeyVaultSecretId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_secret_id");
        set => WithProperty("key_vault_secret_id", value);
    }

    /// <summary>
    /// The secret name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The value for this secret.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerAppEnvironmentDaprComponentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComponentType is required")]
    public required TerraformProperty<string> ComponentType
    {
        get => GetProperty<TerraformProperty<string>>("component_type");
        set => this.WithProperty("component_type", value);
    }

    /// <summary>
    /// The Container App Managed Environment ID to configure this Dapr component on.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerAppEnvironmentId is required")]
    public required TerraformProperty<string> ContainerAppEnvironmentId
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// A list of scopes to which this component applies. e.g. a Container App&#39;s `dapr.app_id` value.
    /// </summary>
    public List<TerraformProperty<string>>? Scopes
    {
        get => GetProperty<List<TerraformProperty<string>>>("scopes");
        set => this.WithProperty("scopes", value);
    }

    /// <summary>
    /// The version of the component.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// Block for metadata.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermContainerAppEnvironmentDaprComponentMetadataBlock>? Metadata
    {
        get => GetProperty<List<AzurermContainerAppEnvironmentDaprComponentMetadataBlock>>("metadata");
        set => this.WithProperty("metadata", value);
    }

    /// <summary>
    /// Block for secret.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermContainerAppEnvironmentDaprComponentSecretBlock>? Secret
    {
        get => GetProperty<HashSet<AzurermContainerAppEnvironmentDaprComponentSecretBlock>>("secret");
        set => this.WithProperty("secret", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermContainerAppEnvironmentDaprComponentTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermContainerAppEnvironmentDaprComponentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
