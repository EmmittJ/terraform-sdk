using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for metadata in .
/// Nesting mode: list
/// </summary>
public partial class AzurermContainerAppEnvironmentDaprComponentMetadataBlock : TerraformBlockBase
{
    /// <summary>
    /// The name of the Metadata configuration item.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name of a secret specified in the `secrets` block that contains the value for this metadata configuration item.
    /// </summary>
    [TerraformProperty("secret_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SecretName { get; set; }

    /// <summary>
    /// The value for this metadata configuration item.
    /// </summary>
    [TerraformProperty("value")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Block type for secret in .
/// Nesting mode: set
/// </summary>
public partial class AzurermContainerAppEnvironmentDaprComponentSecretBlock : TerraformBlockBase
{
    /// <summary>
    /// The identity to use for accessing key vault reference.
    /// </summary>
    [TerraformProperty("identity")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Identity { get; set; }

    /// <summary>
    /// The Key Vault Secret ID. Could be either one of `id` or `versionless_id`.
    /// </summary>
    [TerraformProperty("key_vault_secret_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KeyVaultSecretId { get; set; }

    /// <summary>
    /// The secret name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The value for this secret.
    /// </summary>
    [TerraformProperty("value")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermContainerAppEnvironmentDaprComponentTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_container_app_environment_dapr_component resource.
/// </summary>
public partial class AzurermContainerAppEnvironmentDaprComponent : TerraformResource
{
    public AzurermContainerAppEnvironmentDaprComponent(string name) : base("azurerm_container_app_environment_dapr_component", name)
    {
    }

    /// <summary>
    /// The Dapr Component Type. For example `state.azure.blobstorage`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComponentType is required")]
    [TerraformProperty("component_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ComponentType { get; set; }

    /// <summary>
    /// The Container App Managed Environment ID to configure this Dapr component on.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerAppEnvironmentId is required")]
    [TerraformProperty("container_app_environment_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ContainerAppEnvironmentId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Should the Dapr sidecar to continue initialisation if the component fails to load. Defaults to `false`
    /// </summary>
    [TerraformProperty("ignore_errors")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IgnoreErrors { get; set; }

    /// <summary>
    /// The component initialisation timeout in ISO8601 format. e.g. `5s`, `2h`, `1m`. Defaults to `5s`.
    /// </summary>
    [TerraformProperty("init_timeout")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? InitTimeout { get; set; }

    /// <summary>
    /// The name for this Dapr Component.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// A list of scopes to which this component applies. e.g. a Container App&#39;s `dapr.app_id` value.
    /// </summary>
    [TerraformProperty("scopes")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Scopes { get; set; }

    /// <summary>
    /// The version of the component.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformProperty("version")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Version { get; set; }

    /// <summary>
    /// Block for metadata.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("metadata")]
    public TerraformList<TerraformBlock<AzurermContainerAppEnvironmentDaprComponentMetadataBlock>>? Metadata { get; set; }

    /// <summary>
    /// Block for secret.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("secret")]
    public TerraformSet<TerraformBlock<AzurermContainerAppEnvironmentDaprComponentSecretBlock>>? Secret { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermContainerAppEnvironmentDaprComponentTimeoutsBlock>? Timeouts { get; set; }

}
