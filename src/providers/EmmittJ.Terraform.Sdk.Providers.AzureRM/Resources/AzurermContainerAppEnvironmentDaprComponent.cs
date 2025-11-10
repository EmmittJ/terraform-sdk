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
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The name of a secret specified in the `secrets` block that contains the value for this metadata configuration item.
    /// </summary>
    public TerraformProperty<string>? SecretName
    {
        set => SetProperty("secret_name", value);
    }

    /// <summary>
    /// The value for this metadata configuration item.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        set => SetProperty("value", value);
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
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// The Key Vault Secret ID. Could be either one of `id` or `versionless_id`.
    /// </summary>
    public TerraformProperty<string>? KeyVaultSecretId
    {
        set => SetProperty("key_vault_secret_id", value);
    }

    /// <summary>
    /// The secret name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The value for this secret.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        set => SetProperty("value", value);
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("component_type");
        SetOutput("container_app_environment_id");
        SetOutput("id");
        SetOutput("ignore_errors");
        SetOutput("init_timeout");
        SetOutput("name");
        SetOutput("scopes");
        SetOutput("version");
    }

    /// <summary>
    /// The Dapr Component Type. For example `state.azure.blobstorage`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComponentType is required")]
    public required TerraformProperty<string> ComponentType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("component_type");
        set => SetProperty("component_type", value);
    }

    /// <summary>
    /// The Container App Managed Environment ID to configure this Dapr component on.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerAppEnvironmentId is required")]
    public required TerraformProperty<string> ContainerAppEnvironmentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("container_app_environment_id");
        set => SetProperty("container_app_environment_id", value);
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
    /// Should the Dapr sidecar to continue initialisation if the component fails to load. Defaults to `false`
    /// </summary>
    public TerraformProperty<bool> IgnoreErrors
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("ignore_errors");
        set => SetProperty("ignore_errors", value);
    }

    /// <summary>
    /// The component initialisation timeout in ISO8601 format. e.g. `5s`, `2h`, `1m`. Defaults to `5s`.
    /// </summary>
    public TerraformProperty<string> InitTimeout
    {
        get => GetRequiredOutput<TerraformProperty<string>>("init_timeout");
        set => SetProperty("init_timeout", value);
    }

    /// <summary>
    /// The name for this Dapr Component.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// A list of scopes to which this component applies. e.g. a Container App&#39;s `dapr.app_id` value.
    /// </summary>
    public List<TerraformProperty<string>> Scopes
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("scopes");
        set => SetProperty("scopes", value);
    }

    /// <summary>
    /// The version of the component.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version");
        set => SetProperty("version", value);
    }

    /// <summary>
    /// Block for metadata.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermContainerAppEnvironmentDaprComponentMetadataBlock>? Metadata
    {
        set => SetProperty("metadata", value);
    }

    /// <summary>
    /// Block for secret.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermContainerAppEnvironmentDaprComponentSecretBlock>? Secret
    {
        set => SetProperty("secret", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermContainerAppEnvironmentDaprComponentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
